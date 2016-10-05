using System;
using System.Collections.Generic;

namespace Jass {

	public class War3mapJ {

		private JassArray<string> h = new JassArray<string>();
		private int o;
		private float A;
		private float B;
		private JassArray<float> C = new JassArray<float>();
		private JassArray<float> D = new JassArray<float>();
		private JassArray<float> E = new JassArray<float>();
		private JassArray<float> F = new JassArray<float>();
		private JassArray<float> G = new JassArray<float>();
		private float H;
		private float I;
		private float J;
		private int K;
		private timer L;
		private JassArray<item> M = new JassArray<item>();
		private int N;
		private code O;
		private float P;
		private JassArray<int> Q = new JassArray<int>();
		private timer R = CreateTimer();
		private JassArray<unit> S = new JassArray<unit>();
		private JassArray<float> T = new JassArray<float>();
		private JassArray<float> U = new JassArray<float>();
		private JassArray<int> V = new JassArray<int>();
		private int W = 0;
		private boolexpr X;
		private timer Y;
		private bool Z = false;
		private int d4;
		private JassArray<int> e4 = new JassArray<int>();
		private JassArray<int> f4 = new JassArray<int>();
		private JassArray<int> g4 = new JassArray<int>();
		private JassArray<int> h4 = new JassArray<int>();
		private JassArray<int> i4 = new JassArray<int>();
		private JassArray<int> j4 = new JassArray<int>();
		private JassArray<int> k4 = new JassArray<int>();
		private JassArray<float> m4 = new JassArray<float>();
		private JassArray<float> n4 = new JassArray<float>();
		private float o4;
		private float p4;
		private group q4 = CreateGroup();
		private player r4;
		private JassArray<int> t4 = new JassArray<int>();
		private JassArray<float> u4 = new JassArray<float>();
		private JassArray<bool> v4 = new JassArray<bool>();
		private JassArray<bool> w4 = new JassArray<bool>();
		private JassArray<int> x4 = new JassArray<int>();
		private JassArray<trigger> y4 = new JassArray<trigger>();
		private unit z4;
		private JassArray<float> A4 = new JassArray<float>();
		private JassArray<trigger> a4 = new JassArray<trigger>();
		private unit B4;
		private JassArray<trigger> b4 = new JassArray<trigger>();
		private JassArray<int> C4 = new JassArray<int>();
		private unit c4;
		private unit D4;
		private JassArray<string> E4 = new JassArray<string>();
		private int F4 = 0;
		private int G4 = 0;
		private int H4 = 0;
		private int I4 = $C8;
		private bool l4 = true;
		private JassArray<bool> J4 = new JassArray<bool>();
		private timer K4 = CreateTimer();
		private JassArray<unit> L4 = new JassArray<unit>();
		private JassArray<float> M4 = new JassArray<float>();
		private JassArray<float> N4 = new JassArray<float>();
		private JassArray<int> O4 = new JassArray<int>();
		private JassArray<float> P4 = new JassArray<float>();
		private int Q4 = 0;
		private bool R4 = false;
		private boolexpr S4;
		private player T4 = null;
		private force U4 = CreateForce();
		private trigger V4 = CreateTrigger();
		private int W4;
		private int X4;
		private timer Y4 = CreateTimer();
		private JassArray<unit> Z4 = new JassArray<unit>();
		private JassArray<float> d7 = new JassArray<float>();
		private JassArray<int> e7 = new JassArray<int>();
		private JassArray<int> f7 = new JassArray<int>();
		private JassArray<unit> g7 = new JassArray<unit>();
		private JassArray<float> h7 = new JassArray<float>();
		private JassArray<bool> i7 = new JassArray<bool>();
		private int j7 = 0;
		private boolexpr k7;
		private int m7 = StringLength("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~");
		private JassArray<string> n7 = new JassArray<string>();
		private JassArray<string> o7 = new JassArray<string>();
		private JassArray<string> p7 = new JassArray<string>();
		private JassArray<string> q7 = new JassArray<string>();
		private JassArray<string> r7 = new JassArray<string>();
		private bool s7 = false;
		private gamecache t7 = null;
		private int u7 = 1;
		private int v7 = 0;
		private timer w7 = CreateTimer();
		private int x7 = 0;
		private int y7 = 0;
		private player z7 = Player($F);
		private timer A7 = CreateTimer();
		private JassArray<destructable> a7 = new JassArray<destructable>();
		private JassArray<unit> B7 = new JassArray<unit>();
		private bool b7 = false;
		private trigger C7 = null;
		private int c7 = 0;
		private JassArray<int> D7 = new JassArray<int>();
		private JassArray<int> E7 = new JassArray<int>();
		private JassArray<string> F7 = new JassArray<string>();
		private JassArray<int> G7 = new JassArray<int>();
		private JassArray<sound> H7 = new JassArray<sound>();
		private JassArray<bool> I7 = new JassArray<bool>();
		private int l7 = 0;
		private trigger J7 = CreateTrigger();
		private JassArray<int> K7 = new JassArray<int>();
		private timer L7 = null;
		private JassArray<timer> M7 = new JassArray<timer>();
		private JassArray<timer> N7 = new JassArray<timer>();
		private JassArray<timerdialog> O7 = new JassArray<timerdialog>();
		private JassArray<float> P7 = new JassArray<float>();
		private JassArray<int> Q7 = new JassArray<int>();
		private JassArray<string> R7 = new JassArray<string>();
		private JassArray<location> S7 = new JassArray<location>();
		private JassArray<bool> T7 = new JassArray<bool>();
		private trigger U7 = CreateTrigger();
		private bool V7 = false;
		private float W7;
		private float X7;
		private float Y7;
		private float Z7;
		private JassArray<unit> d8 = new JassArray<unit>();
		private int e8;
		private sound g8 = CreateSoundFromLabel("InterfaceError",false,false,false,$A,$A);
		private bool h8 = true;
		private JassArray<float> i8 = new JassArray<float>();
		private JassArray<playercolor> j8 = new JassArray<playercolor>();
		private playercolor k8 = GetPlayerColor(Player($F));
		private bool m8 = false;
		private region n8;
		private region o8;
		private int p8;
		private int q8;
		private trigger r8;
		private trigger s8;
		private unit t8;
		private unit u8;
		private JassArray<int> v8 = new JassArray<int>();
		private int w8;
		private int x8 = 'A0D1';
		private int y8 = 'A0D0';
		private int z8 = 'A0E3';
		private JassArray<int> A8 = new JassArray<int>();
		private JassArray<int> a8 = new JassArray<int>();
		private boolexpr B8;
		private bool b8;
		private JassArray<int> C8 = new JassArray<int>();
		private int c8;
		private bool D8;
		private boolexpr E8;
		private JassArray<unit> F8 = new JassArray<unit>();
		private JassArray<unit> G8 = new JassArray<unit>();
		private int H8;
		private JassArray<int> I8 = new JassArray<int>();
		private int l8;
		private boolexpr J8;
		private boolexpr K8;
		private JassArray<unit> L8 = new JassArray<unit>();
		private JassArray<bool> M8 = new JassArray<bool>();
		private JassArray<float> N8 = new JassArray<float>();
		private JassArray<float> O8 = new JassArray<float>();
		private boolexpr P8;
		private boolexpr Q8;
		private boolexpr R8;
		private boolexpr S8;
		private boolexpr T8;
		private JassArray<unit> U8 = new JassArray<unit>();
		private JassArray<float> V8 = new JassArray<float>();
		private JassArray<float> W8 = new JassArray<float>();
		private JassArray<timer> X8 = new JassArray<timer>();
		private int Y8 = 0;
		private code Z8;
		private trigger d9 = CreateTrigger();
		private player e9;
		private int f9;
		private int g9;
		private group h9;
		private hashtable i9 = InitHashtable();
		private int j9;
		private int k9;
		private int m9;
		private int n9;
		private int o9;
		private int p9;
		private int q9;
		private int r9;
		private int s9;
		private int t9;
		private int u9;
		private int v9;
		private int w9;
		private boolexpr x9;
		private boolexpr y9;
		private group z9 = CreateGroup();
		private boolexpr A9;
		private timer a9 = CreateTimer();
		private timer B9 = CreateTimer();
		private boolexpr b9;
		private rect C9;
		private bool c9 = false;
		private JassArray<multiboard> D9 = new JassArray<multiboard>();
		private JassArray<multiboard> E9 = new JassArray<multiboard>();
		private JassArray<int> F9 = new JassArray<int>();
		private multiboard G9 = null;
		private JassArray<int> H9 = new JassArray<int>();
		private int I9 = 0;
		private JassArray<string> l9 = new JassArray<string>();
		private multiboarditem J9;
		private int K9 = 0;
		private timer L9 = CreateTimer();
		private int M9;
		private int N9;
		private hashtable O9 = InitHashtable();
		private group P9 = CreateGroup();
		private rect Q9;
		private location R9;
		private bool S9 = true;
		private bool T9 = false;
		private bool U9 = false;
		private string V9;
		private int W9 = $FA;
		private int X9 = '}';
		private int Y9 = 1;
		private int Z9 = -1;
		private int dd = 0;
		private int ed = 0;
		private int fd = 2;
		private int gd = -1;
		private int hd = $A;
		private bool jd;
		private bool kd = false;
		private bool md = false;
		private bool nd = false;
		private bool od = false;
		private bool pd = true;
		private bool qd = true;
		private bool rd = true;
		private bool sd = true;
		private bool td = false;
		private bool ud = true;
		private bool vd = false;
		private bool wd = false;
		private bool xd = false;
		private bool yd = true;
		private bool zd = false;
		private int Ad = 0;
		private int ad = -1;
		private int Bd = 0;
		private int bd = 0;
		private int Cd = 0;
		private int cd = 0;
		private int Dd = 0;
		private int Ed = 0;
		private int Fd = 0;
		private JassArray<bool> Gd = new JassArray<bool>();
		private JassArray<int> Hd = new JassArray<int>();
		private JassArray<location> Id = new JassArray<location>();
		private JassArray<int> ld = new JassArray<int>();
		private JassArray<group> Jd = new JassArray<group>();
		private JassArray<int> Kd = new JassArray<int>();
		private JassArray<rect> Ld = new JassArray<rect>();
		private JassArray<int> Md = new JassArray<int>();
		private JassArray<int> Nd = new JassArray<int>();
		private JassArray<string> Od = new JassArray<string>();
		private JassArray<int> Pd = new JassArray<int>();
		private JassArray<location> Qd = new JassArray<location>();
		private JassArray<int> Rd = new JassArray<int>();
		private JassArray<int> Sd = new JassArray<int>();
		private JassArray<int> Td = new JassArray<int>();
		private JassArray<int> Ud = new JassArray<int>();
		private JassArray<int> Vd = new JassArray<int>();
		private JassArray<int> Wd = new JassArray<int>();
		private JassArray<int> Xd = new JassArray<int>();
		private JassArray<int> Yd = new JassArray<int>();
		private JassArray<int> Zd = new JassArray<int>();
		private JassArray<int> de = new JassArray<int>();
		private JassArray<int> ee = new JassArray<int>();
		private JassArray<int> fe = new JassArray<int>();
		private JassArray<int> ge = new JassArray<int>();
		private JassArray<int> he = new JassArray<int>();
		private force ie = CreateForce();
		private force je = CreateForce();
		private force ke = CreateForce();
		private JassArray<int> me = new JassArray<int>();
		private JassArray<force> ne = new JassArray<force>();
		private JassArray<unit> oe = new JassArray<unit>();
		private JassArray<string> pe = new JassArray<string>();
		private JassArray<bool> qe = new JassArray<bool>();
		private int re = 0;
		private timer se;
		private JassArray<int> te = new JassArray<int>();
		private JassArray<float> ue = new JassArray<float>();
		private JassArray<int> ve = new JassArray<int>();
		private JassArray<int> xe = new JassArray<int>();
		private JassArray<int> ye = new JassArray<int>();
		private JassArray<bool> ze = new JassArray<bool>();
		private JassArray<float> Ae = new JassArray<float>();
		private JassArray<unit> ae = new JassArray<unit>();
		private JassArray<bool> Be = new JassArray<bool>();
		private JassArray<unit> be = new JassArray<unit>();
		private JassArray<force> Ce = new JassArray<force>();
		private JassArray<timer> ce = new JassArray<timer>();
		private JassArray<bool> De = new JassArray<bool>();
		private JassArray<player> Ee = new JassArray<player>();
		private bool Fe = true;
		private bool Ge = false;
		private int He = 7-1;
		private JassArray<int> Ie = new JassArray<int>();
		private boolexpr le;
		private int Je;
		private int Ke;
		private int Le;
		private int Me;
		private int Ne;
		private int Oe;
		private int Pe;
		private int Qe;
		private int Re;
		private int Se;
		private int Te;
		private int Ue;
		private JassArray<int> Ve = new JassArray<int>();
		private int We = 'A01I';
		private int Xe;
		private boolexpr Ye;
		private boolexpr Ze;
		private int df = 'n01C';
		private boolexpr ef;
		private group ff = CreateGroup();
		private boolexpr gf;
		private boolexpr hf;
		private timer jf = CreateTimer();
		private float kf = 25.;
		private JassArray<float> mf = new JassArray<float>();
		private JassArray<int> nf = new JassArray<int>();
		private string of;
		private JassArray<float> pf = new JassArray<float>();
		private int qf;
		private group rf = CreateGroup();
		private boolexpr sf;
		private boolexpr tf;
		private boolexpr uf;
		private int vf = 'A0BD';
		private weathereffect wf;
		private boolexpr xf;
		private boolexpr yf;
		private int zf = 'A07T';
		private group Af = CreateGroup();
		private boolexpr af;
		private JassArray<int> Bf = new JassArray<int>();
		private trigger bf = CreateTrigger();
		private boolexpr Cf;
		private boolexpr cf;
		private boolexpr Df;
		private timer Ef = CreateTimer();
		private JassArray<unit> Ff = new JassArray<unit>();
		private int Gf = 0;
		private weathereffect Hf;
		private float If;
		private float lf;
		private float Jf;
		private float Kf;
		private boolexpr Lf;
		private JassArray<int> Mf = new JassArray<int>();
		private trigger Nf = null;
		private bool Of;
		private bool Pf;
		private boolexpr Qf;
		private string Rf;
		private timer Sf = null;
		private trigger Tf = null;
		private JassArray<int> Uf = new JassArray<int>();
		private JassArray<int> Vf = new JassArray<int>();
		private timer Wf = null;
		private timer Xf = CreateTimer();
		private timerdialog Yf;
		private trigger Zf = CreateTrigger();
		private dialog dg = DialogCreate();
		private JassArray<button> eg = new JassArray<button>();
		private bool fg = false;
		private bool gg = false;
		private trigger hg;
		private trigger ig;
		private trigger jg;
		private boolexpr kg;
		private int mg = 0;
		private timer ng = CreateTimer();
		private timerdialog og = CreateTimerDialog(ng);
		private int pg = -1;
		private int qg;
		private JassArray<bool> rg = new JassArray<bool>();
		private bool sg = false;
		private string tg = null;
		private bool ug = false;
		private timer vg = CreateTimer();
		private bool wg = false;
		private int xg;
		private int yg;
		private trigger zg = CreateTrigger();
		private fogmodifier Ag;
		private fogmodifier ag;
		private int Bg = -1;
		private int bg;
		private trigger Cg;
		private rect cg = null;
		private rect Dg = null;
		private rect Eg = null;
		private rect Fg = null;
		private sound Gg = null;
		private sound Hg = null;
		private sound Ig = null;
		private sound lg = null;
		private sound Jg = null;
		private sound Kg = null;
		private sound Lg = null;
		private sound Mg = null;
		private sound Ng = null;
		private sound Og = null;
		private sound Pg = null;
		private sound Qg = null;
		private sound Rg = null;
		private sound Sg = null;
		private sound Tg = null;
		private sound Ug = null;
		private trigger Vg = null;
		private trigger Wg = null;
		private trigger Xg = null;
		private trigger Yg = null;
		private trigger Zg = null;
		private trigger dh = null;
		private trigger eh = null;
		private trigger fh = null;
		private trigger gh = null;
		private trigger hh = null;
		private trigger ih = null;
		private trigger jh = null;
		private trigger kh = null;
		private force mh;
		private bool nh = true;
		private boolexpr oh;
		private int ph = 0;
		private int qh = 0;
		private JassArray<int> rh = new JassArray<int>();
		private JassArray<float> sh = new JassArray<float>();
		private JassArray<string> th = new JassArray<string>();
		private JassArray<int> uh = new JassArray<int>();
		private JassArray<string> vh = new JassArray<string>();
		private JassArray<int> wh = new JassArray<int>();
		private int xh = 0;
		private int yh = 0;
		private JassArray<int> zh = new JassArray<int>();
		private JassArray<int> Ah = new JassArray<int>();
		private JassArray<trigger> ah = new JassArray<trigger>();
		private JassArray<trigger> Bh = new JassArray<trigger>();
		private int bh = 0;
		private int Ch = 0;
		private JassArray<int> Dh = new JassArray<int>();
		private JassArray<int> Eh = new JassArray<int>();
		private JassArray<int> Fh = new JassArray<int>();
		private JassArray<int> Gh = new JassArray<int>();
		private int Hh = 0;
		private int Ih = 0;
		private JassArray<int> lh = new JassArray<int>();
		private int Jh = 0;
		private int Kh = 0;
		private JassArray<int> Lh = new JassArray<int>();
		private int Mh = 0;
		private int Nh = 0;
		private JassArray<int> Oh = new JassArray<int>();
		private JassArray<int> Ph = new JassArray<int>();
		private JassArray<int> Qh = new JassArray<int>();
		private JassArray<int> Rh = new JassArray<int>();
		private int Sh = 0;
		private int Th = 0;
		private JassArray<int> Uh = new JassArray<int>();
		private JassArray<int> Vh = new JassArray<int>();
		private JassArray<int> Wh = new JassArray<int>();
		private JassArray<int> Xh = new JassArray<int>();
		private JassArray<int> Yh = new JassArray<int>();
		private JassArray<int> Zh = new JassArray<int>();
		private JassArray<int> di = new JassArray<int>();
		private JassArray<int> ei = new JassArray<int>();
		private JassArray<int> fi = new JassArray<int>();
		private trigger gi;
		private trigger hi;
		private unit ii;
		private int ji;
		private int ki;
		private bool mi;
		public static int GetUnitGoldCost(int unitid);
		public static int GetUnitWoodCost(int unitid);
		public static int GetUnitBuildTime(int unitid);
		public static int GetUpgradeLevel(int id);
		public static int GetUpgradeGoldCost(int id);
		public static int GetUpgradeWoodCost(int id);
		private int ni() {
			int oi = ph;
			if ((oi!=0)) {
				ph = rh[oi];
			} else {
				qh = qh+1;
				oi = qh;
			}
			if ((oi>8190)) {
				return 0;
			}
			wh[oi] = 0;
			rh[oi] = -1;
			return oi;
		}
		private int pi() {
			int oi = Sh;
			if ((oi!=0)) {
				Sh = Uh[oi];
			} else {
				Th = Th+1;
				oi = Th;
			}
			if ((oi>$CB)) {
				return 0;
			}
			Wh[oi] = (oi-1)*40;
			Yh[oi] = (oi-1)*7;
			di[oi] = (oi-1)*16;
			fi[oi] = (oi-1)*4;
			Uh[oi] = -1;
			return oi;
		}
		private int qi() {
			int oi = Mh;
			if ((oi!=0)) {
				Mh = Oh[oi];
			} else {
				Nh = Nh+1;
				oi = Nh;
			}
			if ((oi>$7FE)) {
				return 0;
			}
			Qh[oi] = (oi-1)*4;
			Oh[oi] = -1;
			return oi;
		}
		private int ri() {
			int oi = Jh;
			if ((oi!=0)) {
				Jh = Lh[oi];
			} else {
				Kh = Kh+1;
				oi = Kh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Lh[oi] = -1;
			return oi;
		}
		private int si() {
			int oi = Hh;
			if ((oi!=0)) {
				Hh = lh[oi];
			} else {
				Ih = Ih+1;
				oi = Ih;
			}
			if ((oi>8190)) {
				return 0;
			}
			lh[oi] = -1;
			return oi;
		}
		private bool ti(int oi, unit u) {
			ki = oi;
			ii = u;
			TriggerEvaluate(Bh[Ah[oi]]);
			return mi;
		}
		private int ui() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = 16;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int wi() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = $F;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int xi() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = $E;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int yi() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = $D;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int zi() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = $C;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int Ai() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = $B;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int Bi() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = $A;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int Ci() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = 9;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int ci() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = 8;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int Di() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = 7;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int Ei() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = 6;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private int Fi() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = 5;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private void Gi(int oi, int Hi) {
			Eh[Fh[oi]+Gh[oi]] = Hi;
			Gh[oi] = Gh[oi]+1;
		}
		private int Ii() {
			int oi = bh;
			if ((oi!=0)) {
				bh = Dh[oi];
			} else {
				Ch = Ch+1;
				oi = Ch;
			}
			if ((oi>510)) {
				return 0;
			}
			Fh[oi] = (oi-1)*16;
			Dh[oi] = -1;
			return oi;
		}
		private void li(int oi) {
			if (oi==null ) {
				return;
			} else if ((Dh[oi]!=-1)) {
				return;
			}
			Dh[oi] = bh;
			bh = oi;
		}
		private int Ji() {
			int vi;
			int oi = xh;
			if ((oi!=0)) {
				xh = zh[oi];
			} else {
				yh = yh+1;
				oi = yh;
			}
			if ((oi>8190)) {
				return 0;
			}
			Ah[oi] = 17;
			vi = oi;
			zh[oi] = -1;
			return oi;
		}
		private string Ki() {
			int i = GetRandomInt(0,o);
			string s = h[i];
			h[i] = h[o];
			o = o-1;
			return s;
		}
		private void Li() {
			h[0] = "General";
			h[1] = "FanToMace";
			h[2] = "antiPOD";
			h[3] = "ADMIN";
			h[4] = "Ms Weapon";
			h[5] = "C|c00ff008000l";
			h[6] = "O|c00ff00ff:";
			h[7] = ":|c00ff8040O";
			h[8] = "INqUSitor";
			h[9] = "Your_Death";
			h[$A] = "Nan Yanoi";
			h[$B] = "Impale";
			h[$C] = "Proxima";
			h[$D] = "13|c00ff0000th";
			h[$E] = "Mariana";
			h[$F] = "ProFan";
			h[16] = "Active";
			h[17] = "Master";
			h[18] = "Nice Guy";
			h[19] = "Kasr'Kin";
			h[20] = "Pr0[tag]on1st";
			h[21] = "Imperor";
			h[22] = "FBI agent :)";
			h[23] = "Spell";
			h[24] = "WTFG0D";
			h[25] = "Leaver :P";
			h[26] = "Your Windows";
			h[27] = "GreatWarrior";
			h[28] = "ShadowOfFlame";
			h[29] = "No_Ob";
			h[30] = "Shurf";
			h[31] = "I am WH :'(";
			h[32] = "CriticalError";
			h[33] = "Brain";
			h[34] = "L|c0000ff40ord";
			h[35] = "Princess";
			o = 35;
		}
		private void Mi() {
			int i = 0;
			if ((md)) {
				H = 128.;
			} else {
				H = 128.*2.;
			}
			F[0] = -1.*H;
			G[0] = 1.*H;
			F[1] = -1.*H;
			G[1] = -1.*H;
			F[2] = 1.*H;
			G[2] = -1.*H;
			F[3] = 1.*H;
			G[3] = 1.*H;
			D[0] = 5568.;
			E[0] = 512.;
			D[1] = 5568.;
			E[1] = -1.*512.;
			D[2] = -1.*5568.;
			E[2] = -1.*512.;
			D[3] = -1.*5568.;
			E[3] = 512.;
			while (true) {
				C[i] = E[i];
				i = i+1;
				if (i>3) { break; }
			}
		}
		private void Ni() {
			int i = 0;
			H = 128.;
			F[0] = -1.*H;
			G[0] = 1.*H;
			F[1] = -1.*H;
			G[1] = -1.*H;
			F[2] = 1.*H;
			G[2] = -1.*H;
			F[3] = 1.*H;
			G[3] = 1.*H;
			D[0] = 5568.;
			E[0] = 512.;
			D[1] = 5568.;
			E[1] = -1.*512.;
			D[2] = -1.*5568.;
			E[2] = -1.*512.;
			D[3] = -1.*5568.;
			E[3] = 512.;
			while (true) {
				C[i] = E[i];
				i = i+1;
				if (i>3) { break; }
			}
		}
		private void Oi(int Pi) {
			A = D[Pi];
			B = E[Pi];
		}
		private void Qi(int Pi) {
			E[Pi] = E[Pi]+(G[Pi]);
			if ((RAbsBJ(E[Pi])>1920.)) {
				D[Pi] = D[Pi]+(F[Pi]);
				if ((RAbsBJ(D[Pi])<1664.)) {
					Ni();
					return;
				}
				E[Pi] = C[Pi];
			}
		}
		private void Ri() {
			unit u = GetEnumUnit();
			I = I+(GetUnitX(u));
			J = J+(GetUnitY(u));
			K = K+1;
			u = null;
		}
		private bool Si(unit Ti, unit Ui) {
			r4 = GetOwningPlayer(Ui);
			if ((IsPlayerInForce(r4,ie))) {
				DisplayTextToForce(ie, pe[GetPlayerId(GetOwningPlayer(Ti))]+": I'm going to use RS!!!");
			} else if ((IsPlayerInForce(r4,je))) {
				DisplayTextToForce(je, pe[GetPlayerId(GetOwningPlayer(Ti))]+": I'm going to use RS!!!");
			}
			GroupEnumUnitsInRange(q4, GetUnitX(Ui), GetUnitY(Ui), 1690.1, y9);
			I = .0;
			J = .0;
			K = 0;
			ForGroup(q4, function Ri);
			if ((K!=0)) {
				I = I/(K);
				J = J/(K);
				return IssuePointOrderById(Ti,$D0208,I,J);
			}
			return false;
		}
		private void Vi() {
			int i = 0;
			while (true) {
				RemoveItem(M[i]);
				i = i+1;
				if (i>=N) { break; }
			}
			TimerStart(L, 31.25, false, O);
		}
		private void Wi() {
			int i = 0;
			P = P+(3.);
			while (true) {
				M[i] = CreateItem('I000',GetRandomReal(GetRectMinX(Dg),GetRectMaxX(Dg)),GetRandomReal(GetRectMinY(Dg),GetRectMaxY(Dg)));
				DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Demon\\DarkPortal\\DarkPortalTarget.mdl", GetItemX(M[i]), GetItemY(M[i])));
				M[i+1] = CreateItem('I000',GetRandomReal(GetRectMinX(cg),GetRectMaxX(cg)),GetRandomReal(GetRectMinY(cg),GetRectMaxY(cg)));
				DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Demon\\DarkPortal\\DarkPortalTarget.mdl", GetItemX(M[i+1]), GetItemY(M[i+1])));
				i = i+(2);
				if (i>=N) { break; }
			}
			TimerStart(L, 4.75, false, function Vi);
		}
		private void Xi() {
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffFFFF80Bounty incoming!|r");
			TimerStart(L, 4., false, function Wi);
		}
		private void Yi(player p) {
			int id = GetPlayerId(p);
			int Zi = R2I((I2R(ge[id])+4.)*.25*(8.+P));
			Yd[id] = Yd[id]+1;
			DisplayTextToPlayer(p, .0, .0, "|cffFFFF80You found |cffFFFF00"+I2S(Zi)+"|cffFFFF80 gold!|r");
			Zd[id] = Zd[id]+(Zi);
			AdjustPlayerStateBJ(Zi, p, PLAYER_STATE_RESOURCE_GOLD);
		}
		private void dj(bool ej) {
			if ((L==null)) {
				return;
			}
			PauseTimer(L);
			if ((ej)) {
				DestroyTimer(L);
				L = null;
			}
		}
		private void fj() {
			int i = 0;
			if ((Cd<=0)) {
				return;
			}
			if ((L==null)) {
				L = CreateTimer();
				N = Cd*2;
			}
			P = .0;
			while (true) {
				Q[i] = -1;
				i = i+1;
				if (i>=4) { break; }
			}
			Q[4] = 0;
			Q[5] = 0;
			TimerStart(L, 40., false, function Xi);
		}
		private void gj() {
			L = null;
			O = function Xi;
		}
		private bool hj() {
			unit u = GetFilterUnit();
			bool b = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER);
			u = null;
			return b;
		}
		private void ij() {
			int i = 0;
			float x;
			float y;
			float an;
			unit u;
			unit j;
			while (true) {
				if (i>=W) { break; }
				an = GetUnitFacing(S[i])*bj_DEGTORAD;
				x = GetUnitX(S[i])+26.*Cos(an);
				y = GetUnitY(S[i])+26.*Sin(an);
				SetUnitX(S[i], x);
				SetUnitY(S[i], y);
				r4 = GetOwningPlayer(S[i]);
				GroupEnumUnitsInRange(q4, x, y, 34., X);
				u = FirstOfGroup(q4);
				if ((u!=null)) {
					UnitDamageTarget(S[i], u, U[i], true, false, ATTACK_TYPE_MAGIC, DAMAGE_TYPE_COLD, WEAPON_TYPE_WHOKNOWS);
					j = CreateUnit(GetOwningPlayer(S[i]),'e008',x,y,.0);
					UnitAddAbility(j, 'A043');
					SetUnitAbilityLevel(j, 'A043', V[i]);
					IssueTargetOrderById(j, $D0102, u);
					UnitApplyTimedLife(j, 'BTLF', 1.);
					j = null;
				}
				T[i] = T[i]-(26.);
				if ((T[i]<=.0 || u!=null)) {
					W = W-1;
					KillUnit(S[i]);
					S[i] = S[W];
					T[i] = T[W];
					V[i] = V[W];
					U[i] = U[W];
					u = null;
				} else {
					i = i+1;
				}
			}
			if ((W<=0)) {
				PauseTimer(R);
			}
		}
		private void jj(unit u, int kj, float mj, int nj) {
			player p = GetOwningPlayer(u);
			float an = GetUnitFacing(u)-45.;
			float oj = an+90.;
			float x = GetUnitX(u);
			float y = GetUnitY(u);
			int i = 0;
			while (true) {
				S[W] = CreateUnit(p,'h068',x,y,GetRandomReal(an,oj));
				T[W] = 500.;
				U[W] = mj;
				V[W] = nj;
				if ((W==0)) {
					TimerStart(R, .03, true, function ij);
				}
				W = W+1;
				i = i+1;
				TriggerSleepAction(.04);
				if (i>=kj) { break; }
			}
		}
		private void pj() {
			X = Filter(function hj);
		}
		private void qj() {
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Icy Environment|r has been selected. Note that a custom environment has no influence on gameplay.");
			h4[0] = 'Ibsq';
			h4[1] = 'Iice';
			h4[2] = 'Isnw';
			h4[3] = 'Idki';
			h4[4] = 'Nsnw';
			h4[5] = 'Nsnr';
			h4[6] = 'Irbk';
			h4[7] = 'Nsnw';
			i4[0] = 'ITtw';
			j4[0] = $A;
			i4[1] = 'ITtc';
			j4[1] = 3;
			k4[0] = 'B00M';
			n4[0] = .5;
			m4[0] = .0;
			k4[1] = 'B00N';
			n4[1] = .5;
			m4[1] = .0;
			k4[2] = 'B00O';
			n4[2] = .5;
			m4[2] = .0;
			k4[3] = 'B00P';
			n4[3] = .5;
			m4[3] = .0;
			k4[4] = 'B00G';
			n4[4] = .97;
			m4[4] = -30.;
			SetTerrainFogExBJ(0, 1200., 6000., 0, 80., 80., 100.);
		}
		private void rj() {
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Lava Environment|r has been selected. Note that a custom environment has no influence on gameplay.");
			h4[0] = 'Ddkr';
			h4[1] = 'Dgrs';
			h4[2] = 'Dlvc';
			h4[3] = 'Dlav';
			h4[4] = 'Drds';
			h4[5] = 'Ddrt';
			h4[6] = 'Dsqd';
			h4[7] = 'Dgrs';
			i4[0] = 'B001';
			j4[0] = 8;
			i4[1] = 'B000';
			j4[1] = $A;
			k4[0] = 'B00H';
			n4[0] = 1.1;
			m4[0] = .0;
			k4[1] = 'B00J';
			n4[1] = 1.1;
			m4[1] = .0;
			k4[2] = 'B00K';
			n4[2] = 1.1;
			m4[2] = .0;
			k4[3] = 'B00L';
			n4[3] = 1.1;
			m4[3] = .0;
			k4[4] = 'B00I';
			n4[4] = 1.;
			m4[4] = -70.;
			SetTerrainFogExBJ(0, $3E8, 3000., 0, 50., .0, .0);
			SetWaterBaseColorBJ('d', .0, .0, 0);
		}
		private void sj() {
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Icy Environment|r has been selected. Note that a custom environment has no influence on gameplay.");
			h4[0] = 'Ibsq';
			h4[1] = 'Iice';
			h4[2] = 'Isnw';
			h4[3] = 'Idki';
			h4[4] = 'Nsnw';
			h4[5] = 'Nsnr';
			h4[6] = 'Irbk';
			h4[7] = 'Nsnw';
			i4[0] = 'ITtw';
			j4[0] = $A;
			i4[1] = 'ITtc';
			j4[1] = 3;
			k4[0] = 'B007';
			n4[0] = 1.2;
			m4[0] = .0;
			k4[1] = 'B008';
			n4[1] = 1.2;
			m4[1] = .0;
			k4[2] = 'B009';
			n4[2] = 1.2;
			m4[2] = .0;
			k4[3] = 'B00A';
			n4[3] = 1.2;
			m4[3] = .0;
			k4[4] = 'B00G';
			n4[4] = .97;
			m4[4] = -30.;
		}
		private void tj() {
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Barrens Environment|r has been selected. Note that a custom environment has no influence on gameplay.");
			h4[0] = 'Klgb';
			h4[1] = 'Odrt';
			h4[2] = 'Bdrt';
			h4[3] = 'Ofst';
			h4[4] = 'Bdrh';
			h4[5] = 'Bgrr';
			h4[6] = 'Bdsd';
			h4[7] = 'Bdrr';
			i4[0] = 'ITtw';
			j4[0] = $A;
			i4[1] = 'ITtc';
			j4[1] = 3;
			k4[0] = 'B007';
			n4[0] = 1.2;
			m4[0] = .0;
			k4[1] = 'B008';
			n4[1] = 1.2;
			m4[1] = .0;
			k4[2] = 'B009';
			n4[2] = 1.2;
			m4[2] = .0;
			k4[3] = 'B00A';
			n4[3] = 1.2;
			m4[3] = .0;
			k4[4] = 'B00G';
			n4[4] = .97;
			m4[4] = -30.;
			SetTerrainFogEx(0, 1000., 8000., .0, .686, .369, .098);
			SetAmbientDaySound("BarrensDay");
			SetAmbientNightSound("BarrensNight");
		}
		private void uj() {
			destructable vj = GetEnumDestructable();
			int i = 0;
			float x;
			float y;
			float z;
			location l;
			while (true) {
				if (i>1) { break; }
				if (GetDestructableTypeId(vj)==f4[i]) {
					x = GetDestructableX(vj);
					y = GetDestructableY(vj);
					RemoveDestructable(vj);
					CreateDestructable(i4[i], x, y, GetRandomReal(.0, 360.), 1, GetRandomInt(0, j4[i]-1));
					return;
				}
				i = i+1;
			}
			i = 0;
			while (true) {
				if (i>4) { break; }
				if (GetDestructableTypeId(vj)==g4[i]) {
					x = GetDestructableX(vj);
					y = GetDestructableY(vj);
					l = GetDestructableLoc(vj);
					z = GetLocationZ(l);
					RemoveLocation(l);
					l = null;
					RemoveDestructable(vj);
					CreateDestructableZ(k4[i], x, y, m4[i]+z, 0, n4[i], 1);
					return;
				}
				i = i+1;
			}
			vj = null;
		}
		private void wj() {
			float x = 0;
			float y = d4*512;
			float zG;
			float ZG;
			int i;
			int j;
			if ((d4<50)) {
				while (true) {
					if ((y>o4)) { break; }
					x = 0;
					while (true) {
						if ((x>p4)) { break; }
						i = 0;
						while (true) {
							if (i>3) { break; }
							zG = I2R((i/ 2)*2-1)*x;
							ZG = I2R(ModuloInteger(i,2)*2-1)*y;
							j = 0;
							while (true) {
								if (j>7) { break; }
								if ((GetTerrainType(zG,ZG)==e4[j])) {
									SetTerrainType(zG, ZG, h4[j], -1, 1, 0);
									if (true) { break; }
								}
								j = j+1;
							}
							i = i+1;
						}
						x = x+$80;
					}
					y = y+$80;
					if ((ModuloReal(y,512)==0)) {
						d4 = d4+1;
						TimerStart(Y, .0, false, function wj);
						return;
					}
				}
				d4 = 50;
				TimerStart(Y, .0, false, function wj);
				return;
			} else if (d4==50 ) {
				j = 0;
				while (true) {
					if (j>6) { break; }
					e4[j] = h4[j];
					j = j+1;
				}
				EnumDestructablesInRectAll(bj_mapInitialPlayableArea, function uj);
				j = 0;
				while (true) {
					if (j>1) { break; }
					f4[j] = i4[j];
					j = j+1;
				}
				j = 0;
				while (true) {
					if (j>4) { break; }
					g4[j] = k4[j];
					j = j+1;
				}
				DestroyTimer(Y);
				Y = null;
			}
		}
		private void xj(int yj) {
			if ((Z)) {
				DisplayTextToPlayer(Player(0), 0, 0, "You have already chosen an environment!");
				return;
			}
			Z = true;
			Y = CreateTimer();
			d4 = 0;
			o4 = GetRectMaxY(C9);
			p4 = GetRectMaxX(C9);
			e4[0] = 'Vstp';
			e4[1] = 'Adrt';
			e4[2] = 'Adrg';
			e4[3] = 'Agrs';
			e4[4] = 'Agrd';
			e4[5] = 'Alvd';
			e4[6] = 'Zdtr';
			e4[7] = 'Avin';
			f4[0] = 'ATtr';
			f4[1] = 'ATtc';
			g4[0] = 'B002';
			g4[1] = 'B003';
			g4[2] = 'B004';
			g4[3] = 'B005';
			g4[4] = 'B006';
			if ((yj==0)) {
				qj();
			} else if ((yj==1)) {
				rj();
			} else if ((yj==2)) {
				sj();
			} else if ((yj==3)) {
				tj();
			}
			TimerStart(Y, .0, false, function wj);
		}
		private void zj(int Aj, int aj) {
			x4[GetUnitPointValueByType(Aj)] = aj;
		}
		private void Bj(unit u, int bj, float an, float x, float y) {
			int Cj = GetUnitUserData(u);
			float mx = GetUnitX(u)+x;
			float my = GetUnitY(u)+y;
			unit v = CreateUnit(GetOwningPlayer(u),bj,mx,my,an);
			SetUnitPathing(v, false);
			SetUnitX(v, mx);
			SetUnitY(v, my);
			SaveUnitHandle(O9, GetHandleId(u), Cj, v);
			v = null;
			SetUnitUserData(u, Cj+1);
		}
		private void cj(unit u) {
			int Dj = GetUnitUserData(u);
			int Ej = GetHandleId(u);
			if ((Dj>0)) {
				while (true) {
					Dj = Dj-1;
					RemoveUnit(LoadUnitHandle(O9, Ej, Dj));
					if (Dj<=0) { break; }
				}
			}
		}
		private void Fj(int Aj, code Gj) {
			int id = GetUnitPointValueByType(Aj);
			y4[id] = CreateTrigger();
			TriggerAddCondition(y4[id], Condition(Gj));
		}
		private void Hj(unit u) {
			int id = GetUnitPointValue(u);
			if ((y4[id]!=null)) {
				z4 = u;
				TriggerEvaluate(y4[id]);
			}
		}
		private void Ij(int Aj, float r) {
			A4[GetUnitPointValueByType(Aj)] = r;
		}
		private void lj(int Aj, code Jj) {
			int id = GetUnitPointValueByType(Aj);
			a4[id] = CreateTrigger();
			TriggerAddAction(a4[id], Jj);
		}
		private void Kj(unit u) {
			int id = GetUnitPointValue(u);
			if ((a4[id]!=null)) {
				B4 = u;
				TriggerExecute(a4[id]);
			}
		}
		private void Lj(int Aj, int Mj, code Gj) {
			int id = GetUnitPointValueByType(Aj);
			b4[id] = CreateTrigger();
			TriggerAddAction(b4[id], Gj);
			C4[id] = Mj;
		}
		private void Nj(unit u, int Mj, unit t) {
			int id = GetUnitPointValue(u);
			if ((b4[id]!=null && Mj==C4[id])) {
				c4 = u;
				D4 = t;
				TriggerExecute(b4[id]);
			}
		}
		private void Oj() {
			int id;
			id = GetUnitPointValueByType('h008');
			t4[id] = 350;
			u4[id] = 350*.09/ 100.;
			v4[id] = false;
		}
		private void Pj(string s) {
			string Qj = I2S(G4);
			if ((G4<$A)) {
				Qj = "0"+Qj;
			}
			E4[F4] = E4[F4]+("["+I2S(H4)+":"+Qj+"] "+s+"");
			if ((StringLength(E4[F4])>=I4)) {
				F4 = F4+1;
			}
		}
		private void LogClear() {
			int i = 0;
			while (true) {
				if (not(i<=F4)) { break; }
				E4[i] = "";
				i = i+1;
			}
			F4 = 0;
		}
		private void Rj() {
			int i = 0;
			PreloadGenClear();
			PreloadGenStart();
			while (true) {
				if (not(i<=F4)) { break; }
				Preload("\")"+E4[i]+"(\"");
				i = i+1;
			}
			PreloadGenEnd("Replay\\LastReplay.log");
		}
		private void Sj(string Tj, string Jj, string Uj) {
			Pj("DEBUG ("+Jj+" at "+Tj+"): "+Uj);
			Rj();
		}
		private void Vj() {
			G4 = G4+1;
			if ((G4>59)) {
				G4 = 0;
				H4 = H4+1;
			}
		}
		private void Wj() {
			TimerStart(CreateTimer(), 1., true, function Vj);
			Pj("Castle Fight ES game log");
			Pj("Map compilation: 2012.04.15 03:35:50");
			Rj();
		}
		private void Xj() {
			int i = 0;
			while (true) {
				if ((GetPlayerController(Player(i))==MAP_CONTROL_USER && GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING  && (IsPlayerInForce(Player(i),ie) || IsPlayerInForce(Player(i),je)))) {
					J4[i] = true;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			l4 = false;
		}
		private bool Yj() {
			int i = 0;
			while (true) {
				if ((J4[i])) {
					return false;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			l4 = true;
			return true;
		}
		private void Zj(int dk) {
			if ((l4)) {
				return;
			}
			if ((J4[dk])) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" has voted for a draw!");
				J4[dk] = false;
				if ((Yj())) {
					TriggerExecute(jg);
				}
			} else {
				DisplayTextToPlayer(Player(dk), .0, .0, "|cffFF0000You have already voted for a draw!|r");
			}
		}
		private bool ek() {
			unit u = GetFilterUnit();
			bool b = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_GROUND) && IsUnitType(u,UNIT_TYPE_SAPPER);
			if ((b)) {
				UnitDamageTarget(L4[bj_forLoopAIndex], GetEnumUnit(), N4[bj_forLoopAIndex], true, false, ATTACK_TYPE_MAGIC, DAMAGE_TYPE_FIRE, WEAPON_TYPE_WHOKNOWS);
			}
			u = null;
			return false;
		}
		private void fk() {
			float x;
			float y;
			float an;
			bj_forLoopAIndex = 0;
			R4 = !R4;
			while (true) {
				if (bj_forLoopAIndex>=Q4) { break; }
				an = (GetUnitFacing(L4[bj_forLoopAIndex])+O4[bj_forLoopAIndex]*GetRandomReal(.0,P4[bj_forLoopAIndex]))*bj_DEGTORAD;
				x = GetUnitX(L4[bj_forLoopAIndex])+15.*Cos(an);
				y = GetUnitY(L4[bj_forLoopAIndex])+15.*Sin(an);
				SetUnitX(L4[bj_forLoopAIndex], x);
				SetUnitY(L4[bj_forLoopAIndex], y);
				if ((R4)) {
					DestroyEffect(AddSpecialEffect("mdx\\sfx\\FireTrapUp.mdx", x, y));
				}
				P4[bj_forLoopAIndex] = P4[bj_forLoopAIndex]-(GetRandomReal(1.,10.));
				if ((P4[bj_forLoopAIndex]<=10.)) {
					P4[bj_forLoopAIndex] = GetRandomReal(15.,85.);
					O4[bj_forLoopAIndex] = IntegerTertiaryOp(GetRandomInt(0,1)==0,-1,1);
				}
				r4 = GetOwningPlayer(L4[bj_forLoopAIndex]);
				GroupEnumUnitsInRange(q4, x, y, 34., S4);
				M4[bj_forLoopAIndex] = M4[bj_forLoopAIndex]-(15.);
				if ((M4[bj_forLoopAIndex]<=0)) {
					Q4 = Q4-1;
					KillUnit(L4[bj_forLoopAIndex]);
					L4[bj_forLoopAIndex] = L4[Q4];
					M4[bj_forLoopAIndex] = M4[Q4];
					P4[bj_forLoopAIndex] = P4[Q4];
					O4[bj_forLoopAIndex] = O4[Q4];
					N4[bj_forLoopAIndex] = N4[Q4];
				} else {
					bj_forLoopAIndex = bj_forLoopAIndex+1;
				}
			}
			if ((Q4<=0)) {
				PauseTimer(K4);
			}
		}
		private void gk(unit u, int kj, float mj) {
			player p = GetOwningPlayer(u);
			float an = GetUnitFacing(u)-45.;
			float oj = an+90.;
			float x = GetUnitX(u);
			float y = GetUnitY(u);
			int i = 0;
			bool hk = Q4==0;
			while (true) {
				L4[Q4] = CreateUnit(p,'h06A',x,y,GetRandomReal(an,oj));
				M4[Q4] = 800.;
				N4[Q4] = mj;
				P4[Q4] = GetRandomReal(15.,80.);
				O4[Q4] = 0;
				Q4 = Q4+1;
				i = i+1;
				if (i>=kj) { break; }
			}
			if ((hk)) {
				TimerStart(K4, .03, true, function fk);
			}
		}
		private void ik() {
			S4 = Filter(function ek);
		}
		private string jk(int Cj) {
			if ((Cj==1)) {
				return "first";
			}
			if ((Cj==2)) {
				return "second";
			}
			if ((Cj==3)) {
				return "third";
			}
			return "fourth";
		}
		private void kk() {
			int mk;
			player p = GetTriggerPlayer();
			if ((!IsPlayerInForce(p,U4))) {
				if ((T4==null)) {
					T4 = p;
				}
				AdjustPlayerStateBJ(W4, GetTriggerPlayer(), PLAYER_STATE_RESOURCE_GOLD);
				DisplayTextToPlayer(p, .0, .0, "|cffFFFF80You receive |cffFFCC00"+I2S(W4)+"|cffFFFF80 gold for being the "+jk(X4)+" player that finishes a structure!");
				mk = GetPlayerId(p);
				de[mk] = de[mk]+(W4);
				W4 = W4-(5);
				X4 = X4+1;
				if ((X4>4)) {
					DisableTrigger(V4);
				} else {
					ForceAddPlayer(U4, p);
				}
			}
		}
		private void nk() {
			T4 = null;
			ForceClear(U4);
			W4 = 20;
			X4 = 1;
			EnableTrigger(V4);
		}
		private void ok() {
			TriggerAddAction(V4, function kk);
			TriggerRegisterAnyUnitEventBJ(V4, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH);
			DisableTrigger(V4);
		}
		private void pk() {
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\NightElf\\Barkskin\\BarkSkinTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\HowlOfTerror\\HowlCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Units\\NightElf\\Wisp\\WispExplode.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathCoil\\DeathCoilSpecialArt.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\AncestralSpirit\\AncestralSpiritCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Resurrect\\ResurrectCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathPact\\DeathPactTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\ReplenishHealth\\ReplenishHealthCasterOverhead.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\Naga\\NagaDeath\\NagaDeath.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\NightElf\\BattleRoar\\RoarCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Polymorph\\PolyMorphTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\ControlMagic\\ControlMagicTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIda\\AIdaCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Feedback\\SpellBreakerAttack.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIvi\\AIviTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Demon\\DarkPortal\\DarkPortalTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\Transmute\\PileofGold.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIil\\AIilTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\MirrorImage\\MirrorImageDeathCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MassTeleport\\MassTeleportCaster.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\NEDeathMedium\\NEDeath.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\EntBirthTarget\\EntBirthTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("mdx\\sfx\\sin2.mdx", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Weapons\\Bolt\\BoltImpact.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("mdx\\sfx\\FireTrapUp.mdx", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\HolyBolt\\HolyBoltSpecialArt.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\ReplenishMana\\ReplenishManaCasterOverhead.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\Volcano\\VolcanoDeath.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Weapons\\Bolt\\BoltImpact.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("mdx\\sfx\\FireTrapUp.mdx", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Heal\\HealTarget.mdl", .0, .0));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathPact\\DeathPactCaster.mdl", .0, .0));
			KillUnit(CreateUnit(Player($D), 'e008', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h00O', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'u006', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h00C', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h019', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h00E', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h017', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h089', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h00P', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h018', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h06P', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h01A', .0, .0, .0));
			KillUnit(CreateUnit(Player($D), 'h051', .0, .0, .0));
		}
		private void qk() {
			pk();
		}
		private bool rk() {
			unit u = GetFilterUnit();
			bool b = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && u!=bj_lastLoadedUnit;
			u = null;
			return b;
		}
		private void sk(int tk) {
			float an = GetUnitFacing(Z4[tk]);
			SetUnitFacing(Z4[tk], an-30.);
			e7[tk] = e7[tk]-1;
			f7[tk] = 1;
			d7[tk] = 50.;
			Z4[j7] = CreateUnit(GetOwningPlayer(Z4[tk]),'h03H',GetUnitX(Z4[tk]),GetUnitY(Z4[tk]),an+30.);
			d7[j7] = 50.;
			e7[j7] = e7[tk];
			f7[j7] = -1;
			g7[j7] = null;
			h7[j7] = h7[tk];
			i7[j7] = false;
			j7 = j7+1;
		}
		private void uk() {
			int i = 0;
			float x;
			float y;
			float an;
			unit u;
			while (true) {
				if (i>=j7) { break; }
				an = GetUnitFacing(Z4[i])*bj_DEGTORAD;
				x = GetUnitX(Z4[i])+20.*Cos(an);
				y = GetUnitY(Z4[i])+20.*Sin(an);
				SetUnitX(Z4[i], x);
				SetUnitY(Z4[i], y);
				r4 = GetOwningPlayer(Z4[i]);
				bj_lastLoadedUnit = g7[i];
				GroupEnumUnitsInRange(q4, x, y, 34., k7);
				u = FirstOfGroup(q4);
				if ((u!=null)) {
					UnitDamageTarget(Z4[i], u, h7[i], true, false, ATTACK_TYPE_MAGIC, DAMAGE_TYPE_LIGHTNING, WEAPON_TYPE_WHOKNOWS);
					DestroyEffect(AddSpecialEffect("Abilities\\Weapons\\Bolt\\BoltImpact.mdl", GetUnitX(u), GetUnitY(u)));
					g7[i] = u;
				}
				d7[i] = d7[i]-(20.);
				if ((d7[i]<=.0)) {
					if ((f7[i]==0)) {
						if ((e7[i]>0)) {
							sk(i);
						} else {
							j7 = j7-1;
							KillUnit(Z4[i]);
							Z4[i] = Z4[j7];
							d7[i] = d7[j7];
							e7[i] = e7[j7];
							f7[i] = f7[j7];
							g7[i] = g7[j7];
							h7[i] = h7[j7];
							i7[i] = i7[j7];
						}
					} else {
						if ((f7[i]>0 && !i7[i])) {
							j7 = j7-1;
							KillUnit(Z4[i]);
							Z4[i] = Z4[j7];
							d7[i] = d7[j7];
							e7[i] = e7[j7];
							f7[i] = f7[j7];
							g7[i] = g7[j7];
							h7[i] = h7[j7];
							i7[i] = i7[j7];
						} else {
							d7[i] = 400.;
							SetUnitFacing(Z4[i], an*bj_RADTODEG+f7[i]*30.);
							f7[i] = 0;
						}
					}
				} else {
					i = i+1;
				}
			}
			if ((j7<=0)) {
				PauseTimer(Y4);
			}
			u = null;
		}
		private void vk(unit u, int wk, int xk, float mj) {
			player p = GetOwningPlayer(u);
			float an = GetUnitFacing(u);
			int i = 0;
			bool hk = j7==0;
			float yk = (an+90.)*bj_DEGTORAD;
			float zk = -50.*I2R(wk/ 2)+50.*ModuloInteger(wk+1,2)/ 2.;
			float x = GetUnitX(u)+30.*CosBJ(an);
			float y = GetUnitY(u)+30.*SinBJ(an);
			float Ak = Sin(yk);
			yk = Cos(yk);
			while (true) {
				Z4[j7] = CreateUnit(p,'h03H',x+zk*yk,y+zk*Ak,an);
				d7[j7] = 400.;
				e7[j7] = xk;
				f7[j7] = 0;
				g7[j7] = null;
				h7[j7] = mj;
				i7[j7] = false;
				zk = zk+(50.);
				j7 = j7+1;
				i = i+1;
				if (i>=wk) { break; }
			}
			i7[j7-1] = true;
			if ((hk)) {
				TimerStart(Y4, .03, true, function uk);
			}
		}
		private void ak() {
			k7 = Filter(function rk);
		}
		private void Bk(string reason) {
			u7 = 3;
		}
		private float MMD___time() {
			return TimerGetElapsed(w7);
		}
		private void bk() {
			int i = 0;
			string id;
			while (true) {
				if (i>=m7) { break; }
				id = SubString("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~",i,i+1);
				if (id==StringCase(id,true)) {
					id = id+"U";
				}
				StoreInteger(t7, "c2i", id, i);
				i = i+1;
			}
		}
		private int Ck(string c) {
			int i;
			string id = c;
			if (id==StringCase(id,true)) {
				id = id+"U";
			}
			i = GetStoredInteger(t7,"c2i",id);
			if ((i<0 || i>=m7 || SubString("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~",i,i+1)!=c) && HaveStoredInteger(t7,"c2i",id)) {
				i = 0;
				while (true) {
					if (i>=m7) { break; }
					if (c==SubString("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~",i,i+1)) {
						Bk("c2i poisoned");
						StoreInteger(t7, "c2i", id, i);
						if (true) { break; }
					}
					i = i+1;
				}
			}
			return i;
		}
		private int ck(string s, int Dk) {
			int n = StringLength(s);
			int m = n+Dk;
			int i = 0;
			while (true) {
				if (i>=n) { break; }
				m = m*41+Ck(SubString(s,i,i+1));
				i = i+1;
			}
			return m;
		}
		private int Ek(int id, string Fk) {
			int oi = ni();
			sh[oi] = (TimerGetElapsed(w7))+7.+GetRandomReal(0,2+.1*GetPlayerId(GetLocalPlayer()));
			th[oi] = Fk;
			uh[oi] = ck(th[oi],id);
			vh[oi] = I2S(id);
			return oi;
		}
		private void Gk(int oi) {
			FlushStoredInteger(t7, "val:"+vh[oi], th[oi]);
			FlushStoredInteger(t7, "chk:"+vh[oi], vh[oi]);
			th[oi] = null;
			vh[oi] = null;
			wh[oi] = 0;
		}
		private void Hk(int oi) {
			if (oi==null ) {
				return;
			} else if ((rh[oi]!=-1)) {
				return;
			}
			Gk(oi);
			rh[oi] = ph;
			ph = oi;
		}
		private void Ik(int oi) {
			StoreInteger(t7, "val:"+vh[oi], th[oi], uh[oi]);
			StoreInteger(t7, "chk:"+vh[oi], vh[oi], uh[oi]);
			SyncStoredInteger(t7, "val:"+vh[oi], th[oi]);
			SyncStoredInteger(t7, "chk:"+vh[oi], vh[oi]);
		}
		private bool lk() {
			int i = 0;
			int n = 0;
			int r;
			JassArray<int> Jk = new JassArray<int>();
			JassArray<bool> Kk = new JassArray<bool>();
			while (true) {
				if (i>=$C) { break; }
				if (GetPlayerController(Player(i))==MAP_CONTROL_USER && GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING ) {
					if (n<u7 ) {
						Jk[n] = i;
						Kk[i] = true;
					} else {
						r = GetRandomInt(0,n);
						if (r<u7 ) {
							Kk[Jk[r]] = false;
							Jk[r] = i;
							Kk[i] = true;
						}
					}
					n = n+1;
				}
				i = i+1;
			}
			return Kk[GetPlayerId(GetLocalPlayer())];
		}
		private void Lk(string Mk) {
			int q;
			if (!s7 ) {
				BJDebugMsg("MMD Emit Error: Library not initialized yet.");
				return;
			}
			q = Ek(v7,Mk);
			if (x7==0 ) {
				x7 = q;
			} else {
				wh[y7] = q;
			}
			y7 = q;
			v7 = v7+1;
			if (lk()) {
				Ik(q);
			}
		}
		private void Nk() {
			int q;
			int i;
			q = x7;
			while (true) {
				if (q==0 || sh[q]>=(TimerGetElapsed(w7))) { break; }
				if (!HaveStoredInteger(t7,"val:"+vh[q],th[q])) {
					Bk("message skipping");
					Ik(q);
				} else if (!HaveStoredInteger(t7,"chk:"+vh[q],vh[q])) {
					Bk("checksum skipping");
					Ik(q);
				} else if (GetStoredInteger(t7,"val:"+vh[q],th[q])!=uh[q]) {
					Bk("message tampering");
					Ik(q);
				} else if (GetStoredInteger(t7,"chk:"+vh[q],vh[q])!=uh[q]) {
					Bk("checksum tampering");
					Ik(q);
				}
				x7 = wh[q];
				Hk(q);
				q = x7;
			}
			if (x7==0 ) {
				y7 = 0;
			}
			i = 0;
			while (true) {
				if (!HaveStoredInteger(t7,"chk:"+I2S(v7),I2S(v7))) { break; }
				Bk("message insertion");
				Lk("Blank");
				i = i+1;
				if (i>=$A) { break; }
			}
		}
		private string Ok(string Pk) {
			int j;
			int i = 0;
			string Qk = "";
			string c;
			while (true) {
				if (i>=StringLength(Pk)) { break; }
				c = SubString(Pk,i,i+1);
				j = 0;
				while (true) {
					if (j>=StringLength(" \\")) { break; }
					if (c==SubString(" \\",j,j+1)) {
						c = "\\"+c;
						if (true) { break; }
					}
					j = j+1;
				}
				Qk = Qk+c;
				i = i+1;
			}
			return Qk;
		}
		private void Rk(string Sk, player p, string op, string Pk, int Tk) {
			int id = GetPlayerId(p);
			if (p==null || id<0 || id>=$C ) {
				BJDebugMsg("MMD Set Error: Invalid player. Must be P1 to P12.");
			} else if (Tk!=GetStoredInteger(t7,"types",Sk)) {
				BJDebugMsg("MMD Set Error: Updated value of undefined variable or used value of incorrect type.");
			} else if (StringLength(op)==0 ) {
				BJDebugMsg("MMD Set Error: Unrecognized operation type.");
			} else if (StringLength(Sk)>50 ) {
				BJDebugMsg("MMD Set Error: Variable name is too long.");
			} else if (StringLength(Sk)==0 ) {
				BJDebugMsg("MMD Set Error: Variable name is empty.");
			} else {
				Lk("VarP "+I2S(id)+" "+Ok(Sk)+" "+op+" "+Pk);
			}
		}
		private void dm(player p, int em) {
			string fm = n7[em];
			int id = GetPlayerId(p);
			if (p==null || id<0 || id>=$C ) {
				BJDebugMsg("MMD Flag Error: Invalid player. Must be P1 to P12.");
			} else if (StringLength(fm)==0 ) {
				BJDebugMsg("MMD Flag Error: Unrecognized flag type.");
			} else if (GetPlayerController(Player(id))==MAP_CONTROL_USER ) {
				Lk("FlagP "+I2S(id)+" "+fm);
			}
		}
		private void gm(string Sk, int hm, int im, int jm) {
			string km = o7[im];
			string mm = q7[hm];
			string nm = r7[jm];
			if (km==null ) {
				BJDebugMsg("MMD Def Error: Unrecognized goal type.");
			} else if (mm==null ) {
				BJDebugMsg("MMD Def Error: Unrecognized value type.");
			} else if (nm==null ) {
				BJDebugMsg("Stats Def Error: Unrecognized suggestion type.");
			} else if (StringLength(Sk)>32 ) {
				BJDebugMsg("MMD Def Error: Variable name is too long.");
			} else if (StringLength(Sk)==0 ) {
				BJDebugMsg("MMD Def Error: Variable name is empty.");
			} else if (hm=='e' && im!='e' ) {
				BJDebugMsg("MMD Def Error: Strings must have goal type of none.");
			} else if (GetStoredInteger(t7,"types",Sk)!=0 ) {
				BJDebugMsg("MMD Def Error: Value redefined.");
			} else {
				StoreInteger(t7, "types", Sk, hm);
				Lk("DefVarP "+Ok(Sk)+" "+mm+" "+km+" "+nm);
			}
		}
		private void om() {
			int i;
			trigger t;
			s7 = true;
			Lk("init version "+I2S(1)+" "+I2S(1));
			i = 0;
			while (true) {
				if (i>=$C) { break; }
				if (GetPlayerController(Player(i))==MAP_CONTROL_USER && GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING ) {
					Lk("init pid "+I2S(i)+" "+Ok(GetPlayerName(Player(i))));
				}
				i = i+1;
			}
			t = CreateTrigger();
			TriggerAddAction(t, function Nk);
			TriggerRegisterTimerEvent(t, .37, true);
			gm("RoundsWon", 'g', 'e', 'e');
			gm("RoundsLost", 'g', 'e', 'e');
			gm("Wins", 'g', 'e', 'e');
			gm("Loses", 'g', 'e', 'e');
		}
		private void pm() {
			trigger t = CreateTrigger();
			TriggerRegisterTimerEvent(t, 0, false);
			TriggerAddAction(t, function om);
			o7['e'] = "none";
			o7['f'] = "high";
			o7['g'] = "low";
			q7['g'] = "int";
			q7['f'] = "real";
			q7['e'] = "string";
			r7['e'] = "none";
			r7['f'] = "track";
			r7['g'] = "leaderboard";
			p7['e'] = "+=";
			p7['f'] = "-=";
			p7['g'] = "=";
			n7['e'] = "drawer";
			n7['f'] = "loser";
			n7['g'] = "winner";
			n7['h'] = "leaver";
			n7['i'] = "practicing";
			FlushGameCache(InitGameCache("MMD.Dat"));
			t7 = InitGameCache("MMD.Dat");
			TimerStart(w7, $3B9AC9FF, false, null);
			bk();
		}
		private void qm() {
			int i = 0;
			while (true) {
				if ((B7[i]==null)) {
					B7[i] = CreateUnit(z7,'h06B',IntegerTertiaryOp(i<$A,-1,1)*GetRandomReal(2048.,X7),IntegerTertiaryOp(ModuloInteger(i,$A)<5,-1,1)*(Z7-128.),270.);
					SetUnitFlyHeight(B7[i], 30., 85.);
					IssueTargetOrderById(B7[i], $D0003, a7[i]);
					i = (i/ 5+1)*5;
				}
				i = i+1;
				if (i>=20) { break; }
			}
		}
		private unit rm(int sm) {
			int i = sm*5;
			int j = (sm+1)*5;
			unit u;
			while (true) {
				if ((B7[i]!=null)) {
					u = B7[i];
					B7[i] = null;
					return u;
				}
				i = i+1;
				if (i>=20) { break; }
			}
			return null;
		}
		private void NatureWispControl_StartCalling() {
			TimerStart(A7, 4., true, function qm);
		}
		private void tm() {
			int i = 0;
			PauseTimer(A7);
			while (true) {
				if ((B7[i]!=null)) {
					RemoveUnit(B7[i]);
					B7[i] = null;
				}
				i = i+1;
				if (i>=20) { break; }
			}
		}
		private void um() {
			destructable d = GetEnumDestructable();
			int id = GetDestructableTypeId(d);
			if ((bj_forLoopAIndex<bj_forLoopAIndexEnd  && (id=='ATtc' || id=='ATtr' || id=='B001' || id=='B000' || id=='ITtw' || id=='ITtc'))) {
				SetDestructableInvulnerable(d, true);
				a7[bj_forLoopAIndex] = d;
				bj_forLoopAIndex = bj_forLoopAIndex+1;
			}
			d = null;
		}
		private void vm() {
			rect r;
			if ((b7)) {
				return;
			}
			b7 = true;
			r = Rect(-2048.,.0,-X7,-Z7);
			bj_forLoopAIndex = 0;
			bj_forLoopAIndexEnd = bj_forLoopAIndex+5;
			EnumDestructablesInRect(r, null, function um);
			RemoveRect(r);
			r = Rect(-2048.,.0,-X7,Z7);
			bj_forLoopAIndexEnd = bj_forLoopAIndex+5;
			EnumDestructablesInRect(r, null, function um);
			RemoveRect(r);
			r = Rect(2048.,.0,X7,-Z7);
			bj_forLoopAIndexEnd = bj_forLoopAIndex+5;
			EnumDestructablesInRect(r, null, function um);
			RemoveRect(r);
			r = Rect(2048.,.0,X7,Z7);
			bj_forLoopAIndexEnd = bj_forLoopAIndex+5;
			EnumDestructablesInRect(r, null, function um);
			RemoveRect(r);
			r = null;
		}
		private void wm() {
			TimerStart(CreateTimer(), .0, true, function wm);
		}
		private void xm() {
			trigger t = CreateTrigger();
			DestroyTimer(GetExpiredTimer());
			if ((GetHandleId(t)!=$10022B)) {
				TimerStart(CreateTimer(), .0, true, function wm);
			} else {
				DestroyTrigger(t);
				t = null;
			}
		}
		private void ym() {
			TimerStart(CreateTimer(), .15, false, function xm);
		}
		private string zm(int aj) {
			int i = 0;
			while (true) {
				if (E7[i]==aj || i>=l7) { break; }
				i = i+1;
			}
			if ((i>=l7)) {
				return "Unregistred Race";
			}
			return F7[i];
		}
		private void Am(int am) {
			int i = 0;
			while (true) {
				SetPlayerAbilityAvailable(Player(i), G7[am], I7[me[i]*l7+am]and am>K7[i]*9 and am<(K7[i]+1)*9);
				i = i+1;
				if (i>=$C) { break; }
			}
		}
		private void Bm(int bm, bool fl) {
			int i = 0;
			while (true) {
				if (E7[i]==bm || i>=l7) { break; }
				i = i+1;
			}
			if ((i>=l7)) {
				return;
			}
			I7[i] = fl;
			I7[l7+i] = fl;
			Am(i);
		}
		private void Cm(int bm, bool fl, int cm) {
			int i = 0;
			while (true) {
				if (E7[i]==bm || i>=l7) { break; }
				i = i+1;
			}
			if ((i>=l7)) {
				return;
			}
			I7[l7*cm+i] = fl;
			Am(i);
		}
		private void Dm(unit u) {
			int i = 0;
			player p = GetOwningPlayer(u);
			while (true) {
				UnitAddAbility(u, G7[i]);
				i = i+1;
				if (i>=l7) { break; }
			}
			UnitAddAbility(u, 'A0DP');
			UnitAddAbility(u, 'A0DQ');
			UnitAddAbility(u, 'A0DR');
			SelectUnitForPlayerSingle(u, p);
			PanCameraToForPlayer(p, GetUnitX(u), GetUnitY(u));
		}
		private unit Em(unit u) {
			Dm(u);
			return u;
		}
		private int Fm(unit u, float Gm) {
			int dk = GetPlayerId(GetOwningPlayer(u));
			timer Hm = CreateTimer();
			int Im = 0;
			Dm(u);
			TimerStart(Hm, Gm, false, null);
			while (true) {
				TriggerSleepAction(.33);
				if (D7[dk]!=0 || TimerGetRemaining(Hm)<.33) { break; }
			}
			PauseTimer(Hm);
			DestroyTimer(Hm);
			Hm = null;
			RemoveUnit(u);
			if ((D7[dk]==0)) {
				return -1;
			}
			Im = D7[dk];
			D7[dk] = 0;
			return Im;
		}
		private void lm(int dk) {
			int i = 0;
			int Jm = K7[dk]*9;
			int to = (K7[dk]+1)*9;
			int zk = me[dk]*l7;
			player p = Player(dk);
			while (true) {
				SetPlayerAbilityAvailable(p, G7[i], I7[zk+i]and i>=Jm and i<to);
				i = i+1;
				if (i>=l7) { break; }
			}
			SetPlayerAbilityAvailable(p, 'A0DP', to<l7);
			SetPlayerAbilityAvailable(p, 'A0DQ', Jm>0);
		}
		private void RaceSelector_Finally() {
			DisableTrigger(J7);
		}
		private void Km() {
			int i = 0;
			while (true) {
				K7[i] = 0;
				D7[i] = 0;
				lm(i);
				i = i+1;
				if (i>=$C) { break; }
			}
			C7 = null;
		}
		private void Lm() {
			int i = 0;
			while (true) {
				I7[i] = true;
				i = i+1;
				if (i>=l7*2) { break; }
			}
			Km();
			EnableTrigger(J7);
		}
		private bool Mm() {
			unit u = GetTriggerUnit();
			int dk = GetPlayerId(GetOwningPlayer(u));
			int Nm = GetSpellAbilityId();
			int i = 0;
			if ((Nm=='A0DP')) {
				K7[dk] = K7[dk]+1;
				lm(dk);
				u = null;
				return false;
			} else if ((Nm=='A0DQ')) {
				K7[dk] = K7[dk]-1;
				lm(dk);
				u = null;
				return false;
			} else if ((Nm=='A0DR')) {
				D7[dk] = -1;
				if ((C7!=null)) {
					c7 = dk;
					TriggerEvaluate(C7);
				}
				RemoveUnit(u);
				u = null;
				return false;
			}
			while (true) {
				if (G7[i]==Nm || i>=l7) { break; }
				i = i+1;
			}
			RemoveUnit(u);
			u = null;
			if ((i>=l7)) {
				return false;
			}
			D7[dk] = E7[i];
			if ((GetLocalPlayer()==Player(dk))) {
				StartSound(H7[i]);
			}
			if ((C7!=null)) {
				c7 = dk;
				TriggerEvaluate(C7);
			}
			return false;
		}
		private void Om(int a, int b) {
			int i = 0;
			while (true) {
				if ((I7[i])) {
					Gi(a, E7[i]);
				}
				if ((I7[l7+i])) {
					Gi(b, E7[i]);
				}
				i = i+1;
				if (i>=l7) { break; }
			}
		}
		private void Pm() {
			F7[l7] = "Chaos Legions";
			E7[l7] = 'h00O';
			G7[l7] = 'A0DD';
			H7[l7] = CreateSound("Units\\Demon\\HeroPitLord\\HPitLordYesAttack2.wav",false,false,false,$A,$A,"DefaultEAXON");
			l7 = l7+1;
			F7[l7] = "Elven Union";
			E7[l7] = 'h00P';
			G7[l7] = 'A0DE';
			H7[l7] = CreateSound("Units\\Critters\\BloodElfPeasant\\BloodElfEngineerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON");
			l7 = l7+1;
			F7[l7] = "Corrupted Conglomerate";
			E7[l7] = 'u006';
			G7[l7] = 'A0DF';
			H7[l7] = CreateSound("Units\\Demon\\Pitlord\\PitLordYesAttack1.wav",false,false,false,$A,$A,"DefaultEAXON");
			l7 = l7+1;
			F7[l7] = "Human Alliance";
			E7[l7] = 'h00C';
			G7[l7] = 'A0DG';
			H7[l7] = CreateSound("Units\\Human\\Peasant\\PeasantReady1.wav",false,false,false,$A,$A,"DefaultEAXON");
			l7 = l7+1;
			F7[l7] = "Orcish Horde";
			E7[l7] = 'h019';
			G7[l7] = 'A0DH';
			H7[l7] = CreateSound("Units\\Orc\\Peon\\PeonReady1.wav",false,false,false,$A,$A,"DefaultEAXON");
			l7 = l7+1;
			F7[l7] = "Naga Faction";
			E7[l7] = 'h00E';
			G7[l7] = 'A0DI';
			H7[l7] = CreateSound("Units\\Creeps\\Murloc\\MurlocPissed2.wav",false,false,false,$A,$A,"DefaultEAXON");
			l7 = l7+1;
			F7[l7] = "Northern Realms";
			E7[l7] = 'h017';
			G7[l7] = 'A0DJ';
			H7[l7] = CreateSound("Units\\Creeps\\Bandit\\BanditWhat1.wav",false,false,false,$A,$A,"DefaultEAXON");
			l7 = l7+1;
			F7[l7] = "Night Elfs";
			E7[l7] = 'h089';
			G7[l7] = 'A0DK';
			H7[l7] = CreateSound("Units\\NightElf\\Runner\\RunnerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON");
			l7 = l7+1;
			F7[l7] = "Undead Forces";
			E7[l7] = 'h018';
			G7[l7] = 'A0DL';
			H7[l7] = CreateSound("Units\\Undead\\Acolyte\\AcolyteWarcry1.wav",false,false,false,$A,$A,"HeroAcksEAX");
			l7 = l7+1;
			F7[l7] = "Mech Coalition";
			E7[l7] = 'h06P';
			G7[l7] = 'A0DM';
			H7[l7] = CreateSound("Units\\Creeps\\HeroTinker\\HeroTinkerReady1.wav",false,false,false,$A,$A,"HeroAcksEAX");
			l7 = l7+1;
			F7[l7] = "Nature Force";
			E7[l7] = 'h01A';
			G7[l7] = 'A0DN';
			H7[l7] = CreateSound("Units\\NightElf\\Ent\\EntReady1.wav",false,false,false,$A,$A,"DefaultEAXON");
			l7 = l7+1;
			F7[l7] = "Elementals' Universe";
			E7[l7] = 'h051';
			G7[l7] = 'A0DO';
			H7[l7] = CreateSound("Units\\NightElf\\Wisp\\WispPissed3.wav",false,false,false,$A,$A,"DefaultEAXON");
			l7 = l7+1;
			DisableTrigger(J7);
			TriggerAddCondition(J7, Condition(function Mm));
			TriggerRegisterAnyUnitEventBJ(J7, EVENT_PLAYER_UNIT_SPELL_CAST);
		}
		private void Qm() {
			PlaySoundBJ(Hg);
			if ((cd>0 && T4!=null)) {
				if ((IsPlayerInForce(T4,ie))) {
					TriggerExecute(ig);
				} else {
					TriggerExecute(hg);
				}
				return;
			}
			TriggerExecute(jg);
		}
		private void Rm() {
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 10., "1 minute before round ends!");
			TimerStart(L7, 60., false, function Qm);
			PlaySoundBJ(Hg);
		}
		private void Sm() {
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 10., "3 minutes before round ends!");
			TimerStart(L7, 120., false, function Rm);
			PlaySoundBJ(Hg);
		}
		private void Tm() {
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 10., "Warnning! 5 minutes before round ends!");
			TimerStart(L7, 120., false, function Sm);
			PlaySoundBJ(Hg);
		}
		private void Um() {
			if ((L7!=null)) {
				PauseTimer(L7);
			}
			if ((cd!=0)) {
				if ((L7==null)) {
					L7 = CreateTimer();
				}
				TimerStart(L7, (IAbsBJ(cd)-5)*60., false, function Tm);
			}
		}
		private void Vm() {
			int id = LoadInteger(O9,GetHandleId(GetExpiredTimer()),30);
			Q7[id] = Q7[id]-1;
			if ((Q7[id]<0)) {
				if ((GetLocalPlayer()==Player(id))) {
					StartSound(Ug);
				}
				Q7[id] = 3;
				TimerDialogSetTitle(O7[id], R7[3]);
				TimerStart(M7[id], P7[id], false, function Vm);
				TimerStart(N7[id], P7[id]+3, false, null);
				return;
			}
			if ((GetLocalPlayer()==Player(id))) {
				StartSound(Tg);
			}
			TimerDialogSetTitle(O7[id], R7[Q7[id]]);
			TimerStart(M7[id], 1., false, function Vm);
		}
		private void Wm(int p, float Gm) {
			if ((M7[p]==null)) {
				M7[p] = CreateTimer();
				N7[p] = CreateTimer();
				O7[p] = CreateTimerDialog(N7[p]);
				SaveInteger(O9, GetHandleId(M7[p]), 30, p);
			}
			TimerDialogDisplay(O7[p], GetLocalPlayer()==Player(p));
			P7[p] = Gm-3;
			Q7[p] = 3;
			TimerDialogSetTitle(O7[p], R7[3]);
			TimerStart(M7[p], P7[p], false, function Vm);
			TimerStart(N7[p], P7[p]+3, false, null);
		}
		private bool Xm(int p) {
			if ((P7[p]<=.0)) {
				return false;
			}
			PauseTimer(M7[p]);
			P7[p] = .0;
			PauseTimer(N7[p]);
			TimerDialogDisplay(O7[p], false);
			return true;
		}
		private void Ym(bool fm) {
			int i = 0;
			if ((fm)) {
				while (true) {
					if ((P7[i]>.0)) {
						TimerDialogSetTitle(O7[i], R7[3]);
						TimerStart(M7[i], P7[i], false, function Vm);
						TimerStart(N7[i], P7[i]+3, false, null);
					}
					i = i+1;
					if (i>$B) { break; }
				}
				return;
			}
			while (true) {
				if ((P7[i]>.0)) {
					PauseTimer(M7[i]);
					PauseTimer(N7[i]);
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void Zm() {
			R7[0] = "!!!";
			R7[1] = ".!!";
			R7[2] = "..!";
			R7[3] = "...";
		}
		private location dn(bool en) {
			int i = 0;
			if ((!en)) {
				i = 6;
			}
			while (true) {
				if ((!T7[i])) {
					T7[i] = true;
					return S7[i];
				}
				i = i+1;
				if (i>$B) { break; }
			}
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "GENERAL FAILURE AT MODULE 'SP:GMR'. PLEASE REPORT ABOUT THIS BUG!");
			return Location(.0,.0);
		}
		private void fn(location gn) {
			int i = 0;
			while (true) {
				if ((gn==S7[i])) {
					T7[i] = false;
					return;
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void hn() {
			int i = 0;
			while (true) {
				S7[i] = GetPlayerStartLocationLoc(Player(i));
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void in() {
			destructable d = GetTriggerDestructable();
			timer t = CreateTimer();
			TimerStart(t, 30., false, null);
			while (true) {
				TriggerSleepAction(1.);
				if (TimerGetRemaining(t)<.5) { break; }
			}
			PauseTimer(t);
			DestroyTimer(t);
			t = null;
			DestructableRestoreLife(d, GetDestructableMaxLife(d), true);
			d = null;
		}
		private void jn() {
			TriggerRegisterDeathEvent(U7, GetEnumDestructable());
		}
		private bool kn() {
			destructable d = GetFilterDestructable();
			int t = GetDestructableTypeId(d);
			bool Im = t=='ATtc' || t=='ATtr' || t=='B001' || t=='B000' || t=='ITtw' || t=='ITtc';
			d = null;
			return Im;
		}
		private void mn() {
			boolexpr f;
			if ((V7)) {
				return;
			}
			V7 = true;
			f = Filter(function kn);
			EnumDestructablesInRect(bj_mapInitialPlayableArea, f, function jn);
			DestroyBoolExpr(f);
			f = null;
			TriggerAddAction(U7, function in);
		}
		private int nn() {
			int u = Ii();
			Gh[u] = 0;
			return u;
		}
		private void on(int oi, int Hi) {
			int i = 0;
			while (true) {
				if (Eh[Fh[oi]+i]==Hi || i>=Gh[oi]) { break; }
				i = i+1;
			}
			if ((i>=Gh[oi])) {
				return;
			}
			Gh[oi] = Gh[oi]-1;
			Eh[Fh[oi]+i] = Eh[Fh[oi]+Gh[oi]];
		}
		private int pn(int oi) {
			return Eh[Fh[oi]+GetRandomInt(0,Gh[oi]-1)];
		}
		private void qn() {
			d8[e8] = GetEnumUnit();
			e8 = e8+1;
		}
		private unit rn(group g) {
			e8 = 0;
			ForGroup(g, function qn);
			if ((e8<=0)) {
				return null;
			}
			return d8[GetRandomInt(0,e8-1)];
		}
		private int sn(int x, int y) {
			int r;
			if ((x==0 || y==0)) {
				return x+y;
			}
			r = x-y*(x/ y);
			while (true) {
				if (r==0) { break; }
				x = y;
				y = r;
				r = x-y*(x/ y);
			}
			return y;
		}
		private int tn(int x, int y) {
			return (x*y)/ sn(x,y);
		}
		private void un(player p, string s) {
			if ((GetLocalPlayer()==p)) {
				ClearTextMessages();
				DisplayTimedTextToPlayer(p, .52, -1., 2., "|cffffcc00"+s+"|r");
				StopSound(g8, false, false);
				StartSound(g8);
			}
		}
		private player vn(force f) {
			int i = 0;
			while (true) {
				if ((IsPlayerInForce(Player(i),f))) {
					return Player(i);
				}
				i = i+1;
				if (i>$B) { break; }
			}
			return null;
		}
		private void wn(force f1, force f2) {
			int i = 0;
			player p;
			while (true) {
				p = Player(i);
				if ((IsPlayerInForce(p,f2) && IsPlayerInForce(p,f1))) {
					ForceRemovePlayer(f1, p);
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private int xn() {
			int i = 0;
			int j = 0;
			while (true) {
				if ((IsPlayerInForce(Player(i),ie) && D9[i]!=null)) {
					j = j+1;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			return j;
		}
		private int yn() {
			int i = 0;
			int j = 0;
			while (true) {
				if ((IsPlayerInForce(Player(i),je) && D9[i]!=null)) {
					j = j+1;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			return j;
		}
		private player zn(bool en) {
			int i = 0;
			h8 = true;
			if ((!en)) {
				i = 7;
			}
			while (true) {
				if (IsPlayerInForce(Player(i),ke) || i>$B) { break; }
				i = i+1;
			}
			if ((i>$B)) {
				if ((en)) {
					return null;
				}
				i = 0;
				while (true) {
					if (IsPlayerInForce(Player(i),ke) || i>6) { break; }
					i = i+1;
				}
				if ((i>6)) {
					return null;
				}
			}
			return Player(i);
		}
		private void An() {
			int i = 0;
			int j;
			while (true) {
				j = 0;
				while (true) {
					if ((me[i]==me[j])) {
						if ((ne[j]!=null && IsPlayerInForce(Player(i),ne[j]))) {
							SetPlayerAllianceStateBJ(Player(i), Player(j), 5);
						} else {
							SetPlayerAllianceStateBJ(Player(i), Player(j), 3);
						}
					} else {
						SetPlayerAllianceStateBJ(Player(i), Player(j), 0);
					}
					j = j+1;
					if (j>$B) { break; }
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void Bn() {
			An();
			h8 = false;
		}
		private void bn() {
			W7 = GetRectMinX(bj_mapInitialPlayableArea);
			X7 = GetRectMaxX(bj_mapInitialPlayableArea);
			Y7 = GetRectMinY(bj_mapInitialPlayableArea);
			Z7 = GetRectMaxY(bj_mapInitialPlayableArea);
		}
		private void Cn() {
			unit u = GetTriggerUnit();
			int p = GetPlayerId(GetOwningPlayer(u));
			if (((!IsUnitType(u,UNIT_TYPE_FLYING)) && p<$C && GetUnitPointValue(u)!=$81 && p8!=me[p])) {
				if ((p8!=-1)) {
					if ((v8[p8]==w8)) {
						DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 8., Od[p8]+"|cffFFFF00 are no longer dominating!|r");
						i8[p8] = 1.;
					}
					v8[p8] = v8[p8]-1;
				}
				p8 = me[p];
				v8[p8] = v8[p8]+1;
				SetUnitColor(t8, j8[p8]);
				if ((v8[p8]==w8)) {
					i8[p8] = 1.+.15;
					DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 8., Od[p8]+"|cffFFFF00 are dominating, they gain +"+I2S(R2I(.15*'d'))+"% income!|r");
				}
			}
			u = null;
		}
		private void cn() {
			unit u = GetTriggerUnit();
			int p = GetPlayerId(GetOwningPlayer(u));
			if (((!IsUnitType(u,UNIT_TYPE_FLYING)) && p<$C && GetUnitPointValue(u)!=$81 && q8!=me[p])) {
				if ((q8!=-1)) {
					if ((v8[q8]==w8)) {
						DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 8., Od[q8]+"|cffFFFF00 are no longer dominating!|r");
						i8[q8] = 1.;
					}
					v8[q8] = v8[q8]-1;
				}
				q8 = me[p];
				v8[q8] = v8[q8]+1;
				SetUnitColor(u8, j8[q8]);
				if ((v8[q8]==w8)) {
					i8[q8] = 1.+.15;
					DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 8., Od[q8]+"|cffFFFF00 are dominating, they gain +"+I2S(R2I(.15*'d'))+"% income!|r");
				}
			}
			u = null;
		}
		private void Dn() {
			rect En;
			if ((!m8)) {
				En = Rect(-160.,448.,160.,1216.);
				n8 = CreateRegion();
				RegionAddRect(n8, En);
				RemoveRect(En);
				En = Rect(-160.,-1216.,160.,-448.);
				o8 = CreateRegion();
				RegionAddRect(o8, En);
				RemoveRect(En);
				En = null;
				r8 = CreateTrigger();
				s8 = CreateTrigger();
				TriggerAddAction(r8, function Cn);
				TriggerAddAction(s8, function cn);
				TriggerRegisterEnterRegion(r8, n8, null);
				TriggerRegisterEnterRegion(s8, o8, null);
				j8[0] = PLAYER_COLOR_RED;
				j8[1] = PLAYER_COLOR_GREEN;
				t8 = CreateUnit(Player($F),'ncp2',.0,832.,.0);
				u8 = CreateUnit(Player($F),'ncp2',.0,-832.,.0);
				m8 = true;
			}
			if ((ed==0)) {
				w8 = 2;
			} else {
				w8 = 1;
				if ((ed==1)) {
					ShowUnit(u8, false);
					DisableTrigger(s8);
				} else {
					ShowUnit(t8, false);
					DisableTrigger(r8);
				}
			}
			SetUnitColor(t8, k8);
			SetUnitColor(u8, k8);
			v8[0] = 0;
			v8[1] = 0;
			p8 = -1;
			q8 = -1;
			i8[0] = 1.;
			i8[1] = 1.;
		}
		private int Fn(int dk) {
			int i = 6*dk+1;
			int j = 6*(dk+1);
			int c = 0;
			while (true) {
				c = c+(A8[i]);
				i = i+1;
				if (i>=j) { break; }
			}
			return c;
		}
		private void Gn(unit u) {
			int dk = GetPlayerId(GetOwningPlayer(u));
			int Hn = a8[GetUnitPointValue(u)];
			A8[dk*6+Hn] = A8[dk*6+Hn]+1;
		}
		private void In(unit u) {
			int dk = GetPlayerId(GetOwningPlayer(u));
			int Hn = a8[GetUnitPointValue(u)];
			A8[dk*6+Hn] = A8[dk*6+Hn]-1;
		}
		private void ln() {
			int dk = GetPlayerId(GetOwningPlayer(c4));
			int i = GetRandomInt(0,98);
			if ((i<33)) {
				SetUnitAnimation(c4, "spell slam");
				vk(c4, 2+A8[dk*6+3]/ 3, 2+A8[dk*6+5]/ 2, 75.*IMinBJ(1+A8[dk*6+1], 4));
			} else if ((i<66)) {
				jj(c4, 5+A8[dk*6+4]*2, 75.*IMinBJ(1+A8[dk*6+2], 4), IMaxBJ(IMinBJ(A8[dk*6+5]/ 4, 3), 1));
			} else {
				SetUnitAnimation(c4, "spell throw");
				gk(c4, IMaxBJ(IMinBJ(A8[dk*6+1]/ 2, 8), 2), 75.*IMinBJ(1+A8[dk*6+3], 4));
			}
		}
		private void Jn(unit c, unit t) {
			lightning Kn;
			float Ln = .0;
			UnitRemoveAbility(c, 'A0EK');
			if ((GetUnitAbilityLevel(t,'A0EL')>0)) {
				UnitAddAbility(c, 'A0EK');
				un(GetOwningPlayer(c), "Target is improved already.");
				return;
			}
			if ((GetUnitState(t,UNIT_STATE_MAX_MANA)<1. || (x4[GetUnitPointValue((t))])>0)) {
				UnitAddAbility(c, 'A0EK');
				un(GetOwningPlayer(c), "Target haven't mana or it's not special building.");
				return;
			}
			UnitAddAbility(t, 'A0EL');
			UnitMakeAbilityPermanent(t, true, 'A0EL');
			if ((GetUnitAbilityLevel(t,'A0DS')>0)) {
				SetUnitAbilityLevel(t, 'A0EL', 2);
			}
			SaveUnitHandle(O9, GetHandleId(t), 26, c);
			Kn = AddLightning("DRAM",true,GetUnitX(t),GetUnitY(t),GetUnitX(c),GetUnitY(c));
			if ((IsUnitAlly(c,GetLocalPlayer()))) {
				Ln = 1.;
			}
			SetLightningColor(Kn, 1., 1., 1., Ln);
			SaveLightningHandle(O9, GetHandleId(t), 25, Kn);
			Kn = null;
		}
		private void Mn(unit u) {
			UnitAddAbility(LoadUnitHandle(O9, GetHandleId(u), 26), 'A0EK');
			DestroyLightning(LoadLightningHandle(O9, GetHandleId(u), 25));
		}
		private void Nn() {
			unit c;
			int i = GetRandomInt(0,2);
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			bj_groupRandomCurrentPick = rn(q4);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			c = CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);
			if ((i==0)) {
				UnitAddAbility(c, x8);
				IssuePointOrderById(c, $D0079, GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick));
			} else if ((i==1)) {
				UnitAddAbility(c, y8);
				IssuePointOrderById(c, $D010E, GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick));
			} else {
				UnitAddAbility(c, z8);
				IssuePointOrderById(c, $D026F, GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick));
			}
			UnitApplyTimedLife(c, 'BTLF', 10.);
			c = null;
		}
		private bool On() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && (b8 || GetUnitAbilityLevel(u,'A0F4')<=0);
			u = null;
			return Im;
		}
		private void Pn() {
			float r;
			int i = 0;
			r4 = GetOwningPlayer(B4);
			b8 = false;
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, B8);
			bj_groupRandomCurrentPick = rn(q4);
			if ((bj_groupRandomCurrentPick==null)) {
				b8 = true;
				GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, B8);
				bj_groupRandomCurrentPick = rn(q4);
				if ((bj_groupRandomCurrentPick==null)) {
					return;
				}
			}
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\HolyBolt\\HolyBoltSpecialArt.mdl", bj_groupRandomCurrentPick, "overhead"));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\ReplenishMana\\ReplenishManaCasterOverhead.mdl", GetUnitX(B4), GetUnitY(B4)));
			r = GetWidgetLife(bj_groupRandomCurrentPick);
			if ((GetUnitState(bj_groupRandomCurrentPick,UNIT_STATE_MAX_LIFE)-r>350.)) {
				SetWidgetLife(bj_groupRandomCurrentPick, r+450.);
			} else {
				C8[0] = 'A0D7';
				C8[1] = 'A0F3';
				C8[2] = 'A0F1';
				c8 = 3;
				while (true) {
					if (i>=c8) { break; }
					if ((GetUnitAbilityLevel(bj_groupRandomCurrentPick,C8[i])>0)) {
						c8 = c8-1;
						C8[i] = C8[c8];
					} else {
						i = i+1;
					}
				}
				if ((c8<=0)) {
					SetWidgetLife(bj_groupRandomCurrentPick, r+450.);
				} else {
					i = GetRandomInt(0,c8-1);
					UnitAddAbility(bj_groupRandomCurrentPick, C8[i]);
					if ((i==2)) {
						UnitAddAbility(bj_groupRandomCurrentPick, 'A03Q');
					}
					UnitAddAbility(bj_groupRandomCurrentPick, 'A0F4');
				}
			}
		}
		private bool Qn() {
			Bj(z4, 'h050', 270., .0, 28.);
			Bj(z4, 'h050', 90., .0, -28.);
			return false;
		}
		private bool Rn() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h050', 90., .0, -28.);
			return false;
		}
		private bool Sn() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h04Y', 90., .0, -28.);
			return false;
		}
		private bool Tn() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h050', 90., .0, -28.);
			return false;
		}
		private bool Un() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h04Y', 90., .0, -28.);
			Bj(z4, 'h058', 270., .0, .0);
			return false;
		}
		private bool Vn() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h050', 90., .0, -28.);
			Bj(z4, 'h052', 270., .0, .0);
			return false;
		}
		private bool Wn() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h04Y', 90., .0, -28.);
			Bj(z4, 'h053', 270., .0, .0);
			return false;
		}
		private bool Xn() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h050', 90., .0, -28.);
			Bj(z4, 'h05O', 270., .0, .0);
			return false;
		}
		private bool Yn() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h04Y', 90., .0, -28.);
			Bj(z4, 'h057', 270., .0, .0);
			Bj(z4, 'h05P', 270., .0, .0);
			return false;
		}
		private bool Zn() {
			Bj(z4, 'h050', 270., .0, 28.);
			Bj(z4, 'h050', 90., .0, -28.);
			return false;
		}
		private bool do() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h050', 90., .0, -28.);
			Bj(z4, 'h05K', 90., .0, .0);
			return false;
		}
		private bool eo() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h04Y', 90., .0, -28.);
			Bj(z4, 'h05B', 90., .0, .0);
			return false;
		}
		private bool fo() {
			Bj(z4, 'h04Y', 270., .0, 28.);
			Bj(z4, 'h04Y', 90., .0, -28.);
			Bj(z4, 'h05Y', 270., .0, .0);
			Bj(z4, 'h05Q', 270., .0, .0);
			Bj(z4, 'h05S', 270., .0, .0);
			Bj(z4, 'h05W', 270., .0, .0);
			return false;
		}
		private bool go() {
			Bj(z4, 'h065', 300., .0, .0);
			return false;
		}
		private bool ho() {
			Bj(z4, 'h066', 270., .0, .0);
			return false;
		}
		private bool io() {
			Bj(z4, 'h067', 270., .0, .0);
			return false;
		}
		private bool jo() {
			Bj(z4, 'h064', 270., .0, .0);
			return false;
		}
		private void ko() {
			zj('h03Y', 'h02X');
			a8[GetUnitPointValueByType('h03Y')] = 4;
			zj('h03X', 'h02W');
			a8[GetUnitPointValueByType('h03X')] = 4;
			zj('h03Z', 'h02Y');
			a8[GetUnitPointValueByType('h03Z')] = 4;
			zj('h040', 'h034');
			a8[GetUnitPointValueByType('h040')] = 2;
			zj('h041', 'h03N');
			a8[GetUnitPointValueByType('h041')] = 2;
			zj('h042', 'h03P');
			a8[GetUnitPointValueByType('h042')] = 3;
			zj('h044', 'h03R');
			a8[GetUnitPointValueByType('h044')] = 3;
			zj('h045', 'h02Z');
			a8[GetUnitPointValueByType('h045')] = 1;
			zj('h046', 'u00F');
			a8[GetUnitPointValueByType('h046')] = 1;
			zj('h04A', 'o00C');
			a8[GetUnitPointValueByType('h04A')] = 5;
			zj('h04C', 'o00D');
			a8[GetUnitPointValueByType('h04C')] = 5;
			zj('h04D', 'o00E');
			a8[GetUnitPointValueByType('h04D')] = 5;
			zj('h04E', 'h03V');
			a8[GetUnitPointValueByType('h04E')] = 1;
			Fj('h03X', function Qn);
			Fj('h03Y', function Rn);
			Fj('h03Z', function Sn);
			Fj('h040', function Tn);
			Fj('h041', function Un);
			Fj('h042', function Vn);
			Fj('h044', function Wn);
			Fj('h045', function Xn);
			Fj('h046', function Yn);
			Fj('h04A', function Zn);
			Fj('h04C', function do);
			Fj('h04D', function eo);
			Fj('h04E', function fo);
			Fj('h05Z', function ho);
			Fj('h060', function go);
			Fj('h061', function io);
			Fj('h063', function jo);
			lj('h060', function Pn);
			lj('h05Z', function Nn);
			Ij('h061', 700.);
		}
		private void mo() {
			int id;
			id = GetUnitPointValueByType('h03X');
			t4[id] = GetUnitGoldCost('h03X');
			u4[id] = GetUnitGoldCost('h03X')*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03Y');
			t4[id] = GetUnitGoldCost('h03Y');
			u4[id] = GetUnitGoldCost('h03Y')*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03Z');
			t4[id] = GetUnitGoldCost('h03Z');
			u4[id] = GetUnitGoldCost('h03Z')*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h042');
			t4[id] = GetUnitGoldCost('h042');
			u4[id] = GetUnitGoldCost('h042')*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h044');
			t4[id] = GetUnitGoldCost('h044');
			u4[id] = GetUnitGoldCost('h044')*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h045');
			t4[id] = GetUnitGoldCost('h045');
			u4[id] = GetUnitGoldCost('h045')*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h046');
			t4[id] = GetUnitGoldCost('h046');
			u4[id] = GetUnitGoldCost('h046')*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04A');
			t4[id] = GetUnitGoldCost('h04A');
			u4[id] = GetUnitGoldCost('h04A')*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04C');
			t4[id] = GetUnitGoldCost('h04C');
			u4[id] = GetUnitGoldCost('h04C')*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04D');
			t4[id] = GetUnitGoldCost('h04D');
			u4[id] = GetUnitGoldCost('h04D')*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h040');
			t4[id] = GetUnitGoldCost('h040');
			u4[id] = GetUnitGoldCost('h040')*.18/ 100.;
			v4[id] = true;
			w4[id] = true;
			id = GetUnitPointValueByType('h041');
			t4[id] = GetUnitGoldCost('h041');
			u4[id] = GetUnitGoldCost('h041')*.18/ 100.;
			v4[id] = true;
			w4[id] = true;
			id = GetUnitPointValueByType('h061');
			t4[id] = GetUnitGoldCost('h061');
			u4[id] = GetUnitGoldCost('h061')*.08/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h04E');
			t4[id] = GetUnitGoldCost('h04E');
			u4[id] = GetUnitGoldCost('h04E')*.2/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h060');
			t4[id] = GetUnitGoldCost('h060');
			u4[id] = GetUnitGoldCost('h060')*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h05Z');
			t4[id] = GetUnitGoldCost('h05Z');
			u4[id] = GetUnitGoldCost('h05Z')*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h062');
			t4[id] = GetUnitGoldCost('h062');
			u4[id] = GetUnitGoldCost('h062')*.12/ 100.;
			v4[id] = false;
		}
		private void Elementals___RegisterUnitCasts() {
			Lj('h03V', 'A0E1', function ln);
		}
		private void no() {
			timer t = GetExpiredTimer();
			unit u = LoadUnitHandle(O9,GetHandleId(t),22);
			unit w = CreateUnit(GetOwningPlayer(u),'e008',GetUnitX(u),GetUnitY(u),.0);
			UnitAddAbility(w, 'A0DA');
			IssuePointOrderById(w, $D01F9, GetUnitX(u), GetUnitY(u));
			UnitApplyTimedLife(w, 'BTLF', 60.);
			SaveUnitHandle(O9, GetHandleId(t), 20, w);
			t = null;
			u = null;
			w = null;
		}
		private void oo(unit u) {
			int i = GetRandomInt(0,99);
			timer t;
			unit w;
			if ((i<25)) {
				UnitAddAbility(u, 'A0D8');
			} else if ((i<50)) {
				UnitAddAbility(u, 'A0D9');
				UnitAddAbility(u, 'A0EX');
			} else if ((i<75)) {
				UnitAddAbility(u, 'A03Q');
				UnitAddAbility(u, 'A0EV');
			} else {
				UnitAddAbility(u, 'A0EW');
				t = CreateTimer();
				w = CreateUnit(GetOwningPlayer(u),'e008',GetUnitX(u),GetUnitY(u),.0);
				UnitAddAbility(w, 'A0DA');
				IssuePointOrderById(w, $D01F9, GetUnitX(u), GetUnitY(u));
				UnitApplyTimedLife(w, 'BTLF', 60.);
				SaveTimerHandle(O9, GetHandleId(u), 21, t);
				SaveUnitHandle(O9, GetHandleId(t), 20, w);
				SaveUnitHandle(O9, GetHandleId(t), 22, u);
				TimerStart(t, 60., true, function no);
				t = null;
				w = null;
			}
		}
		private void po(unit u) {
			timer t = LoadTimerHandle(O9,GetHandleId(u),21);
			if ((t!=null)) {
				PauseTimer(t);
				RemoveUnit(LoadUnitHandle(O9, GetHandleId(t), 20));
				FlushChildHashtable(O9, GetHandleId(t));
				DestroyTimer(t);
				t = null;
			}
		}
		private void qo(player p) {
			int id = me[GetPlayerId(p)];
			Kd[id] = Kd[id]+(1);
		}
		private void ro(unit u) {
			int id = me[GetPlayerId(GetOwningPlayer(u))];
			Kd[id] = Kd[id]-(1);
		}
		private void so() {
			unit u;
			ko();
			mo();
			Lj('h03V', 'A0E1', function ln);
			B8 = Filter(function On);
			u = CreateUnit(Player($D),'e008',.0,.0,.0);
			UnitAddAbility(u, 'A0DA');
			RemoveUnit(u);
			u = null;
		}
		private bool uo() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && (D8 || GetUnitAbilityLevel(u,'A0F1')<=0);
			u = null;
			return Im;
		}
		private void vo() {
			int i = GetRandomInt(1,3);
			r4 = GetOwningPlayer(B4);
			D8 = false;
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, E8);
			bj_groupRandomCurrentPick = rn(q4);
			if ((bj_groupRandomCurrentPick==null)) {
				D8 = true;
				GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, E8);
				bj_groupRandomCurrentPick = rn(q4);
				if ((bj_groupRandomCurrentPick==null)) {
					return;
				}
			}
			UnitAddAbility(bj_groupRandomCurrentPick, 'A03B');
			UnitAddAbility(bj_groupRandomCurrentPick, 'A03A');
			UnitAddAbility(bj_groupRandomCurrentPick, 'A03D');
			UnitAddAbility(bj_groupRandomCurrentPick, 'A08L');
			if ((i==1)) {
				UnitAddAbility(bj_groupRandomCurrentPick, 'A05I');
				UnitAddAbility(bj_groupRandomCurrentPick, 'A06W');
			} else if ((i==2)) {
				UnitAddAbility(bj_groupRandomCurrentPick, 'A08M');
				UnitAddAbility(bj_groupRandomCurrentPick, 'A06Y');
			} else {
				UnitAddAbility(bj_groupRandomCurrentPick, 'A08R');
				UnitAddAbility(bj_groupRandomCurrentPick, 'A06X');
			}
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Undead\\ReplenishHealth\\ReplenishHealthCasterOverhead.mdl", bj_groupRandomCurrentPick, "overhead"));
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl", GetUnitX(B4), GetUnitY(B4)));
		}
		private void wo() {
			unit c = CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(B4),GetUnitY(B4),.0);
			UnitAddAbility(c, 'A031');
			IssueImmediateOrderById(c, $D009F);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = B4;
			TriggerSleepAction(1.);
			SetUnitAnimation(c, "stand");
			c = null;
		}
		private void xo() {
			unit c;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			c = CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(B4),GetUnitY(B4),.0);
			UnitAddAbility(c, 'A030');
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);
			IssueTargetOrderById(c, $D02B6, bj_groupRandomCurrentPick);
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);
			UnitApplyTimedLife(c, 'BTLF', 30.);
			c = B4;
			TriggerSleepAction(.5);
			SetUnitAnimation(c, "attack");
			TriggerSleepAction(1.);
			SetUnitAnimation(c, "stand");
			c = null;
		}
		private void yo() {
			unit c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(c, 'A06H');
			IssueTargetOrderById(c, $D008A, D4);
			UnitApplyTimedLife(c, 'BTLF', 2.);
			c = null;
		}
		private void zo() {
			lj('h02R', function vo);
			zj('h02P', 'o009');
			zj('h02K', 'o007');
			zj('h092', 'o00B');
			zj('h035', 'o008');
			zj('h036', 'o006');
			lj('h02O', function wo);
			lj('h02N', function xo);
			zj('h029', 'o002');
			zj('h02U', 'o004');
			zj('h031', 'o005');
			zj('h02B', 'o003');
			zj('h02I', 'o001');
			Ij('o000', 900.);
			zj('h02H', 'n00V');
			zj('h05E', 'n01O');
		}
		private void Ao() {
			int id;
			id = GetUnitPointValueByType('h02P');
			t4[id] = $DC;
			u4[id] = $DC*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h02K');
			t4[id] = 260;
			u4[id] = 260*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h092');
			t4[id] = 'd';
			u4[id] = 'd'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h035');
			t4[id] = 'd';
			u4[id] = 'd'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h036');
			t4[id] = 'd';
			u4[id] = 'd'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h029');
			t4[id] = 'n';
			u4[id] = 'n'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h02U');
			t4[id] = 'd';
			u4[id] = 'd'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h031');
			t4[id] = $F0;
			u4[id] = $F0*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h02B');
			t4[id] = $AA;
			u4[id] = $AA*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h02I');
			t4[id] = 380;
			u4[id] = 380*.18/ 100.;
			v4[id] = true;
			w4[id] = true;
			id = GetUnitPointValueByType('h02H');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h05E');
			t4[id] = 80;
			u4[id] = 80*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h02R');
			t4[id] = $FA;
			u4[id] = $FA*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h02O');
			t4[id] = 475;
			u4[id] = 475*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('o000');
			t4[id] = $AF;
			u4[id] = $AF*.08/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h02N');
			t4[id] = 270;
			u4[id] = 270*.09/ 100.;
			v4[id] = false;
		}
		private void Orc___RegisterUnitCasts() {
			Lj('n01O', 'A06I', function yo);
		}
		private void ao() {
			zo();
			Ao();
			Lj('n01O', 'A06I', function yo);
			E8 = Filter(function uo);
		}
		private void SmartGroup___DEBUGstateShow() {
			int i = 0;
			string s = "Units at filter: ";
			DisplayTextToPlayer(GetLocalPlayer(), .0, .0, "Filter called, total count: "+I2S(H8));
			i = 0;
			while (true) {
				s = s+GetUnitName(G8[i])+" ";
				i = i+1;
				if (i>H8) { break; }
			}
			DisplayTextToPlayer(GetLocalPlayer(), .0, .0, s);
			i = 0;
			s = "Areas at filter: ";
			while (true) {
				s = s+I2S(I8[i])+" ";
				i = i+1;
				if (i>l8) { break; }
			}
			DisplayTextToPlayer(GetLocalPlayer(), .0, .0, s);
		}
		private bool Bo() {
			unit u = GetFilterUnit();
			if ((GetWidgetLife(u)>.405 && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitAlly(u,r4) && GetUnitAbilityLevel(u,'Avul')<=0)) {
				F8[H8] = u;
				H8 = H8+1;
			}
			u = null;
			return false;
		}
		private bool bo() {
			unit u = GetFilterUnit();
			if ((GetWidgetLife(u)>.405 && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitEnemy(u,r4) && GetUnitAbilityLevel(u,'Avul')<=0)) {
				F8[H8] = u;
				H8 = H8+1;
			}
			u = null;
			return false;
		}
		private void Co() {
			int i = 0;
			while (true) {
				if (i>=H8) { break; }
				G8[i] = F8[i];
				i = i+1;
			}
			l8 = 0;
			I8[0] = 0;
		}
		private void co(player p, float x, float y, float r) {
			l8 = 0;
			I8[0] = 0;
			r4 = p;
			H8 = 0;
			GroupEnumUnitsInRange(q4, x, y, r, K8);
		}
		private bool Do(int Eo) {
			int i = I8[l8];
			int j = H8;
			unit u;
			while (true) {
				if (i>=j) { break; }
				if ((ti(Eo,G8[i]))) {
					j = j-1;
					u = G8[j];
					G8[j] = G8[i];
					G8[i] = u;
				} else {
					i = i+1;
				}
			}
			if ((i<H8)) {
				l8 = l8+1;
				I8[l8] = i;
			}
			u = null;
			DisplayTextToPlayer(GetLocalPlayer(), .0, .0, I2S(i)+":"+I2S(j)+":"+I2S(H8));
			return j==H8;
		}
		private unit SmartGroup_GetRandomUnitLastArea() {
			if ((I8[l8]>=H8)) {
				return null;
			}
			return G8[GetRandomInt(I8[l8],H8-1)];
		}
		private unit Fo() {
			if ((I8[l8]>=H8)) {
				return null;
			}
			return G8[H8-1];
		}
		private void Go() {
			J8 = Filter(function Bo);
			K8 = Filter(function bo);
		}
		private bool Ho() {
			unit u = GetFilterUnit();
			float r = GetWidgetLife(u);
			bool Im = r>.405 && IsUnitEnemy(u,r4) && GetUnitAbilityLevel(u,'A0CV')>0 && GetUnitAbilityLevel(u,'BHbn')<=0 && GetUnitAbilityLevel(u,'A0BG')<=0;
			u = null;
			return Im;
		}
		private bool Io() {
			unit u = GetFilterUnit();
			float r = GetWidgetLife(u);
			bool Im = r>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitType(u,UNIT_TYPE_GROUND) && GetUnitAbilityLevel(u,'A08H')<=0 && GetUnitAbilityLevel(u,'A0BG')<=0 && GetUnitAbilityLevel(u,'B012')<=0 && GetUnitAbilityLevel(u,'BHbn')<=0  && ((GetUnitState(u,UNIT_STATE_MAX_MANA)>100. && r<=600.) || r<=300.);
			u = null;
			return Im;
		}
		private bool lo() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitType(u,UNIT_TYPE_GROUND) && GetUnitAbilityLevel(u,'Avul')<=0 && GetUnitAbilityLevel(u,'A08H')<=0 && GetUnitAbilityLevel(u,'A0BG')<=0 && GetUnitAbilityLevel(u,'B012')<=0 && GetUnitAbilityLevel(u,'BHbn')<=0;
			u = null;
			return Im;
		}
		private bool Jo() {
			unit u = GetFilterUnit();
			float r = GetWidgetLife(u);
			bool Im = r>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_STRUCTURE) && GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>50.;
			u = null;
			return Im;
		}
		private bool Ko() {
			unit u = GetFilterUnit();
			float r = GetWidgetLife(u);
			bool Im = r>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_MECHANICAL) && GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>50.;
			u = null;
			return Im;
		}
		private void Lo(unit u) {
			int bj = GetUnitPointValue(u);
			int id = GetUnitUserData(u);
			r4 = GetOwningPlayer(u);
			if ((bj==$81)) {
				if ((L8[id]!=null && GetWidgetLife(L8[id])>.405 && IsUnitEnemy(L8[id],r4))) {
					if ((GetUnitAbilityLevel(L8[id],'B012')>0 || GetUnitAbilityLevel(L8[id],'BHbn')>0)) {
						L8[id] = null;
					} else if ((!IssueTargetOrderById(u,$D000F,L8[id]))) {
						IssuePointOrderById(u, $D0012, GetUnitX(L8[id]), GetUnitY(L8[id]));
					}
				} else if ((GetUnitAbilityLevel(u,'B012')>0 || IssueImmediateOrderById(u,$D00A1))) {
					GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, P8);
					bj_groupRandomCurrentPick = rn(q4);
					if ((bj_groupRandomCurrentPick==null)) {
						GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Q8);
						bj_groupRandomCurrentPick = rn(q4);
					}
					if ((bj_groupRandomCurrentPick==null)) {
						IssuePointOrderById(u, $D0012, GetUnitX(u), GetUnitY(u));
					} else {
						L8[id] = bj_groupRandomCurrentPick;
						IssuePointOrderById(u, $D0012, GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick));
					}
				} else {
					IssuePointOrderByIdLoc(u, $D000F, Id[me[GetPlayerId(r4)]]);
				}
			} else if ((bj==$82)) {
				if ((L8[id]==null)) {
					GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, S8);
					bj_groupRandomCurrentPick = rn(q4);
					if ((bj_groupRandomCurrentPick==null)) {
						GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, T8);
						bj_groupRandomCurrentPick = rn(q4);
					}
					L8[id] = u;
					if ((bj_groupRandomCurrentPick==null)) {
						N8[id] = GetUnitX(u);
						O8[id] = GetUnitY(u);
					} else {
						N8[id] = GetUnitX(bj_groupRandomCurrentPick);
						O8[id] = GetUnitY(bj_groupRandomCurrentPick);
					}
					IssuePointOrderById(u, $D000F, N8[id], O8[id]);
				} else {
					IssuePointOrderById(u, $D000F, N8[id], O8[id]);
				}
			}
		}
		private void Mo(unit u) {
			int i = 0;
			while (true) {
				if (M8[i]==false) { break; }
				i = i+1;
			}
			M8[i] = true;
			L8[i] = null;
			SetUnitUserData(u, i);
			if ((GetUnitTypeId(u)=='n01U')) {
				UnitApplyTimedLife(u, 'BTLF', 'x');
			}
		}
		private void No() {
			P8 = Filter(function Ho);
			Q8 = Filter(function Io);
			R8 = Filter(function lo);
			S8 = Filter(function Jo);
			T8 = Filter(function Ko);
		}
		private void AdvancedSmartGroup_PrepareSorting() {
			Co();
		}
		private unit Oo(int s1, int s2, int s3, int s4) {
			Co();
			if ((Do(s1))) {
				DisplayTextToPlayer(GetLocalPlayer(), .0, .0, "G:s1 returned");
				return null;
			}
			if ((s2!=0)) {
				if ((Do(s2))) {
					DisplayTextToPlayer(GetLocalPlayer(), .0, .0, "G:s2 returned");
					return Fo();
				}
			}
			if ((s3!=0)) {
				if ((Do(s3))) {
					DisplayTextToPlayer(GetLocalPlayer(), .0, .0, "G:s3 returned");
					return Fo();
				}
			}
			if ((s4!=0)) {
				Do(s4);
			}
			return Fo();
		}
		private void Po(unit u) {
			IssuePointOrderByIdLoc(u, $D000F, Id[me[GetPlayerId(GetOwningPlayer(u))]]);
		}
		private void Qo(unit u) {
			if ((IsUnitType(u,UNIT_TYPE_TAUREN))) {
				return;
			}
			if ((GetUnitAbilityLevel(u,'A07M')>=1)) {
				Lo(u);
			} else {
				IssuePointOrderByIdLoc(u, $D000F, Id[me[GetPlayerId(GetOwningPlayer(u))]]);
			}
		}
		private float Ro(float x, float y) {
			return SquareRoot(x*x+y*y);
		}
		private void So() {
			timer t = GetExpiredTimer();
			int id = LoadInteger(O9,GetHandleId(t),1);
			if ((GetWidgetLife(U8[id])>.405 && Ro(V8[id]-GetUnitX(U8[id]),W8[id]-GetUnitY(U8[id]))>768.)) {
				UnitRemoveAbility(U8[id], 'A0BG');
			}
			Y8 = Y8-1;
			X8[id] = X8[Y8];
			V8[id] = V8[Y8];
			W8[id] = W8[Y8];
			U8[id] = U8[Y8];
			SaveInteger(O9, GetHandleId(X8[Y8]), 1, id);
			X8[Y8] = t;
			t = null;
		}
		private void To() {
			timer t = GetExpiredTimer();
			int id = LoadInteger(O9,GetHandleId(t),1);
			if ((GetWidgetLife(U8[id])>.405)) {
				SetUnitPathing(U8[id], true);
				TimerStart(t, 4., false, Z8);
			} else {
				Y8 = Y8-1;
				X8[id] = X8[Y8];
				V8[id] = V8[Y8];
				W8[id] = W8[Y8];
				U8[id] = U8[Y8];
				SaveInteger(O9, GetHandleId(X8[Y8]), 1, id);
				X8[Y8] = t;
			}
			t = null;
		}
		private void Uo() {
			timer t = GetExpiredTimer();
			int id = LoadInteger(O9,GetHandleId(t),1);
			if ((GetWidgetLife(U8[id])>.405 && Ro(V8[id]-GetUnitX(U8[id]),W8[id]-GetUnitY(U8[id]))<768.)) {
				SetUnitPathing(U8[id], false);
				Qo(U8[id]);
				TimerStart(t, .7, false, function To);
			} else {
				UnitRemoveAbility(U8[id], 'A0BG');
				Y8 = Y8-1;
				X8[id] = X8[Y8];
				V8[id] = V8[Y8];
				W8[id] = W8[Y8];
				U8[id] = U8[Y8];
				SaveInteger(O9, GetHandleId(X8[Y8]), 1, id);
				X8[Y8] = t;
			}
			t = null;
		}
		private void Vo(unit u) {
			UnitAddAbility(u, 'A0BG');
			if ((X8[Y8]==null)) {
				X8[Y8] = CreateTimer();
			}
			V8[Y8] = GetUnitX(u);
			W8[Y8] = GetUnitY(u);
			U8[Y8] = u;
			SaveInteger(O9, GetHandleId(X8[Y8]), 1, Y8);
			TimerStart(X8[Y8], 4., false, Z8);
			Y8 = Y8+1;
		}
		private void Wo() {
			if ((ud)) {
				Z8 = function Uo;
			} else {
				Z8 = function So;
			}
		}
		private void Xo() {
			unit Ui = GetAttacker();
			unit Yo;
			if ((GetUnitAbilityLevel(Ui,'A0EZ')>0)) {
				Yo = GetTriggerUnit();
				UnitRemoveAbility(Ui, 'A0EZ');
				TriggerSleepAction(.0);
				if ((!IssueTargetOrderById(Ui,$D0279,Yo))) {
					Po(Ui);
				}
				Yo = null;
			}
			Ui = null;
		}
		private void Zo() {
			TriggerRegisterAnyUnitEventBJ(d9, EVENT_PLAYER_UNIT_ATTACKED);
			TriggerAddAction(d9, function Xo);
		}
		private void dp(bool ep) {
			if ((ep)) {
				EnableTrigger(d9);
			} else {
				DisableTrigger(d9);
			}
		}
		private bool fp(int oi, unit u) {
			return GetWidgetLife(u)<100.;
		}
		private bool gp(int oi, unit u) {
			return IsUnitType(u,UNIT_TYPE_RANGED_ATTACKER);
		}
		private bool hp(int oi, unit u) {
			return IsUnitType(u,UNIT_TYPE_MELEE_ATTACKER);
		}
		private bool ip(int oi, unit u) {
			return IsUnitType(u,UNIT_TYPE_FLYING);
		}
		private bool jp(int oi, unit u) {
			return IsUnitType(u,UNIT_TYPE_GROUND);
		}
		private bool kp(int oi, unit u) {
			return LoadInteger(i9,GetUnitTypeId(u),1)==0;
		}
		private bool np(int oi, unit u) {
			return LoadInteger(i9,GetUnitTypeId(u),1)==1;
		}
		private bool pp(int oi, unit u) {
			return LoadInteger(i9,GetUnitTypeId(u),1)==2;
		}
		private bool qp(int oi, unit u) {
			return LoadInteger(i9,GetUnitTypeId(u),1)==3;
		}
		private bool rp(int oi, unit u) {
			return LoadInteger(i9,GetUnitTypeId(u),1)==4;
		}
		private bool sp(int oi, unit u) {
			return LoadInteger(i9,GetUnitTypeId(u),1)==5;
		}
		private bool tp(int oi, unit u) {
			return LoadInteger(i9,GetUnitTypeId(u),1)==6;
		}
		private bool up(int oi, unit u) {
			int vp = LoadInteger(i9,GetUnitTypeId(u),1);
			return vp==1 || vp==6;
		}
		private bool UnitsAI___Enemy() {
			return IsUnitEnemy(GetFilterUnit(),e9);
		}
		private bool UnitsAI___Alive() {
			return GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7;
		}
		private bool UnitsAI___Damaged() {
			return GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.;
		}
		private bool UnitsAI___RangedUnit() {
			return (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))!=null;
		}
		private bool UnitsAI___MeleeUnit() {
			return (IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER))!=null;
		}
		private bool UnitsAI___Air() {
			return (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING))!=null;
		}
		private bool UnitsAI___Ground() {
			return (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))!=null;
		}
		private bool UnitsAI___HeroDef() {
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0;
		}
		private bool UnitsAI___LightDef() {
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1;
		}
		private bool UnitsAI___HeavyDef() {
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2;
		}
		private bool UnitsAI___DivineDef() {
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3;
		}
		private bool UnitsAI___MediumDef() {
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4;
		}
		private bool UnitsAI___FortifiedDef() {
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==5;
		}
		private bool UnitsAI___UnarmoredDef() {
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6;
		}
		private bool wp() {
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool xp() {
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool yp() {
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool zp() {
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Ap() {
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool ap() {
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Bp() {
			return (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1);
		}
		private bool bp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Cp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool cp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Dp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Ep() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Fp() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool UnitsAI___meleeSiege8() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Gp() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Hp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Ip() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool lp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Jp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Kp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Lp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Mp() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Np() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Op() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Pp() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Qp() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Rp() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Sp() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Tp() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Up() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Vp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Wp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Xp() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool Yp() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool Zp() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool dq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool eq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool fq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool gq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool hq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool iq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool jq() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool kq() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool mq() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool nq() {
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool oq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool qq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool rq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool sq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool tq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool uq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool vq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;
		}
		private bool wq() {
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool xq() {
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private bool yq() {
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;
		}
		private void zq(int oi) {
			SaveInteger(i9, 'n000', 0, 0);
			SaveInteger(i9, 'h03B', 0, 1);
			SaveInteger(i9, 'h03C', 0, 1);
			SaveInteger(i9, 'n01X', 0, 1);
			SaveInteger(i9, 'n024', 0, 1);
			SaveInteger(i9, 'n01M', 0, 1);
			SaveInteger(i9, 'z002', 0, 2);
			SaveInteger(i9, 'z003', 0, 2);
			SaveInteger(i9, 'n00B', 0, 2);
			SaveInteger(i9, 'n01K', 0, 2);
			SaveInteger(i9, 'u007', 0, 2);
			SaveInteger(i9, 'n00C', 0, 2);
			SaveInteger(i9, 'n00L', 0, 2);
			SaveInteger(i9, 'n00M', 0, 2);
			SaveInteger(i9, 'n00N', 0, 2);
			SaveInteger(i9, 'n00O', 0, 2);
			SaveInteger(i9, 'n00P', 0, 2);
			SaveInteger(i9, 'n00Q', 0, 2);
			SaveInteger(i9, 'n00R', 0, 2);
			SaveInteger(i9, 'n00O', 0, 2);
			SaveInteger(i9, 'h034', 0, 3);
			SaveInteger(i9, 'h03N', 0, 3);
			SaveInteger(i9, 'n00E', 0, 3);
			SaveInteger(i9, 'hfoo', 0, 4);
			SaveInteger(i9, 'h03A', 0, 4);
			SaveInteger(i9, 'h02W', 0, 4);
			SaveInteger(i9, 'h02X', 0, 4);
			SaveInteger(i9, 'h02Y', 0, 4);
			SaveInteger(i9, 'o002', 0, 4);
			SaveInteger(i9, 'o004', 0, 4);
			SaveInteger(i9, 'o005', 0, 4);
			SaveInteger(i9, 'u002', 0, 4);
			SaveInteger(i9, 'u00B', 0, 4);
			SaveInteger(i9, 'n01I', 0, 4);
			SaveInteger(i9, 'n01H', 0, 4);
			SaveInteger(i9, 'n027', 0, 4);
			SaveInteger(i9, 'n006', 0, 4);
			SaveInteger(i9, 'n00Y', 0, 4);
			SaveInteger(i9, 'n017', 0, 4);
			SaveInteger(i9, 'n018', 0, 4);
			SaveInteger(i9, 'n016', 0, 4);
			SaveInteger(i9, 'n029', 0, 4);
			SaveInteger(i9, 'n02B', 0, 4);
			SaveInteger(i9, 'n009', 0, 4);
			SaveInteger(i9, 'n00Z', 0, 4);
			SaveInteger(i9, 'n00I', 0, 4);
			SaveInteger(i9, 'n00J', 0, 4);
			SaveInteger(i9, 'n00K', 0, 4);
			SaveInteger(i9, 'h06U', 0, 4);
			SaveInteger(i9, 'e00F', 0, 4);
			SaveInteger(i9, 'o007', 0, 5);
			SaveInteger(i9, 'n01T', 0, 5);
			SaveInteger(i9, 'h01V', 0, 5);
			SaveInteger(i9, 'h01U', 0, 5);
			SaveInteger(i9, 'h05H', 0, 5);
			SaveInteger(i9, 'n01G', 0, 5);
			SaveInteger(i9, 'n012', 0, 5);
			SaveInteger(i9, 'n013', 0, 5);
			SaveInteger(i9, 'n00T', 0, 5);
			SaveInteger(i9, 'n00U', 0, 5);
			SaveInteger(i9, 'n01N', 0, 5);
			SaveInteger(i9, 'n01W', 0, 5);
			SaveInteger(i9, 'n002', 0, 5);
			SaveInteger(i9, 'n00X', 0, 5);
			SaveInteger(i9, 'e00B', 0, 6);
			SaveInteger(i9, 'e00A', 0, 6);
			SaveInteger(i9, 'h034', 1, 0);
			SaveInteger(i9, 'h03N', 1, 0);
			SaveInteger(i9, 'h01V', 1, 0);
			SaveInteger(i9, 'h01U', 1, 0);
			SaveInteger(i9, 'h05H', 1, 0);
			SaveInteger(i9, 'n00R', 1, 0);
			SaveInteger(i9, 'o007', 1, 1);
			SaveInteger(i9, 'z002', 1, 1);
			SaveInteger(i9, 'z003', 1, 1);
			SaveInteger(i9, 'u002', 1, 1);
			SaveInteger(i9, 'u00B', 1, 1);
			SaveInteger(i9, 'n01M', 1, 1);
			SaveInteger(i9, 'n01C', 1, 1);
			SaveInteger(i9, 'e00B', 1, 1);
			SaveInteger(i9, 'e00A', 1, 1);
			SaveInteger(i9, 'n00N', 1, 1);
			SaveInteger(i9, 'hfoo', 1, 2);
			SaveInteger(i9, 'h03A', 1, 2);
			SaveInteger(i9, 'h03B', 1, 2);
			SaveInteger(i9, 'h03C', 1, 2);
			SaveInteger(i9, 'o002', 1, 2);
			SaveInteger(i9, 'o004', 1, 2);
			SaveInteger(i9, 'o005', 1, 2);
			SaveInteger(i9, 'n01I', 1, 2);
			SaveInteger(i9, 'n01H', 1, 2);
			SaveInteger(i9, 'n027', 1, 2);
			SaveInteger(i9, 'n006', 1, 2);
			SaveInteger(i9, 'n00Y', 1, 2);
			SaveInteger(i9, 'n00P', 1, 2);
			SaveInteger(i9, 'n000', 1, 2);
			SaveInteger(i9, 'n002', 1, 2);
			SaveInteger(i9, 'n00X', 1, 2);
			SaveInteger(i9, 'h06U', 1, 2);
			SaveInteger(i9, 'n024', 1, 3);
			SaveInteger(i9, 'n00M', 1, 3);
			SaveInteger(i9, 'h02W', 1, 4);
			SaveInteger(i9, 'h02X', 1, 4);
			SaveInteger(i9, 'h02Y', 1, 4);
			SaveInteger(i9, 'n01X', 1, 4);
			SaveInteger(i9, 'n01T', 1, 4);
			SaveInteger(i9, 'n00B', 1, 4);
			SaveInteger(i9, 'n01K', 1, 4);
			SaveInteger(i9, 'u007', 1, 4);
			SaveInteger(i9, 'n01G', 1, 4);
			SaveInteger(i9, 'n012', 1, 4);
			SaveInteger(i9, 'n013', 1, 4);
			SaveInteger(i9, 'n009', 1, 4);
			SaveInteger(i9, 'n00Z', 1, 4);
			SaveInteger(i9, 'n00L', 1, 4);
			SaveInteger(i9, 'n00O', 1, 4);
			SaveInteger(i9, 'e00F', 1, 5);
			SaveInteger(i9, 'n018', 1, 6);
			SaveInteger(i9, 'n016', 1, 6);
			SaveInteger(i9, 'n029', 1, 6);
			SaveInteger(i9, 'n02B', 1, 6);
			SaveInteger(i9, 'n00T', 1, 6);
			SaveInteger(i9, 'n00U', 1, 6);
			SaveInteger(i9, 'n01N', 1, 6);
			SaveInteger(i9, 'n01W', 1, 6);
			SaveInteger(i9, 'n00Q', 1, 6);
			SaveInteger(i9, 'n00I', 1, 6);
			SaveInteger(i9, 'n00J', 1, 6);
			SaveInteger(i9, 'n00K', 1, 6);
		}
		private void Aq(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function wp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function xp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function yp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function zp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Ap));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function ap));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void aq(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function wp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function xp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function yp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function zp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Ap));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function ap));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void Bq(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Bp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function bp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Cp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function cp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Dp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Ep));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Fp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Gp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Hp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Ip));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void bq(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function lp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Jp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Kp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Lp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Mp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Np));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Op));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Pp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Qp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Rp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Sp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Tp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void Cq(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Up));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Vp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Wp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Xp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Yp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Zp));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function dq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function eq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function fq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function gq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function hq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function iq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void cq(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function jq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function kq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function mq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function nq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function oq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function qq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function rq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function sq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function tq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function uq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function vq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function wq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void Dq(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function xq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function yq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void Eq(int oi, unit u) {
			int id = LoadInteger(i9,GetUnitTypeId(u),0);
			if (id==1 ) {
				Aq(oi, u);
			} else if (id==2 ) {
				aq(oi, u);
			} else if (id==3 ) {
				Bq(oi, u);
			} else if (id==4 ) {
				bq(oi, u);
			} else if (id==5 ) {
				Cq(oi, u);
			} else if (id==6 ) {
				cq(oi, u);
			} else if (id==0 ) {
				Dq(oi, u);
			}
		}
		private bool Fq() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9));
		}
		private bool Gq() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3);
		}
		private bool Hq() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3);
		}
		private bool Iq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)))!=null;
		}
		private bool lq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)))!=null;
		}
		private bool Jq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (IsUnitEnemy(GetFilterUnit(),e9)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null;
		}
		private bool Kq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (IsUnitEnemy(GetFilterUnit(),e9)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)))!=null;
		}
		private bool Lq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool Mq() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4);
		}
		private bool Nq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool Oq() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4);
		}
		private bool Pq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool Qq() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.);
		}
		private bool Rq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool Sq() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6));
		}
		private bool Tq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool Uq() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.);
		}
		private bool Vq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool Wq() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1);
		}
		private bool Xq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool Yq() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1);
		}
		private bool Zq() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool dr() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1);
		}
		private bool er() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool fr() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.);
		}
		private bool gr() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool hr() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6));
		}
		private bool ir() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool jr() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.);
		}
		private bool kr() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool mr() {
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2);
		}
		private bool nr() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null;
		}
		private bool UnitsAI___rangedAA2() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool UnitsAI___rangedAA3() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null;
		}
		private bool UnitsAI___rangedAA4() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private bool UnitsAI___rangedAA5() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null;
		}
		private bool UnitsAI___rangedAA6() {
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;
		}
		private void qr(int oi) {
			SaveInteger(i9, 'n05C', 0, 0);
			SaveInteger(i9, 'o00C', 0, 0);
			SaveInteger(i9, 'o00D', 0, 0);
			SaveInteger(i9, 'o00E', 0, 0);
			SaveInteger(i9, 'h05C', 0, 0);
			SaveInteger(i9, 'h06Q', 0, 0);
			SaveInteger(i9, 'h06R', 0, 0);
			SaveInteger(i9, 'h02Z', 0, 2);
			SaveInteger(i9, 'h030', 0, 2);
			SaveInteger(i9, 'h04I', 0, 2);
			SaveInteger(i9, 'e007', 0, 2);
			SaveInteger(i9, 'e00J', 0, 2);
			SaveInteger(i9, 'h00W', 0, 2);
			SaveInteger(i9, 'n014', 0, 2);
			SaveInteger(i9, 'h010', 0, 2);
			SaveInteger(i9, 'e00C', 0, 2);
			SaveInteger(i9, 'n001', 0, 2);
			SaveInteger(i9, 'n02A', 0, 2);
			SaveInteger(i9, 'n01R', 0, 2);
			SaveInteger(i9, 'n01P', 0, 2);
			SaveInteger(i9, 'n01Q', 0, 2);
			SaveInteger(i9, 'n00S', 0, 2);
			SaveInteger(i9, 'hmtm', 0, 3);
			SaveInteger(i9, 'o001', 0, 3);
			SaveInteger(i9, 'n01F', 0, 3);
			SaveInteger(i9, 'n01E', 0, 3);
			SaveInteger(i9, 'e005', 0, 3);
			SaveInteger(i9, 'e002', 0, 3);
			SaveInteger(i9, 'n007', 0, 3);
			SaveInteger(i9, 'n00V', 0, 4);
			SaveInteger(i9, 'n01O', 0, 4);
			SaveInteger(i9, 'h06S', 0, 4);
			SaveInteger(i9, 'h098', 0, 4);
			SaveInteger(i9, 'n00A', 0, 4);
			SaveInteger(i9, 'z000', 0, 4);
			SaveInteger(i9, 'n004', 0, 4);
			SaveInteger(i9, 'u000', 0, 4);
			SaveInteger(i9, 'h06T', 0, 4);
			SaveInteger(i9, 'hrif', 0, 5);
			SaveInteger(i9, 'h0A2', 0, 5);
			SaveInteger(i9, 'o00D', 0, 5);
			SaveInteger(i9, 'o00E', 0, 5);
			SaveInteger(i9, 'o006', 0, 5);
			SaveInteger(i9, 'o008', 0, 5);
			SaveInteger(i9, 'o00B', 0, 5);
			SaveInteger(i9, 'o009', 0, 5);
			SaveInteger(i9, 'n00D', 0, 5);
			SaveInteger(i9, 'n01L', 0, 5);
			SaveInteger(i9, 'e001', 0, 5);
			SaveInteger(i9, 'e003', 0, 5);
			SaveInteger(i9, 'e004', 0, 5);
			SaveInteger(i9, 'n022', 0, 5);
			SaveInteger(i9, 'n023', 0, 5);
			SaveInteger(i9, 'n01Y', 0, 5);
			SaveInteger(i9, 'n011', 0, 5);
			SaveInteger(i9, 'e006', 0, 5);
			SaveInteger(i9, 'e009', 0, 5);
			SaveInteger(i9, 'e00C', 0, 5);
			SaveInteger(i9, 'h016', 0, 6);
			SaveInteger(i9, 'o003', 0, 6);
			SaveInteger(i9, 'u005', 0, 6);
			SaveInteger(i9, 'u009', 0, 6);
			SaveInteger(i9, 'u00D', 0, 6);
			SaveInteger(i9, 'u001', 0, 6);
			SaveInteger(i9, 'u00A', 0, 6);
			SaveInteger(i9, 'u003', 0, 6);
			SaveInteger(i9, 'n01B', 0, 6);
			SaveInteger(i9, 'n01D', 0, 6);
			SaveInteger(i9, 'n019', 0, 6);
			SaveInteger(i9, 'n01A', 0, 6);
			SaveInteger(i9, 'e000', 0, 6);
			SaveInteger(i9, 'h07B', 0, 6);
			SaveInteger(i9, 'h00U', 0, 6);
			SaveInteger(i9, 'n015', 0, 6);
			SaveInteger(i9, 'o00A', 0, 6);
			SaveInteger(i9, 'n026', 0, 6);
			SaveInteger(i9, 'n028', 0, 6);
			SaveInteger(i9, 'n008', 0, 6);
			SaveInteger(i9, 'n00H', 0, 6);
			SaveInteger(i9, 'o006', 1, 1);
			SaveInteger(i9, 'o008', 1, 1);
			SaveInteger(i9, 'o00B', 1, 1);
			SaveInteger(i9, 'u000', 1, 1);
			SaveInteger(i9, 'u00A', 1, 1);
			SaveInteger(i9, 'u003', 1, 1);
			SaveInteger(i9, 'n00D', 1, 1);
			SaveInteger(i9, 'n01L', 1, 1);
			SaveInteger(i9, 'n019', 1, 1);
			SaveInteger(i9, 'n01A', 1, 1);
			SaveInteger(i9, 'e001', 1, 1);
			SaveInteger(i9, 'e003', 1, 1);
			SaveInteger(i9, 'e004', 1, 1);
			SaveInteger(i9, 'e000', 1, 1);
			SaveInteger(i9, 'n015', 1, 1);
			SaveInteger(i9, 'o00A', 1, 1);
			SaveInteger(i9, 'n026', 1, 1);
			SaveInteger(i9, 'n028', 1, 1);
			SaveInteger(i9, 'n00A', 1, 1);
			SaveInteger(i9, 'z000', 1, 1);
			SaveInteger(i9, 'n008', 1, 1);
			SaveInteger(i9, 'n00H', 1, 1);
			SaveInteger(i9, 'h03P', 1, 2);
			SaveInteger(i9, 'h03R', 1, 2);
			SaveInteger(i9, 'h02Z', 1, 2);
			SaveInteger(i9, 'h030', 1, 2);
			SaveInteger(i9, 'h099', 1, 2);
			SaveInteger(i9, 'h06S', 1, 2);
			SaveInteger(i9, 'h06T', 1, 2);
			SaveInteger(i9, 'h098', 1, 2);
			SaveInteger(i9, 'n01E', 1, 2);
			SaveInteger(i9, 'n01F', 1, 2);
			SaveInteger(i9, 'e005', 1, 2);
			SaveInteger(i9, 'e002', 1, 2);
			SaveInteger(i9, 'n007', 1, 2);
			SaveInteger(i9, 'n01Y', 1, 2);
			SaveInteger(i9, 'hrif', 1, 4);
			SaveInteger(i9, 'h02A', 1, 4);
			SaveInteger(i9, 'h05C', 1, 4);
			SaveInteger(i9, 'h016', 1, 4);
			SaveInteger(i9, 'o00C', 1, 4);
			SaveInteger(i9, 'o00D', 1, 4);
			SaveInteger(i9, 'o00E', 1, 4);
			SaveInteger(i9, 'o001', 1, 4);
			SaveInteger(i9, 'n00V', 1, 4);
			SaveInteger(i9, 'n01O', 1, 4);
			SaveInteger(i9, 'h04I', 1, 4);
			SaveInteger(i9, 'n01B', 1, 4);
			SaveInteger(i9, 'n01D', 1, 4);
			SaveInteger(i9, 'h00U', 1, 4);
			SaveInteger(i9, 'e006', 1, 4);
			SaveInteger(i9, 'e009', 1, 4);
			SaveInteger(i9, 'e00C', 1, 4);
			SaveInteger(i9, 'n01P', 1, 4);
			SaveInteger(i9, 'n01Q', 1, 4);
			SaveInteger(i9, 'n01R', 1, 4);
			SaveInteger(i9, 'n004', 1, 4);
			SaveInteger(i9, 'hmtm', 1, 6);
			SaveInteger(i9, 'n005', 1, 6);
			SaveInteger(i9, 'o009', 1, 6);
			SaveInteger(i9, 'o003', 1, 6);
			SaveInteger(i9, 'u005', 1, 6);
			SaveInteger(i9, 'u009', 1, 6);
			SaveInteger(i9, 'u00D', 1, 6);
			SaveInteger(i9, 'e007', 1, 6);
			SaveInteger(i9, 'e00J', 1, 6);
			SaveInteger(i9, 'h07B', 1, 6);
			SaveInteger(i9, 'h00W', 1, 6);
			SaveInteger(i9, 'n022', 1, 6);
			SaveInteger(i9, 'n023', 1, 6);
			SaveInteger(i9, 'n014', 1, 6);
			SaveInteger(i9, 'n00S', 1, 6);
		}
		private void rr(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Fq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Gq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Hq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Iq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void sr(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function lq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Jq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Kq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void tr(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Lq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Mq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Nq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Oq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Pq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Qq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Rq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Sq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Tq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Uq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Vq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Wq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void ur(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Xq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Yq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Zq));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function dr));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function er));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function fr));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function gr));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function hr));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function ir));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function jr));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function kr));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function mr));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void vr(int oi, unit u) {
			unit t;
			co((e9), ((GetUnitX(u))*1.), ((GetUnitY(u))*1.), ((700.)*1.));
			Co();
			t = Oo(r9,j9,n9,0);
			if ((t!=null)) {
				IssueTargetOrderById(u, $D000F, t);
				t = null;
				return;
			}
			Co();
			t = Oo(r9,n9,0,0);
			if ((t!=null)) {
				IssueTargetOrderById(u, $D000F, t);
				t = null;
				return;
			}
			Co();
			t = Oo(w9,j9,n9,0);
			if ((t!=null)) {
				IssueTargetOrderById(u, $D000F, t);
				t = null;
				return;
			}
			Co();
			t = Oo(w9,n9,0,0);
			if ((t!=null)) {
				IssueTargetOrderById(u, $D000F, t);
				t = null;
				return;
			}
			Co();
			t = Oo(t9,j9,n9,0);
			if ((t!=null)) {
				IssueTargetOrderById(u, $D000F, t);
				t = null;
				return;
			}
			Co();
			t = Oo(t9,n9,0,0);
			if ((t!=null)) {
				IssueTargetOrderById(u, $D000F, t);
				t = null;
				return;
			}
		}
		private void wr(int oi, unit u) {
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function nr));
			if (FirstOfGroup(h9)!=null ) {
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));
				return;
			}
		}
		private void xr(int oi, unit u) {
			int id = LoadInteger(i9,GetUnitTypeId(u),0);
			if (id==1 ) {
			} else if (id==2 ) {
				rr(oi, u);
			} else if (id==3 ) {
				sr(oi, u);
			} else if (id==4 ) {
				tr(oi, u);
			} else if (id==5 ) {
				ur(oi, u);
			} else if (id==6 ) {
				vr(oi, u);
			} else if (id==0 ) {
				wr(oi, u);
			}
		}
		private void yr(unit u) {
			e9 = GetOwningPlayer(u);
			if (IsUnitType(u,UNIT_TYPE_MELEE_ATTACKER)) {
				Eq(f9, u);
			} else {
				xr(g9, u);
			}
			GroupClear(h9);
		}
		private void zr() {
			h9 = CreateGroup();
			f9 = si();
			g9 = ri();
			zq(f9);
			qr(g9);
			j9 = Fi();
			k9 = Ei();
			m9 = Di();
			n9 = ci();
			o9 = Ci();
			p9 = Bi();
			q9 = Ai();
			r9 = zi();
			s9 = yi();
			t9 = xi();
			u9 = wi();
			v9 = ui();
			w9 = Ji();
		}
		private void Ar(unit u, float r) {
			int ar = 20+R2I((r-500.)/ 50);
			float x = GetUnitX(u);
			float y = GetUnitY(u);
			int i = 0;
			string Br = "";
			float an;
			JassArray<effect> e = new JassArray<effect>();
			if ((GetOwningPlayer(u)==GetLocalPlayer())) {
				Br = "Abilities\\Spells\\NightElf\\Barkskin\\BarkSkinTarget.mdl";
			}
			while (true) {
				if (i>=ar) { break; }
				an = 2.*bj_PI*i/ ar;
				e[i] = AddSpecialEffect("Abilities\\Spells\\NightElf\\Barkskin\\BarkSkinTarget.mdl",x+r*Cos(an),y+r*Sin(an));
				i = i+1;
			}
			TriggerSleepAction(6.);
			i = 0;
			while (true) {
				if (i>=ar) { break; }
				DestroyEffect(e[i]);
				e[i] = null;
				i = i+1;
			}
		}
		private void br(unit u) {
			IssuePointOrderByIdLoc(u, $D0012, Id[me[GetPlayerId(GetOwningPlayer(u))]+2]);
		}
		private bool Cr() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitType(u,UNIT_TYPE_GROUND) && GetUnitAbilityLevel(u,'Avul')<=0 && GetUnitAbilityLevel(u,'A08H')<=0;
			u = null;
			return Im;
		}
		private void cr(unit u, int Dr) {
			player p = GetOwningPlayer(u);
			int dk = GetPlayerId(p);
			if ((ad>0)) {
				if ((he[dk]+Dr>=ad)) {
					Dr = ad-he[dk];
					if ((Dr<=0)) {
						return;
					}
					he[dk] = ad;
				} else {
					he[dk] = he[dk]+(Dr);
				}
			}
			AdjustPlayerStateBJ(Dr, p, PLAYER_STATE_RESOURCE_LUMBER);
			bj_lastCreatedTextTag = CreateTextTag();
			SetTextTagText(bj_lastCreatedTextTag, I2S(Dr), .024);
			SetTextTagPos(bj_lastCreatedTextTag, GetUnitX(u)-36., GetUnitY(u)-16., .0);
			SetTextTagColor(bj_lastCreatedTextTag, 0, $C8, 80, $FF);
			SetTextTagPermanent(bj_lastCreatedTextTag, false);
			SetTextTagLifespan(bj_lastCreatedTextTag, 3.);
			SetTextTagFadepoint(bj_lastCreatedTextTag, 1.);
			SetTextTagVelocity(bj_lastCreatedTextTag, 0, .06);
			if ((p!=GetLocalPlayer())) {
				SetTextTagVisibility(bj_lastCreatedTextTag, false);
			} else {
				SetTextTagVisibility(bj_lastCreatedTextTag, true);
			}
		}
		private void Er(unit u) {
			int i = GetUnitAbilityLevel(u,'A09L');
			if ((i==2)) {
				SetUnitAbilityLevel(u, 'A09L', 1);
				SetUnitState(u, UNIT_STATE_MANA, GetUnitState(u, UNIT_STATE_MANA)+100.);
				UnitAddAbility(u, 'A09M');
				SetUnitAbilityLevel(u, 'A09M', 3);
				UnitRemoveAbility(u, 'A09M');
				SetUnitState(u, UNIT_STATE_LIFE, GetWidgetLife(u)+200.);
			} else {
				UnitRemoveAbility(u, 'A09L');
			}
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Items\\AIvi\\AIviTarget.mdl", u, "origin"));
		}
		private void Fr(unit u) {
			int i = GetUnitAbilityLevel(u,'A09C')+1;
			if ((i>=6)) {
				return;
			}
			SetUnitAbilityLevel(u, 'A09C', i);
			SetUnitAbilityLevel(u, 'A09B', i);
			SetUnitAbilityLevel(u, 'A00J', i);
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl", u, "origin"));
		}
		private bool Gr(unit u) {
			if ((GetUnitAbilityLevel(u,'A09L')>0)) {
				Er(u);
				return true;
			} else if ((GetUnitTypeId(u)=='n01T')) {
				if ((GetRandomInt(0,99)<60)) {
					Fr(u);
					return true;
				} else {
					return false;
				}
			}
			return GetUnitAbilityLevel(u,'A070')>0;
		}
		private bool Hr(unit u) {
			if ((Gr(u))) {
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl", u, "origin"));
				return true;
			}
			return false;
		}
		private bool Ir() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,'Avul')<=0 && GetUnitAbilityLevel(u,'A08H')<=0;
			u = null;
			return Im;
		}
		private void lr() {
			Lo(GetEnumUnit());
		}
		private void Jr() {
			ForGroup(z9, function lr);
		}
		private bool Kr() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && GetUnitCurrentOrder(u)==0 && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,'A07I')<=0 && GetUnitAbilityLevel(u,'A07M')<=0;
			u = null;
			return Im;
		}
		private void Lr() {
			Po(GetEnumUnit());
		}
		private void Mr() {
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, A9);
			ForGroup(q4, function Lr);
		}
		private void Nr() {
			bool Pr = false;
			int i = 0;
			while (true) {
				if ((Pd[i]=='h089' || Pd[i]=='h06P')) {
					Pr = true;
				}
				i = i+1;
				if (i>$B || Pr) { break; }
			}
			if ((Pr)) {
				TimerStart(a9, 2., true, function Jr);
			}
		}
		private void Functions_CheckAndStartCommon() {
			TimerStart(B9, 4., true, function Mr);
		}
		private bool Qr() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitType(u,UNIT_TYPE_PEON);
			u = null;
			return Im;
		}
		private void Rr() {
			SetUnitAnimation(GetEnumUnit(), "stand");
		}
		private void Sr(unit u, unit Tr) {
			player p = GetOwningPlayer(Tr);
			int dk = GetPlayerId(p);
			bool Ur = GetUnitAbilityLevel(Tr,'B01K')>0;
			if ((GetUnitAbilityLevel(u,'A0DZ')>0)) {
				IssueImmediateOrderById(u, $D02BB);
				UnitApplyTimedLife(u, 'BTLF', 1.);
				u = GetSummonedUnit();
				if ((u==null)) {
					return;
				}
			}
			if ((Ur)) {
				UnitAddAbility(u, 'A09M');
				SetUnitAbilityLevel(u, 'A09M', 3);
				UnitRemoveAbility(u, 'A09M');
				UnitAddAbility(u, 'A09Q');
				UnitAddAbility(u, 'A09R');
			}
			if ((GetUnitAbilityLevel(Tr,'A0EL')>0 && GetRandomInt(0,99)<30)) {
				UnitAddAbility(u, 'A0EZ');
				UnitAddAbility(u, 'A0C5');
			}
			Vo(u);
			Rd[dk] = Rd[dk]+1;
			if ((GetUnitAbilityLevel(u,'A07M')>=1)) {
				Mo(u);
				GroupAddUnit(z9, u);
			}
		}
		private void Vr() {
			unit u = GetEnumUnit();
			bj_forLoopAIndex = bj_forLoopAIndex+1;
			if ((bj_forLoopAIndex<=2 && GetRandomInt(0,99)<17)) {
				Sr(CreateUnit(GetOwningPlayer(u), GetUnitTypeId(bj_lastCreatedUnit), GetUnitX(bj_lastCreatedUnit), GetUnitY(bj_lastCreatedUnit), .0), bj_lastLoadedUnit);
				if ((GetUnitAbilityLevel(bj_lastCreatedUnit,'A09H')>0)) {
					Sr(CreateUnit(GetOwningPlayer(u), GetUnitTypeId(bj_lastCreatedUnit), GetUnitX(bj_lastCreatedUnit), GetUnitY(bj_lastCreatedUnit), .0), bj_lastLoadedUnit);
				}
			}
			u = null;
		}
		private void Wr(unit u, unit Tr) {
			player p = GetOwningPlayer(Tr);
			int dk = GetPlayerId(p);
			bool Ur = GetUnitAbilityLevel(Tr,'B01K')>0;
			if ((GetUnitAbilityLevel(u,'A0DZ')>0)) {
				ShowUnit(u, false);
				IssueImmediateOrderById(u, $D02BB);
				UnitApplyTimedLife(u, 'BTLF', 1.);
			}
			if ((Ur)) {
				UnitAddAbility(u, 'A09M');
				SetUnitAbilityLevel(u, 'A09M', 3);
				UnitRemoveAbility(u, 'A09M');
				UnitAddAbility(u, 'A09Q');
				UnitAddAbility(u, 'A09R');
			}
			Vo(u);
			Rd[dk] = Rd[dk]+1;
			if ((GetUnitAbilityLevel(u,'A07M')>=1)) {
				Mo(u);
				GroupAddUnit(z9, u);
			} else if ((GetUnitAbilityLevel(u,'A09H')>0)) {
				Sr(CreateUnit(p, GetUnitTypeId(u), GetUnitX(u), GetUnitY(u), .0), Tr);
			}
			if ((GetUnitAbilityLevel(u,'A070')<=0)) {
				bj_lastCreatedUnit = u;
				bj_lastLoadedUnit = Tr;
				bj_forLoopAIndex = 0;
				ForGroup(Jd[me[dk]], function Vr);
			}
		}
		private void Xr() {
			y9 = Filter(function Ir);
			A9 = Filter(function Kr);
			x9 = Filter(function Cr);
			b9 = Filter(function Qr);
		}
		private void Yr(int x, int y, string lb) {
			int i = 0;
			while (true) {
				if ((D9[i]!=null)) {
					J9 = MultiboardGetItem(D9[i],y,x);
					MultiboardSetItemValue(J9, lb);
					MultiboardReleaseItem(J9);
				}
				i = i+1;
				if (i>$B) { break; }
			}
			if ((x==1)) {
				J9 = MultiboardGetItem(G9,1,(y-1)*6+1);
				MultiboardSetItemValue(J9, lb);
				MultiboardReleaseItem(J9);
			} else if ((x>2 && x<5)) {
				J9 = MultiboardGetItem(G9,1,(y-1)*6+x-1);
				MultiboardSetItemValue(J9, lb);
				MultiboardReleaseItem(J9);
			} else if ((x==5)) {
				J9 = MultiboardGetItem(G9,I9,$A);
				MultiboardSetItemValue(J9, lb);
				MultiboardReleaseItem(J9);
			}
		}
		private void Zr(int x, int y, string lb) {
			J9 = MultiboardGetItem(G9,x,y);
			MultiboardSetItemValue(J9, lb);
			MultiboardReleaseItem(J9);
		}
		private string ds() {
			string s = I2S(N9);
			if ((N9<$A)) {
				s = "0"+s;
			}
			return "|cffFFFF00"+I2S(M9)+"|cffFF8000:|cffFFFF00"+s+"|r";
		}
		private void es() {
			N9 = N9+1;
			if ((N9==60)) {
				N9 = 0;
				M9 = M9+1;
			}
			Yr(5, 3, ds());
		}
		private bool fs() {
			int pl = CountPlayersInForceBJ(ie);
			int pr = CountPlayersInForceBJ(je);
			int pq = CountPlayersInForceBJ(ke);
			int pc = pl+pr;
			int gs = IntegerTertiaryOp(Bd>0,2*Bd,-Bd);
			if ((bd>0 && pc*bd>l7-gs)) {
				return false;
			}
			if ((pc>l7-gs)) {
				return false;
			}
			if ((pc*(bd-1)>pq)) {
				return false;
			}
			if ((pc>l7 && td)) {
				return false;
			}
			if ((Dd>0 && tn(IMaxBJ(pl,pr)*Dd,IMinBJ(pl,pr))*2>pq+pc)) {
				return false;
			}
			return true;
		}
		private void hs(bool fl) {
			zd = fl;
			zr();
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00AI|r enabled. Units will choose targets by its armor type.");
		}
		private void is(bool fl) {
			md = !fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Artillery|r enabled. You can build structures that attack enemy structures.");
				df = 'n01C';
				zf = 'A07T';
				We = 'A01I';
				vf = 'A0BD';
				x8 = 'A0D1';
				y8 = 'A0D0';
				z8 = 'A0E3';
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Artillery|r has been chosen. You cannot build structures that attack enemy structures.");
				df = 'n021';
				zf = 'A08T';
				We = 'A05H';
				vf = 'A0BQ';
				x8 = 'A0D2';
				y8 = 'A0D3';
				z8 = 'A0E4';
			}
			bj_forLoopAIndex = 0;
			bj_forLoopAIndexEnd = $B;
			while (true) {
				if (bj_forLoopAIndex>bj_forLoopAIndexEnd) { break; }
				SetPlayerUnitAvailableBJ('h001', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('h048', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('h01E', fl, Player(bj_forLoopAIndex));
				bj_forLoopAIndex = bj_forLoopAIndex+1;
			}
		}
		private void js(bool fl) {
			xd = fl;
			if ((!fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No AFK|r mode has been disabled. Command -afk enabled.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No AFK|r has been chosen. Command -afk disabled.");
			}
		}
		private void ks() {
			Cd = 1;
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Coin|r has been chosen. There will be a coin spawn every 40 seconds.");
		}
		private void ms() {
			Cd = $A;
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Crazy Coins|r has been chosen. Ten coins will spawn every 40 seconds.");
		}
		private void ns(bool fl) {
			kd = fl;
			if ((!fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Dual Race|r mode has been disabled.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Dual Race|r has been chosen. Each race can be chosen more than once per team.");
			}
		}
		private void os(bool fl) {
			td = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Unique Races|r has been chosen. Each race can be chosen only once (even across the teams).");
				if (((CountPlayersInForceBJ(ie)+CountPlayersInForceBJ(je))+Bd*2>$A)) {
					td = false;
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Unique Races|r mode has been disabled due so many players.");
				}
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Unique Races|r mode has been disabled.");
			}
		}
		private void ps(bool fl) {
			nd = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Treasure Box|r mode has been disabled.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Treasure Box|r has been chosen. You cannot build Treasure Boxes.");
			}
			bj_forLoopAIndex = 0;
			bj_forLoopAIndexEnd = $B;
			while (true) {
				if (bj_forLoopAIndex>bj_forLoopAIndexEnd) { break; }
				SetPlayerUnitAvailableBJ('h008', fl, Player(bj_forLoopAIndex));
				bj_forLoopAIndex = bj_forLoopAIndex+1;
			}
		}
		private void qs(bool fl) {
			od = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Bounty|r mode has been disabled.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Bounty|r has been chosen. Neither units nor buildings will give bounty when destroyed.");
			}
			bj_forLoopAIndex = 0;
			bj_forLoopAIndexEnd = $B;
			while (true) {
				if (bj_forLoopAIndex>bj_forLoopAIndexEnd) { break; }
				SetPlayerFlagBJ(PLAYER_STATE_GIVES_BOUNTY, fl, Player(bj_forLoopAIndex));
				bj_forLoopAIndex = bj_forLoopAIndex+1;
			}
		}
		private void rs(bool fl) {
			pd = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Specials|r mode has been disabled.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Specials|r has been chosen. You can't build special buildings except towers and Treasure Boxes.");
			}
			bj_forLoopAIndex = 0;
			bj_forLoopAIndexEnd = $B;
			while (true) {
				if (bj_forLoopAIndex>bj_forLoopAIndexEnd) { break; }
				SetPlayerUnitAvailableBJ('h01P', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('h056', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('h014', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('h03Q', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('h01O', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('o000', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('h006', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('n01J', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('h073', fl, Player(bj_forLoopAIndex));
				SetPlayerUnitAvailableBJ('h05L', fl, Player(bj_forLoopAIndex));
				bj_forLoopAIndex = bj_forLoopAIndex+1;
			}
		}
		private void ss(bool fl) {
			qd = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Items|r mode has been disabled.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Items|r has been chosen. The castle doesn't sell any items.");
			}
		}
		private void ts(bool fl) {
			rd = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Legendaries|r mode has been disabled.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Legendaries|r has been chosen. You don't get food to buy legendary buildings.");
			}
		}
		private void us(bool fl) {
			sd = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Rescue Strike|r mode has been disabled.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Rescue Strike|r has been chosen. Your worker doesn't have a Rescue Strike!");
			}
		}
		private void vs(int ws) {
			if ((ws<$96)) {
				ad = -1;
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Lumber Limit|r mode has been disabled.");
			} else {
				ad = ws;
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Lumber Limit|r has been set to |cffFFFF00"+I2S(ad)+"|r.");
			}
		}
		private void xs(int ws) {
			hd = IMaxBJ(IMinBJ(ws,'x'),2);
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Income Timer|r has been set to |cffFFFF00"+I2S(hd)+"|r.");
		}
		private void ys(int zs) {
			Ad = zs;
			if ((Ad==1)) {
				kf = 1000.;
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Taxes|r has been chosen. You don't have to pay taxes on your income.");
			} else if ((Ad==2)) {
				kf = 12.5;
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00High Taxes|r has been chosen. Tax rate increases 10% every 12.5 income.");
			}
		}
		private void As(bool fl) {
			ud = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Caging|r mode has been disabled.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Caging|r has been chosen. You can trap units with your buildings");
			}
		}
		private void as(bool fl) {
			vd = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Domination|r has been chosen. You gain extra income by controlling the lanes.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "TODO::SetDOMStatus(false)");
			}
		}
		private void Bs(int zs) {
			if ((zs>2)) {
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Wrong Autobalance variation!|r");
				return;
			}
			fd = zs;
			if ((zs==0)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Autobalance|r has been setted to |cffFFFF000|r. All units of any left player will be divided between members in team.");
			} else if ((zs==1)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Autobalance|r has been setted to |cffFFFF001|r. All depended players of any left player will be shared between members in team.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Autobalance|r has been setted to |cffFFFF001|r. AI will take control of any left player.");
			}
		}
		private void bs(int zs) {
			if ((zs==0)) {
				Bd = -1;
			} else {
				Bd = -zs;
			}
			if ((!fs())) {
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Too many players for Random Ban Race mode!|r");
				Bd = 0;
				return;
			}
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Random Ban Race|r has been chosen. Number of bans: |cffFFFF00"+I2S(IAbsBJ(Bd))+"|r.");
		}
		private void Cs(int zs) {
			if ((zs==0)) {
				Bd = 1;
			} else {
				Bd = zs;
			}
			if ((!fs())) {
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Too many players for Ban Race mode!|r");
				Bd = 0;
				return;
			}
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Ban Race|r has been chosen. Number of bans per team: |cffFFFF00"+I2S(Bd)+"|r.");
		}
		private void cs(int zs) {
			if ((zs==0)) {
				Dd = 1;
			} else {
				Dd = zs;
			}
			bd = 0;
			if ((!fs())) {
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Too many players for Extended Multi Race mode!|r");
				Dd = 0;
				return;
			}
			fd = 1;
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Extended Multiple Players|r has been chosen. Parameter's value is: |cffFFFF00"+I2S(Dd)+"|r.");
		}
		private void Ds(int zs) {
			if ((zs<1 || zs>5)) {
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Wrong number of players per player! Must be between 2 and 4!|r");
				return;
			}
			Dd = 0;
			bd = zs;
			if ((!fs())) {
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Too many players for Multi Race mode!|r");
				bd = 0;
				return;
			}
			fd = 1;
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Multiple Players|r has been chosen. Number of additional players per human player: |cffFFFF00"+I2S(zs)+"|r");
		}
		private void Es(bool fl) {
			wd = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Stop-detection|r system has been activated. Any player will be detected on bug usage.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "TODO::SetSDStatus(false)");
			}
		}
		private void Fs(bool fl) {
			yd = fl;
			if ((fl)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Debuging|r is on.");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Debuging|r is off.");
			}
		}
		private void Gs(int yj) {
			if ((IAbsBJ(yj)>5)) {
				cd = yj;
				if ((yj>0)) {
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Round time limit for win|r has been activated. Round will automatically end after "+I2S(IAbsBJ(yj))+" minutes and owner of first building will win.");
				} else {
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Round time limit for draw|r has been activated. Round will automatically end after "+I2S(IAbsBJ(yj))+" minutes with draw result.");
				}
			} else {
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Wrong value of minutes for round time limitation! Must be more 5!|r");
			}
		}
		private void Hs(int yj) {
			int p = l7;
			if ((yj==0)) {
				yj = 1;
			}
			l7 = l7-yj;
			if ((!fs())) {
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Not possible to disable so many races!|r");
				l7 = p;
				return;
			}
			Ed = yj;
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00System-races-pool|r has been changed. There are |cffFFFF00"+I2S(yj)+"|r new races have been removed.|r");
		}
		private void Is() {
			int i = 0;
			int j;
			player p;
			unit u;
			while (true) {
				if (i>$B) { break; }
				j = 1;
				p = Player(i);
				while (true) {
					u = CreateUnitAtLoc(p,'tec0'+j,R9,.0);
					ShowUnit(u, false);
					j = j+1;
					if (j>3) { break; }
				}
				i = i+1;
			}
		}
		private void ls(int i) {
			ge[i] = 0;
			mf[i] = .0;
			Rd[i] = -1;
			Sd[i] = -1;
			Td[i] = -1;
			Ud[i] = -1;
			Vd[i] = -1;
			Wd[i] = -1;
			Xd[i] = -1;
			Yd[i] = -1;
			Zd[i] = -1;
			de[i] = -1;
			ee[i] = -1;
			fe[i] = -1;
			he[i] = 0;
		}
		private void Js(int i) {
			ge[i] = 0;
			mf[i] = .5;
			Rd[i] = 0;
			Sd[i] = 0;
			Td[i] = 0;
			Ud[i] = 0;
			Vd[i] = 0;
			Wd[i] = 0;
			Xd[i] = 0;
			Yd[i] = 0;
			Zd[i] = 0;
			de[i] = 0;
			ee[i] = 0;
			fe[i] = 0;
			he[i] = '}';
		}
		private string Ks(int dk) {
			playercolor pc = GetPlayerColor(Player(dk));
			string Im;
			if ((pc==PLAYER_COLOR_RED)) {
				Im = "|cffff0000";
			} else if ((pc==PLAYER_COLOR_BLUE)) {
				Im = "|cff0000FF";
			} else if ((pc==PLAYER_COLOR_CYAN)) {
				Im = "|cff00FFFF";
			} else if ((pc==PLAYER_COLOR_PURPLE)) {
				Im = "|cff800080";
			} else if ((pc==PLAYER_COLOR_YELLOW)) {
				Im = "|cffFFFF00";
			} else if ((pc==PLAYER_COLOR_ORANGE)) {
				Im = "|cffFFCC00";
			} else if ((pc==PLAYER_COLOR_GREEN)) {
				Im = "|cff00ff00";
			} else if ((pc==PLAYER_COLOR_PINK)) {
				Im = "|cffff00ff";
			} else if ((pc==PLAYER_COLOR_LIGHT_GRAY)) {
				Im = "|cffc0c0c0";
			} else if ((pc==PLAYER_COLOR_LIGHT_BLUE)) {
				Im = "|cffCCFFFF";
			} else if ((pc==PLAYER_COLOR_AQUA)) {
				Im = "|cff087329";
			} else if ((pc==PLAYER_COLOR_BROWN)) {
				Im = "|cffC16D00";
			} else {
				Im = "|CFFFFFFFF";
			}
			pc = null;
			return Im;
		}
		private void Ls(int dk) {
			pe[dk] = Ks(dk)+GetPlayerName(Player(dk))+"|r";
		}
		private void Ms() {
			player p = GetEnumPlayer();
			int i = GetPlayerId(p);
			ForceRemovePlayer(ie, p);
			ForceRemovePlayer(je, p);
			ForceAddPlayer(ke, p);
			E9[i] = null;
		}
		private void Ns() {
			int i = 0;
			int j;
			player p;
			bool Os;
			while (true) {
				if ((ne[i]!=null)) {
					ForForce(ne[i], function Ms);
					SetPlayerName(Player(i), l9[i]);
				}
				i = i+1;
				if (i>$B) { break; }
			}
			i = 0;
			while (true) {
				if ((ne[i]!=null)) {
					Os = IsPlayerInForce(Player(i),ie);
					j = 1;
					while (true) {
						p = zn(Os);
						ForceRemovePlayer(ke, p);
						ForceAddPlayer(ne[i], p);
						if ((Os)) {
							ForceAddPlayer(ie, p);
							Qd[GetPlayerId(p)] = PolarProjectionBJ(Qd[i],96.*j,.0);
						} else {
							ForceAddPlayer(je, p);
							Qd[GetPlayerId(p)] = PolarProjectionBJ(Qd[i],96.*j,180.);
						}
						SetPlayerName(p, l9[i]);
						pe[GetPlayerId(p)] = Ks(GetPlayerId(p))+GetPlayerName(p)+"|r";
						me[GetPlayerId(p)] = me[i];
						j = j+1;
						if (j>=bd) { break; }
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void Ps() {
			int pl = CountPlayersInForceBJ(ie);
			int pr = CountPlayersInForceBJ(je);
			int Qs = tn(IMaxBJ(pl,pr)*Dd,IMinBJ(pl,pr));
			int Rs = Qs/ pl;
			int Ss = Qs/ pr;
			int i = 0;
			int j;
			int l;
			player p;
			bool Os;
			while (true) {
				if ((ne[i]!=null)) {
					ForForce(ne[i], function Ms);
					SetPlayerName(Player(i), l9[i]);
				}
				i = i+1;
				if (i>$B) { break; }
			}
			i = 0;
			while (true) {
				if ((ne[i]!=null)) {
					Os = IsPlayerInForce(Player(i),ie);
					l = IntegerTertiaryOp(Os,Rs,Ss);
					j = 1;
					while (true) {
						if (j>=l) { break; }
						p = zn(Os);
						ForceRemovePlayer(ke, p);
						ForceAddPlayer(ne[i], p);
						if ((Os)) {
							ForceAddPlayer(ie, p);
							Qd[GetPlayerId(p)] = PolarProjectionBJ(Qd[i],96.*j,.0);
						} else {
							ForceAddPlayer(je, p);
							Qd[GetPlayerId(p)] = PolarProjectionBJ(Qd[i],96.*j,180.);
						}
						SetPlayerName(p, l9[i]);
						pe[GetPlayerId(p)] = Ks(GetPlayerId(p))+GetPlayerName(p)+"|r";
						me[GetPlayerId(p)] = me[i];
						j = j+1;
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void Ts() {
			if ((Dd>0)) {
				Ps();
				return;
			} else if ((bd>0)) {
				Ns();
				return;
			}
			DisplayTimedTextToPlayer(GetLocalPlayer(), .0, .0, 60., "Unknown exception at module Main::SunAMP. Please report.");
		}
		private void Us() {
			int i = 0;
			player p = Player($C);
			C9 = GetWorldBounds();
			Q9 = Rect(-288.,3296.,-96.,3488.);
			while (true) {
				me[i] = 0;
				if ((GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING)) {
					ForceAddPlayer(ie, Player(i));
					CreateFogModifierRectBJ(true, Player(i), FOG_OF_WAR_VISIBLE, Q9);
					Qd[i] = dn(true);
					ne[i] = CreateForce();
					l9[i] = GetPlayerName(Player(i));
				} else if ((GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_EMPTY)) {
					ForceAddPlayer(ke, Player(i));
				}
				me[i+6] = 1;
				if ((GetPlayerSlotState(Player(i+6))==PLAYER_SLOT_STATE_PLAYING)) {
					ForceAddPlayer(je, Player(i+6));
					CreateFogModifierRectBJ(true, Player(i+6), FOG_OF_WAR_VISIBLE, Q9);
					Qd[i+6] = dn(false);
					ne[i+6] = CreateForce();
					l9[i+6] = GetPlayerName(Player(i+6));
				} else if ((GetPlayerSlotState(Player(i+6))==PLAYER_SLOT_STATE_EMPTY)) {
					ForceAddPlayer(ke, Player(i+6));
				}
				i = i+1;
				if (i>=6) { break; }
			}
			R9 = Location(-192.,3392.);
			Id[0] = GetRectCenter(Fg);
			Id[1] = GetRectCenter(Eg);
			Id[2] = GetRectCenter(Eg);
			Id[3] = GetRectCenter(Fg);
			Ld[0] = Dg;
			Ld[1] = cg;
			Od[0] = "|cffff0303Western Forces|r";
			Jd[0] = CreateGroup();
			Od[1] = "|cff20c000Eastern Forces|r";
			Jd[1] = CreateGroup();
			i = 0;
			while (true) {
				GroupAddUnit(P9, CreateUnit(p, 'h00L', -192., 3392., 270.));
				i = i+1;
				if (i>33) { break; }
			}
			p = Player($F);
			CreateUnit(p, 'h00L', -192., 3392., 270.);
			CreateUnit(p, 'nshp', 320., 1856., 270.);
			SetUnitColor(CreateUnit(p, 'nmrk', -256., -2816., 270.), ConvertPlayerColor(0));
			CreateUnit(p, 'nder', -4735.4, 3246.1, 109.526);
			CreateUnit(p, 'nfro', -1091.1, 2532.8, 224.842);
			CreateUnit(p, 'nfro', -1750.8, 3170.3, 12.503);
			CreateUnit(p, 'nfro', -4208.5, -3103.9, 62.844);
			CreateUnit(p, 'nrac', 3575.1, -3410.6, 28.565);
			CreateUnit(p, 'nrac', 215.3, -2989.1, 39.991);
			CreateUnit(p, 'nder', -734.9, -2927.2, 354.77);
			CreateUnit(p, 'nder', -778.4, 3161.3, 100.297);
			CreateUnit(p, 'nder', 486.3, 3092.6, 147.507);
			CreateUnit(p, 'nder', 2097.6, 2634.9, 173.293);
			CreateUnit(p, 'necr', 2734.8, 2968., 320.909);
			CreateUnit(p, 'necr', -601.3, 1917.2, 359.418);
			CreateUnit(p, 'necr', -2505.3, 3205.6, 108.405);
			CreateUnit(p, 'necr', -2553.8, 3097.9, 314.669);
			CreateUnit(p, 'nfro', 4466.5, 3139.7, 42.463);
			CreateUnit(p, 'nfro', 539.6, 2646.5, 108.054);
			CreateUnit(p, 'necr', -5469.2, 2773.2, 240.63);
			CreateUnit(p, 'nrac', -3882.6, 3455.9, 171.348);
			CreateUnit(p, 'necr', -2951.9, 3480.5, 75.248);
			CreateUnit(p, 'nder', -1995.2, 3031.8, 320.569);
			CreateUnit(p, 'nder', -4755.9, -3285.9, 96.265);
			CreateUnit(p, 'necr', -2813.4, -3182.2, 270.799);
			CreateUnit(p, 'nrac', -2009.7, -3134.2, 263.79);
			CreateUnit(p, 'nder', 5212.3, -3150.6, 44.199);
			CreateUnit(p, 'nfro', 4753.5, -3152.8, 349.596);
			CreateUnit(p, 'nrac', -10.6, 3013.2, 169.052);
			CreateUnit(p, 'ndwm', 1689.8, -2774.7, 192.19);
			CreateUnit(p, 'ndog', -3610.9, -3243.8, 118.216);
			CreateUnit(p, 'ndog', 1334.7, 2849.5, 136.344);
			CreateUnit(p, 'ndog', 3868.8, 3221.9, 302.375);
			CreateUnit(p, 'nshe', -5537.3, 3457.1, 52.22);
			CreateUnit(p, 'nsno', 824.5, 3262.9, 175.677);
			CreateUnit(p, 'nsno', 202.1, -2945.4, 216.679);
			CreateUnit(p, 'npnw', 745.5, 2441.4, 238.74);
			CreateUnit(p, 'npnw', -1503.3, 3397.6, 70.468);
			CreateUnit(p, 'nhmc', -1045.4, 2540.1, 279.314);
			CreateUnit(p, 'nskk', -1729., 3470.5, 317.767);
			CreateUnit(p, 'nskk', -2433.4, 2555.1, 311.109);
			CreateUnit(p, 'nskk', 3859.9, -3350.3, 329.995);
			CreateUnit(p, 'ncrb', 4721.1, -3370.7, 285.192);
			CreateUnit(p, 'nalb', 4473.6, -3164.3, 324.601);
			CreateUnit(p, 'nhmc', 4158.9, -3098.4, 273.93);
			Is();
			bj_forLoopAIndex = 0;
			bj_forLoopAIndexEnd = $B;
			while (true) {
				if (bj_forLoopAIndex>bj_forLoopAIndexEnd) { break; }
				SetPlayerFlagBJ(PLAYER_STATE_GIVES_BOUNTY, true, Player(bj_forLoopAIndex));
				pe[bj_forLoopAIndex] = Ks(bj_forLoopAIndex)+GetPlayerName(Player(bj_forLoopAIndex))+"|r";
				Gd[bj_forLoopAIndex] = true;
				bj_forLoopAIndex = bj_forLoopAIndex+1;
			}
			SetMapFlag(MAP_LOCK_RESOURCE_TRADING, true);
			FogMaskEnable(false);
			FogEnable(false);
			CreateQuestBJ(0, "Game Modes", "Gamemodes are entered by the red player in the first 20 seconds of game time.A gamemode consists of a dash followed by two characters and a number:The first character determines the race distribution.|cffFFFF00p :|r pick race|cffFFFF00d :|r draft race|cffFFFF00r :|r random race|cffFFFF00m :|r mirror mode (random)The second character determines how long races are kept:|cffFFFF00g :|r The race is determined in round one and then |cffFFFF80kept for the whole game|r|cffFFFF00r :|r The race is determined before |cffFFFF80EACH round|rThe 3rd character is a number between |cffFFFF001|r and |cffFFFF006|r determining the number of wins for overall victory|cffFFFF00Examples:|r-|cffFF0000r|cff00FF00r|cffFFFF002|r would start a |cffFF0000RANDOM|r race |cff00FF00EACH ROUND|r game with |cffFFFF002 wins|r for overall victory-|cffFF0000p|cff00FF00g|cffFFFF004|r would start a |cffFF0000PICK|r race |cff00FF00ONCE FOR WHOLE GAME|r game with |cffFFFF004 wins|r for overall victory", "ReplaceableTextures\\CommandButtons\\BTNPickUpItem.blp");
			CreateQuestBJ(0, "Modifications", "TRIGSTR_005", "ReplaceableTextures\\CommandButtons\\BTNSpy.blp");
			CreateQuestBJ(0, "Other Commands", "TRIGSTR_006", "ReplaceableTextures\\CommandButtons\\BTNAuraOfDarkness.blp");
			CreateQuestBJ(2, "First Match?", "|cffFFFF80This is your very first match of Castle Fight?|rWell, no problem, this game is very easy (even if playing with real good strategy can be very difficult). Just pick a worker and start building. Listen to your teammates, you will learn fast.Read the basic hints in this questlog and when you have played a couple of games and want even more information and tactics about this game, visit |cffFFFF80castle-fight.net.ru|r for a detailed documentation.|cffFF0000Note that the game has more than one round, so please don't leave if your castle is about to fall. Another round may come after this one and you ruin the game by leaving after round 1.|rGood luck and have fun!", "ReplaceableTextures\\CommandButtons\\BTNSelectHeroOff.blp");
			CreateQuestBJ(2, "Basic Hints", "TRIGSTR_010", "ReplaceableTextures\\CommandButtons\\BTNMilitia.blp");
			CreateQuestBJ(2, "About", "TRIGSTR_011", "ReplaceableTextures\\CommandButtons\\BTNTomeOfRetraining.blp");
		}
		private void Vs(int Aj, int bj, float Ws) {
			int at;
			float Xs = Ws;
			float Ys = .5*Ws;
			if ((ye[Aj]>0)) {
				at = bj+4;
				Ae[at] = Ae[at]+(Ys);
			}
			at = xe[Aj];
			if ((at==1)) {
				Ae[bj+1] = Ae[bj+1]+(Xs);
				Ae[bj+2] = Ae[bj+2]+(Ys);
			} else if ((at==2)) {
				Ae[bj+2] = Ae[bj+2]+(Xs);
				Ae[bj+3] = Ae[bj+3]+(Ys);
			} else if ((at==3)) {
				Ae[bj+3] = Ae[bj+3]+(Xs);
				Ae[bj+1] = Ae[bj+1]+(Ys);
			} else if ((at==4)) {
				Ae[bj+4] = Ae[bj+4]+(Xs);
				if ((ye[Aj]<2)) {
					Ae[bj+1] = Ae[bj+1]+(Ys);
					Ae[bj+2] = Ae[bj+2]+(Ys);
					Ae[bj+3] = Ae[bj+3]+(Ys);
				}
			} else if ((at==6)) {
				Ae[bj+6] = Ae[bj+6]+(Xs*1.5);
				Ae[bj+1] = Ae[bj+1]+(Ys);
				Ae[bj+2] = Ae[bj+2]+(Ys);
				Ae[bj+3] = Ae[bj+3]+(Ys);
			} else if ((at==5)) {
				Ae[bj+5] = Ae[bj+5]+(Xs);
			}
			Ae[bj+5] = Ae[bj+5]+(Ys);
		}
		private void Zs() {
			unit u = GetTriggerUnit();
			int id = GetUnitPointValue(u);
			float d = t4[id];
			int r = ve[id];
			int a = id*7;
			int z = 7*me[GetPlayerId(GetOwningPlayer(u))];
			if ((r>0)) {
				r = r+(z);
				ue[r] = ue[r]+(d);
				Vs(id, z, d*.8);
			}
			u = null;
		}
		private bool dt(unit Jm, int to) {
			player p = GetOwningPlayer(Jm);
			SetUnitOwner(Jm, Player($F), false);
			SetUnitOwner(Jm, p, false);
			return IssueImmediateOrderById(Jm,to);
		}
		private void et() {
			if ((GetExpiredTimer()==ce[0])) {
				De[0] = true;
			} else {
				De[1] = true;
			}
		}
		private bool ft(int dk) {
			if ((GetUnitAbilityLevel(ae[dk],'A005')<=0)) {
				Ee[me[dk]] = Player($E);
				ForceRemovePlayer(Ce[me[dk]], Player(dk));
			} else {
				De[me[dk]] = false;
				Ee[me[dk]] = Player(dk);
				TimerStart(ce[me[dk]], 10., false, function et);
				return Si(ae[dk],be[me[dk]]);
			}
			return false;
		}
		private void gt() {
			int ht = 0;
			int ai;
			int bi;
			float d1;
			float d2;
			float t;
			int i;
			while (true) {
				ai = 7*ht+1;
				bi = 7*ModuloInteger(ht+1,2)+1;
				d1 = ue[bi+6]-Ae[ai+6];
				d2 = d1;
				i = 1;
				Ie[ht*2] = 6;
				Ie[ht*2+1] = 6;
				while (true) {
					t = ue[bi]-Ae[ai];
					if ((t>d1 && ue[bi]>Ae[ai])) {
						d1 = t;
						Ie[ht*2] = i;
					} else if ((t<d2)) {
						d2 = t;
						Ie[ht*2+1] = i;
					}
					ai = ai+1;
					bi = bi+1;
					i = i+1;
					if (i>=He) { break; }
				}
				ht = ht+1;
				if (ht>=2) { break; }
			}
		}
		private bool jt() {
			unit u = GetTriggerUnit();
			int ht;
			player p;
			if ((IsUnitType(u,UNIT_TYPE_STRUCTURE))) {
				r4 = GetOwningPlayer(u);
				ht = me[GetPlayerId(r4)];
				be[ht] = u;
				GroupEnumUnitsInRange(q4, GetUnitX(u), GetUnitY(u), 1590.1, y9);
				p = vn(Ce[ht]);
				if ((p!=null  && (GetWidgetLife(u)/ GetUnitState(u,UNIT_STATE_MAX_LIFE)*100.<40.4 || CountUnitsInGroup(q4)>=16) && (De[ht]or Ee[ht]==p))) {
					Sj("AI", "STRIKE_ORDER_TARGET", GetPlayerName(p));
					ft(GetPlayerId(p));
				}
			}
			u = null;
			return false;
		}
		private bool kt() {
			unit u = GetFilterUnit();
			float r = GetWidgetLife(u);
			bool Im = r>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_STRUCTURE) && GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>50.;
			u = null;
			return Im;
		}
		private int mt(int nt, int ot, int pt, int qt) {
			int v = qi();
			int i = 0;
			Ph[Qh[v]] = nt;
			Ph[Qh[v]+1] = ot;
			Ph[Qh[v]+2] = pt;
			Ph[Qh[v]+3] = qt;
			while (true) {
				if ((Ph[Qh[v]+i]!=0)) {
					Rh[v] = i;
				}
				i = i+1;
				if (i>=4) { break; }
			}
			return v;
		}
		private void rt(int oi, unit bm) {
			int i = Rh[oi]-1;
			int st = $A;
			unit tt;
			r4 = GetOwningPlayer(bm);
			while (true) {
				if ((i<0)) {
					bj_groupEnumTypeId = Ph[Qh[oi]];
					if ((GetPlayerState(r4,PLAYER_STATE_RESOURCE_GOLD)>t4[GetUnitPointValueByType(bj_groupEnumTypeId)])) {
						i = te[GetPlayerId(r4)];
						while (true) {
							Oi(i);
							if (IssueBuildOrderById(bm,bj_groupEnumTypeId,A,B) || st<0) { break; }
							st = st-1;
							Qi(i);
						}
					}
					if (true) { break; }
				} else {
					bj_groupEnumTypeId = Ph[Qh[oi]+i];
					GroupEnumUnitsOfPlayer(q4, r4, filterGetUnitsOfPlayerAndTypeId);
					tt = FirstOfGroup(q4);
					if ((tt==null)) {
						i = i-1;
					} else {
						if ((GetPlayerState(r4,PLAYER_STATE_RESOURCE_GOLD)>t4[GetUnitPointValueByType(Ph[Qh[oi]+i+1])])) {
							dt(tt, Ph[Qh[oi]+i+1]);
						}
						tt = null;
						if (true) { break; }
					}
				}
			}
		}
		private void ut(int oi, unit bm) {
			rt(oi, bm);
			bj_groupEnumTypeId = Ph[Qh[oi]+Rh[oi]];
			GroupEnumUnitsOfPlayer(q4, r4, filterGetUnitsOfPlayerAndTypeId);
			ze[GetPlayerId(r4)] = FirstOfGroup(q4)!=null;
		}
		private int vt(int oi) {
			return ve[GetUnitPointValueByType(Ph[Qh[oi]+Rh[oi]])];
		}
		private void wt(int oi, int xt, int yt) {
			Vh[Wh[oi]+xt*7+Xh[Yh[oi]+xt]] = yt;
			Xh[Yh[oi]+xt] = Xh[Yh[oi]+xt]+1;
		}
		private void zt(int oi, unit bm) {
			int i = 0;
			int At = -1;
			int Bt = 2*me[GetPlayerId(GetOwningPlayer(bm))];
			while (true) {
				if ((vt(Vh[Wh[oi]+Ie[Bt]*7+i])==Ie[Bt+1])) {
					At = i;
				}
				i = i+1;
				if (i>Xh[Yh[oi]+Ie[Bt]]) { break; }
			}
			if ((At>-1)) {
				rt(Vh[Wh[oi]+Ie[Bt]*7+At], bm);
			} else {
				rt(Vh[Wh[oi]+Ie[Bt]*7+GetRandomInt(0, Xh[Yh[oi]+Ie[Bt]])], bm);
			}
		}
		private void bt(int oi) {
			int i = 0;
			while (true) {
				Xh[Yh[oi]+i] = Xh[Yh[oi]+i]-1;
				i = i+1;
				if (i>=7) { break; }
			}
			ei[fi[oi]] = ei[fi[oi]]-1;
			ei[fi[oi]+1] = ei[fi[oi]+1]-1;
			ei[fi[oi]+2] = ei[fi[oi]+2]-1;
			ei[fi[oi]+3] = ei[fi[oi]+3]-1;
		}
		private void Ct(int oi, int ct, int yt) {
			Zh[di[oi]+4*ct+ei[fi[oi]+ct]] = yt;
			ei[fi[oi]+ct] = ei[fi[oi]+ct]+1;
		}
		private void Dt(int oi, unit bm) {
			int dk = GetPlayerId(GetOwningPlayer(bm));
			if ((rd  && (!ze[dk]))) {
				if (((!md) && ei[fi[oi]+3]>=0)) {
					ut(Zh[di[oi]+4*3+GetRandomInt(0, ei[fi[oi]+3])], bm);
				} else if ((ei[fi[oi]]>=0)) {
					ut(Zh[di[oi]+4*0+GetRandomInt(0, ei[fi[oi]])], bm);
				} else {
					ze[dk] = true;
				}
			} else if (((!md) && ei[fi[oi]+1]>=0)) {
				rt(Zh[di[oi]+4*1+GetRandomInt(0, ei[fi[oi]+1])], bm);
			} else if ((ei[fi[oi]+2]>=0)) {
				rt(Zh[di[oi]+4*2+GetRandomInt(0, ei[fi[oi]+2])], bm);
			} else {
				zt(oi, bm);
			}
		}
		private int Et(int aj) {
			if ((aj=='h00O')) {
				return Je;
			}
			if ((aj=='u006')) {
				return Ke;
			}
			if ((aj=='h00C')) {
				return Le;
			}
			if ((aj=='h019')) {
				return Me;
			}
			if ((aj=='h00E')) {
				return Ne;
			}
			if ((aj=='h017')) {
				return Oe;
			}
			if ((aj=='h089')) {
				return Pe;
			}
			if ((aj=='h00P')) {
				return Qe;
			}
			if ((aj=='h018')) {
				return Re;
			}
			if ((aj=='h06P')) {
				return Se;
			}
			if ((aj=='h01A')) {
				return Te;
			}
			if ((aj=='h051')) {
				return Ue;
			}
			return -1;
		}
		private void Ft() {
			int i = 0;
			if ((Fe)) {
				return;
			}
			while (true) {
				if ((Be[i]and ae[i]!=null && GetWidgetLife(ae[i])>.405)) {
					if ((be[me[i]]==null)) {
						if ((GetUnitCurrentOrder(ae[i])==0)) {
							IssuePointOrderByIdLoc(ae[i], $D022D, Qd[i]);
						}
					} else if ((GetWidgetLife(be[me[i]])>.405 && GetUnitState(be[me[i]],UNIT_STATE_MAX_LIFE)-GetWidgetLife(be[me[i]])>50.)) {
						IssueTargetOrderById(ae[i], $D0038, be[me[i]]);
					} else {
						r4 = Player(i);
						GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, le);
						bj_groupRandomConsidered = 0;
						bj_groupRandomCurrentPick = null;
						ForGroup(q4, function GroupPickRandomUnitEnum);
						be[me[i]] = bj_groupRandomCurrentPick;
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void Gt() {
			int i = 0;
			int t;
			if ((Fe)) {
				return;
			}
			gt();
			while (true) {
				if ((Be[i])) {
					r4 = Player(i);
					if ((ae[i]==null || GetWidgetLife(ae[i])<=.405)) {
						GroupEnumUnitsOfPlayer(q4, r4, b9);
						ae[i] = FirstOfGroup(q4);
						if ((ae[i]!=null)) {
							Ve[i] = Et(GetUnitTypeId(ae[i]));
							if ((GetUnitAbilityLevel(ae[i],'A005')>0)) {
								ForceAddPlayer(Ce[me[i]], r4);
								Sj("AI", "MainOrdererRegistratorStrikeStack", GetPlayerName(r4));
							}
						}
					} else {
						t = GetPlayerState(Player(i),PLAYER_STATE_RESOURCE_LUMBER);
						if ((t<$7D0 || t>$BB8 || GetPlayerState(r4,PLAYER_STATE_RESOURCE_GOLD)>=$3E8)) {
							zt(Ve[i], ae[i]);
						} else {
							Dt(Ve[i], ae[i]);
						}
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void AILibrary_PrepareAI() {
			ExecuteFunc("Ht");
		}
		private void AILibrary_ResetBuildPlaces() {
			int i = 0;
			if ((!Ge)) {
				return;
			}
			while (true) {
				if ((Be[i])) {
					if ((IsPlayerInForce(Player(i),ie))) {
						te[i] = ModuloInteger(i,2)+2;
					} else if ((IsPlayerInForce(Player(i),je))) {
						te[i] = ModuloInteger(i,2);
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void It(int dk) {
			string s;
			ExecuteFunc("Ht");
			if ((IsPlayerInForce(Player(dk),ie))) {
				te[dk] = ModuloInteger(dk,2)+2;
			} else if ((IsPlayerInForce(Player(dk),je))) {
				te[dk] = ModuloInteger(dk,2);
			}
			s = Ki();
			SetPlayerName(Player(dk), s);
			l9[dk] = s;
			Ls(dk);
			Be[dk] = true;
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" joined to game with AI savvy!");
		}
		private bool lt(int dk) {
			if ((!Be[dk])) {
				return false;
			}
			Be[dk] = false;
			ForceRemovePlayer(Ce[me[dk]], Player(dk));
			return true;
		}
		private void Jt() {
			int i = 0;
			while (true) {
				if ((qe[i])) {
					DisplayTextToPlayer(Player(i), .0, .0, "|cffCA0000WARNING|r: AI took control over your units! Type -afk to disable AI.");
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void Kt(int dk) {
			if ((qe[dk])) {
				qe[dk] = false;
				lt(dk);
				SetPlayerName(Player(dk), l9[dk]);
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+"|cffCA0000 is no longer AFK!|r");
				re = re-1;
				if ((re==0)) {
					PauseTimer(se);
					DestroyTimer(se);
					se = null;
				}
			} else {
				qe[dk] = true;
				Gd[dk] = true;
				ExecuteFunc("Ht");
				if ((IsPlayerInForce(Player(dk),ie))) {
					te[dk] = ModuloInteger(dk,2)+2;
				} else if ((IsPlayerInForce(Player(dk),je))) {
					te[dk] = ModuloInteger(dk,2);
				}
				SetPlayerName(Player(dk), "[AFK] "+l9[dk]);
				Be[dk] = true;
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+"|cffCA0000 is AFK!|r AI took control over his units.");
				if ((re==0)) {
					se = CreateTimer();
					TimerStart(se, 5., true, function Jt);
				}
				re = re+1;
			}
		}
		private void Lt() {
			int i = 0;
			bool b = false;
			while (true) {
				if ((GetPlayerController(Player(i))==MAP_CONTROL_COMPUTER)) {
					It(i);
					b = true;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			if ((b)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "AI functionality damaged: you are playing with computer slots.In future use command -fill.");
			}
		}
		private void Mt() {
			int i = 0;
			while (true) {
				ue[i] = 0;
				Ae[i] = 0;
				i = i+1;
				if (i>7*2) { break; }
			}
			i = 0;
			while (true) {
				ze[i] = false;
				if (i>$B) { break; }
				i = i+1;
			}
			Mi();
			ForceClear(Ce[0]);
			ForceClear(Ce[1]);
			PauseTimer(ce[0]);
			PauseTimer(ce[1]);
			De[0] = true;
			De[1] = true;
			Ee[0] = Player($E);
			Ee[1] = Player($E);
			Fe = false;
		}
		private void AILibrary_Sleep() {
			Fe = true;
		}
		private void Ht() {
			int i;
			trigger t;
			int Nt;
			int Ot;
			int Pt;
			int Qt;
			int Rt;
			int St;
			int Tt;
			int Ut;
			int Vt;
			int Wt;
			int Xt;
			int Yt;
			int Zt;
			int du;
			int eu;
			int fu;
			int gu;
			int hu;
			int iu;
			int ju;
			int ku;
			int mu;
			int nu;
			int ou;
			int pu;
			int qu;
			int ru;
			int su;
			int tu;
			int uu;
			int vu;
			int wu;
			int xu;
			int yu;
			int zu;
			int Au;
			int au;
			int Bu;
			int bu;
			int Cu;
			int cu;
			int Du;
			int Eu;
			int Fu;
			int Gu;
			if ((Ge)) {
				return;
			}
			Li();
			Mi();
			le = Filter(function kt);
			TimerStart(CreateTimer(), 2., true, function Gt);
			TimerStart(CreateTimer(), 5., true, function Ft);
			t = CreateTrigger();
			TriggerAddAction(t, function Zs);
			TriggerRegisterAnyUnitEventBJ(t, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH);
			TriggerRegisterAnyUnitEventBJ(t, EVENT_PLAYER_UNIT_UPGRADE_FINISH);
			t = CreateTrigger();
			TriggerAddCondition(t, Condition(function jt));
			TriggerRegisterAnyUnitEventBJ(t, EVENT_PLAYER_UNIT_ATTACKED);
			t = null;
			Ce[0] = CreateForce();
			Ce[1] = CreateForce();
			ce[0] = CreateTimer();
			ce[1] = CreateTimer();
			De[0] = true;
			De[1] = true;
			Ee[0] = Player($E);
			Ee[1] = Player($E);
			Je = pi();
			Nt = mt('h025',0,0,0);
			Ot = mt('h009',0,0,0);
			Pt = mt('h007',0,0,0);
			Qt = mt('h01C',0,0,0);
			wt(Je, 2, mt('h01I', 'h026', 0, 0));
			wt(Je, 2, mt('h01D', 'h03G', 0, 0));
			wt(Je, 3, Qt);
			wt(Je, 6, Nt);
			wt(Je, 6, Ot);
			wt(Je, 6, Pt);
			wt(Je, 1, Nt);
			wt(Je, 1, Qt);
			wt(Je, 4, Pt);
			wt(Je, 5, Ot);
			i = GetUnitPointValueByType('h025');
			ve[i] = 5;
			xe[i] = 6;
			ye[i] = 0;
			i = GetUnitPointValueByType('h009');
			ve[i] = 4;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h007');
			ve[i] = 3;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01C');
			ve[i] = 1;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01I');
			ve[i] = 1;
			xe[i] = 2;
			ye[i] = 1;
			i = GetUnitPointValueByType('h026');
			ve[i] = 1;
			xe[i] = 2;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01D');
			ve[i] = 2;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h03G');
			ve[i] = 2;
			xe[i] = 2;
			ye[i] = 0;
			Ct(Je, 0, mt('h01M', 'h01W', 'h01X', 0));
			Ct(Je, 3, mt('h01E', 0, 0, 0));
			Ct(Je, 2, mt('h01F', 0, 0, 0));
			bt(Je);
			Le = pi();
			Rt = mt('h000','h039',0,0);
			St = mt('h003','h05D',0,0);
			Tt = mt('h037','h038',0,0);
			Ut = mt('h015',0,0,0);
			wt(Le, 1, St);
			wt(Le, 2, Rt);
			wt(Le, 2, St);
			wt(Le, 2, Tt);
			wt(Le, 3, Tt);
			wt(Le, 3, Ut);
			wt(Le, 4, mt('h003', 'h0A1', 0, 0));
			wt(Le, 5, mt('h004', 0, 0, 0));
			wt(Le, 5, Ut);
			wt(Le, 6, Tt);
			wt(Le, 6, mt('h00K', 0, 0, 0));
			i = GetUnitPointValueByType('h000');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h039');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h003');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h05D');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h0A1');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 2;
			i = GetUnitPointValueByType('h004');
			ve[i] = 1;
			xe[i] = 5;
			ye[i] = 0;
			i = GetUnitPointValueByType('h015');
			ve[i] = 4;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h037');
			ve[i] = 3;
			xe[i] = 6;
			ye[i] = 0;
			i = GetUnitPointValueByType('h038');
			ve[i] = 3;
			xe[i] = 6;
			ye[i] = 0;
			i = GetUnitPointValueByType('h00K');
			ve[i] = 5;
			xe[i] = 6;
			ye[i] = 1;
			Ct(Le, 0, mt('h05G', 0, 0, 0));
			Ct(Le, 1, mt('h001', 0, 0, 0));
			bt(Le);
			Ke = pi();
			Vt = mt('h04L','h04N',0,0);
			Wt = mt('h04O','h04M',0,0);
			Xt = mt('h04Q','h04P',0,0);
			Yt = mt('h04U',0,0,0);
			wt(Ke, 1, mt('h04S', 0, 0, 0));
			wt(Ke, 2, mt('h04V', 'h04W', 0, 0));
			wt(Ke, 3, Vt);
			wt(Ke, 3, Wt);
			wt(Ke, 3, Xt);
			wt(Ke, 4, Vt);
			wt(Ke, 4, Yt);
			wt(Ke, 5, Xt);
			wt(Ke, 5, Wt);
			wt(Ke, 6, Yt);
			i = GetUnitPointValueByType('h04S');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h04V');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h04W');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h09Y');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h04L');
			ve[i] = 1;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h04N');
			ve[i] = 1;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h04O');
			ve[i] = 4;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h04M');
			ve[i] = 4;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h04Q');
			ve[i] = 3;
			xe[i] = 5;
			ye[i] = 0;
			i = GetUnitPointValueByType('h04P');
			ve[i] = 3;
			xe[i] = 5;
			ye[i] = 0;
			i = GetUnitPointValueByType('h04U');
			ve[i] = 2;
			xe[i] = 6;
			ye[i] = 1;
			Ct(Ke, 0, mt('h04T', 0, 0, 0));
			Ct(Ke, 0, mt('h04V', 'h04W', 'h09Y', 0));
			Ct(Ke, 2, mt('h04K', 0, 0, 0));
			Ct(Ke, 2, mt('h04R', 0, 0, 0));
			bt(Ke);
			Me = pi();
			Zt = mt('h029','h02U','h031',0);
			du = mt('h02H','h05E',0,0);
			eu = mt('h02I',0,0,0);
			fu = mt('h02B',0,0,0);
			wt(Me, 1, mt('h02K', 'h092', 0, 0));
			wt(Me, 1, mt('h02K', 'h035', 0, 0));
			wt(Me, 1, mt('h02K', 'h036', 0, 0));
			wt(Me, 1, mt('h02P', 0, 0, 0));
			wt(Me, 2, Zt);
			wt(Me, 2, du);
			wt(Me, 3, Zt);
			wt(Me, 3, fu);
			wt(Me, 4, du);
			wt(Me, 5, eu);
			wt(Me, 6, Zt);
			wt(Me, 6, eu);
			i = GetUnitPointValueByType('h02K');
			ve[i] = 1;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h092');
			ve[i] = 1;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h035');
			ve[i] = 1;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h036');
			ve[i] = 1;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h02P');
			ve[i] = 4;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h029');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h02U');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h031');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h02H');
			ve[i] = 2;
			xe[i] = 2;
			ye[i] = 1;
			i = GetUnitPointValueByType('h05E');
			ve[i] = 2;
			xe[i] = 2;
			ye[i] = 1;
			i = GetUnitPointValueByType('h02B');
			ve[i] = 5;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h02I');
			ve[i] = 2;
			xe[i] = 5;
			ye[i] = 0;
			Ct(Me, 0, mt('h02O', 0, 0, 0));
			Ct(Me, 2, mt('h02R', 0, 0, 0));
			Ct(Me, 2, mt('h02N', 0, 0, 0));
			bt(Me);
			Ne = pi();
			gu = mt('h00F','h032',0,0);
			hu = mt('h020','h021','h022',0);
			iu = mt('h01B',0,0,0);
			ju = mt('h01Z',0,0,0);
			ku = mt('h00J',0,0,0);
			wt(Ne, 1, gu);
			wt(Ne, 2, hu);
			wt(Ne, 2, iu);
			wt(Ne, 2, ku);
			wt(Ne, 3, gu);
			wt(Ne, 3, hu);
			wt(Ne, 3, iu);
			wt(Ne, 3, mt('h01Y', 0, 0, 0));
			wt(Ne, 4, ku);
			wt(Ne, 4, iu);
			wt(Ne, 4, ju);
			wt(Ne, 5, iu);
			wt(Ne, 5, ju);
			wt(Ne, 6, ju);
			i = GetUnitPointValueByType('h00F');
			ve[i] = 3;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h032');
			ve[i] = 3;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h020');
			ve[i] = 5;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h021');
			ve[i] = 5;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h022');
			ve[i] = 5;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h01B');
			ve[i] = 3;
			xe[i] = 5;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01Z');
			ve[i] = 5;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01Y');
			ve[i] = 4;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h00J');
			ve[i] = 2;
			xe[i] = 2;
			ye[i] = 1;
			i = GetUnitPointValueByType('h05F');
			ve[i] = 2;
			xe[i] = 6;
			ye[i] = 1;
			Ct(Ne, 0, mt('h00J', 'h05F', 0, 0));
			Ct(Ne, 0, mt('h00N', 0, 0, 0));
			Ct(Ne, 2, mt('h00I', 0, 0, 0));
			Ct(Ne, 2, mt('h00M', 0, 0, 0));
			bt(Ne);
			Oe = pi();
			mu = mt('h03S',0,0,0);
			nu = mt('h03I',0,0,0);
			wt(Oe, 1, mt('h03U', 0, 0, 0));
			wt(Oe, 1, mt('h03T', 'h043', 0, 0));
			wt(Oe, 2, mt('h049', 'h04F', 'h03W', 0));
			wt(Oe, 2, mu);
			wt(Oe, 2, nu);
			wt(Oe, 3, mt('h03K', 'h03J', 0, 0));
			wt(Oe, 3, mu);
			wt(Oe, 3, nu);
			wt(Oe, 4, mu);
			wt(Oe, 4, nu);
			wt(Oe, 5, mu);
			wt(Oe, 5, nu);
			wt(Oe, 6, mu);
			wt(Oe, 6, nu);
			i = GetUnitPointValueByType('h03U');
			ve[i] = 3;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h03T');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h043');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h049');
			ve[i] = 5;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h04F');
			ve[i] = 5;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h03W');
			ve[i] = 5;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h03K');
			ve[i] = 1;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h03J');
			ve[i] = 1;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h049');
			ve[i] = 4;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h04F');
			ve[i] = 5;
			xe[i] = 6;
			ye[i] = 1;
			Ct(Oe, 0, mt('h03O', 0, 0, 0));
			Ct(Oe, 1, mt('h048', 'h03L', 0, 0));
			Ct(Oe, 2, mt('h047', 0, 0, 0));
			bt(Oe);
			Re = pi();
			ou = mt('h01P','h056',0,0);
			pu = mt('h01K','h04B',0,0);
			qu = mt('h01S',0,0,0);
			wt(Re, 1, mt('h01N', 'h054', 0, 0));
			wt(Re, 1, ou);
			wt(Re, 1, pu);
			wt(Re, 1, qu);
			wt(Re, 2, ou);
			wt(Re, 2, pu);
			wt(Re, 2, qu);
			wt(Re, 3, pu);
			wt(Re, 3, mt('h01L', 0, 0, 0));
			wt(Re, 3, qu);
			wt(Re, 4, ou);
			wt(Re, 4, pu);
			wt(Re, 5, pu);
			wt(Re, 5, mt('h01T', 0, 0, 0));
			wt(Re, 5, qu);
			wt(Re, 6, mt('h01R', 'h04Z', 'h03M', 0));
			i = GetUnitPointValueByType('h01P');
			ve[i] = 1;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h056');
			ve[i] = 1;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01K');
			ve[i] = 5;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h04B');
			ve[i] = 5;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h055');
			ve[i] = 5;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01S');
			ve[i] = 4;
			xe[i] = 2;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01N');
			ve[i] = 3;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h054');
			ve[i] = 3;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h01L');
			ve[i] = 6;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01T');
			ve[i] = 2;
			xe[i] = 5;
			ye[i] = 0;
			i = GetUnitPointValueByType('h01R');
			ve[i] = 2;
			xe[i] = 6;
			ye[i] = 0;
			i = GetUnitPointValueByType('h04Z');
			ve[i] = 2;
			xe[i] = 6;
			ye[i] = 0;
			i = GetUnitPointValueByType('h03M');
			ve[i] = 2;
			xe[i] = 6;
			ye[i] = 0;
			Ct(Re, 0, mt('h01K', 'h04B', 'h055', 0));
			Ct(Re, 0, mt('h01Q', 0, 0, 0));
			Ct(Re, 2, mt('h00A', 0, 0, 0));
			bt(Re);
			Pe = pi();
			ru = mt('h00S','h03D',0,0);
			wt(Pe, 1, ru);
			wt(Pe, 1, mt('h07M', 'h07L', 0, 0));
			wt(Pe, 2, ru);
			wt(Pe, 3, mt('h07O', 'h07N', 0, 0));
			wt(Pe, 3, mt('h00B', 0, 0, 0));
			wt(Pe, 4, ru);
			wt(Pe, 5, ru);
			wt(Pe, 5, mt('h011', 0, 0, 0));
			wt(Pe, 6, mt('h088', 'h07D', 0, 0));
			i = GetUnitPointValueByType('h00S');
			ve[i] = 1;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h03D');
			ve[i] = 1;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h03E');
			ve[i] = 1;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h07M');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h07L');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h07O');
			ve[i] = 1;
			xe[i] = 3;
			ye[i] = 0;
			i = GetUnitPointValueByType('h07N');
			ve[i] = 1;
			xe[i] = 3;
			ye[i] = 0;
			i = GetUnitPointValueByType('h00B');
			ve[i] = 4;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h011');
			ve[i] = 3;
			xe[i] = 5;
			ye[i] = 0;
			i = GetUnitPointValueByType('h088');
			ve[i] = 5;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h07D');
			ve[i] = 5;
			xe[i] = 6;
			ye[i] = 1;
			Ct(Pe, 0, mt('h00S', 'h03D', 'h03E', 0));
			Ct(Pe, 3, mt('h07I', 0, 0, 0));
			Ct(Pe, 2, mt('h07H', 0, 0, 0));
			Ct(Pe, 2, mt('h08P', 0, 0, 0));
			bt(Pe);
			Qe = pi();
			su = mt('h08X','h08Y',0,0);
			tu = mt('h06Y',0,0,0);
			uu = mt('h00T','h03F',0,0);
			vu = mt('h09X',0,0,0);
			wu = mt('h00V',0,0,0);
			wt(Qe, 1, su);
			wt(Qe, 1, tu);
			wt(Qe, 2, uu);
			wt(Qe, 3, wu);
			wt(Qe, 3, vu);
			wt(Qe, 4, su);
			wt(Qe, 4, tu);
			wt(Qe, 5, mt('h070', 0, 0, 0));
			wt(Qe, 5, wu);
			wt(Qe, 6, su);
			wt(Qe, 6, uu);
			wt(Qe, 6, vu);
			i = GetUnitPointValueByType('h08X');
			ve[i] = 5;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h08Y');
			ve[i] = 5;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h06Y');
			ve[i] = 4;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h00T');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h03F');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h00V');
			ve[i] = 2;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h09X');
			ve[i] = 5;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h00X');
			ve[i] = 5;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h070');
			ve[i] = 2;
			xe[i] = 5;
			ye[i] = 0;
			Ct(Qe, 0, mt('h09X', 'h00X', 0, 0));
			Ct(Qe, 0, mt('h059', 0, 0, 0));
			Ct(Qe, 2, mt('h00Z', 0, 0, 0));
			Ct(Qe, 2, mt('h005', 0, 0, 0));
			bt(Qe);
			Se = pi();
			xu = mt('h05X','h09I',0,0);
			yu = mt('h05X','h09B',0,0);
			zu = mt('h05X','h09J',0,0);
			Au = mt('h05T','h09P',0,0);
			wt(Se, 1, mt('h05U', 0, 0, 0));
			wt(Se, 1, xu);
			wt(Se, 1, Au);
			wt(Se, 2, yu);
			wt(Se, 2, zu);
			wt(Se, 2, Au);
			wt(Se, 3, xu);
			wt(Se, 3, yu);
			wt(Se, 3, zu);
			wt(Se, 3, mt('h05M', 0, 0, 0));
			wt(Se, 4, mt('h05X', 'h09B', 'h09H', 0));
			wt(Se, 4, mt('h05J', 'h09L', 0, 0));
			wt(Se, 5, xu);
			wt(Se, 5, yu);
			wt(Se, 5, Au);
			wt(Se, 6, xu);
			wt(Se, 6, mt('h05V', 0, 0, 0));
			wt(Se, 6, Au);
			i = GetUnitPointValueByType('h05X');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h09I');
			ve[i] = 3;
			xe[i] = 6;
			ye[i] = 0;
			i = GetUnitPointValueByType('h09B');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h09J');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h05T');
			ve[i] = 1;
			xe[i] = 6;
			ye[i] = 0;
			i = GetUnitPointValueByType('h09P');
			ve[i] = 1;
			xe[i] = 6;
			ye[i] = 0;
			i = GetUnitPointValueByType('h05U');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h05M');
			ve[i] = 5;
			xe[i] = 3;
			ye[i] = 0;
			i = GetUnitPointValueByType('h09H');
			ve[i] = 3;
			xe[i] = 2;
			ye[i] = 1;
			i = GetUnitPointValueByType('h05J');
			ve[i] = 4;
			xe[i] = 1;
			ye[i] = 2;
			i = GetUnitPointValueByType('h09L');
			ve[i] = 4;
			xe[i] = 1;
			ye[i] = 2;
			i = GetUnitPointValueByType('h05V');
			ve[i] = 2;
			xe[i] = 6;
			ye[i] = 0;
			i = GetUnitPointValueByType('h097');
			ve[i] = 6;
			xe[i] = 6;
			ye[i] = 0;
			Ct(Se, 0, mt('h05V', 'h097', 0, 0));
			Ct(Se, 2, mt('h06J', 'h05R', 0, 0));
			Ct(Se, 2, mt('h069', 0, 0, 0));
			bt(Se);
			Te = pi();
			au = mt('h002','h00Q','h00R',0);
			Bu = mt('h028',0,0,0);
			bu = mt('h00Y','h012',0,0);
			Cu = mt('h013','h01H',0,0);
			cu = mt('h027',0,0,0);
			wt(Te, 1, au);
			wt(Te, 1, Cu);
			wt(Te, 2, mt('h023', 'h024', 0, 0));
			wt(Te, 2, Bu);
			wt(Te, 3, bu);
			wt(Te, 4, bu);
			wt(Te, 4, Cu);
			wt(Te, 4, Bu);
			wt(Te, 5, Bu);
			wt(Te, 5, cu);
			wt(Te, 6, Bu);
			wt(Te, 6, cu);
			i = GetUnitPointValueByType('h002');
			ve[i] = 5;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h00Q');
			ve[i] = 5;
			xe[i] = 1;
			ye[i] = 0;
			i = GetUnitPointValueByType('h00R');
			ve[i] = 5;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h028');
			ve[i] = 5;
			xe[i] = 5;
			ye[i] = 1;
			i = GetUnitPointValueByType('h00Y');
			ve[i] = 1;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h012');
			ve[i] = 1;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h013');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01H');
			ve[i] = 2;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h01J');
			ve[i] = 2;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h027');
			ve[i] = 4;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h023');
			ve[i] = 5;
			xe[i] = 2;
			ye[i] = 0;
			i = GetUnitPointValueByType('h024');
			ve[i] = 5;
			xe[i] = 2;
			ye[i] = 0;
			Ct(Te, 0, mt('h013', 'h01H', 'h01J', 0));
			Ct(Te, 0, mt('h02D', 0, 0, 0));
			Ct(Te, 2, mt('h02C', 0, 0, 0));
			Ct(Te, 2, mt('h02A', 0, 0, 0));
			bt(Te);
			Ue = pi();
			Du = mt('h045','h046',0,0);
			Eu = mt('h040','h041',0,0);
			Fu = mt('h03X','h03Y','h03Z',0);
			Gu = mt('h042','h044',0,0);
			wt(Ue, 1, Du);
			wt(Ue, 1, Fu);
			wt(Ue, 1, Gu);
			wt(Ue, 2, Fu);
			wt(Ue, 3, Gu);
			wt(Ue, 4, mt('h04A', 'h04C', 'h04D', 0));
			wt(Ue, 4, Du);
			wt(Ue, 5, Eu);
			wt(Ue, 6, Du);
			i = GetUnitPointValueByType('h045');
			ve[i] = 3;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h046');
			ve[i] = 3;
			xe[i] = 6;
			ye[i] = 1;
			i = GetUnitPointValueByType('h040');
			ve[i] = 2;
			xe[i] = 5;
			ye[i] = 0;
			i = GetUnitPointValueByType('h041');
			ve[i] = 2;
			xe[i] = 5;
			ye[i] = 0;
			i = GetUnitPointValueByType('h03X');
			ve[i] = 1;
			xe[i] = 2;
			ye[i] = 1;
			i = GetUnitPointValueByType('h03Y');
			ve[i] = 1;
			xe[i] = 2;
			ye[i] = 1;
			i = GetUnitPointValueByType('h03Z');
			ve[i] = 1;
			xe[i] = 2;
			ye[i] = 1;
			i = GetUnitPointValueByType('h042');
			ve[i] = 3;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h044');
			ve[i] = 3;
			xe[i] = 3;
			ye[i] = 1;
			i = GetUnitPointValueByType('h04A');
			ve[i] = 4;
			xe[i] = 1;
			ye[i] = 2;
			i = GetUnitPointValueByType('h04C');
			ve[i] = 4;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h04D');
			ve[i] = 4;
			xe[i] = 1;
			ye[i] = 1;
			i = GetUnitPointValueByType('h04E');
			ve[i] = 3;
			xe[i] = 3;
			ye[i] = 1;
			Ct(Ue, 0, mt('h045', 'h046', 'h04E', 0));
			Ct(Ue, 0, mt('h063', 0, 0, 0));
			Ct(Ue, 2, mt('h060', 0, 0, 0));
			Ct(Ue, 2, mt('h05Z', 0, 0, 0));
			bt(Ue);
			Ge = true;
		}
		private void Hu() {
			unit c;
			int i = GetRandomInt(0,8);
			float x;
			float y;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl", GetUnitX(B4), GetUnitY(B4)));
			bj_groupRandomCurrentPick = rn(q4);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			if ((yd)) {
				Pj("SE:CH:ST "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));
				Rj();
			}
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl", bj_groupRandomCurrentPick, "origin"));
			if ((Hr(bj_groupRandomCurrentPick))) {
				return;
			}
			if ((i==0)) {
				ExplodeUnitBJ(bj_groupRandomCurrentPick);
				i = GetPlayerId(r4);
				Sd[i] = Sd[i]+1;
			} else if ((i==1)) {
				UnitDamageTarget(B4, bj_groupRandomCurrentPick, 50000., true, false, ATTACK_TYPE_NORMAL, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);
			} else if ((i==2)) {
				UnitDamageTarget(B4, bj_groupRandomCurrentPick, 500., true, false, ATTACK_TYPE_NORMAL, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);
			} else if ((i==3)) {
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl", bj_groupRandomCurrentPick, "origin"));
				UnitAddAbility(bj_groupRandomCurrentPick, 'A06T');
				UnitAddAbility(bj_groupRandomCurrentPick, 'A06U');
				SetUnitState(bj_groupRandomCurrentPick, UNIT_STATE_LIFE, GetUnitState(bj_groupRandomCurrentPick, UNIT_STATE_MAX_LIFE));
			} else if ((i==4)) {
				c = CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);
				UnitAddAbility(c, 'A018');
				UnitShareVision(bj_groupRandomCurrentPick, r4, true);
				IssueTargetOrderById(c, $D0216, bj_groupRandomCurrentPick);
				UnitShareVision(bj_groupRandomCurrentPick, r4, false);
				UnitApplyTimedLife(c, 'BTLF', 1.);
				c = bj_groupRandomCurrentPick;
				TriggerSleepAction(1.);
				Po(c);
				if ((GetUnitTypeId(c)=='h03A')) {
					TriggerSleepAction(44.5);
					IssueImmediateOrderById(c, $D0057);
					TriggerSleepAction(.5);
					Po(c);
				}
				c = null;
			} else if ((i==5)) {
				c = CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);
				UnitAddAbility(c, 'A06S');
				UnitShareVision(bj_groupRandomCurrentPick, r4, true);
				IssueTargetOrderById(c, $D007F, bj_groupRandomCurrentPick);
				UnitShareVision(bj_groupRandomCurrentPick, r4, false);
				UnitApplyTimedLife(c, 'BTLF', 2.);
				c = null;
			} else if ((i==6)) {
				i = GetPlayerId(r4);
				Sd[i] = Sd[i]+1;
				ShowUnit(bj_groupRandomCurrentPick, false);
				x = GetUnitX(bj_groupRandomCurrentPick);
				y = GetUnitY(bj_groupRandomCurrentPick);
				DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl", x, y));
				Po(CreateUnit(r4, 'n01S', x, y, GetUnitFacing(bj_groupRandomCurrentPick)));
				RemoveUnit(bj_groupRandomCurrentPick);
			}
		}
		private bool Iu() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && GetUnitTypeId(u)==Xe;
			u = null;
			return Im;
		}
		private void lu() {
			unit u = GetEnumUnit();
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Items\\AIil\\AIilTarget.mdl", u, "origin"));
			if ((GetUnitAbilityLevel(u,'A070')<=0)) {
				UnitDamageTarget(B4, u, 100500., true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);
			}
			u = null;
		}
		private void Ju() {
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl", GetUnitX(B4), GetUnitY(B4)));
			bj_groupRandomCurrentPick = rn(q4);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			if ((yd)) {
				Pj("SE:CH:SE "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));
				Rj();
			}
			Xe = GetUnitTypeId(bj_groupRandomCurrentPick);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Ye);
			ForGroup(q4, function lu);
		}
		private void Ku() {
			float x;
			float y;
			unit c;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, x9);
			bj_groupRandomCurrentPick = rn(q4);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			if ((yd)) {
				Pj("SE:CH:SV "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));
				Rj();
			}
			x = GetUnitX(bj_groupRandomCurrentPick);
			y = GetUnitY(bj_groupRandomCurrentPick);
			c = CreateUnit(r4,'e008',x,y,.0);
			UnitAddAbility(c, We);
			IssuePointOrderById(c, $D0208, x, y);
			UnitApplyTimedLife(c, 'BTLF', 6.);
			c = null;
		}
		private bool Lu() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_STRUCTURE) && GetPlayerId(GetOwningPlayer(u))<$C && GetUnitTypeId(u)!='hcas' && GetUnitAbilityLevel(u,'A06V')<=0;
			u = null;
			return Im;
		}
		private void Mu() {
			int t;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Ze);
			bj_groupRandomCurrentPick = rn(q4);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			if ((yd)) {
				Pj("SE:CH:SD "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));
				Rj();
			}
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosTarget.mdl", GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick)));
			KillUnit(bj_groupRandomCurrentPick);
			t = me[GetPlayerId(r4)];
			Nd[t] = Nd[t]+1;
			Yr(3, t+1, I2S(Nd[t]));
		}
		private void Nu() {
			unit c;
			if ((yd)) {
				Pj("SE:CH:SR "+GetUnitName(c4)+" ->[no target]");
				Rj();
			}
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\NightElf\\BattleRoar\\RoarCaster.mdl", c4, "origin"));
			c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(c, 'A03R');
			IssueImmediateOrderById(c, $D00C4);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = null;
		}
		private bool Ou() {
			Bj(z4, 'h094', 74., 38.5, 28.);
			Bj(z4, 'h093', 160., -42., -18.75);
			Bj(z4, 'h093', 250., 3.75, -55.5);
			Bj(z4, 'h08Z', 220., 43., 27.5);
			return false;
		}
		private void Pu() {
			lj('h05I', function Hu);
			zj('h025', 'n00L');
			lj('h01M', function Ju);
			lj('h01W', function Ju);
			lj('h01X', function Ju);
			zj('h01I', 'n00A');
			zj('h026', 'z000');
			lj('h01F', function Ku);
			lj('h01E', function Mu);
			zj('h01C', 'n008');
			zj('h01D', 'n009');
			zj('h03G', 'n00Z');
			Fj('h03G', function Ou);
			zj('h009', 'n001');
			zj('h007', 'n000');
		}
		private void Qu() {
			int id;
			id = GetUnitPointValueByType('h025');
			t4[id] = 280;
			u4[id] = 280*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01I');
			t4[id] = 'x';
			u4[id] = 'x'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h026');
			t4[id] = $E6;
			u4[id] = $E6*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01C');
			t4[id] = $E6;
			u4[id] = $E6*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01D');
			t4[id] = $A0;
			u4[id] = $A0*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03G');
			t4[id] = $BE;
			u4[id] = $BE*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h009');
			t4[id] = 350;
			u4[id] = 350*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h007');
			t4[id] = 500;
			u4[id] = 500*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h05I');
			t4[id] = $C8;
			u4[id] = $C8*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h01M');
			t4[id] = 350;
			u4[id] = 350*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h01W');
			t4[id] = $AF;
			u4[id] = $AF*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h01X');
			t4[id] = $AF;
			u4[id] = $AF*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h01F');
			t4[id] = 340;
			u4[id] = 340*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h01E');
			t4[id] = 850;
			u4[id] = 850*.12/ 100.;
			v4[id] = false;
		}
		private void Chaos___RegisterUnitCasts() {
			Lj('n00Z', 'A03S', function Nu);
		}
		private unit Ru(unit u, int aj) {
			unit n;
			ShowUnit(u, false);
			n = CreateUnit(GetOwningPlayer(u),aj,GetUnitX(u),GetUnitY(u),GetUnitFacing(u));
			RemoveUnit(u);
			return n;
		}
		private unit Su(unit u) {
			int i = GetRandomInt(0,99);
			if ((i<5)) {
				u = Ru(u,'n00M');
			} else if ((i<$E)) {
				u = Ru(u,'n00R');
			} else {
				i = GetRandomInt(0,3);
				if ((i==0)) {
					u = Ru(u,'n00Q');
				} else if ((i==1)) {
					u = Ru(u,'n00N');
				} else if ((i==2)) {
					u = Ru(u,'n00O');
				} else {
					u = Ru(u,'n00P');
				}
			}
			i = GetRandomInt(0,99);
			if ((i<20)) {
				UnitAddAbility(u, 'A009');
			} else if ((i<55)) {
				UnitAddAbility(u, 'A01F');
			}
			i = GetRandomInt(0,99);
			if ((i<18)) {
				UnitAddAbility(u, 'A02B');
			} else if ((i<30)) {
				UnitAddAbility(u, 'A01B');
			} else if ((i<33)) {
				UnitAddAbility(u, 'A00Z');
			} else if ((i<43)) {
				UnitAddAbility(u, 'A07L');
			}
			i = GetRandomInt(0,99);
			if ((i<$A)) {
				UnitAddAbility(u, 'A00U');
			} else if ((i<32)) {
				UnitAddAbility(u, 'A00T');
			} else if ((i<35)) {
				UnitAddAbility(u, 'A05J');
			}
			i = GetRandomInt(0,99);
			if ((i<25)) {
				UnitAddAbility(u, 'A01A');
			}
			i = GetRandomInt(0,99);
			if ((i<$F)) {
				UnitAddAbility(u, 'A00V');
			} else if ((i<40)) {
				UnitAddAbility(u, 'A00D');
			}
			i = GetRandomInt(0,99);
			if ((i<8)) {
				UnitAddAbility(u, 'A01U');
			} else if ((i<16)) {
				UnitAddAbility(u, 'A010');
			} else if ((i<24)) {
				UnitAddAbility(u, 'A01P');
			} else if ((i<34)) {
				UnitAddAbility(u, 'A006');
			} else if ((i<44)) {
				UnitAddAbility(u, 'A01R');
			} else if ((i<47)) {
				UnitAddAbility(u, 'A012');
			}
			return u;
		}
		private void Tu() {
			Pu();
			Qu();
			Lj('n00Z', 'A03S', function Nu);
			Ye = Filter(function Iu);
			Ze = Filter(function Lu);
		}
		private void Uu() {
			int i = 0;
			float x;
			float y;
			float an;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, x9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			x = GetUnitX(bj_groupRandomCurrentPick);
			y = GetUnitY(bj_groupRandomCurrentPick);
			while (true) {
				an = 60.*I2R(i);
				UnitApplyTimedLife(CreateUnit(r4, df, x+64.*Cos(an*bj_DEGTORAD), y+64.*Sin(an*bj_DEGTORAD), 360.-an), 'BTLF', 9.);
				i = i+1;
				if (i>=6) { break; }
			}
		}
		private void Vu() {
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Undead\\DeathPact\\DeathPactTarget.mdl", bj_groupRandomCurrentPick, "origin"));
			if (!Hr(bj_groupRandomCurrentPick)) {
				UnitDamageTarget(B4, bj_groupRandomCurrentPick, 200., true, false, ATTACK_TYPE_NORMAL, DAMAGE_TYPE_SONIC, WEAPON_TYPE_WHOKNOWS);
			}
		}
		private void Wu() {
			player p = GetOwningPlayer(c4);
			float x = GetUnitX(c4);
			float y = GetUnitY(c4);
			float an = bj_RADTODEG*Atan2(GetUnitY(D4)-y,GetUnitX(D4)-x)-20.;
			int i = 0;
			unit c;
			while (true) {
				c = CreateUnit(p,'e008',x,y,an);
				UnitAddAbility(c, 'A0AF');
				IssuePointOrderById(c, $D024B, x+10.*Cos(an*bj_DEGTORAD), y+10.*Sin(an*bj_DEGTORAD));
				UnitApplyTimedLife(c, 'BTLF', 2.);
				an = an+(10.);
				i = i+1;
				if (i>3) { break; }
			}
			c = null;
		}
		private bool Xu() {
			Bj(z4, 'h04J', 191., .0, .0);
			return false;
		}
		private bool Yu() {
			Bj(z4, 'h09Z', 270., .0, .0);
			return false;
		}
		private bool Zu() {
			SetUnitVertexColor(z4, 82, 0, $87, 'f');
			return false;
		}
		private bool dv() {
			Bj(z4, 'h08I', .0, .0, .0);
			return false;
		}
		private void ev() {
			Ij('n01J', 800.);
			zj('h04V', 'n01I');
			zj('h04W', 'n01H');
			zj('h09Y', 'n027');
			Fj('h09Y', function Yu);
			zj('h04U', 'h04I');
			Fj('h04U', function Xu);
			zj('h04S', 'n01G');
			lj('h04R', function Uu);
			zj('h04Q', 'n01F');
			zj('h04P', 'n01E');
			zj('h04O', 'n01D');
			zj('h04M', 'n01B');
			Fj('h04M', function Zu);
			zj('h04L', 'n019');
			zj('h04N', 'n01A');
			lj('h04K', function Vu);
			Fj('h04K', function dv);
		}
		private void fv() {
			int id;
			id = GetUnitPointValueByType('h04V');
			t4[id] = '}';
			u4[id] = '}'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04W');
			t4[id] = '}';
			u4[id] = '}'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04U');
			t4[id] = 520;
			u4[id] = 520*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04S');
			t4[id] = $F0;
			u4[id] = $F0*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04Q');
			t4[id] = 300;
			u4[id] = 300*.18/ 100.;
			v4[id] = true;
			w4[id] = true;
			id = GetUnitPointValueByType('h04P');
			t4[id] = $96;
			u4[id] = $96*.18/ 100.;
			v4[id] = true;
			w4[id] = true;
			id = GetUnitPointValueByType('h04O');
			t4[id] = $EB;
			u4[id] = $EB*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04M');
			t4[id] = $A5;
			u4[id] = $A5*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04L');
			t4[id] = $BE;
			u4[id] = $BE*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04N');
			t4[id] = $BE;
			u4[id] = $BE*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('n01J');
			t4[id] = $C8;
			u4[id] = $C8*.08/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h09Y');
			t4[id] = 500;
			u4[id] = 500*.2/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h04T');
			t4[id] = 500;
			u4[id] = 500*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h04R');
			t4[id] = 260;
			u4[id] = 260*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h04K');
			t4[id] = 275;
			u4[id] = 275*.09/ 100.;
			v4[id] = false;
		}
		private void Corrupted___RegisterUnitCasts() {
			Lj('n027', 'A0AE', function Wu);
		}
		private void gv() {
			ev();
			fv();
			Lj('n027', 'A0AE', function Wu);
		}
		private bool hv() {
			unit u = GetFilterUnit();
			bool Im = IsUnitType(u,UNIT_TYPE_FLYING) && GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && !IsUnitType(u,UNIT_TYPE_MECHANICAL);
			u = null;
			return Im;
		}
		private void iv() {
			float x;
			float y;
			int i = 0;
			unit t;
			unit c;
			r4 = GetOwningPlayer(c4);
			x = GetUnitX(c4);
			y = GetUnitY(c4);
			GroupEnumUnitsInRange(q4, GetUnitX(D4), GetUnitY(D4), 400., ef);
			while (true) {
				t = FirstOfGroup(q4);
				i = i+1;
				if (i>4 || t==null) { break; }
				GroupRemoveUnit(q4, t);
				c = CreateUnit(GetOwningPlayer(c4),'e008',x,y,.0);
				UnitAddAbility(c, 'A08U');
				IssueTargetOrderById(c, $D007F, t);
				UnitApplyTimedLife(c, 'BTLF', 3.);
			}
			t = null;
			c = null;
		}
		private void jv() {
			unit c;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null || Hr(bj_groupRandomCurrentPick))) {
				return;
			}
			c = CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);
			UnitAddAbility(c, 'A018');
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);
			IssueTargetOrderById(c, $D0216, bj_groupRandomCurrentPick);
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = bj_groupRandomCurrentPick;
			TriggerSleepAction(1.);
			Po(c);
			if ((GetUnitTypeId(c)=='h03A')) {
				TriggerSleepAction(44.5);
				IssueImmediateOrderById(c, $D0057);
				TriggerSleepAction(.5);
				Po(c);
			}
			c = null;
		}
		private void kv() {
			unit c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(c, 'A0A8');
			IssueTargetOrderById(c, $D0215, D4);
			UnitApplyTimedLife(c, 'BTLF', 2.);
			c = c4;
			TriggerSleepAction(.8);
			Po(c);
			c = null;
		}
		private void mv() {
			unit c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(c, 'A00Y');
			IssueTargetOrderById(c, $D0215, D4);
			UnitApplyTimedLife(c, 'BTLF', 2.);
			c = c4;
			TriggerSleepAction(.8);
			Po(c);
			c = null;
		}
		private bool nv() {
			SetUnitVertexColor(z4, $FF, $FF, $FF, 0);
			Bj(z4, 'h08Z', 250., 46., 33.5);
			Bj(z4, 'h090', 270., -17., 18.);
			return false;
		}
		private bool ov() {
			SetUnitVertexColor(z4, $FF, $FF, $FF, 0);
			Bj(z4, 'h08Z', 250., 46., 33.5);
			Bj(z4, 'h091', 270., -17., 18.);
			Bj(z4, 'h08Z', 350., -22., -40.);
			return false;
		}
		private void pv() {
			lj('h00Z', function jv);
			Ij('h014', 675.);
			zj('h09X', 'h07B');
			zj('h00X', 'h00W');
			zj('h00V', 'h00U');
			zj('h00T', 'n006');
			zj('h03F', 'n00Y');
			zj('h08X', 'n022');
			Fj('h08X', function nv);
			zj('h08Y', 'n023');
			Fj('h08Y', function ov);
			zj('h070', 'e005');
			zj('h06Y', 'n01Y');
		}
		private void qv() {
			int id;
			id = GetUnitPointValueByType('h09X');
			t4[id] = 360;
			u4[id] = 360*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00V');
			t4[id] = 275;
			u4[id] = 275*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00T');
			t4[id] = $DC;
			u4[id] = $DC*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03F');
			t4[id] = $E6;
			u4[id] = $E6*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h08X');
			t4[id] = $B4;
			u4[id] = $B4*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h08Y');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h070');
			t4[id] = 350;
			u4[id] = 350*.18/ 100.;
			v4[id] = true;
			w4[id] = true;
			id = GetUnitPointValueByType('h06Y');
			t4[id] = 310;
			u4[id] = 310*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00Z');
			t4[id] = $F0;
			u4[id] = $F0*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h00X');
			t4[id] = 440;
			u4[id] = 440*.2/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h059');
			t4[id] = 650;
			u4[id] = 650*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h005');
			t4[id] = $FA;
			u4[id] = $FA*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h014');
			t4[id] = $FA;
			u4[id] = $FA*.08/ 100.;
			v4[id] = false;
		}
		private void rv() {
			Lj('n01Y', 'A08V', function iv);
			Lj('h07B', 'A0A7', function kv);
			Lj('h00W', 'A00X', function mv);
		}
		private void sv(player p) {
			int id = me[GetPlayerId(p)];
			ld[id] = ld[id]+(20);
		}
		private void tv(unit u) {
			int id = me[GetPlayerId(GetOwningPlayer(u))];
			ld[id] = ld[id]-(20);
		}
		private void uv() {
			pv();
			qv();
			rv();
			ef = Filter(function hv);
		}
		private void vv() {
			unit u = GetEnumUnit();
			unit c = CreateUnit(r4,'e008',GetUnitX(u),GetUnitY(u),.0);
			UnitAddAbility(c, 'A016');
			IssueTargetOrderById(c, $D0085, u);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = null;
			u = null;
		}
		private void wv() {
			float x = GetUnitX(B4);
			float y = GetUnitY(B4);
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\HowlOfTerror\\HowlCaster.mdl", x, y));
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRange(q4, x, y, 500., gf);
			ForGroup(q4, function vv);
		}
		private void xv() {
			unit u = c4;
			IssueTargetOrderById(u, $D0062, D4);
			TriggerSleepAction(1.);
			Po(u);
			u = null;
		}
		private bool yv() {
			unit u = GetFilterUnit();
			bool Im = IsUnitAlly(u,r4) && GetWidgetLife(u)<.405 && !IsUnitType(u,UNIT_TYPE_MECHANICAL);
			u = null;
			return Im;
		}
		private void zv() {
			unit u = c4;
			IssueTargetOrderById(u, $D0062, D4);
			UnitAddAbility(D4, 'A03L');
			TriggerSleepAction(1.);
			r4 = GetOwningPlayer(u);
			GroupEnumUnitsInRange(q4, GetUnitX(u), GetUnitY(u), 900., hf);
			if ((FirstOfGroup(q4)!=null)) {
				IssueImmediateOrderById(u, $D007E);
				TriggerSleepAction(1.);
			}
			Po(u);
			u = null;
		}
		private void Av() {
			unit u = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(u, 'A00I');
			IssueImmediateOrderById(u, $D022E);
			UnitApplyTimedLife(u, 'BTLF', 1.);
			u = c4;
			UnitRemoveAbility(u, 'A00F');
			UnitAddAbility(u, 'A07I');
			TriggerSleepAction(.3);
			br(u);
			TriggerSleepAction(5.);
			if ((GetUnitAbilityLevel(u,'A00F')<=0)) {
				IssueImmediateOrderById(u, $D0019);
				TriggerSleepAction(6.6);
				if ((GetUnitAbilityLevel(u,'A00F')<=0)) {
					UnitAddAbility(u, 'A00F');
					UnitRemoveAbility(u, 'A07I');
					UnitAddAbility(u, 'A0EZ');
					Po(u);
				}
			}
			u = null;
		}
		private bool av() {
			SetUnitVertexColor(z4, $FF, $FF, $FF, 0);
			Bj(z4, 'h0A0', 170., 31.25, -43.);
			Bj(z4, 'h0A0', 80., -38., -40.25);
			Bj(z4, 'h0A0', 350., -30.25, 30.);
			Bj(z4, 'h08Z', 220., 43., 27.5);
			return false;
		}
		private void Bv() {
			zj('h000', 'hfoo');
			zj('h039', 'h03A');
			zj('h003', 'hrif');
			zj('h0A1', 'h05C');
			Fj('h0A1', function av);
			zj('h05D', 'h0A2');
			zj('h004', 'hmtm');
			Ij('h006', 950.);
			zj('h00K', 'n005');
			Ij('h010', 500.);
			lj('h010', function wv);
			zj('h015', 'h016');
			zj('h037', 'h03B');
			zj('h038', 'h03C');
		}
		private void bv() {
			int id;
			id = GetUnitPointValueByType('h037');
			t4[id] = 265;
			u4[id] = 265*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h015');
			t4[id] = $FA;
			u4[id] = $FA*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00K');
			t4[id] = 300;
			u4[id] = 300*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h004');
			t4[id] = $D2;
			u4[id] = $D2*.18/ 100.;
			v4[id] = true;
			w4[id] = true;
			id = GetUnitPointValueByType('h003');
			t4[id] = $8C;
			u4[id] = $8C*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h000');
			t4[id] = 'd';
			u4[id] = 'd'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h039');
			t4[id] = $AF;
			u4[id] = $AF*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h0A1');
			t4[id] = $A0;
			u4[id] = $A0*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h05D');
			t4[id] = $B4;
			u4[id] = $B4*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h038');
			t4[id] = 260;
			u4[id] = 260*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h001');
			t4[id] = $C8;
			u4[id] = $C8*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h006');
			t4[id] = $96;
			u4[id] = $96*.08/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h010');
			t4[id] = $E1;
			u4[id] = $E1*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h05G');
			t4[id] = 550;
			u4[id] = 550*.12/ 100.;
			v4[id] = false;
		}
		private void Cv() {
			Lj('h03B', 'A03K', function xv);
			Lj('h03C', 'A03K', function zv);
			Lj('n005', 'A00K', function Av);
		}
		private void cv(unit u) {
			rect r = Ld[me[GetPlayerId(GetOwningPlayer(u))]];
			IssuePointOrderById(u, $D0010, GetRandomReal(GetRectMinX(r), GetRectMaxX(r)), GetRandomReal(GetRectMinY(r), GetRectMaxY(r)));
			r = null;
		}
		private void Dv() {
			cv(GetEnumUnit());
		}
		private void Ev() {
			ForGroup(ff, function Dv);
		}
		private void Fv(unit u) {
			GroupAddUnit(Jd[me[GetPlayerId(GetOwningPlayer(u))]], u);
		}
		private void Gv(unit u) {
			GroupRemoveUnit(Jd[me[GetPlayerId(GetOwningPlayer(u))]], u);
		}
		private bool Hv() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER);
			u = null;
			return Im;
		}
		private void Iv() {
			Bv();
			bv();
			Cv();
			TimerStart(CreateTimer(), 9., true, function Ev);
			hf = Filter(function yv);
			gf = Filter(function Hv);
		}
		private float lv(int x) {
			if ((x<$A)) {
				return pf[x]*.25+1.;
			}
			return ((((I2R(x-9))*.25)+5.11)*.25)+1.;
		}
		private float Jv(int dk) {
			return (mf[(dk)]*10.)*lv(ge[dk]);
		}
		private int Kv(int dk) {
			float i = Jv(dk);
			float j = .0;
			float k = .0;
			while (true) {
				if ((i<kf) || (k>=8)) { break; }
				i = i-kf;
				j = j+kf*(1.-k/ 10.);
				k = k+1.;
			}
			j = j+i*(1.-k/ 10.);
			return R2I(j*i8[me[dk]]);
		}
		private void Lv(int dk, unit u) {
			float l = u4[GetUnitPointValue(u)];
			int aj = GetHandleId(u);
			mf[dk] = mf[dk]+(l);
			SaveReal(O9, aj, $A, LoadReal(O9, aj, $A)+l);
		}
		private void Mv(int dk, unit u) {
			mf[dk] = mf[dk]-(LoadReal(O9,GetHandleId(u),$A));
		}
		private void Nv(int dk, unit u) {
			mf[dk] = mf[dk]+(LoadReal(O9,GetHandleId(u),$A));
		}
		private void Ov() {
			of = of+(" "+I2S(nf[GetPlayerId(GetEnumPlayer())]));
		}
		private void Pv() {
			player p = GetEnumPlayer();
			int id = GetPlayerId(p);
			int ws = Kv(id);
			Vd[id] = Vd[id]+(ws);
			SetPlayerState(p, PLAYER_STATE_RESOURCE_GOLD, GetPlayerState(p, PLAYER_STATE_RESOURCE_GOLD)+ws);
			SetPlayerState(p, PLAYER_STATE_GOLD_GATHERED, GetPlayerState(p, PLAYER_STATE_GOLD_GATHERED)+ws);
			nf[id] = ws;
			qf = qf+(ws);
		}
		private void Qv() {
			int i = 0;
			qf = 0;
			ForForce(ie, function Pv);
			Yr(4, 1, I2S(qf));
			qf = 0;
			ForForce(je, function Pv);
			Yr(4, 2, I2S(qf));
			while (true) {
				if ((nf[i]>0)) {
					of = "Income: |cffFFFF00"+I2S(nf[i]);
					if ((ne[i]!=null)) {
						ForForce(ne[i], function Ov);
					}
					DisplayTextToPlayer(Player(i), 0, 0, of);
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void Rv(player p) {
			int dk = GetPlayerId(p);
			string s = "Your basic income is |cffFFFF00"+I2S(R2I((mf[(dk)]*10.)));
			s = s+("|r. Your Treasure Box income multiplier is |cffFFFF00"+R2SW(lv(ge[dk]),1,2));
			s = s+("|r, boosting your income to |cffFFFF00"+I2S(R2I(Jv(dk))));
			s = s+("|r. After paying taxes your income is |cffFFFF00"+I2S(nf[dk])+"|r.");
			DisplayTextToPlayer(p, .0, .0, s);
		}
		private void Sv(player p) {
			int id = GetPlayerId(p);
			DisplayTimedTextToPlayer(p, .0, .0, 15., "-------- Current statistics: --------");
			DisplayTimedTextToPlayer(p, .0, .0, 15., "Income: |cffFFFF00"+I2S(Kv(id))+"|r (|cffFFFF00"+I2S(Vd[id])+"|r gold in total)");
			if ((Cd>0)) {
				DisplayTimedTextToPlayer(p, .0, .0, 15., "Coins collected: |cffFFFF00"+I2S(Yd[id])+"|r (|cffFFFF00"+I2S(Zd[id])+"|r gold in total)");
			}
			DisplayTimedTextToPlayer(p, .0, .0, 15., "Units killed: |cffFFFF00"+I2S(Sd[id])+"|r (|cffFFFF00"+I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_GOLD)+ee[id]+fe[id]-de[id]-Vd[id]-Zd[id]-$FA)+"|r gold in total)");
			DisplayTimedTextToPlayer(p, .0, .0, 15., "Units trained: |cffFFFF00"+I2S(Rd[id])+"|r (|cffFFFF00"+I2S(Td[id])+"|r creepspawning buildings in total)");
			DisplayTimedTextToPlayer(p, .0, .0, 15., "Specials built: |cffFFFF00"+I2S(Ud[id])+"|r");
			DisplayTimedTextToPlayer(p, .0, .0, 15., "Rescue Strike damage: |cffFFFF00"+I2S(Wd[id])+"|r (|cffFFFF00"+I2S(Xd[id])+"|r units killed)");
			DisplayTimedTextToPlayer(p, .0, .0, 15., "----------------------------------------------------");
		}
		private int Tv() {
			int j = 0;
			int i = 1;
			while (true) {
				if ((Wd[i]>Wd[j])) {
					j = i;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			return j;
		}
		private int Uv() {
			int j = 0;
			int i = 1;
			while (true) {
				if ((Ud[i]>Ud[j])) {
					j = i;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			return Ud[j];
		}
		private int Vv() {
			int j = 0;
			int i = 0;
			while (true) {
				if ((Td[j]>Td[i])) {
					i = j;
				}
				j = j+1;
				if (j>$B) { break; }
			}
			return j;
		}
		private int Wv() {
			int j = 0;
			int i = 1;
			while (true) {
				if ((Sd[i]>Sd[j])) {
					j = i;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			return j;
		}
		private int Xv() {
			int j = 0;
			int i = 1;
			while (true) {
				if ((Yd[i]>Yd[j])) {
					j = i;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			return j;
		}
		private int Yv() {
			int j = 0;
			int v = Kv(0);
			int i = 1;
			int t;
			while (true) {
				t = Kv(i);
				if ((t>v)) {
					v = t;
					j = i;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			return j;
		}
		private void Zv() {
			string s;
			string t;
			int g;
			int i;
			player p;
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "|cffFFFF80-----------  End of round statistics  -----------|r");
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Round time: "+ds());
			g = Kv(Yv());
			s = "";
			i = 0;
			while (true) {
				if ((Kv(i)==g)) {
					if ((s=="")) {
						s = pe[i];
						t = I2S(Vd[i]);
					} else {
						s = s+", "+pe[i];
						t = t+"|r, |cffFFFF00"+I2S(Vd[i]);
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Highest income: "+s+" - |cffFFFF00"+I2S(g)+"|r (|cffFFFF00"+t+"|r gold in total)");
			if ((Cd>0)) {
				g = Xv();
				s = "";
				i = 0;
				while (true) {
					p = Player(i);
					if ((Yd[i]==Yd[g])) {
						if ((s=="")) {
							s = pe[i];
							t = I2S(Zd[i]);
						} else {
							s = s+", "+pe[i];
							t = t+"|r, |cffFFFF00"+I2S(Zd[i]);
						}
					}
					i = i+1;
					if (i>$B) { break; }
				}
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Most coins collected: "+s+" - |cffFFFF00"+I2S(Yd[g])+"|r (|cffFFFF00"+t+"|r gold in total)");
			}
			g = Wv();
			s = "";
			i = 0;
			while (true) {
				p = Player(i);
				if ((Sd[i]==Sd[g])) {
					if ((s=="")) {
						s = pe[i];
						t = I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)+ee[i]+fe[i]-de[i]-Vd[i]-Zd[i]-$FA);
					} else {
						s = s+", "+pe[i];
						t = t+"|r, |cffFFFF00"+I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)+ee[i]+fe[i]-de[i]-Vd[i]-Zd[i]-$FA);
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
			s = "Most units killed: "+s+" - |cffFFFF00"+I2S(Sd[g])+"|r";
			if ((od)) {
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., s);
			} else {
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., s+" (|cffFFFF00"+t+"|r gold in total)");
			}
			g = Td[Vv()];
			s = "";
			i = 0;
			while (true) {
				if ((Td[i]==Td[g])) {
					if ((s=="")) {
						s = pe[i];
						t = I2S(Rd[i]);
					} else {
						s = s+", "+pe[i];
						t = t+"|r, |cffFFFF00"+I2S(Rd[i]);
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Most creepspawning buildings: "+s+" - |cffFFFF00"+I2S(Td[g])+"|r (|cffFFFF00"+t+"|r units in total)");
			if ((pd)) {
				g = Uv();
				s = "";
				i = 0;
				while (true) {
					if ((Ud[i]==g)) {
						if ((s=="")) {
							s = pe[i];
						} else {
							s = s+", "+pe[i];
						}
					}
					i = i+1;
					if (i>$B) { break; }
				}
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Most special buildings: "+s+" - |cffFFFF00"+I2S(g)+"|r");
			}
			g = Tv();
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Most damage dealt with RS: "+pe[g]+" - |cffFFFF00"+I2S(Wd[g])+"|r (|cffFFFF00"+I2S(Xd[g])+"|r units killed)");
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "|cffFFFF80--------------------------------------------------------------------|r");
		}
		private void dw() {
			pf[0] = .0;
			pf[1] = 1.;
			pf[2] = 1.85;
			pf[3] = 2.57;
			pf[4] = 3.18;
			pf[5] = 3.7;
			pf[6] = 4.14;
			pf[7] = 4.52;
			pf[8] = 4.84;
			pf[9] = 5.11;
			i8[0] = 1.;
			i8[1] = 1.;
		}
		private bool ew() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,'Avul')<=0 && GetUnitAbilityLevel(u,'A09L')<=0;
			u = null;
			return Im;
		}
		private void fw() {
			unit u;
			r4 = GetOwningPlayer(B4);
			bj_groupRandomCurrentPick = rn(q4);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			if ((yd)) {
				Pj("SE:MC:SA "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));
				Rj();
			}
			UnitAddAbility(bj_groupRandomCurrentPick, 'A09L');
			u = B4;
			SetUnitAnimation(u, "death");
			TriggerSleepAction(.3);
			SetUnitAnimation(u, "stand");
			u = null;
		}
		private bool gw() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,'Avul')<=0;
			u = null;
			return Im;
		}
		private void hw() {
			unit u;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, sf);
			bj_groupRandomCurrentPick = rn(q4);
			if ((bj_groupRandomCurrentPick==null)) {
				GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, tf);
				bj_groupRandomCurrentPick = rn(q4);
				if ((bj_groupRandomCurrentPick==null)) {
					return;
				}
			} else {
				UnitAddAbility(bj_groupRandomCurrentPick, 'A09L');
			}
			if ((yd)) {
				Pj("SE:MC:SA2 "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));
				Rj();
			}
			SetUnitAbilityLevel(bj_groupRandomCurrentPick, 'A09L', 2);
			u = B4;
			SetUnitAnimation(u, "death");
			TriggerSleepAction(.3);
			SetUnitAnimation(u, "stand");
			u = null;
		}
		private void iw() {
			player p = GetOwningPlayer(c4);
			float x = GetUnitX(D4);
			float y = GetUnitY(D4);
			float sx = GetUnitX(c4);
			float sy = GetUnitY(c4);
			unit c = CreateUnit(p,'h09Q',sx,sy,.0);
			unit t;
			if ((yd)) {
				Pj("SE:MC:SG "+GetUnitName(c4)+" ->[no target]");
				Rj();
			}
			IssuePointOrderById(c, $D0010, x, y);
			UnitApplyTimedLife(c, 'BTLF', 3.);
			sx = sx-(x);
			sy = sy-(y);
			TriggerSleepAction(SquareRoot(sx*sx+sy*sy)/ 700.);
			c = CreateUnit(p,'e008',x,y,.0);
			UnitAddAbility(c, 'A09E');
			IssueImmediateOrderById(c, $D0080);
			UnitApplyTimedLife(c, 'BTLF', 3.);
			r4 = p;
			GroupEnumUnitsInRange(q4, x, y, 300., x9);
			while (true) {
				t = FirstOfGroup(q4);
				if (t==null) { break; }
				GroupRemoveUnit(q4, t);
				sx = GetUnitState(t,UNIT_STATE_MANA);
				if ((sx>.0)) {
					sy = RMinBJ(sx,'d');
					SetUnitState(t, UNIT_STATE_MANA, sx-sy);
					DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Feedback\\SpellBreakerAttack.mdl", t, "origin"));
					UnitDamageTarget(c, t, sy, true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_NORMAL, WEAPON_TYPE_WHOKNOWS);
				}
			}
			c = null;
		}
		private void jw() {
			player p = GetOwningPlayer(c4);
			float sx = GetUnitX(c4);
			float sy = GetUnitY(c4);
			float r = GetRandomReal(70.,300.);
			float y = GetRandomReal(.0,360.)*bj_DEGTORAD;
			float x = sx+r*Cos(y);
			unit c = CreateUnit(p,'h09M',sx,sy,.0);
			if ((yd)) {
				Pj("SE:MC:SM "+GetUnitName(c4)+" ->[no target]");
				Rj();
			}
			y = sy+r*Sin(y);
			IssuePointOrderById(c, $D0010, x, y);
			UnitApplyTimedLife(c, 'BTLF', 3.);
			TriggerSleepAction(r/ 700.);
			CreateUnit(p, 'n025', x, y, .0);
			c = null;
		}
		private bool kw() {
			unit u = GetFilterUnit();
			bool fl = GetWidgetLife(u)>=.405 && IsUnitType(u,UNIT_TYPE_STRUCTURE) && GetUnitTypeId(u)!='h09T'  && (GetUnitAbilityLevel(u,'Bfrz')>0 || GetUnitAbilityLevel(u,'B00M')>0) && GetRandomInt(0,99)<50;
			u = null;
			return fl;
		}
		private void mw() {
			unit u = GetEnumUnit();
			UnitRemoveAbility(u, 'Bfrz');
			UnitRemoveAbility(u, 'B00M');
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\MirrorImage\\MirrorImageDeathCaster.mdl", GetUnitX(u), GetUnitY(u)));
			u = null;
		}
		private void nw() {
			unit u = GetEnumUnit();
			GroupEnumUnitsInRange(q4, GetUnitX(u), GetUnitY(u), 252., uf);
			ForGroup(q4, function mw);
			u = null;
		}
		private void ow() {
			ForGroup(rf, function nw);
		}
		private bool pw() {
			Bj(z4, 'h09V', 270., .0, .0);
			Bj(z4, 'h09U', 90., 20., .0);
			Bj(z4, 'h09U', .0, .0, -20.);
			Bj(z4, 'h09U', 270., -20., .0);
			Bj(z4, 'h09U', 180., .0, 20.);
			return false;
		}
		private bool qw() {
			Bj(z4, 'h09R', 300., 3.5, 65.25);
			Bj(z4, 'h09R', 70., -16.5, -51.);
			Bj(z4, 'h09N', 238., 36., 53.);
			Bj(z4, 'h09O', 314., -38., -39.5);
			return false;
		}
		private bool rw() {
			Bj(z4, 'h09O', 279., -45.5, 24.75);
			Bj(z4, 'h09N', 300., 31., -32.25);
			return false;
		}
		private bool sw() {
			Bj(z4, 'h09K', 238., .0, .0);
			return false;
		}
		private bool tw() {
			Bj(z4, 'h09F', 2., 36.25, 41.);
			Bj(z4, 'h09F', 2., 33.25, -33.5);
			Bj(z4, 'h09F', 2., -46.25, 10.75);
			Bj(z4, 'h09A', 45., -5.25, 17.);
			return false;
		}
		private bool uw() {
			Bj(z4, 'h09D', 225., 35., -29.75);
			Bj(z4, 'h09D', 45., 20., 22.5);
			Bj(z4, 'h09D', 225., -31., 26.25);
			Bj(z4, 'h09G', 23., -25.25, -36.);
			return false;
		}
		private bool vw() {
			Bj(z4, 'h09C', 33., 36.25, 36.5);
			Bj(z4, 'h09C', 13., 21., -47.5);
			Bj(z4, 'h09C', 319., -46.25, 11.75);
			return false;
		}
		private bool ww() {
			Bj(z4, 'h09C', 33., 36.25, 36.5);
			Bj(z4, 'h09C', 13., 21., -47.5);
			Bj(z4, 'h09C', 319., -46.25, 11.75);
			Bj(z4, 'h09E', 348., -6.5, 9.);
			return false;
		}
		private bool xw() {
			Bj(z4, 'h09K', 45., .0, .0);
			return false;
		}
		private bool yw() {
			Bj(z4, 'h096', 180., -45.75, 21.75);
			Bj(z4, 'h096', 110., 9., -62.5);
			return false;
		}
		private void zw() {
			Fj('h09T', function pw);
			Ij('h09T', 180.);
			zj('h069', 'n01U');
			Fj('h069', function qw);
			lj('h06J', function fw);
			lj('h05R', function hw);
			zj('h05T', 'z002');
			zj('h09P', 'z003');
			Fj('h09P', function rw);
			zj('h05U', 'n01T');
			zj('h05M', 'n01V');
			zj('h05J', 'h06Q');
			zj('h09L', 'h06R');
			Fj('h09L', function sw);
			zj('h05V', 'n01X');
			zj('h097', 'n024');
			Fj('h097', function yw);
			zj('h05X', 'h06T');
			zj('h09J', 'h06U');
			Fj('h09J', function tw);
			zj('h09I', 'h099');
			Fj('h09I', function uw);
			zj('h09B', 'h06S');
			Fj('h09B', function vw);
			zj('h09H', 'h098');
			Fj('h09H', function ww);
			Ij('h05L', 600.);
			Fj('h05L', function xw);
		}
		private void Aw() {
			int id;
			id = GetUnitPointValueByType('h05T');
			t4[id] = $DC;
			u4[id] = $DC*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h09P');
			t4[id] = $8C;
			u4[id] = $8C*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h05U');
			t4[id] = 375;
			u4[id] = 375*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h05M');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h05J');
			t4[id] = $A0;
			u4[id] = $A0*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h09L');
			t4[id] = $B4;
			u4[id] = $B4*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h05V');
			t4[id] = 270;
			u4[id] = 270*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h05X');
			t4[id] = $B4;
			u4[id] = $B4*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h09J');
			t4[id] = $96;
			u4[id] = $96*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h09I');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h09B');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h09H');
			t4[id] = $96;
			u4[id] = $96*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h09T');
			t4[id] = 340;
			u4[id] = 340*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h069');
			t4[id] = $FA;
			u4[id] = $FA*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h06J');
			t4[id] = $BE;
			u4[id] = $BE*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h05R');
			t4[id] = $8C;
			u4[id] = $8C*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h097');
			t4[id] = 500;
			u4[id] = 500*.2/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h05L');
			t4[id] = $F0;
			u4[id] = $F0*.08/ 100.;
			v4[id] = false;
		}
		private void aw() {
			Lj('z003', 'A09D', function iw);
			Lj('h06U', 'A095', function jw);
		}
		private void Bw() {
			zw();
			Aw();
			aw();
			tf = Filter(function gw);
			sf = Filter(function ew);
			uf = Filter(function kw);
			TimerStart(CreateTimer(), 4., true, function ow);
		}
		private void bw() {
			unit c;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			c = CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(B4),GetUnitY(B4),.0);
			UnitAddAbility(c, 'A00P');
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);
			IssueTargetOrderById(c, $D00FA, bj_groupRandomCurrentPick);
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);
			UnitApplyTimedLife(c, 'BTLF', 20.);
			c = null;
		}
		private void Cw() {
			unit c;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null || Hr(bj_groupRandomCurrentPick))) {
				return;
			}
			c = CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(B4),GetUnitY(B4),.0);
			UnitAddAbility(c, 'A00N');
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);
			IssueTargetOrderById(c, $D0265, bj_groupRandomCurrentPick);
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = null;
		}
		private void cw() {
			unit c;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, x9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			c = CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);
			UnitAddAbility(c, 'A00B');
			IssueImmediateOrderById(c, $D0080);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = null;
		}
		private void Dw() {
			unit c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(c, 'A02T');
			IssueTargetOrderById(c, $D008F, D4);
			UnitApplyTimedLife(c, 'BTLF', 2.);
			c = c4;
			TriggerSleepAction(1.);
			if ((IssueImmediateOrderById(c,$D009E))) {
				TriggerSleepAction(1.);
			}
			Po(c);
			c = null;
		}
		private void Ew() {
			zj('h01Z', 'n00S');
			lj('h00N', function bw);
			lj('h00M', function Cw);
			zj('h00J', 'n004');
			zj('h05F', 'n01P');
			zj('h01B', 'n007');
			lj('h00I', function cw);
			zj('h020', 'n00I');
			zj('h021', 'n00J');
			zj('h022', 'n00K');
			Ij('h00G', 700.);
			zj('h01Y', 'n00H');
			zj('h00F', 'n002');
			zj('h032', 'n00X');
		}
		private void Fw() {
			int id;
			id = GetUnitPointValueByType('h01Z');
			t4[id] = 350;
			u4[id] = 350*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00J');
			t4[id] = $AF;
			u4[id] = $AF*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01B');
			t4[id] = 280;
			u4[id] = 280*.18/ 100.;
			v4[id] = true;
			w4[id] = true;
			id = GetUnitPointValueByType('h020');
			t4[id] = $AA;
			u4[id] = $AA*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h021');
			t4[id] = $B4;
			u4[id] = $B4*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h022');
			t4[id] = $BE;
			u4[id] = $BE*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01Y');
			t4[id] = $E6;
			u4[id] = $E6*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00F');
			t4[id] = $FA;
			u4[id] = $FA*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h032');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00N');
			t4[id] = 750;
			u4[id] = 750*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h00I');
			t4[id] = 360;
			u4[id] = 360*.18/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h00M');
			t4[id] = 310;
			u4[id] = 310*.18/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h00G');
			t4[id] = $FA;
			u4[id] = $FA*.18/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h05F');
			t4[id] = 725;
			u4[id] = 725*.2/ 100.;
			v4[id] = false;
		}
		private void Naga___RegisterUnitCasts() {
			Lj('n00S', 'A02U', function Dw);
		}
		private void Gw() {
			Ew();
			Fw();
			Lj('n00S', 'A02U', function Dw);
		}
		private bool Hw() {
			unit u = GetFilterUnit();
			bool b = GetWidgetLife(u)>.405 && IsUnitType(u,UNIT_TYPE_GROUND) && IsUnitType(u,UNIT_TYPE_SAPPER);
			u = null;
			return b;
		}
		private void Iw() {
			player p = GetOwningPlayer(c4);
			int i = 0;
			float x = GetUnitX(c4);
			float y = GetUnitY(c4);
			JassArray<destructable> lw = new JassArray<destructable>();
			float an;
			float r;
			unit u;
			float x2;
			float y2;
			GroupEnumUnitsInRange(q4, x, y, 144., xf);
			while (true) {
				u = FirstOfGroup(q4);
				if (u==null) { break; }
				GroupRemoveUnit(q4, u);
				if ((u!=c4)) {
					r = GetRandomReal(160.,218.);
					an = (GetRandomReal(135.,234.)+180.*me[GetPlayerId(GetOwningPlayer(u))])*bj_DEGTORAD;
					x2 = x+r*Cos(an);
					y2 = y+r*Sin(an);
					SetUnitX(u, x2);
					SetUnitY(u, y2);
					DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MassTeleport\\MassTeleportCaster.mdl", x2, y2));
				}
			}
			u = c4;
			while (true) {
				an = 72.*I2R(i);
				lw[i] = CreateDestructable('YTct',x+120.*Cos(an*bj_DEGTORAD),y+120.*Sin(an*bj_DEGTORAD),an,1.,0);
				i = i+1;
				if (i>=5) { break; }
			}
			TriggerSleepAction(3.);
			if ((GetWidgetLife(u)>.405)) {
				i = 0;
				while (true) {
					if ((GetWidgetLife(lw[i])>.405)) {
						KillDestructable(lw[i]);
						an = 72.*I2R(i);
						x2 = x+112.*Cos(an*bj_DEGTORAD);
						y2 = y+112.*Sin(an*bj_DEGTORAD);
						UnitApplyTimedLife(CreateUnit(p, 'e00D', x2, y2, an), 'B021', 20.);
						DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\EntBirthTarget\\EntBirthTarget.mdl", x2, y2));
					}
					i = i+1;
					if (i>=5) { break; }
				}
				Po(u);
			} else {
				i = 0;
				while (true) {
					KillDestructable(lw[i]);
					i = i+1;
					if (i>=5) { break; }
				}
			}
			TriggerSleepAction(3.);
			i = 0;
			while (true) {
				RemoveDestructable(lw[i]);
				lw[i] = null;
				i = i+1;
				if (i>=5) { break; }
			}
			u = null;
		}
		private void Jw() {
			unit c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(c, 'A0AW');
			IssueTargetOrderById(c, $D00C0, D4);
			UnitApplyTimedLife(c, 'BTLF', 2.);
			c = c4;
			TriggerSleepAction(.8);
			Po(c);
			c = null;
		}
		private void Kw() {
			unit c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(c, 'A0AW');
			IssueTargetOrderById(c, $D00C0, D4);
			UnitApplyTimedLife(c, 'BTLF', 2.);
			c = c4;
			TriggerSleepAction(.8);
			Po(c);
			c = null;
		}
		private void Lw() {
			unit u = c4;
			IssueImmediateOrderById(u, $D0228);
			TriggerSleepAction(.6);
			Po(u);
			u = null;
		}
		private bool Mw() {
			unit u = GetFilterUnit();
			float r = GetWidgetLife(u);
			bool Im = r>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,'A08C')<=0 && GetUnitAbilityLevel(u,'Bhea')<=0 && GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>200.;
			u = null;
			return Im;
		}
		private void Nw() {
			unit u = c4;
			UnitAddAbility(D4, 'AId2');
			DestroyEffect(AddSpecialEffectTarget("mdx\\sfx\\sin2.mdx", D4, "overhead"));
			TriggerSleepAction(.6);
			Po(u);
			u = null;
		}
		private void Ow() {
			unit u = c4;
			UnitAddAbility(D4, 'AId3');
			DestroyEffect(AddSpecialEffectTarget("mdx\\sfx\\sin2.mdx", D4, "overhead"));
			TriggerSleepAction(.6);
			if ((IssueImmediateOrderById(u,$D009E))) {
				TriggerSleepAction(1.);
			}
			Po(u);
			u = null;
		}
		private void Pw() {
			unit u = c4;
			TriggerSleepAction(3.);
			IssueImmediateOrderById(u, $D00F4);
			TriggerSleepAction(3.);
			IssueImmediateOrderById(u, $D027A);
			Po(u);
			u = null;
		}
		private void Qw(unit w) {
			unit u;
			group g = CreateGroup();
			r4 = GetOwningPlayer(w);
			GroupEnumUnitsInRange(g, GetUnitX(w), GetUnitY(w), 400., y9);
			while (true) {
				u = FirstOfGroup(g);
				if (u==null) { break; }
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\NightElf\\Blink\\BlinkCaster.mdl", u, "head"));
				SetUnitState(u, UNIT_STATE_MANA, GetUnitState(u, UNIT_STATE_MANA)-100.);
				GroupRemoveUnit(g, u);
			}
			DestroyGroup(g);
			g = null;
			u = CreateUnit(r4,'e008',GetUnitX(w),GetUnitY(w),.0);
			UnitAddAbility(u, 'A0ES');
			UnitApplyTimedLife(u, 'BTLF', 8.);
			u = null;
		}
		private void Rw() {
			player p = GetOwningPlayer(B4);
			int sm = 2*me[GetPlayerId(p)];
			int i = 0;
			int j = 0;
			unit u;
			while (true) {
				u = rm(sm+j);
				UnitRemoveAbility(u, 'Awha');
				SetUnitOwner(u, p, false);
				UnitAddType(u, UNIT_TYPE_SAPPER);
				Po(u);
				UnitApplyTimedLife(u, 'BTLF', 42.);
				j = j+1;
				if ((j>1)) {
					j = 0;
				}
				i = i+1;
				TriggerSleepAction(.3);
				if (i>=6) { break; }
			}
			u = null;
		}
		private void Sw() {
			unit c;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null || Hr(bj_groupRandomCurrentPick))) {
				return;
			}
			c = CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);
			UnitAddAbility(c, 'A0BL');
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);
			IssueTargetOrderById(c, $D0206, bj_groupRandomCurrentPick);
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = null;
		}
		private void Tw() {
			unit c;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			c = CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);
			UnitAddAbility(c, vf);
			IssuePointOrderById(c, $D0275, GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick));
			UnitApplyTimedLife(c, 'BTLF', 5.);
			c = null;
		}
		private bool Uw() {
			Bj(z4, 'h02J', 270., .0, .0);
			return false;
		}
		private bool Vw() {
			Bj(z4, 'h02J', 270., .0, .0);
			Bj(z4, 'h02E', 270., .0, .0);
			return false;
		}
		private bool Ww() {
			Bj(z4, 'h02J', 270., .0, .0);
			Bj(z4, 'h02E', 270., .0, .0);
			Bj(z4, 'h02F', 270., -25., -25.);
			return false;
		}
		private bool Xw() {
			Bj(z4, 'h02J', 270., .0, .0);
			Bj(z4, 'h02E', 270., .0, .0);
			Bj(z4, 'h02F', 270., -35., -40.);
			Bj(z4, 'h02G', 211., -35., 35.);
			return false;
		}
		private bool Yw() {
			Bj(z4, 'h02Q', 270., -35., 30.);
			return false;
		}
		private bool Zw() {
			Bj(z4, 'h02L', 270., .0, .0);
			Bj(z4, 'h02M', 270., 25, 20.);
			return false;
		}
		private bool dx() {
			Bj(z4, 'h02T', 49., -40., 20.);
			return false;
		}
		private void ex() {
			zj('n02C', 'n00T');
			Fj('n02C', function Uw);
			zj('h002', 'n00U');
			Fj('h002', function Vw);
			zj('h00Q', 'n01N');
			Fj('h00Q', function Ww);
			zj('h00R', 'n01W');
			Fj('h00R', function Xw);
			zj('h00Y', 'n026');
			zj('h012', 'n028');
			Fj('h012', function Yw);
			zj('h013', 'e006');
			zj('h01H', 'e009');
			zj('h01J', 'e00C');
			zj('h023', 'n029');
			zj('h024', 'n02B');
			Fj('h024', function Zw);
			zj('h027', 'n02A');
			zj('h028', 'e00F');
			Fj('h028', function dx);
			Ij('n02D', 700.);
			lj('h02D', function Rw);
			lj('h02C', function Sw);
			lj('h02A', function Tw);
		}
		private void fx() {
			int id;
			id = GetUnitPointValueByType('h002');
			t4[id] = $AA;
			u4[id] = $AA*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00Q');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00R');
			t4[id] = $FA;
			u4[id] = $FA*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00Y');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h012');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h013');
			t4[id] = $DC;
			u4[id] = $DC*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01H');
			t4[id] = $DC;
			u4[id] = $DC*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h023');
			t4[id] = 260;
			u4[id] = 260*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h024');
			t4[id] = 260;
			u4[id] = 260*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h027');
			t4[id] = 310;
			u4[id] = 310*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h028');
			t4[id] = 510;
			u4[id] = 510*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('n02D');
			t4[id] = $D2;
			u4[id] = $D2*.08/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h01J');
			t4[id] = 400;
			u4[id] = 400*.2/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h02A');
			t4[id] = 350;
			u4[id] = 350*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h02C');
			t4[id] = $FA;
			u4[id] = $FA*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h02D');
			t4[id] = 600;
			u4[id] = 600*.12/ 100.;
			v4[id] = false;
		}
		private void gx() {
			Lj('n026', 'A0C0', function Jw);
			Lj('n028', 'A0C1', function Kw);
			Lj('e006', 'A004', function Nw);
			Lj('e009', 'A0BT', function Ow);
			Lj('e00C', 'A0BX', function Iw);
			Lj('n01W', 'A0AV', function Pw);
			Lj('e00F', 'A0BJ', function Lw);
		}
		private void hx(unit u) {
			float x = GetUnitX(u);
			float y = GetUnitY(u);
			float an = GetUnitFacing(u)*bj_DEGTORAD;
			destructable d = CreateDestructable('VTlt',x+32.*Cos(an),y+32.*Sin(an),GetRandomReal(0,360),GetRandomReal(.5,.8),0);
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\NEDeathMedium\\NEDeath.mdl", GetDestructableX(d), GetDestructableY(d)));
			IssueTargetOrderById(u, $D021F, d);
			TriggerSleepAction(1.6);
			Po(u);
			TriggerSleepAction(2.);
			RemoveDestructable(d);
			d = null;
		}
		private void ix(unit u) {
			UnitRemoveAbility(u, 'A0C4');
			SetUnitMoveSpeed(u, 370.);
			br(u);
			TriggerSleepAction(5.);
			SetUnitMoveSpeed(u, 270.);
			UnitRemoveBuffs(u, true, true);
			IssueImmediateOrderById(u, $D0019);
			UnitAddAbility(u, 'Asla');
			UnitAddAbility(u, 'A0C7');
			UnitAddAbility(u, 'A0C8');
			TriggerSleepAction(10.);
			UnitRemoveAbility(u, 'Asla');
			UnitRemoveAbility(u, 'A0C7');
			Po(u);
		}
		private void jx(unit u) {
			UnitRemoveAbility(u, 'A0C4');
			SetUnitMoveSpeed(u, 370.);
			br(u);
			TriggerSleepAction(5.);
			SetUnitMoveSpeed(u, 270.);
			UnitRemoveBuffs(u, true, true);
			IssueImmediateOrderById(u, $D0019);
			UnitAddAbility(u, 'Asla');
			UnitAddAbility(u, 'A0C6');
			TriggerSleepAction(10.);
			UnitRemoveAbility(u, 'Asla');
			UnitRemoveAbility(u, 'A0C6');
			Po(u);
		}
		private void kx() {
			ex();
			fx();
			gx();
			yf = Filter(function Mw);
			xf = Filter(function Hw);
			wf = AddWeatherEffect(bj_mapInitialPlayableArea,'FDgh');
			EnableWeatherEffect(wf, false);
		}
		private bool nx() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,'A08C')<=0;
			u = null;
			return Im;
		}
		private void ox() {
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, af);
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Polymorph\\PolyMorphTarget.mdl", GetUnitX(B4), GetUnitY(B4)));
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\ControlMagic\\ControlMagicTarget.mdl", bj_groupRandomCurrentPick, "overhead"));
			UnitAddAbility(bj_groupRandomCurrentPick, 'A08C');
			UnitAddAbility(bj_groupRandomCurrentPick, 'A08D');
			UnitAddAbility(bj_groupRandomCurrentPick, 'A08F');
		}
		private void px() {
			unit u = GetTriggerUnit();
			player p;
			int id;
			float x;
			float y;
			if ((IsUnitType(u,UNIT_TYPE_STRUCTURE) || (!IsUnitType(GetTriggerUnit(),UNIT_TYPE_SAPPER)) || GetUnitAbilityLevel(u,'A08H')>0)) {
				u = null;
				return;
			}
			p = GetOwningPlayer(u);
			id = me[GetPlayerId(p)];
			if ((Bf[id]>0)) {
				x = GetUnitX(u);
				y = GetUnitY(u);
				DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIda\\AIdaCaster.mdl", x, y));
				u = CreateUnit(p,'e008',x,y,.0);
				UnitAddAbility(u, 'A08A');
				IssueImmediateOrderById(u, $D012D);
				UnitApplyTimedLife(u, 'BTLF', 1.);
				Bf[id] = Bf[id]-1;
				if ((Bf[0]<=0 && Bf[1]<=0)) {
					DisableTrigger(bf);
				}
			}
			u = null;
		}
		private void qx() {
			int id = me[GetPlayerId(GetOwningPlayer(B4))];
			Bf[id] = Bf[id]+1;
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl", GetUnitX(B4), GetUnitY(B4)));
			if ((!IsTriggerEnabled(bf))) {
				EnableTrigger(bf);
			}
		}
		private void rx() {
			effect e;
			fogmodifier f;
			float x;
			float y;
			bool fl;
			unit c;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			e = AddSpecialEffect("Abilities\\Spells\\NightElf\\Starfall\\StarfallCaster.mdl",GetUnitX(B4),GetUnitY(B4));
			x = GetUnitX(bj_groupRandomCurrentPick);
			y = GetUnitY(bj_groupRandomCurrentPick);
			fl = !U9;
			if ((fl)) {
				f = CreateFogModifierRadius(r4,FOG_OF_WAR_VISIBLE,x,y,1100.,true,false);
				FogModifierStart(f);
			}
			c = CreateUnit(r4,'e008',x,y,.0);
			UnitAddAbility(c, zf);
			IssueImmediateOrderById(c, $D00D7);
			UnitApplyTimedLife(c, 'BTLF', 11.);
			c = null;
			TriggerSleepAction(8.);
			if ((fl)) {
				DestroyFogModifier(f);
				f = null;
			}
			DestroyEffect(e);
			e = null;
		}
		private void ux() {
			unit c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(D4),GetUnitY(D4),.0);
			UnitAddAbility(c, 'A07A');
			IssueTargetOrderById(c, $D00CB, D4);
			UnitApplyTimedLife(c, 'BTLF', 6.);
			c = null;
		}
		private bool vx() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitType(u,UNIT_TYPE_GROUND) && GetUnitAbilityLevel(u,'Avul')<=0 && GetUnitAbilityLevel(u,'A08H')<=0;
			if ((Im && GetUnitAbilityLevel(u,'BEer')<=0 && GetUnitAbilityLevel(u,'B00M')<=0)) {
				GroupAddUnit(Af, u);
				u = null;
				return false;
			}
			u = null;
			return Im;
		}
		private void wx() {
			float x;
			float y;
			unit t;
			unit c;
			r4 = GetOwningPlayer(c4);
			x = GetUnitX(D4);
			y = GetUnitY(D4);
			bj_forLoopAIndex = 3;
			GroupClear(Af);
			GroupEnumUnitsInRange(q4, x, y, 300., Cf);
			while (true) {
				t = FirstOfGroup(Af);
				if (bj_forLoopAIndex<=0 || t==null) { break; }
				bj_forLoopAIndex = bj_forLoopAIndex-1;
				GroupRemoveUnit(Af, t);
				c = CreateUnit(r4,'e008',x,y,.0);
				UnitAddAbility(c, 'A07Q');
				UnitShareVision(t, r4, true);
				IssueTargetOrderById(c, $D00CB, t);
				UnitShareVision(t, r4, false);
				UnitApplyTimedLife(c, 'BTLF', 11.);
			}
			if ((bj_forLoopAIndex>0)) {
				while (true) {
					t = FirstOfGroup(q4);
					if (bj_forLoopAIndex<=0 || t==null) { break; }
					bj_forLoopAIndex = bj_forLoopAIndex-1;
					GroupRemoveUnit(q4, t);
					c = CreateUnit(r4,'e008',x,y,.0);
					UnitAddAbility(c, 'A07Q');
					UnitShareVision(t, r4, true);
					IssueTargetOrderById(c, $D00CB, t);
					UnitShareVision(t, r4, false);
					UnitApplyTimedLife(c, 'BTLF', 11.);
				}
			}
			t = null;
			c = null;
		}
		private void xx() {
			unit u = c4;
			TriggerSleepAction(1.2);
			Po(u);
			u = null;
		}
		private bool yx() {
			Bj(z4, 'h08L', 32., 12., -11.5);
			return false;
		}
		private bool zx() {
			Bj(z4, 'h08D', 116., -3., -10.5);
			Bj(z4, 'h08N', 323., 20., 5.75);
			return false;
		}
		private bool Ax() {
			Bj(z4, 'h08A', .0, .0, .0);
			return false;
		}
		private bool ax() {
			Bj(z4, 'h08K', .0, .0, .0);
			return false;
		}
		private bool Bx() {
			Bj(z4, 'h08K', .0, .0, .0);
			Bj(z4, 'h08S', .0, .0, .0);
			return false;
		}
		private bool bx() {
			Bj(z4, 'h08N', 226., 37.75, -41.5);
			return false;
		}
		private bool Cx() {
			Bj(z4, 'h08O', 318, 43.5, -41.75);
			Bj(z4, 'h08N', $E2, -38.25, 40.25);
			return false;
		}
		private bool cx() {
			Bj(z4, 'h08K', .0, 15., .0);
			Bj(z4, 'h08R', .0, .0, .0);
			return false;
		}
		private bool Dx() {
			Bj(z4, 'h08M', .0, .0, .0);
			Bj(z4, 'h08Q', .0, .0, .0);
			return false;
		}
		private void Ex() {
			lj('h07H', function ox);
			Fj('h07H', function yx);
			lj('h08P', function qx);
			Fj('h08P', function zx);
			Ij('h073', 850.);
			lj('h07I', function rx);
			Fj('h07I', function Ax);
			zj('h088', 'e007');
			Fj('h088', function ax);
			zj('h07D', 'e00J');
			Fj('h07D', function Bx);
			zj('h07M', 'n01Z');
			Fj('h07M', function bx);
			zj('h07L', 'n020');
			Fj('h07L', function Cx);
			zj('h07O', 'e00B');
			Fj('h07O', function cx);
			zj('h07N', 'e00A');
			Fj('h07N', function Dx);
			zj('h011', 'e002');
			zj('h00S', 'e001');
			zj('h03D', 'e003');
			zj('h03E', 'e004');
			zj('h00B', 'e000');
		}
		private void Fx() {
			int id;
			id = GetUnitPointValueByType('h088');
			t4[id] = $BE;
			u4[id] = $BE*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h07D');
			t4[id] = $D2;
			u4[id] = $D2*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h07M');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h07L');
			t4[id] = $AF;
			u4[id] = $AF*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h07O');
			t4[id] = $E6;
			u4[id] = $E6*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h07N');
			t4[id] = $F0;
			u4[id] = $F0*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h011');
			t4[id] = 285;
			u4[id] = 285*.18/ 100.;
			v4[id] = true;
			w4[id] = true;
			id = GetUnitPointValueByType('h00S');
			t4[id] = $96;
			u4[id] = $96*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03D');
			t4[id] = $C8;
			u4[id] = $C8*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03E');
			t4[id] = 400;
			u4[id] = 400*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h00B');
			t4[id] = 260;
			u4[id] = 260*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h07H');
			t4[id] = $DC;
			u4[id] = $DC*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h08P');
			t4[id] = $E1;
			u4[id] = $E1*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h073');
			t4[id] = $D2;
			u4[id] = $D2*.08/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h07I');
			t4[id] = 650;
			u4[id] = 650*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h03E');
			t4[id] = 400;
			u4[id] = 400*.2/ 100.;
			v4[id] = false;
		}
		private void Gx() {
			Lj('e007', 'A07P', function ux);
			Lj('e00J', 'A07R', function wx);
			Lj('e000', 'A0CG', function xx);
		}
		private void Hx() {
			Ex();
			Fx();
			Gx();
			af = Filter(function nx);
			Cf = Filter(function vx);
			TriggerAddAction(bf, function px);
			TriggerRegisterAnyUnitEventBJ(bf, EVENT_PLAYER_UNIT_ATTACKED);
			DisableTrigger(bf);
		}
		private bool Ix() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitType(u,UNIT_TYPE_FLYING);
			u = null;
			return Im;
		}
		private void lx() {
			unit c;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, cf);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null || Hr(bj_groupRandomCurrentPick))) {
				return;
			}
			c = CreateUnit(r4,'e008',GetUnitX(B4),GetUnitY(B4),.0);
			UnitAddAbility(c, 'A0AK');
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);
			IssueTargetOrderById(c, $D007F, bj_groupRandomCurrentPick);
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);
			UnitApplyTimedLife(c, 'BTLF', 10.);
			c = null;
		}
		private bool Jx() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_STRUCTURE) && GetPlayerId(GetOwningPlayer(u))<$C && GetUnitTypeId(u)!='hcas';
			u = null;
			return Im;
		}
		private void Kx() {
			float x;
			float y;
			unit c;
			fogmodifier f;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Df);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			x = GetUnitX(B4);
			y = GetUnitY(B4);
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\Naga\\NagaDeath\\NagaDeath.mdl", x, y));
			c = CreateUnit(r4,'h04G',x,y,.0);
			UnitApplyTimedLife(c, 'BTLF', 20.);
			if ((U9)) {
				IssueTargetOrderById(c, $D000F, bj_groupRandomCurrentPick);
			} else {
				f = CreateFogModifierRadius(r4,FOG_OF_WAR_VISIBLE,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),128.,true,false);
				FogModifierStart(f);
				IssueTargetOrderById(c, $D000F, bj_groupRandomCurrentPick);
				TriggerSleepAction(.1);
				DestroyFogModifier(f);
				f = null;
			}
			c = null;
		}
		private void Lx() {
			float x;
			float y;
			unit c;
			fogmodifier f;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Df);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			x = GetUnitX(B4);
			y = GetUnitY(B4);
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\Naga\\NagaDeath\\NagaDeath.mdl", x, y));
			c = CreateUnit(r4,'h04H',x,y,.0);
			UnitApplyTimedLife(c, 'BTLF', 20.);
			if ((U9)) {
				IssueTargetOrderById(c, $D000F, bj_groupRandomCurrentPick);
			} else {
				f = CreateFogModifierRadius(r4,FOG_OF_WAR_VISIBLE,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),128.,true,false);
				FogModifierStart(f);
				IssueTargetOrderById(c, $D000F, bj_groupRandomCurrentPick);
				TriggerSleepAction(.1);
				DestroyFogModifier(f);
				f = null;
			}
			c = null;
		}
		private void Mx() {
			int i = 0;
			float x;
			float y;
			float an;
			unit u;
			unit c;
			int t;
			while (true) {
				if (i>=Gf) { break; }
				u = Ff[i];
				an = GetUnitFacing(u);
				x = GetUnitX(u)+10.*Cos(an*bj_DEGTORAD);
				if ((x>=lf || x<=If || GetWidgetLife(u)<.405)) {
					RemoveUnit(u);
					Gf = Gf-1;
					Ff[i] = Ff[Gf];
				} else {
					y = GetUnitY(u)+10.*Sin(an*bj_DEGTORAD);
					if ((y>=Kf || y<=Jf)) {
						y = GetUnitY(u)+30.*Sin((360.-an)*bj_DEGTORAD);
						SetUnitFacing(u, 360.-an);
					}
					SetUnitX(u, x);
					SetUnitY(u, y);
					t = GetUnitUserData(u)+1;
					if ((t>50)) {
						t = 0;
						r4 = GetOwningPlayer(u);
						GroupEnumUnitsInRange(q4, x, y, 700., y9);
						bj_groupRandomConsidered = 0;
						bj_groupRandomCurrentPick = null;
						ForGroup(q4, function GroupPickRandomUnitEnum);
						if ((bj_groupRandomCurrentPick!=null)) {
							if ((IsUnitType(bj_groupRandomCurrentPick,UNIT_TYPE_FLYING))) {
								c = CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);
								UnitAddAbility(c, 'A082');
								UnitShareVision(bj_groupRandomCurrentPick, r4, true);
								IssueTargetOrderById(c, $D007F, bj_groupRandomCurrentPick);
								UnitShareVision(bj_groupRandomCurrentPick, r4, false);
								UnitApplyTimedLife(c, 'BTLF', 2.);
							} else {
								c = CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);
								UnitAddAbility(c, 'A083');
								UnitShareVision(bj_groupRandomCurrentPick, r4, true);
								IssueTargetOrderById(c, $D007F, bj_groupRandomCurrentPick);
								UnitShareVision(bj_groupRandomCurrentPick, r4, false);
								UnitApplyTimedLife(c, 'BTLF', 2.);
								c = CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);
								UnitAddAbility(c, 'A04H');
								UnitShareVision(bj_groupRandomCurrentPick, r4, true);
								IssueTargetOrderById(c, $D00CB, bj_groupRandomCurrentPick);
								UnitShareVision(bj_groupRandomCurrentPick, r4, false);
								UnitApplyTimedLife(c, 'BTLF', 16.);
							}
						}
					}
					SetUnitUserData(u, t);
					i = i+1;
				}
			}
			if ((Gf==0)) {
				PauseTimer(Ef);
			}
			u = null;
			c = null;
		}
		private void Nx() {
			unit u = B4;
			float x = GetUnitX(u);
			float y = GetUnitY(u);
			player p = GetOwningPlayer(u);
			float an = me[GetPlayerId(p)]*180.;
			int i = 0;
			unit c;
			SetUnitAnimation(u, "death");
			TriggerSleepAction(1.5);
			TimerStart(Ef, .04, true, function Mx);
			while (true) {
				c = CreateUnit(p,'h08U',x,y,ModuloReal(an+GetRandomReal(-55.,55.)+360.,360.));
				if ((md)) {
					UnitRemoveAbility(c, 'A080');
					UnitAddAbility(c, 'A084');
				}
				Ff[Gf] = c;
				Gf = Gf+1;
				i = i+1;
				if (i>2) { break; }
			}
			c = null;
			EnableWeatherEffect(Hf, true);
			TriggerSleepAction(3.7);
			SetUnitAnimation(u, "stand");
			TriggerSleepAction(2.6);
			EnableWeatherEffect(Hf, false);
			u = null;
		}
		private bool Ox() {
			SetUnitVertexColor(z4, 0, $A6, $FF, 's');
			return false;
		}
		private void Px() {
			unit c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(c, 'A05D');
			IssueImmediateOrderById(c, $D009F);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = null;
		}
		private void Qx() {
			unit c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(c, 'A043');
			IssueTargetOrderById(c, $D0102, D4);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = null;
		}
		private void Rx() {
			unit c = CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0);
			UnitAddAbility(c, 'A05B');
			IssueImmediateOrderById(c, $D026C);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = null;
		}
		private void Sx() {
			lj('h047', function lx);
			lj('h048', function Kx);
			lj('h03L', function Lx);
			lj('h03O', function Nx);
			zj('h049', 'n017');
			zj('h04F', 'n018');
			zj('h03W', 'n016');
			zj('h03T', 'n012');
			zj('h043', 'n013');
			zj('h03S', 'n014');
			Fj('h03S', function Ox);
			zj('h03K', 'n015');
			zj('h03J', 'o00A');
			Ij('h03Q', 750.);
			zj('h03U', 'n011');
			zj('h03I', 'n010');
		}
		private void Tx() {
			int id;
			id = GetUnitPointValueByType('h049');
			t4[id] = 's';
			u4[id] = 's'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04F');
			t4[id] = '}';
			u4[id] = '}'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03W');
			t4[id] = $FA;
			u4[id] = $FA*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03T');
			t4[id] = 275;
			u4[id] = 275*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h043');
			t4[id] = $E1;
			u4[id] = $E1*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03S');
			t4[id] = 400;
			u4[id] = 400*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03K');
			t4[id] = $AF;
			u4[id] = $AF*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03J');
			t4[id] = $96;
			u4[id] = $96*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03U');
			t4[id] = $A0;
			u4[id] = $A0*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03I');
			t4[id] = 280;
			u4[id] = 280*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h047');
			t4[id] = $BE;
			u4[id] = $BE*.12/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h03Q');
			t4[id] = $E6;
			u4[id] = $E6*.08/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h048');
			t4[id] = $D2;
			u4[id] = $D2*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h03L');
			t4[id] = 290;
			u4[id] = 290*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h03O');
			t4[id] = 600;
			u4[id] = 600*.09/ 100.;
			v4[id] = false;
		}
		private void Ux() {
			Lj('n016', 'A05E', function Px);
			Lj('n013', 'A05C', function Rx);
			Lj('n014', 'A044', function Qx);
		}
		private void Vx() {
			Sx();
			Tx();
			Ux();
			cf = Filter(function Ix);
			Df = Filter(function Jx);
			If = GetRectMinX(bj_mapInitialPlayableArea);
			lf = GetRectMaxX(bj_mapInitialPlayableArea);
			Jf = GetRectMinY(bj_mapInitialPlayableArea);
			Kf = GetRectMaxY(bj_mapInitialPlayableArea);
			Hf = AddWeatherEffect(bj_mapInitialPlayableArea,'SNhs');
			EnableWeatherEffect(Hf, false);
		}
		private bool Wx() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)<.405 && IsUnitType(u,UNIT_TYPE_SAPPER) && !IsUnitType(u,UNIT_TYPE_UNDEAD);
			u = null;
			return Im;
		}
		private void Xx() {
			float x;
			float y;
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Lf);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			x = GetUnitX(bj_groupRandomCurrentPick);
			y = GetUnitY(bj_groupRandomCurrentPick);
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl", x, y));
			if ((GetRandomInt(0,99)<$A)) {
				Po(CreateUnit(GetOwningPlayer(B4), Mf[3], x, y, .0));
			} else {
				Po(CreateUnit(GetOwningPlayer(B4), Mf[GetRandomInt(0, 2)], x, y, .0));
			}
			RemoveUnit(bj_groupRandomCurrentPick);
		}
		private void Yx() {
			float x;
			float y;
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Lf);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			x = GetUnitX(bj_groupRandomCurrentPick);
			y = GetUnitY(bj_groupRandomCurrentPick);
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl", x, y));
			if ((GetRandomInt(0,99)<$A)) {
				Po(CreateUnit(GetOwningPlayer(B4), Mf[7], x, y, .0));
			} else {
				Po(CreateUnit(GetOwningPlayer(B4), Mf[GetRandomInt(1, 6)], x, y, .0));
			}
			RemoveUnit(bj_groupRandomCurrentPick);
		}
		private void Zx() {
			unit u;
			r4 = GetOwningPlayer(B4);
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);
			bj_groupRandomConsidered = 0;
			bj_groupRandomCurrentPick = null;
			ForGroup(q4, function GroupPickRandomUnitEnum);
			if ((bj_groupRandomCurrentPick==null)) {
				return;
			}
			if (!Hr(bj_groupRandomCurrentPick)) {
				UnitDamageTarget(B4, bj_groupRandomCurrentPick, 50000., true, false, ATTACK_TYPE_NORMAL, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);
			}
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathCoil\\DeathCoilSpecialArt.mdl", GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick)));
			u = B4;
			SetUnitAnimation(u, "work");
			TriggerSleepAction(1.);
			SetUnitAnimation(u, "stand");
			u = null;
		}
		private void dy() {
			zj('h01K', 'u005');
			zj('h04B', 'u009');
			zj('h055', 'u00D');
			Ij('h01O', 800.);
			zj('h01T', 'n00E');
			lj('h01P', function Xx);
			lj('h056', function Yx);
			zj('h01N', 'h01U');
			zj('h054', 'h05H');
			zj('h01L', 'u001');
			zj('h01S', 'u000');
			lj('h00A', function Zx);
			zj('h01R', 'n00B');
			zj('h04Z', 'n01K');
			zj('h03M', 'u007');
		}
		private void ey() {
			int id;
			id = GetUnitPointValueByType('h01K');
			t4[id] = $D2;
			u4[id] = $D2*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04B');
			t4[id] = $AA;
			u4[id] = $AA*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01T');
			t4[id] = 370;
			u4[id] = 370*.18/ 100.;
			v4[id] = true;
			w4[id] = true;
			id = GetUnitPointValueByType('h01P');
			t4[id] = $A0;
			u4[id] = $A0*.12/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h056');
			t4[id] = $8C;
			u4[id] = $8C*.12/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01N');
			t4[id] = $E6;
			u4[id] = $E6*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h054');
			t4[id] = 265;
			u4[id] = 265*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01L');
			t4[id] = 290;
			u4[id] = 290*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01S');
			t4[id] = 500;
			u4[id] = 500*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01R');
			t4[id] = 'x';
			u4[id] = 'x'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h04Z');
			t4[id] = 'd';
			u4[id] = 'd'*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h03M');
			t4[id] = $CD;
			u4[id] = $CD*.2/ 100.;
			v4[id] = true;
			id = GetUnitPointValueByType('h01O');
			t4[id] = $C8;
			u4[id] = $C8*.08/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h055');
			t4[id] = 370;
			u4[id] = 370*.2/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h00A');
			t4[id] = 360;
			u4[id] = 360*.09/ 100.;
			v4[id] = false;
			id = GetUnitPointValueByType('h01Q');
			t4[id] = 650;
			u4[id] = 650*.09/ 100.;
			v4[id] = false;
		}
		private void fy() {
		}
		private void gy() {
			unit u = GetSummonedUnit();
			int aj = GetUnitTypeId(u);
			if ((aj=='u004')) {
				Po(ReplaceUnitBJ(u, Mf[GetRandomInt(0, 2)], 2));
			} else if ((aj=='u008')) {
				Po(ReplaceUnitBJ(u, Mf[GetRandomInt(0, 6)], 2));
			} else if ((aj=='u00E')) {
				aj = GetRandomInt(0,7);
				if ((aj==0)) {
					aj = 7;
				} else {
					aj = GetRandomInt(3,6);
				}
				Po(ReplaceUnitBJ(u, Mf[aj], 2));
				UnitAddAbility(bj_lastReplacedUnit, 'A088');
				UnitAddAbility(bj_lastReplacedUnit, 'A089');
			}
			u = null;
		}
		private void hy(unit k, unit d, int bj) {
			float x = GetUnitX(d);
			float y = GetUnitY(d);
			CreateUnit(GetOwningPlayer(k), bj, x, y, .0);
			RemoveUnit(d);
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl", x, y));
		}
		private void iy() {
			trigger t;
			dy();
			ey();
			fy();
			Lf = Filter(function Wx);
			Mf[0] = 'u002';
			Mf[1] = 'n00D';
			Mf[2] = 'u00A';
			Mf[3] = 'n00C';
			Mf[4] = 'u00B';
			Mf[5] = 'n01L';
			Mf[6] = 'u003';
			Mf[7] = 'n01M';
			t = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(t, EVENT_PLAYER_UNIT_SUMMON);
			TriggerAddAction(t, function gy);
		}
		private void jy(unit u, float x, float y) {
			unit c = CreateUnit(GetOwningPlayer(u),'e008',x,y,.0);
			UnitAddAbility(c, 'A086');
			IssuePointOrderById(c, $D00FD, x, y);
			UnitApplyTimedLife(c, 'BTLF', 6.);
			c = null;
		}
		private void ky(unit u, unit v) {
			int i = GetRandomInt(0,99);
			if ((i<$F && GetUnitAbilityLevel(v,'A070')<=0 && !IsUnitType(v,UNIT_TYPE_MECHANICAL))) {
				if ((GetWidgetLife(v)<.405)) {
					return;
				}
				SetUnitState(u, UNIT_STATE_LIFE, GetUnitState(u, UNIT_STATE_LIFE)+GetUnitState(v, UNIT_STATE_LIFE)/ 2.);
				UnitDamageTarget(u, v, 10000., true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Orc\\AncestralSpirit\\AncestralSpiritCaster.mdl", v, "chest"));
			} else if ((i<25)) {
				jy(u, GetUnitX(v), GetUnitY(v));
			}
		}
		private void ny(unit u, unit v) {
			unit c;
			if ((GetRandomInt(0,99)<$F)) {
				c = CreateUnit(GetOwningPlayer(u),'e008',GetUnitX(u),GetUnitY(u),.0);
				UnitAddAbility(c, 'A09T');
				IssueTargetOrderById(c, $D0097, v);
				UnitApplyTimedLife(c, 'BTLF', 4.);
				c = null;
			}
		}
		private void oy(unit u, unit v) {
			unit c;
			if ((GetRandomInt(0,99)<40)) {
				c = CreateUnit(GetOwningPlayer(u),'e008',GetUnitX(u),GetUnitY(u),.0);
				UnitAddAbility(c, 'A0DC');
				IssueTargetOrderById(c, $D011C, v);
				UnitApplyTimedLife(c, 'BTLF', 4.);
				c = null;
			}
		}
		private void py(unit v) {
			int i = GetUnitAbilityLevel(v,'A0C9');
			if ((i<=0)) {
				UnitAddAbility(v, 'A0C9');
			} else if ((i<3)) {
				SetUnitAbilityLevel(v, 'A0C9', i+1);
			}
		}
		private void qy(unit v) {
			unit u;
			if ((GetRandomInt(0,99)<$F)) {
				u = CreateUnit(GetOwningPlayer(v),'e008',GetUnitX(v),GetUnitY(v),.0);
				UnitAddAbility(u, 'A0B7');
				IssueTargetOrderById(u, $D0062, v);
				UnitApplyTimedLife(u, 'BTLF', 2.);
				u = CreateUnit(GetOwningPlayer(v),'e008',GetUnitX(v),GetUnitY(v),.0);
				UnitAddAbility(u, 'A0B5');
				IssueTargetOrderById(u, $D0085, v);
				UnitApplyTimedLife(u, 'BTLF', 2.);
				u = null;
			}
		}
		private void ry(unit v) {
			unit u;
			if ((GetRandomInt(0,99)<20)) {
				u = CreateUnit(GetOwningPlayer(v),'e008',GetUnitX(v),GetUnitY(v),.0);
				UnitAddAbility(u, 'A0B8');
				IssueTargetOrderById(u, $D0062, v);
				UnitApplyTimedLife(u, 'BTLF', 2.);
				u = CreateUnit(GetOwningPlayer(v),'e008',GetUnitX(v),GetUnitY(v),.0);
				UnitAddAbility(u, 'A0B6');
				IssueTargetOrderById(u, $D0085, v);
				UnitApplyTimedLife(u, 'BTLF', 2.);
				u = null;
			}
		}
		private void uy(unit u) {
			if ((GetRandomInt(0,99)<$F)) {
				UnitRemoveBuffsEx(u, true, false, true, false, false, false, false);
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl", u, "overhead"));
			}
		}
		private void vy(unit u) {
			if ((GetRandomInt(0,99)<20)) {
				UnitRemoveBuffsEx(u, true, false, true, false, false, false, false);
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl", u, "overhead"));
			}
		}
		private void wy() {
			unit u = GetEnumUnit();
			UnitRemoveBuffsEx(u, true, false, true, false, false, false, false);
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl", u, "overhead"));
			u = null;
		}
		private void xy(unit u, unit t) {
			r4 = GetOwningPlayer(u);
			if ((GetRandomInt(0,99)<25)) {
				GroupEnumUnitsInRange(q4, GetUnitX(t), GetUnitY(t), 100., y9);
				ForGroup(q4, function wy);
			}
		}
		private void yy(unit s, unit u) {
			int zy = GetUnitLevel(u);
			unit c;
			if ((IsUnitType(s,UNIT_TYPE_MELEE_ATTACKER) && GetRandomInt(0,99)<=$F*zy)) {
				c = CreateUnit(GetOwningPlayer(u),'e008',GetUnitX(u),GetUnitY(u),.0);
				UnitAddAbility(c, 'A0D5');
				SetUnitAbilityLevel(c, 'A0D5', zy);
				IssueTargetOrderById(c, $D007F, s);
				UnitApplyTimedLife(c, 'BTLF', 4.);
				c = null;
			}
		}
		private void Ay(unit u) {
			if ((GetRandomInt(0,99)<20)) {
				IssueImmediateOrderById(u, $D009B);
			}
		}
		private void ay(unit u, float d) {
			float mp = GetUnitState(u,UNIT_STATE_MANA)+d;
			if ((mp>=680.)) {
				UnitRemoveAbility(u, 'A0C5');
				SetUnitMoveSpeed(u, 450.);
				UnitAddAbility(u, 'A0EN');
				IssueImmediateOrderById(u, $D0049);
			} else {
				SetUnitState(u, UNIT_STATE_MANA, mp);
			}
		}
		private void By(unit u) {
			float r = GetWidgetLife(u);
			if ((r<128. && r>.405)) {
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Undead\\DeathPact\\DeathPactCaster.mdl", u, "origin"));
				SetWidgetLife(u, 5000.);
				UnitRemoveAbility(u, 'A0EZ');
			}
		}
		private bool by() {
			unit u = GetFilterUnit();
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,'Avul')<=0  && ((Of && IsUnitType(u,UNIT_TYPE_GROUND)) || (Pf && IsUnitType(u,UNIT_TYPE_FLYING)));
			u = null;
			return Im;
		}
		private void Cy(unit Ui, float cy, float x, float y, bool Dy, bool Ey) {
			player p = GetOwningPlayer(Ui);
			unit u = CreateUnit(p,'e008',x,y,.0);
			unit j;
			r4 = p;
			Of = Dy;
			Pf = Ey;
			GroupEnumUnitsInRange(q4, x, y, 250., Qf);
			while (true) {
				j = FirstOfGroup(q4);
				if (j==null) { break; }
				GroupRemoveUnit(q4, j);
				UnitDamageTarget(u, j, cy, true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS);
			}
			UnitApplyTimedLife(u, 'BTLF', 1.);
			u = null;
		}
		private bool Fy() {
			unit s = GetEventDamageSource();
			unit u = GetTriggerUnit();
			int Gy;
			if ((GetUnitAbilityLevel(s,'A03Q')>0)) {
				if ((GetUnitAbilityLevel(s,'A0F1')>0)) {
					Cy(s, .5*GetEventDamage(), GetUnitX(u), GetUnitY(u), IsUnitType(s, UNIT_TYPE_ATTACKS_GROUND), IsUnitType(s, UNIT_TYPE_ATTACKS_FLYING));
				}
				Gy = GetUnitTypeId(s);
				if ((Gy=='u00D')) {
					ky(s, u);
				} else if ((Gy=='h05L')) {
					ny(s, u);
				} else if ((Gy=='h061')) {
					oy(s, u);
				} else if ((Gy=='n02A')) {
					py(u);
				} else if ((Gy=='n02B')) {
					UnitRemoveAbility(s, 'A0C8');
				} else if ((Gy=='e006')) {
					uy(u);
				} else if ((Gy=='e009')) {
					vy(u);
				} else if ((Gy=='e00C')) {
					xy(s, u);
				} else if ((GetUnitAbilityLevel(s,'A0DW')>0)) {
					DisableTrigger(Nf);
					UnitDamageTarget(s, u, 50.*GetUnitLevel(s)*GetWidgetLife(s)/ GetUnitState(s, UNIT_STATE_MAX_LIFE), true, false, ATTACK_TYPE_SIEGE, DAMAGE_TYPE_DEMOLITION, WEAPON_TYPE_WHOKNOWS);
					EnableTrigger(Nf);
				} else if ((Gy=='h02Y')) {
					Ay(s);
				}
			}
			if ((GetWidgetLife(u)>.405 && GetUnitAbilityLevel(u,'A0C5')>0)) {
				Gy = GetUnitTypeId(u);
				if ((Gy=='n029')) {
					qy(u);
					if ((GetUnitAbilityLevel(u,'A0C4')>0 && GetWidgetLife(u)<255.)) {
						jx(u);
					} else {
						UnitRemoveAbility(u, 'Asla');
						UnitRemoveAbility(u, 'A0C6');
					}
				} else if ((Gy=='n02B')) {
					ry(u);
					if ((GetUnitAbilityLevel(u,'A0C4')>0 && GetWidgetLife(u)<255.)) {
						ix(u);
					} else {
						UnitRemoveAbility(u, 'Asla');
						UnitRemoveAbility(u, 'A0C7');
					}
				} else if ((GetUnitAbilityLevel(u,'A0DX')>0)) {
					yy(s, u);
				} else if ((GetUnitAbilityLevel(u,'A0EZ')>0)) {
					By(u);
				} else if ((Gy=='o00E')) {
					ay(u, GetEventDamage());
				}
			}
			if ((zd)) {
				yr(u);
			}
			u = null;
			s = null;
			return false;
		}
		private void Hy() {
			if ((Nf!=null)) {
				TriggerClearActions(Nf);
				DestroyTrigger(Nf);
			}
			Nf = CreateTrigger();
			TriggerAddAction(Nf, function Fy);
			Qf = Filter(function by);
		}
		private void Iy() {
			int i = 0;
			while (true) {
				if ((D9[i]!=null)) {
					if ((GetLocalPlayer()==Player(i))) {
						MultiboardDisplay(D9[i], true);
					}
				} else {
					if ((GetLocalPlayer()==Player(i))) {
						MultiboardDisplay(G9, true);
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void ly() {
			int i = 0;
			int x = 0;
			multiboarditem Jy;
			player p;
			while (true) {
				if ((E9[i]!=null)) {
					p = Player(i);
					Jy = MultiboardGetItem(E9[i],F9[i],3);
					MultiboardSetItemValue(Jy, I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_GOLD)));
					MultiboardReleaseItem(Jy);
					Jy = MultiboardGetItem(E9[i],F9[i],4);
					MultiboardSetItemValue(Jy, I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_LUMBER)));
					MultiboardReleaseItem(Jy);
					Jy = MultiboardGetItem(E9[i],F9[i],5);
					MultiboardSetItemValue(Jy, I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_FOOD_USED))+"/"+I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_FOOD_CAP)));
					MultiboardReleaseItem(Jy);
				}
				if ((H9[i]>0)) {
					p = Player(i);
					if ((IsPlayerInForce(p,ie))) {
						x = 0;
					} else {
						x = 6;
					}
					Jy = MultiboardGetItem(G9,H9[i],x+2);
					MultiboardSetItemValue(Jy, I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_GOLD)));
					MultiboardReleaseItem(Jy);
					Jy = MultiboardGetItem(G9,H9[i],x+3);
					MultiboardSetItemValue(Jy, I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_LUMBER)));
					MultiboardReleaseItem(Jy);
					Jy = MultiboardGetItem(G9,H9[i],x+4);
					MultiboardSetItemValue(Jy, I2S(nf[i]));
					MultiboardReleaseItem(Jy);
				}
				i = i+1;
				if (i>$B) { break; }
			}
			Jy = null;
		}
		private void Ky(int dk, string Ly) {
			int i = 0;
			int j = 0;
			multiboarditem Jy;
			MultiboardSetRowCount(D9[dk], CountPlayersInForceBJ(ne[dk])+6);
			Jy = MultiboardGetItem(D9[dk],4,0);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],4,1);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],4,2);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],4,3);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],4,4);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],4,5);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],5,0);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],5,1);
			MultiboardSetItemStyle(Jy, true, false);
			MultiboardSetItemValue(Jy, Ly);
			MultiboardSetItemWidth(Jy, .1);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],5,2);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],5,3);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],5,4);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(D9[dk],5,5);
			MultiboardSetItemStyle(Jy, false, false);
			MultiboardReleaseItem(Jy);
			while (true) {
				if ((IsPlayerInForce(Player(i),ne[dk]))) {
					Jy = MultiboardGetItem(D9[dk],j+6,0);
					MultiboardSetItemStyle(Jy, true, false);
					MultiboardSetItemValue(Jy, pe[i]);
					MultiboardSetItemWidth(Jy, .09);
					MultiboardReleaseItem(Jy);
					Jy = MultiboardGetItem(D9[dk],j+6,1);
					MultiboardSetItemStyle(Jy, false, false);
					MultiboardSetItemWidth(Jy, .0001);
					MultiboardReleaseItem(Jy);
					Jy = MultiboardGetItem(D9[dk],j+6,2);
					MultiboardSetItemStyle(Jy, false, false);
					MultiboardSetItemWidth(Jy, .0001);
					MultiboardReleaseItem(Jy);
					Jy = MultiboardGetItem(D9[dk],j+6,3);
					MultiboardSetItemStyle(Jy, true, true);
					MultiboardSetItemIcon(Jy, "UI\\Feedback\\Resources\\ResourceGold.blp");
					MultiboardSetItemWidth(Jy, .035);
					MultiboardReleaseItem(Jy);
					Jy = MultiboardGetItem(D9[dk],j+6,4);
					MultiboardSetItemStyle(Jy, true, true);
					MultiboardSetItemIcon(Jy, "UI\\Feedback\\Resources\\ResourceLumber.blp");
					MultiboardSetItemWidth(Jy, .035);
					MultiboardReleaseItem(Jy);
					Jy = MultiboardGetItem(D9[dk],j+6,5);
					MultiboardSetItemStyle(Jy, true, true);
					MultiboardSetItemIcon(Jy, "UI\\Feedback\\Resources\\ResourceManaStone.blp");
					MultiboardSetItemWidth(Jy, .03);
					MultiboardReleaseItem(Jy);
					E9[i] = D9[dk];
					F9[i] = j+6;
					j = j+1;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			Jy = null;
		}
		private void My() {
			int i = IMaxBJ(CountPlayersInForceBJ(ie),CountPlayersInForceBJ(je));
			int j = 0;
			multiboarditem Jy;
			MultiboardSetTitleText(G9, Rf);
			MultiboardSetRowCount(G9, 6+i);
			I9 = 4+i;
			MultiboardSetColumnCount(G9, $B);
			MultiboardSetItemStyleBJ(G9, 0, 0, true, false);
			MultiboardSetItemWidthBJ(G9, 1, 0, 8.);
			MultiboardSetItemWidthBJ(G9, 6, 0, 1.);
			MultiboardSetItemWidthBJ(G9, 7, 0, 8.);
			Jy = MultiboardGetItem(G9,I9+1,0);
			MultiboardSetItemWidth(Jy, 10.);
			MultiboardReleaseItem(Jy);
			i = 0;
			while (true) {
				Jy = MultiboardGetItem(G9,0,i+0);
				MultiboardSetItemValue(Jy, "|cffFFFF80Team|r");
				MultiboardReleaseItem(Jy);
				Jy = MultiboardGetItem(G9,0,i+1);
				MultiboardSetItemValue(Jy, "|cffFFFF80Resc.|r");
				MultiboardReleaseItem(Jy);
				Jy = MultiboardGetItem(G9,0,i+2);
				MultiboardSetItemValue(Jy, "|cffFFFF80Destr.|r");
				MultiboardReleaseItem(Jy);
				Jy = MultiboardGetItem(G9,0,i+3);
				MultiboardSetItemValue(Jy, "|cffFFFF80Income|r");
				MultiboardReleaseItem(Jy);
				Jy = MultiboardGetItem(G9,0,i+4);
				MultiboardSetItemValue(Jy, "|cffFFFF80Wins|r");
				MultiboardReleaseItem(Jy);
				MultiboardSetItemWidthBJ(G9, i+5, 0, 1.8);
				i = i+(6);
				if (i>6) { break; }
			}
			Jy = MultiboardGetItem(G9,1,0);
			MultiboardSetItemValue(Jy, "|cffFF0000West|r");
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(G9,1,6);
			MultiboardSetItemValue(Jy, "|cff00FF00East|r");
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(G9,1,2);
			MultiboardSetItemValue(Jy, "0");
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(G9,1,8);
			MultiboardSetItemValue(Jy, "0");
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(G9,1,4);
			MultiboardSetItemValue(Jy, I2S(Hd[0]));
			MultiboardReleaseItem(Jy);
			Jy = MultiboardGetItem(G9,1,$A);
			MultiboardSetItemValue(Jy, I2S(Hd[1]));
			MultiboardReleaseItem(Jy);
			i = 0;
			while (true) {
				Jy = MultiboardGetItem(G9,3,i+0);
				MultiboardSetItemValue(Jy, "|cffFFFF80Player|r");
				MultiboardReleaseItem(Jy);
				Jy = MultiboardGetItem(G9,3,i+1);
				MultiboardSetItemStyle(Jy, false, true);
				MultiboardSetItemIcon(Jy, "ReplaceableTextures\\CommandButtons\\BTNHolyBolt.blp");
				MultiboardReleaseItem(Jy);
				Jy = MultiboardGetItem(G9,3,i+2);
				MultiboardSetItemStyle(Jy, false, true);
				MultiboardSetItemIcon(Jy, "UI\\Feedback\\Resources\\ResourceGold.blp");
				MultiboardReleaseItem(Jy);
				Jy = MultiboardGetItem(G9,3,i+3);
				MultiboardSetItemStyle(Jy, false, true);
				MultiboardSetItemIcon(Jy, "UI\\Feedback\\Resources\\ResourceLumber.blp");
				MultiboardReleaseItem(Jy);
				Jy = MultiboardGetItem(G9,3,i+4);
				MultiboardSetItemStyle(Jy, false, true);
				MultiboardSetItemIcon(Jy, "ReplaceableTextures\\CommandButtons\\BTNChestOfGold.blp");
				MultiboardReleaseItem(Jy);
				i = i+(6);
				if (i>6) { break; }
			}
			i = 0;
			j = 4;
			while (true) {
				if ((IsPlayerInForce(Player(i),ie))) {
					H9[i] = j;
					Jy = MultiboardGetItem(G9,H9[i],0);
					MultiboardSetItemValue(Jy, pe[i]);
					MultiboardReleaseItem(Jy);
					j = j+1;
				} else {
					H9[i] = 0;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			i = 0;
			j = 4;
			while (true) {
				if ((IsPlayerInForce(Player(i),je))) {
					H9[i] = j;
					Jy = MultiboardGetItem(G9,H9[i],6);
					MultiboardSetItemValue(Jy, pe[i]);
					MultiboardReleaseItem(Jy);
					j = j+1;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			Jy = null;
		}
		private void Ny() {
			int i = 0;
			player p;
			string Oy = GetLocalizedString("TEAM_RESOURCES")+":";
			if ((bd>0 || Dd>0)) {
				if ((h8)) {
					Ts();
				}
			}
			if ((h8)) {
				Bn();
			}
			if ((G9!=null)) {
				DestroyMultiboard(G9);
			}
			G9 = CreateMultiboard();
			My();
			while (true) {
				p = Player(i);
				if ((ne[i]!=null)) {
					if ((D9[i]!=null)) {
						DestroyMultiboard(D9[i]);
					}
					D9[i] = CreateMultiboard();
					MultiboardSetRowCount(D9[i], 4);
					MultiboardSetColumnCount(D9[i], 6);
					MultiboardSetTitleText(D9[i], Rf);
					MultiboardSetItemStyleBJ(D9[i], 0, 0, true, false);
					MultiboardSetItemValueBJ(D9[i], 0, 0, "0");
					MultiboardSetItemValueBJ(D9[i], 0, 4, "");
					MultiboardSetItemColorBJ(D9[i], 6, 0, 'd', 90., .0, 0);
					MultiboardSetItemValueBJ(D9[i], 1, 1, "");
					MultiboardSetItemValueBJ(D9[i], 2, 1, "Resc.");
					MultiboardSetItemValueBJ(D9[i], 3, 1, "Coins");
					MultiboardSetItemValueBJ(D9[i], 4, 1, "Destr.");
					MultiboardSetItemValueBJ(D9[i], 5, 1, "Income");
					MultiboardSetItemValueBJ(D9[i], 6, 1, "|cffFFFF80Wins|r");
					MultiboardSetItemValueBJ(D9[i], 1, 2, "|cffFF0000West|r");
					MultiboardSetItemValueBJ(D9[i], 1, 3, "|cff00FF00East|r");
					MultiboardSetItemValueBJ(D9[i], 1, 4, "|cffFFFF00Round Time:|r");
					MultiboardSetItemValueBJ(D9[i], 6, 4, "|cffFFFF000|cffFF8000:|cffFFFF0000|r");
					MultiboardSetItemWidthBJ(D9[i], 0, 4, 2.);
					MultiboardSetItemWidthBJ(D9[i], 1, 4, 7.);
					MultiboardSetItemWidthBJ(D9[i], 6, 4, 3.);
					if ((CountPlayersInForceBJ(ne[i])>0)) {
						Ky(i, Oy);
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
			if ((Sf==null)) {
				Sf = CreateTimer();
				TimerStart(Sf, 1., true, function ly);
			}
			Yr(5, 1, I2S(Hd[0]));
			Yr(5, 2, I2S(Hd[1]));
			Iy();
		}
		private void Py() {
			int i = 0;
			while (true) {
				if ((Uf[i]>3)) {
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[i]+" |c00ff0000have used stopping bug!|r");
				}
				Uf[i] = 0;
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private bool Qy() {
			unit u = GetTriggerUnit();
			if ((GetIssuedOrderId()==$D0003)) {
				Vf[GetPlayerId(GetOwningPlayer(u))] = M9;
				if ((IsUnitType(u,UNIT_TYPE_SAPPER))) {
					Qo(u);
				} else if ((GetUnitTypeId(u)=='h001')) {
					cv(u);
				}
			}
			u = null;
			return false;
		}
		private bool Ry() {
			unit u = GetTriggerUnit();
			int dk = GetPlayerId(GetOwningPlayer(u));
			if ((GetIssuedOrderId()==$D0003)) {
				Vf[GetPlayerId(GetOwningPlayer(u))] = M9;
				if ((IsUnitType(u,UNIT_TYPE_SAPPER))) {
					Qo(u);
					Uf[dk] = Uf[dk]+1;
				} else if ((GetUnitTypeId(u)=='h001')) {
					cv(u);
				}
			}
			u = null;
			return false;
		}
		private void Sy() {
			if ((Tf!=null)) {
				return;
			}
			Tf = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(Tf, EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER);
			TriggerRegisterAnyUnitEventBJ(Tf, EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER);
			if ((wd)) {
				TriggerAddCondition(Tf, Condition(function Ry));
				TimerStart(CreateTimer(), 1.5, true, function Py);
			} else {
				TriggerAddCondition(Tf, Condition(function Qy));
			}
		}
		private void Ty() {
			int i = 0;
			player p;
			while (true) {
				p = Player(i);
				if ((GetPlayerSlotState(p)==PLAYER_SLOT_STATE_PLAYING && GetPlayerController(p)==MAP_CONTROL_USER && !qe[i])) {
					if ((M9-Vf[i]>4)) {
						DisplayTextToPlayer(Player(i), .0, .0, "|cffCA0000WARNING|r: You did not move your worker for 5 minutes. AI will take control in 60 seconds!");
						if ((M9-Vf[i]>5)) {
							Kt(i);
						}
					}
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void Uy() {
			if ((Wf!=null)) {
				PauseTimer(Wf);
			}
		}
		private void Vy() {
			int i = 0;
			while (true) {
				Vf[i] = 0;
				i = i+1;
				if (i>$B) { break; }
			}
			if ((Wf!=null)) {
				TimerStart(Wf, 60., true, function Ty);
			}
		}
		private void Wy() {
			if ((Wf==null)) {
				Wf = CreateTimer();
			}
		}
		private void Xy(bool fl) {
			string s1;
			string s2;
			if (((!fl) && fg)) {
				return;
			}
			fg = true;
			if ((dd==1)) {
				if ((Z9==0)) {
					s1 = pe[0]+" has chosen single round/pick race. You may pick your race! The first round determines the winner!";
					s2 = "Single Round Pick";
				} else if ((Z9==1)) {
					s1 = pe[0]+" has chosen single round/random race. You will get a random race! The first round determines the winner!";
					s2 = "Single Round Random";
				} else if ((Z9==2)) {
					s1 = pe[0]+" has chosen single round/mirror mode. Both teams will get the same random races! The first round determines the winner!";
					s2 = "Single Round Random";
				} else if ((Z9==3)) {
					s1 = pe[0]+" has chosen single round/draft race. Races will be drafted! The first round determines the winner!";
					s2 = "Single Round Draft";
				}
			} else {
				if ((jd)) {
					if ((Z9==0)) {
						s1 = pe[0]+" has chosen |cffFFFF00pick|r race. You may pick a race at the beginning that you keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";
						s2 = "Pick once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";
					} else if ((Z9==1)) {
						s1 = pe[0]+" has chosen |cffFFFF00random|r race. You will get a random race at the beginning that you keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";
						s2 = "Random once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";
					} else if ((Z9==2)) {
						s1 = pe[0]+" has chosen |cffFFFF00mirror mode|r. Both teams will get the same random races at the beginning that they will keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";
						s2 = "Mirror once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";
					} else if ((Z9==3)) {
						s1 = pe[0]+" has chosen |cffFFFF00draft|r race. You will draft a race at the beginning that you keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";
						s2 = "Draft once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";
					}
				} else {
					if ((Z9==0)) {
						s1 = pe[0]+" has chosen |cffFFFF00pick|r race |cffFFFF00each round|r. You may pick a new race each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";
						s2 = "Pick each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";
					} else if ((Z9==1)) {
						s1 = pe[0]+" has chosen |cffFFFF00random|r race |cffFFFF00each round|r. You will get a new random race each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";
						s2 = "Random each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";
					} else if ((Z9==2)) {
						s1 = pe[0]+" has chosen  |cffFFFF00mirror mode each round|r. Both teams will get the same random races each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";
						s2 = "Mirror each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";
					} else if ((Z9==3)) {
						s1 = pe[0]+" has chosen |cffFFFF00draft|r race |cffFFFF00each round|r. You will draft a new race each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";
						s2 = "Draft each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";
					}
				}
			}
			Rf = "|cffFFFF80"+s2+"|r";
			if ((fl || !c9)) {
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 25., s1);
			}
		}
		private void Yy() {
			eg[0] = null;
			eg[1] = null;
			eg[2] = null;
			eg[3] = null;
			DialogClear(dg);
			DialogDestroy(dg);
			dg = null;
			DestroyTimerDialog(Yf);
			Yf = null;
			DestroyTimer(Xf);
			Xf = null;
			DestroyTrigger(Zf);
			Zf = null;
			Xy(false);
			TriggerExecute(zg);
		}
		private void Zy() {
			jd = not(GetClickedButton()==eg[0]);
			TriggerSleepAction(.1);
			Yy();
		}
		private void dz() {
			TriggerSleepAction(.1);
			DialogClear(dg);
			DialogSetMessage(dg, "New races after each round?");
			eg[0] = DialogAddButton(dg,"YES",0);
			eg[1] = DialogAddButton(dg,"NO",0);
			TriggerClearActions(Zf);
			TriggerAddAction(Zf, function Zy);
			DialogDisplay(Player(0), dg, true);
		}
		private void ez() {
			if ((GetClickedButton()==eg[0])) {
				V9 = "fz";
				Z9 = 0;
			} else {
				V9 = "gz";
				Z9 = 1;
			}
			if ((dd==1)) {
				jd = false;
				Yy();
			} else {
				dz();
			}
		}
		private void hz() {
			TriggerSleepAction(.1);
			DialogClear(dg);
			DialogSetMessage(dg, "Race selection?");
			eg[0] = DialogAddButton(dg,"Pick your race!",0);
			eg[1] = DialogAddButton(dg,"Random race!",0);
			TriggerClearActions(Zf);
			TriggerAddAction(Zf, function ez);
			DialogDisplay(Player(0), dg, true);
		}
		private void iz() {
			button cl = GetClickedButton();
			int i = 0;
			while (true) {
				if (cl==eg[i]) { break; }
				i = i+1;
			}
			dd = i+1;
			cl = null;
			hz();
		}
		private void jz() {
			PauseTimer(Xf);
			S9 = false;
			if ((Z9!=-1)) {
				Yy();
				return;
			}
			DialogSetMessage(dg, "Number of victories?");
			eg[0] = DialogAddButton(dg,"1",0);
			eg[1] = DialogAddButton(dg,"2",0);
			eg[2] = DialogAddButton(dg,"3",0);
			eg[3] = DialogAddButton(dg,"4",0);
			TriggerAddAction(Zf, function iz);
			DialogDisplay(Player(0), dg, true);
		}
		private void kz() {
			TimerStart(Xf, 20., false, function jz);
			Yf = CreateTimerDialog(Xf);
			TimerDialogSetTitle(Yf, "Game starts:");
			TimerDialogDisplay(Yf, true);
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 30., "Welcome to |cffFFFF80Castle Fight|r |c0000ffffES|r |c0080ff001.22a|r! |cffFF0000"+GetPlayerName(Player(0))+"|r has now 20 seconds to choose game modes. If you are new to this map, you can find some useful hints in the |cff80FF00Manual|r (|cffFFBA17F9|r).");
			DisplayTimedTextToPlayer(Player(0), .0, .0, 30., "Welcome to |cffFFFF80Castle Fight|r! You have 20 seconds to enter gamemodes. If you don't enter a valid command, you will be able to choose gamemodes via dialogues. If you don't know how to enter gamemodes read the |cff80FF00Manual|r (|cffFFBA17F9|r).");
			CinematicFadeBJ(1, .0, "ReplaceableTextures\\CameraMasks\\Black_mask.blp", .0, 0, 0, 6.);
			FlashQuestDialogButton();
		}
		private void mz() {
			TimerStart(Xf, .01, false, function kz);
			TriggerRegisterDialogEvent(Zf, dg);
		}
		private void nz() {
			Rk(("Wins"), (GetEnumPlayer()), p7[('e')], I2S((1)), 'g');
			dm(GetEnumPlayer(), 'g');
		}
		private void oz() {
			CustomVictoryBJ(GetEnumPlayer(), true, true);
		}
		private void pz() {
			Rk(("Loses"), (GetEnumPlayer()), p7[('e')], I2S((1)), 'g');
			dm(GetEnumPlayer(), 'f');
			CustomDefeatBJ(GetEnumPlayer(), "You were defeated!");
		}
		private void qz() {
			RemoveUnit(GetEnumUnit());
		}
		private void rz() {
			unit u = GetEnumUnit();
			ShowUnit(u, false);
			KillUnit(u);
			RemoveUnit(u);
			u = null;
		}
		private void sz() {
			RemoveItem(GetEnumItem());
		}
		private void tz() {
			int i = 0;
			gg = false;
			Fe = true;
			Ym(false);
			Uy();
			FogEnable(false);
			PauseTimer(a9);
			PauseTimer(B9);
			PauseTimer(jf);
			PauseTimer(L9);
			dj(false);
			DestroyFogModifier(Ag);
			DestroyFogModifier(ag);
			TriggerClearActions(hg);
			DestroyTrigger(hg);
			TriggerClearActions(ig);
			DestroyTrigger(ig);
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "The Score is |cffFF0000West|r: |cffFFCC00"+I2S(Hd[0])+" |cff00FF00East|r:|cffFFCC00 "+I2S(Hd[1])+"|r. Number of wins for overall victory: |cffFFCC00"+I2S(dd)+"|r");
			Zv();
			tm();
			if ((mg>0)) {
				if ((mg==2)) {
					ForForce(ie, function nz);
				} else {
					ForForce(je, function nz);
				}
			}
			TriggerSleepAction(4.);
			CinematicFadeBJ(1, 2, "ReplaceableTextures\\CameraMasks\\Black_mask.blp", 0, 0, 0, 6.);
			TriggerSleepAction(2.);
			U9 = false;
			nh = false;
			while (true) {
				GroupEnumUnitsOfPlayer(q4, Player(i), kg);
				ForGroup(q4, function rz);
				i = i+1;
				if (i>$B) { break; }
			}
			GroupEnumUnitsInRect(q4, C9, kg);
			ForGroup(q4, function qz);
			TriggerSleepAction(3.);
			i = 0;
			while (true) {
				GroupEnumUnitsOfPlayer(q4, Player(i), kg);
				ForGroup(q4, function rz);
				i = i+1;
				if (i>$B) { break; }
			}
			GroupEnumUnitsInRect(q4, C9, kg);
			ForGroup(q4, function qz);
			nh = true;
			Bf[0] = 0;
			Bf[1] = 0;
			EnumItemsInRect(C9, null, function sz);
			if ((mg>0)) {
				TriggerSleepAction(11.);
				if ((mg==2)) {
					ForForce(ie, function oz);
					ForForce(je, function pz);
				} else {
					ForForce(je, function oz);
					ForForce(ie, function pz);
				}
			} else {
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 10., "Preparing for new round...");
				TriggerSleepAction(7.);
				TriggerExecute(zg);
			}
		}
		private bool uz() {
			unit u = GetFilterUnit();
			bool Im = GetPlayerId(GetOwningPlayer(u))<$C && GetUnitAbilityLevel(u,'A02E')<1;
			u = null;
			return Im;
		}
		private void vz() {
			Rk(("RoundsWon"), (GetEnumPlayer()), p7[('e')], I2S((1)), 'g');
		}
		private void wz() {
			Rk(("RoundsLost"), (GetEnumPlayer()), p7[('e')], I2S((1)), 'g');
		}
		private void xz() {
			if ((!gg)) {
				return;
			}
			ForForce(ie, function vz);
			ForForce(je, function wz);
			Hd[1] = Hd[1]+1;
			Yr(5, 2, I2S(Hd[1]));
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cff00FF00Eastern Forces|r have won the round!");
			if ((Hd[1]>=dd)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffFFFF00Congratulations! |cff00FF00Eastern Forces|r|cffFFFF00 have won the match! Game ends in one minute.|r");
				mg = 1;
				T9 = true;
			}
			tz();
		}
		private void yz() {
			if ((!gg)) {
				return;
			}
			ForForce(je, function vz);
			ForForce(ie, function wz);
			Hd[0] = Hd[0]+1;
			Yr(5, 1, I2S(Hd[0]));
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffFF0000Western Forces|r have won the round!");
			if ((Hd[0]>=dd)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffFFFF00Congratulations! |cffFF0000Western Forces|r|cffFFFF00 have won the match! Game ends in one minute.|r");
				mg = 2;
				T9 = true;
			}
			tz();
		}
		private void zz() {
			if ((!gg)) {
				return;
			}
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffFFAC00All players have voted for a draw, round will restart!|r");
			tz();
		}
		private void Az() {
			kg = Filter(function uz);
			jg = CreateTrigger();
			TriggerAddAction(jg, function zz);
		}
		private void az() {
			pg = -1;
			TimerDialogDisplay(og, false);
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "Time is up and not all players have agreed. Extra rounds declined!");
		}
		private void Bz(int dk) {
			if ((pg==-1)) {
				return;
			}
			if ((rg[dk])) {
				rg[dk] = false;
				qg = qg-1;
				if ((qg>0)) {
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" has agreed, "+I2S(qg)+" more votes needed");
				} else {
					dd = dd+(pg);
					PauseTimer(ng);
					TimerDialogDisplay(og, false);
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "All players have agreed, number of rounds is increased by "+I2S(pg));
					c9 = true;
					Xy(true);
					pg = -1;
				}
			} else {
				DisplayTextToPlayer(Player(dk), .0, .0, "You have already agreed!");
			}
		}
		private void bz(int ws) {
			int i = 0;
			if ((ws<1 || ws>3)) {
				DisplayTextToPlayer(Player(0), .0, .0, "Invalid number of rounds, must be between 1 and 3");
				return;
			}
			pg = ws;
			qg = 0;
			while (true) {
				if ((GetPlayerController(Player(i))==MAP_CONTROL_USER && GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING  && (IsPlayerInForce(Player(i),ie) || IsPlayerInForce(Player(i),je)))) {
					rg[i] = true;
					qg = qg+1;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			TimerStart(ng, 30., false, function az);
			TimerDialogDisplay(og, true);
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 30., "|cffC6FF00"+I2S(ws)+" Extra Rounds|r vote has been started. You have 30 seconds to agree to it by typing |cffFFFF00-agree|r. If all players agree, the number of wins for overall victory will be increased by "+I2S(ws));
		}
		private void Cz() {
			TimerDialogDisplay(og, false);
			TimerDialogSetTitle(og, "Voting XR");
		}
		private string cz() {
			string Im;
			if ((tg!=null)) {
				return tg;
			}
			if ((Z9==1)) {
				Im = " -r";
			} else if ((Z9==2)) {
				Im = " -m";
			} else if ((Z9==3)) {
				Im = " -d";
			} else {
				Im = " -p";
			}
			if ((jd)) {
				Im = Im+("p");
			} else {
				Im = Im+("r");
			}
			Im = Im+(I2S(dd));
			if ((ed==1)) {
				Im = Im+("-slt");
			} else if ((ed==2)) {
				Im = Im+("-slb");
			}
			if ((gd>0)) {
				Im = Im+"-fow"+I2S(gd);
			} else if ((gd==0)) {
				Im = Im+("-nfow");
			}
			if ((hd!=$A)) {
				Im = Im+"-it"+I2S(hd);
			}
			if ((kd)) {
				Im = Im+("-du");
			}
			if ((zd)) {
				Im = Im+("-ai");
			}
			if ((Fd>0)) {
				Im = Im+("-fp");
			}
			if ((md)) {
				Im = Im+("-na");
			}
			if ((nd)) {
				Im = Im+("-ntb");
			}
			if ((od)) {
				Im = Im+("-nb");
			}
			if ((!pd)) {
				Im = Im+("-ns");
			}
			if ((!qd)) {
				Im = Im+("-ni");
			}
			if ((!rd)) {
				Im = Im+("-la");
			}
			if ((!sd)) {
				Im = Im+("-nrs");
			}
			if ((td)) {
				Im = Im+("-ur");
			}
			if ((!sd)) {
				Im = Im+("-ca");
			}
			if ((vd)) {
				Im = Im+("-dom");
			}
			if ((wd)) {
				Im = Im+("-sd");
			}
			if ((xd)) {
				Im = Im+("-nafk");
			}
			if ((!yd)) {
				Im = Im+("-ndb");
			}
			if ((Ad==1)) {
				Im = Im+("-nt");
			} else if ((Ad==2)) {
				Im = Im+("-ht");
			}
			if ((ad>-1)) {
				Im = Im+"-ll"+I2S(ad);
			}
			if ((Bd>0)) {
				Im = Im+"-ban"+I2S(Bd);
			}
			if ((Bd<0)) {
				Im = Im+"-rban"+I2S(-Bd);
			}
			if ((bd>0)) {
				Im = Im+"-mp"+I2S(bd);
			}
			if ((Dd>0)) {
				Im = Im+"-emp"+I2S(Dd);
			}
			if ((Cd==$A)) {
				Im = Im+(Im+"-cc");
			} else if ((Cd==1)) {
				Im = Im+("-co");
			}
			if ((cd!=0)) {
				if ((cd>0)) {
					Im = Im+"-glw"+I2S(cd);
				} else {
					Im = Im+"-gld"+I2S(IAbsBJ(cd));
				}
			}
			if ((!ud)) {
				Im = Im+("-ca");
			}
			if ((W9!=$FA)) {
				Im = Im+("-srg"+I2S(W9));
			}
			if ((X9!='}')) {
				Im = Im+("-srl"+I2S(X9));
			}
			if ((Y9!=1)) {
				Im = Im+("-sru"+I2S(Y9));
			}
			if ((Ed>0)) {
				Im = Im+("-nfr"+I2S(Ed));
			}
			Im = Im+"-bal"+I2S(fd);
			tg = Im;
			return Im;
		}
		private void Dz(string s) {
			if ((StringLength(s)>0 && SubString(s,0,1)==" ")) {
				s = SubString(s,1,StringLength(s));
			}
			s = StringCase(s,false);
			if ((SubString(s,0,3)=="ice")) {
				xj(0);
			} else if ((SubString(s,0,4)=="lava")) {
				xj(1);
			} else if ((SubString(s,0,4)=="ice2")) {
				xj(2);
			} else {
				DisplayTextToPlayer(Player(0), .0, .0, "Sorry, but landscape [|c00ff0000"+s+"|r] not found.");
			}
		}
		private void Ez() {
			ug = !ug;
			if ((ug)) {
				PauseTimer(Xf);
			} else {
				ResumeTimer(Xf);
				if ((sg)) {
					jz();
				}
			}
		}
		private void Console_SpecControlSendsResume() {
			if ((!ug)) {
				ResumeTimer(Xf);
				if ((sg)) {
					jz();
				}
			}
		}
		private void Fz(player Gz, int Pk) {
			int i = 0;
			player p;
			if ((Pk>6)) {
				Pk = 6;
			}
			if ((CountPlayersInForceBJ(ie)+CountPlayersInForceBJ(je)+CountPlayersInForceBJ(ke)<Pk*2)) {
				DisplayTextToPlayer(Gz, .0, .0, "Sorry, but command [|c00ff0000Fill|r] coudn't be executed. There are small count of quota players.");
				return;
			}
			while (true) {
				if (CountPlayersInForceBJ(ie)>=Pk) { break; }
				p = zn(true);
				ForceRemovePlayer(ke, p);
				ForceAddPlayer(ie, p);
				CreateFogModifierRectBJ(true, p, FOG_OF_WAR_VISIBLE, Q9);
				Qd[GetPlayerId(p)] = dn(true);
				ne[GetPlayerId(p)] = CreateForce();
				It(GetPlayerId(p));
				i = i+1;
			}
			while (true) {
				if (CountPlayersInForceBJ(je)>=Pk) { break; }
				p = zn(false);
				ForceRemovePlayer(ke, p);
				ForceAddPlayer(je, p);
				CreateFogModifierRectBJ(true, p, FOG_OF_WAR_VISIBLE, Q9);
				Qd[GetPlayerId(p)] = dn(false);
				ne[GetPlayerId(p)] = CreateForce();
				It(GetPlayerId(p));
				i = i+1;
			}
			Bn();
			DisplayTextToPlayer(Gz, .0, .0, "There are added "+I2S(i)+" players.");
		}
		private bool Hz(string s) {
			int i = S2I(s);
			if ((i<=0)) {
				return false;
			}
			dd = IMinBJ(i,6);
			return true;
		}
		private bool Iz(string s) {
			if ((s=="g")) {
				jd = true;
				return true;
			} else if ((s=="r")) {
				jd = false;
				return true;
			}
			return false;
		}
		private void lz(int t) {
			if ((t<0)) {
				return;
			}
			if ((t==0)) {
				if ((gd==-1)) {
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cff808080Deprecated activation of Permanent Fog of War has been encountered. Ignored.|r");
					return;
				}
				gd = -1;
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "Permanent |cffC6FF00Fog of War|r has been chosen");
				return;
			}
			gd = t;
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Fog of War|r time has been set to |cffFFFF00"+I2S(t)+"|r seconds.");
		}
		private void Jz() {
			gd = 0;
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Fog of War|r has been removed. All map will be visible.");
		}
		private void Kz(int Lz) {
			if ((Lz==0)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, I2S(GetRandomInt(0, 99)));
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, I2S(GetRandomInt(0, Lz)));
			}
		}
		private void Mz(string YC) {
			int zC;
			string ZC;
			float i = $C0;
			float Nz;
			if (ed>0 ) {
				return;
			}
			if (YC=="u" || YC=="t" ) {
				zC = -1;
			} else if (YC=="d" || YC=="b" ) {
				zC = 1;
			} else {
				zC = (GetRandomInt(0,1)*2)-1;
			}
			if (zC==1 ) {
				ed = 2;
				ZC = "bottom";
			} else {
				ed = 1;
				ZC = "top";
			}
			Nz = GetRectMaxY(bj_mapInitialPlayableArea);
			while (true) {
				if (i>Nz) { break; }
				CreateDestructable('YTfc', $5C0, i*zC, 270, 1, 0);
				CreateDestructable('YTfc', -$5C0, i*zC, 270, 1, 0);
				i = i+$80;
			}
			i = -$5F0;
			while (true) {
				if (i>$5F0) { break; }
				SetTerrainPathable(i, 272*zC, PATHING_TYPE_WALKABILITY, false);
				SetTerrainPathable(i, 272*zC, PATHING_TYPE_FLYABILITY, false);
				i = i+32;
			}
			CreateDestructable('B004', $5C0, 640*zC, 270, 1.1, 0);
			CreateDestructable('B004', -$5C0, 640*zC, 270, 1.1, 0);
			CreateDestructable('B004', $5C0, 960*zC, 270, 1.1, 0);
			CreateDestructable('B004', -$5C0, 960*zC, 270, 1.1, 0);
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Single Lane|r has been chosen. Units are only able to walk/fly over the |cffFFFF00"+ZC+" lane|r.");
		}
		private void Oz(int p, int Pk) {
			if ((Pk==0)) {
				if ((Xm(p))) {
					DisplayTextToPlayer(Player(p), .0, .0, "Your |cffC6FF00Personal Timer|r has been disabled");
				} else {
					DisplayTextToPlayer(Player(p), .0, .0, "Your |cffC6FF00Personal Timer|r is already disabled!");
				}
				return;
			}
			if ((Pk<4)) {
				DisplayTextToPlayer(Player(p), .0, .0, "The value for Personal Timer must be more that |c00ff00003|r!");
				return;
			}
			Wm(p, Pk);
			DisplayTextToPlayer(Player(p), .0, .0, "Your |cffC6FF00Personal Timer|r has been started");
		}
		private void Pz(int tk) {
			Gd[tk] = !Gd[tk];
			if ((Gd[tk])) {
				DisplayTextToPlayer(Player(tk), .0, .0, "|cffC6FF00Auto Training|r has been activated");
			} else {
				DisplayTextToPlayer(Player(tk), .0, .0, "|cffC6FF00Auto Training|r has been deactivated");
			}
		}
		private void Qz(string Rz, int Pk) {
			if ((Rz=="g" || Rz=="G")) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Start Resources|r has been changed. The amount of start |c00ffdc00Gold|r is |cffFFFF00"+I2S(Pk)+"|r.");
				W9 = Pk;
			} else if ((Rz=="l" || Rz=="L")) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Start Resources|r has been changed. The amount of start |c0000c850Lumber|r is |cffFFFF00"+I2S(Pk)+"|r.");
				X9 = Pk;
			} else if ((Rz=="u" || Rz=="U")) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Start Resources|r has been changed. The amount of start |c008000ffLegendaries limit|r is |cffFFFF00"+I2S(Pk)+"|r.");
				Y9 = Pk;
			} else {
				DisplayTextToPlayer(Player(0), .0, .0, "Sorry, but resorce [|c00ff0000"+Rz+"|r] couldn't be identified.");
			}
		}
		private void Sz(string s, int tk) {
			player p;
			if ((StringLength(s)<=2)) {
				return;
			}
			if ((S9 && tk==0 && SubString(s,1,3)=="na")) {
				is(false);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ai")) {
				hs(true);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="co")) {
				ks();
			} else if ((S9 && tk==0 && SubString(s,1,3)=="cc")) {
				ms();
			} else if ((S9 && tk==0 && SubString(s,1,3)=="du")) {
				ns(true);
			} else if ((S9 && tk==0 && SubString(s,1,4)=="ntb")) {
				ps(false);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="nb")) {
				qs(false);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ns")) {
				rs(false);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ni")) {
				ss(false);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="la")) {
				ts(false);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="sr" && StringLength(s)>4)) {
				Qz(SubString(s, 3, 4), S2I(SubString(s, 4, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,4)=="nrs")) {
				us(false);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="sl" && ed==0)) {
				Mz(SubString(s, 3, 4));
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ur")) {
				os(true);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="it")) {
				xs(S2I(SubString(s, 3, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,4)=="glw")) {
				Gs(S2I(SubString(s, 4, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,4)=="gld")) {
				Gs(-1*S2I(SubString(s, 4, StringLength(s))));
			} else if (((!S9) && tk==0 && SubString(s,1,3)=="xr")) {
				bz(S2I(SubString(s, 3, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,3)=="mp")) {
				Ds(S2I(SubString(s, 3, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,4)=="emp")) {
				cs(S2I(SubString(s, 4, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ll")) {
				vs(S2I(SubString(s, 3, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ht")) {
				ys(2);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="nt")) {
				ys(1);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ca")) {
				As(false);
			} else if ((S9 && tk==0 && SubString(s,1,3)=="sd")) {
				Es(true);
			} else if ((S9 && tk==0 && SubString(s,1,4)=="dom")) {
				as(true);
			} else if ((S9 && tk==0 && SubString(s,1,4)=="fow")) {
				lz(S2I(SubString(s, 4, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,5)=="nfow")) {
				Jz();
			} else if ((S9 && tk==0 && SubString(s,1,5)=="rban")) {
				bs(S2I(SubString(s, 5, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,4)=="ban")) {
				Cs(S2I(SubString(s, 4, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,4)=="bal")) {
				Bs(S2I(SubString(s, 4, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,4)=="nfr")) {
				Hs(S2I(SubString(s, 4, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,4)=="ndb")) {
				Fs(false);
			} else if ((S9 && tk==0 && SubString(s,1,4)=="env")) {
				Dz(SubString(s, 4, StringLength(s)));
			} else if ((S9 && tk==0 && SubString(s,1,5)=="fill")) {
				Fz(Player(tk), S2I(SubString(s, 5, StringLength(s))));
			} else if ((S9 && tk==0 && SubString(s,1,5)=="nafk")) {
				js(true);
			} else if ((S9 && tk==0 && SubString(s,1,6)=="pause")) {
				Ez();
			} else if ((S9 && tk==0 && SubString(s,1,5)=="skip")) {
				if ((ug)) {
					sg = true;
				} else {
					jz();
				}
			} else if ((S9 && tk==0 && SubString(s,1,2)=="r" && Iz(SubString(s,2,3)) && Hz(SubString(s,3,4)))) {
				Z9 = 1;
				V9 = "gz";
				Xy(true);
			} else if ((S9 && tk==0 && SubString(s,1,2)=="p" && Iz(SubString(s,2,3)) && Hz(SubString(s,3,4)))) {
				Z9 = 0;
				V9 = "fz";
				Xy(true);
			} else if ((S9 && tk==0 && SubString(s,1,2)=="m" && Iz(SubString(s,2,3)) && Hz(SubString(s,3,4)))) {
				Z9 = 2;
				V9 = "Tz";
				Xy(true);
			} else if ((S9 && tk==0 && SubString(s,1,2)=="d" && Iz(SubString(s,2,3)) && Hz(SubString(s,3,4)))) {
				Z9 = 3;
				V9 = "Uz";
				Xy(true);
			} else if ((SubString(s,1,6)=="stats" && !S9)) {
				Sv(Player(tk));
			} else if ((SubString(s,1,4)=="afk"  && (!S9) && !xd)) {
				Kt(tk);
			} else if ((SubString(s,1,3)=="at")) {
				Pz(tk);
			} else if ((SubString(s,1,5)=="mode"  && (!S9))) {
				DisplayTimedTextToPlayer(Player(tk), .0, .0, 10., "|cffFFFF00Game-config-string|r:");
				DisplayTimedTextToPlayer(Player(tk), .0, .0, 10., cz());
			} else if ((SubString(s,1,7)=="income" && !S9)) {
				Rv(Player(tk));
			} else if ((SubString(s,1,6)=="armor")) {
				p = Player(tk);
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFFF00Armor table:");
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Chaos damage:    |cffFFFF00neutral against all|r");
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Normal damage: |cff00FF00good against:|r medium |cffFF0000bad against:|r light");
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Pierce damage:   |cff00FF00good against:|r light        |cffFF0000bad against:|r heavy");
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Magic damage:   |cff00FF00good against:|r heavy      |cffFF0000bad against:|r medium");
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Siege damage:     |cff00FF00good against:|r fortified |cffFF0000bad against:|r all others");
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Note:|r All attack types are |cffFF0000bad|r against divine besides chaos!");
			} else if ((tk==0 && SubString(s,1,5)=="roll")) {
				Kz(S2I(SubString(s, 5, StringLength(s))));
			} else if ((SubString(s,1,5)=="draw")) {
				Zj(tk);
			} else if ((SubString(s,1,3)=="mt")) {
				Oz(tk, S2I(SubString(s, 3, StringLength(s))));
			} else if ((SubString(s,1,6)=="agree")) {
				Bz(tk);
			} else {
				DisplayTextToPlayer(Player(tk), .0, .0, "Sorry, but command [|c00ff0000"+SubString(s, 1, StringLength(s))+"|r] coudn't be executed. You are not allowed to perform it in current time or you have mistake in syntax.");
			}
		}
		private bool Vz() {
			return SubString(GetEventPlayerChatString(),0,1)=="-";
		}
		private void Wz() {
			string Xz = GetEventPlayerChatString();
			string s = StringCase(Xz,false);
			int Yz = 0;
			int Zz = 0;
			int dA = StringLength(s);
			int i = 0;
			int id = GetPlayerId(GetTriggerPlayer());
			string ch;
			Pj("CE: "+Xz);
			Rj();
			while (true) {
				ch = SubString(s,i,i+1);
				if (ch=="-" ) {
					if (Yz!=i ) {
						if (Zz>0 ) {
							Sz(SubString(s, Yz, Zz)+SubString(Xz, Zz, i), id);
						} else {
							Sz(SubString(s, Yz, i), id);
						}
					}
					Yz = i;
					Zz = 0;
				} else if (Zz==0 && ch==" " ) {
					Zz = i;
				}
				i = i+1;
				if (i>=dA) { break; }
			}
			if (Zz>0 ) {
				Sz(SubString(s, Yz, Zz)+SubString(Xz, Zz, i), id);
			} else {
				Sz(SubString(s, Yz, i), id);
			}
		}
		private void eA() {
			trigger t = CreateTrigger();
			DestroyTimer(GetExpiredTimer());
			TriggerRegisterPlayerChatEvent(t, Player(0), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player(1), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player(2), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player(3), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player(4), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player(5), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player(6), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player(7), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player(8), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player(9), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player($A), "-", false);
			TriggerRegisterPlayerChatEvent(t, Player($B), "-", false);
			TriggerAddCondition(t, Condition(function Vz));
			TriggerAddAction(t, function Wz);
			t = null;
		}
		private void fA() {
			TimerStart(CreateTimer(), .2, false, function eA);
		}
		private void gA() {
			FogEnable(false);
			U9 = true;
		}
		private void hA() {
			int i;
			unit u;
			player pl;
			player pr;
			bool iA = false;
			K9 = K9+1;
			Pj("RE: "+I2S(K9));
			Rj();
			FogEnable(true);
			pl = ForcePickRandomPlayer(ie);
			pr = ForcePickRandomPlayer(je);
			if ((K9==1)) {
				Lt();
			}
			if ((pl==null)) {
				pl = Player(0);
			}
			if ((pr==null)) {
				pr = Player(6);
				if ((K9==1)) {
					ForceRemovePlayer(ke, pr);
					ForceAddPlayer(je, pr);
					CreateFogModifierRectBJ(true, pr, FOG_OF_WAR_VISIBLE, Q9);
					Qd[6] = dn(false);
					ne[6] = CreateForce();
					It(6);
				}
			}
			Ny();
			Wo();
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 9.5, "Get ready for round |cffFFCC00"+I2S(K9)+"|r!");
			CinematicFadeBJ(0, 4., "ReplaceableTextures\\CameraMasks\\Black_mask.blp", 0, 0, 0, 6.);
			Ag = CreateFogModifierRectBJ(true,ForcePickRandomPlayer(ie),FOG_OF_WAR_VISIBLE,cg);
			ag = CreateFogModifierRectBJ(true,ForcePickRandomPlayer(je),FOG_OF_WAR_VISIBLE,Dg);
			hg = CreateTrigger();
			ig = CreateTrigger();
			oe[0] = CreateUnitAtLoc(pl,'hcas',Id[1],270.);
			SetUnitX(oe[0], GetLocationX(Id[1]));
			SetUnitY(oe[0], GetLocationY(Id[1]));
			SetUnitColor(oe[0], PLAYER_COLOR_RED);
			if ((!qd)) {
				UnitRemoveAbility(oe[0], 'Aall');
				UnitRemoveAbility(oe[0], 'Apit');
			}
			TriggerRegisterDeathEvent(hg, oe[0]);
			oe[1] = CreateUnitAtLoc(pr,'hcas',Id[0],270.);
			SetUnitX(oe[1], GetLocationX(Id[0]));
			SetUnitY(oe[1], GetLocationY(Id[0]));
			SetUnitColor(oe[1], PLAYER_COLOR_GREEN);
			if ((!qd)) {
				UnitRemoveAbility(oe[1], 'Aall');
				UnitRemoveAbility(oe[1], 'Apit');
			}
			TriggerRegisterDeathEvent(ig, oe[1]);
			TriggerAddAction(hg, function xz);
			TriggerAddAction(ig, function yz);
			if ((vd)) {
				Dn();
			}
			TriggerSleepAction(4.);
			mn();
			vm();
			Hy();
			UnitShareVision(oe[0], pr, true);
			UnitShareVision(oe[1], pl, true);
			TriggerSleepAction(1.);
			UnitShareVision(oe[0], pr, false);
			UnitShareVision(oe[1], pl, false);
			Sy();
			if ((!jd || K9==1)) {
				if ((!xd)) {
					Wy();
				}
				Lm();
				if ((Bd!=0)) {
					if ((Bd>0)) {
						ExecuteFunc("jA");
					} else {
						ExecuteFunc("kA");
					}
					while (true) {
						TriggerSleepAction(1.);
						if (wg) { break; }
					}
					wg = false;
				}
				i = 0;
				while (true) {
					Pd[i] = 0;
					i = i+1;
					if (i>$B) { break; }
				}
				Km();
				ExecuteFunc(V9);
				while (true) {
					TriggerSleepAction(1.);
					if (wg) { break; }
				}
				wg = false;
				DisableTrigger(J7);
			}
			Md[0] = 0;
			Md[1] = 0;
			Nd[0] = 0;
			Nd[1] = 0;
			i = 0;
			while (true) {
				if ((Pd[i]!=0)) {
					if ((Pd[i]=='h00C')) {
						iA = true;
					}
					u = CreateUnitAtLoc(Player(i),Pd[i],Qd[i],180.*me[i]);
					if ((!sd)) {
						UnitRemoveAbility(u, 'A005');
						UnitRemoveAbility(u, 'A06E');
					} else {
						Md[me[i]] = Md[me[i]]+1;
						Zr(H9[i], me[i]*6+1, "V");
					}
					PanCameraToTimedLocForPlayer(Player(i), Qd[i], .01);
					SetPlayerState(Player(i), PLAYER_STATE_RESOURCE_GOLD, W9);
					SetPlayerState(Player(i), PLAYER_STATE_RESOURCE_LUMBER, X9);
					if ((rd)) {
						SetPlayerState(Player(i), PLAYER_STATE_RESOURCE_FOOD_CAP, Y9);
					} else {
						SetPlayerState(Player(i), PLAYER_STATE_RESOURCE_FOOD_CAP, 0);
					}
					if ((E9[i]!=null)) {
						UnitAddAbility(u, 'A0A5');
					}
					Js(i);
				} else {
					ls(i);
				}
				i = i+1;
				if (i>$B) { break; }
			}
			Yr(1, 1, I2S(Md[0]));
			Yr(1, 2, I2S(Md[1]));
			TimerStart(jf, hd, true, function Qv);
			fj();
			if ((gd!=-1)) {
				TimerStart(vg, gd, false, function gA);
			}
			M9 = 0;
			N9 = 0;
			TimerStart(L9, 1., true, function es);
			Nr();
			TimerStart(B9, 4., true, function Mr);
			nk();
			Xj();
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "Round |cffFFCC00"+I2S(K9)+"|r started! gl & hf!");
			PlaySoundBJ(Gg);
			Mt();
			Um();
			gg = true;
			u = null;
			dp(iA);
			Ym(true);
			Vy();
			Zr(I9+1, 0, "|cffFFCC00Modes:|r"+cz());
		}
		private void mA() {
			xg = nn();
			yg = nn();
			Om(xg, yg);
		}
		private void nA() {
			li(xg);
			li(yg);
			wg = true;
		}
		private void oA(int id, bool pA) {
			if ((kd)) {
				if ((td)) {
					if ((pA)) {
						on(yg, id);
					} else {
						on(xg, id);
					}
				}
			} else {
				if ((td)) {
					on(xg, id);
					on(yg, id);
				} else {
					if ((pA)) {
						on(xg, id);
					} else {
						on(yg, id);
					}
				}
			}
		}
		private void qA() {
			TriggerAddAction(zg, function hA);
		}
		private void jA() {
			timer rA;
			timerdialog sA;
			int ct;
			int tA;
			player p;
			int uA;
			int dk;
			mA();
			rA = CreateTimer();
			sA = CreateTimerDialog(rA);
			TimerDialogSetTitle(sA, "Time to ban:");
			TimerDialogDisplay(sA, true);
			ct = GetRandomInt(0,1);
			tA = Bd*2;
			while (true) {
				if ((ct==0)) {
					p = vn(ie);
					ct = 1;
				} else {
					p = vn(je);
					ct = 0;
				}
				dk = GetPlayerId(p);
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+", your turn to ban race now...");
				TimerStart(rA, 15., false, null);
				uA = Fm(CreateUnit(p,'h09W',GetLocationX(Qd[dk]),GetLocationY(Qd[dk]),270.),15.);
				if ((uA==-1)) {
					uA = pn(xg);
				}
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" has banned |cffFFFF00"+zm(uA));
				on(xg, uA);
				Bm(uA, false);
				tA = tA-1;
				if (tA<=0) { break; }
			}
			DestroyTimerDialog(sA);
			sA = null;
			DestroyTimer(rA);
			rA = null;
			nA();
		}
		private void vA(int Gz) {
			oA(Pd[Gz], IsPlayerInForce(Player(Gz), ie));
			if ((kd)) {
				if ((td)) {
					Cm(Pd[Gz], false, ModuloInteger(me[Gz]+1, 2));
				}
			} else {
				if ((td)) {
					Bm(Pd[Gz], false);
				} else {
					Cm(Pd[Gz], false, me[Gz]);
				}
			}
		}
		private void wA() {
			trigger t = GetTriggeringTrigger();
			timer rA;
			timerdialog sA;
			int xA = 0;
			int yA = 0;
			int ct;
			player zA;
			int i = 0;
			int dk;
			mA();
			rA = CreateTimer();
			sA = CreateTimerDialog(rA);
			TimerDialogSetTitle(sA, "Time to select:");
			TimerDialogDisplay(sA, true);
			if ((Bg<0)) {
				Bg = GetRandomInt(0,1);
			}
			Bg = ModuloInteger(Bg+1,2);
			ct = 1+2*Bg;
			while (true) {
				Pd[i] = 0;
				i = i+1;
				if (i>$B) { break; }
			}
			while (true) {
				zA = null;
				if ((ct<2)) {
					while (true) {
						if ((IsPlayerInForce(Player(xA),ie))) {
							zA = Player(xA);
						}
						xA = xA+1;
						if (zA!=null || xA>$B) { break; }
					}
				} else {
					while (true) {
						if ((IsPlayerInForce(Player(yA),je))) {
							zA = Player(yA);
						}
						yA = yA+1;
						if (zA!=null || yA>$B) { break; }
					}
				}
				ct = ct+1;
				if ((ct>=4)) {
					ct = 0;
				}
				if (zA==null && xA>$B && yA>$B) { break; }
				if ((zA!=null)) {
					dk = GetPlayerId(zA);
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" is selecting now...");
					TimerStart(rA, 15., false, null);
					Pd[dk] = Fm(CreateUnit(zA,'h033',GetLocationX(Qd[dk]),GetLocationY(Qd[dk]),270.),15.);
					if ((Pd[dk]==-1)) {
						DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" skipped selection.");
					} else {
						DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" controls |cffFFFF00"+zm(Pd[dk])+"|r.");
						vA(dk);
					}
				}
			}
			i = 0;
			while (true) {
				if ((Pd[i]==-1)) {
					zA = Player(i);
					if ((IsPlayerInForce(zA,ie))) {
						Pd[i] = pn(xg);
						vA(i);
					} else if ((IsPlayerInForce(zA,je))) {
						Pd[i] = pn(yg);
						vA(i);
					}
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[i]+" controls |cffFFFF00"+zm(Pd[i])+"|r.");
				}
				i = i+1;
				if (i>$B) { break; }
			}
			DestroyTimerDialog(sA);
			sA = null;
			DestroyTimer(rA);
			rA = null;
			nA();
			TriggerClearActions(t);
			DestroyTrigger(t);
			t = null;
		}
		private void Uz() {
			trigger t = CreateTrigger();
			TriggerAddAction(t, function wA);
			TriggerExecute(t);
			t = null;
		}
		private void Tz() {
			int i = 0;
			int j = 0;
			JassArray<int> AA = new JassArray<int>();
			force f1;
			force f2;
			mA();
			if ((CountPlayersInForceBJ(ie)>=CountPlayersInForceBJ(je))) {
				f1 = ie;
				f2 = je;
			} else {
				f1 = je;
				f2 = ie;
			}
			while (true) {
				if ((IsPlayerInForce(Player(i),f1))) {
					Pd[i] = pn(xg);
					if ((!kd)) {
						on(xg, Pd[i]);
					}
					AA[j] = Pd[i];
					j = j+1;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			i = 0;
			j = 0;
			while (true) {
				if ((IsPlayerInForce(Player(i),f2))) {
					Pd[i] = AA[j];
					j = j+1;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			f1 = null;
			f2 = null;
			nA();
		}
		private void aA(int Gz) {
			oA(D7[Gz], IsPlayerInForce(Player(Gz), ie));
			if ((kd)) {
				if ((td)) {
					Cm(D7[Gz], false, ModuloInteger(me[Gz]+1, 2));
				}
			} else {
				if ((td)) {
					Bm(D7[Gz], false);
				} else {
					Cm(D7[Gz], false, me[Gz]);
				}
			}
		}
		private bool BA() {
			bg = bg-1;
			if ((D7[c7]==-1)) {
				return false;
			}
			aA(c7);
			return false;
		}
		private void bA() {
			trigger t = GetTriggeringTrigger();
			timer rA;
			timerdialog sA;
			JassArray<unit> CA = new JassArray<unit>();
			int i = 0;
			player p;
			int uA;
			int dk;
			mA();
			rA = CreateTimer();
			sA = CreateTimerDialog(rA);
			TimerDialogSetTitle(sA, "Time to select:");
			TimerDialogDisplay(sA, true);
			Cg = CreateTrigger();
			TriggerAddCondition(Cg, Condition(function BA));
			C7 = Cg;
			bg = 0;
			while (true) {
				p = Player(i);
				if ((IsPlayerInForce(p,ie) || IsPlayerInForce(p,je))) {
					CA[i] = Em(CreateUnit(p,'h033',GetLocationX(Qd[i]),GetLocationY(Qd[i]),270.));
					bg = bg+1;
				}
				i = i+1;
				if (i>$B) { break; }
			}
			TimerStart(rA, 15., false, null);
			while (true) {
				TriggerSleepAction(.33);
				if (TimerGetRemaining(rA)<.33 || bg<=0) { break; }
			}
			TriggerClearConditions(Cg);
			DestroyTrigger(Cg);
			i = 0;
			while (true) {
				p = Player(i);
				if ((IsPlayerInForce(p,ie) || IsPlayerInForce(p,je))) {
					if ((D7[i]==-1 || D7[i]==0)) {
						if ((IsPlayerInForce(p,ie))) {
							D7[i] = pn(xg);
						} else if ((IsPlayerInForce(p,je))) {
							D7[i] = pn(yg);
						}
						aA(i);
					}
					Pd[i] = D7[i];
				} else {
					Pd[i] = 0;
				}
				RemoveUnit(CA[i]);
				CA[i] = null;
				i = i+1;
				if (i>$B) { break; }
			}
			DestroyTimerDialog(sA);
			sA = null;
			DestroyTimer(rA);
			rA = null;
			nA();
			TriggerClearActions(t);
			DestroyTrigger(t);
			t = null;
		}
		private void fz() {
			trigger t = CreateTrigger();
			TriggerAddAction(t, function bA);
			TriggerExecute(t);
			t = null;
		}
		private void kA() {
			int tA = IAbsBJ(Bd);
			string s = "";
			int uA;
			mA();
			while (true) {
				uA = pn(xg);
				on(xg, uA);
				Bm(uA, false);
				if ((s=="")) {
					s = zm(uA);
				} else {
					s = s+", "+zm(uA);
				}
				tA = tA-1;
				if (tA<=0) { break; }
			}
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, s+" have banned by Random.");
			nA();
		}
		private void gz() {
			int i = 0;
			mA();
			while (true) {
				if ((IsPlayerInForce(Player(i),ie))) {
					Pd[i] = pn(xg);
					oA(Pd[i], true);
				} else if ((IsPlayerInForce(Player(i),je))) {
					Pd[i] = pn(yg);
					oA(Pd[i], false);
				}
				i = i+1;
				if (i>$B) { break; }
			}
			nA();
		}
		private void cA(unit u, unit j) {
			if ((GetUnitAbilityLevel(j,'A0DZ')>0)) {
				Wr(u, j);
			}
		}
		private void DA() {
			unit u = GetSummonedUnit();
			int aj = GetUnitTypeId(u);
			if ((aj=='h03C')) {
				SetUnitState(u, UNIT_STATE_MANA, 30.);
			} else if ((aj=='h03A')) {
				TriggerSleepAction(.7);
				IssueImmediateOrderById(u, $D0057);
				TriggerSleepAction(.1);
			} else if ((GetUnitAbilityLevel(u,'A07M')>0)) {
				Mo(u);
				GroupAddUnit(z9, u);
			} else if ((aj=='h030')) {
				UnitRemoveType(u, UNIT_TYPE_SUMMONED);
				if ((GetUnitTypeId(GetSummoningUnit())=='h030')) {
					u = ReplaceUnitBJ(u,'h02Z',2);
				} else {
					cA(u, GetSummoningUnit());
				}
			}
			Qo(u);
			u = null;
		}
		private void FA(int dk) {
			unit u;
			GroupEnumUnitsOfPlayer(q4, Player(dk), b9);
			u = FirstOfGroup(q4);
			if ((u==null)) {
				return;
			}
			if ((GetUnitAbilityLevel(u,'A005')>0)) {
				Md[me[dk]] = Md[me[dk]]-1;
				if ((Md[me[dk]]==0)) {
					Yr(1, me[dk]+1, "|cffFF00000|r");
				} else {
					Yr(1, me[dk]+1, I2S(Md[me[dk]]));
				}
			}
			RemoveUnit(u);
			u = null;
		}
		private void GA() {
			unit u = GetEnumUnit();
			int HA;
			if ((IsUnitType(u,UNIT_TYPE_STRUCTURE))) {
				SetUnitOwner(u, ForcePickRandomPlayer(mh), true);
				HA = (x4[GetUnitPointValue((u))]);
				if ((HA>0)) {
					IssueImmediateOrderById(u, HA);
					IssueImmediateOrderById(u, HA);
				}
				HA = GetPlayerId(GetOwningPlayer(u));
				Nv(HA, u);
				if ((!v4[GetUnitPointValue(u)])) {
					Ud[HA] = Ud[HA]+1;
				}
			} else {
				SetUnitOwner(u, ForcePickRandomPlayer(mh), true);
				Qo(u);
			}
			u = null;
		}
		private void IA() {
			player p = GetEnumPlayer();
			int dk = GetPlayerId(p);
			int i = CountPlayersInForceBJ(mh);
			int g = GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)/ i;
			int l = GetPlayerState(p,PLAYER_STATE_RESOURCE_LUMBER)/ i;
			string s = "You received |cffFFFF00"+I2S(g)+"|r gold && |cffFFFF00"+I2S(l)+"|r lumber from "+pe[dk];
			ls(dk);
			FA(dk);
			fn(Qd[dk]);
			ForceAddPlayer(ke, p);
			GroupEnumUnitsOfPlayer(q4, p, null);
			ForGroup(q4, function GA);
			i = 0;
			while (true) {
				p = Player(i);
				if ((IsPlayerInForce(p,mh))) {
					AdjustPlayerStateBJ(g, p, PLAYER_STATE_RESOURCE_GOLD);
					AdjustPlayerStateBJ(l, p, PLAYER_STATE_RESOURCE_LUMBER);
					DisplayTextToPlayer(p, .0, .0, s);
				}
				i = i+1;
				if (i>$B) { break; }
			}
		}
		private void lA(int dk) {
			player p = Player(dk);
			ForceRemovePlayer(mh, p);
			wn(mh, ne[dk]);
			ForceAddPlayer(ne[dk], p);
			ForForce(ne[dk], function IA);
			DestroyForce(ne[dk]);
			ne[dk] = null;
		}
		private void JA(int dk) {
			int i = 0;
			player p = Player(dk);
			force KA = ne[dk];
			unit u;
			ForceAddPlayer(KA, p);
			ne[dk] = null;
			while (true) {
				if ((IsPlayerInForce(Player(i),mh) && ne[i]!=null)) {
					p = vn(KA);
					if (p==null) { break; }
					ForceRemovePlayer(KA, p);
					ForceAddPlayer(ne[i], p);
					SetPlayerName(p, l9[i]);
					Ls(GetPlayerId(p));
					GroupEnumUnitsOfPlayer(q4, p, b9);
					u = FirstOfGroup(q4);
					if ((u!=null && GetUnitAbilityLevel(u,'A0A5')<=0)) {
						UnitAddAbility(u, 'A0A5');
					}
				}
				i = i+1;
				if ((i>$B)) {
					i = 0;
				}
			}
			h8 = true;
			Ny();
			u = null;
		}
		private void LA(player p) {
			int dk = GetPlayerId(p);
			if ((T9)) {
				return;
			}
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" |cffCA0000has left the game!|r");
			Zj(dk);
			if ((IsPlayerInForce(p,ie))) {
				Rk(("Loses"), (p), p7[('e')], I2S((1)), 'g');
				dm(p, 'h');
				mh = ie;
				if ((xn()<=1)) {
					mg = 1;
					T9 = true;
					DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 60., "All players of |cffFF0000Western Forces|r left. |cff00FF00Eastern Forces|r have won!");
					TriggerExecute(hg);
					return;
				}
			} else if ((IsPlayerInForce(p,je))) {
				Rk(("Loses"), (p), p7[('e')], I2S((1)), 'g');
				dm(p, 'h');
				mh = je;
				if ((yn()<=1)) {
					mg = 2;
					T9 = true;
					DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 60., "All players of |cff00FF00Eastern Forces|r left. |cffFF0000Western Forces|r have won!");
					TriggerExecute(ig);
					return;
				}
			} else {
				return;
			}
			if ((fd==0)) {
				lA(dk);
			} else if ((fd==1)) {
				JA(dk);
			} else {
				It(dk);
			}
		}
		private void MA() {
			LA(GetTriggerPlayer());
		}
		private void OA(int dk) {
			Q[me[dk]+4] = Q[me[dk]+4]+1;
			Yr(2, me[dk]+1, I2S(Q[me[dk]+4]));
			if ((Q[me[dk]]==dk)) {
				Q[me[dk]+2] = Q[me[dk]+2]+1;
				if ((Q[me[dk]+2]==3)) {
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+"|cffFFFF80 just collected |cffFFFF003|cffFFFF80 coins in a row for the "+Od[me[dk]]+"|cffFFFF00! Very nice!");
				} else if ((Q[me[dk]+2]==5)) {
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+"|cffFFFF80 just collected|cffFFFF00 5|cffFFFF80 coins in a row for the "+Od[me[dk]]+"|cffFFFF00! Impressive!");
				} else if ((Q[me[dk]+2]==$A)) {
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+"|cffFFFF80 just collected|cffFFFF00 10|cffFFFF80 coins in a row for the "+Od[me[dk]]+"|cffFFFF00! Sick!");
				}
			} else {
				Q[me[dk]] = dk;
				Q[me[dk]+2] = 1;
			}
		}
		private void PA() {
			int mk;
			unit u = GetTriggerUnit();
			player p = GetOwningPlayer(u);
			item it = GetManipulatedItem();
			int bj = GetItemTypeId(it);
			if ((bj=='I004')) {
				RemoveItem(it);
				if ((rd)) {
					mk = GetPlayerId(p);
					fe[mk] = fe[mk]+($5DC);
					AdjustPlayerStateBJ(1, p, PLAYER_STATE_RESOURCE_FOOD_CAP);
				} else {
					AdjustPlayerStateBJ($5DC, p, PLAYER_STATE_RESOURCE_GOLD);
					DisplayTextToPlayer(p, .0, .0, "|cffFF0000You can't increase your Legendaries limit! No Legendaries is activated!|r");
				}
			} else if ((bj=='I008')) {
				mk = GetPlayerId(p);
				fe[mk] = fe[mk]+(600);
				u = CreateUnitAtLoc(p,'e008',R9,.0);
				UnitAddAbility(u, 'A06D');
				UnitApplyTimedLife(u, 'BTLF', 29.);
			} else if ((bj=='I007')) {
				mk = GetPlayerId(p);
				fe[mk] = fe[mk]+($578);
				u = CreateUnitAtLoc(p,'e008',R9,.0);
				UnitAddAbility(u, 'A06C');
				UnitApplyTimedLife(u, 'BTLF', 29.);
			} else if ((bj=='I001')) {
				mk = GetPlayerId(p);
				fe[mk] = fe[mk]+($96);
			} else if ((bj=='I005')) {
				mk = GetPlayerId(p);
				fe[mk] = fe[mk]+($96);
			} else if ((bj=='I003')) {
				mk = GetPlayerId(p);
				fe[mk] = fe[mk]+(650);
			} else if ((bj=='I00A')) {
				mk = GetPlayerId(p);
				fe[mk] = fe[mk]+(600);
			} else if ((bj=='I009')) {
				mk = GetPlayerId(p);
				fe[mk] = fe[mk]+(500);
			} else if ((bj=='I006')) {
				mk = GetPlayerId(p);
				fe[mk] = fe[mk]+(550);
			} else if ((bj=='I000')) {
				Yi(p);
				RemoveItem(it);
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Other\\Transmute\\PileofGold.mdl", u, "origin"));
				OA(GetPlayerId(p));
			}
			it = null;
			u = null;
		}
		private bool RA() {
			unit u = GetTriggerUnit();
			player p;
			if ((IsUnitType(u,UNIT_TYPE_PEON))) {
				p = GetOwningPlayer(u);
				PingMinimapForPlayer(p, GetUnitX(u), GetUnitY(u), 1.);
				SetUnitPositionLoc(u, Qd[GetPlayerId(p)]);
				DisplayTextToPlayer(p, .0, .0, "|cffFF0000Your worker may not leave your castle!|r");
			}
			u = null;
			return false;
		}
		private void TA() {
			unit u = GetTriggerUnit();
			player p = GetOwningPlayer(u);
			int HA = GetPlayerId(p);
			int aj = GetUnitPointValue(u);
			Hj(u);
			ee[HA] = ee[HA]+(t4[aj]);
			if ((v4[aj])) {
				if ((w4[aj])) {
					cr(u, t4[aj]*3/ 4);
				} else {
					cr(u, t4[aj]);
				}
			} else {
				Ud[HA] = Ud[HA]+1;
			}
			Lv(HA, u);
			GroupEnumUnitsOfPlayer(q4, p, b9);
			ForGroup(q4, function Rr);
			HA = (x4[GetUnitPointValue((u))]);
			if ((HA>0)) {
				if ((Gd[GetPlayerId(p)])) {
					IssueImmediateOrderById(u, HA);
					IssueImmediateOrderById(u, HA);
				}
			} else {
				aj = GetUnitTypeId(u);
				if ((aj=='h001')) {
					cv(u);
					GroupAddUnit(ff, u);
				} else if ((aj=='h05G')) {
					Fv(u);
				} else if ((aj=='h059')) {
					sv(p);
				} else if ((aj=='h063')) {
					qo(p);
				} else if ((aj=='h02D')) {
					TimerStart(A7, 4., true, function qm);
				} else if ((aj=='h00G')) {
					UnitAddAbility(u, 'A008');
					UnitAddAbility(u, 'A007');
				} else if ((aj=='h061')) {
					oo(u);
				} else if ((aj=='h056' || aj=='h03L' || aj=='h01W' || aj=='h01X' || aj=='h05R')) {
					IssueImmediateOrderById(u, $D027A);
					TriggerSleepAction(1.);
					IssueImmediateOrderById(u, $D027A);
					IssueTargetOrderById(u, $D0279, GroupPickRandomUnit(P9));
					TriggerSleepAction(45.);
					IssueTargetOrderById(u, $D0279, GroupPickRandomUnit(P9));
				} else if ((aj=='h09T')) {
					UnitAddAbility(u, 'A09S');
					UnitAddAbility(u, 'A09P');
					UnitAddAbility(u, 'A09V');
					GroupAddUnit(rf, u);
				} else if ((aj=='h01O')) {
					UnitAddAbility(u, 'A01V');
				} else if ((aj=='h008')) {
					aj = GetPlayerId(p);
					ge[aj] = ge[aj]+1;
				}
			}
			if ((yd)) {
				Pj("BE: "+GetPlayerName(p)+" ->"+GetUnitName(u));
				Rj();
			}
			u = null;
		}
		private void VA() {
			unit u = GetTriggerUnit();
			cj(u);
			u = null;
		}
		private void XA() {
			Hj(GetTriggerUnit());
		}
		private bool ZA() {
			unit u = GetTriggerUnit();
			int dk;
			if (((x4[GetUnitPointValue((u))])>0)) {
				dk = GetPlayerId(GetOwningPlayer(u));
				Td[dk] = Td[dk]+1;
				if ((GetUnitAbilityLevel(u,'A0DS')>0)) {
					Gn(u);
				}
			}
			u = null;
			return false;
		}
		private bool ea() {
			unit u = GetFilterUnit();
			if ((GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER))) {
				if ((GetUnitTypeId(u)==bj_forLoopAIndex)) {
					SetWidgetLife(u, GetWidgetLife(u)+bj_forLoopAIndexEnd);
				} else {
					SetWidgetLife(u, GetWidgetLife(u)+.3*bj_forLoopAIndexEnd);
				}
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Heal\\HealTarget.mdl", u, "overhead"));
			}
			u = null;
			return false;
		}
		private void fa() {
			unit u = GetTriggerUnit();
			unit k = GetKillingUnit();
			int t;
			if ((IsUnitType(u,UNIT_TYPE_SAPPER))) {
				if ((GetUnitAbilityLevel(u,'A07M')>=1)) {
					GroupRemoveUnit(z9, u);
					M8[GetUnitUserData((u))] = false;
				} else if ((GetUnitTypeId(u)=='h06B')) {
					Qw(u);
				}
				if ((k!=null)) {
					if ((!IsUnitType(k,UNIT_TYPE_STRUCTURE))) {
						t = GetPlayerId(GetOwningPlayer(k));
						Sd[t] = Sd[t]+1;
						if ((GetUnitTypeId(u)=='e00A')) {
							UnitDamageTarget(u, k, 350., true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_NORMAL, WEAPON_TYPE_WHOKNOWS);
						}
						t = GetUnitTypeId(k);
						if ((t=='n00V' || t=='n01O')) {
							IssueImmediateOrderById(k, $D0084);
							Po(k);
						} else if ((t=='e00B')) {
							SetUnitLifePercentBJ(k, GetUnitLifePercent(k)+14.);
						} else if ((t=='e00A')) {
							SetUnitLifePercentBJ(k, GetUnitLifePercent(k)+20.);
						} else if ((t=='h01U' && GetUnitAbilityLevel(u,'A08H')<=0  && (!IsUnitType(u,UNIT_TYPE_MECHANICAL)) && (!IsUnitType(u,UNIT_TYPE_UNDEAD)))) {
							hy(k, u, 'h01V');
							u = null;
						} else if ((t=='h05H' && GetUnitAbilityLevel(u,'A08H')<=0  && (!IsUnitType(u,UNIT_TYPE_MECHANICAL)) && (!IsUnitType(u,UNIT_TYPE_UNDEAD)))) {
							hy(k, u, 'h01U');
							u = null;
						} else if ((GetUnitAbilityLevel(u,'A07M')>=1)) {
							Lo(u);
						}
					}
					if ((GetUnitAbilityLevel(u,'A07G')<=0 && GetUnitAbilityLevel(u,'A07H')<=0 && !IsUnitType(u,UNIT_TYPE_SUMMONED))) {
						t = me[GetPlayerId(GetOwningPlayer(u))];
						if ((Kd[t]>0 && GetUnitAbilityLevel(u,'A0F5')>0)) {
							r4 = GetOwningPlayer(u);
							bj_forLoopAIndexEnd = IMinBJ(20*Fn(GetPlayerId(r4)),500);
							GroupEnumUnitsInRange(q4, GetUnitX(u), GetUnitY(u), 512., oh);
						}
						if ((ld[t]>0)) {
							TriggerSleepAction(2.);
							if ((u!=null && GetWidgetLife(u)<.405 && GetRandomInt(0,99)<IMinBJ(ld[t],40))) {
								k = CreateUnit(GetOwningPlayer(u),GetUnitTypeId(u),GetUnitX(u),GetUnitY(u),.0);
								RemoveUnit(u);
								DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Resurrect\\ResurrectCaster.mdl", k, "origin"));
								if ((GetUnitAbilityLevel(k,'A07M')>=1)) {
									Mo(k);
									GroupAddUnit(z9, k);
								}
							}
						}
					}
				}
			} else if ((IsUnitType(u,UNIT_TYPE_STRUCTURE))) {
				cj(u);
				Mv(GetPlayerId(GetOwningPlayer(u)), u);
				if ((GetUnitAbilityLevel(u,'A0EL')>0)) {
					Mn(u);
				}
				t = GetUnitTypeId(u);
				if ((t=='h05G')) {
					Gv(u);
				} else if ((t=='h059')) {
					tv(u);
				} else if ((t=='h063')) {
					ro(u);
				} else if ((t=='h008')) {
					t = GetPlayerId(GetOwningPlayer(u));
					ge[t] = ge[t]-1;
				} else if ((GetUnitAbilityLevel(u,'A0DS')>0)) {
					In(u);
				} else if ((t=='h061')) {
					po(u);
				}
				FlushChildHashtable(O9, GetHandleId(u));
				GroupRemoveUnit(ff, u);
				GroupRemoveUnit(rf, u);
				u = GetKillingUnit();
				if ((u!=null && nh)) {
					t = me[GetPlayerId(GetOwningPlayer(u))];
					Nd[t] = Nd[t]+1;
					Yr(3, t+1, I2S(Nd[t]));
				}
			}
			k = null;
			u = null;
		}
		private void ha(unit u, float tx, float ty) {
			player p = GetOwningPlayer(u);
			unit c = CreateUnit(p,'h04X',tx,ty,.0);
			group g = CreateGroup();
			float mj = .0;
			int Dj = 0;
			unit j;
			bool ia;
			int dk;
			SetUnitVertexColor(c, 0, 0, 0, 0);
			UnitRemoveAbility(u, 'A005');
			UnitRemoveAbility(u, 'A06E');
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl", u, "origin"));
			DestroyEffect(AddSpecialEffectTarget("Units\\NightElf\\Wisp\\WispExplode.mdl", c, "origin"));
			DestroyEffect(AddSpecialEffectTarget("Units\\NightElf\\Wisp\\WispExplode.mdl", c, "origin"));
			DestroyEffect(AddSpecialEffectTarget("Units\\NightElf\\Wisp\\WispExplode.mdl", c, "origin"));
			TriggerSleepAction(.35);
			r4 = p;
			GroupEnumUnitsInRange(g, tx, ty, 700., null);
			ia = zd;
			zd = false;
			while (true) {
				j = FirstOfGroup(g);
				if (j==null) { break; }
				GroupRemoveUnit(g, j);
				if ((IsUnitEnemy(j,p) && GetWidgetLife(j)>.405 && GetUnitAbilityLevel(j,'Avul')<=0)) {
					Dj = Dj+1;
					mj = mj+(GetWidgetLife(j));
					UnitDamageTarget(u, j, 4444., true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);
					UnitDamageTarget(u, j, 4444., true, false, ATTACK_TYPE_MAGIC, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);
				}
			}
			DestroyGroup(g);
			g = null;
			IssueImmediateOrderById(c, $D022E);
			zd = ia;
			TriggerSleepAction(1.5);
			RemoveUnit(c);
			c = null;
			dk = GetPlayerId(p);
			Wd[dk] = R2I(mj);
			Xd[dk] = Dj;
			Md[me[dk]] = Md[me[dk]]-1;
			if ((Md[me[dk]]==0)) {
				Yr(1, me[dk]+1, "|cffFF00000|r");
			} else {
				Yr(1, me[dk]+1, I2S(Md[me[dk]]));
			}
			Zr(H9[dk], me[dk]*6+1, " ");
			if ((Dj==0)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" wasted his Rescue Strike, killing no unit! Epic Fail!");
			} else if ((Dj==1)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" wasted his Rescue Strike, killing only one unit!");
			} else if ((Dj<5)) {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" wasted his Rescue Strike, dealing only |cffFFFF00"+I2S(Wd[dk])+"|r damage and killing only |cffFFFF00"+I2S(Dj)+"|r units!");
			} else {
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" dealt |cffFFFF00"+I2S(Wd[dk])+"|r damage with his Rescue Strike, killing |cffFFFF00"+I2S(Dj)+"|r units!");
			}
		}
		private void ja(unit u, float tx, float ty) {
			unit c = CreateUnit(GetOwningPlayer(u),'e008',tx,ty,.0);
			UnitAddAbility(c, 'A02G');
			IssueImmediateOrderById(c, $D012D);
			UnitApplyTimedLife(c, 'BTLF', 1.);
			c = null;
		}
		private void ka(unit u, int ma) {
			player p = GetOwningPlayer(u);
			if ((ma==0)) {
				ma = 'I008';
			} else if ((ma==1)) {
				ma = 'I007';
			} else if ((ma==2)) {
				ma = 'I006';
			} else if ((ma==3)) {
				ma = 'I003';
			} else if ((ma==4)) {
				ma = 'I004';
			} else if ((ma==5)) {
				ma = 'I005';
			} else if ((ma==6)) {
				ma = 'I00A';
			} else if ((ma==7)) {
				ma = 'I001';
			} else if ((ma==8)) {
				ma = 'I009';
			}
			IssueNeutralImmediateOrderById(p, oe[me[GetPlayerId(p)]], ma);
		}
		private void na() {
			unit u = GetTriggerUnit();
			int oa = GetSpellAbilityId();
			if ((IsUnitType(u,UNIT_TYPE_STRUCTURE))) {
				if ((oa=='A09A')) {
					Ar(u, (A4[GetUnitPointValue((u))]));
				} else if ((oa=='A0EK')) {
					Jn(u, GetSpellTargetUnit());
				} else {
					Kj(u);
				}
			} else if ((oa=='A005')) {
				ha(u, GetSpellTargetX(), GetSpellTargetY());
			} else if ((oa=='A08Y')) {
				ja(u, GetSpellTargetX(), GetSpellTargetY());
			} else if ((oa>='IBA0' && oa<='IBA8')) {
				ka(u, oa-'IBA0');
			} else {
				Nj(u, oa, GetSpellTargetUnit());
			}
			u = null;
		}
		private void qa() {
			unit u = GetTrainedUnit();
			unit j = GetTriggerUnit();
			int bj = GetTrainedUnitType();
			if ((GetUnitAbilityLevel(u,'A07J')>0)) {
				u = Su(u);
			} else if ((GetUnitTypeId(u)=='h06U')) {
				SetUnitState(u, UNIT_STATE_MANA, GetRandomReal(.0, 50.));
			}
			Wr(u, j);
			u = null;
			if ((Gd[GetPlayerId(GetOwningPlayer(j))])) {
				TriggerSleepAction(.1);
				IssueImmediateOrderById(j, bj);
			}
			j = null;
		}
		private bool sa() {
			unit u = GetTriggerUnit();
			int aj;
			if ((IsUnitType(u,UNIT_TYPE_SAPPER))) {
				TriggerRegisterUnitEvent(Nf, u, EVENT_UNIT_DAMAGED);
				aj = GetUnitTypeId(u);
				if ((aj=='n01B')) {
					SetUnitVertexColor(u, 82, 0, $87, 'f');
				} else if ((aj=='e00F')) {
					u = null;
					return true;
				} else if ((GetUnitAbilityLevel(u,'A0E5')>0)) {
					SetUnitVertexColor(u, $FF, $FF, $FF, $FF-60*GetUnitLevel(u));
				}
				Qo(u);
			}
			u = null;
			return false;
		}
		private void ta() {
			hx(GetTriggerUnit());
		}
		private void va() {
			unit u = GetTriggerUnit();
			if ((IsUnitType(GetTriggerUnit(),UNIT_TYPE_SAPPER) && !IsUnitType(GetTriggerUnit(),UNIT_TYPE_STRUCTURE))) {
				if ((GetUnitAbilityLevel(u,'A07H')>0)) {
					DisableTrigger(kh);
					SetUnitOwner(u, GetChangingUnitPrevOwner(), true);
					EnableTrigger(kh);
					DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl", u, "origin"));
				} else if ((GetUnitTypeId(GetTriggerUnit())=='h03A')) {
					TriggerSleepAction(.1);
					IssueImmediateOrderById(u, $D0057);
					TriggerSleepAction(.1);
				}
			}
			Qo(u);
			u = null;
		}
		private void InitCustomTeams() {
			SetPlayerTeam(Player(0), 0);
			SetPlayerState(Player(0), PLAYER_STATE_ALLIED_VICTORY, 1);
			SetPlayerTeam(Player(1), 0);
			SetPlayerState(Player(1), PLAYER_STATE_ALLIED_VICTORY, 1);
			SetPlayerAllianceStateAllyBJ(Player(0), Player(1), true);
			SetPlayerAllianceStateAllyBJ(Player(1), Player(0), true);
			SetPlayerAllianceStateVisionBJ(Player(0), Player(1), true);
			SetPlayerAllianceStateVisionBJ(Player(1), Player(0), true);
			SetPlayerTeam(Player(6), 1);
			SetPlayerState(Player(6), PLAYER_STATE_ALLIED_VICTORY, 1);
			SetPlayerTeam(Player(7), 1);
			SetPlayerState(Player(7), PLAYER_STATE_ALLIED_VICTORY, 1);
			SetPlayerAllianceStateAllyBJ(Player(6), Player(7), true);
			SetPlayerAllianceStateAllyBJ(Player(7), Player(6), true);
			SetPlayerAllianceStateVisionBJ(Player(6), Player(7), true);
			SetPlayerAllianceStateVisionBJ(Player(7), Player(6), true);
		}
		private void main() {
			weathereffect we;
			SetCameraBounds(-5632.+GetCameraMargin(CAMERA_MARGIN_LEFT), -3584.+GetCameraMargin(CAMERA_MARGIN_BOTTOM), 5632.-GetCameraMargin(CAMERA_MARGIN_RIGHT), 3584.-GetCameraMargin(CAMERA_MARGIN_TOP), -5632.+GetCameraMargin(CAMERA_MARGIN_LEFT), 3584.-GetCameraMargin(CAMERA_MARGIN_TOP), 5632.-GetCameraMargin(CAMERA_MARGIN_RIGHT), -3584.+GetCameraMargin(CAMERA_MARGIN_BOTTOM));
			SetDayNightModels("Environment\\DNC\\DNCAshenvale\\DNCAshenvaleTerrain\\DNCAshenvaleTerrain.mdl", "Environment\\DNC\\DNCAshenvale\\DNCAshenvaleUnit\\DNCAshenvaleUnit.mdl");
			NewSoundEnvironment("Default");
			SetAmbientDaySound("AshenvaleDay");
			SetAmbientNightSound("AshenvaleNight");
			SetMapMusic("Music", true, 0);
			Gg = CreateSound("Sound\\Ambient\\DoodadEffects\\TheHornOfCenarius.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Gg, "HornOfCenariusSound");
			SetSoundDuration(Gg, $2F59);
			Hg = CreateSound("Sound\\Interface\\CreepAggroWhat1.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Hg, "CreepAggro");
			SetSoundDuration(Hg, $4D4);
			Ig = CreateSound("Units\\Demon\\HeroPitLord\\HPitLordYesAttack2.wav",false,false,false,$A,$A,"HeroAcksEAX");
			SetSoundParamsFromLabel(Ig, "HeroPitLordYesAttack");
			SetSoundDuration(Ig, $9C7);
			lg = CreateSound("Units\\NightElf\\Wisp\\WispPissed3.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(lg, "WispPissed");
			SetSoundDuration(lg, $A7A);
			Jg = CreateSound("Units\\Critters\\BloodElfPeasant\\BloodElfEngineerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Jg, "BloodElfEngineerWarcry");
			SetSoundDuration(Jg, $44E);
			Kg = CreateSound("Units\\Human\\Peasant\\PeasantReady1.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Kg, "PeasantReady");
			SetSoundDuration(Kg, 892);
			Lg = CreateSound("Units\\Creeps\\HeroTinker\\HeroTinkerReady1.wav",false,false,false,$A,$A,"HeroAcksEAX");
			SetSoundParamsFromLabel(Lg, "HeroTinkerReady");
			SetSoundDuration(Lg, $AF3);
			Mg = CreateSound("Units\\Creeps\\Murloc\\MurlocPissed2.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Mg, "MurlocPissed");
			SetSoundDuration(Mg, 853);
			Ng = CreateSound("Units\\NightElf\\Ent\\EntReady1.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Ng, "EntReady");
			SetSoundDuration(Ng, $912);
			SetSoundChannel(Ng, 1);
			Og = CreateSound("Units\\NightElf\\Runner\\RunnerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Og, "RunnerWarcry");
			SetSoundDuration(Og, $478);
			Pg = CreateSound("Units\\Creeps\\Bandit\\BanditWhat1.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Pg, "BanditWhat");
			SetSoundDuration(Pg, 520);
			Qg = CreateSound("Units\\Orc\\Peon\\PeonReady1.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Qg, "PeonReady");
			SetSoundDuration(Qg, $6BC);
			SetSoundChannel(Qg, 1);
			Rg = CreateSound("Units\\Undead\\Acolyte\\AcolyteWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Rg, "AcolyteWarcry");
			SetSoundDuration(Rg, $72D);
			Sg = CreateSound("Units\\Demon\\Pitlord\\PitLordYesAttack1.wav",false,false,true,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Sg, "PitLordYesAttack");
			SetSoundDuration(Sg, $A67);
			SetSoundChannel(Sg, 1);
			Tg = CreateSound("Sound\\Interface\\BattleNetTick.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Tg, "ChatroomTimerTick");
			SetSoundDuration(Tg, 476);
			Ug = CreateSound("Sound\\Interface\\Hint.wav",false,false,false,$A,$A,"DefaultEAXON");
			SetSoundParamsFromLabel(Ug, "Hint");
			SetSoundDuration(Ug, $7D6);
			cg = Rect(-5632.,-2048.,-1440.,2048.);
			Dg = Rect(1440.,-2048.,5632.,2048.);
			Eg = Rect(-5248.,-384.,-4480.,384.);
			Fg = Rect(4480.,-384.,5248.,384.);
			InitBlizzard();
			ExecuteFunc("xa");
			ExecuteFunc("gj");
			ExecuteFunc("pj");
			ExecuteFunc("Oj");
			ExecuteFunc("Wj");
			ExecuteFunc("ik");
			ExecuteFunc("ok");
			ExecuteFunc("qk");
			ExecuteFunc("ak");
			ExecuteFunc("pm");
			ExecuteFunc("ym");
			ExecuteFunc("Pm");
			ExecuteFunc("Zm");
			ExecuteFunc("hn");
			ExecuteFunc("bn");
			ExecuteFunc("so");
			ExecuteFunc("ao");
			ExecuteFunc("Go");
			ExecuteFunc("No");
			ExecuteFunc("Zo");
			ExecuteFunc("Xr");
			ExecuteFunc("Us");
			ExecuteFunc("Tu");
			ExecuteFunc("gv");
			ExecuteFunc("uv");
			ExecuteFunc("Iv");
			ExecuteFunc("dw");
			ExecuteFunc("Bw");
			ExecuteFunc("Gw");
			ExecuteFunc("kx");
			ExecuteFunc("Hx");
			ExecuteFunc("Vx");
			ExecuteFunc("iy");
			ExecuteFunc("mz");
			ExecuteFunc("Az");
			ExecuteFunc("Cz");
			ExecuteFunc("fA");
			ExecuteFunc("qA");
			Vg = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(Vg, EVENT_PLAYER_UNIT_SUMMON);
			TriggerAddAction(Vg, function DA);
			Wg = CreateTrigger();
			TriggerRegisterPlayerEventLeave(Wg, Player(0));
			TriggerRegisterPlayerEventLeave(Wg, Player(1));
			TriggerRegisterPlayerEventLeave(Wg, Player(2));
			TriggerRegisterPlayerEventLeave(Wg, Player(3));
			TriggerRegisterPlayerEventLeave(Wg, Player(4));
			TriggerRegisterPlayerEventLeave(Wg, Player(5));
			TriggerRegisterPlayerEventLeave(Wg, Player(6));
			TriggerRegisterPlayerEventLeave(Wg, Player(7));
			TriggerRegisterPlayerEventLeave(Wg, Player(8));
			TriggerRegisterPlayerEventLeave(Wg, Player(9));
			TriggerRegisterPlayerEventLeave(Wg, Player($A));
			TriggerRegisterPlayerEventLeave(Wg, Player($B));
			TriggerAddAction(Wg, function MA);
			Xg = CreateTrigger();
			TriggerAddAction(Xg, function PA);
			TriggerRegisterAnyUnitEventBJ(Xg, EVENT_PLAYER_UNIT_PICKUP_ITEM);
			Yg = CreateTrigger();
			TriggerRegisterLeaveRectSimple(Yg, cg);
			TriggerRegisterLeaveRectSimple(Yg, Dg);
			TriggerAddCondition(Yg, Condition(function RA));
			Zg = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(Zg, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH);
			TriggerRegisterAnyUnitEventBJ(Zg, EVENT_PLAYER_UNIT_UPGRADE_FINISH);
			TriggerAddAction(Zg, function TA);
			dh = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(dh, EVENT_PLAYER_UNIT_UPGRADE_START);
			TriggerAddAction(dh, function VA);
			eh = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(eh, EVENT_PLAYER_UNIT_UPGRADE_CANCEL);
			TriggerAddAction(eh, function XA);
			fh = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(fh, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH);
			TriggerAddCondition(fh, Condition(function ZA));
			gh = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(gh, EVENT_PLAYER_UNIT_DEATH);
			TriggerAddAction(gh, function fa);
			oh = Filter(function ea);
			hh = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(hh, EVENT_PLAYER_UNIT_SPELL_EFFECT);
			TriggerAddAction(hh, function na);
			ih = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(ih, EVENT_PLAYER_UNIT_TRAIN_FINISH);
			TriggerAddAction(ih, function qa);
			jh = CreateTrigger();
			TriggerRegisterEnterRectSimple(jh, bj_mapInitialPlayableArea);
			TriggerAddCondition(jh, Condition(function sa));
			TriggerAddAction(jh, function ta);
			kh = CreateTrigger();
			TriggerRegisterAnyUnitEventBJ(kh, EVENT_PLAYER_UNIT_CHANGE_OWNER);
			TriggerAddAction(kh, function va);
		}
		private void config() {
			SetMapName("|cffFFD700Castle Fight 1.22a ES");
			SetMapDescription("An epic battle between the two castles!Recommended gamemode is 4on4 with 2 wins.hf!");
			SetPlayers(4);
			SetTeams(4);
			SetGamePlacement(MAP_PLACEMENT_TEAMS_TOGETHER);
			DefineStartLocation(0, -4288., 448.);
			DefineStartLocation(1, -4288., 320.);
			DefineStartLocation(2, 4288., 448.);
			DefineStartLocation(3, 4288., 320.);
			SetPlayerStartLocation(Player(0), 0);
			ForcePlayerStartLocation(Player(0), 0);
			SetPlayerColor(Player(0), ConvertPlayerColor(0));
			SetPlayerRacePreference(Player(0), RACE_PREF_NIGHTELF);
			SetPlayerRaceSelectable(Player(0), false);
			SetPlayerController(Player(0), MAP_CONTROL_USER);
			SetPlayerStartLocation(Player(1), 1);
			ForcePlayerStartLocation(Player(1), 1);
			SetPlayerColor(Player(1), ConvertPlayerColor(1));
			SetPlayerRacePreference(Player(1), RACE_PREF_NIGHTELF);
			SetPlayerRaceSelectable(Player(1), false);
			SetPlayerController(Player(1), MAP_CONTROL_USER);
			SetPlayerStartLocation(Player(6), 2);
			ForcePlayerStartLocation(Player(6), 2);
			SetPlayerColor(Player(6), ConvertPlayerColor(6));
			SetPlayerRacePreference(Player(6), RACE_PREF_UNDEAD);
			SetPlayerRaceSelectable(Player(6), false);
			SetPlayerController(Player(6), MAP_CONTROL_USER);
			SetPlayerStartLocation(Player(7), 3);
			ForcePlayerStartLocation(Player(7), 3);
			SetPlayerColor(Player(7), ConvertPlayerColor(7));
			SetPlayerRacePreference(Player(7), RACE_PREF_UNDEAD);
			SetPlayerRaceSelectable(Player(7), false);
			SetPlayerController(Player(7), MAP_CONTROL_USER);
			InitCustomTeams();
			SetStartLocPrioCount(0, 1);
			SetStartLocPrio(0, 0, 1, MAP_LOC_PRIO_HIGH);
			SetStartLocPrioCount(1, 1);
			SetStartLocPrio(1, 0, 0, MAP_LOC_PRIO_HIGH);
			SetStartLocPrioCount(2, 1);
			SetStartLocPrio(2, 0, 3, MAP_LOC_PRIO_HIGH);
			SetStartLocPrioCount(3, 1);
			SetStartLocPrio(3, 0, 2, MAP_LOC_PRIO_HIGH);
		}
		private bool ya() {
			int oi = ki;
			FlushStoredInteger(t7, "val:"+vh[oi], th[oi]);
			FlushStoredInteger(t7, "chk:"+vh[oi], vh[oi]);
			th[oi] = null;
			vh[oi] = null;
			wh[oi] = 0;
			return true;
		}
		private bool za() {
			mi = tp(ki,ii);
			return true;
		}
		private bool Aa() {
			mi = sp(ki,ii);
			return true;
		}
		private bool aa() {
			mi = rp(ki,ii);
			return true;
		}
		private bool Ba() {
			mi = qp(ki,ii);
			return true;
		}
		private bool ba() {
			mi = pp(ki,ii);
			return true;
		}
		private bool Ca() {
			mi = np(ki,ii);
			return true;
		}
		private bool ca() {
			mi = kp(ki,ii);
			return true;
		}
		private bool Da() {
			mi = jp(ki,ii);
			return true;
		}
		private bool Ea() {
			mi = ip(ki,ii);
			return true;
		}
		private bool Fa() {
			mi = hp(ki,ii);
			return true;
		}
		private bool Ga() {
			mi = gp(ki,ii);
			return true;
		}
		private bool Ha() {
			mi = fp(ki,ii);
			return true;
		}
		private bool Ia() {
			int oi = ki;
			int Hi = ji;
			Eh[Fh[oi]+Gh[oi]] = Hi;
			Gh[oi] = Gh[oi]+1;
			return true;
		}
		private bool la() {
			mi = up(ki,ii);
			return true;
		}
		private void xa() {
			gi = CreateTrigger();
			TriggerAddCondition(gi, Condition(function ya));
			Bh[16] = CreateTrigger();
			TriggerAddCondition(Bh[16], Condition(function za));
			TriggerAddAction(Bh[16], function za);
			ah[16] = null;
			Bh[$F] = CreateTrigger();
			TriggerAddCondition(Bh[$F], Condition(function Aa));
			TriggerAddAction(Bh[$F], function Aa);
			ah[$F] = null;
			Bh[$E] = CreateTrigger();
			TriggerAddCondition(Bh[$E], Condition(function aa));
			TriggerAddAction(Bh[$E], function aa);
			ah[$E] = null;
			Bh[$D] = CreateTrigger();
			TriggerAddCondition(Bh[$D], Condition(function Ba));
			TriggerAddAction(Bh[$D], function Ba);
			ah[$D] = null;
			Bh[$C] = CreateTrigger();
			TriggerAddCondition(Bh[$C], Condition(function ba));
			TriggerAddAction(Bh[$C], function ba);
			ah[$C] = null;
			Bh[$B] = CreateTrigger();
			TriggerAddCondition(Bh[$B], Condition(function Ca));
			TriggerAddAction(Bh[$B], function Ca);
			ah[$B] = null;
			Bh[$A] = CreateTrigger();
			TriggerAddCondition(Bh[$A], Condition(function ca));
			TriggerAddAction(Bh[$A], function ca);
			ah[$A] = null;
			Bh[9] = CreateTrigger();
			TriggerAddCondition(Bh[9], Condition(function Da));
			TriggerAddAction(Bh[9], function Da);
			ah[9] = null;
			Bh[8] = CreateTrigger();
			TriggerAddCondition(Bh[8], Condition(function Ea));
			TriggerAddAction(Bh[8], function Ea);
			ah[8] = null;
			Bh[7] = CreateTrigger();
			TriggerAddCondition(Bh[7], Condition(function Fa));
			TriggerAddAction(Bh[7], function Fa);
			ah[7] = null;
			Bh[6] = CreateTrigger();
			TriggerAddCondition(Bh[6], Condition(function Ga));
			TriggerAddAction(Bh[6], function Ga);
			ah[6] = null;
			Bh[5] = CreateTrigger();
			TriggerAddCondition(Bh[5], Condition(function Ha));
			TriggerAddAction(Bh[5], function Ha);
			ah[5] = null;
			hi = CreateTrigger();
			TriggerAddCondition(hi, Condition(function Ia));
			Bh[17] = CreateTrigger();
			TriggerAddCondition(Bh[17], Condition(function la));
			TriggerAddAction(Bh[17], function la);
			ah[17] = null;
		}

	
	}
}

