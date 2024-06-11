#include "CImg.h"
using namespace cimg_library;

/*---------------------------

Main procedure

--------------------------*/

int main() {
	CImg<unsigned char> board(8,10,1,1,0),
		background = CImg<unsigned char>(board.dimx()*32,board.dimy()*16+200,1,3,0).noise(20,1).draw_plasma().blur(1,8,0),
		visu0(background/2), visu(visu0), brick(16,16,1,1,200), racket(64,8,1,3,0), ball(8,8,1,3,0);

	const unsigned char white[3] = { 255,255,255 }, green1[3] = { 60,150,30 }, green2[3] = { 130,255,130 };
	{ cimg_for_borderXY(brick,x,y,1) brick(x,y) = x>y?255:128; }

	{ cimg_for_insideXY(brick,x,y,1) brick(x,y) = cimg::min(255,64+8*(x+y)); }

	brick.resize(31,15,1,1,1).resize(32,16,1,1,0);
	ball.draw_circle(4,4,3,white); ball-=ball.get_erode(3)/1.5f;

	racket.draw_circle(4,3,3.7f,green1).draw_circle(3,2,1.8f,green2);

	{ cimg_forY(racket,y) racket.draw_rectangle(4,y,racket.dimx()-7,y,CImg<unsigned char>::vector(y*4,255-y*32,255-y*25).ptr()); }
	racket.draw_image(racket.get_crop(0,0,racket.dimx()/2-1,racket.dimy()-1).mirror('x'),racket.dimx()/2,0);

	const int w = visu.dimx(), h = visu.dimy(), w2 = w/2, h2 = h/2, bw = ball.dimx(), bh = ball.dimy(), bw2 = bw/2, bh2 = bh/2,
		rw = racket.dimx(), rh = racket.dimy(), rw2 = rw/2;

	float xr = (float)(w-rw2), oxr = (float)xr, xb = 0, yb = 0, oxb = 0, oyb = 0, vxb = 0, vyb = 0;

	CImgDisplay disp(visu,"CImg Breakout",0); disp.move((CImgDisplay::screen_dimx()-w)/2,(CImgDisplay::screen_dimy()-h)/2);

	for (unsigned int N=0, N0=0; !disp.is_closed && disp.key!=cimg::keyESC && disp.key!=cimg::keyQ; ) {
		if (N0) {
			int X = (int)xr;
			if (disp.mouse_x>=0) X = (int)(w2+((disp.mouse_x<0?w2:disp.mouse_x)-w2)*2); else disp.set_mouse(xr>w2?w-81:80,h2);
			if (X<rw2) { X = rw2; disp.set_mouse(80,h2); }
			if (X>=w-rw2) { X = w-rw2-1; disp.set_mouse(w-81,h2); }
			oxr = xr; xr = (float)X; oxb = xb; oyb = yb; xb+=vxb; yb+=vyb;
			if ((xb>=w-bw2) || (xb<bw2)) { xb-=vxb; yb-=vyb; vxb=-vxb; }
			if (yb<bh2) { yb = (float)bh2; vyb=-vyb; }
			if (yb>=h-rh-8-bh2 && yb<h-8-bh2 && xr-rw2<=xb && xr+rw2>=xb) {
				xb = oxb; yb = h-rh-8.0f-bh2; vyb=-vyb; vxb+=(xr-oxr)/4;
				if (cimg::abs(vxb)>8) vxb*=8/cimg::abs(vxb);
			}
			if (yb<board.dimy()*16) {
				const int X = (int)xb/32, Y = (int)yb/16;
				if (board(X,Y)) {
					N++; board(X,Y) = 0;
					const unsigned int x0 = X*brick.dimx(), y0 = Y*brick.dimy(), x1 = (X+1)*brick.dimx()-1, y1 = (Y+1)*brick.dimy()-1;
					visu0.draw_image(background.get_crop(x0,y0,x1,y1),x0,y0);
					if (oxb<(X<<5) || oxb>=((X+1)<<5)) vxb=-vxb; else if (oyb<(Y<<4) || oyb>=((Y+1)<<4)) vyb=-vyb;
				}}			
			disp.set_title("Score : %u/%u",N,N0);
		}
		if (yb>h || N==N0) {
			disp.show_mouse();
			while (!disp.key && !disp.is_closed && !disp.button) {
				((visu=visu0)/=2).draw_text(N0?"Game Over !":"Get Ready ?",50,visu.dimy()/2-10,white,0,25).
					display(disp);
				disp.wait();
				if (disp.is_resized) disp.resize(disp);
			}
			board.fill(0); visu0 = background;
			cimg_forXY(board,x,y) if (0.2f+cimg::crand()>=0) {
				CImg<> cbrick = CImg<double>::vector(100+cimg::rand()*155,100+cimg::rand()*155,100+cimg::rand()*155).
					unroll('v').resize(brick.dimx(),brick.dimy());
				cimg_forV(cbrick,k) (cbrick.get_shared_channel(k).mul(brick))/=255;
				visu0.draw_image(cbrick,x*32,y*16);
				board(x,y) = 1;
			}
			N0 = (int)board.sum(); N = 0; oxb = xb = (float)w2; oyb = yb = board.dimy()*16.0f+bh; vxb = 2.0f; vyb = 3.0f;
			disp.hide_mouse();
		} else disp.display((visu=visu0).draw_image(racket,(int)(xr-rw2),h-rh-8).draw_image(ball,(int)(xb-bw2),(int)(yb-bh2)));
		if (disp.wait(20).is_resized) disp.resize(disp);
	}	
  return 0;
}
