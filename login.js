#pragma strict
var myskin:GUISkin;
var generalwidth=20;
var loaderHeight=10;
var loaderWidth=10;
var logHeight=10;
var logWidth=10;
var playerUserName=" ";
var PlayerPasswords=" ";
var UserHeight=1;
var PassHeight=1;
var GameOwner ="";
var GamePassword = "";
var Usernamecorrect=false;
var Passwordcorrect=false;
function Start () {

}

function Update () {
if(playerUserName == GameOwner){
  Usernamecorrect=true;
 }
 else{
 Usernamecorrect=false;
 }
 if(PlayerPasswords == GamePassword ){
 Passwordcorrect=true;
 }
 else{
 Passwordcorrect=false;
 }
}
function OnGUI(){
GUI.skin = myskin;
//background

GUI.Box(Rect(loaderHeight, loaderWidth, 220, 120), "Log in");
//text area
playerUserName=GUI.TextArea(Rect(generalwidth,UserHeight, 100, 20),playerUserName);
PlayerPasswords=GUI.TextArea(Rect(generalwidth,PassHeight, 100, 20),PlayerPasswords);

if(GUI.Button(Rect(logHeight, logWidth, 60, 20),"Log in")){
if(Usernamecorrect==true){
if(Passwordcorrect==true){
Application.LoadLevel(0);	
	}
 }
}
}