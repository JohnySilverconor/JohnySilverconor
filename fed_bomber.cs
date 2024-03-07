using System;

namespace SpaceshipExplosion
{
    public class Explosion
    {
        public class Gib
        {
            public double VelocityMin { get; set; }
            public double VelocityMax { get; set; }
            public double DirectionMin { get; set; }
            public double DirectionMax { get; set; }
            public double AngularMin { get; set; }
            public double AngularMax { get; set; }
            public int GlowOffsetX { get; set; }
            public int GlowOffsetY { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
        }

        public class WeaponMount
        {
            public int X { get; set; }
            public int Y { get; set; }
            public bool Rotate { get; set; }
            public bool Mirror { get; set; }
            public int Gib { get; set; }
            public string Slide { get; set; }
        }

        public class ExplosionSettings
        {
            public Gib Gib1 { get; set; }
            public Gib Gib2 { get; set; }
            public Gib Gib3 { get; set; }
            public Gib Gib4 { get; set; }
        }

        public class FTL
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int GlowOffsetX { get; set; }
            public int GlowOffsetY { get; set; }
            public Offset Cloak { get; set; }
            public List<WeaponMount> WeaponMounts { get; set; }
            public ExplosionSettings Explosion { get; set; }
        }

        public class Offset
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        public static void Main(string[] args)
        {
            // Your spaceship explosion logic here...
        }
    }
}

//xml
<?xml version="1.0" encoding="utf-8"?>
<FTL>

<!-- +33 +169-->
<img x="-46" y="-38" w="372" h="356"/>

<!-- Only used for iPad -->
<glowOffset x="26" y="28"/>

<offsets>
	<cloak x="18" y="20"/>
</offsets>

<weaponMounts>
	<mount x="126" y="65" rotate="false" mirror="true" gib="3" slide="left"/>
	<mount x="246" y="65" rotate="false" mirror="false" gib="3" slide="right"/>
	<mount x="48" y="160" rotate="false" mirror="true" gib="1" slide="left"/>
	<mount x="324" y="160" rotate="false" mirror="false" gib="3" slide="right"/>
</weaponMounts>


<!--  Bad Combos:;  -->
<explosion>
	<gib1>
		<velocity min="0.4" max="1"/>
		<direction min="70" max="90"/>
		<angular min="-1" max="1"/>
		<glowOffset x="26" y="28"/> <!-- individual setting - only for ipad - not needed -->
		<x>0</x>
		<y>65</y>
	</gib1>
	<gib2>
		<velocity min="0.3" max="0.7"/>
		<direction min="220" max="240"/>
		<angular min="-0.4" max="0.4"/>
		<glowOffset x="47" y="42"/> <!-- individual setting - only for ipad - not needed -->
		<x>166</x>
		<y>129</y>
	</gib2>
	<gib3>
		<velocity min="0.2" max="0.4"/>
		<direction min="290" max="0"/>
		<angular min="-0.4" max="1"/>
		<glowOffset x="22" y="28"/> <!-- individual setting - only for ipad - not needed -->
		<x>77</x>
		<y>0</y>
	</gib3>
	<gib4>
		<velocity min="0.1" max="0.3"/>
		<direction min="-160" max="180"/>
		<angular min="-0.5" max="0.5"/>
		<glowOffset x="23" y="26"/> <!-- individual setting - only for ipad - not needed -->
		<x>36</x>
		<y>104</y>
	</gib4>
</explosion>
</FTL>
