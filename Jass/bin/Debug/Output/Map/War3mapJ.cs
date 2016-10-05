using System;
using System.Collections.Generic;

namespace Jass {

	public class War3mapJ {

		private JassArray<string> h = new JassArray<string>();//string array h
		private int o;//integer o
		private float A;//real A
		private float B;//real B
		private JassArray<float> C = new JassArray<float>();//real array C
		private JassArray<float> D = new JassArray<float>();//real array D
		private JassArray<float> E = new JassArray<float>();//real array E
		private JassArray<float> F = new JassArray<float>();//real array F
		private JassArray<float> G = new JassArray<float>();//real array G
		private float H;//real H
		private float I;//real I
		private float J;//real J
		private int K;//integer K
		private timer L;//timer L
		private JassArray<item> M = new JassArray<item>();//item array M
		private int N;//integer N
		private code O;//code O
		private float P;//real P
		private JassArray<int> Q = new JassArray<int>();//integer array Q
		private timer R = CreateTimer();//constant timer R=CreateTimer()
		private JassArray<unit> S = new JassArray<unit>();//unit array S
		private JassArray<float> T = new JassArray<float>();//real array T
		private JassArray<float> U = new JassArray<float>();//real array U
		private JassArray<int> V = new JassArray<int>();//integer array V
		private int W = 0;//integer W=0
		private boolexpr X;//boolexpr X
		private timer Y;//timer Y
		private bool Z = false;//boolean Z=false
		private int d4;//integer d4
		private JassArray<int> e4 = new JassArray<int>();//integer array e4
		private JassArray<int> f4 = new JassArray<int>();//integer array f4
		private JassArray<int> g4 = new JassArray<int>();//integer array g4
		private JassArray<int> h4 = new JassArray<int>();//integer array h4
		private JassArray<int> i4 = new JassArray<int>();//integer array i4
		private JassArray<int> j4 = new JassArray<int>();//integer array j4
		private JassArray<int> k4 = new JassArray<int>();//integer array k4
		private JassArray<float> m4 = new JassArray<float>();//real array m4
		private JassArray<float> n4 = new JassArray<float>();//real array n4
		private float o4;//real o4
		private float p4;//real p4
		private group q4 = CreateGroup();//constant group q4=CreateGroup()
		private player r4;//player r4
		private JassArray<int> t4 = new JassArray<int>();//integer array t4
		private JassArray<float> u4 = new JassArray<float>();//real array u4
		private JassArray<bool> v4 = new JassArray<bool>();//boolean array v4
		private JassArray<bool> w4 = new JassArray<bool>();//boolean array w4
		private JassArray<int> x4 = new JassArray<int>();//integer array x4
		private JassArray<trigger> y4 = new JassArray<trigger>();//trigger array y4
		private unit z4;//unit z4
		private JassArray<float> A4 = new JassArray<float>();//real array A4
		private JassArray<trigger> a4 = new JassArray<trigger>();//trigger array a4
		private unit B4;//unit B4
		private JassArray<trigger> b4 = new JassArray<trigger>();//trigger array b4
		private JassArray<int> C4 = new JassArray<int>();//integer array C4
		private unit c4;//unit c4
		private unit D4;//unit D4
		private JassArray<string> E4 = new JassArray<string>();//string array E4
		private int F4 = 0;//integer F4=0
		private int G4 = 0;//integer G4=0
		private int H4 = 0;//integer H4=0
		private int I4 = $C8;//constant integer I4=$C8
		private bool l4 = true;//boolean l4=true
		private JassArray<bool> J4 = new JassArray<bool>();//boolean array J4
		private timer K4 = CreateTimer();//constant timer K4=CreateTimer()
		private JassArray<unit> L4 = new JassArray<unit>();//unit array L4
		private JassArray<float> M4 = new JassArray<float>();//real array M4
		private JassArray<float> N4 = new JassArray<float>();//real array N4
		private JassArray<int> O4 = new JassArray<int>();//integer array O4
		private JassArray<float> P4 = new JassArray<float>();//real array P4
		private int Q4 = 0;//integer Q4=0
		private bool R4 = false;//boolean R4=false
		private boolexpr S4;//boolexpr S4
		private player T4 = null;//player T4=null
		private force U4 = CreateForce();//constant force U4=CreateForce()
		private trigger V4 = CreateTrigger();//constant trigger V4=CreateTrigger()
		private int W4;//integer W4
		private int X4;//integer X4
		private timer Y4 = CreateTimer();//constant timer Y4=CreateTimer()
		private JassArray<unit> Z4 = new JassArray<unit>();//unit array Z4
		private JassArray<float> d7 = new JassArray<float>();//real array d7
		private JassArray<int> e7 = new JassArray<int>();//integer array e7
		private JassArray<int> f7 = new JassArray<int>();//integer array f7
		private JassArray<unit> g7 = new JassArray<unit>();//unit array g7
		private JassArray<float> h7 = new JassArray<float>();//real array h7
		private JassArray<bool> i7 = new JassArray<bool>();//boolean array i7
		private int j7 = 0;//integer j7=0
		private boolexpr k7;//boolexpr k7
		private int m7 = StringLength("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~");//constant integer m7=StringLength("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~")
		private JassArray<string> n7 = new JassArray<string>();//string array n7
		private JassArray<string> o7 = new JassArray<string>();//string array o7
		private JassArray<string> p7 = new JassArray<string>();//string array p7
		private JassArray<string> q7 = new JassArray<string>();//string array q7
		private JassArray<string> r7 = new JassArray<string>();//string array r7
		private bool s7 = false;//boolean s7=false
		private gamecache t7 = null;//gamecache t7=null
		private int u7 = 1;//integer u7=1
		private int v7 = 0;//integer v7=0
		private timer w7 = CreateTimer();//timer w7=CreateTimer()
		private int x7 = 0;//integer x7=0
		private int y7 = 0;//integer y7=0
		private player z7 = Player($F);//constant player z7=Player($F)
		private timer A7 = CreateTimer();//constant timer A7=CreateTimer()
		private JassArray<destructable> a7 = new JassArray<destructable>();//destructable array a7
		private JassArray<unit> B7 = new JassArray<unit>();//unit array B7
		private bool b7 = false;//boolean b7=false
		private trigger C7 = null;//trigger C7=null
		private int c7 = 0;//integer c7=0
		private JassArray<int> D7 = new JassArray<int>();//integer array D7
		private JassArray<int> E7 = new JassArray<int>();//integer array E7
		private JassArray<string> F7 = new JassArray<string>();//string array F7
		private JassArray<int> G7 = new JassArray<int>();//integer array G7
		private JassArray<sound> H7 = new JassArray<sound>();//sound array H7
		private JassArray<bool> I7 = new JassArray<bool>();//boolean array I7
		private int l7 = 0;//integer l7=0
		private trigger J7 = CreateTrigger();//constant trigger J7=CreateTrigger()
		private JassArray<int> K7 = new JassArray<int>();//integer array K7
		private timer L7 = null;//timer L7=null
		private JassArray<timer> M7 = new JassArray<timer>();//timer array M7
		private JassArray<timer> N7 = new JassArray<timer>();//timer array N7
		private JassArray<timerdialog> O7 = new JassArray<timerdialog>();//timerdialog array O7
		private JassArray<float> P7 = new JassArray<float>();//real array P7
		private JassArray<int> Q7 = new JassArray<int>();//integer array Q7
		private JassArray<string> R7 = new JassArray<string>();//string array R7
		private JassArray<location> S7 = new JassArray<location>();//location array S7
		private JassArray<bool> T7 = new JassArray<bool>();//boolean array T7
		private trigger U7 = CreateTrigger();//constant trigger U7=CreateTrigger()
		private bool V7 = false;//boolean V7=false
		private float W7;//real W7
		private float X7;//real X7
		private float Y7;//real Y7
		private float Z7;//real Z7
		private JassArray<unit> d8 = new JassArray<unit>();//unit array d8
		private int e8;//integer e8
		private sound g8 = CreateSoundFromLabel("InterfaceError",false,false,false,$A,$A);//constant sound g8=CreateSoundFromLabel("InterfaceError",false,false,false,$A,$A)
		private bool h8 = true;//boolean h8=true
		private JassArray<float> i8 = new JassArray<float>();//real array i8
		private JassArray<playercolor> j8 = new JassArray<playercolor>();//playercolor array j8
		private playercolor k8 = GetPlayerColor(Player($F));//constant playercolor k8=GetPlayerColor(Player($F))
		private bool m8 = false;//boolean m8=false
		private region n8;//region n8
		private region o8;//region o8
		private int p8;//integer p8
		private int q8;//integer q8
		private trigger r8;//trigger r8
		private trigger s8;//trigger s8
		private unit t8;//unit t8
		private unit u8;//unit u8
		private JassArray<int> v8 = new JassArray<int>();//integer array v8
		private int w8;//integer w8
		private int x8 = 1144013095;//integer x8='A0D1'
		private int y8 = 1144013095;//integer y8='A0D0'
		private int z8 = 1160790311;//integer z8='A0E3'
		private JassArray<int> A8 = new JassArray<int>();//integer array A8
		private JassArray<int> a8 = new JassArray<int>();//integer array a8
		private boolexpr B8;//boolexpr B8
		private bool b8;//boolean b8
		private JassArray<int> C8 = new JassArray<int>();//integer array C8
		private int c8;//integer c8
		private bool D8;//boolean D8
		private boolexpr E8;//boolexpr E8
		private JassArray<unit> F8 = new JassArray<unit>();//unit array F8
		private JassArray<unit> G8 = new JassArray<unit>();//unit array G8
		private int H8;//integer H8
		private JassArray<int> I8 = new JassArray<int>();//integer array I8
		private int l8;//integer l8
		private boolexpr J8;//boolexpr J8
		private boolexpr K8;//boolexpr K8
		private JassArray<unit> L8 = new JassArray<unit>();//unit array L8
		private JassArray<bool> M8 = new JassArray<bool>();//boolean array M8
		private JassArray<float> N8 = new JassArray<float>();//real array N8
		private JassArray<float> O8 = new JassArray<float>();//real array O8
		private boolexpr P8;//boolexpr P8
		private boolexpr Q8;//boolexpr Q8
		private boolexpr R8;//boolexpr R8
		private boolexpr S8;//boolexpr S8
		private boolexpr T8;//boolexpr T8
		private JassArray<unit> U8 = new JassArray<unit>();//unit array U8
		private JassArray<float> V8 = new JassArray<float>();//real array V8
		private JassArray<float> W8 = new JassArray<float>();//real array W8
		private JassArray<timer> X8 = new JassArray<timer>();//timer array X8
		private int Y8 = 0;//integer Y8=0
		private code Z8;//code Z8
		private trigger d9 = CreateTrigger();//constant trigger d9=CreateTrigger()
		private player e9;//player e9
		private int f9;//integer f9
		private int g9;//integer g9
		private group h9;//group h9
		private hashtable i9 = InitHashtable();//hashtable i9=InitHashtable()
		private int j9;//integer j9
		private int k9;//integer k9
		private int m9;//integer m9
		private int n9;//integer n9
		private int o9;//integer o9
		private int p9;//integer p9
		private int q9;//integer q9
		private int r9;//integer r9
		private int s9;//integer s9
		private int t9;//integer t9
		private int u9;//integer u9
		private int v9;//integer v9
		private int w9;//integer w9
		private boolexpr x9;//boolexpr x9
		private boolexpr y9;//boolexpr y9
		private group z9 = CreateGroup();//constant group z9=CreateGroup()
		private boolexpr A9;//boolexpr A9
		private timer a9 = CreateTimer();//constant timer a9=CreateTimer()
		private timer B9 = CreateTimer();//constant timer B9=CreateTimer()
		private boolexpr b9;//boolexpr b9
		private rect C9;//rect C9
		private bool c9 = false;//boolean c9=false
		private JassArray<multiboard> D9 = new JassArray<multiboard>();//multiboard array D9
		private JassArray<multiboard> E9 = new JassArray<multiboard>();//multiboard array E9
		private JassArray<int> F9 = new JassArray<int>();//integer array F9
		private multiboard G9 = null;//multiboard G9=null
		private JassArray<int> H9 = new JassArray<int>();//integer array H9
		private int I9 = 0;//integer I9=0
		private JassArray<string> l9 = new JassArray<string>();//string array l9
		private multiboarditem J9;//multiboarditem J9
		private int K9 = 0;//integer K9=0
		private timer L9 = CreateTimer();//constant timer L9=CreateTimer()
		private int M9;//integer M9
		private int N9;//integer N9
		private hashtable O9 = InitHashtable();//constant hashtable O9=InitHashtable()
		private group P9 = CreateGroup();//constant group P9=CreateGroup()
		private rect Q9;//rect Q9
		private location R9;//location R9
		private bool S9 = true;//boolean S9=true
		private bool T9 = false;//boolean T9=false
		private bool U9 = false;//boolean U9=false
		private string V9;//string V9
		private int W9 = $FA;//integer W9=$FA
		private int X9 = '}';//integer X9='}'
		private int Y9 = 1;//integer Y9=1
		private int Z9 = -1;//integer Z9=-1
		private int dd = 0;//integer dd=0
		private int ed = 0;//integer ed=0
		private int fd = 2;//integer fd=2
		private int gd = -1;//integer gd=-1
		private int hd = $A;//integer hd=$A
		private bool jd;//boolean jd
		private bool kd = false;//boolean kd=false
		private bool md = false;//boolean md=false
		private bool nd = false;//boolean nd=false
		private bool od = false;//boolean od=false
		private bool pd = true;//boolean pd=true
		private bool qd = true;//boolean qd=true
		private bool rd = true;//boolean rd=true
		private bool sd = true;//boolean sd=true
		private bool td = false;//boolean td=false
		private bool ud = true;//boolean ud=true
		private bool vd = false;//boolean vd=false
		private bool wd = false;//boolean wd=false
		private bool xd = false;//boolean xd=false
		private bool yd = true;//boolean yd=true
		private bool zd = false;//boolean zd=false
		private int Ad = 0;//integer Ad=0
		private int ad = -1;//integer ad=-1
		private int Bd = 0;//integer Bd=0
		private int bd = 0;//integer bd=0
		private int Cd = 0;//integer Cd=0
		private int cd = 0;//integer cd=0
		private int Dd = 0;//integer Dd=0
		private int Ed = 0;//integer Ed=0
		private int Fd = 0;//integer Fd=0
		private JassArray<bool> Gd = new JassArray<bool>();//boolean array Gd
		private JassArray<int> Hd = new JassArray<int>();//integer array Hd
		private JassArray<location> Id = new JassArray<location>();//location array Id
		private JassArray<int> ld = new JassArray<int>();//integer array ld
		private JassArray<group> Jd = new JassArray<group>();//group array Jd
		private JassArray<int> Kd = new JassArray<int>();//integer array Kd
		private JassArray<rect> Ld = new JassArray<rect>();//rect array Ld
		private JassArray<int> Md = new JassArray<int>();//integer array Md
		private JassArray<int> Nd = new JassArray<int>();//integer array Nd
		private JassArray<string> Od = new JassArray<string>();//string array Od
		private JassArray<int> Pd = new JassArray<int>();//integer array Pd
		private JassArray<location> Qd = new JassArray<location>();//location array Qd
		private JassArray<int> Rd = new JassArray<int>();//integer array Rd
		private JassArray<int> Sd = new JassArray<int>();//integer array Sd
		private JassArray<int> Td = new JassArray<int>();//integer array Td
		private JassArray<int> Ud = new JassArray<int>();//integer array Ud
		private JassArray<int> Vd = new JassArray<int>();//integer array Vd
		private JassArray<int> Wd = new JassArray<int>();//integer array Wd
		private JassArray<int> Xd = new JassArray<int>();//integer array Xd
		private JassArray<int> Yd = new JassArray<int>();//integer array Yd
		private JassArray<int> Zd = new JassArray<int>();//integer array Zd
		private JassArray<int> de = new JassArray<int>();//integer array de
		private JassArray<int> ee = new JassArray<int>();//integer array ee
		private JassArray<int> fe = new JassArray<int>();//integer array fe
		private JassArray<int> ge = new JassArray<int>();//integer array ge
		private JassArray<int> he = new JassArray<int>();//integer array he
		private force ie = CreateForce();//constant force ie=CreateForce()
		private force je = CreateForce();//constant force je=CreateForce()
		private force ke = CreateForce();//constant force ke=CreateForce()
		private JassArray<int> me = new JassArray<int>();//integer array me
		private JassArray<force> ne = new JassArray<force>();//force array ne
		private JassArray<unit> oe = new JassArray<unit>();//unit array oe
		private JassArray<string> pe = new JassArray<string>();//string array pe
		private JassArray<bool> qe = new JassArray<bool>();//boolean array qe
		private int re = 0;//integer re=0
		private timer se;//timer se
		private JassArray<int> te = new JassArray<int>();//integer array te
		private JassArray<float> ue = new JassArray<float>();//real array ue
		private JassArray<int> ve = new JassArray<int>();//integer array ve
		private JassArray<int> xe = new JassArray<int>();//integer array xe
		private JassArray<int> ye = new JassArray<int>();//integer array ye
		private JassArray<bool> ze = new JassArray<bool>();//boolean array ze
		private JassArray<float> Ae = new JassArray<float>();//real array Ae
		private JassArray<unit> ae = new JassArray<unit>();//unit array ae
		private JassArray<bool> Be = new JassArray<bool>();//boolean array Be
		private JassArray<unit> be = new JassArray<unit>();//unit array be
		private JassArray<force> Ce = new JassArray<force>();//force array Ce
		private JassArray<timer> ce = new JassArray<timer>();//timer array ce
		private JassArray<bool> De = new JassArray<bool>();//boolean array De
		private JassArray<player> Ee = new JassArray<player>();//player array Ee
		private bool Fe = true;//boolean Fe=true
		private bool Ge = false;//boolean Ge=false
		private int He = 7-1;//constant integer He=7-1
		private JassArray<int> Ie = new JassArray<int>();//integer array Ie
		private boolexpr le;//boolexpr le
		private int Je;//integer Je
		private int Ke;//integer Ke
		private int Le;//integer Le
		private int Me;//integer Me
		private int Ne;//integer Ne
		private int Oe;//integer Oe
		private int Pe;//integer Pe
		private int Qe;//integer Qe
		private int Re;//integer Re
		private int Se;//integer Se
		private int Te;//integer Te
		private int Ue;//integer Ue
		private JassArray<int> Ve = new JassArray<int>();//integer array Ve
		private int We = 825245991;//integer We='A01I'
		private int Xe;//integer Xe
		private boolexpr Ye;//boolexpr Ye
		private boolexpr Ze;//boolexpr Ze
		private int df = 825257511;//integer df='n01C'
		private boolexpr ef;//boolexpr ef
		private group ff = CreateGroup();//constant group ff=CreateGroup()
		private boolexpr gf;//boolexpr gf
		private boolexpr hf;//boolexpr hf
		private timer jf = CreateTimer();//constant timer jf=CreateTimer()
		private float kf = 25.;//real kf=25.
		private JassArray<float> mf = new JassArray<float>();//real array mf
		private JassArray<int> nf = new JassArray<int>();//integer array nf
		private string of;//string of
		private JassArray<float> pf = new JassArray<float>();//real array pf
		private int qf;//integer qf
		private group rf = CreateGroup();//constant group rf=CreateGroup()
		private boolexpr sf;//boolexpr sf
		private boolexpr tf;//boolexpr tf
		private boolexpr uf;//boolexpr uf
		private int vf = 1110458663;//integer vf='A0BD'
		private weathereffect wf;//weathereffect wf
		private boolexpr xf;//boolexpr xf
		private boolexpr yf;//boolexpr yf
		private int zf = 925909287;//integer zf='A07T'
		private group Af = CreateGroup();//constant group Af=CreateGroup()
		private boolexpr af;//boolexpr af
		private JassArray<int> Bf = new JassArray<int>();//integer array Bf
		private trigger bf = CreateTrigger();//constant trigger bf=CreateTrigger()
		private boolexpr Cf;//boolexpr Cf
		private boolexpr cf;//boolexpr cf
		private boolexpr Df;//boolexpr Df
		private timer Ef = CreateTimer();//constant timer Ef=CreateTimer()
		private JassArray<unit> Ff = new JassArray<unit>();//unit array Ff
		private int Gf = 0;//integer Gf=0
		private weathereffect Hf;//weathereffect Hf
		private float If;//real If
		private float lf;//real lf
		private float Jf;//real Jf
		private float Kf;//real Kf
		private boolexpr Lf;//boolexpr Lf
		private JassArray<int> Mf = new JassArray<int>();//integer array Mf
		private trigger Nf = null;//trigger Nf=null
		private bool Of;//boolean Of
		private bool Pf;//boolean Pf
		private boolexpr Qf;//boolexpr Qf
		private string Rf;//string Rf
		private timer Sf = null;//timer Sf=null
		private trigger Tf = null;//trigger Tf=null
		private JassArray<int> Uf = new JassArray<int>();//integer array Uf
		private JassArray<int> Vf = new JassArray<int>();//integer array Vf
		private timer Wf = null;//timer Wf=null
		private timer Xf = CreateTimer();//timer Xf=CreateTimer()
		private timerdialog Yf;//timerdialog Yf
		private trigger Zf = CreateTrigger();//trigger Zf=CreateTrigger()
		private dialog dg = DialogCreate();//dialog dg=DialogCreate()
		private JassArray<button> eg = new JassArray<button>();//button array eg
		private bool fg = false;//boolean fg=false
		private bool gg = false;//boolean gg=false
		private trigger hg;//trigger hg
		private trigger ig;//trigger ig
		private trigger jg;//trigger jg
		private boolexpr kg;//boolexpr kg
		private int mg = 0;//integer mg=0
		private timer ng = CreateTimer();//constant timer ng=CreateTimer()
		private timerdialog og = CreateTimerDialog(ng);//constant timerdialog og=CreateTimerDialog(ng)
		private int pg = -1;//integer pg=-1
		private int qg;//integer qg
		private JassArray<bool> rg = new JassArray<bool>();//boolean array rg
		private bool sg = false;//boolean sg=false
		private string tg = null;//string tg=null
		private bool ug = false;//boolean ug=false
		private timer vg = CreateTimer();//constant timer vg=CreateTimer()
		private bool wg = false;//boolean wg=false
		private int xg;//integer xg
		private int yg;//integer yg
		private trigger zg = CreateTrigger();//constant trigger zg=CreateTrigger()
		private fogmodifier Ag;//fogmodifier Ag
		private fogmodifier ag;//fogmodifier ag
		private int Bg = -1;//integer Bg=-1
		private int bg;//integer bg
		private trigger Cg;//trigger Cg
		private rect cg = null;//rect cg=null
		private rect Dg = null;//rect Dg=null
		private rect Eg = null;//rect Eg=null
		private rect Fg = null;//rect Fg=null
		private sound Gg = null;//sound Gg=null
		private sound Hg = null;//sound Hg=null
		private sound Ig = null;//sound Ig=null
		private sound lg = null;//sound lg=null
		private sound Jg = null;//sound Jg=null
		private sound Kg = null;//sound Kg=null
		private sound Lg = null;//sound Lg=null
		private sound Mg = null;//sound Mg=null
		private sound Ng = null;//sound Ng=null
		private sound Og = null;//sound Og=null
		private sound Pg = null;//sound Pg=null
		private sound Qg = null;//sound Qg=null
		private sound Rg = null;//sound Rg=null
		private sound Sg = null;//sound Sg=null
		private sound Tg = null;//sound Tg=null
		private sound Ug = null;//sound Ug=null
		private trigger Vg = null;//trigger Vg=null
		private trigger Wg = null;//trigger Wg=null
		private trigger Xg = null;//trigger Xg=null
		private trigger Yg = null;//trigger Yg=null
		private trigger Zg = null;//trigger Zg=null
		private trigger dh = null;//trigger dh=null
		private trigger eh = null;//trigger eh=null
		private trigger fh = null;//trigger fh=null
		private trigger gh = null;//trigger gh=null
		private trigger hh = null;//trigger hh=null
		private trigger ih = null;//trigger ih=null
		private trigger jh = null;//trigger jh=null
		private trigger kh = null;//trigger kh=null
		private force mh;//force mh
		private bool nh = true;//boolean nh=true
		private boolexpr oh;//boolexpr oh
		private int ph = 0;//integer ph=0
		private int qh = 0;//integer qh=0
		private JassArray<int> rh = new JassArray<int>();//integer array rh
		private JassArray<float> sh = new JassArray<float>();//real array sh
		private JassArray<string> th = new JassArray<string>();//string array th
		private JassArray<int> uh = new JassArray<int>();//integer array uh
		private JassArray<string> vh = new JassArray<string>();//string array vh
		private JassArray<int> wh = new JassArray<int>();//integer array wh
		private int xh = 0;//integer xh=0
		private int yh = 0;//integer yh=0
		private JassArray<int> zh = new JassArray<int>();//integer array zh
		private JassArray<int> Ah = new JassArray<int>();//integer array Ah
		private JassArray<trigger> ah = new JassArray<trigger>();//trigger array ah
		private JassArray<trigger> Bh = new JassArray<trigger>();//trigger array Bh
		private int bh = 0;//integer bh=0
		private int Ch = 0;//integer Ch=0
		private JassArray<int> Dh = new JassArray<int>();//integer array Dh
		private JassArray<int> Eh = new JassArray<int>();//integer array Eh
		private JassArray<int> Fh = new JassArray<int>();//integer array Fh
		private JassArray<int> Gh = new JassArray<int>();//integer array Gh
		private int Hh = 0;//integer Hh=0
		private int Ih = 0;//integer Ih=0
		private JassArray<int> lh = new JassArray<int>();//integer array lh
		private int Jh = 0;//integer Jh=0
		private int Kh = 0;//integer Kh=0
		private JassArray<int> Lh = new JassArray<int>();//integer array Lh
		private int Mh = 0;//integer Mh=0
		private int Nh = 0;//integer Nh=0
		private JassArray<int> Oh = new JassArray<int>();//integer array Oh
		private JassArray<int> Ph = new JassArray<int>();//integer array Ph
		private JassArray<int> Qh = new JassArray<int>();//integer array Qh
		private JassArray<int> Rh = new JassArray<int>();//integer array Rh
		private int Sh = 0;//integer Sh=0
		private int Th = 0;//integer Th=0
		private JassArray<int> Uh = new JassArray<int>();//integer array Uh
		private JassArray<int> Vh = new JassArray<int>();//integer array Vh
		private JassArray<int> Wh = new JassArray<int>();//integer array Wh
		private JassArray<int> Xh = new JassArray<int>();//integer array Xh
		private JassArray<int> Yh = new JassArray<int>();//integer array Yh
		private JassArray<int> Zh = new JassArray<int>();//integer array Zh
		private JassArray<int> di = new JassArray<int>();//integer array di
		private JassArray<int> ei = new JassArray<int>();//integer array ei
		private JassArray<int> fi = new JassArray<int>();//integer array fi
		private trigger gi;//trigger gi
		private trigger hi;//trigger hi
		private unit ii;//unit ii
		private int ji;//integer ji
		private int ki;//integer ki
		private bool mi;//boolean mi
		public static int GetUnitGoldCost(int unitid);//native GetUnitGoldCost takes integer unitid returns integer
		public static int GetUnitWoodCost(int unitid);//native GetUnitWoodCost takes integer unitid returns integer
		public static int GetUnitBuildTime(int unitid);//native GetUnitBuildTime takes integer unitid returns integer
		public static int GetUpgradeLevel(int id);//native GetUpgradeLevel takes integer id returns integer
		public static int GetUpgradeGoldCost(int id);//native GetUpgradeGoldCost takes integer id returns integer
		public static int GetUpgradeWoodCost(int id);//native GetUpgradeWoodCost takes integer id returns integer
		private int ni() {//function ni takes nothing returns integer
			int oi = ph;//local integer oi=ph
			if ((oi!=0)) {//if(oi!=0)then
				ph = rh[oi];//set ph=rh[oi]
			} else {//else
				qh = qh+1;//set qh=qh+1
				oi = qh;//set oi=qh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			wh[oi] = 0;//set wh[oi]=0
			rh[oi] = -1;//set rh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int pi() {//function pi takes nothing returns integer
			int oi = Sh;//local integer oi=Sh
			if ((oi!=0)) {//if(oi!=0)then
				Sh = Uh[oi];//set Sh=Uh[oi]
			} else {//else
				Th = Th+1;//set Th=Th+1
				oi = Th;//set oi=Th
			}//endif
			if ((oi>$CB)) {//if(oi>$CB)then
				return 0;//return 0
			}//endif
			Wh[oi] = (oi-1)*40;//set Wh[oi]=(oi-1)*40
			Yh[oi] = (oi-1)*7;//set Yh[oi]=(oi-1)*7
			di[oi] = (oi-1)*16;//set di[oi]=(oi-1)*16
			fi[oi] = (oi-1)*4;//set fi[oi]=(oi-1)*4
			Uh[oi] = -1;//set Uh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int qi() {//function qi takes nothing returns integer
			int oi = Mh;//local integer oi=Mh
			if ((oi!=0)) {//if(oi!=0)then
				Mh = Oh[oi];//set Mh=Oh[oi]
			} else {//else
				Nh = Nh+1;//set Nh=Nh+1
				oi = Nh;//set oi=Nh
			}//endif
			if ((oi>$7FE)) {//if(oi>$7FE)then
				return 0;//return 0
			}//endif
			Qh[oi] = (oi-1)*4;//set Qh[oi]=(oi-1)*4
			Oh[oi] = -1;//set Oh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int ri() {//function ri takes nothing returns integer
			int oi = Jh;//local integer oi=Jh
			if ((oi!=0)) {//if(oi!=0)then
				Jh = Lh[oi];//set Jh=Lh[oi]
			} else {//else
				Kh = Kh+1;//set Kh=Kh+1
				oi = Kh;//set oi=Kh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Lh[oi] = -1;//set Lh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int si() {//function si takes nothing returns integer
			int oi = Hh;//local integer oi=Hh
			if ((oi!=0)) {//if(oi!=0)then
				Hh = lh[oi];//set Hh=lh[oi]
			} else {//else
				Ih = Ih+1;//set Ih=Ih+1
				oi = Ih;//set oi=Ih
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			lh[oi] = -1;//set lh[oi]=-1
			return oi;//return oi
		}//endfunction
		private bool ti(int oi, unit u) {//function ti takes integer oi,unit u returns boolean
			ki = oi;//set ki=oi
			ii = u;//set ii=u
			TriggerEvaluate(Bh[Ah[oi]]);//call TriggerEvaluate(Bh[Ah[oi]])
			return mi;//return mi
		}//endfunction
		private int ui() {//function ui takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = 16;//set Ah[oi]=16
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int wi() {//function wi takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = $F;//set Ah[oi]=$F
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int xi() {//function xi takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = $E;//set Ah[oi]=$E
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int yi() {//function yi takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = $D;//set Ah[oi]=$D
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int zi() {//function zi takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = $C;//set Ah[oi]=$C
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int Ai() {//function Ai takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = $B;//set Ah[oi]=$B
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int Bi() {//function Bi takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = $A;//set Ah[oi]=$A
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int Ci() {//function Ci takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = 9;//set Ah[oi]=9
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int ci() {//function ci takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = 8;//set Ah[oi]=8
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int Di() {//function Di takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = 7;//set Ah[oi]=7
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int Ei() {//function Ei takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = 6;//set Ah[oi]=6
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private int Fi() {//function Fi takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = 5;//set Ah[oi]=5
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private void Gi(int oi, int Hi) {//function Gi takes integer oi,integer Hi returns nothing
			Eh[Fh[oi]+Gh[oi]] = Hi;//set Eh[Fh[oi]+Gh[oi]]=Hi
			Gh[oi] = Gh[oi]+1;//set Gh[oi]=Gh[oi]+1
		}//endfunction
		private int Ii() {//function Ii takes nothing returns integer
			int oi = bh;//local integer oi=bh
			if ((oi!=0)) {//if(oi!=0)then
				bh = Dh[oi];//set bh=Dh[oi]
			} else {//else
				Ch = Ch+1;//set Ch=Ch+1
				oi = Ch;//set oi=Ch
			}//endif
			if ((oi>510)) {//if(oi>510)then
				return 0;//return 0
			}//endif
			Fh[oi] = (oi-1)*16;//set Fh[oi]=(oi-1)*16
			Dh[oi] = -1;//set Dh[oi]=-1
			return oi;//return oi
		}//endfunction
		private void li(int oi) {//function li takes integer oi returns nothing
			if (oi==null ) {//if oi==null then
				return;//return
			} else if ((Dh[oi]!=-1)) {//elseif(Dh[oi]!=-1)then
				return;//return
			}//endif
			Dh[oi] = bh;//set Dh[oi]=bh
			bh = oi;//set bh=oi
		}//endfunction
		private int Ji() {//function Ji takes nothing returns integer
			int vi;//local integer vi
			int oi = xh;//local integer oi=xh
			if ((oi!=0)) {//if(oi!=0)then
				xh = zh[oi];//set xh=zh[oi]
			} else {//else
				yh = yh+1;//set yh=yh+1
				oi = yh;//set oi=yh
			}//endif
			if ((oi>8190)) {//if(oi>8190)then
				return 0;//return 0
			}//endif
			Ah[oi] = 17;//set Ah[oi]=17
			vi = oi;//set vi=oi
			zh[oi] = -1;//set zh[oi]=-1
			return oi;//return oi
		}//endfunction
		private string Ki() {//function Ki takes nothing returns string
			int i = GetRandomInt(0,o);//local integer i=GetRandomInt(0,o)
			string s = h[i];//local string s=h[i]
			h[i] = h[o];//set h[i]=h[o]
			o = o-1;//set o=o-1
			return s;//return s
		}//endfunction
		private void Li() {//function Li takes nothing returns nothing
			h[0] = "General";//set h[0]="General"
			h[1] = "FanToMace";//set h[1]="FanToMace"
			h[2] = "antiPOD";//set h[2]="antiPOD"
			h[3] = "ADMIN";//set h[3]="ADMIN"
			h[4] = "Ms Weapon";//set h[4]="Ms Weapon"
			h[5] = "C|c00ff008000l";//set h[5]="C|c00ff008000l"
			h[6] = "O|c00ff00ff:";//set h[6]="O|c00ff00ff:"
			h[7] = ":|c00ff8040O";//set h[7]=":|c00ff8040O"
			h[8] = "INqUSitor";//set h[8]="INqUSitor"
			h[9] = "Your_Death";//set h[9]="Your_Death"
			h[$A] = "Nan Yanoi";//set h[$A]="Nan Yanoi"
			h[$B] = "Impale";//set h[$B]="Impale"
			h[$C] = "Proxima";//set h[$C]="Proxima"
			h[$D] = "13|c00ff0000th";//set h[$D]="13|c00ff0000th"
			h[$E] = "Mariana";//set h[$E]="Mariana"
			h[$F] = "ProFan";//set h[$F]="ProFan"
			h[16] = "Active";//set h[16]="Active"
			h[17] = "Master";//set h[17]="Master"
			h[18] = "Nice Guy";//set h[18]="Nice Guy"
			h[19] = "Kasr'Kin";//set h[19]="Kasr'Kin"
			h[20] = "Pr0[tag]on1st";//set h[20]="Pr0[tag]on1st"
			h[21] = "Imperor";//set h[21]="Imperor"
			h[22] = "FBI agent :)";//set h[22]="FBI agent :)"
			h[23] = "Spell";//set h[23]="Spell"
			h[24] = "WTFG0D";//set h[24]="WTFG0D"
			h[25] = "Leaver :P";//set h[25]="Leaver :P"
			h[26] = "Your Windows";//set h[26]="Your Windows"
			h[27] = "GreatWarrior";//set h[27]="GreatWarrior"
			h[28] = "ShadowOfFlame";//set h[28]="ShadowOfFlame"
			h[29] = "No_Ob";//set h[29]="No_Ob"
			h[30] = "Shurf";//set h[30]="Shurf"
			h[31] = "I am WH :'(";//set h[31]="I am WH :'("
			h[32] = "CriticalError";//set h[32]="CriticalError"
			h[33] = "Brain";//set h[33]="Brain"
			h[34] = "L|c0000ff40ord";//set h[34]="L|c0000ff40ord"
			h[35] = "Princess";//set h[35]="Princess"
			o = 35;//set o=35
		}//endfunction
		private void Mi() {//function Mi takes nothing returns nothing
			int i = 0;//local integer i=0
			if ((md)) {//if(md)then
				H = 128.;//set H=128.
			} else {//else
				H = 128.*2.;//set H=128.*2.
			}//endif
			F[0] = -1.*H;//set F[0]=-1.*H
			G[0] = 1.*H;//set G[0]=1.*H
			F[1] = -1.*H;//set F[1]=-1.*H
			G[1] = -1.*H;//set G[1]=-1.*H
			F[2] = 1.*H;//set F[2]=1.*H
			G[2] = -1.*H;//set G[2]=-1.*H
			F[3] = 1.*H;//set F[3]=1.*H
			G[3] = 1.*H;//set G[3]=1.*H
			D[0] = 5568.;//set D[0]=5568.
			E[0] = 512.;//set E[0]=512.
			D[1] = 5568.;//set D[1]=5568.
			E[1] = -1.*512.;//set E[1]=-1.*512.
			D[2] = -1.*5568.;//set D[2]=-1.*5568.
			E[2] = -1.*512.;//set E[2]=-1.*512.
			D[3] = -1.*5568.;//set D[3]=-1.*5568.
			E[3] = 512.;//set E[3]=512.
			while (true) {//loop
				C[i] = E[i];//set C[i]=E[i]
				i = i+1;//set i=i+1
				if (i>3) { break; }//exitwhen i>3
			}//endloop
		}//endfunction
		private void Ni() {//function Ni takes nothing returns nothing
			int i = 0;//local integer i=0
			H = 128.;//set H=128.
			F[0] = -1.*H;//set F[0]=-1.*H
			G[0] = 1.*H;//set G[0]=1.*H
			F[1] = -1.*H;//set F[1]=-1.*H
			G[1] = -1.*H;//set G[1]=-1.*H
			F[2] = 1.*H;//set F[2]=1.*H
			G[2] = -1.*H;//set G[2]=-1.*H
			F[3] = 1.*H;//set F[3]=1.*H
			G[3] = 1.*H;//set G[3]=1.*H
			D[0] = 5568.;//set D[0]=5568.
			E[0] = 512.;//set E[0]=512.
			D[1] = 5568.;//set D[1]=5568.
			E[1] = -1.*512.;//set E[1]=-1.*512.
			D[2] = -1.*5568.;//set D[2]=-1.*5568.
			E[2] = -1.*512.;//set E[2]=-1.*512.
			D[3] = -1.*5568.;//set D[3]=-1.*5568.
			E[3] = 512.;//set E[3]=512.
			while (true) {//loop
				C[i] = E[i];//set C[i]=E[i]
				i = i+1;//set i=i+1
				if (i>3) { break; }//exitwhen i>3
			}//endloop
		}//endfunction
		private void Oi(int Pi) {//function Oi takes integer Pi returns nothing
			A = D[Pi];//set A=D[Pi]
			B = E[Pi];//set B=E[Pi]
		}//endfunction
		private void Qi(int Pi) {//function Qi takes integer Pi returns nothing
			E[Pi] = E[Pi]+(G[Pi]);//set E[Pi]=E[Pi]+(G[Pi])
			if ((RAbsBJ(E[Pi])>1920.)) {//if(RAbsBJ(E[Pi])>1920.)then
				D[Pi] = D[Pi]+(F[Pi]);//set D[Pi]=D[Pi]+(F[Pi])
				if ((RAbsBJ(D[Pi])<1664.)) {//if(RAbsBJ(D[Pi])<1664.)then
					Ni();//call Ni()
					return;//return
				}//endif
				E[Pi] = C[Pi];//set E[Pi]=C[Pi]
			}//endif
		}//endfunction
		private void Ri() {//function Ri takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u=GetEnumUnit()
			I = I+(GetUnitX(u));//set I=I+(GetUnitX(u))
			J = J+(GetUnitY(u));//set J=J+(GetUnitY(u))
			K = K+1;//set K=K+1
			u = null;//set u=null
		}//endfunction
		private bool Si(unit Ti, unit Ui) {//function Si takes unit Ti,unit Ui returns boolean
			r4 = GetOwningPlayer(Ui);//set r4=GetOwningPlayer(Ui)
			if ((IsPlayerInForce(r4,ie))) {//if(IsPlayerInForce(r4,ie))then
				DisplayTextToForce(ie, pe[GetPlayerId(GetOwningPlayer(Ti))]+": I'm going to use RS!!!");//call DisplayTextToForce(ie,pe[GetPlayerId(GetOwningPlayer(Ti))]+": I'm going to use RS!!!")
			} else if ((IsPlayerInForce(r4,je))) {//elseif(IsPlayerInForce(r4,je))then
				DisplayTextToForce(je, pe[GetPlayerId(GetOwningPlayer(Ti))]+": I'm going to use RS!!!");//call DisplayTextToForce(je,pe[GetPlayerId(GetOwningPlayer(Ti))]+": I'm going to use RS!!!")
			}//endif
			GroupEnumUnitsInRange(q4, GetUnitX(Ui), GetUnitY(Ui), 1690.1, y9);//call GroupEnumUnitsInRange(q4,GetUnitX(Ui),GetUnitY(Ui),1690.1,y9)
			I = .0;//set I=.0
			J = .0;//set J=.0
			K = 0;//set K=0
			ForGroup(q4, function Ri);//call ForGroup(q4,function Ri)
			if ((K!=0)) {//if(K!=0)then
				I = I/(K);//set I=I/(K)
				J = J/(K);//set J=J/(K)
				return IssuePointOrderById(Ti,$D0208,I,J);//return IssuePointOrderById(Ti,$D0208,I,J)
			}//endif
			return false;//return false
		}//endfunction
		private void Vi() {//function Vi takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				RemoveItem(M[i]);//call RemoveItem(M[i])
				i = i+1;//set i=i+1
				if (i>=N) { break; }//exitwhen i>=N
			}//endloop
			TimerStart(L, 31.25, false, O);//call TimerStart(L,31.25,false,O)
		}//endfunction
		private void Wi() {//function Wi takes nothing returns nothing
			int i = 0;//local integer i=0
			P = P+(3.);//set P=P+(3.)
			while (true) {//loop
				M[i] = CreateItem(808470823,GetRandomReal(GetRectMinX(Dg),GetRectMaxX(Dg)),GetRandomReal(GetRectMinY(Dg),GetRectMaxY(Dg)));//set M[i]=CreateItem('I000',GetRandomReal(GetRectMinX(Dg),GetRectMaxX(Dg)),GetRandomReal(GetRectMinY(Dg),GetRectMaxY(Dg)))
				DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Demon\\DarkPortal\\DarkPortalTarget.mdl", GetItemX(M[i]), GetItemY(M[i])));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Demon\\DarkPortal\\DarkPortalTarget.mdl",GetItemX(M[i]),GetItemY(M[i])))
				M[i+1] = CreateItem(808470823,GetRandomReal(GetRectMinX(cg),GetRectMaxX(cg)),GetRandomReal(GetRectMinY(cg),GetRectMaxY(cg)));//set M[i+1]=CreateItem('I000',GetRandomReal(GetRectMinX(cg),GetRectMaxX(cg)),GetRandomReal(GetRectMinY(cg),GetRectMaxY(cg)))
				DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Demon\\DarkPortal\\DarkPortalTarget.mdl", GetItemX(M[i+1]), GetItemY(M[i+1])));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Demon\\DarkPortal\\DarkPortalTarget.mdl",GetItemX(M[i+1]),GetItemY(M[i+1])))
				i = i+(2);//set i=i+(2)
				if (i>=N) { break; }//exitwhen i>=N
			}//endloop
			TimerStart(L, 4.75, false, function Vi);//call TimerStart(L,4.75,false,function Vi)
		}//endfunction
		private void Xi() {//function Xi takes nothing returns nothing
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffFFFF80Bounty incoming!|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffFFFF80Bounty incoming!|r")
			TimerStart(L, 4., false, function Wi);//call TimerStart(L,4.,false,function Wi)
		}//endfunction
		private void Yi(player p) {//function Yi takes player p returns nothing
			int id = GetPlayerId(p);//local integer id=GetPlayerId(p)
			int Zi = R2I((I2R(ge[id])+4.)*.25*(8.+P));//local integer Zi=R2I((I2R(ge[id])+4.)*.25*(8.+P))
			Yd[id] = Yd[id]+1;//set Yd[id]=Yd[id]+1
			DisplayTextToPlayer(p, .0, .0, "|cffFFFF80You found |cffFFFF00"+I2S(Zi)+"|cffFFFF80 gold!|r");//call DisplayTextToPlayer(p,.0,.0,"|cffFFFF80You found |cffFFFF00"+I2S(Zi)+"|cffFFFF80 gold!|r")
			Zd[id] = Zd[id]+(Zi);//set Zd[id]=Zd[id]+(Zi)
			AdjustPlayerStateBJ(Zi, p, PLAYER_STATE_RESOURCE_GOLD);//call AdjustPlayerStateBJ(Zi,p,PLAYER_STATE_RESOURCE_GOLD)
		}//endfunction
		private void dj(bool ej) {//function dj takes boolean ej returns nothing
			if ((L==null)) {//if(L==null)then
				return;//return
			}//endif
			PauseTimer(L);//call PauseTimer(L)
			if ((ej)) {//if(ej)then
				DestroyTimer(L);//call DestroyTimer(L)
				L = null;//set L=null
			}//endif
		}//endfunction
		private void fj() {//function fj takes nothing returns nothing
			int i = 0;//local integer i=0
			if ((Cd<=0)) {//if(Cd<=0)then
				return;//return
			}//endif
			if ((L==null)) {//if(L==null)then
				L = CreateTimer();//set L=CreateTimer()
				N = Cd*2;//set N=Cd*2
			}//endif
			P = .0;//set P=.0
			while (true) {//loop
				Q[i] = -1;//set Q[i]=-1
				i = i+1;//set i=i+1
				if (i>=4) { break; }//exitwhen i>=4
			}//endloop
			Q[4] = 0;//set Q[4]=0
			Q[5] = 0;//set Q[5]=0
			TimerStart(L, 40., false, function Xi);//call TimerStart(L,40.,false,function Xi)
		}//endfunction
		private void gj() {//function gj takes nothing returns nothing
			L = null;//set L=null
			O = function Xi;//set O=function Xi
		}//endfunction
		private bool hj() {//function hj takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool b = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER);//local boolean b=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)
			u = null;//set u=null
			return b;//return b
		}//endfunction
		private void ij() {//function ij takes nothing returns nothing
			int i = 0;//local integer i=0
			float x;//local real x
			float y;//local real y
			float an;//local real an
			unit u;//local unit u
			unit j;//local unit j
			while (true) {//loop
				if (i>=W) { break; }//exitwhen i>=W
				an = GetUnitFacing(S[i])*bj_DEGTORAD;//set an=GetUnitFacing(S[i])*bj_DEGTORAD
				x = GetUnitX(S[i])+26.*Cos(an);//set x=GetUnitX(S[i])+26.*Cos(an)
				y = GetUnitY(S[i])+26.*Sin(an);//set y=GetUnitY(S[i])+26.*Sin(an)
				SetUnitX(S[i], x);//call SetUnitX(S[i],x)
				SetUnitY(S[i], y);//call SetUnitY(S[i],y)
				r4 = GetOwningPlayer(S[i]);//set r4=GetOwningPlayer(S[i])
				GroupEnumUnitsInRange(q4, x, y, 34., X);//call GroupEnumUnitsInRange(q4,x,y,34.,X)
				u = FirstOfGroup(q4);//set u=FirstOfGroup(q4)
				if ((u!=null)) {//if(u!=null)then
					UnitDamageTarget(S[i], u, U[i], true, false, ATTACK_TYPE_MAGIC, DAMAGE_TYPE_COLD, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(S[i],u,U[i],true,false,ATTACK_TYPE_MAGIC,DAMAGE_TYPE_COLD,WEAPON_TYPE_WHOKNOWS)
					j = CreateUnit(GetOwningPlayer(S[i]),808477991,x,y,.0);//set j=CreateUnit(GetOwningPlayer(S[i]),'e008',x,y,.0)
					UnitAddAbility(j, 'A043');//call UnitAddAbility(j,'A043')
					SetUnitAbilityLevel(j, 'A043', V[i]);//call SetUnitAbilityLevel(j,'A043',V[i])
					IssueTargetOrderById(j, $D0102, u);//call IssueTargetOrderById(j,$D0102,u)
					UnitApplyTimedLife(j, 'BTLF', 1.);//call UnitApplyTimedLife(j,'BTLF',1.)
					j = null;//set j=null
				}//endif
				T[i] = T[i]-(26.);//set T[i]=T[i]-(26.)
				if ((T[i]<=.0 || u!=null)) {//if(T[i]<=.0 or u!=null)then
					W = W-1;//set W=W-1
					KillUnit(S[i]);//call KillUnit(S[i])
					S[i] = S[W];//set S[i]=S[W]
					T[i] = T[W];//set T[i]=T[W]
					V[i] = V[W];//set V[i]=V[W]
					U[i] = U[W];//set U[i]=U[W]
					u = null;//set u=null
				} else {//else
					i = i+1;//set i=i+1
				}//endif
			}//endloop
			if ((W<=0)) {//if(W<=0)then
				PauseTimer(R);//call PauseTimer(R)
			}//endif
		}//endfunction
		private void jj(unit u, int kj, float mj, int nj) {//function jj takes unit u,integer kj,real mj,integer nj returns nothing
			player p = GetOwningPlayer(u);//local player p=GetOwningPlayer(u)
			float an = GetUnitFacing(u)-45.;//local real an=GetUnitFacing(u)-45.
			float oj = an+90.;//local real oj=an+90.
			float x = GetUnitX(u);//local real x=GetUnitX(u)
			float y = GetUnitY(u);//local real y=GetUnitY(u)
			int i = 0;//local integer i=0
			while (true) {//loop
				S[W] = CreateUnit(p,909142055,x,y,GetRandomReal(an,oj));//set S[W]=CreateUnit(p,'h068',x,y,GetRandomReal(an,oj))
				T[W] = 500.;//set T[W]=500.
				U[W] = mj;//set U[W]=mj
				V[W] = nj;//set V[W]=nj
				if ((W==0)) {//if(W==0)then
					TimerStart(R, .03, true, function ij);//call TimerStart(R,.03,true,function ij)
				}//endif
				W = W+1;//set W=W+1
				i = i+1;//set i=i+1
				TriggerSleepAction(.04);//call TriggerSleepAction(.04)
				if (i>=kj) { break; }//exitwhen i>=kj
			}//endloop
		}//endfunction
		private void pj() {//function pj takes nothing returns nothing
			X = Filter(function hj);//set X=Filter(function hj)
		}//endfunction
		private void qj() {//function qj takes nothing returns nothing
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Icy Environment|r has been selected. Note that a custom environment has no influence on gameplay.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Icy Environment|r has been selected. Note that a custom environment has no influence on gameplay.")
			h4[0] = 1935821095;//set h4[0]='Ibsq'
			h4[1] = 1667844391;//set h4[1]='Iice'
			h4[2] = 1853049127;//set h4[2]='Isnw'
			h4[3] = 1801734439;//set h4[3]='Idki'
			h4[4] = 1853050407;//set h4[4]='Nsnw'
			h4[5] = 1853050407;//set h4[5]='Nsnr'
			h4[6] = 1651656999;//set h4[6]='Irbk'
			h4[7] = 1853050407;//set h4[7]='Nsnw'
			i4[0] = 1951680807;//set i4[0]='ITtw'
			j4[0] = $A;//set j4[0]=$A
			i4[1] = 1951680807;//set i4[1]='ITtc'
			j4[1] = 3;//set j4[1]=3
			k4[0] = 808469031;//set k4[0]='B00M'
			n4[0] = .5;//set n4[0]=.5
			m4[0] = .0;//set m4[0]=.0
			k4[1] = 808469031;//set k4[1]='B00N'
			n4[1] = .5;//set n4[1]=.5
			m4[1] = .0;//set m4[1]=.0
			k4[2] = 808469031;//set k4[2]='B00O'
			n4[2] = .5;//set n4[2]=.5
			m4[2] = .0;//set m4[2]=.0
			k4[3] = 808469031;//set k4[3]='B00P'
			n4[3] = .5;//set n4[3]=.5
			m4[3] = .0;//set m4[3]=.0
			k4[4] = 808469031;//set k4[4]='B00G'
			n4[4] = .97;//set n4[4]=.97
			m4[4] = -30.;//set m4[4]=-30.
			SetTerrainFogExBJ(0, 1200., 6000., 0, 80., 80., 100.);//call SetTerrainFogExBJ(0,1200.,6000.,0,80.,80.,100.)
		}//endfunction
		private void rj() {//function rj takes nothing returns nothing
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Lava Environment|r has been selected. Note that a custom environment has no influence on gameplay.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Lava Environment|r has been selected. Note that a custom environment has no influence on gameplay.")
			h4[0] = 1801733159;//set h4[0]='Ddkr'
			h4[1] = 1919370279;//set h4[1]='Dgrs'
			h4[2] = 1986806823;//set h4[2]='Dlvc'
			h4[3] = 1634485287;//set h4[3]='Dlav'
			h4[4] = 1685210151;//set h4[4]='Drds'
			h4[5] = 1919173671;//set h4[5]='Ddrt'
			h4[6] = 1903379495;//set h4[6]='Dsqd'
			h4[7] = 1919370279;//set h4[7]='Dgrs'
			i4[0] = 808469031;//set i4[0]='B001'
			j4[0] = 8;//set j4[0]=8
			i4[1] = 808469031;//set i4[1]='B000'
			j4[1] = $A;//set j4[1]=$A
			k4[0] = 808469031;//set k4[0]='B00H'
			n4[0] = 1.1;//set n4[0]=1.1
			m4[0] = .0;//set m4[0]=.0
			k4[1] = 808469031;//set k4[1]='B00J'
			n4[1] = 1.1;//set n4[1]=1.1
			m4[1] = .0;//set m4[1]=.0
			k4[2] = 808469031;//set k4[2]='B00K'
			n4[2] = 1.1;//set n4[2]=1.1
			m4[2] = .0;//set m4[2]=.0
			k4[3] = 808469031;//set k4[3]='B00L'
			n4[3] = 1.1;//set n4[3]=1.1
			m4[3] = .0;//set m4[3]=.0
			k4[4] = 808469031;//set k4[4]='B00I'
			n4[4] = 1.;//set n4[4]=1.
			m4[4] = -70.;//set m4[4]=-70.
			SetTerrainFogExBJ(0, $3E8, 3000., 0, 50., .0, .0);//call SetTerrainFogExBJ(0,$3E8,3000.,0,50.,.0,.0)
			SetWaterBaseColorBJ('d', .0, .0, 0);//call SetWaterBaseColorBJ('d',.0,.0,0)
		}//endfunction
		private void sj() {//function sj takes nothing returns nothing
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Icy Environment|r has been selected. Note that a custom environment has no influence on gameplay.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Icy Environment|r has been selected. Note that a custom environment has no influence on gameplay.")
			h4[0] = 1935821095;//set h4[0]='Ibsq'
			h4[1] = 1667844391;//set h4[1]='Iice'
			h4[2] = 1853049127;//set h4[2]='Isnw'
			h4[3] = 1801734439;//set h4[3]='Idki'
			h4[4] = 1853050407;//set h4[4]='Nsnw'
			h4[5] = 1853050407;//set h4[5]='Nsnr'
			h4[6] = 1651656999;//set h4[6]='Irbk'
			h4[7] = 1853050407;//set h4[7]='Nsnw'
			i4[0] = 1951680807;//set i4[0]='ITtw'
			j4[0] = $A;//set j4[0]=$A
			i4[1] = 1951680807;//set i4[1]='ITtc'
			j4[1] = 3;//set j4[1]=3
			k4[0] = 808469031;//set k4[0]='B007'
			n4[0] = 1.2;//set n4[0]=1.2
			m4[0] = .0;//set m4[0]=.0
			k4[1] = 808469031;//set k4[1]='B008'
			n4[1] = 1.2;//set n4[1]=1.2
			m4[1] = .0;//set m4[1]=.0
			k4[2] = 808469031;//set k4[2]='B009'
			n4[2] = 1.2;//set n4[2]=1.2
			m4[2] = .0;//set m4[2]=.0
			k4[3] = 808469031;//set k4[3]='B00A'
			n4[3] = 1.2;//set n4[3]=1.2
			m4[3] = .0;//set m4[3]=.0
			k4[4] = 808469031;//set k4[4]='B00G'
			n4[4] = .97;//set n4[4]=.97
			m4[4] = -30.;//set m4[4]=-30.
		}//endfunction
		private void tj() {//function tj takes nothing returns nothing
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Barrens Environment|r has been selected. Note that a custom environment has no influence on gameplay.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Barrens Environment|r has been selected. Note that a custom environment has no influence on gameplay.")
			h4[0] = 1735150375;//set h4[0]='Klgb'
			h4[1] = 1919176487;//set h4[1]='Odrt'
			h4[2] = 1919173159;//set h4[2]='Bdrt'
			h4[3] = 1936084775;//set h4[3]='Ofst'
			h4[4] = 1919173159;//set h4[4]='Bdrh'
			h4[5] = 1919369767;//set h4[5]='Bgrr'
			h4[6] = 1935950375;//set h4[6]='Bdsd'
			h4[7] = 1919173159;//set h4[7]='Bdrr'
			i4[0] = 1951680807;//set i4[0]='ITtw'
			j4[0] = $A;//set j4[0]=$A
			i4[1] = 1951680807;//set i4[1]='ITtc'
			j4[1] = 3;//set j4[1]=3
			k4[0] = 808469031;//set k4[0]='B007'
			n4[0] = 1.2;//set n4[0]=1.2
			m4[0] = .0;//set m4[0]=.0
			k4[1] = 808469031;//set k4[1]='B008'
			n4[1] = 1.2;//set n4[1]=1.2
			m4[1] = .0;//set m4[1]=.0
			k4[2] = 808469031;//set k4[2]='B009'
			n4[2] = 1.2;//set n4[2]=1.2
			m4[2] = .0;//set m4[2]=.0
			k4[3] = 808469031;//set k4[3]='B00A'
			n4[3] = 1.2;//set n4[3]=1.2
			m4[3] = .0;//set m4[3]=.0
			k4[4] = 808469031;//set k4[4]='B00G'
			n4[4] = .97;//set n4[4]=.97
			m4[4] = -30.;//set m4[4]=-30.
			SetTerrainFogEx(0, 1000., 8000., .0, .686, .369, .098);//call SetTerrainFogEx(0,1000.,8000.,.0,.686,.369,.098)
			SetAmbientDaySound("BarrensDay");//call SetAmbientDaySound("BarrensDay")
			SetAmbientNightSound("BarrensNight");//call SetAmbientNightSound("BarrensNight")
		}//endfunction
		private void uj() {//function uj takes nothing returns nothing
			destructable vj = GetEnumDestructable();//local destructable vj=GetEnumDestructable()
			int i = 0;//local integer i=0
			float x;//local real x
			float y;//local real y
			float z;//local real z
			location l;//local location l
			while (true) {//loop
				if (i>1) { break; }//exitwhen i>1
				if (GetDestructableTypeId(vj)==f4[i]) {//if GetDestructableTypeId(vj)==f4[i]then
					x = GetDestructableX(vj);//set x=GetDestructableX(vj)
					y = GetDestructableY(vj);//set y=GetDestructableY(vj)
					RemoveDestructable(vj);//call RemoveDestructable(vj)
					CreateDestructable(i4[i], x, y, GetRandomReal(.0, 360.), 1, GetRandomInt(0, j4[i]-1));//call CreateDestructable(i4[i],x,y,GetRandomReal(.0,360.),1,GetRandomInt(0,j4[i]-1))
					return;//return
				}//endif
				i = i+1;//set i=i+1
			}//endloop
			i = 0;//set i=0
			while (true) {//loop
				if (i>4) { break; }//exitwhen i>4
				if (GetDestructableTypeId(vj)==g4[i]) {//if GetDestructableTypeId(vj)==g4[i]then
					x = GetDestructableX(vj);//set x=GetDestructableX(vj)
					y = GetDestructableY(vj);//set y=GetDestructableY(vj)
					l = GetDestructableLoc(vj);//set l=GetDestructableLoc(vj)
					z = GetLocationZ(l);//set z=GetLocationZ(l)
					RemoveLocation(l);//call RemoveLocation(l)
					l = null;//set l=null
					RemoveDestructable(vj);//call RemoveDestructable(vj)
					CreateDestructableZ(k4[i], x, y, m4[i]+z, 0, n4[i], 1);//call CreateDestructableZ(k4[i],x,y,m4[i]+z,0,n4[i],1)
					return;//return
				}//endif
				i = i+1;//set i=i+1
			}//endloop
			vj = null;//set vj=null
		}//endfunction
		private void wj() {//function wj takes nothing returns nothing
			float x = 0;//local real x=0
			float y = d4*512;//local real y=d4*512
			float zG;//local real zG
			float ZG;//local real ZG
			int i;//local integer i
			int j;//local integer j
			if ((d4<50)) {//if(d4<50)then
				while (true) {//loop
					if ((y>o4)) { break; }//exitwhen(y>o4)
					x = 0;//set x=0
					while (true) {//loop
						if ((x>p4)) { break; }//exitwhen(x>p4)
						i = 0;//set i=0
						while (true) {//loop
							if (i>3) { break; }//exitwhen i>3
							zG = I2R((i/ 2)*2-1)*x;//set zG=I2R((i/ 2)*2-1)*x
							ZG = I2R(ModuloInteger(i,2)*2-1)*y;//set ZG=I2R(ModuloInteger(i,2)*2-1)*y
							j = 0;//set j=0
							while (true) {//loop
								if (j>7) { break; }//exitwhen j>7
								if ((GetTerrainType(zG,ZG)==e4[j])) {//if(GetTerrainType(zG,ZG)==e4[j])then
									SetTerrainType(zG, ZG, h4[j], -1, 1, 0);//call SetTerrainType(zG,ZG,h4[j],-1,1,0)
									if (true) { break; }//exitwhen true
								}//endif
								j = j+1;//set j=j+1
							}//endloop
							i = i+1;//set i=i+1
						}//endloop
						x = x+$80;//set x=x+$80
					}//endloop
					y = y+$80;//set y=y+$80
					if ((ModuloReal(y,512)==0)) {//if(ModuloReal(y,512)==0)then
						d4 = d4+1;//set d4=d4+1
						TimerStart(Y, .0, false, function wj);//call TimerStart(Y,.0,false,function wj)
						return;//return
					}//endif
				}//endloop
				d4 = 50;//set d4=50
				TimerStart(Y, .0, false, function wj);//call TimerStart(Y,.0,false,function wj)
				return;//return
			} else if (d4==50 ) {//elseif d4==50 then
				j = 0;//set j=0
				while (true) {//loop
					if (j>6) { break; }//exitwhen j>6
					e4[j] = h4[j];//set e4[j]=h4[j]
					j = j+1;//set j=j+1
				}//endloop
				EnumDestructablesInRectAll(bj_mapInitialPlayableArea, function uj);//call EnumDestructablesInRectAll(bj_mapInitialPlayableArea,function uj)
				j = 0;//set j=0
				while (true) {//loop
					if (j>1) { break; }//exitwhen j>1
					f4[j] = i4[j];//set f4[j]=i4[j]
					j = j+1;//set j=j+1
				}//endloop
				j = 0;//set j=0
				while (true) {//loop
					if (j>4) { break; }//exitwhen j>4
					g4[j] = k4[j];//set g4[j]=k4[j]
					j = j+1;//set j=j+1
				}//endloop
				DestroyTimer(Y);//call DestroyTimer(Y)
				Y = null;//set Y=null
			}//endif
		}//endfunction
		private void xj(int yj) {//function xj takes integer yj returns nothing
			if ((Z)) {//if(Z)then
				DisplayTextToPlayer(Player(0), 0, 0, "You have already chosen an environment!");//call DisplayTextToPlayer(Player(0),0,0,"You have already chosen an environment!")
				return;//return
			}//endif
			Z = true;//set Z=true
			Y = CreateTimer();//set Y=CreateTimer()
			d4 = 0;//set d4=0
			o4 = GetRectMaxY(C9);//set o4=GetRectMaxY(C9)
			p4 = GetRectMaxX(C9);//set p4=GetRectMaxX(C9)
			e4[0] = 1953715751;//set e4[0]='Vstp'
			e4[1] = 1919172903;//set e4[1]='Adrt'
			e4[2] = 1919172903;//set e4[2]='Adrg'
			e4[3] = 1919369511;//set e4[3]='Agrs'
			e4[4] = 1919369511;//set e4[4]='Agrd'
			e4[5] = 1986806055;//set e4[5]='Alvd'
			e4[6] = 1952733735;//set e4[6]='Zdtr'
			e4[7] = 1769357607;//set e4[7]='Avin'
			f4[0] = 1951678759;//set f4[0]='ATtr'
			f4[1] = 1951678759;//set f4[1]='ATtc'
			g4[0] = 808469031;//set g4[0]='B002'
			g4[1] = 808469031;//set g4[1]='B003'
			g4[2] = 808469031;//set g4[2]='B004'
			g4[3] = 808469031;//set g4[3]='B005'
			g4[4] = 808469031;//set g4[4]='B006'
			if ((yj==0)) {//if(yj==0)then
				qj();//call qj()
			} else if ((yj==1)) {//elseif(yj==1)then
				rj();//call rj()
			} else if ((yj==2)) {//elseif(yj==2)then
				sj();//call sj()
			} else if ((yj==3)) {//elseif(yj==3)then
				tj();//call tj()
			}//endif
			TimerStart(Y, .0, false, function wj);//call TimerStart(Y,.0,false,function wj)
		}//endfunction
		private void zj(int Aj, int aj) {//function zj takes integer Aj,integer aj returns nothing
			x4[GetUnitPointValueByType(Aj)] = aj;//set x4[GetUnitPointValueByType(Aj)]=aj
		}//endfunction
		private void Bj(unit u, int bj, float an, float x, float y) {//function Bj takes unit u,integer bj,real an,real x,real y returns nothing
			int Cj = GetUnitUserData(u);//local integer Cj=GetUnitUserData(u)
			float mx = GetUnitX(u)+x;//local real mx=GetUnitX(u)+x
			float my = GetUnitY(u)+y;//local real my=GetUnitY(u)+y
			unit v = CreateUnit(GetOwningPlayer(u),bj,mx,my,an);//local unit v=CreateUnit(GetOwningPlayer(u),bj,mx,my,an)
			SetUnitPathing(v, false);//call SetUnitPathing(v,false)
			SetUnitX(v, mx);//call SetUnitX(v,mx)
			SetUnitY(v, my);//call SetUnitY(v,my)
			SaveUnitHandle(O9, GetHandleId(u), Cj, v);//call SaveUnitHandle(O9,GetHandleId(u),Cj,v)
			v = null;//set v=null
			SetUnitUserData(u, Cj+1);//call SetUnitUserData(u,Cj+1)
		}//endfunction
		private void cj(unit u) {//function cj takes unit u returns nothing
			int Dj = GetUnitUserData(u);//local integer Dj=GetUnitUserData(u)
			int Ej = GetHandleId(u);//local integer Ej=GetHandleId(u)
			if ((Dj>0)) {//if(Dj>0)then
				while (true) {//loop
					Dj = Dj-1;//set Dj=Dj-1
					RemoveUnit(LoadUnitHandle(O9, Ej, Dj));//call RemoveUnit(LoadUnitHandle(O9,Ej,Dj))
					if (Dj<=0) { break; }//exitwhen Dj<=0
				}//endloop
			}//endif
		}//endfunction
		private void Fj(int Aj, code Gj) {//function Fj takes integer Aj,code Gj returns nothing
			int id = GetUnitPointValueByType(Aj);//local integer id=GetUnitPointValueByType(Aj)
			y4[id] = CreateTrigger();//set y4[id]=CreateTrigger()
			TriggerAddCondition(y4[id], Condition(Gj));//call TriggerAddCondition(y4[id],Condition(Gj))
		}//endfunction
		private void Hj(unit u) {//function Hj takes unit u returns nothing
			int id = GetUnitPointValue(u);//local integer id=GetUnitPointValue(u)
			if ((y4[id]!=null)) {//if(y4[id]!=null)then
				z4 = u;//set z4=u
				TriggerEvaluate(y4[id]);//call TriggerEvaluate(y4[id])
			}//endif
		}//endfunction
		private void Ij(int Aj, float r) {//function Ij takes integer Aj,real r returns nothing
			A4[GetUnitPointValueByType(Aj)] = r;//set A4[GetUnitPointValueByType(Aj)]=r
		}//endfunction
		private void lj(int Aj, code Jj) {//function lj takes integer Aj,code Jj returns nothing
			int id = GetUnitPointValueByType(Aj);//local integer id=GetUnitPointValueByType(Aj)
			a4[id] = CreateTrigger();//set a4[id]=CreateTrigger()
			TriggerAddAction(a4[id], Jj);//call TriggerAddAction(a4[id],Jj)
		}//endfunction
		private void Kj(unit u) {//function Kj takes unit u returns nothing
			int id = GetUnitPointValue(u);//local integer id=GetUnitPointValue(u)
			if ((a4[id]!=null)) {//if(a4[id]!=null)then
				B4 = u;//set B4=u
				TriggerExecute(a4[id]);//call TriggerExecute(a4[id])
			}//endif
		}//endfunction
		private void Lj(int Aj, int Mj, code Gj) {//function Lj takes integer Aj,integer Mj,code Gj returns nothing
			int id = GetUnitPointValueByType(Aj);//local integer id=GetUnitPointValueByType(Aj)
			b4[id] = CreateTrigger();//set b4[id]=CreateTrigger()
			TriggerAddAction(b4[id], Gj);//call TriggerAddAction(b4[id],Gj)
			C4[id] = Mj;//set C4[id]=Mj
		}//endfunction
		private void Nj(unit u, int Mj, unit t) {//function Nj takes unit u,integer Mj,unit t returns nothing
			int id = GetUnitPointValue(u);//local integer id=GetUnitPointValue(u)
			if ((b4[id]!=null && Mj==C4[id])) {//if(b4[id]!=null and Mj==C4[id])then
				c4 = u;//set c4=u
				D4 = t;//set D4=t
				TriggerExecute(b4[id]);//call TriggerExecute(b4[id])
			}//endif
		}//endfunction
		private void Oj() {//function Oj takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h008')
			t4[id] = 350;//set t4[id]=350
			u4[id] = 350*.09/ 100.;//set u4[id]=350*.09/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void Pj(string s) {//function Pj takes string s returns nothing
			string Qj = I2S(G4);//local string Qj=I2S(G4)
			if ((G4<$A)) {//if(G4<$A)then
				Qj = "0"+Qj;//set Qj="0"+Qj
			}//endif
			E4[F4] = E4[F4]+("["+I2S(H4)+":"+Qj+"] "+s+"");//set E4[F4]=E4[F4]+("["+I2S(H4)+":"+Qj+"] "+s+"")
			if ((StringLength(E4[F4])>=I4)) {//if(StringLength(E4[F4])>=I4)then
				F4 = F4+1;//set F4=F4+1
			}//endif
		}//endfunction
		private void LogClear() {//function LogClear takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if (not(i<=F4)) { break; }//exitwhen not(i<=F4)
				E4[i] = "";//set E4[i]=""
				i = i+1;//set i=i+1
			}//endloop
			F4 = 0;//set F4=0
		}//endfunction
		private void Rj() {//function Rj takes nothing returns nothing
			int i = 0;//local integer i=0
			PreloadGenClear();//call PreloadGenClear()
			PreloadGenStart();//call PreloadGenStart()
			while (true) {//loop
				if (not(i<=F4)) { break; }//exitwhen not(i<=F4)
				Preload("\")"+E4[i]+"(\"");//call Preload("\")"+E4[i]+"(\"")
				i = i+1;//set i=i+1
			}//endloop
			PreloadGenEnd("Replay\\LastReplay.log");//call PreloadGenEnd("Replay\\LastReplay.log")
		}//endfunction
		private void Sj(string Tj, string Jj, string Uj) {//function Sj takes string Tj,string Jj,string Uj returns nothing
			Pj("DEBUG ("+Jj+" at "+Tj+"): "+Uj);//call Pj("DEBUG ("+Jj+" at "+Tj+"): "+Uj)
			Rj();//call Rj()
		}//endfunction
		private void Vj() {//function Vj takes nothing returns nothing
			G4 = G4+1;//set G4=G4+1
			if ((G4>59)) {//if(G4>59)then
				G4 = 0;//set G4=0
				H4 = H4+1;//set H4=H4+1
			}//endif
		}//endfunction
		private void Wj() {//function Wj takes nothing returns nothing
			TimerStart(CreateTimer(), 1., true, function Vj);//call TimerStart(CreateTimer(),1.,true,function Vj)
			Pj("Castle Fight ES game log");//call Pj("Castle Fight ES game log")
			Pj("Map compilation: 2012.04.15 03:35:50");//call Pj("Map compilation: 2012.04.15 03:35:50")
			Rj();//call Rj()
		}//endfunction
		private void Xj() {//function Xj takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((GetPlayerController(Player(i))==MAP_CONTROL_USER && GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING  && (IsPlayerInForce(Player(i),ie) || IsPlayerInForce(Player(i),je)))) {//if(GetPlayerController(Player(i))==MAP_CONTROL_USER and GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING and(IsPlayerInForce(Player(i),ie)or IsPlayerInForce(Player(i),je)))then
					J4[i] = true;//set J4[i]=true
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			l4 = false;//set l4=false
		}//endfunction
		private bool Yj() {//function Yj takes nothing returns boolean
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((J4[i])) {//if(J4[i])then
					return false;//return false
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			l4 = true;//set l4=true
			return true;//return true
		}//endfunction
		private void Zj(int dk) {//function Zj takes integer dk returns nothing
			if ((l4)) {//if(l4)then
				return;//return
			}//endif
			if ((J4[dk])) {//if(J4[dk])then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" has voted for a draw!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" has voted for a draw!")
				J4[dk] = false;//set J4[dk]=false
				if ((Yj())) {//if(Yj())then
					TriggerExecute(jg);//call TriggerExecute(jg)
				}//endif
			} else {//else
				DisplayTextToPlayer(Player(dk), .0, .0, "|cffFF0000You have already voted for a draw!|r");//call DisplayTextToPlayer(Player(dk),.0,.0,"|cffFF0000You have already voted for a draw!|r")
			}//endif
		}//endfunction
		private bool ek() {//function ek takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool b = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_GROUND) && IsUnitType(u,UNIT_TYPE_SAPPER);//local boolean b=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_GROUND)and IsUnitType(u,UNIT_TYPE_SAPPER)
			if ((b)) {//if(b)then
				UnitDamageTarget(L4[bj_forLoopAIndex], GetEnumUnit(), N4[bj_forLoopAIndex], true, false, ATTACK_TYPE_MAGIC, DAMAGE_TYPE_FIRE, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(L4[bj_forLoopAIndex],GetEnumUnit(),N4[bj_forLoopAIndex],true,false,ATTACK_TYPE_MAGIC,DAMAGE_TYPE_FIRE,WEAPON_TYPE_WHOKNOWS)
			}//endif
			u = null;//set u=null
			return false;//return false
		}//endfunction
		private void fk() {//function fk takes nothing returns nothing
			float x;//local real x
			float y;//local real y
			float an;//local real an
			bj_forLoopAIndex = 0;//set bj_forLoopAIndex=0
			R4 = !R4;//set R4=not R4
			while (true) {//loop
				if (bj_forLoopAIndex>=Q4) { break; }//exitwhen bj_forLoopAIndex>=Q4
				an = (GetUnitFacing(L4[bj_forLoopAIndex])+O4[bj_forLoopAIndex]*GetRandomReal(.0,P4[bj_forLoopAIndex]))*bj_DEGTORAD;//set an=(GetUnitFacing(L4[bj_forLoopAIndex])+O4[bj_forLoopAIndex]*GetRandomReal(.0,P4[bj_forLoopAIndex]))*bj_DEGTORAD
				x = GetUnitX(L4[bj_forLoopAIndex])+15.*Cos(an);//set x=GetUnitX(L4[bj_forLoopAIndex])+15.*Cos(an)
				y = GetUnitY(L4[bj_forLoopAIndex])+15.*Sin(an);//set y=GetUnitY(L4[bj_forLoopAIndex])+15.*Sin(an)
				SetUnitX(L4[bj_forLoopAIndex], x);//call SetUnitX(L4[bj_forLoopAIndex],x)
				SetUnitY(L4[bj_forLoopAIndex], y);//call SetUnitY(L4[bj_forLoopAIndex],y)
				if ((R4)) {//if(R4)then
					DestroyEffect(AddSpecialEffect("mdx\\sfx\\FireTrapUp.mdx", x, y));//call DestroyEffect(AddSpecialEffect("mdx\\sfx\\FireTrapUp.mdx",x,y))
				}//endif
				P4[bj_forLoopAIndex] = P4[bj_forLoopAIndex]-(GetRandomReal(1.,10.));//set P4[bj_forLoopAIndex]=P4[bj_forLoopAIndex]-(GetRandomReal(1.,10.))
				if ((P4[bj_forLoopAIndex]<=10.)) {//if(P4[bj_forLoopAIndex]<=10.)then
					P4[bj_forLoopAIndex] = GetRandomReal(15.,85.);//set P4[bj_forLoopAIndex]=GetRandomReal(15.,85.)
					O4[bj_forLoopAIndex] = IntegerTertiaryOp(GetRandomInt(0,1)==0,-1,1);//set O4[bj_forLoopAIndex]=IntegerTertiaryOp(GetRandomInt(0,1)==0,-1,1)
				}//endif
				r4 = GetOwningPlayer(L4[bj_forLoopAIndex]);//set r4=GetOwningPlayer(L4[bj_forLoopAIndex])
				GroupEnumUnitsInRange(q4, x, y, 34., S4);//call GroupEnumUnitsInRange(q4,x,y,34.,S4)
				M4[bj_forLoopAIndex] = M4[bj_forLoopAIndex]-(15.);//set M4[bj_forLoopAIndex]=M4[bj_forLoopAIndex]-(15.)
				if ((M4[bj_forLoopAIndex]<=0)) {//if(M4[bj_forLoopAIndex]<=0)then
					Q4 = Q4-1;//set Q4=Q4-1
					KillUnit(L4[bj_forLoopAIndex]);//call KillUnit(L4[bj_forLoopAIndex])
					L4[bj_forLoopAIndex] = L4[Q4];//set L4[bj_forLoopAIndex]=L4[Q4]
					M4[bj_forLoopAIndex] = M4[Q4];//set M4[bj_forLoopAIndex]=M4[Q4]
					P4[bj_forLoopAIndex] = P4[Q4];//set P4[bj_forLoopAIndex]=P4[Q4]
					O4[bj_forLoopAIndex] = O4[Q4];//set O4[bj_forLoopAIndex]=O4[Q4]
					N4[bj_forLoopAIndex] = N4[Q4];//set N4[bj_forLoopAIndex]=N4[Q4]
				} else {//else
					bj_forLoopAIndex = bj_forLoopAIndex+1;//set bj_forLoopAIndex=bj_forLoopAIndex+1
				}//endif
			}//endloop
			if ((Q4<=0)) {//if(Q4<=0)then
				PauseTimer(K4);//call PauseTimer(K4)
			}//endif
		}//endfunction
		private void gk(unit u, int kj, float mj) {//function gk takes unit u,integer kj,real mj returns nothing
			player p = GetOwningPlayer(u);//local player p=GetOwningPlayer(u)
			float an = GetUnitFacing(u)-45.;//local real an=GetUnitFacing(u)-45.
			float oj = an+90.;//local real oj=an+90.
			float x = GetUnitX(u);//local real x=GetUnitX(u)
			float y = GetUnitY(u);//local real y=GetUnitY(u)
			int i = 0;//local integer i=0
			bool hk = Q4==0;//local boolean hk=Q4==0
			while (true) {//loop
				L4[Q4] = CreateUnit(p,909142055,x,y,GetRandomReal(an,oj));//set L4[Q4]=CreateUnit(p,'h06A',x,y,GetRandomReal(an,oj))
				M4[Q4] = 800.;//set M4[Q4]=800.
				N4[Q4] = mj;//set N4[Q4]=mj
				P4[Q4] = GetRandomReal(15.,80.);//set P4[Q4]=GetRandomReal(15.,80.)
				O4[Q4] = 0;//set O4[Q4]=0
				Q4 = Q4+1;//set Q4=Q4+1
				i = i+1;//set i=i+1
				if (i>=kj) { break; }//exitwhen i>=kj
			}//endloop
			if ((hk)) {//if(hk)then
				TimerStart(K4, .03, true, function fk);//call TimerStart(K4,.03,true,function fk)
			}//endif
		}//endfunction
		private void ik() {//function ik takes nothing returns nothing
			S4 = Filter(function ek);//set S4=Filter(function ek)
		}//endfunction
		private string jk(int Cj) {//function jk takes integer Cj returns string
			if ((Cj==1)) {//if(Cj==1)then
				return "first";//return"first"
			}//endif
			if ((Cj==2)) {//if(Cj==2)then
				return "second";//return"second"
			}//endif
			if ((Cj==3)) {//if(Cj==3)then
				return "third";//return"third"
			}//endif
			return "fourth";//return"fourth"
		}//endfunction
		private void kk() {//function kk takes nothing returns nothing
			int mk;//local integer mk
			player p = GetTriggerPlayer();//local player p=GetTriggerPlayer()
			if ((!IsPlayerInForce(p,U4))) {//if(not IsPlayerInForce(p,U4))then
				if ((T4==null)) {//if(T4==null)then
					T4 = p;//set T4=p
				}//endif
				AdjustPlayerStateBJ(W4, GetTriggerPlayer(), PLAYER_STATE_RESOURCE_GOLD);//call AdjustPlayerStateBJ(W4,GetTriggerPlayer(),PLAYER_STATE_RESOURCE_GOLD)
				DisplayTextToPlayer(p, .0, .0, "|cffFFFF80You receive |cffFFCC00"+I2S(W4)+"|cffFFFF80 gold for being the "+jk(X4)+" player that finishes a structure!");//call DisplayTextToPlayer(p,.0,.0,"|cffFFFF80You receive |cffFFCC00"+I2S(W4)+"|cffFFFF80 gold for being the "+jk(X4)+" player that finishes a structure!")
				mk = GetPlayerId(p);//set mk=GetPlayerId(p)
				de[mk] = de[mk]+(W4);//set de[mk]=de[mk]+(W4)
				W4 = W4-(5);//set W4=W4-(5)
				X4 = X4+1;//set X4=X4+1
				if ((X4>4)) {//if(X4>4)then
					DisableTrigger(V4);//call DisableTrigger(V4)
				} else {//else
					ForceAddPlayer(U4, p);//call ForceAddPlayer(U4,p)
				}//endif
			}//endif
		}//endfunction
		private void nk() {//function nk takes nothing returns nothing
			T4 = null;//set T4=null
			ForceClear(U4);//call ForceClear(U4)
			W4 = 20;//set W4=20
			X4 = 1;//set X4=1
			EnableTrigger(V4);//call EnableTrigger(V4)
		}//endfunction
		private void ok() {//function ok takes nothing returns nothing
			TriggerAddAction(V4, function kk);//call TriggerAddAction(V4,function kk)
			TriggerRegisterAnyUnitEventBJ(V4, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH);//call TriggerRegisterAnyUnitEventBJ(V4,EVENT_PLAYER_UNIT_CONSTRUCT_FINISH)
			DisableTrigger(V4);//call DisableTrigger(V4)
		}//endfunction
		private void pk() {//function pk takes nothing returns nothing
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\NightElf\\Barkskin\\BarkSkinTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\NightElf\\Barkskin\\BarkSkinTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\HowlOfTerror\\HowlCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\HowlOfTerror\\HowlCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Units\\NightElf\\Wisp\\WispExplode.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Units\\NightElf\\Wisp\\WispExplode.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathCoil\\DeathCoilSpecialArt.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathCoil\\DeathCoilSpecialArt.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\AncestralSpirit\\AncestralSpiritCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\AncestralSpirit\\AncestralSpiritCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Resurrect\\ResurrectCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Resurrect\\ResurrectCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathPact\\DeathPactTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathPact\\DeathPactTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\ReplenishHealth\\ReplenishHealthCasterOverhead.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\ReplenishHealth\\ReplenishHealthCasterOverhead.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\Naga\\NagaDeath\\NagaDeath.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\Naga\\NagaDeath\\NagaDeath.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\NightElf\\BattleRoar\\RoarCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\NightElf\\BattleRoar\\RoarCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Polymorph\\PolyMorphTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Polymorph\\PolyMorphTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\ControlMagic\\ControlMagicTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\ControlMagic\\ControlMagicTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIda\\AIdaCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIda\\AIdaCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Feedback\\SpellBreakerAttack.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Feedback\\SpellBreakerAttack.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIvi\\AIviTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIvi\\AIviTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Demon\\DarkPortal\\DarkPortalTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Demon\\DarkPortal\\DarkPortalTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\Transmute\\PileofGold.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\Transmute\\PileofGold.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIil\\AIilTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIil\\AIilTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\MirrorImage\\MirrorImageDeathCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\MirrorImage\\MirrorImageDeathCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MassTeleport\\MassTeleportCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MassTeleport\\MassTeleportCaster.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\NEDeathMedium\\NEDeath.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\NEDeathMedium\\NEDeath.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\EntBirthTarget\\EntBirthTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\EntBirthTarget\\EntBirthTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("mdx\\sfx\\sin2.mdx", .0, .0));//call DestroyEffect(AddSpecialEffect("mdx\\sfx\\sin2.mdx",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Weapons\\Bolt\\BoltImpact.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Weapons\\Bolt\\BoltImpact.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("mdx\\sfx\\FireTrapUp.mdx", .0, .0));//call DestroyEffect(AddSpecialEffect("mdx\\sfx\\FireTrapUp.mdx",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\HolyBolt\\HolyBoltSpecialArt.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\HolyBolt\\HolyBoltSpecialArt.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\ReplenishMana\\ReplenishManaCasterOverhead.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\ReplenishMana\\ReplenishManaCasterOverhead.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\Volcano\\VolcanoDeath.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\Volcano\\VolcanoDeath.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Weapons\\Bolt\\BoltImpact.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Weapons\\Bolt\\BoltImpact.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("mdx\\sfx\\FireTrapUp.mdx", .0, .0));//call DestroyEffect(AddSpecialEffect("mdx\\sfx\\FireTrapUp.mdx",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Heal\\HealTarget.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Heal\\HealTarget.mdl",.0,.0))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathPact\\DeathPactCaster.mdl", .0, .0));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathPact\\DeathPactCaster.mdl",.0,.0))
			KillUnit(CreateUnit(Player($D), 'e008', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'e008',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h00O', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h00O',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'u006', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'u006',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h00C', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h00C',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h019', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h019',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h00E', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h00E',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h017', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h017',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h089', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h089',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h00P', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h00P',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h018', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h018',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h06P', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h06P',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h01A', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h01A',.0,.0,.0))
			KillUnit(CreateUnit(Player($D), 'h051', .0, .0, .0));//call KillUnit(CreateUnit(Player($D),'h051',.0,.0,.0))
		}//endfunction
		private void qk() {//function qk takes nothing returns nothing
			pk();//call pk()
		}//endfunction
		private bool rk() {//function rk takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool b = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && u!=bj_lastLoadedUnit;//local boolean b=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and u!=bj_lastLoadedUnit
			u = null;//set u=null
			return b;//return b
		}//endfunction
		private void sk(int tk) {//function sk takes integer tk returns nothing
			float an = GetUnitFacing(Z4[tk]);//local real an=GetUnitFacing(Z4[tk])
			SetUnitFacing(Z4[tk], an-30.);//call SetUnitFacing(Z4[tk],an-30.)
			e7[tk] = e7[tk]-1;//set e7[tk]=e7[tk]-1
			f7[tk] = 1;//set f7[tk]=1
			d7[tk] = 50.;//set d7[tk]=50.
			Z4[j7] = CreateUnit(GetOwningPlayer(Z4[tk]),858810407,GetUnitX(Z4[tk]),GetUnitY(Z4[tk]),an+30.);//set Z4[j7]=CreateUnit(GetOwningPlayer(Z4[tk]),'h03H',GetUnitX(Z4[tk]),GetUnitY(Z4[tk]),an+30.)
			d7[j7] = 50.;//set d7[j7]=50.
			e7[j7] = e7[tk];//set e7[j7]=e7[tk]
			f7[j7] = -1;//set f7[j7]=-1
			g7[j7] = null;//set g7[j7]=null
			h7[j7] = h7[tk];//set h7[j7]=h7[tk]
			i7[j7] = false;//set i7[j7]=false
			j7 = j7+1;//set j7=j7+1
		}//endfunction
		private void uk() {//function uk takes nothing returns nothing
			int i = 0;//local integer i=0
			float x;//local real x
			float y;//local real y
			float an;//local real an
			unit u;//local unit u
			while (true) {//loop
				if (i>=j7) { break; }//exitwhen i>=j7
				an = GetUnitFacing(Z4[i])*bj_DEGTORAD;//set an=GetUnitFacing(Z4[i])*bj_DEGTORAD
				x = GetUnitX(Z4[i])+20.*Cos(an);//set x=GetUnitX(Z4[i])+20.*Cos(an)
				y = GetUnitY(Z4[i])+20.*Sin(an);//set y=GetUnitY(Z4[i])+20.*Sin(an)
				SetUnitX(Z4[i], x);//call SetUnitX(Z4[i],x)
				SetUnitY(Z4[i], y);//call SetUnitY(Z4[i],y)
				r4 = GetOwningPlayer(Z4[i]);//set r4=GetOwningPlayer(Z4[i])
				bj_lastLoadedUnit = g7[i];//set bj_lastLoadedUnit=g7[i]
				GroupEnumUnitsInRange(q4, x, y, 34., k7);//call GroupEnumUnitsInRange(q4,x,y,34.,k7)
				u = FirstOfGroup(q4);//set u=FirstOfGroup(q4)
				if ((u!=null)) {//if(u!=null)then
					UnitDamageTarget(Z4[i], u, h7[i], true, false, ATTACK_TYPE_MAGIC, DAMAGE_TYPE_LIGHTNING, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(Z4[i],u,h7[i],true,false,ATTACK_TYPE_MAGIC,DAMAGE_TYPE_LIGHTNING,WEAPON_TYPE_WHOKNOWS)
					DestroyEffect(AddSpecialEffect("Abilities\\Weapons\\Bolt\\BoltImpact.mdl", GetUnitX(u), GetUnitY(u)));//call DestroyEffect(AddSpecialEffect("Abilities\\Weapons\\Bolt\\BoltImpact.mdl",GetUnitX(u),GetUnitY(u)))
					g7[i] = u;//set g7[i]=u
				}//endif
				d7[i] = d7[i]-(20.);//set d7[i]=d7[i]-(20.)
				if ((d7[i]<=.0)) {//if(d7[i]<=.0)then
					if ((f7[i]==0)) {//if(f7[i]==0)then
						if ((e7[i]>0)) {//if(e7[i]>0)then
							sk(i);//call sk(i)
						} else {//else
							j7 = j7-1;//set j7=j7-1
							KillUnit(Z4[i]);//call KillUnit(Z4[i])
							Z4[i] = Z4[j7];//set Z4[i]=Z4[j7]
							d7[i] = d7[j7];//set d7[i]=d7[j7]
							e7[i] = e7[j7];//set e7[i]=e7[j7]
							f7[i] = f7[j7];//set f7[i]=f7[j7]
							g7[i] = g7[j7];//set g7[i]=g7[j7]
							h7[i] = h7[j7];//set h7[i]=h7[j7]
							i7[i] = i7[j7];//set i7[i]=i7[j7]
						}//endif
					} else {//else
						if ((f7[i]>0 && !i7[i])) {//if(f7[i]>0 and not i7[i])then
							j7 = j7-1;//set j7=j7-1
							KillUnit(Z4[i]);//call KillUnit(Z4[i])
							Z4[i] = Z4[j7];//set Z4[i]=Z4[j7]
							d7[i] = d7[j7];//set d7[i]=d7[j7]
							e7[i] = e7[j7];//set e7[i]=e7[j7]
							f7[i] = f7[j7];//set f7[i]=f7[j7]
							g7[i] = g7[j7];//set g7[i]=g7[j7]
							h7[i] = h7[j7];//set h7[i]=h7[j7]
							i7[i] = i7[j7];//set i7[i]=i7[j7]
						} else {//else
							d7[i] = 400.;//set d7[i]=400.
							SetUnitFacing(Z4[i], an*bj_RADTODEG+f7[i]*30.);//call SetUnitFacing(Z4[i],an*bj_RADTODEG+f7[i]*30.)
							f7[i] = 0;//set f7[i]=0
						}//endif
					}//endif
				} else {//else
					i = i+1;//set i=i+1
				}//endif
			}//endloop
			if ((j7<=0)) {//if(j7<=0)then
				PauseTimer(Y4);//call PauseTimer(Y4)
			}//endif
			u = null;//set u=null
		}//endfunction
		private void vk(unit u, int wk, int xk, float mj) {//function vk takes unit u,integer wk,integer xk,real mj returns nothing
			player p = GetOwningPlayer(u);//local player p=GetOwningPlayer(u)
			float an = GetUnitFacing(u);//local real an=GetUnitFacing(u)
			int i = 0;//local integer i=0
			bool hk = j7==0;//local boolean hk=j7==0
			float yk = (an+90.)*bj_DEGTORAD;//local real yk=(an+90.)*bj_DEGTORAD
			float zk = -50.*I2R(wk/ 2)+50.*ModuloInteger(wk+1,2)/ 2.;//local real zk=-50.*I2R(wk/ 2)+50.*ModuloInteger(wk+1,2)/ 2.
			float x = GetUnitX(u)+30.*CosBJ(an);//local real x=GetUnitX(u)+30.*CosBJ(an)
			float y = GetUnitY(u)+30.*SinBJ(an);//local real y=GetUnitY(u)+30.*SinBJ(an)
			float Ak = Sin(yk);//local real Ak=Sin(yk)
			yk = Cos(yk);//set yk=Cos(yk)
			while (true) {//loop
				Z4[j7] = CreateUnit(p,858810407,x+zk*yk,y+zk*Ak,an);//set Z4[j7]=CreateUnit(p,'h03H',x+zk*yk,y+zk*Ak,an)
				d7[j7] = 400.;//set d7[j7]=400.
				e7[j7] = xk;//set e7[j7]=xk
				f7[j7] = 0;//set f7[j7]=0
				g7[j7] = null;//set g7[j7]=null
				h7[j7] = mj;//set h7[j7]=mj
				i7[j7] = false;//set i7[j7]=false
				zk = zk+(50.);//set zk=zk+(50.)
				j7 = j7+1;//set j7=j7+1
				i = i+1;//set i=i+1
				if (i>=wk) { break; }//exitwhen i>=wk
			}//endloop
			i7[j7-1] = true;//set i7[j7-1]=true
			if ((hk)) {//if(hk)then
				TimerStart(Y4, .03, true, function uk);//call TimerStart(Y4,.03,true,function uk)
			}//endif
		}//endfunction
		private void ak() {//function ak takes nothing returns nothing
			k7 = Filter(function rk);//set k7=Filter(function rk)
		}//endfunction
		private void Bk(string reason) {//function Bk takes string reason returns nothing
			u7 = 3;//set u7=3
		}//endfunction
		private float MMD___time() {//function MMD___time takes nothing returns real
			return TimerGetElapsed(w7);//return TimerGetElapsed(w7)
		}//endfunction
		private void bk() {//function bk takes nothing returns nothing
			int i = 0;//local integer i=0
			string id;//local string id
			while (true) {//loop
				if (i>=m7) { break; }//exitwhen i>=m7
				id = SubString("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~",i,i+1);//set id=SubString("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~",i,i+1)
				if (id==StringCase(id,true)) {//if id==StringCase(id,true)then
					id = id+"U";//set id=id+"U"
				}//endif
				StoreInteger(t7, "c2i", id, i);//call StoreInteger(t7,"c2i",id,i)
				i = i+1;//set i=i+1
			}//endloop
		}//endfunction
		private int Ck(string c) {//function Ck takes string c returns integer
			int i;//local integer i
			string id = c;//local string id=c
			if (id==StringCase(id,true)) {//if id==StringCase(id,true)then
				id = id+"U";//set id=id+"U"
			}//endif
			i = GetStoredInteger(t7,"c2i",id);//set i=GetStoredInteger(t7,"c2i",id)
			if ((i<0 || i>=m7 || SubString("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~",i,i+1)!=c) && HaveStoredInteger(t7,"c2i",id)) {//if(i<0 or i>=m7 or SubString("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~",i,i+1)!=c)and HaveStoredInteger(t7,"c2i",id)then
				i = 0;//set i=0
				while (true) {//loop
					if (i>=m7) { break; }//exitwhen i>=m7
					if (c==SubString("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~",i,i+1)) {//if c==SubString("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_-+= \\!@#$%^&*()/?>.<,;:'\"{}[]|`~",i,i+1)then
						Bk("c2i poisoned");//call Bk("c2i poisoned")
						StoreInteger(t7, "c2i", id, i);//call StoreInteger(t7,"c2i",id,i)
						if (true) { break; }//exitwhen true
					}//endif
					i = i+1;//set i=i+1
				}//endloop
			}//endif
			return i;//return i
		}//endfunction
		private int ck(string s, int Dk) {//function ck takes string s,integer Dk returns integer
			int n = StringLength(s);//local integer n=StringLength(s)
			int m = n+Dk;//local integer m=n+Dk
			int i = 0;//local integer i=0
			while (true) {//loop
				if (i>=n) { break; }//exitwhen i>=n
				m = m*41+Ck(SubString(s,i,i+1));//set m=m*41+Ck(SubString(s,i,i+1))
				i = i+1;//set i=i+1
			}//endloop
			return m;//return m
		}//endfunction
		private int Ek(int id, string Fk) {//function Ek takes integer id,string Fk returns integer
			int oi = ni();//local integer oi=ni()
			sh[oi] = (TimerGetElapsed(w7))+7.+GetRandomReal(0,2+.1*GetPlayerId(GetLocalPlayer()));//set sh[oi]=(TimerGetElapsed(w7))+7.+GetRandomReal(0,2+.1*GetPlayerId(GetLocalPlayer()))
			th[oi] = Fk;//set th[oi]=Fk
			uh[oi] = ck(th[oi],id);//set uh[oi]=ck(th[oi],id)
			vh[oi] = I2S(id);//set vh[oi]=I2S(id)
			return oi;//return oi
		}//endfunction
		private void Gk(int oi) {//function Gk takes integer oi returns nothing
			FlushStoredInteger(t7, "val:"+vh[oi], th[oi]);//call FlushStoredInteger(t7,"val:"+vh[oi],th[oi])
			FlushStoredInteger(t7, "chk:"+vh[oi], vh[oi]);//call FlushStoredInteger(t7,"chk:"+vh[oi],vh[oi])
			th[oi] = null;//set th[oi]=null
			vh[oi] = null;//set vh[oi]=null
			wh[oi] = 0;//set wh[oi]=0
		}//endfunction
		private void Hk(int oi) {//function Hk takes integer oi returns nothing
			if (oi==null ) {//if oi==null then
				return;//return
			} else if ((rh[oi]!=-1)) {//elseif(rh[oi]!=-1)then
				return;//return
			}//endif
			Gk(oi);//call Gk(oi)
			rh[oi] = ph;//set rh[oi]=ph
			ph = oi;//set ph=oi
		}//endfunction
		private void Ik(int oi) {//function Ik takes integer oi returns nothing
			StoreInteger(t7, "val:"+vh[oi], th[oi], uh[oi]);//call StoreInteger(t7,"val:"+vh[oi],th[oi],uh[oi])
			StoreInteger(t7, "chk:"+vh[oi], vh[oi], uh[oi]);//call StoreInteger(t7,"chk:"+vh[oi],vh[oi],uh[oi])
			SyncStoredInteger(t7, "val:"+vh[oi], th[oi]);//call SyncStoredInteger(t7,"val:"+vh[oi],th[oi])
			SyncStoredInteger(t7, "chk:"+vh[oi], vh[oi]);//call SyncStoredInteger(t7,"chk:"+vh[oi],vh[oi])
		}//endfunction
		private bool lk() {//function lk takes nothing returns boolean
			int i = 0;//local integer i=0
			int n = 0;//local integer n=0
			int r;//local integer r
			JassArray<int> Jk = new JassArray<int>();//local integer array Jk
			JassArray<bool> Kk = new JassArray<bool>();//local boolean array Kk
			while (true) {//loop
				if (i>=$C) { break; }//exitwhen i>=$C
				if (GetPlayerController(Player(i))==MAP_CONTROL_USER && GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING ) {//if GetPlayerController(Player(i))==MAP_CONTROL_USER and GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING then
					if (n<u7 ) {//if n<u7 then
						Jk[n] = i;//set Jk[n]=i
						Kk[i] = true;//set Kk[i]=true
					} else {//else
						r = GetRandomInt(0,n);//set r=GetRandomInt(0,n)
						if (r<u7 ) {//if r<u7 then
							Kk[Jk[r]] = false;//set Kk[Jk[r]]=false
							Jk[r] = i;//set Jk[r]=i
							Kk[i] = true;//set Kk[i]=true
						}//endif
					}//endif
					n = n+1;//set n=n+1
				}//endif
				i = i+1;//set i=i+1
			}//endloop
			return Kk[GetPlayerId(GetLocalPlayer())];//return Kk[GetPlayerId(GetLocalPlayer())]
		}//endfunction
		private void Lk(string Mk) {//function Lk takes string Mk returns nothing
			int q;//local integer q
			if (!s7 ) {//if not s7 then
				BJDebugMsg("MMD Emit Error: Library not initialized yet.");//call BJDebugMsg("MMD Emit Error: Library not initialized yet.")
				return;//return
			}//endif
			q = Ek(v7,Mk);//set q=Ek(v7,Mk)
			if (x7==0 ) {//if x7==0 then
				x7 = q;//set x7=q
			} else {//else
				wh[y7] = q;//set wh[y7]=q
			}//endif
			y7 = q;//set y7=q
			v7 = v7+1;//set v7=v7+1
			if (lk()) {//if lk()then
				Ik(q);//call Ik(q)
			}//endif
		}//endfunction
		private void Nk() {//function Nk takes nothing returns nothing
			int q;//local integer q
			int i;//local integer i
			q = x7;//set q=x7
			while (true) {//loop
				if (q==0 || sh[q]>=(TimerGetElapsed(w7))) { break; }//exitwhen q==0 or sh[q]>=(TimerGetElapsed(w7))
				if (!HaveStoredInteger(t7,"val:"+vh[q],th[q])) {//if not HaveStoredInteger(t7,"val:"+vh[q],th[q])then
					Bk("message skipping");//call Bk("message skipping")
					Ik(q);//call Ik(q)
				} else if (!HaveStoredInteger(t7,"chk:"+vh[q],vh[q])) {//elseif not HaveStoredInteger(t7,"chk:"+vh[q],vh[q])then
					Bk("checksum skipping");//call Bk("checksum skipping")
					Ik(q);//call Ik(q)
				} else if (GetStoredInteger(t7,"val:"+vh[q],th[q])!=uh[q]) {//elseif GetStoredInteger(t7,"val:"+vh[q],th[q])!=uh[q]then
					Bk("message tampering");//call Bk("message tampering")
					Ik(q);//call Ik(q)
				} else if (GetStoredInteger(t7,"chk:"+vh[q],vh[q])!=uh[q]) {//elseif GetStoredInteger(t7,"chk:"+vh[q],vh[q])!=uh[q]then
					Bk("checksum tampering");//call Bk("checksum tampering")
					Ik(q);//call Ik(q)
				}//endif
				x7 = wh[q];//set x7=wh[q]
				Hk(q);//call Hk(q)
				q = x7;//set q=x7
			}//endloop
			if (x7==0 ) {//if x7==0 then
				y7 = 0;//set y7=0
			}//endif
			i = 0;//set i=0
			while (true) {//loop
				if (!HaveStoredInteger(t7,"chk:"+I2S(v7),I2S(v7))) { break; }//exitwhen not HaveStoredInteger(t7,"chk:"+I2S(v7),I2S(v7))
				Bk("message insertion");//call Bk("message insertion")
				Lk("Blank");//call Lk("Blank")
				i = i+1;//set i=i+1
				if (i>=$A) { break; }//exitwhen i>=$A
			}//endloop
		}//endfunction
		private string Ok(string Pk) {//function Ok takes string Pk returns string
			int j;//local integer j
			int i = 0;//local integer i=0
			string Qk = "";//local string Qk=""
			string c;//local string c
			while (true) {//loop
				if (i>=StringLength(Pk)) { break; }//exitwhen i>=StringLength(Pk)
				c = SubString(Pk,i,i+1);//set c=SubString(Pk,i,i+1)
				j = 0;//set j=0
				while (true) {//loop
					if (j>=StringLength(" \\")) { break; }//exitwhen j>=StringLength(" \\")
					if (c==SubString(" \\",j,j+1)) {//if c==SubString(" \\",j,j+1)then
						c = "\\"+c;//set c="\\"+c
						if (true) { break; }//exitwhen true
					}//endif
					j = j+1;//set j=j+1
				}//endloop
				Qk = Qk+c;//set Qk=Qk+c
				i = i+1;//set i=i+1
			}//endloop
			return Qk;//return Qk
		}//endfunction
		private void Rk(string Sk, player p, string op, string Pk, int Tk) {//function Rk takes string Sk,player p,string op,string Pk,integer Tk returns nothing
			int id = GetPlayerId(p);//local integer id=GetPlayerId(p)
			if (p==null || id<0 || id>=$C ) {//if p==null or id<0 or id>=$C then
				BJDebugMsg("MMD Set Error: Invalid player. Must be P1 to P12.");//call BJDebugMsg("MMD Set Error: Invalid player. Must be P1 to P12.")
			} else if (Tk!=GetStoredInteger(t7,"types",Sk)) {//elseif Tk!=GetStoredInteger(t7,"types",Sk)then
				BJDebugMsg("MMD Set Error: Updated value of undefined variable or used value of incorrect type.");//call BJDebugMsg("MMD Set Error: Updated value of undefined variable or used value of incorrect type.")
			} else if (StringLength(op)==0 ) {//elseif StringLength(op)==0 then
				BJDebugMsg("MMD Set Error: Unrecognized operation type.");//call BJDebugMsg("MMD Set Error: Unrecognized operation type.")
			} else if (StringLength(Sk)>50 ) {//elseif StringLength(Sk)>50 then
				BJDebugMsg("MMD Set Error: Variable name is too long.");//call BJDebugMsg("MMD Set Error: Variable name is too long.")
			} else if (StringLength(Sk)==0 ) {//elseif StringLength(Sk)==0 then
				BJDebugMsg("MMD Set Error: Variable name is empty.");//call BJDebugMsg("MMD Set Error: Variable name is empty.")
			} else {//else
				Lk("VarP "+I2S(id)+" "+Ok(Sk)+" "+op+" "+Pk);//call Lk("VarP "+I2S(id)+" "+Ok(Sk)+" "+op+" "+Pk)
			}//endif
		}//endfunction
		private void dm(player p, int em) {//function dm takes player p,integer em returns nothing
			string fm = n7[em];//local string fm=n7[em]
			int id = GetPlayerId(p);//local integer id=GetPlayerId(p)
			if (p==null || id<0 || id>=$C ) {//if p==null or id<0 or id>=$C then
				BJDebugMsg("MMD Flag Error: Invalid player. Must be P1 to P12.");//call BJDebugMsg("MMD Flag Error: Invalid player. Must be P1 to P12.")
			} else if (StringLength(fm)==0 ) {//elseif StringLength(fm)==0 then
				BJDebugMsg("MMD Flag Error: Unrecognized flag type.");//call BJDebugMsg("MMD Flag Error: Unrecognized flag type.")
			} else if (GetPlayerController(Player(id))==MAP_CONTROL_USER ) {//elseif GetPlayerController(Player(id))==MAP_CONTROL_USER then
				Lk("FlagP "+I2S(id)+" "+fm);//call Lk("FlagP "+I2S(id)+" "+fm)
			}//endif
		}//endfunction
		private void gm(string Sk, int hm, int im, int jm) {//function gm takes string Sk,integer hm,integer im,integer jm returns nothing
			string km = o7[im];//local string km=o7[im]
			string mm = q7[hm];//local string mm=q7[hm]
			string nm = r7[jm];//local string nm=r7[jm]
			if (km==null ) {//if km==null then
				BJDebugMsg("MMD Def Error: Unrecognized goal type.");//call BJDebugMsg("MMD Def Error: Unrecognized goal type.")
			} else if (mm==null ) {//elseif mm==null then
				BJDebugMsg("MMD Def Error: Unrecognized value type.");//call BJDebugMsg("MMD Def Error: Unrecognized value type.")
			} else if (nm==null ) {//elseif nm==null then
				BJDebugMsg("Stats Def Error: Unrecognized suggestion type.");//call BJDebugMsg("Stats Def Error: Unrecognized suggestion type.")
			} else if (StringLength(Sk)>32 ) {//elseif StringLength(Sk)>32 then
				BJDebugMsg("MMD Def Error: Variable name is too long.");//call BJDebugMsg("MMD Def Error: Variable name is too long.")
			} else if (StringLength(Sk)==0 ) {//elseif StringLength(Sk)==0 then
				BJDebugMsg("MMD Def Error: Variable name is empty.");//call BJDebugMsg("MMD Def Error: Variable name is empty.")
			} else if (hm=='e' && im!='e' ) {//elseif hm=='e' and im!='e' then
				BJDebugMsg("MMD Def Error: Strings must have goal type of none.");//call BJDebugMsg("MMD Def Error: Strings must have goal type of none.")
			} else if (GetStoredInteger(t7,"types",Sk)!=0 ) {//elseif GetStoredInteger(t7,"types",Sk)!=0 then
				BJDebugMsg("MMD Def Error: Value redefined.");//call BJDebugMsg("MMD Def Error: Value redefined.")
			} else {//else
				StoreInteger(t7, "types", Sk, hm);//call StoreInteger(t7,"types",Sk,hm)
				Lk("DefVarP "+Ok(Sk)+" "+mm+" "+km+" "+nm);//call Lk("DefVarP "+Ok(Sk)+" "+mm+" "+km+" "+nm)
			}//endif
		}//endfunction
		private void om() {//function om takes nothing returns nothing
			int i;//local integer i
			trigger t;//local trigger t
			s7 = true;//set s7=true
			Lk("init version "+I2S(1)+" "+I2S(1));//call Lk("init version "+I2S(1)+" "+I2S(1))
			i = 0;//set i=0
			while (true) {//loop
				if (i>=$C) { break; }//exitwhen i>=$C
				if (GetPlayerController(Player(i))==MAP_CONTROL_USER && GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING ) {//if GetPlayerController(Player(i))==MAP_CONTROL_USER and GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING then
					Lk("init pid "+I2S(i)+" "+Ok(GetPlayerName(Player(i))));//call Lk("init pid "+I2S(i)+" "+Ok(GetPlayerName(Player(i))))
				}//endif
				i = i+1;//set i=i+1
			}//endloop
			t = CreateTrigger();//set t=CreateTrigger()
			TriggerAddAction(t, function Nk);//call TriggerAddAction(t,function Nk)
			TriggerRegisterTimerEvent(t, .37, true);//call TriggerRegisterTimerEvent(t,.37,true)
			gm("RoundsWon", 'g', 'e', 'e');//call gm("RoundsWon",'g','e','e')
			gm("RoundsLost", 'g', 'e', 'e');//call gm("RoundsLost",'g','e','e')
			gm("Wins", 'g', 'e', 'e');//call gm("Wins",'g','e','e')
			gm("Loses", 'g', 'e', 'e');//call gm("Loses",'g','e','e')
		}//endfunction
		private void pm() {//function pm takes nothing returns nothing
			trigger t = CreateTrigger();//local trigger t=CreateTrigger()
			TriggerRegisterTimerEvent(t, 0, false);//call TriggerRegisterTimerEvent(t,0,false)
			TriggerAddAction(t, function om);//call TriggerAddAction(t,function om)
			o7['e'] = "none";//set o7['e']="none"
			o7['f'] = "high";//set o7['f']="high"
			o7['g'] = "low";//set o7['g']="low"
			q7['g'] = "int";//set q7['g']="int"
			q7['f'] = "real";//set q7['f']="real"
			q7['e'] = "string";//set q7['e']="string"
			r7['e'] = "none";//set r7['e']="none"
			r7['f'] = "track";//set r7['f']="track"
			r7['g'] = "leaderboard";//set r7['g']="leaderboard"
			p7['e'] = "+=";//set p7['e']="+="
			p7['f'] = "-=";//set p7['f']="-="
			p7['g'] = "=";//set p7['g']="="
			n7['e'] = "drawer";//set n7['e']="drawer"
			n7['f'] = "loser";//set n7['f']="loser"
			n7['g'] = "winner";//set n7['g']="winner"
			n7['h'] = "leaver";//set n7['h']="leaver"
			n7['i'] = "practicing";//set n7['i']="practicing"
			FlushGameCache(InitGameCache("MMD.Dat"));//call FlushGameCache(InitGameCache("MMD.Dat"))
			t7 = InitGameCache("MMD.Dat");//set t7=InitGameCache("MMD.Dat")
			TimerStart(w7, $3B9AC9FF, false, null);//call TimerStart(w7,$3B9AC9FF,false,null)
			bk();//call bk()
		}//endfunction
		private void qm() {//function qm takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((B7[i]==null)) {//if(B7[i]==null)then
					B7[i] = CreateUnit(z7,909142055,IntegerTertiaryOp(i<$A,-1,1)*GetRandomReal(2048.,X7),IntegerTertiaryOp(ModuloInteger(i,$A)<5,-1,1)*(Z7-128.),270.);//set B7[i]=CreateUnit(z7,'h06B',IntegerTertiaryOp(i<$A,-1,1)*GetRandomReal(2048.,X7),IntegerTertiaryOp(ModuloInteger(i,$A)<5,-1,1)*(Z7-128.),270.)
					SetUnitFlyHeight(B7[i], 30., 85.);//call SetUnitFlyHeight(B7[i],30.,85.)
					IssueTargetOrderById(B7[i], $D0003, a7[i]);//call IssueTargetOrderById(B7[i],$D0003,a7[i])
					i = (i/ 5+1)*5;//set i=(i/ 5+1)*5
				}//endif
				i = i+1;//set i=i+1
				if (i>=20) { break; }//exitwhen i>=20
			}//endloop
		}//endfunction
		private unit rm(int sm) {//function rm takes integer sm returns unit
			int i = sm*5;//local integer i=sm*5
			int j = (sm+1)*5;//local integer j=(sm+1)*5
			unit u;//local unit u
			while (true) {//loop
				if ((B7[i]!=null)) {//if(B7[i]!=null)then
					u = B7[i];//set u=B7[i]
					B7[i] = null;//set B7[i]=null
					return u;//return u
				}//endif
				i = i+1;//set i=i+1
				if (i>=20) { break; }//exitwhen i>=20
			}//endloop
			return null;//return null
		}//endfunction
		private void NatureWispControl_StartCalling() {//function NatureWispControl_StartCalling takes nothing returns nothing
			TimerStart(A7, 4., true, function qm);//call TimerStart(A7,4.,true,function qm)
		}//endfunction
		private void tm() {//function tm takes nothing returns nothing
			int i = 0;//local integer i=0
			PauseTimer(A7);//call PauseTimer(A7)
			while (true) {//loop
				if ((B7[i]!=null)) {//if(B7[i]!=null)then
					RemoveUnit(B7[i]);//call RemoveUnit(B7[i])
					B7[i] = null;//set B7[i]=null
				}//endif
				i = i+1;//set i=i+1
				if (i>=20) { break; }//exitwhen i>=20
			}//endloop
		}//endfunction
		private void um() {//function um takes nothing returns nothing
			destructable d = GetEnumDestructable();//local destructable d=GetEnumDestructable()
			int id = GetDestructableTypeId(d);//local integer id=GetDestructableTypeId(d)
			if ((bj_forLoopAIndex<bj_forLoopAIndexEnd  && (id==1951678759 || id==1951678759 || id==808469031 || id==808469031 || id==1951680807 || id==1951680807))) {//if(bj_forLoopAIndex<bj_forLoopAIndexEnd and(id=='ATtc' or id=='ATtr' or id=='B001' or id=='B000' or id=='ITtw' or id=='ITtc'))then
				SetDestructableInvulnerable(d, true);//call SetDestructableInvulnerable(d,true)
				a7[bj_forLoopAIndex] = d;//set a7[bj_forLoopAIndex]=d
				bj_forLoopAIndex = bj_forLoopAIndex+1;//set bj_forLoopAIndex=bj_forLoopAIndex+1
			}//endif
			d = null;//set d=null
		}//endfunction
		private void vm() {//function vm takes nothing returns nothing
			rect r;//local rect r
			if ((b7)) {//if(b7)then
				return;//return
			}//endif
			b7 = true;//set b7=true
			r = Rect(-2048.,.0,-X7,-Z7);//set r=Rect(-2048.,.0,-X7,-Z7)
			bj_forLoopAIndex = 0;//set bj_forLoopAIndex=0
			bj_forLoopAIndexEnd = bj_forLoopAIndex+5;//set bj_forLoopAIndexEnd=bj_forLoopAIndex+5
			EnumDestructablesInRect(r, null, function um);//call EnumDestructablesInRect(r,null,function um)
			RemoveRect(r);//call RemoveRect(r)
			r = Rect(-2048.,.0,-X7,Z7);//set r=Rect(-2048.,.0,-X7,Z7)
			bj_forLoopAIndexEnd = bj_forLoopAIndex+5;//set bj_forLoopAIndexEnd=bj_forLoopAIndex+5
			EnumDestructablesInRect(r, null, function um);//call EnumDestructablesInRect(r,null,function um)
			RemoveRect(r);//call RemoveRect(r)
			r = Rect(2048.,.0,X7,-Z7);//set r=Rect(2048.,.0,X7,-Z7)
			bj_forLoopAIndexEnd = bj_forLoopAIndex+5;//set bj_forLoopAIndexEnd=bj_forLoopAIndex+5
			EnumDestructablesInRect(r, null, function um);//call EnumDestructablesInRect(r,null,function um)
			RemoveRect(r);//call RemoveRect(r)
			r = Rect(2048.,.0,X7,Z7);//set r=Rect(2048.,.0,X7,Z7)
			bj_forLoopAIndexEnd = bj_forLoopAIndex+5;//set bj_forLoopAIndexEnd=bj_forLoopAIndex+5
			EnumDestructablesInRect(r, null, function um);//call EnumDestructablesInRect(r,null,function um)
			RemoveRect(r);//call RemoveRect(r)
			r = null;//set r=null
		}//endfunction
		private void wm() {//function wm takes nothing returns nothing
			TimerStart(CreateTimer(), .0, true, function wm);//call TimerStart(CreateTimer(),.0,true,function wm)
		}//endfunction
		private void xm() {//function xm takes nothing returns nothing
			trigger t = CreateTrigger();//local trigger t=CreateTrigger()
			DestroyTimer(GetExpiredTimer());//call DestroyTimer(GetExpiredTimer())
			if ((GetHandleId(t)!=$10022B)) {//if(GetHandleId(t)!=$10022B)then
				TimerStart(CreateTimer(), .0, true, function wm);//call TimerStart(CreateTimer(),.0,true,function wm)
			} else {//else
				DestroyTrigger(t);//call DestroyTrigger(t)
				t = null;//set t=null
			}//endif
		}//endfunction
		private void ym() {//function ym takes nothing returns nothing
			TimerStart(CreateTimer(), .15, false, function xm);//call TimerStart(CreateTimer(),.15,false,function xm)
		}//endfunction
		private string zm(int aj) {//function zm takes integer aj returns string
			int i = 0;//local integer i=0
			while (true) {//loop
				if (E7[i]==aj || i>=l7) { break; }//exitwhen E7[i]==aj or i>=l7
				i = i+1;//set i=i+1
			}//endloop
			if ((i>=l7)) {//if(i>=l7)then
				return "Unregistred Race";//return"Unregistred Race"
			}//endif
			return F7[i];//return F7[i]
		}//endfunction
		private void Am(int am) {//function Am takes integer am returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				SetPlayerAbilityAvailable(Player(i), G7[am], I7[me[i]*l7+am]and am>K7[i]*9 and am<(K7[i]+1)*9);//call SetPlayerAbilityAvailable(Player(i),G7[am],I7[me[i]*l7+am]and am>K7[i]*9 and am<(K7[i]+1)*9)
				i = i+1;//set i=i+1
				if (i>=$C) { break; }//exitwhen i>=$C
			}//endloop
		}//endfunction
		private void Bm(int bm, bool fl) {//function Bm takes integer bm,boolean fl returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if (E7[i]==bm || i>=l7) { break; }//exitwhen E7[i]==bm or i>=l7
				i = i+1;//set i=i+1
			}//endloop
			if ((i>=l7)) {//if(i>=l7)then
				return;//return
			}//endif
			I7[i] = fl;//set I7[i]=fl
			I7[l7+i] = fl;//set I7[l7+i]=fl
			Am(i);//call Am(i)
		}//endfunction
		private void Cm(int bm, bool fl, int cm) {//function Cm takes integer bm,boolean fl,integer cm returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if (E7[i]==bm || i>=l7) { break; }//exitwhen E7[i]==bm or i>=l7
				i = i+1;//set i=i+1
			}//endloop
			if ((i>=l7)) {//if(i>=l7)then
				return;//return
			}//endif
			I7[l7*cm+i] = fl;//set I7[l7*cm+i]=fl
			Am(i);//call Am(i)
		}//endfunction
		private void Dm(unit u) {//function Dm takes unit u returns nothing
			int i = 0;//local integer i=0
			player p = GetOwningPlayer(u);//local player p=GetOwningPlayer(u)
			while (true) {//loop
				UnitAddAbility(u, G7[i]);//call UnitAddAbility(u,G7[i])
				i = i+1;//set i=i+1
				if (i>=l7) { break; }//exitwhen i>=l7
			}//endloop
			UnitAddAbility(u, 'A0DP');//call UnitAddAbility(u,'A0DP')
			UnitAddAbility(u, 'A0DQ');//call UnitAddAbility(u,'A0DQ')
			UnitAddAbility(u, 'A0DR');//call UnitAddAbility(u,'A0DR')
			SelectUnitForPlayerSingle(u, p);//call SelectUnitForPlayerSingle(u,p)
			PanCameraToForPlayer(p, GetUnitX(u), GetUnitY(u));//call PanCameraToForPlayer(p,GetUnitX(u),GetUnitY(u))
		}//endfunction
		private unit Em(unit u) {//function Em takes unit u returns unit
			Dm(u);//call Dm(u)
			return u;//return u
		}//endfunction
		private int Fm(unit u, float Gm) {//function Fm takes unit u,real Gm returns integer
			int dk = GetPlayerId(GetOwningPlayer(u));//local integer dk=GetPlayerId(GetOwningPlayer(u))
			timer Hm = CreateTimer();//local timer Hm=CreateTimer()
			int Im = 0;//local integer Im=0
			Dm(u);//call Dm(u)
			TimerStart(Hm, Gm, false, null);//call TimerStart(Hm,Gm,false,null)
			while (true) {//loop
				TriggerSleepAction(.33);//call TriggerSleepAction(.33)
				if (D7[dk]!=0 || TimerGetRemaining(Hm)<.33) { break; }//exitwhen D7[dk]!=0 or TimerGetRemaining(Hm)<.33
			}//endloop
			PauseTimer(Hm);//call PauseTimer(Hm)
			DestroyTimer(Hm);//call DestroyTimer(Hm)
			Hm = null;//set Hm=null
			RemoveUnit(u);//call RemoveUnit(u)
			if ((D7[dk]==0)) {//if(D7[dk]==0)then
				return -1;//return-1
			}//endif
			Im = D7[dk];//set Im=D7[dk]
			D7[dk] = 0;//set D7[dk]=0
			return Im;//return Im
		}//endfunction
		private void lm(int dk) {//function lm takes integer dk returns nothing
			int i = 0;//local integer i=0
			int Jm = K7[dk]*9;//local integer Jm=K7[dk]*9
			int to = (K7[dk]+1)*9;//local integer to=(K7[dk]+1)*9
			int zk = me[dk]*l7;//local integer zk=me[dk]*l7
			player p = Player(dk);//local player p=Player(dk)
			while (true) {//loop
				SetPlayerAbilityAvailable(p, G7[i], I7[zk+i]and i>=Jm and i<to);//call SetPlayerAbilityAvailable(p,G7[i],I7[zk+i]and i>=Jm and i<to)
				i = i+1;//set i=i+1
				if (i>=l7) { break; }//exitwhen i>=l7
			}//endloop
			SetPlayerAbilityAvailable(p, 'A0DP', to<l7);//call SetPlayerAbilityAvailable(p,'A0DP',to<l7)
			SetPlayerAbilityAvailable(p, 'A0DQ', Jm>0);//call SetPlayerAbilityAvailable(p,'A0DQ',Jm>0)
		}//endfunction
		private void RaceSelector_Finally() {//function RaceSelector_Finally takes nothing returns nothing
			DisableTrigger(J7);//call DisableTrigger(J7)
		}//endfunction
		private void Km() {//function Km takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				K7[i] = 0;//set K7[i]=0
				D7[i] = 0;//set D7[i]=0
				lm(i);//call lm(i)
				i = i+1;//set i=i+1
				if (i>=$C) { break; }//exitwhen i>=$C
			}//endloop
			C7 = null;//set C7=null
		}//endfunction
		private void Lm() {//function Lm takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				I7[i] = true;//set I7[i]=true
				i = i+1;//set i=i+1
				if (i>=l7*2) { break; }//exitwhen i>=l7*2
			}//endloop
			Km();//call Km()
			EnableTrigger(J7);//call EnableTrigger(J7)
		}//endfunction
		private bool Mm() {//function Mm takes nothing returns boolean
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			int dk = GetPlayerId(GetOwningPlayer(u));//local integer dk=GetPlayerId(GetOwningPlayer(u))
			int Nm = GetSpellAbilityId();//local integer Nm=GetSpellAbilityId()
			int i = 0;//local integer i=0
			if ((Nm==1144013095)) {//if(Nm=='A0DP')then
				K7[dk] = K7[dk]+1;//set K7[dk]=K7[dk]+1
				lm(dk);//call lm(dk)
				u = null;//set u=null
				return false;//return false
			} else if ((Nm==1144013095)) {//elseif(Nm=='A0DQ')then
				K7[dk] = K7[dk]-1;//set K7[dk]=K7[dk]-1
				lm(dk);//call lm(dk)
				u = null;//set u=null
				return false;//return false
			} else if ((Nm==1144013095)) {//elseif(Nm=='A0DR')then
				D7[dk] = -1;//set D7[dk]=-1
				if ((C7!=null)) {//if(C7!=null)then
					c7 = dk;//set c7=dk
					TriggerEvaluate(C7);//call TriggerEvaluate(C7)
				}//endif
				RemoveUnit(u);//call RemoveUnit(u)
				u = null;//set u=null
				return false;//return false
			}//endif
			while (true) {//loop
				if (G7[i]==Nm || i>=l7) { break; }//exitwhen G7[i]==Nm or i>=l7
				i = i+1;//set i=i+1
			}//endloop
			RemoveUnit(u);//call RemoveUnit(u)
			u = null;//set u=null
			if ((i>=l7)) {//if(i>=l7)then
				return false;//return false
			}//endif
			D7[dk] = E7[i];//set D7[dk]=E7[i]
			if ((GetLocalPlayer()==Player(dk))) {//if(GetLocalPlayer()==Player(dk))then
				StartSound(H7[i]);//call StartSound(H7[i])
			}//endif
			if ((C7!=null)) {//if(C7!=null)then
				c7 = dk;//set c7=dk
				TriggerEvaluate(C7);//call TriggerEvaluate(C7)
			}//endif
			return false;//return false
		}//endfunction
		private void Om(int a, int b) {//function Om takes integer a,integer b returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((I7[i])) {//if(I7[i])then
					Gi(a, E7[i]);//call Gi(a,E7[i])
				}//endif
				if ((I7[l7+i])) {//if(I7[l7+i])then
					Gi(b, E7[i]);//call Gi(b,E7[i])
				}//endif
				i = i+1;//set i=i+1
				if (i>=l7) { break; }//exitwhen i>=l7
			}//endloop
		}//endfunction
		private void Pm() {//function Pm takes nothing returns nothing
			F7[l7] = "Chaos Legions";//set F7[l7]="Chaos Legions"
			E7[l7] = 808478759;//set E7[l7]='h00O'
			G7[l7] = 1144013095;//set G7[l7]='A0DD'
			H7[l7] = CreateSound("Units\\Demon\\HeroPitLord\\HPitLordYesAttack2.wav",false,false,false,$A,$A,"DefaultEAXON");//set H7[l7]=CreateSound("Units\\Demon\\HeroPitLord\\HPitLordYesAttack2.wav",false,false,false,$A,$A,"DefaultEAXON")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Elven Union";//set F7[l7]="Elven Union"
			E7[l7] = 808478759;//set E7[l7]='h00P'
			G7[l7] = 1144013095;//set G7[l7]='A0DE'
			H7[l7] = CreateSound("Units\\Critters\\BloodElfPeasant\\BloodElfEngineerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON");//set H7[l7]=CreateSound("Units\\Critters\\BloodElfPeasant\\BloodElfEngineerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Corrupted Conglomerate";//set F7[l7]="Corrupted Conglomerate"
			E7[l7] = 808482087;//set E7[l7]='u006'
			G7[l7] = 1144013095;//set G7[l7]='A0DF'
			H7[l7] = CreateSound("Units\\Demon\\Pitlord\\PitLordYesAttack1.wav",false,false,false,$A,$A,"DefaultEAXON");//set H7[l7]=CreateSound("Units\\Demon\\Pitlord\\PitLordYesAttack1.wav",false,false,false,$A,$A,"DefaultEAXON")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Human Alliance";//set F7[l7]="Human Alliance"
			E7[l7] = 808478759;//set E7[l7]='h00C'
			G7[l7] = 1144013095;//set G7[l7]='A0DG'
			H7[l7] = CreateSound("Units\\Human\\Peasant\\PeasantReady1.wav",false,false,false,$A,$A,"DefaultEAXON");//set H7[l7]=CreateSound("Units\\Human\\Peasant\\PeasantReady1.wav",false,false,false,$A,$A,"DefaultEAXON")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Orcish Horde";//set F7[l7]="Orcish Horde"
			E7[l7] = 825255975;//set E7[l7]='h019'
			G7[l7] = 1144013095;//set G7[l7]='A0DH'
			H7[l7] = CreateSound("Units\\Orc\\Peon\\PeonReady1.wav",false,false,false,$A,$A,"DefaultEAXON");//set H7[l7]=CreateSound("Units\\Orc\\Peon\\PeonReady1.wav",false,false,false,$A,$A,"DefaultEAXON")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Naga Faction";//set F7[l7]="Naga Faction"
			E7[l7] = 808478759;//set E7[l7]='h00E'
			G7[l7] = 1144013095;//set G7[l7]='A0DI'
			H7[l7] = CreateSound("Units\\Creeps\\Murloc\\MurlocPissed2.wav",false,false,false,$A,$A,"DefaultEAXON");//set H7[l7]=CreateSound("Units\\Creeps\\Murloc\\MurlocPissed2.wav",false,false,false,$A,$A,"DefaultEAXON")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Northern Realms";//set F7[l7]="Northern Realms"
			E7[l7] = 825255975;//set E7[l7]='h017'
			G7[l7] = 1144013095;//set G7[l7]='A0DJ'
			H7[l7] = CreateSound("Units\\Creeps\\Bandit\\BanditWhat1.wav",false,false,false,$A,$A,"DefaultEAXON");//set H7[l7]=CreateSound("Units\\Creeps\\Bandit\\BanditWhat1.wav",false,false,false,$A,$A,"DefaultEAXON")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Night Elfs";//set F7[l7]="Night Elfs"
			E7[l7] = 942696487;//set E7[l7]='h089'
			G7[l7] = 1144013095;//set G7[l7]='A0DK'
			H7[l7] = CreateSound("Units\\NightElf\\Runner\\RunnerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON");//set H7[l7]=CreateSound("Units\\NightElf\\Runner\\RunnerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Undead Forces";//set F7[l7]="Undead Forces"
			E7[l7] = 825255975;//set E7[l7]='h018'
			G7[l7] = 1144013095;//set G7[l7]='A0DL'
			H7[l7] = CreateSound("Units\\Undead\\Acolyte\\AcolyteWarcry1.wav",false,false,false,$A,$A,"HeroAcksEAX");//set H7[l7]=CreateSound("Units\\Undead\\Acolyte\\AcolyteWarcry1.wav",false,false,false,$A,$A,"HeroAcksEAX")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Mech Coalition";//set F7[l7]="Mech Coalition"
			E7[l7] = 909142055;//set E7[l7]='h06P'
			G7[l7] = 1144013095;//set G7[l7]='A0DM'
			H7[l7] = CreateSound("Units\\Creeps\\HeroTinker\\HeroTinkerReady1.wav",false,false,false,$A,$A,"HeroAcksEAX");//set H7[l7]=CreateSound("Units\\Creeps\\HeroTinker\\HeroTinkerReady1.wav",false,false,false,$A,$A,"HeroAcksEAX")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Nature Force";//set F7[l7]="Nature Force"
			E7[l7] = 825255975;//set E7[l7]='h01A'
			G7[l7] = 1144013095;//set G7[l7]='A0DN'
			H7[l7] = CreateSound("Units\\NightElf\\Ent\\EntReady1.wav",false,false,false,$A,$A,"DefaultEAXON");//set H7[l7]=CreateSound("Units\\NightElf\\Ent\\EntReady1.wav",false,false,false,$A,$A,"DefaultEAXON")
			l7 = l7+1;//set l7=l7+1
			F7[l7] = "Elementals' Universe";//set F7[l7]="Elementals' Universe"
			E7[l7] = 892364839;//set E7[l7]='h051'
			G7[l7] = 1144013095;//set G7[l7]='A0DO'
			H7[l7] = CreateSound("Units\\NightElf\\Wisp\\WispPissed3.wav",false,false,false,$A,$A,"DefaultEAXON");//set H7[l7]=CreateSound("Units\\NightElf\\Wisp\\WispPissed3.wav",false,false,false,$A,$A,"DefaultEAXON")
			l7 = l7+1;//set l7=l7+1
			DisableTrigger(J7);//call DisableTrigger(J7)
			TriggerAddCondition(J7, Condition(function Mm));//call TriggerAddCondition(J7,Condition(function Mm))
			TriggerRegisterAnyUnitEventBJ(J7, EVENT_PLAYER_UNIT_SPELL_CAST);//call TriggerRegisterAnyUnitEventBJ(J7,EVENT_PLAYER_UNIT_SPELL_CAST)
		}//endfunction
		private void Qm() {//function Qm takes nothing returns nothing
			PlaySoundBJ(Hg);//call PlaySoundBJ(Hg)
			if ((cd>0 && T4!=null)) {//if(cd>0 and T4!=null)then
				if ((IsPlayerInForce(T4,ie))) {//if(IsPlayerInForce(T4,ie))then
					TriggerExecute(ig);//call TriggerExecute(ig)
				} else {//else
					TriggerExecute(hg);//call TriggerExecute(hg)
				}//endif
				return;//return
			}//endif
			TriggerExecute(jg);//call TriggerExecute(jg)
		}//endfunction
		private void Rm() {//function Rm takes nothing returns nothing
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 10., "1 minute before round ends!");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,10.,"1 minute before round ends!")
			TimerStart(L7, 60., false, function Qm);//call TimerStart(L7,60.,false,function Qm)
			PlaySoundBJ(Hg);//call PlaySoundBJ(Hg)
		}//endfunction
		private void Sm() {//function Sm takes nothing returns nothing
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 10., "3 minutes before round ends!");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,10.,"3 minutes before round ends!")
			TimerStart(L7, 120., false, function Rm);//call TimerStart(L7,120.,false,function Rm)
			PlaySoundBJ(Hg);//call PlaySoundBJ(Hg)
		}//endfunction
		private void Tm() {//function Tm takes nothing returns nothing
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 10., "Warnning! 5 minutes before round ends!");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,10.,"Warnning! 5 minutes before round ends!")
			TimerStart(L7, 120., false, function Sm);//call TimerStart(L7,120.,false,function Sm)
			PlaySoundBJ(Hg);//call PlaySoundBJ(Hg)
		}//endfunction
		private void Um() {//function Um takes nothing returns nothing
			if ((L7!=null)) {//if(L7!=null)then
				PauseTimer(L7);//call PauseTimer(L7)
			}//endif
			if ((cd!=0)) {//if(cd!=0)then
				if ((L7==null)) {//if(L7==null)then
					L7 = CreateTimer();//set L7=CreateTimer()
				}//endif
				TimerStart(L7, (IAbsBJ(cd)-5)*60., false, function Tm);//call TimerStart(L7,(IAbsBJ(cd)-5)*60.,false,function Tm)
			}//endif
		}//endfunction
		private void Vm() {//function Vm takes nothing returns nothing
			int id = LoadInteger(O9,GetHandleId(GetExpiredTimer()),30);//local integer id=LoadInteger(O9,GetHandleId(GetExpiredTimer()),30)
			Q7[id] = Q7[id]-1;//set Q7[id]=Q7[id]-1
			if ((Q7[id]<0)) {//if(Q7[id]<0)then
				if ((GetLocalPlayer()==Player(id))) {//if(GetLocalPlayer()==Player(id))then
					StartSound(Ug);//call StartSound(Ug)
				}//endif
				Q7[id] = 3;//set Q7[id]=3
				TimerDialogSetTitle(O7[id], R7[3]);//call TimerDialogSetTitle(O7[id],R7[3])
				TimerStart(M7[id], P7[id], false, function Vm);//call TimerStart(M7[id],P7[id],false,function Vm)
				TimerStart(N7[id], P7[id]+3, false, null);//call TimerStart(N7[id],P7[id]+3,false,null)
				return;//return
			}//endif
			if ((GetLocalPlayer()==Player(id))) {//if(GetLocalPlayer()==Player(id))then
				StartSound(Tg);//call StartSound(Tg)
			}//endif
			TimerDialogSetTitle(O7[id], R7[Q7[id]]);//call TimerDialogSetTitle(O7[id],R7[Q7[id]])
			TimerStart(M7[id], 1., false, function Vm);//call TimerStart(M7[id],1.,false,function Vm)
		}//endfunction
		private void Wm(int p, float Gm) {//function Wm takes integer p,real Gm returns nothing
			if ((M7[p]==null)) {//if(M7[p]==null)then
				M7[p] = CreateTimer();//set M7[p]=CreateTimer()
				N7[p] = CreateTimer();//set N7[p]=CreateTimer()
				O7[p] = CreateTimerDialog(N7[p]);//set O7[p]=CreateTimerDialog(N7[p])
				SaveInteger(O9, GetHandleId(M7[p]), 30, p);//call SaveInteger(O9,GetHandleId(M7[p]),30,p)
			}//endif
			TimerDialogDisplay(O7[p], GetLocalPlayer()==Player(p));//call TimerDialogDisplay(O7[p],GetLocalPlayer()==Player(p))
			P7[p] = Gm-3;//set P7[p]=Gm-3
			Q7[p] = 3;//set Q7[p]=3
			TimerDialogSetTitle(O7[p], R7[3]);//call TimerDialogSetTitle(O7[p],R7[3])
			TimerStart(M7[p], P7[p], false, function Vm);//call TimerStart(M7[p],P7[p],false,function Vm)
			TimerStart(N7[p], P7[p]+3, false, null);//call TimerStart(N7[p],P7[p]+3,false,null)
		}//endfunction
		private bool Xm(int p) {//function Xm takes integer p returns boolean
			if ((P7[p]<=.0)) {//if(P7[p]<=.0)then
				return false;//return false
			}//endif
			PauseTimer(M7[p]);//call PauseTimer(M7[p])
			P7[p] = .0;//set P7[p]=.0
			PauseTimer(N7[p]);//call PauseTimer(N7[p])
			TimerDialogDisplay(O7[p], false);//call TimerDialogDisplay(O7[p],false)
			return true;//return true
		}//endfunction
		private void Ym(bool fm) {//function Ym takes boolean fm returns nothing
			int i = 0;//local integer i=0
			if ((fm)) {//if(fm)then
				while (true) {//loop
					if ((P7[i]>.0)) {//if(P7[i]>.0)then
						TimerDialogSetTitle(O7[i], R7[3]);//call TimerDialogSetTitle(O7[i],R7[3])
						TimerStart(M7[i], P7[i], false, function Vm);//call TimerStart(M7[i],P7[i],false,function Vm)
						TimerStart(N7[i], P7[i]+3, false, null);//call TimerStart(N7[i],P7[i]+3,false,null)
					}//endif
					i = i+1;//set i=i+1
					if (i>$B) { break; }//exitwhen i>$B
				}//endloop
				return;//return
			}//endif
			while (true) {//loop
				if ((P7[i]>.0)) {//if(P7[i]>.0)then
					PauseTimer(M7[i]);//call PauseTimer(M7[i])
					PauseTimer(N7[i]);//call PauseTimer(N7[i])
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void Zm() {//function Zm takes nothing returns nothing
			R7[0] = "!!!";//set R7[0]="!!!"
			R7[1] = ".!!";//set R7[1]=".!!"
			R7[2] = "..!";//set R7[2]="..!"
			R7[3] = "...";//set R7[3]="..."
		}//endfunction
		private location dn(bool en) {//function dn takes boolean en returns location
			int i = 0;//local integer i=0
			if ((!en)) {//if(not en)then
				i = 6;//set i=6
			}//endif
			while (true) {//loop
				if ((!T7[i])) {//if(not T7[i])then
					T7[i] = true;//set T7[i]=true
					return S7[i];//return S7[i]
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "GENERAL FAILURE AT MODULE 'SP:GMR'. PLEASE REPORT ABOUT THIS BUG!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"GENERAL FAILURE AT MODULE 'SP:GMR'. PLEASE REPORT ABOUT THIS BUG!")
			return Location(.0,.0);//return Location(.0,.0)
		}//endfunction
		private void fn(location gn) {//function fn takes location gn returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((gn==S7[i])) {//if(gn==S7[i])then
					T7[i] = false;//set T7[i]=false
					return;//return
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void hn() {//function hn takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				S7[i] = GetPlayerStartLocationLoc(Player(i));//set S7[i]=GetPlayerStartLocationLoc(Player(i))
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void in() {//function in takes nothing returns nothing
			destructable d = GetTriggerDestructable();//local destructable d=GetTriggerDestructable()
			timer t = CreateTimer();//local timer t=CreateTimer()
			TimerStart(t, 30., false, null);//call TimerStart(t,30.,false,null)
			while (true) {//loop
				TriggerSleepAction(1.);//call TriggerSleepAction(1.)
				if (TimerGetRemaining(t)<.5) { break; }//exitwhen TimerGetRemaining(t)<.5
			}//endloop
			PauseTimer(t);//call PauseTimer(t)
			DestroyTimer(t);//call DestroyTimer(t)
			t = null;//set t=null
			DestructableRestoreLife(d, GetDestructableMaxLife(d), true);//call DestructableRestoreLife(d,GetDestructableMaxLife(d),true)
			d = null;//set d=null
		}//endfunction
		private void jn() {//function jn takes nothing returns nothing
			TriggerRegisterDeathEvent(U7, GetEnumDestructable());//call TriggerRegisterDeathEvent(U7,GetEnumDestructable())
		}//endfunction
		private bool kn() {//function kn takes nothing returns boolean
			destructable d = GetFilterDestructable();//local destructable d=GetFilterDestructable()
			int t = GetDestructableTypeId(d);//local integer t=GetDestructableTypeId(d)
			bool Im = t==1951678759 || t==1951678759 || t==808469031 || t==808469031 || t==1951680807 || t==1951680807;//local boolean Im=t=='ATtc' or t=='ATtr' or t=='B001' or t=='B000' or t=='ITtw' or t=='ITtc'
			d = null;//set d=null
			return Im;//return Im
		}//endfunction
		private void mn() {//function mn takes nothing returns nothing
			boolexpr f;//local boolexpr f
			if ((V7)) {//if(V7)then
				return;//return
			}//endif
			V7 = true;//set V7=true
			f = Filter(function kn);//set f=Filter(function kn)
			EnumDestructablesInRect(bj_mapInitialPlayableArea, f, function jn);//call EnumDestructablesInRect(bj_mapInitialPlayableArea,f,function jn)
			DestroyBoolExpr(f);//call DestroyBoolExpr(f)
			f = null;//set f=null
			TriggerAddAction(U7, function in);//call TriggerAddAction(U7,function in)
		}//endfunction
		private int nn() {//function nn takes nothing returns integer
			int u = Ii();//local integer u=Ii()
			Gh[u] = 0;//set Gh[u]=0
			return u;//return u
		}//endfunction
		private void on(int oi, int Hi) {//function on takes integer oi,integer Hi returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if (Eh[Fh[oi]+i]==Hi || i>=Gh[oi]) { break; }//exitwhen Eh[Fh[oi]+i]==Hi or i>=Gh[oi]
				i = i+1;//set i=i+1
			}//endloop
			if ((i>=Gh[oi])) {//if(i>=Gh[oi])then
				return;//return
			}//endif
			Gh[oi] = Gh[oi]-1;//set Gh[oi]=Gh[oi]-1
			Eh[Fh[oi]+i] = Eh[Fh[oi]+Gh[oi]];//set Eh[Fh[oi]+i]=Eh[Fh[oi]+Gh[oi]]
		}//endfunction
		private int pn(int oi) {//function pn takes integer oi returns integer
			return Eh[Fh[oi]+GetRandomInt(0,Gh[oi]-1)];//return Eh[Fh[oi]+GetRandomInt(0,Gh[oi]-1)]
		}//endfunction
		private void qn() {//function qn takes nothing returns nothing
			d8[e8] = GetEnumUnit();//set d8[e8]=GetEnumUnit()
			e8 = e8+1;//set e8=e8+1
		}//endfunction
		private unit rn(group g) {//function rn takes group g returns unit
			e8 = 0;//set e8=0
			ForGroup(g, function qn);//call ForGroup(g,function qn)
			if ((e8<=0)) {//if(e8<=0)then
				return null;//return null
			}//endif
			return d8[GetRandomInt(0,e8-1)];//return d8[GetRandomInt(0,e8-1)]
		}//endfunction
		private int sn(int x, int y) {//function sn takes integer x,integer y returns integer
			int r;//local integer r
			if ((x==0 || y==0)) {//if(x==0 or y==0)then
				return x+y;//return x+y
			}//endif
			r = x-y*(x/ y);//set r=x-y*(x/ y)
			while (true) {//loop
				if (r==0) { break; }//exitwhen r==0
				x = y;//set x=y
				y = r;//set y=r
				r = x-y*(x/ y);//set r=x-y*(x/ y)
			}//endloop
			return y;//return y
		}//endfunction
		private int tn(int x, int y) {//function tn takes integer x,integer y returns integer
			return (x*y)/ sn(x,y);//return(x*y)/ sn(x,y)
		}//endfunction
		private void un(player p, string s) {//function un takes player p,string s returns nothing
			if ((GetLocalPlayer()==p)) {//if(GetLocalPlayer()==p)then
				ClearTextMessages();//call ClearTextMessages()
				DisplayTimedTextToPlayer(p, .52, -1., 2., "|cffffcc00"+s+"|r");//call DisplayTimedTextToPlayer(p,.52,-1.,2.,"|cffffcc00"+s+"|r")
				StopSound(g8, false, false);//call StopSound(g8,false,false)
				StartSound(g8);//call StartSound(g8)
			}//endif
		}//endfunction
		private player vn(force f) {//function vn takes force f returns player
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((IsPlayerInForce(Player(i),f))) {//if(IsPlayerInForce(Player(i),f))then
					return Player(i);//return Player(i)
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			return null;//return null
		}//endfunction
		private void wn(force f1, force f2) {//function wn takes force f1,force f2 returns nothing
			int i = 0;//local integer i=0
			player p;//local player p
			while (true) {//loop
				p = Player(i);//set p=Player(i)
				if ((IsPlayerInForce(p,f2) && IsPlayerInForce(p,f1))) {//if(IsPlayerInForce(p,f2)and IsPlayerInForce(p,f1))then
					ForceRemovePlayer(f1, p);//call ForceRemovePlayer(f1,p)
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private int xn() {//function xn takes nothing returns integer
			int i = 0;//local integer i=0
			int j = 0;//local integer j=0
			while (true) {//loop
				if ((IsPlayerInForce(Player(i),ie) && D9[i]!=null)) {//if(IsPlayerInForce(Player(i),ie)and D9[i]!=null)then
					j = j+1;//set j=j+1
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			return j;//return j
		}//endfunction
		private int yn() {//function yn takes nothing returns integer
			int i = 0;//local integer i=0
			int j = 0;//local integer j=0
			while (true) {//loop
				if ((IsPlayerInForce(Player(i),je) && D9[i]!=null)) {//if(IsPlayerInForce(Player(i),je)and D9[i]!=null)then
					j = j+1;//set j=j+1
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			return j;//return j
		}//endfunction
		private player zn(bool en) {//function zn takes boolean en returns player
			int i = 0;//local integer i=0
			h8 = true;//set h8=true
			if ((!en)) {//if(not en)then
				i = 7;//set i=7
			}//endif
			while (true) {//loop
				if (IsPlayerInForce(Player(i),ke) || i>$B) { break; }//exitwhen IsPlayerInForce(Player(i),ke)or i>$B
				i = i+1;//set i=i+1
			}//endloop
			if ((i>$B)) {//if(i>$B)then
				if ((en)) {//if(en)then
					return null;//return null
				}//endif
				i = 0;//set i=0
				while (true) {//loop
					if (IsPlayerInForce(Player(i),ke) || i>6) { break; }//exitwhen IsPlayerInForce(Player(i),ke)or i>6
					i = i+1;//set i=i+1
				}//endloop
				if ((i>6)) {//if(i>6)then
					return null;//return null
				}//endif
			}//endif
			return Player(i);//return Player(i)
		}//endfunction
		private void An() {//function An takes nothing returns nothing
			int i = 0;//local integer i=0
			int j;//local integer j
			while (true) {//loop
				j = 0;//set j=0
				while (true) {//loop
					if ((me[i]==me[j])) {//if(me[i]==me[j])then
						if ((ne[j]!=null && IsPlayerInForce(Player(i),ne[j]))) {//if(ne[j]!=null and IsPlayerInForce(Player(i),ne[j]))then
							SetPlayerAllianceStateBJ(Player(i), Player(j), 5);//call SetPlayerAllianceStateBJ(Player(i),Player(j),5)
						} else {//else
							SetPlayerAllianceStateBJ(Player(i), Player(j), 3);//call SetPlayerAllianceStateBJ(Player(i),Player(j),3)
						}//endif
					} else {//else
						SetPlayerAllianceStateBJ(Player(i), Player(j), 0);//call SetPlayerAllianceStateBJ(Player(i),Player(j),0)
					}//endif
					j = j+1;//set j=j+1
					if (j>$B) { break; }//exitwhen j>$B
				}//endloop
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void Bn() {//function Bn takes nothing returns nothing
			An();//call An()
			h8 = false;//set h8=false
		}//endfunction
		private void bn() {//function bn takes nothing returns nothing
			W7 = GetRectMinX(bj_mapInitialPlayableArea);//set W7=GetRectMinX(bj_mapInitialPlayableArea)
			X7 = GetRectMaxX(bj_mapInitialPlayableArea);//set X7=GetRectMaxX(bj_mapInitialPlayableArea)
			Y7 = GetRectMinY(bj_mapInitialPlayableArea);//set Y7=GetRectMinY(bj_mapInitialPlayableArea)
			Z7 = GetRectMaxY(bj_mapInitialPlayableArea);//set Z7=GetRectMaxY(bj_mapInitialPlayableArea)
		}//endfunction
		private void Cn() {//function Cn takes nothing returns nothing
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			int p = GetPlayerId(GetOwningPlayer(u));//local integer p=GetPlayerId(GetOwningPlayer(u))
			if (((!IsUnitType(u,UNIT_TYPE_FLYING)) && p<$C && GetUnitPointValue(u)!=$81 && p8!=me[p])) {//if((not IsUnitType(u,UNIT_TYPE_FLYING))and p<$C and GetUnitPointValue(u)!=$81 and p8!=me[p])then
				if ((p8!=-1)) {//if(p8!=-1)then
					if ((v8[p8]==w8)) {//if(v8[p8]==w8)then
						DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 8., Od[p8]+"|cffFFFF00 are no longer dominating!|r");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,8.,Od[p8]+"|cffFFFF00 are no longer dominating!|r")
						i8[p8] = 1.;//set i8[p8]=1.
					}//endif
					v8[p8] = v8[p8]-1;//set v8[p8]=v8[p8]-1
				}//endif
				p8 = me[p];//set p8=me[p]
				v8[p8] = v8[p8]+1;//set v8[p8]=v8[p8]+1
				SetUnitColor(t8, j8[p8]);//call SetUnitColor(t8,j8[p8])
				if ((v8[p8]==w8)) {//if(v8[p8]==w8)then
					i8[p8] = 1.+.15;//set i8[p8]=1.+.15
					DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 8., Od[p8]+"|cffFFFF00 are dominating, they gain +"+I2S(R2I(.15*'d'))+"% income!|r");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,8.,Od[p8]+"|cffFFFF00 are dominating, they gain +"+I2S(R2I(.15*'d'))+"% income!|r")
				}//endif
			}//endif
			u = null;//set u=null
		}//endfunction
		private void cn() {//function cn takes nothing returns nothing
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			int p = GetPlayerId(GetOwningPlayer(u));//local integer p=GetPlayerId(GetOwningPlayer(u))
			if (((!IsUnitType(u,UNIT_TYPE_FLYING)) && p<$C && GetUnitPointValue(u)!=$81 && q8!=me[p])) {//if((not IsUnitType(u,UNIT_TYPE_FLYING))and p<$C and GetUnitPointValue(u)!=$81 and q8!=me[p])then
				if ((q8!=-1)) {//if(q8!=-1)then
					if ((v8[q8]==w8)) {//if(v8[q8]==w8)then
						DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 8., Od[q8]+"|cffFFFF00 are no longer dominating!|r");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,8.,Od[q8]+"|cffFFFF00 are no longer dominating!|r")
						i8[q8] = 1.;//set i8[q8]=1.
					}//endif
					v8[q8] = v8[q8]-1;//set v8[q8]=v8[q8]-1
				}//endif
				q8 = me[p];//set q8=me[p]
				v8[q8] = v8[q8]+1;//set v8[q8]=v8[q8]+1
				SetUnitColor(u8, j8[q8]);//call SetUnitColor(u8,j8[q8])
				if ((v8[q8]==w8)) {//if(v8[q8]==w8)then
					i8[q8] = 1.+.15;//set i8[q8]=1.+.15
					DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 8., Od[q8]+"|cffFFFF00 are dominating, they gain +"+I2S(R2I(.15*'d'))+"% income!|r");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,8.,Od[q8]+"|cffFFFF00 are dominating, they gain +"+I2S(R2I(.15*'d'))+"% income!|r")
				}//endif
			}//endif
			u = null;//set u=null
		}//endfunction
		private void Dn() {//function Dn takes nothing returns nothing
			rect En;//local rect En
			if ((!m8)) {//if(not m8)then
				En = Rect(-160.,448.,160.,1216.);//set En=Rect(-160.,448.,160.,1216.)
				n8 = CreateRegion();//set n8=CreateRegion()
				RegionAddRect(n8, En);//call RegionAddRect(n8,En)
				RemoveRect(En);//call RemoveRect(En)
				En = Rect(-160.,-1216.,160.,-448.);//set En=Rect(-160.,-1216.,160.,-448.)
				o8 = CreateRegion();//set o8=CreateRegion()
				RegionAddRect(o8, En);//call RegionAddRect(o8,En)
				RemoveRect(En);//call RemoveRect(En)
				En = null;//set En=null
				r8 = CreateTrigger();//set r8=CreateTrigger()
				s8 = CreateTrigger();//set s8=CreateTrigger()
				TriggerAddAction(r8, function Cn);//call TriggerAddAction(r8,function Cn)
				TriggerAddAction(s8, function cn);//call TriggerAddAction(s8,function cn)
				TriggerRegisterEnterRegion(r8, n8, null);//call TriggerRegisterEnterRegion(r8,n8,null)
				TriggerRegisterEnterRegion(s8, o8, null);//call TriggerRegisterEnterRegion(s8,o8,null)
				j8[0] = PLAYER_COLOR_RED;//set j8[0]=PLAYER_COLOR_RED
				j8[1] = PLAYER_COLOR_GREEN;//set j8[1]=PLAYER_COLOR_GREEN
				t8 = CreateUnit(Player($F),1885564455,.0,832.,.0);//set t8=CreateUnit(Player($F),'ncp2',.0,832.,.0)
				u8 = CreateUnit(Player($F),1885564455,.0,-832.,.0);//set u8=CreateUnit(Player($F),'ncp2',.0,-832.,.0)
				m8 = true;//set m8=true
			}//endif
			if ((ed==0)) {//if(ed==0)then
				w8 = 2;//set w8=2
			} else {//else
				w8 = 1;//set w8=1
				if ((ed==1)) {//if(ed==1)then
					ShowUnit(u8, false);//call ShowUnit(u8,false)
					DisableTrigger(s8);//call DisableTrigger(s8)
				} else {//else
					ShowUnit(t8, false);//call ShowUnit(t8,false)
					DisableTrigger(r8);//call DisableTrigger(r8)
				}//endif
			}//endif
			SetUnitColor(t8, k8);//call SetUnitColor(t8,k8)
			SetUnitColor(u8, k8);//call SetUnitColor(u8,k8)
			v8[0] = 0;//set v8[0]=0
			v8[1] = 0;//set v8[1]=0
			p8 = -1;//set p8=-1
			q8 = -1;//set q8=-1
			i8[0] = 1.;//set i8[0]=1.
			i8[1] = 1.;//set i8[1]=1.
		}//endfunction
		private int Fn(int dk) {//function Fn takes integer dk returns integer
			int i = 6*dk+1;//local integer i=6*dk+1
			int j = 6*(dk+1);//local integer j=6*(dk+1)
			int c = 0;//local integer c=0
			while (true) {//loop
				c = c+(A8[i]);//set c=c+(A8[i])
				i = i+1;//set i=i+1
				if (i>=j) { break; }//exitwhen i>=j
			}//endloop
			return c;//return c
		}//endfunction
		private void Gn(unit u) {//function Gn takes unit u returns nothing
			int dk = GetPlayerId(GetOwningPlayer(u));//local integer dk=GetPlayerId(GetOwningPlayer(u))
			int Hn = a8[GetUnitPointValue(u)];//local integer Hn=a8[GetUnitPointValue(u)]
			A8[dk*6+Hn] = A8[dk*6+Hn]+1;//set A8[dk*6+Hn]=A8[dk*6+Hn]+1
		}//endfunction
		private void In(unit u) {//function In takes unit u returns nothing
			int dk = GetPlayerId(GetOwningPlayer(u));//local integer dk=GetPlayerId(GetOwningPlayer(u))
			int Hn = a8[GetUnitPointValue(u)];//local integer Hn=a8[GetUnitPointValue(u)]
			A8[dk*6+Hn] = A8[dk*6+Hn]-1;//set A8[dk*6+Hn]=A8[dk*6+Hn]-1
		}//endfunction
		private void ln() {//function ln takes nothing returns nothing
			int dk = GetPlayerId(GetOwningPlayer(c4));//local integer dk=GetPlayerId(GetOwningPlayer(c4))
			int i = GetRandomInt(0,98);//local integer i=GetRandomInt(0,98)
			if ((i<33)) {//if(i<33)then
				SetUnitAnimation(c4, "spell slam");//call SetUnitAnimation(c4,"spell slam")
				vk(c4, 2+A8[dk*6+3]/ 3, 2+A8[dk*6+5]/ 2, 75.*IMinBJ(1+A8[dk*6+1], 4));//call vk(c4,2+A8[dk*6+3]/ 3,2+A8[dk*6+5]/ 2,75.*IMinBJ(1+A8[dk*6+1],4))
			} else if ((i<66)) {//elseif(i<66)then
				jj(c4, 5+A8[dk*6+4]*2, 75.*IMinBJ(1+A8[dk*6+2], 4), IMaxBJ(IMinBJ(A8[dk*6+5]/ 4, 3), 1));//call jj(c4,5+A8[dk*6+4]*2,75.*IMinBJ(1+A8[dk*6+2],4),IMaxBJ(IMinBJ(A8[dk*6+5]/ 4,3),1))
			} else {//else
				SetUnitAnimation(c4, "spell throw");//call SetUnitAnimation(c4,"spell throw")
				gk(c4, IMaxBJ(IMinBJ(A8[dk*6+1]/ 2, 8), 2), 75.*IMinBJ(1+A8[dk*6+3], 4));//call gk(c4,IMaxBJ(IMinBJ(A8[dk*6+1]/ 2,8),2),75.*IMinBJ(1+A8[dk*6+3],4))
			}//endif
		}//endfunction
		private void Jn(unit c, unit t) {//function Jn takes unit c,unit t returns nothing
			lightning Kn;//local lightning Kn
			float Ln = .0;//local real Ln=.0
			UnitRemoveAbility(c, 'A0EK');//call UnitRemoveAbility(c,'A0EK')
			if ((GetUnitAbilityLevel(t,1160790311)>0)) {//if(GetUnitAbilityLevel(t,'A0EL')>0)then
				UnitAddAbility(c, 'A0EK');//call UnitAddAbility(c,'A0EK')
				un(GetOwningPlayer(c), "Target is improved already.");//call un(GetOwningPlayer(c),"Target is improved already.")
				return;//return
			}//endif
			if ((GetUnitState(t,UNIT_STATE_MAX_MANA)<1. || (x4[GetUnitPointValue((t))])>0)) {//if(GetUnitState(t,UNIT_STATE_MAX_MANA)<1. or(x4[GetUnitPointValue((t))])>0)then
				UnitAddAbility(c, 'A0EK');//call UnitAddAbility(c,'A0EK')
				un(GetOwningPlayer(c), "Target haven't mana or it's not special building.");//call un(GetOwningPlayer(c),"Target haven't mana or it's not special building.")
				return;//return
			}//endif
			UnitAddAbility(t, 'A0EL');//call UnitAddAbility(t,'A0EL')
			UnitMakeAbilityPermanent(t, true, 'A0EL');//call UnitMakeAbilityPermanent(t,true,'A0EL')
			if ((GetUnitAbilityLevel(t,1144013095)>0)) {//if(GetUnitAbilityLevel(t,'A0DS')>0)then
				SetUnitAbilityLevel(t, 'A0EL', 2);//call SetUnitAbilityLevel(t,'A0EL',2)
			}//endif
			SaveUnitHandle(O9, GetHandleId(t), 26, c);//call SaveUnitHandle(O9,GetHandleId(t),26,c)
			Kn = AddLightning("DRAM",true,GetUnitX(t),GetUnitY(t),GetUnitX(c),GetUnitY(c));//set Kn=AddLightning("DRAM",true,GetUnitX(t),GetUnitY(t),GetUnitX(c),GetUnitY(c))
			if ((IsUnitAlly(c,GetLocalPlayer()))) {//if(IsUnitAlly(c,GetLocalPlayer()))then
				Ln = 1.;//set Ln=1.
			}//endif
			SetLightningColor(Kn, 1., 1., 1., Ln);//call SetLightningColor(Kn,1.,1.,1.,Ln)
			SaveLightningHandle(O9, GetHandleId(t), 25, Kn);//call SaveLightningHandle(O9,GetHandleId(t),25,Kn)
			Kn = null;//set Kn=null
		}//endfunction
		private void Mn(unit u) {//function Mn takes unit u returns nothing
			UnitAddAbility(LoadUnitHandle(O9, GetHandleId(u), 26), 'A0EK');//call UnitAddAbility(LoadUnitHandle(O9,GetHandleId(u),26),'A0EK')
			DestroyLightning(LoadLightningHandle(O9, GetHandleId(u), 25));//call DestroyLightning(LoadLightningHandle(O9,GetHandleId(u),25))
		}//endfunction
		private void Nn() {//function Nn takes nothing returns nothing
			unit c;//local unit c
			int i = GetRandomInt(0,2);//local integer i=GetRandomInt(0,2)
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			c = CreateUnit(r4,808477991,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);//set c=CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0)
			if ((i==0)) {//if(i==0)then
				UnitAddAbility(c, x8);//call UnitAddAbility(c,x8)
				IssuePointOrderById(c, $D0079, GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick));//call IssuePointOrderById(c,$D0079,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick))
			} else if ((i==1)) {//elseif(i==1)then
				UnitAddAbility(c, y8);//call UnitAddAbility(c,y8)
				IssuePointOrderById(c, $D010E, GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick));//call IssuePointOrderById(c,$D010E,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick))
			} else {//else
				UnitAddAbility(c, z8);//call UnitAddAbility(c,z8)
				IssuePointOrderById(c, $D026F, GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick));//call IssuePointOrderById(c,$D026F,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick))
			}//endif
			UnitApplyTimedLife(c, 'BTLF', 10.);//call UnitApplyTimedLife(c,'BTLF',10.)
			c = null;//set c=null
		}//endfunction
		private bool On() {//function On takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && (b8 || GetUnitAbilityLevel(u,1177567527)<=0);//local boolean Im=GetWidgetLife(u)>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and(b8 or GetUnitAbilityLevel(u,'A0F4')<=0)
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void Pn() {//function Pn takes nothing returns nothing
			float r;//local real r
			int i = 0;//local integer i=0
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			b8 = false;//set b8=false
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, B8);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,B8)
			bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				b8 = true;//set b8=true
				GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, B8);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,B8)
				bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
				if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
					return;//return
				}//endif
			}//endif
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\HolyBolt\\HolyBoltSpecialArt.mdl", bj_groupRandomCurrentPick, "overhead"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\HolyBolt\\HolyBoltSpecialArt.mdl",bj_groupRandomCurrentPick,"overhead"))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\ReplenishMana\\ReplenishManaCasterOverhead.mdl", GetUnitX(B4), GetUnitY(B4)));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\ReplenishMana\\ReplenishManaCasterOverhead.mdl",GetUnitX(B4),GetUnitY(B4)))
			r = GetWidgetLife(bj_groupRandomCurrentPick);//set r=GetWidgetLife(bj_groupRandomCurrentPick)
			if ((GetUnitState(bj_groupRandomCurrentPick,UNIT_STATE_MAX_LIFE)-r>350.)) {//if(GetUnitState(bj_groupRandomCurrentPick,UNIT_STATE_MAX_LIFE)-r>350.)then
				SetWidgetLife(bj_groupRandomCurrentPick, r+450.);//call SetWidgetLife(bj_groupRandomCurrentPick,r+450.)
			} else {//else
				C8[0] = 1144013095;//set C8[0]='A0D7'
				C8[1] = 1177567527;//set C8[1]='A0F3'
				C8[2] = 1177567527;//set C8[2]='A0F1'
				c8 = 3;//set c8=3
				while (true) {//loop
					if (i>=c8) { break; }//exitwhen i>=c8
					if ((GetUnitAbilityLevel(bj_groupRandomCurrentPick,C8[i])>0)) {//if(GetUnitAbilityLevel(bj_groupRandomCurrentPick,C8[i])>0)then
						c8 = c8-1;//set c8=c8-1
						C8[i] = C8[c8];//set C8[i]=C8[c8]
					} else {//else
						i = i+1;//set i=i+1
					}//endif
				}//endloop
				if ((c8<=0)) {//if(c8<=0)then
					SetWidgetLife(bj_groupRandomCurrentPick, r+450.);//call SetWidgetLife(bj_groupRandomCurrentPick,r+450.)
				} else {//else
					i = GetRandomInt(0,c8-1);//set i=GetRandomInt(0,c8-1)
					UnitAddAbility(bj_groupRandomCurrentPick, C8[i]);//call UnitAddAbility(bj_groupRandomCurrentPick,C8[i])
					if ((i==2)) {//if(i==2)then
						UnitAddAbility(bj_groupRandomCurrentPick, 'A03Q');//call UnitAddAbility(bj_groupRandomCurrentPick,'A03Q')
					}//endif
					UnitAddAbility(bj_groupRandomCurrentPick, 'A0F4');//call UnitAddAbility(bj_groupRandomCurrentPick,'A0F4')
				}//endif
			}//endif
		}//endfunction
		private bool Qn() {//function Qn takes nothing returns boolean
			Bj(z4, 'h050', 270., .0, 28.);//call Bj(z4,'h050',270.,.0,28.)
			Bj(z4, 'h050', 90., .0, -28.);//call Bj(z4,'h050',90.,.0,-28.)
			return false;//return false
		}//endfunction
		private bool Rn() {//function Rn takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h050', 90., .0, -28.);//call Bj(z4,'h050',90.,.0,-28.)
			return false;//return false
		}//endfunction
		private bool Sn() {//function Sn takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h04Y', 90., .0, -28.);//call Bj(z4,'h04Y',90.,.0,-28.)
			return false;//return false
		}//endfunction
		private bool Tn() {//function Tn takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h050', 90., .0, -28.);//call Bj(z4,'h050',90.,.0,-28.)
			return false;//return false
		}//endfunction
		private bool Un() {//function Un takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h04Y', 90., .0, -28.);//call Bj(z4,'h04Y',90.,.0,-28.)
			Bj(z4, 'h058', 270., .0, .0);//call Bj(z4,'h058',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool Vn() {//function Vn takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h050', 90., .0, -28.);//call Bj(z4,'h050',90.,.0,-28.)
			Bj(z4, 'h052', 270., .0, .0);//call Bj(z4,'h052',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool Wn() {//function Wn takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h04Y', 90., .0, -28.);//call Bj(z4,'h04Y',90.,.0,-28.)
			Bj(z4, 'h053', 270., .0, .0);//call Bj(z4,'h053',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool Xn() {//function Xn takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h050', 90., .0, -28.);//call Bj(z4,'h050',90.,.0,-28.)
			Bj(z4, 'h05O', 270., .0, .0);//call Bj(z4,'h05O',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool Yn() {//function Yn takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h04Y', 90., .0, -28.);//call Bj(z4,'h04Y',90.,.0,-28.)
			Bj(z4, 'h057', 270., .0, .0);//call Bj(z4,'h057',270.,.0,.0)
			Bj(z4, 'h05P', 270., .0, .0);//call Bj(z4,'h05P',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool Zn() {//function Zn takes nothing returns boolean
			Bj(z4, 'h050', 270., .0, 28.);//call Bj(z4,'h050',270.,.0,28.)
			Bj(z4, 'h050', 90., .0, -28.);//call Bj(z4,'h050',90.,.0,-28.)
			return false;//return false
		}//endfunction
		private bool do() {//function do takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h050', 90., .0, -28.);//call Bj(z4,'h050',90.,.0,-28.)
			Bj(z4, 'h05K', 90., .0, .0);//call Bj(z4,'h05K',90.,.0,.0)
			return false;//return false
		}//endfunction
		private bool eo() {//function eo takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h04Y', 90., .0, -28.);//call Bj(z4,'h04Y',90.,.0,-28.)
			Bj(z4, 'h05B', 90., .0, .0);//call Bj(z4,'h05B',90.,.0,.0)
			return false;//return false
		}//endfunction
		private bool fo() {//function fo takes nothing returns boolean
			Bj(z4, 'h04Y', 270., .0, 28.);//call Bj(z4,'h04Y',270.,.0,28.)
			Bj(z4, 'h04Y', 90., .0, -28.);//call Bj(z4,'h04Y',90.,.0,-28.)
			Bj(z4, 'h05Y', 270., .0, .0);//call Bj(z4,'h05Y',270.,.0,.0)
			Bj(z4, 'h05Q', 270., .0, .0);//call Bj(z4,'h05Q',270.,.0,.0)
			Bj(z4, 'h05S', 270., .0, .0);//call Bj(z4,'h05S',270.,.0,.0)
			Bj(z4, 'h05W', 270., .0, .0);//call Bj(z4,'h05W',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool go() {//function go takes nothing returns boolean
			Bj(z4, 'h065', 300., .0, .0);//call Bj(z4,'h065',300.,.0,.0)
			return false;//return false
		}//endfunction
		private bool ho() {//function ho takes nothing returns boolean
			Bj(z4, 'h066', 270., .0, .0);//call Bj(z4,'h066',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool io() {//function io takes nothing returns boolean
			Bj(z4, 'h067', 270., .0, .0);//call Bj(z4,'h067',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool jo() {//function jo takes nothing returns boolean
			Bj(z4, 'h064', 270., .0, .0);//call Bj(z4,'h064',270.,.0,.0)
			return false;//return false
		}//endfunction
		private void ko() {//function ko takes nothing returns nothing
			zj('h03Y', 'h02X');//call zj('h03Y','h02X')
			a8[GetUnitPointValueByType('h03Y')] = 4;//set a8[GetUnitPointValueByType('h03Y')]=4
			zj('h03X', 'h02W');//call zj('h03X','h02W')
			a8[GetUnitPointValueByType('h03X')] = 4;//set a8[GetUnitPointValueByType('h03X')]=4
			zj('h03Z', 'h02Y');//call zj('h03Z','h02Y')
			a8[GetUnitPointValueByType('h03Z')] = 4;//set a8[GetUnitPointValueByType('h03Z')]=4
			zj('h040', 'h034');//call zj('h040','h034')
			a8[GetUnitPointValueByType('h040')] = 2;//set a8[GetUnitPointValueByType('h040')]=2
			zj('h041', 'h03N');//call zj('h041','h03N')
			a8[GetUnitPointValueByType('h041')] = 2;//set a8[GetUnitPointValueByType('h041')]=2
			zj('h042', 'h03P');//call zj('h042','h03P')
			a8[GetUnitPointValueByType('h042')] = 3;//set a8[GetUnitPointValueByType('h042')]=3
			zj('h044', 'h03R');//call zj('h044','h03R')
			a8[GetUnitPointValueByType('h044')] = 3;//set a8[GetUnitPointValueByType('h044')]=3
			zj('h045', 'h02Z');//call zj('h045','h02Z')
			a8[GetUnitPointValueByType('h045')] = 1;//set a8[GetUnitPointValueByType('h045')]=1
			zj('h046', 'u00F');//call zj('h046','u00F')
			a8[GetUnitPointValueByType('h046')] = 1;//set a8[GetUnitPointValueByType('h046')]=1
			zj('h04A', 'o00C');//call zj('h04A','o00C')
			a8[GetUnitPointValueByType('h04A')] = 5;//set a8[GetUnitPointValueByType('h04A')]=5
			zj('h04C', 'o00D');//call zj('h04C','o00D')
			a8[GetUnitPointValueByType('h04C')] = 5;//set a8[GetUnitPointValueByType('h04C')]=5
			zj('h04D', 'o00E');//call zj('h04D','o00E')
			a8[GetUnitPointValueByType('h04D')] = 5;//set a8[GetUnitPointValueByType('h04D')]=5
			zj('h04E', 'h03V');//call zj('h04E','h03V')
			a8[GetUnitPointValueByType('h04E')] = 1;//set a8[GetUnitPointValueByType('h04E')]=1
			Fj('h03X', function Qn);//call Fj('h03X',function Qn)
			Fj('h03Y', function Rn);//call Fj('h03Y',function Rn)
			Fj('h03Z', function Sn);//call Fj('h03Z',function Sn)
			Fj('h040', function Tn);//call Fj('h040',function Tn)
			Fj('h041', function Un);//call Fj('h041',function Un)
			Fj('h042', function Vn);//call Fj('h042',function Vn)
			Fj('h044', function Wn);//call Fj('h044',function Wn)
			Fj('h045', function Xn);//call Fj('h045',function Xn)
			Fj('h046', function Yn);//call Fj('h046',function Yn)
			Fj('h04A', function Zn);//call Fj('h04A',function Zn)
			Fj('h04C', function do);//call Fj('h04C',function do)
			Fj('h04D', function eo);//call Fj('h04D',function eo)
			Fj('h04E', function fo);//call Fj('h04E',function fo)
			Fj('h05Z', function ho);//call Fj('h05Z',function ho)
			Fj('h060', function go);//call Fj('h060',function go)
			Fj('h061', function io);//call Fj('h061',function io)
			Fj('h063', function jo);//call Fj('h063',function jo)
			lj('h060', function Pn);//call lj('h060',function Pn)
			lj('h05Z', function Nn);//call lj('h05Z',function Nn)
			Ij('h061', 700.);//call Ij('h061',700.)
		}//endfunction
		private void mo() {//function mo takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03X')
			t4[id] = GetUnitGoldCost(858810407);//set t4[id]=GetUnitGoldCost('h03X')
			u4[id] = GetUnitGoldCost(858810407)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h03X')*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03Y')
			t4[id] = GetUnitGoldCost(858810407);//set t4[id]=GetUnitGoldCost('h03Y')
			u4[id] = GetUnitGoldCost(858810407)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h03Y')*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03Z')
			t4[id] = GetUnitGoldCost(858810407);//set t4[id]=GetUnitGoldCost('h03Z')
			u4[id] = GetUnitGoldCost(858810407)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h03Z')*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h042')
			t4[id] = GetUnitGoldCost(875587623);//set t4[id]=GetUnitGoldCost('h042')
			u4[id] = GetUnitGoldCost(875587623)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h042')*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h044')
			t4[id] = GetUnitGoldCost(875587623);//set t4[id]=GetUnitGoldCost('h044')
			u4[id] = GetUnitGoldCost(875587623)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h044')*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h045')
			t4[id] = GetUnitGoldCost(875587623);//set t4[id]=GetUnitGoldCost('h045')
			u4[id] = GetUnitGoldCost(875587623)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h045')*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h046')
			t4[id] = GetUnitGoldCost(875587623);//set t4[id]=GetUnitGoldCost('h046')
			u4[id] = GetUnitGoldCost(875587623)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h046')*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04A')
			t4[id] = GetUnitGoldCost(875587623);//set t4[id]=GetUnitGoldCost('h04A')
			u4[id] = GetUnitGoldCost(875587623)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h04A')*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04C')
			t4[id] = GetUnitGoldCost(875587623);//set t4[id]=GetUnitGoldCost('h04C')
			u4[id] = GetUnitGoldCost(875587623)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h04C')*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04D')
			t4[id] = GetUnitGoldCost(875587623);//set t4[id]=GetUnitGoldCost('h04D')
			u4[id] = GetUnitGoldCost(875587623)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h04D')*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h040')
			t4[id] = GetUnitGoldCost(875587623);//set t4[id]=GetUnitGoldCost('h040')
			u4[id] = GetUnitGoldCost(875587623)*.18/ 100.;//set u4[id]=GetUnitGoldCost('h040')*.18/ 100.
			v4[id] = true;//set v4[id]=true
			w4[id] = true;//set w4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h041')
			t4[id] = GetUnitGoldCost(875587623);//set t4[id]=GetUnitGoldCost('h041')
			u4[id] = GetUnitGoldCost(875587623)*.18/ 100.;//set u4[id]=GetUnitGoldCost('h041')*.18/ 100.
			v4[id] = true;//set v4[id]=true
			w4[id] = true;//set w4[id]=true
			id = GetUnitPointValueByType(909142055);//set id=GetUnitPointValueByType('h061')
			t4[id] = GetUnitGoldCost(909142055);//set t4[id]=GetUnitGoldCost('h061')
			u4[id] = GetUnitGoldCost(909142055)*.08/ 100.;//set u4[id]=GetUnitGoldCost('h061')*.08/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04E')
			t4[id] = GetUnitGoldCost(875587623);//set t4[id]=GetUnitGoldCost('h04E')
			u4[id] = GetUnitGoldCost(875587623)*.2/ 100.;//set u4[id]=GetUnitGoldCost('h04E')*.2/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(909142055);//set id=GetUnitPointValueByType('h060')
			t4[id] = GetUnitGoldCost(909142055);//set t4[id]=GetUnitGoldCost('h060')
			u4[id] = GetUnitGoldCost(909142055)*.12/ 100.;//set u4[id]=GetUnitGoldCost('h060')*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05Z')
			t4[id] = GetUnitGoldCost(892364839);//set t4[id]=GetUnitGoldCost('h05Z')
			u4[id] = GetUnitGoldCost(892364839)*.09/ 100.;//set u4[id]=GetUnitGoldCost('h05Z')*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(909142055);//set id=GetUnitPointValueByType('h062')
			t4[id] = GetUnitGoldCost(909142055);//set t4[id]=GetUnitGoldCost('h062')
			u4[id] = GetUnitGoldCost(909142055)*.12/ 100.;//set u4[id]=GetUnitGoldCost('h062')*.12/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void Elementals___RegisterUnitCasts() {//function Elementals___RegisterUnitCasts takes nothing returns nothing
			Lj('h03V', 'A0E1', function ln);//call Lj('h03V','A0E1',function ln)
		}//endfunction
		private void no() {//function no takes nothing returns nothing
			timer t = GetExpiredTimer();//local timer t=GetExpiredTimer()
			unit u = LoadUnitHandle(O9,GetHandleId(t),22);//local unit u=LoadUnitHandle(O9,GetHandleId(t),22)
			unit w = CreateUnit(GetOwningPlayer(u),808477991,GetUnitX(u),GetUnitY(u),.0);//local unit w=CreateUnit(GetOwningPlayer(u),'e008',GetUnitX(u),GetUnitY(u),.0)
			UnitAddAbility(w, 'A0DA');//call UnitAddAbility(w,'A0DA')
			IssuePointOrderById(w, $D01F9, GetUnitX(u), GetUnitY(u));//call IssuePointOrderById(w,$D01F9,GetUnitX(u),GetUnitY(u))
			UnitApplyTimedLife(w, 'BTLF', 60.);//call UnitApplyTimedLife(w,'BTLF',60.)
			SaveUnitHandle(O9, GetHandleId(t), 20, w);//call SaveUnitHandle(O9,GetHandleId(t),20,w)
			t = null;//set t=null
			u = null;//set u=null
			w = null;//set w=null
		}//endfunction
		private void oo(unit u) {//function oo takes unit u returns nothing
			int i = GetRandomInt(0,99);//local integer i=GetRandomInt(0,99)
			timer t;//local timer t
			unit w;//local unit w
			if ((i<25)) {//if(i<25)then
				UnitAddAbility(u, 'A0D8');//call UnitAddAbility(u,'A0D8')
			} else if ((i<50)) {//elseif(i<50)then
				UnitAddAbility(u, 'A0D9');//call UnitAddAbility(u,'A0D9')
				UnitAddAbility(u, 'A0EX');//call UnitAddAbility(u,'A0EX')
			} else if ((i<75)) {//elseif(i<75)then
				UnitAddAbility(u, 'A03Q');//call UnitAddAbility(u,'A03Q')
				UnitAddAbility(u, 'A0EV');//call UnitAddAbility(u,'A0EV')
			} else {//else
				UnitAddAbility(u, 'A0EW');//call UnitAddAbility(u,'A0EW')
				t = CreateTimer();//set t=CreateTimer()
				w = CreateUnit(GetOwningPlayer(u),808477991,GetUnitX(u),GetUnitY(u),.0);//set w=CreateUnit(GetOwningPlayer(u),'e008',GetUnitX(u),GetUnitY(u),.0)
				UnitAddAbility(w, 'A0DA');//call UnitAddAbility(w,'A0DA')
				IssuePointOrderById(w, $D01F9, GetUnitX(u), GetUnitY(u));//call IssuePointOrderById(w,$D01F9,GetUnitX(u),GetUnitY(u))
				UnitApplyTimedLife(w, 'BTLF', 60.);//call UnitApplyTimedLife(w,'BTLF',60.)
				SaveTimerHandle(O9, GetHandleId(u), 21, t);//call SaveTimerHandle(O9,GetHandleId(u),21,t)
				SaveUnitHandle(O9, GetHandleId(t), 20, w);//call SaveUnitHandle(O9,GetHandleId(t),20,w)
				SaveUnitHandle(O9, GetHandleId(t), 22, u);//call SaveUnitHandle(O9,GetHandleId(t),22,u)
				TimerStart(t, 60., true, function no);//call TimerStart(t,60.,true,function no)
				t = null;//set t=null
				w = null;//set w=null
			}//endif
		}//endfunction
		private void po(unit u) {//function po takes unit u returns nothing
			timer t = LoadTimerHandle(O9,GetHandleId(u),21);//local timer t=LoadTimerHandle(O9,GetHandleId(u),21)
			if ((t!=null)) {//if(t!=null)then
				PauseTimer(t);//call PauseTimer(t)
				RemoveUnit(LoadUnitHandle(O9, GetHandleId(t), 20));//call RemoveUnit(LoadUnitHandle(O9,GetHandleId(t),20))
				FlushChildHashtable(O9, GetHandleId(t));//call FlushChildHashtable(O9,GetHandleId(t))
				DestroyTimer(t);//call DestroyTimer(t)
				t = null;//set t=null
			}//endif
		}//endfunction
		private void qo(player p) {//function qo takes player p returns nothing
			int id = me[GetPlayerId(p)];//local integer id=me[GetPlayerId(p)]
			Kd[id] = Kd[id]+(1);//set Kd[id]=Kd[id]+(1)
		}//endfunction
		private void ro(unit u) {//function ro takes unit u returns nothing
			int id = me[GetPlayerId(GetOwningPlayer(u))];//local integer id=me[GetPlayerId(GetOwningPlayer(u))]
			Kd[id] = Kd[id]-(1);//set Kd[id]=Kd[id]-(1)
		}//endfunction
		private void so() {//function so takes nothing returns nothing
			unit u;//local unit u
			ko();//call ko()
			mo();//call mo()
			Lj('h03V', 'A0E1', function ln);//call Lj('h03V','A0E1',function ln)
			B8 = Filter(function On);//set B8=Filter(function On)
			u = CreateUnit(Player($D),808477991,.0,.0,.0);//set u=CreateUnit(Player($D),'e008',.0,.0,.0)
			UnitAddAbility(u, 'A0DA');//call UnitAddAbility(u,'A0DA')
			RemoveUnit(u);//call RemoveUnit(u)
			u = null;//set u=null
		}//endfunction
		private bool uo() {//function uo takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && (D8 || GetUnitAbilityLevel(u,1177567527)<=0);//local boolean Im=GetWidgetLife(u)>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and(D8 or GetUnitAbilityLevel(u,'A0F1')<=0)
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void vo() {//function vo takes nothing returns nothing
			int i = GetRandomInt(1,3);//local integer i=GetRandomInt(1,3)
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			D8 = false;//set D8=false
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, E8);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,E8)
			bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				D8 = true;//set D8=true
				GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, E8);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,E8)
				bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
				if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
					return;//return
				}//endif
			}//endif
			UnitAddAbility(bj_groupRandomCurrentPick, 'A03B');//call UnitAddAbility(bj_groupRandomCurrentPick,'A03B')
			UnitAddAbility(bj_groupRandomCurrentPick, 'A03A');//call UnitAddAbility(bj_groupRandomCurrentPick,'A03A')
			UnitAddAbility(bj_groupRandomCurrentPick, 'A03D');//call UnitAddAbility(bj_groupRandomCurrentPick,'A03D')
			UnitAddAbility(bj_groupRandomCurrentPick, 'A08L');//call UnitAddAbility(bj_groupRandomCurrentPick,'A08L')
			if ((i==1)) {//if(i==1)then
				UnitAddAbility(bj_groupRandomCurrentPick, 'A05I');//call UnitAddAbility(bj_groupRandomCurrentPick,'A05I')
				UnitAddAbility(bj_groupRandomCurrentPick, 'A06W');//call UnitAddAbility(bj_groupRandomCurrentPick,'A06W')
			} else if ((i==2)) {//elseif(i==2)then
				UnitAddAbility(bj_groupRandomCurrentPick, 'A08M');//call UnitAddAbility(bj_groupRandomCurrentPick,'A08M')
				UnitAddAbility(bj_groupRandomCurrentPick, 'A06Y');//call UnitAddAbility(bj_groupRandomCurrentPick,'A06Y')
			} else {//else
				UnitAddAbility(bj_groupRandomCurrentPick, 'A08R');//call UnitAddAbility(bj_groupRandomCurrentPick,'A08R')
				UnitAddAbility(bj_groupRandomCurrentPick, 'A06X');//call UnitAddAbility(bj_groupRandomCurrentPick,'A06X')
			}//endif
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Undead\\ReplenishHealth\\ReplenishHealthCasterOverhead.mdl", bj_groupRandomCurrentPick, "overhead"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Undead\\ReplenishHealth\\ReplenishHealthCasterOverhead.mdl",bj_groupRandomCurrentPick,"overhead"))
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl", GetUnitX(B4), GetUnitY(B4)));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl",GetUnitX(B4),GetUnitY(B4)))
		}//endfunction
		private void wo() {//function wo takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(B4),808477991,GetUnitX(B4),GetUnitY(B4),.0);//local unit c=CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(B4),GetUnitY(B4),.0)
			UnitAddAbility(c, 'A031');//call UnitAddAbility(c,'A031')
			IssueImmediateOrderById(c, $D009F);//call IssueImmediateOrderById(c,$D009F)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = B4;//set c=B4
			TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			SetUnitAnimation(c, "stand");//call SetUnitAnimation(c,"stand")
			c = null;//set c=null
		}//endfunction
		private void xo() {//function xo takes nothing returns nothing
			unit c;//local unit c
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			c = CreateUnit(GetOwningPlayer(B4),808477991,GetUnitX(B4),GetUnitY(B4),.0);//set c=CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(B4),GetUnitY(B4),.0)
			UnitAddAbility(c, 'A030');//call UnitAddAbility(c,'A030')
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
			IssueTargetOrderById(c, $D02B6, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D02B6,bj_groupRandomCurrentPick)
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
			UnitApplyTimedLife(c, 'BTLF', 30.);//call UnitApplyTimedLife(c,'BTLF',30.)
			c = B4;//set c=B4
			TriggerSleepAction(.5);//call TriggerSleepAction(.5)
			SetUnitAnimation(c, "attack");//call SetUnitAnimation(c,"attack")
			TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			SetUnitAnimation(c, "stand");//call SetUnitAnimation(c,"stand")
			c = null;//set c=null
		}//endfunction
		private void yo() {//function yo takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//local unit c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(c, 'A06H');//call UnitAddAbility(c,'A06H')
			IssueTargetOrderById(c, $D008A, D4);//call IssueTargetOrderById(c,$D008A,D4)
			UnitApplyTimedLife(c, 'BTLF', 2.);//call UnitApplyTimedLife(c,'BTLF',2.)
			c = null;//set c=null
		}//endfunction
		private void zo() {//function zo takes nothing returns nothing
			lj('h02R', function vo);//call lj('h02R',function vo)
			zj('h02P', 'o009');//call zj('h02P','o009')
			zj('h02K', 'o007');//call zj('h02K','o007')
			zj('h092', 'o00B');//call zj('h092','o00B')
			zj('h035', 'o008');//call zj('h035','o008')
			zj('h036', 'o006');//call zj('h036','o006')
			lj('h02O', function wo);//call lj('h02O',function wo)
			lj('h02N', function xo);//call lj('h02N',function xo)
			zj('h029', 'o002');//call zj('h029','o002')
			zj('h02U', 'o004');//call zj('h02U','o004')
			zj('h031', 'o005');//call zj('h031','o005')
			zj('h02B', 'o003');//call zj('h02B','o003')
			zj('h02I', 'o001');//call zj('h02I','o001')
			Ij('o000', 900.);//call Ij('o000',900.)
			zj('h02H', 'n00V');//call zj('h02H','n00V')
			zj('h05E', 'n01O');//call zj('h05E','n01O')
		}//endfunction
		private void Ao() {//function Ao takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02P')
			t4[id] = $DC;//set t4[id]=$DC
			u4[id] = $DC*.2/ 100.;//set u4[id]=$DC*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02K')
			t4[id] = 260;//set t4[id]=260
			u4[id] = 260*.2/ 100.;//set u4[id]=260*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h092')
			t4[id] = 'd';//set t4[id]='d'
			u4[id] = 'd'*.2/ 100.;//set u4[id]='d'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h035')
			t4[id] = 'd';//set t4[id]='d'
			u4[id] = 'd'*.2/ 100.;//set u4[id]='d'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h036')
			t4[id] = 'd';//set t4[id]='d'
			u4[id] = 'd'*.2/ 100.;//set u4[id]='d'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h029')
			t4[id] = 'n';//set t4[id]='n'
			u4[id] = 'n'*.2/ 100.;//set u4[id]='n'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02U')
			t4[id] = 'd';//set t4[id]='d'
			u4[id] = 'd'*.2/ 100.;//set u4[id]='d'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h031')
			t4[id] = $F0;//set t4[id]=$F0
			u4[id] = $F0*.2/ 100.;//set u4[id]=$F0*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02B')
			t4[id] = $AA;//set t4[id]=$AA
			u4[id] = $AA*.2/ 100.;//set u4[id]=$AA*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02I')
			t4[id] = 380;//set t4[id]=380
			u4[id] = 380*.18/ 100.;//set u4[id]=380*.18/ 100.
			v4[id] = true;//set v4[id]=true
			w4[id] = true;//set w4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02H')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05E')
			t4[id] = 80;//set t4[id]=80
			u4[id] = 80*.2/ 100.;//set u4[id]=80*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02R')
			t4[id] = $FA;//set t4[id]=$FA
			u4[id] = $FA*.12/ 100.;//set u4[id]=$FA*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02O')
			t4[id] = 475;//set t4[id]=475
			u4[id] = 475*.12/ 100.;//set u4[id]=475*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(808480551);//set id=GetUnitPointValueByType('o000')
			t4[id] = $AF;//set t4[id]=$AF
			u4[id] = $AF*.08/ 100.;//set u4[id]=$AF*.08/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02N')
			t4[id] = 270;//set t4[id]=270
			u4[id] = 270*.09/ 100.;//set u4[id]=270*.09/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void Orc___RegisterUnitCasts() {//function Orc___RegisterUnitCasts takes nothing returns nothing
			Lj('n01O', 'A06I', function yo);//call Lj('n01O','A06I',function yo)
		}//endfunction
		private void ao() {//function ao takes nothing returns nothing
			zo();//call zo()
			Ao();//call Ao()
			Lj('n01O', 'A06I', function yo);//call Lj('n01O','A06I',function yo)
			E8 = Filter(function uo);//set E8=Filter(function uo)
		}//endfunction
		private void SmartGroup___DEBUGstateShow() {//function SmartGroup___DEBUGstateShow takes nothing returns nothing
			int i = 0;//local integer i=0
			string s = "Units at filter: ";//local string s="Units at filter: "
			DisplayTextToPlayer(GetLocalPlayer(), .0, .0, "Filter called, total count: "+I2S(H8));//call DisplayTextToPlayer(GetLocalPlayer(),.0,.0,"Filter called, total count: "+I2S(H8))
			i = 0;//set i=0
			while (true) {//loop
				s = s+GetUnitName(G8[i])+" ";//set s=s+GetUnitName(G8[i])+" "
				i = i+1;//set i=i+1
				if (i>H8) { break; }//exitwhen i>H8
			}//endloop
			DisplayTextToPlayer(GetLocalPlayer(), .0, .0, s);//call DisplayTextToPlayer(GetLocalPlayer(),.0,.0,s)
			i = 0;//set i=0
			s = "Areas at filter: ";//set s="Areas at filter: "
			while (true) {//loop
				s = s+I2S(I8[i])+" ";//set s=s+I2S(I8[i])+" "
				i = i+1;//set i=i+1
				if (i>l8) { break; }//exitwhen i>l8
			}//endloop
			DisplayTextToPlayer(GetLocalPlayer(), .0, .0, s);//call DisplayTextToPlayer(GetLocalPlayer(),.0,.0,s)
		}//endfunction
		private bool Bo() {//function Bo takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			if ((GetWidgetLife(u)>.405 && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitAlly(u,r4) && GetUnitAbilityLevel(u,1970684199)<=0)) {//if(GetWidgetLife(u)>.405 and IsUnitType(u,UNIT_TYPE_SAPPER)and IsUnitAlly(u,r4)and GetUnitAbilityLevel(u,'Avul')<=0)then
				F8[H8] = u;//set F8[H8]=u
				H8 = H8+1;//set H8=H8+1
			}//endif
			u = null;//set u=null
			return false;//return false
		}//endfunction
		private bool bo() {//function bo takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			if ((GetWidgetLife(u)>.405 && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitEnemy(u,r4) && GetUnitAbilityLevel(u,1970684199)<=0)) {//if(GetWidgetLife(u)>.405 and IsUnitType(u,UNIT_TYPE_SAPPER)and IsUnitEnemy(u,r4)and GetUnitAbilityLevel(u,'Avul')<=0)then
				F8[H8] = u;//set F8[H8]=u
				H8 = H8+1;//set H8=H8+1
			}//endif
			u = null;//set u=null
			return false;//return false
		}//endfunction
		private void Co() {//function Co takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if (i>=H8) { break; }//exitwhen i>=H8
				G8[i] = F8[i];//set G8[i]=F8[i]
				i = i+1;//set i=i+1
			}//endloop
			l8 = 0;//set l8=0
			I8[0] = 0;//set I8[0]=0
		}//endfunction
		private void co(player p, float x, float y, float r) {//function co takes player p,real x,real y,real r returns nothing
			l8 = 0;//set l8=0
			I8[0] = 0;//set I8[0]=0
			r4 = p;//set r4=p
			H8 = 0;//set H8=0
			GroupEnumUnitsInRange(q4, x, y, r, K8);//call GroupEnumUnitsInRange(q4,x,y,r,K8)
		}//endfunction
		private bool Do(int Eo) {//function Do takes integer Eo returns boolean
			int i = I8[l8];//local integer i=I8[l8]
			int j = H8;//local integer j=H8
			unit u;//local unit u
			while (true) {//loop
				if (i>=j) { break; }//exitwhen i>=j
				if ((ti(Eo,G8[i]))) {//if(ti(Eo,G8[i]))then
					j = j-1;//set j=j-1
					u = G8[j];//set u=G8[j]
					G8[j] = G8[i];//set G8[j]=G8[i]
					G8[i] = u;//set G8[i]=u
				} else {//else
					i = i+1;//set i=i+1
				}//endif
			}//endloop
			if ((i<H8)) {//if(i<H8)then
				l8 = l8+1;//set l8=l8+1
				I8[l8] = i;//set I8[l8]=i
			}//endif
			u = null;//set u=null
			DisplayTextToPlayer(GetLocalPlayer(), .0, .0, I2S(i)+":"+I2S(j)+":"+I2S(H8));//call DisplayTextToPlayer(GetLocalPlayer(),.0,.0,I2S(i)+":"+I2S(j)+":"+I2S(H8))
			return j==H8;//return j==H8
		}//endfunction
		private unit SmartGroup_GetRandomUnitLastArea() {//function SmartGroup_GetRandomUnitLastArea takes nothing returns unit
			if ((I8[l8]>=H8)) {//if(I8[l8]>=H8)then
				return null;//return null
			}//endif
			return G8[GetRandomInt(I8[l8],H8-1)];//return G8[GetRandomInt(I8[l8],H8-1)]
		}//endfunction
		private unit Fo() {//function Fo takes nothing returns unit
			if ((I8[l8]>=H8)) {//if(I8[l8]>=H8)then
				return null;//return null
			}//endif
			return G8[H8-1];//return G8[H8-1]
		}//endfunction
		private void Go() {//function Go takes nothing returns nothing
			J8 = Filter(function Bo);//set J8=Filter(function Bo)
			K8 = Filter(function bo);//set K8=Filter(function bo)
		}//endfunction
		private bool Ho() {//function Ho takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			float r = GetWidgetLife(u);//local real r=GetWidgetLife(u)
			bool Im = r>.405 && IsUnitEnemy(u,r4) && GetUnitAbilityLevel(u,1127235879)>0 && GetUnitAbilityLevel(u,1648902695)<=0 && GetUnitAbilityLevel(u,1110458663)<=0;//local boolean Im=r>.405 and IsUnitEnemy(u,r4)and GetUnitAbilityLevel(u,'A0CV')>0 and GetUnitAbilityLevel(u,'BHbn')<=0 and GetUnitAbilityLevel(u,'A0BG')<=0
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private bool Io() {//function Io takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			float r = GetWidgetLife(u);//local real r=GetWidgetLife(u)
			bool Im = r>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitType(u,UNIT_TYPE_GROUND) && GetUnitAbilityLevel(u,942686503)<=0 && GetUnitAbilityLevel(u,1110458663)<=0 && GetUnitAbilityLevel(u,825246247)<=0 && GetUnitAbilityLevel(u,1648902695)<=0  && ((GetUnitState(u,UNIT_STATE_MAX_MANA)>100. && r<=600.) || r<=300.);//local boolean Im=r>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and IsUnitType(u,UNIT_TYPE_GROUND)and GetUnitAbilityLevel(u,'A08H')<=0 and GetUnitAbilityLevel(u,'A0BG')<=0 and GetUnitAbilityLevel(u,'B012')<=0 and GetUnitAbilityLevel(u,'BHbn')<=0 and((GetUnitState(u,UNIT_STATE_MAX_MANA)>100. and r<=600.)or r<=300.)
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private bool lo() {//function lo takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitType(u,UNIT_TYPE_GROUND) && GetUnitAbilityLevel(u,1970684199)<=0 && GetUnitAbilityLevel(u,942686503)<=0 && GetUnitAbilityLevel(u,1110458663)<=0 && GetUnitAbilityLevel(u,825246247)<=0 && GetUnitAbilityLevel(u,1648902695)<=0;//local boolean Im=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and IsUnitType(u,UNIT_TYPE_GROUND)and GetUnitAbilityLevel(u,'Avul')<=0 and GetUnitAbilityLevel(u,'A08H')<=0 and GetUnitAbilityLevel(u,'A0BG')<=0 and GetUnitAbilityLevel(u,'B012')<=0 and GetUnitAbilityLevel(u,'BHbn')<=0
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private bool Jo() {//function Jo takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			float r = GetWidgetLife(u);//local real r=GetWidgetLife(u)
			bool Im = r>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_STRUCTURE) && GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>50.;//local boolean Im=r>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_STRUCTURE)and GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>50.
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private bool Ko() {//function Ko takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			float r = GetWidgetLife(u);//local real r=GetWidgetLife(u)
			bool Im = r>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_MECHANICAL) && GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>50.;//local boolean Im=r>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_MECHANICAL)and GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>50.
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void Lo(unit u) {//function Lo takes unit u returns nothing
			int bj = GetUnitPointValue(u);//local integer bj=GetUnitPointValue(u)
			int id = GetUnitUserData(u);//local integer id=GetUnitUserData(u)
			r4 = GetOwningPlayer(u);//set r4=GetOwningPlayer(u)
			if ((bj==$81)) {//if(bj==$81)then
				if ((L8[id]!=null && GetWidgetLife(L8[id])>.405 && IsUnitEnemy(L8[id],r4))) {//if(L8[id]!=null and GetWidgetLife(L8[id])>.405 and IsUnitEnemy(L8[id],r4))then
					if ((GetUnitAbilityLevel(L8[id],825246247)>0 || GetUnitAbilityLevel(L8[id],1648902695)>0)) {//if(GetUnitAbilityLevel(L8[id],'B012')>0 or GetUnitAbilityLevel(L8[id],'BHbn')>0)then
						L8[id] = null;//set L8[id]=null
					} else if ((!IssueTargetOrderById(u,$D000F,L8[id]))) {//elseif(not IssueTargetOrderById(u,$D000F,L8[id]))then
						IssuePointOrderById(u, $D0012, GetUnitX(L8[id]), GetUnitY(L8[id]));//call IssuePointOrderById(u,$D0012,GetUnitX(L8[id]),GetUnitY(L8[id]))
					}//endif
				} else if ((GetUnitAbilityLevel(u,825246247)>0 || IssueImmediateOrderById(u,$D00A1))) {//elseif(GetUnitAbilityLevel(u,'B012')>0 or IssueImmediateOrderById(u,$D00A1))then
					GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, P8);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,P8)
					bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
					if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
						GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Q8);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,Q8)
						bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
					}//endif
					if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
						IssuePointOrderById(u, $D0012, GetUnitX(u), GetUnitY(u));//call IssuePointOrderById(u,$D0012,GetUnitX(u),GetUnitY(u))
					} else {//else
						L8[id] = bj_groupRandomCurrentPick;//set L8[id]=bj_groupRandomCurrentPick
						IssuePointOrderById(u, $D0012, GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick));//call IssuePointOrderById(u,$D0012,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick))
					}//endif
				} else {//else
					IssuePointOrderByIdLoc(u, $D000F, Id[me[GetPlayerId(r4)]]);//call IssuePointOrderByIdLoc(u,$D000F,Id[me[GetPlayerId(r4)]])
				}//endif
			} else if ((bj==$82)) {//elseif(bj==$82)then
				if ((L8[id]==null)) {//if(L8[id]==null)then
					GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, S8);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,S8)
					bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
					if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
						GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, T8);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,T8)
						bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
					}//endif
					L8[id] = u;//set L8[id]=u
					if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
						N8[id] = GetUnitX(u);//set N8[id]=GetUnitX(u)
						O8[id] = GetUnitY(u);//set O8[id]=GetUnitY(u)
					} else {//else
						N8[id] = GetUnitX(bj_groupRandomCurrentPick);//set N8[id]=GetUnitX(bj_groupRandomCurrentPick)
						O8[id] = GetUnitY(bj_groupRandomCurrentPick);//set O8[id]=GetUnitY(bj_groupRandomCurrentPick)
					}//endif
					IssuePointOrderById(u, $D000F, N8[id], O8[id]);//call IssuePointOrderById(u,$D000F,N8[id],O8[id])
				} else {//else
					IssuePointOrderById(u, $D000F, N8[id], O8[id]);//call IssuePointOrderById(u,$D000F,N8[id],O8[id])
				}//endif
			}//endif
		}//endfunction
		private void Mo(unit u) {//function Mo takes unit u returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if (M8[i]==false) { break; }//exitwhen M8[i]==false
				i = i+1;//set i=i+1
			}//endloop
			M8[i] = true;//set M8[i]=true
			L8[i] = null;//set L8[i]=null
			SetUnitUserData(u, i);//call SetUnitUserData(u,i)
			if ((GetUnitTypeId(u)==825257511)) {//if(GetUnitTypeId(u)=='n01U')then
				UnitApplyTimedLife(u, 'BTLF', 'x');//call UnitApplyTimedLife(u,'BTLF','x')
			}//endif
		}//endfunction
		private void No() {//function No takes nothing returns nothing
			P8 = Filter(function Ho);//set P8=Filter(function Ho)
			Q8 = Filter(function Io);//set Q8=Filter(function Io)
			R8 = Filter(function lo);//set R8=Filter(function lo)
			S8 = Filter(function Jo);//set S8=Filter(function Jo)
			T8 = Filter(function Ko);//set T8=Filter(function Ko)
		}//endfunction
		private void AdvancedSmartGroup_PrepareSorting() {//function AdvancedSmartGroup_PrepareSorting takes nothing returns nothing
			Co();//call Co()
		}//endfunction
		private unit Oo(int s1, int s2, int s3, int s4) {//function Oo takes integer s1,integer s2,integer s3,integer s4 returns unit
			Co();//call Co()
			if ((Do(s1))) {//if(Do(s1))then
				DisplayTextToPlayer(GetLocalPlayer(), .0, .0, "G:s1 returned");//call DisplayTextToPlayer(GetLocalPlayer(),.0,.0,"G:s1 returned")
				return null;//return null
			}//endif
			if ((s2!=0)) {//if(s2!=0)then
				if ((Do(s2))) {//if(Do(s2))then
					DisplayTextToPlayer(GetLocalPlayer(), .0, .0, "G:s2 returned");//call DisplayTextToPlayer(GetLocalPlayer(),.0,.0,"G:s2 returned")
					return Fo();//return Fo()
				}//endif
			}//endif
			if ((s3!=0)) {//if(s3!=0)then
				if ((Do(s3))) {//if(Do(s3))then
					DisplayTextToPlayer(GetLocalPlayer(), .0, .0, "G:s3 returned");//call DisplayTextToPlayer(GetLocalPlayer(),.0,.0,"G:s3 returned")
					return Fo();//return Fo()
				}//endif
			}//endif
			if ((s4!=0)) {//if(s4!=0)then
				Do(s4);//call Do(s4)
			}//endif
			return Fo();//return Fo()
		}//endfunction
		private void Po(unit u) {//function Po takes unit u returns nothing
			IssuePointOrderByIdLoc(u, $D000F, Id[me[GetPlayerId(GetOwningPlayer(u))]]);//call IssuePointOrderByIdLoc(u,$D000F,Id[me[GetPlayerId(GetOwningPlayer(u))]])
		}//endfunction
		private void Qo(unit u) {//function Qo takes unit u returns nothing
			if ((IsUnitType(u,UNIT_TYPE_TAUREN))) {//if(IsUnitType(u,UNIT_TYPE_TAUREN))then
				return;//return
			}//endif
			if ((GetUnitAbilityLevel(u,925909287)>=1)) {//if(GetUnitAbilityLevel(u,'A07M')>=1)then
				Lo(u);//call Lo(u)
			} else {//else
				IssuePointOrderByIdLoc(u, $D000F, Id[me[GetPlayerId(GetOwningPlayer(u))]]);//call IssuePointOrderByIdLoc(u,$D000F,Id[me[GetPlayerId(GetOwningPlayer(u))]])
			}//endif
		}//endfunction
		private float Ro(float x, float y) {//function Ro takes real x,real y returns real
			return SquareRoot(x*x+y*y);//return SquareRoot(x*x+y*y)
		}//endfunction
		private void So() {//function So takes nothing returns nothing
			timer t = GetExpiredTimer();//local timer t=GetExpiredTimer()
			int id = LoadInteger(O9,GetHandleId(t),1);//local integer id=LoadInteger(O9,GetHandleId(t),1)
			if ((GetWidgetLife(U8[id])>.405 && Ro(V8[id]-GetUnitX(U8[id]),W8[id]-GetUnitY(U8[id]))>768.)) {//if(GetWidgetLife(U8[id])>.405 and Ro(V8[id]-GetUnitX(U8[id]),W8[id]-GetUnitY(U8[id]))>768.)then
				UnitRemoveAbility(U8[id], 'A0BG');//call UnitRemoveAbility(U8[id],'A0BG')
			}//endif
			Y8 = Y8-1;//set Y8=Y8-1
			X8[id] = X8[Y8];//set X8[id]=X8[Y8]
			V8[id] = V8[Y8];//set V8[id]=V8[Y8]
			W8[id] = W8[Y8];//set W8[id]=W8[Y8]
			U8[id] = U8[Y8];//set U8[id]=U8[Y8]
			SaveInteger(O9, GetHandleId(X8[Y8]), 1, id);//call SaveInteger(O9,GetHandleId(X8[Y8]),1,id)
			X8[Y8] = t;//set X8[Y8]=t
			t = null;//set t=null
		}//endfunction
		private void To() {//function To takes nothing returns nothing
			timer t = GetExpiredTimer();//local timer t=GetExpiredTimer()
			int id = LoadInteger(O9,GetHandleId(t),1);//local integer id=LoadInteger(O9,GetHandleId(t),1)
			if ((GetWidgetLife(U8[id])>.405)) {//if(GetWidgetLife(U8[id])>.405)then
				SetUnitPathing(U8[id], true);//call SetUnitPathing(U8[id],true)
				TimerStart(t, 4., false, Z8);//call TimerStart(t,4.,false,Z8)
			} else {//else
				Y8 = Y8-1;//set Y8=Y8-1
				X8[id] = X8[Y8];//set X8[id]=X8[Y8]
				V8[id] = V8[Y8];//set V8[id]=V8[Y8]
				W8[id] = W8[Y8];//set W8[id]=W8[Y8]
				U8[id] = U8[Y8];//set U8[id]=U8[Y8]
				SaveInteger(O9, GetHandleId(X8[Y8]), 1, id);//call SaveInteger(O9,GetHandleId(X8[Y8]),1,id)
				X8[Y8] = t;//set X8[Y8]=t
			}//endif
			t = null;//set t=null
		}//endfunction
		private void Uo() {//function Uo takes nothing returns nothing
			timer t = GetExpiredTimer();//local timer t=GetExpiredTimer()
			int id = LoadInteger(O9,GetHandleId(t),1);//local integer id=LoadInteger(O9,GetHandleId(t),1)
			if ((GetWidgetLife(U8[id])>.405 && Ro(V8[id]-GetUnitX(U8[id]),W8[id]-GetUnitY(U8[id]))<768.)) {//if(GetWidgetLife(U8[id])>.405 and Ro(V8[id]-GetUnitX(U8[id]),W8[id]-GetUnitY(U8[id]))<768.)then
				SetUnitPathing(U8[id], false);//call SetUnitPathing(U8[id],false)
				Qo(U8[id]);//call Qo(U8[id])
				TimerStart(t, .7, false, function To);//call TimerStart(t,.7,false,function To)
			} else {//else
				UnitRemoveAbility(U8[id], 'A0BG');//call UnitRemoveAbility(U8[id],'A0BG')
				Y8 = Y8-1;//set Y8=Y8-1
				X8[id] = X8[Y8];//set X8[id]=X8[Y8]
				V8[id] = V8[Y8];//set V8[id]=V8[Y8]
				W8[id] = W8[Y8];//set W8[id]=W8[Y8]
				U8[id] = U8[Y8];//set U8[id]=U8[Y8]
				SaveInteger(O9, GetHandleId(X8[Y8]), 1, id);//call SaveInteger(O9,GetHandleId(X8[Y8]),1,id)
				X8[Y8] = t;//set X8[Y8]=t
			}//endif
			t = null;//set t=null
		}//endfunction
		private void Vo(unit u) {//function Vo takes unit u returns nothing
			UnitAddAbility(u, 'A0BG');//call UnitAddAbility(u,'A0BG')
			if ((X8[Y8]==null)) {//if(X8[Y8]==null)then
				X8[Y8] = CreateTimer();//set X8[Y8]=CreateTimer()
			}//endif
			V8[Y8] = GetUnitX(u);//set V8[Y8]=GetUnitX(u)
			W8[Y8] = GetUnitY(u);//set W8[Y8]=GetUnitY(u)
			U8[Y8] = u;//set U8[Y8]=u
			SaveInteger(O9, GetHandleId(X8[Y8]), 1, Y8);//call SaveInteger(O9,GetHandleId(X8[Y8]),1,Y8)
			TimerStart(X8[Y8], 4., false, Z8);//call TimerStart(X8[Y8],4.,false,Z8)
			Y8 = Y8+1;//set Y8=Y8+1
		}//endfunction
		private void Wo() {//function Wo takes nothing returns nothing
			if ((ud)) {//if(ud)then
				Z8 = function Uo;//set Z8=function Uo
			} else {//else
				Z8 = function So;//set Z8=function So
			}//endif
		}//endfunction
		private void Xo() {//function Xo takes nothing returns nothing
			unit Ui = GetAttacker();//local unit Ui=GetAttacker()
			unit Yo;//local unit Yo
			if ((GetUnitAbilityLevel(Ui,1160790311)>0)) {//if(GetUnitAbilityLevel(Ui,'A0EZ')>0)then
				Yo = GetTriggerUnit();//set Yo=GetTriggerUnit()
				UnitRemoveAbility(Ui, 'A0EZ');//call UnitRemoveAbility(Ui,'A0EZ')
				TriggerSleepAction(.0);//call TriggerSleepAction(.0)
				if ((!IssueTargetOrderById(Ui,$D0279,Yo))) {//if(not IssueTargetOrderById(Ui,$D0279,Yo))then
					Po(Ui);//call Po(Ui)
				}//endif
				Yo = null;//set Yo=null
			}//endif
			Ui = null;//set Ui=null
		}//endfunction
		private void Zo() {//function Zo takes nothing returns nothing
			TriggerRegisterAnyUnitEventBJ(d9, EVENT_PLAYER_UNIT_ATTACKED);//call TriggerRegisterAnyUnitEventBJ(d9,EVENT_PLAYER_UNIT_ATTACKED)
			TriggerAddAction(d9, function Xo);//call TriggerAddAction(d9,function Xo)
		}//endfunction
		private void dp(bool ep) {//function dp takes boolean ep returns nothing
			if ((ep)) {//if(ep)then
				EnableTrigger(d9);//call EnableTrigger(d9)
			} else {//else
				DisableTrigger(d9);//call DisableTrigger(d9)
			}//endif
		}//endfunction
		private bool fp(int oi, unit u) {//function fp takes integer oi,unit u returns boolean
			return GetWidgetLife(u)<100.;//return GetWidgetLife(u)<100.
		}//endfunction
		private bool gp(int oi, unit u) {//function gp takes integer oi,unit u returns boolean
			return IsUnitType(u,UNIT_TYPE_RANGED_ATTACKER);//return IsUnitType(u,UNIT_TYPE_RANGED_ATTACKER)
		}//endfunction
		private bool hp(int oi, unit u) {//function hp takes integer oi,unit u returns boolean
			return IsUnitType(u,UNIT_TYPE_MELEE_ATTACKER);//return IsUnitType(u,UNIT_TYPE_MELEE_ATTACKER)
		}//endfunction
		private bool ip(int oi, unit u) {//function ip takes integer oi,unit u returns boolean
			return IsUnitType(u,UNIT_TYPE_FLYING);//return IsUnitType(u,UNIT_TYPE_FLYING)
		}//endfunction
		private bool jp(int oi, unit u) {//function jp takes integer oi,unit u returns boolean
			return IsUnitType(u,UNIT_TYPE_GROUND);//return IsUnitType(u,UNIT_TYPE_GROUND)
		}//endfunction
		private bool kp(int oi, unit u) {//function kp takes integer oi,unit u returns boolean
			return LoadInteger(i9,GetUnitTypeId(u),1)==0;//return LoadInteger(i9,GetUnitTypeId(u),1)==0
		}//endfunction
		private bool np(int oi, unit u) {//function np takes integer oi,unit u returns boolean
			return LoadInteger(i9,GetUnitTypeId(u),1)==1;//return LoadInteger(i9,GetUnitTypeId(u),1)==1
		}//endfunction
		private bool pp(int oi, unit u) {//function pp takes integer oi,unit u returns boolean
			return LoadInteger(i9,GetUnitTypeId(u),1)==2;//return LoadInteger(i9,GetUnitTypeId(u),1)==2
		}//endfunction
		private bool qp(int oi, unit u) {//function qp takes integer oi,unit u returns boolean
			return LoadInteger(i9,GetUnitTypeId(u),1)==3;//return LoadInteger(i9,GetUnitTypeId(u),1)==3
		}//endfunction
		private bool rp(int oi, unit u) {//function rp takes integer oi,unit u returns boolean
			return LoadInteger(i9,GetUnitTypeId(u),1)==4;//return LoadInteger(i9,GetUnitTypeId(u),1)==4
		}//endfunction
		private bool sp(int oi, unit u) {//function sp takes integer oi,unit u returns boolean
			return LoadInteger(i9,GetUnitTypeId(u),1)==5;//return LoadInteger(i9,GetUnitTypeId(u),1)==5
		}//endfunction
		private bool tp(int oi, unit u) {//function tp takes integer oi,unit u returns boolean
			return LoadInteger(i9,GetUnitTypeId(u),1)==6;//return LoadInteger(i9,GetUnitTypeId(u),1)==6
		}//endfunction
		private bool up(int oi, unit u) {//function up takes integer oi,unit u returns boolean
			int vp = LoadInteger(i9,GetUnitTypeId(u),1);//local integer vp=LoadInteger(i9,GetUnitTypeId(u),1)
			return vp==1 || vp==6;//return vp==1 or vp==6
		}//endfunction
		private bool UnitsAI___Enemy() {//function UnitsAI___Enemy takes nothing returns boolean
			return IsUnitEnemy(GetFilterUnit(),e9);//return IsUnitEnemy(GetFilterUnit(),e9)
		}//endfunction
		private bool UnitsAI___Alive() {//function UnitsAI___Alive takes nothing returns boolean
			return GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7;//return GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7
		}//endfunction
		private bool UnitsAI___Damaged() {//function UnitsAI___Damaged takes nothing returns boolean
			return GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.;//return GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.
		}//endfunction
		private bool UnitsAI___RangedUnit() {//function UnitsAI___RangedUnit takes nothing returns boolean
			return (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))!=null;//return(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))!=null
		}//endfunction
		private bool UnitsAI___MeleeUnit() {//function UnitsAI___MeleeUnit takes nothing returns boolean
			return (IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER))!=null;//return(IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER))!=null
		}//endfunction
		private bool UnitsAI___Air() {//function UnitsAI___Air takes nothing returns boolean
			return (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING))!=null;//return(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING))!=null
		}//endfunction
		private bool UnitsAI___Ground() {//function UnitsAI___Ground takes nothing returns boolean
			return (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))!=null;//return(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))!=null
		}//endfunction
		private bool UnitsAI___HeroDef() {//function UnitsAI___HeroDef takes nothing returns boolean
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0;//return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0
		}//endfunction
		private bool UnitsAI___LightDef() {//function UnitsAI___LightDef takes nothing returns boolean
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1;//return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1
		}//endfunction
		private bool UnitsAI___HeavyDef() {//function UnitsAI___HeavyDef takes nothing returns boolean
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2;//return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2
		}//endfunction
		private bool UnitsAI___DivineDef() {//function UnitsAI___DivineDef takes nothing returns boolean
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3;//return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3
		}//endfunction
		private bool UnitsAI___MediumDef() {//function UnitsAI___MediumDef takes nothing returns boolean
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4;//return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4
		}//endfunction
		private bool UnitsAI___FortifiedDef() {//function UnitsAI___FortifiedDef takes nothing returns boolean
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==5;//return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==5
		}//endfunction
		private bool UnitsAI___UnarmoredDef() {//function UnitsAI___UnarmoredDef takes nothing returns boolean
			return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6;//return LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6
		}//endfunction
		private bool wp() {//function wp takes nothing returns boolean
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool xp() {//function xp takes nothing returns boolean
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool yp() {//function yp takes nothing returns boolean
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool zp() {//function zp takes nothing returns boolean
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Ap() {//function Ap takes nothing returns boolean
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool ap() {//function ap takes nothing returns boolean
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((IsUnitType(GetFilterUnit(),UNIT_TYPE_MELEE_ATTACKER))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Bp() {//function Bp takes nothing returns boolean
			return (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1);//return(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)
		}//endfunction
		private bool bp() {//function bp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Cp() {//function Cp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool cp() {//function cp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Dp() {//function Dp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Ep() {//function Ep takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Fp() {//function Fp takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool UnitsAI___meleeSiege8() {//function UnitsAI___meleeSiege8 takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Gp() {//function Gp takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Hp() {//function Hp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Ip() {//function Ip takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool lp() {//function lp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Jp() {//function Jp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Kp() {//function Kp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Lp() {//function Lp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Mp() {//function Mp takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Np() {//function Np takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Op() {//function Op takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Pp() {//function Pp takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Qp() {//function Qp takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Rp() {//function Rp takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Sp() {//function Sp takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Tp() {//function Tp takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Up() {//function Up takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Vp() {//function Vp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Wp() {//function Wp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Xp() {//function Xp takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool Yp() {//function Yp takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool Zp() {//function Zp takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool dq() {//function dq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool eq() {//function eq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool fq() {//function fq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool gq() {//function gq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool hq() {//function hq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool iq() {//function iq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool jq() {//function jq takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool kq() {//function kq takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool mq() {//function mq takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool nq() {//function nq takes nothing returns boolean
			return ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool oq() {//function oq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool qq() {//function qq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool rq() {//function rq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool sq() {//function sq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool tq() {//function tq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool uq() {//function uq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool vq() {//function vq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9)))!=null
		}//endfunction
		private bool wq() {//function wq takes nothing returns boolean
			return (((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return(((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==0)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool xq() {//function xq takes nothing returns boolean
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private bool yq() {//function yq takes nothing returns boolean
			return ((IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (IsUnitEnemy(GetFilterUnit(),e9)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null;//return((IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(IsUnitEnemy(GetFilterUnit(),e9))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7))!=null
		}//endfunction
		private void zq(int oi) {//function zq takes integer oi returns nothing
			SaveInteger(i9, 'n000', 0, 0);//call SaveInteger(i9,'n000',0,0)
			SaveInteger(i9, 'h03B', 0, 1);//call SaveInteger(i9,'h03B',0,1)
			SaveInteger(i9, 'h03C', 0, 1);//call SaveInteger(i9,'h03C',0,1)
			SaveInteger(i9, 'n01X', 0, 1);//call SaveInteger(i9,'n01X',0,1)
			SaveInteger(i9, 'n024', 0, 1);//call SaveInteger(i9,'n024',0,1)
			SaveInteger(i9, 'n01M', 0, 1);//call SaveInteger(i9,'n01M',0,1)
			SaveInteger(i9, 'z002', 0, 2);//call SaveInteger(i9,'z002',0,2)
			SaveInteger(i9, 'z003', 0, 2);//call SaveInteger(i9,'z003',0,2)
			SaveInteger(i9, 'n00B', 0, 2);//call SaveInteger(i9,'n00B',0,2)
			SaveInteger(i9, 'n01K', 0, 2);//call SaveInteger(i9,'n01K',0,2)
			SaveInteger(i9, 'u007', 0, 2);//call SaveInteger(i9,'u007',0,2)
			SaveInteger(i9, 'n00C', 0, 2);//call SaveInteger(i9,'n00C',0,2)
			SaveInteger(i9, 'n00L', 0, 2);//call SaveInteger(i9,'n00L',0,2)
			SaveInteger(i9, 'n00M', 0, 2);//call SaveInteger(i9,'n00M',0,2)
			SaveInteger(i9, 'n00N', 0, 2);//call SaveInteger(i9,'n00N',0,2)
			SaveInteger(i9, 'n00O', 0, 2);//call SaveInteger(i9,'n00O',0,2)
			SaveInteger(i9, 'n00P', 0, 2);//call SaveInteger(i9,'n00P',0,2)
			SaveInteger(i9, 'n00Q', 0, 2);//call SaveInteger(i9,'n00Q',0,2)
			SaveInteger(i9, 'n00R', 0, 2);//call SaveInteger(i9,'n00R',0,2)
			SaveInteger(i9, 'n00O', 0, 2);//call SaveInteger(i9,'n00O',0,2)
			SaveInteger(i9, 'h034', 0, 3);//call SaveInteger(i9,'h034',0,3)
			SaveInteger(i9, 'h03N', 0, 3);//call SaveInteger(i9,'h03N',0,3)
			SaveInteger(i9, 'n00E', 0, 3);//call SaveInteger(i9,'n00E',0,3)
			SaveInteger(i9, 'hfoo', 0, 4);//call SaveInteger(i9,'hfoo',0,4)
			SaveInteger(i9, 'h03A', 0, 4);//call SaveInteger(i9,'h03A',0,4)
			SaveInteger(i9, 'h02W', 0, 4);//call SaveInteger(i9,'h02W',0,4)
			SaveInteger(i9, 'h02X', 0, 4);//call SaveInteger(i9,'h02X',0,4)
			SaveInteger(i9, 'h02Y', 0, 4);//call SaveInteger(i9,'h02Y',0,4)
			SaveInteger(i9, 'o002', 0, 4);//call SaveInteger(i9,'o002',0,4)
			SaveInteger(i9, 'o004', 0, 4);//call SaveInteger(i9,'o004',0,4)
			SaveInteger(i9, 'o005', 0, 4);//call SaveInteger(i9,'o005',0,4)
			SaveInteger(i9, 'u002', 0, 4);//call SaveInteger(i9,'u002',0,4)
			SaveInteger(i9, 'u00B', 0, 4);//call SaveInteger(i9,'u00B',0,4)
			SaveInteger(i9, 'n01I', 0, 4);//call SaveInteger(i9,'n01I',0,4)
			SaveInteger(i9, 'n01H', 0, 4);//call SaveInteger(i9,'n01H',0,4)
			SaveInteger(i9, 'n027', 0, 4);//call SaveInteger(i9,'n027',0,4)
			SaveInteger(i9, 'n006', 0, 4);//call SaveInteger(i9,'n006',0,4)
			SaveInteger(i9, 'n00Y', 0, 4);//call SaveInteger(i9,'n00Y',0,4)
			SaveInteger(i9, 'n017', 0, 4);//call SaveInteger(i9,'n017',0,4)
			SaveInteger(i9, 'n018', 0, 4);//call SaveInteger(i9,'n018',0,4)
			SaveInteger(i9, 'n016', 0, 4);//call SaveInteger(i9,'n016',0,4)
			SaveInteger(i9, 'n029', 0, 4);//call SaveInteger(i9,'n029',0,4)
			SaveInteger(i9, 'n02B', 0, 4);//call SaveInteger(i9,'n02B',0,4)
			SaveInteger(i9, 'n009', 0, 4);//call SaveInteger(i9,'n009',0,4)
			SaveInteger(i9, 'n00Z', 0, 4);//call SaveInteger(i9,'n00Z',0,4)
			SaveInteger(i9, 'n00I', 0, 4);//call SaveInteger(i9,'n00I',0,4)
			SaveInteger(i9, 'n00J', 0, 4);//call SaveInteger(i9,'n00J',0,4)
			SaveInteger(i9, 'n00K', 0, 4);//call SaveInteger(i9,'n00K',0,4)
			SaveInteger(i9, 'h06U', 0, 4);//call SaveInteger(i9,'h06U',0,4)
			SaveInteger(i9, 'e00F', 0, 4);//call SaveInteger(i9,'e00F',0,4)
			SaveInteger(i9, 'o007', 0, 5);//call SaveInteger(i9,'o007',0,5)
			SaveInteger(i9, 'n01T', 0, 5);//call SaveInteger(i9,'n01T',0,5)
			SaveInteger(i9, 'h01V', 0, 5);//call SaveInteger(i9,'h01V',0,5)
			SaveInteger(i9, 'h01U', 0, 5);//call SaveInteger(i9,'h01U',0,5)
			SaveInteger(i9, 'h05H', 0, 5);//call SaveInteger(i9,'h05H',0,5)
			SaveInteger(i9, 'n01G', 0, 5);//call SaveInteger(i9,'n01G',0,5)
			SaveInteger(i9, 'n012', 0, 5);//call SaveInteger(i9,'n012',0,5)
			SaveInteger(i9, 'n013', 0, 5);//call SaveInteger(i9,'n013',0,5)
			SaveInteger(i9, 'n00T', 0, 5);//call SaveInteger(i9,'n00T',0,5)
			SaveInteger(i9, 'n00U', 0, 5);//call SaveInteger(i9,'n00U',0,5)
			SaveInteger(i9, 'n01N', 0, 5);//call SaveInteger(i9,'n01N',0,5)
			SaveInteger(i9, 'n01W', 0, 5);//call SaveInteger(i9,'n01W',0,5)
			SaveInteger(i9, 'n002', 0, 5);//call SaveInteger(i9,'n002',0,5)
			SaveInteger(i9, 'n00X', 0, 5);//call SaveInteger(i9,'n00X',0,5)
			SaveInteger(i9, 'e00B', 0, 6);//call SaveInteger(i9,'e00B',0,6)
			SaveInteger(i9, 'e00A', 0, 6);//call SaveInteger(i9,'e00A',0,6)
			SaveInteger(i9, 'h034', 1, 0);//call SaveInteger(i9,'h034',1,0)
			SaveInteger(i9, 'h03N', 1, 0);//call SaveInteger(i9,'h03N',1,0)
			SaveInteger(i9, 'h01V', 1, 0);//call SaveInteger(i9,'h01V',1,0)
			SaveInteger(i9, 'h01U', 1, 0);//call SaveInteger(i9,'h01U',1,0)
			SaveInteger(i9, 'h05H', 1, 0);//call SaveInteger(i9,'h05H',1,0)
			SaveInteger(i9, 'n00R', 1, 0);//call SaveInteger(i9,'n00R',1,0)
			SaveInteger(i9, 'o007', 1, 1);//call SaveInteger(i9,'o007',1,1)
			SaveInteger(i9, 'z002', 1, 1);//call SaveInteger(i9,'z002',1,1)
			SaveInteger(i9, 'z003', 1, 1);//call SaveInteger(i9,'z003',1,1)
			SaveInteger(i9, 'u002', 1, 1);//call SaveInteger(i9,'u002',1,1)
			SaveInteger(i9, 'u00B', 1, 1);//call SaveInteger(i9,'u00B',1,1)
			SaveInteger(i9, 'n01M', 1, 1);//call SaveInteger(i9,'n01M',1,1)
			SaveInteger(i9, 'n01C', 1, 1);//call SaveInteger(i9,'n01C',1,1)
			SaveInteger(i9, 'e00B', 1, 1);//call SaveInteger(i9,'e00B',1,1)
			SaveInteger(i9, 'e00A', 1, 1);//call SaveInteger(i9,'e00A',1,1)
			SaveInteger(i9, 'n00N', 1, 1);//call SaveInteger(i9,'n00N',1,1)
			SaveInteger(i9, 'hfoo', 1, 2);//call SaveInteger(i9,'hfoo',1,2)
			SaveInteger(i9, 'h03A', 1, 2);//call SaveInteger(i9,'h03A',1,2)
			SaveInteger(i9, 'h03B', 1, 2);//call SaveInteger(i9,'h03B',1,2)
			SaveInteger(i9, 'h03C', 1, 2);//call SaveInteger(i9,'h03C',1,2)
			SaveInteger(i9, 'o002', 1, 2);//call SaveInteger(i9,'o002',1,2)
			SaveInteger(i9, 'o004', 1, 2);//call SaveInteger(i9,'o004',1,2)
			SaveInteger(i9, 'o005', 1, 2);//call SaveInteger(i9,'o005',1,2)
			SaveInteger(i9, 'n01I', 1, 2);//call SaveInteger(i9,'n01I',1,2)
			SaveInteger(i9, 'n01H', 1, 2);//call SaveInteger(i9,'n01H',1,2)
			SaveInteger(i9, 'n027', 1, 2);//call SaveInteger(i9,'n027',1,2)
			SaveInteger(i9, 'n006', 1, 2);//call SaveInteger(i9,'n006',1,2)
			SaveInteger(i9, 'n00Y', 1, 2);//call SaveInteger(i9,'n00Y',1,2)
			SaveInteger(i9, 'n00P', 1, 2);//call SaveInteger(i9,'n00P',1,2)
			SaveInteger(i9, 'n000', 1, 2);//call SaveInteger(i9,'n000',1,2)
			SaveInteger(i9, 'n002', 1, 2);//call SaveInteger(i9,'n002',1,2)
			SaveInteger(i9, 'n00X', 1, 2);//call SaveInteger(i9,'n00X',1,2)
			SaveInteger(i9, 'h06U', 1, 2);//call SaveInteger(i9,'h06U',1,2)
			SaveInteger(i9, 'n024', 1, 3);//call SaveInteger(i9,'n024',1,3)
			SaveInteger(i9, 'n00M', 1, 3);//call SaveInteger(i9,'n00M',1,3)
			SaveInteger(i9, 'h02W', 1, 4);//call SaveInteger(i9,'h02W',1,4)
			SaveInteger(i9, 'h02X', 1, 4);//call SaveInteger(i9,'h02X',1,4)
			SaveInteger(i9, 'h02Y', 1, 4);//call SaveInteger(i9,'h02Y',1,4)
			SaveInteger(i9, 'n01X', 1, 4);//call SaveInteger(i9,'n01X',1,4)
			SaveInteger(i9, 'n01T', 1, 4);//call SaveInteger(i9,'n01T',1,4)
			SaveInteger(i9, 'n00B', 1, 4);//call SaveInteger(i9,'n00B',1,4)
			SaveInteger(i9, 'n01K', 1, 4);//call SaveInteger(i9,'n01K',1,4)
			SaveInteger(i9, 'u007', 1, 4);//call SaveInteger(i9,'u007',1,4)
			SaveInteger(i9, 'n01G', 1, 4);//call SaveInteger(i9,'n01G',1,4)
			SaveInteger(i9, 'n012', 1, 4);//call SaveInteger(i9,'n012',1,4)
			SaveInteger(i9, 'n013', 1, 4);//call SaveInteger(i9,'n013',1,4)
			SaveInteger(i9, 'n009', 1, 4);//call SaveInteger(i9,'n009',1,4)
			SaveInteger(i9, 'n00Z', 1, 4);//call SaveInteger(i9,'n00Z',1,4)
			SaveInteger(i9, 'n00L', 1, 4);//call SaveInteger(i9,'n00L',1,4)
			SaveInteger(i9, 'n00O', 1, 4);//call SaveInteger(i9,'n00O',1,4)
			SaveInteger(i9, 'e00F', 1, 5);//call SaveInteger(i9,'e00F',1,5)
			SaveInteger(i9, 'n018', 1, 6);//call SaveInteger(i9,'n018',1,6)
			SaveInteger(i9, 'n016', 1, 6);//call SaveInteger(i9,'n016',1,6)
			SaveInteger(i9, 'n029', 1, 6);//call SaveInteger(i9,'n029',1,6)
			SaveInteger(i9, 'n02B', 1, 6);//call SaveInteger(i9,'n02B',1,6)
			SaveInteger(i9, 'n00T', 1, 6);//call SaveInteger(i9,'n00T',1,6)
			SaveInteger(i9, 'n00U', 1, 6);//call SaveInteger(i9,'n00U',1,6)
			SaveInteger(i9, 'n01N', 1, 6);//call SaveInteger(i9,'n01N',1,6)
			SaveInteger(i9, 'n01W', 1, 6);//call SaveInteger(i9,'n01W',1,6)
			SaveInteger(i9, 'n00Q', 1, 6);//call SaveInteger(i9,'n00Q',1,6)
			SaveInteger(i9, 'n00I', 1, 6);//call SaveInteger(i9,'n00I',1,6)
			SaveInteger(i9, 'n00J', 1, 6);//call SaveInteger(i9,'n00J',1,6)
			SaveInteger(i9, 'n00K', 1, 6);//call SaveInteger(i9,'n00K',1,6)
		}//endfunction
		private void Aq(int oi, unit u) {//function Aq takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function wp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function wp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function xp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function xp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function yp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function yp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function zp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function zp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Ap));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Ap))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function ap));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function ap))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void aq(int oi, unit u) {//function aq takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function wp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function wp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function xp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function xp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function yp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function yp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function zp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function zp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Ap));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Ap))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function ap));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function ap))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void Bq(int oi, unit u) {//function Bq takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Bp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Bp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function bp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function bp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Cp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Cp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function cp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function cp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Dp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Dp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Ep));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Ep))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Fp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Fp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Gp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Gp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Hp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Hp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Ip));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Ip))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void bq(int oi, unit u) {//function bq takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function lp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function lp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Jp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Jp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Kp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Kp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Lp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Lp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Mp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Mp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Np));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Np))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Op));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Op))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Pp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Pp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Qp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Qp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Rp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Rp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Sp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Sp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Tp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Tp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void Cq(int oi, unit u) {//function Cq takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Up));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Up))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Vp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Vp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Wp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Wp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Xp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Xp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Yp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Yp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Zp));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Zp))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function dq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function dq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function eq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function eq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function fq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function fq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function gq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function gq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function hq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function hq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function iq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function iq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void cq(int oi, unit u) {//function cq takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function jq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function jq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function kq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function kq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function mq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function mq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function nq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function nq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function oq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function oq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function qq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function qq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function rq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function rq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function sq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function sq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function tq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function tq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function uq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function uq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function vq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function vq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function wq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function wq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void Dq(int oi, unit u) {//function Dq takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function xq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function xq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function yq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function yq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void Eq(int oi, unit u) {//function Eq takes integer oi,unit u returns nothing
			int id = LoadInteger(i9,GetUnitTypeId(u),0);//local integer id=LoadInteger(i9,GetUnitTypeId(u),0)
			if (id==1 ) {//if id==1 then
				Aq(oi, u);//call Aq(oi,u)
			} else if (id==2 ) {//elseif id==2 then
				aq(oi, u);//call aq(oi,u)
			} else if (id==3 ) {//elseif id==3 then
				Bq(oi, u);//call Bq(oi,u)
			} else if (id==4 ) {//elseif id==4 then
				bq(oi, u);//call bq(oi,u)
			} else if (id==5 ) {//elseif id==5 then
				Cq(oi, u);//call Cq(oi,u)
			} else if (id==6 ) {//elseif id==6 then
				cq(oi, u);//call cq(oi,u)
			} else if (id==0 ) {//elseif id==0 then
				Dq(oi, u);//call Dq(oi,u)
			}//endif
		}//endfunction
		private bool Fq() {//function Fq takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9));//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitEnemy(GetFilterUnit(),e9))
		}//endfunction
		private bool Gq() {//function Gq takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)
		}//endfunction
		private bool Hq() {//function Hq takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==3)
		}//endfunction
		private bool Iq() {//function Iq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_RANGED_ATTACKER)))!=null
		}//endfunction
		private bool lq() {//function lq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitEnemy(GetFilterUnit(),e9))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)))!=null
		}//endfunction
		private bool Jq() {//function Jq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (IsUnitEnemy(GetFilterUnit(),e9)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)and(IsUnitEnemy(GetFilterUnit(),e9))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null
		}//endfunction
		private bool Kq() {//function Kq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) && (IsUnitEnemy(GetFilterUnit(),e9)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)and(IsUnitEnemy(GetFilterUnit(),e9))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_GROUND)))!=null
		}//endfunction
		private bool Lq() {//function Lq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool Mq() {//function Mq takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)
		}//endfunction
		private bool Nq() {//function Nq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool Oq() {//function Oq takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)
		}//endfunction
		private bool Pq() {//function Pq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool Qq() {//function Qq takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)
		}//endfunction
		private bool Rq() {//function Rq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool Sq() {//function Sq takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6));//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6))
		}//endfunction
		private bool Tq() {//function Tq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool Uq() {//function Uq takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)
		}//endfunction
		private bool Vq() {//function Vq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool Wq() {//function Wq takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)
		}//endfunction
		private bool Xq() {//function Xq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool Yq() {//function Yq takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)
		}//endfunction
		private bool Zq() {//function Zq takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool dr() {//function dr takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)
		}//endfunction
		private bool er() {//function er takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool fr() {//function fr takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)
		}//endfunction
		private bool gr() {//function gr takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool hr() {//function hr takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6));//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6))
		}//endfunction
		private bool ir() {//function ir takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool jr() {//function jr takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.)
		}//endfunction
		private bool kr() {//function kr takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool mr() {//function mr takes nothing returns boolean
			return (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2);//return(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)
		}//endfunction
		private bool nr() {//function nr takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null
		}//endfunction
		private bool UnitsAI___rangedAA2() {//function UnitsAI___rangedAA2 takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==1)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool UnitsAI___rangedAA3() {//function UnitsAI___rangedAA3 takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null
		}//endfunction
		private bool UnitsAI___rangedAA4() {//function UnitsAI___rangedAA4 takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && ((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6) || (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4)) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and((LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==6)or(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==4))and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private bool UnitsAI___rangedAA5() {//function UnitsAI___rangedAA5 takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)) && (GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING))and(GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)<100.))!=null
		}//endfunction
		private bool UnitsAI___rangedAA6() {//function UnitsAI___rangedAA6 takes nothing returns boolean
			return ((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7) && (IsUnitEnemy(GetFilterUnit(),e9)) && (LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2) && (IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null;//return((GetUnitState(GetFilterUnit(),UNIT_STATE_LIFE)>.7)and(IsUnitEnemy(GetFilterUnit(),e9))and(LoadInteger(i9,GetUnitTypeId(GetFilterUnit()),1)==2)and(IsUnitType(GetFilterUnit(),UNIT_TYPE_FLYING)))!=null
		}//endfunction
		private void qr(int oi) {//function qr takes integer oi returns nothing
			SaveInteger(i9, 'n05C', 0, 0);//call SaveInteger(i9,'n05C',0,0)
			SaveInteger(i9, 'o00C', 0, 0);//call SaveInteger(i9,'o00C',0,0)
			SaveInteger(i9, 'o00D', 0, 0);//call SaveInteger(i9,'o00D',0,0)
			SaveInteger(i9, 'o00E', 0, 0);//call SaveInteger(i9,'o00E',0,0)
			SaveInteger(i9, 'h05C', 0, 0);//call SaveInteger(i9,'h05C',0,0)
			SaveInteger(i9, 'h06Q', 0, 0);//call SaveInteger(i9,'h06Q',0,0)
			SaveInteger(i9, 'h06R', 0, 0);//call SaveInteger(i9,'h06R',0,0)
			SaveInteger(i9, 'h02Z', 0, 2);//call SaveInteger(i9,'h02Z',0,2)
			SaveInteger(i9, 'h030', 0, 2);//call SaveInteger(i9,'h030',0,2)
			SaveInteger(i9, 'h04I', 0, 2);//call SaveInteger(i9,'h04I',0,2)
			SaveInteger(i9, 'e007', 0, 2);//call SaveInteger(i9,'e007',0,2)
			SaveInteger(i9, 'e00J', 0, 2);//call SaveInteger(i9,'e00J',0,2)
			SaveInteger(i9, 'h00W', 0, 2);//call SaveInteger(i9,'h00W',0,2)
			SaveInteger(i9, 'n014', 0, 2);//call SaveInteger(i9,'n014',0,2)
			SaveInteger(i9, 'h010', 0, 2);//call SaveInteger(i9,'h010',0,2)
			SaveInteger(i9, 'e00C', 0, 2);//call SaveInteger(i9,'e00C',0,2)
			SaveInteger(i9, 'n001', 0, 2);//call SaveInteger(i9,'n001',0,2)
			SaveInteger(i9, 'n02A', 0, 2);//call SaveInteger(i9,'n02A',0,2)
			SaveInteger(i9, 'n01R', 0, 2);//call SaveInteger(i9,'n01R',0,2)
			SaveInteger(i9, 'n01P', 0, 2);//call SaveInteger(i9,'n01P',0,2)
			SaveInteger(i9, 'n01Q', 0, 2);//call SaveInteger(i9,'n01Q',0,2)
			SaveInteger(i9, 'n00S', 0, 2);//call SaveInteger(i9,'n00S',0,2)
			SaveInteger(i9, 'hmtm', 0, 3);//call SaveInteger(i9,'hmtm',0,3)
			SaveInteger(i9, 'o001', 0, 3);//call SaveInteger(i9,'o001',0,3)
			SaveInteger(i9, 'n01F', 0, 3);//call SaveInteger(i9,'n01F',0,3)
			SaveInteger(i9, 'n01E', 0, 3);//call SaveInteger(i9,'n01E',0,3)
			SaveInteger(i9, 'e005', 0, 3);//call SaveInteger(i9,'e005',0,3)
			SaveInteger(i9, 'e002', 0, 3);//call SaveInteger(i9,'e002',0,3)
			SaveInteger(i9, 'n007', 0, 3);//call SaveInteger(i9,'n007',0,3)
			SaveInteger(i9, 'n00V', 0, 4);//call SaveInteger(i9,'n00V',0,4)
			SaveInteger(i9, 'n01O', 0, 4);//call SaveInteger(i9,'n01O',0,4)
			SaveInteger(i9, 'h06S', 0, 4);//call SaveInteger(i9,'h06S',0,4)
			SaveInteger(i9, 'h098', 0, 4);//call SaveInteger(i9,'h098',0,4)
			SaveInteger(i9, 'n00A', 0, 4);//call SaveInteger(i9,'n00A',0,4)
			SaveInteger(i9, 'z000', 0, 4);//call SaveInteger(i9,'z000',0,4)
			SaveInteger(i9, 'n004', 0, 4);//call SaveInteger(i9,'n004',0,4)
			SaveInteger(i9, 'u000', 0, 4);//call SaveInteger(i9,'u000',0,4)
			SaveInteger(i9, 'h06T', 0, 4);//call SaveInteger(i9,'h06T',0,4)
			SaveInteger(i9, 'hrif', 0, 5);//call SaveInteger(i9,'hrif',0,5)
			SaveInteger(i9, 'h0A2', 0, 5);//call SaveInteger(i9,'h0A2',0,5)
			SaveInteger(i9, 'o00D', 0, 5);//call SaveInteger(i9,'o00D',0,5)
			SaveInteger(i9, 'o00E', 0, 5);//call SaveInteger(i9,'o00E',0,5)
			SaveInteger(i9, 'o006', 0, 5);//call SaveInteger(i9,'o006',0,5)
			SaveInteger(i9, 'o008', 0, 5);//call SaveInteger(i9,'o008',0,5)
			SaveInteger(i9, 'o00B', 0, 5);//call SaveInteger(i9,'o00B',0,5)
			SaveInteger(i9, 'o009', 0, 5);//call SaveInteger(i9,'o009',0,5)
			SaveInteger(i9, 'n00D', 0, 5);//call SaveInteger(i9,'n00D',0,5)
			SaveInteger(i9, 'n01L', 0, 5);//call SaveInteger(i9,'n01L',0,5)
			SaveInteger(i9, 'e001', 0, 5);//call SaveInteger(i9,'e001',0,5)
			SaveInteger(i9, 'e003', 0, 5);//call SaveInteger(i9,'e003',0,5)
			SaveInteger(i9, 'e004', 0, 5);//call SaveInteger(i9,'e004',0,5)
			SaveInteger(i9, 'n022', 0, 5);//call SaveInteger(i9,'n022',0,5)
			SaveInteger(i9, 'n023', 0, 5);//call SaveInteger(i9,'n023',0,5)
			SaveInteger(i9, 'n01Y', 0, 5);//call SaveInteger(i9,'n01Y',0,5)
			SaveInteger(i9, 'n011', 0, 5);//call SaveInteger(i9,'n011',0,5)
			SaveInteger(i9, 'e006', 0, 5);//call SaveInteger(i9,'e006',0,5)
			SaveInteger(i9, 'e009', 0, 5);//call SaveInteger(i9,'e009',0,5)
			SaveInteger(i9, 'e00C', 0, 5);//call SaveInteger(i9,'e00C',0,5)
			SaveInteger(i9, 'h016', 0, 6);//call SaveInteger(i9,'h016',0,6)
			SaveInteger(i9, 'o003', 0, 6);//call SaveInteger(i9,'o003',0,6)
			SaveInteger(i9, 'u005', 0, 6);//call SaveInteger(i9,'u005',0,6)
			SaveInteger(i9, 'u009', 0, 6);//call SaveInteger(i9,'u009',0,6)
			SaveInteger(i9, 'u00D', 0, 6);//call SaveInteger(i9,'u00D',0,6)
			SaveInteger(i9, 'u001', 0, 6);//call SaveInteger(i9,'u001',0,6)
			SaveInteger(i9, 'u00A', 0, 6);//call SaveInteger(i9,'u00A',0,6)
			SaveInteger(i9, 'u003', 0, 6);//call SaveInteger(i9,'u003',0,6)
			SaveInteger(i9, 'n01B', 0, 6);//call SaveInteger(i9,'n01B',0,6)
			SaveInteger(i9, 'n01D', 0, 6);//call SaveInteger(i9,'n01D',0,6)
			SaveInteger(i9, 'n019', 0, 6);//call SaveInteger(i9,'n019',0,6)
			SaveInteger(i9, 'n01A', 0, 6);//call SaveInteger(i9,'n01A',0,6)
			SaveInteger(i9, 'e000', 0, 6);//call SaveInteger(i9,'e000',0,6)
			SaveInteger(i9, 'h07B', 0, 6);//call SaveInteger(i9,'h07B',0,6)
			SaveInteger(i9, 'h00U', 0, 6);//call SaveInteger(i9,'h00U',0,6)
			SaveInteger(i9, 'n015', 0, 6);//call SaveInteger(i9,'n015',0,6)
			SaveInteger(i9, 'o00A', 0, 6);//call SaveInteger(i9,'o00A',0,6)
			SaveInteger(i9, 'n026', 0, 6);//call SaveInteger(i9,'n026',0,6)
			SaveInteger(i9, 'n028', 0, 6);//call SaveInteger(i9,'n028',0,6)
			SaveInteger(i9, 'n008', 0, 6);//call SaveInteger(i9,'n008',0,6)
			SaveInteger(i9, 'n00H', 0, 6);//call SaveInteger(i9,'n00H',0,6)
			SaveInteger(i9, 'o006', 1, 1);//call SaveInteger(i9,'o006',1,1)
			SaveInteger(i9, 'o008', 1, 1);//call SaveInteger(i9,'o008',1,1)
			SaveInteger(i9, 'o00B', 1, 1);//call SaveInteger(i9,'o00B',1,1)
			SaveInteger(i9, 'u000', 1, 1);//call SaveInteger(i9,'u000',1,1)
			SaveInteger(i9, 'u00A', 1, 1);//call SaveInteger(i9,'u00A',1,1)
			SaveInteger(i9, 'u003', 1, 1);//call SaveInteger(i9,'u003',1,1)
			SaveInteger(i9, 'n00D', 1, 1);//call SaveInteger(i9,'n00D',1,1)
			SaveInteger(i9, 'n01L', 1, 1);//call SaveInteger(i9,'n01L',1,1)
			SaveInteger(i9, 'n019', 1, 1);//call SaveInteger(i9,'n019',1,1)
			SaveInteger(i9, 'n01A', 1, 1);//call SaveInteger(i9,'n01A',1,1)
			SaveInteger(i9, 'e001', 1, 1);//call SaveInteger(i9,'e001',1,1)
			SaveInteger(i9, 'e003', 1, 1);//call SaveInteger(i9,'e003',1,1)
			SaveInteger(i9, 'e004', 1, 1);//call SaveInteger(i9,'e004',1,1)
			SaveInteger(i9, 'e000', 1, 1);//call SaveInteger(i9,'e000',1,1)
			SaveInteger(i9, 'n015', 1, 1);//call SaveInteger(i9,'n015',1,1)
			SaveInteger(i9, 'o00A', 1, 1);//call SaveInteger(i9,'o00A',1,1)
			SaveInteger(i9, 'n026', 1, 1);//call SaveInteger(i9,'n026',1,1)
			SaveInteger(i9, 'n028', 1, 1);//call SaveInteger(i9,'n028',1,1)
			SaveInteger(i9, 'n00A', 1, 1);//call SaveInteger(i9,'n00A',1,1)
			SaveInteger(i9, 'z000', 1, 1);//call SaveInteger(i9,'z000',1,1)
			SaveInteger(i9, 'n008', 1, 1);//call SaveInteger(i9,'n008',1,1)
			SaveInteger(i9, 'n00H', 1, 1);//call SaveInteger(i9,'n00H',1,1)
			SaveInteger(i9, 'h03P', 1, 2);//call SaveInteger(i9,'h03P',1,2)
			SaveInteger(i9, 'h03R', 1, 2);//call SaveInteger(i9,'h03R',1,2)
			SaveInteger(i9, 'h02Z', 1, 2);//call SaveInteger(i9,'h02Z',1,2)
			SaveInteger(i9, 'h030', 1, 2);//call SaveInteger(i9,'h030',1,2)
			SaveInteger(i9, 'h099', 1, 2);//call SaveInteger(i9,'h099',1,2)
			SaveInteger(i9, 'h06S', 1, 2);//call SaveInteger(i9,'h06S',1,2)
			SaveInteger(i9, 'h06T', 1, 2);//call SaveInteger(i9,'h06T',1,2)
			SaveInteger(i9, 'h098', 1, 2);//call SaveInteger(i9,'h098',1,2)
			SaveInteger(i9, 'n01E', 1, 2);//call SaveInteger(i9,'n01E',1,2)
			SaveInteger(i9, 'n01F', 1, 2);//call SaveInteger(i9,'n01F',1,2)
			SaveInteger(i9, 'e005', 1, 2);//call SaveInteger(i9,'e005',1,2)
			SaveInteger(i9, 'e002', 1, 2);//call SaveInteger(i9,'e002',1,2)
			SaveInteger(i9, 'n007', 1, 2);//call SaveInteger(i9,'n007',1,2)
			SaveInteger(i9, 'n01Y', 1, 2);//call SaveInteger(i9,'n01Y',1,2)
			SaveInteger(i9, 'hrif', 1, 4);//call SaveInteger(i9,'hrif',1,4)
			SaveInteger(i9, 'h02A', 1, 4);//call SaveInteger(i9,'h02A',1,4)
			SaveInteger(i9, 'h05C', 1, 4);//call SaveInteger(i9,'h05C',1,4)
			SaveInteger(i9, 'h016', 1, 4);//call SaveInteger(i9,'h016',1,4)
			SaveInteger(i9, 'o00C', 1, 4);//call SaveInteger(i9,'o00C',1,4)
			SaveInteger(i9, 'o00D', 1, 4);//call SaveInteger(i9,'o00D',1,4)
			SaveInteger(i9, 'o00E', 1, 4);//call SaveInteger(i9,'o00E',1,4)
			SaveInteger(i9, 'o001', 1, 4);//call SaveInteger(i9,'o001',1,4)
			SaveInteger(i9, 'n00V', 1, 4);//call SaveInteger(i9,'n00V',1,4)
			SaveInteger(i9, 'n01O', 1, 4);//call SaveInteger(i9,'n01O',1,4)
			SaveInteger(i9, 'h04I', 1, 4);//call SaveInteger(i9,'h04I',1,4)
			SaveInteger(i9, 'n01B', 1, 4);//call SaveInteger(i9,'n01B',1,4)
			SaveInteger(i9, 'n01D', 1, 4);//call SaveInteger(i9,'n01D',1,4)
			SaveInteger(i9, 'h00U', 1, 4);//call SaveInteger(i9,'h00U',1,4)
			SaveInteger(i9, 'e006', 1, 4);//call SaveInteger(i9,'e006',1,4)
			SaveInteger(i9, 'e009', 1, 4);//call SaveInteger(i9,'e009',1,4)
			SaveInteger(i9, 'e00C', 1, 4);//call SaveInteger(i9,'e00C',1,4)
			SaveInteger(i9, 'n01P', 1, 4);//call SaveInteger(i9,'n01P',1,4)
			SaveInteger(i9, 'n01Q', 1, 4);//call SaveInteger(i9,'n01Q',1,4)
			SaveInteger(i9, 'n01R', 1, 4);//call SaveInteger(i9,'n01R',1,4)
			SaveInteger(i9, 'n004', 1, 4);//call SaveInteger(i9,'n004',1,4)
			SaveInteger(i9, 'hmtm', 1, 6);//call SaveInteger(i9,'hmtm',1,6)
			SaveInteger(i9, 'n005', 1, 6);//call SaveInteger(i9,'n005',1,6)
			SaveInteger(i9, 'o009', 1, 6);//call SaveInteger(i9,'o009',1,6)
			SaveInteger(i9, 'o003', 1, 6);//call SaveInteger(i9,'o003',1,6)
			SaveInteger(i9, 'u005', 1, 6);//call SaveInteger(i9,'u005',1,6)
			SaveInteger(i9, 'u009', 1, 6);//call SaveInteger(i9,'u009',1,6)
			SaveInteger(i9, 'u00D', 1, 6);//call SaveInteger(i9,'u00D',1,6)
			SaveInteger(i9, 'e007', 1, 6);//call SaveInteger(i9,'e007',1,6)
			SaveInteger(i9, 'e00J', 1, 6);//call SaveInteger(i9,'e00J',1,6)
			SaveInteger(i9, 'h07B', 1, 6);//call SaveInteger(i9,'h07B',1,6)
			SaveInteger(i9, 'h00W', 1, 6);//call SaveInteger(i9,'h00W',1,6)
			SaveInteger(i9, 'n022', 1, 6);//call SaveInteger(i9,'n022',1,6)
			SaveInteger(i9, 'n023', 1, 6);//call SaveInteger(i9,'n023',1,6)
			SaveInteger(i9, 'n014', 1, 6);//call SaveInteger(i9,'n014',1,6)
			SaveInteger(i9, 'n00S', 1, 6);//call SaveInteger(i9,'n00S',1,6)
		}//endfunction
		private void rr(int oi, unit u) {//function rr takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Fq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Fq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Gq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Gq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Hq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Hq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Iq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Iq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void sr(int oi, unit u) {//function sr takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function lq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function lq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Jq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Jq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Kq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Kq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void tr(int oi, unit u) {//function tr takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Lq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Lq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Mq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Mq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Nq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Nq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Oq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Oq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Pq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Pq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Qq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Qq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Rq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Rq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Sq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Sq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Tq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Tq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Uq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Uq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Vq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Vq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Wq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Wq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void ur(int oi, unit u) {//function ur takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Xq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Xq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Yq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Yq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function Zq));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function Zq))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function dr));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function dr))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function er));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function er))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function fr));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function fr))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function gr));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function gr))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function hr));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function hr))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function ir));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function ir))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function jr));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function jr))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function kr));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function kr))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function mr));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function mr))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void vr(int oi, unit u) {//function vr takes integer oi,unit u returns nothing
			unit t;//local unit t
			co((e9), ((GetUnitX(u))*1.), ((GetUnitY(u))*1.), ((700.)*1.));//call co((e9),((GetUnitX(u))*1.),((GetUnitY(u))*1.),((700.)*1.))
			Co();//call Co()
			t = Oo(r9,j9,n9,0);//set t=Oo(r9,j9,n9,0)
			if ((t!=null)) {//if(t!=null)then
				IssueTargetOrderById(u, $D000F, t);//call IssueTargetOrderById(u,$D000F,t)
				t = null;//set t=null
				return;//return
			}//endif
			Co();//call Co()
			t = Oo(r9,n9,0,0);//set t=Oo(r9,n9,0,0)
			if ((t!=null)) {//if(t!=null)then
				IssueTargetOrderById(u, $D000F, t);//call IssueTargetOrderById(u,$D000F,t)
				t = null;//set t=null
				return;//return
			}//endif
			Co();//call Co()
			t = Oo(w9,j9,n9,0);//set t=Oo(w9,j9,n9,0)
			if ((t!=null)) {//if(t!=null)then
				IssueTargetOrderById(u, $D000F, t);//call IssueTargetOrderById(u,$D000F,t)
				t = null;//set t=null
				return;//return
			}//endif
			Co();//call Co()
			t = Oo(w9,n9,0,0);//set t=Oo(w9,n9,0,0)
			if ((t!=null)) {//if(t!=null)then
				IssueTargetOrderById(u, $D000F, t);//call IssueTargetOrderById(u,$D000F,t)
				t = null;//set t=null
				return;//return
			}//endif
			Co();//call Co()
			t = Oo(t9,j9,n9,0);//set t=Oo(t9,j9,n9,0)
			if ((t!=null)) {//if(t!=null)then
				IssueTargetOrderById(u, $D000F, t);//call IssueTargetOrderById(u,$D000F,t)
				t = null;//set t=null
				return;//return
			}//endif
			Co();//call Co()
			t = Oo(t9,n9,0,0);//set t=Oo(t9,n9,0,0)
			if ((t!=null)) {//if(t!=null)then
				IssueTargetOrderById(u, $D000F, t);//call IssueTargetOrderById(u,$D000F,t)
				t = null;//set t=null
				return;//return
			}//endif
		}//endfunction
		private void wr(int oi, unit u) {//function wr takes integer oi,unit u returns nothing
			GroupEnumUnitsInRange(h9, GetUnitX(u), GetUnitY(u), 700., Condition(function nr));//call GroupEnumUnitsInRange(h9,GetUnitX(u),GetUnitY(u),700.,Condition(function nr))
			if (FirstOfGroup(h9)!=null ) {//if FirstOfGroup(h9)!=null then
				IssueTargetOrderById(u, $D000F, FirstOfGroup(h9));//call IssueTargetOrderById(u,$D000F,FirstOfGroup(h9))
				return;//return
			}//endif
		}//endfunction
		private void xr(int oi, unit u) {//function xr takes integer oi,unit u returns nothing
			int id = LoadInteger(i9,GetUnitTypeId(u),0);//local integer id=LoadInteger(i9,GetUnitTypeId(u),0)
			if (id==1 ) {//if id==1 then
			} else if (id==2 ) {//elseif id==2 then
				rr(oi, u);//call rr(oi,u)
			} else if (id==3 ) {//elseif id==3 then
				sr(oi, u);//call sr(oi,u)
			} else if (id==4 ) {//elseif id==4 then
				tr(oi, u);//call tr(oi,u)
			} else if (id==5 ) {//elseif id==5 then
				ur(oi, u);//call ur(oi,u)
			} else if (id==6 ) {//elseif id==6 then
				vr(oi, u);//call vr(oi,u)
			} else if (id==0 ) {//elseif id==0 then
				wr(oi, u);//call wr(oi,u)
			}//endif
		}//endfunction
		private void yr(unit u) {//function yr takes unit u returns nothing
			e9 = GetOwningPlayer(u);//set e9=GetOwningPlayer(u)
			if (IsUnitType(u,UNIT_TYPE_MELEE_ATTACKER)) {//if IsUnitType(u,UNIT_TYPE_MELEE_ATTACKER)then
				Eq(f9, u);//call Eq(f9,u)
			} else {//else
				xr(g9, u);//call xr(g9,u)
			}//endif
			GroupClear(h9);//call GroupClear(h9)
		}//endfunction
		private void zr() {//function zr takes nothing returns nothing
			h9 = CreateGroup();//set h9=CreateGroup()
			f9 = si();//set f9=si()
			g9 = ri();//set g9=ri()
			zq(f9);//call zq(f9)
			qr(g9);//call qr(g9)
			j9 = Fi();//set j9=Fi()
			k9 = Ei();//set k9=Ei()
			m9 = Di();//set m9=Di()
			n9 = ci();//set n9=ci()
			o9 = Ci();//set o9=Ci()
			p9 = Bi();//set p9=Bi()
			q9 = Ai();//set q9=Ai()
			r9 = zi();//set r9=zi()
			s9 = yi();//set s9=yi()
			t9 = xi();//set t9=xi()
			u9 = wi();//set u9=wi()
			v9 = ui();//set v9=ui()
			w9 = Ji();//set w9=Ji()
		}//endfunction
		private void Ar(unit u, float r) {//function Ar takes unit u,real r returns nothing
			int ar = 20+R2I((r-500.)/ 50);//local integer ar=20+R2I((r-500.)/ 50)
			float x = GetUnitX(u);//local real x=GetUnitX(u)
			float y = GetUnitY(u);//local real y=GetUnitY(u)
			int i = 0;//local integer i=0
			string Br = "";//local string Br=""
			float an;//local real an
			JassArray<effect> e = new JassArray<effect>();//local effect array e
			if ((GetOwningPlayer(u)==GetLocalPlayer())) {//if(GetOwningPlayer(u)==GetLocalPlayer())then
				Br = "Abilities\\Spells\\NightElf\\Barkskin\\BarkSkinTarget.mdl";//set Br="Abilities\\Spells\\NightElf\\Barkskin\\BarkSkinTarget.mdl"
			}//endif
			while (true) {//loop
				if (i>=ar) { break; }//exitwhen i>=ar
				an = 2.*bj_PI*i/ ar;//set an=2.*bj_PI*i/ ar
				e[i] = AddSpecialEffect("Abilities\\Spells\\NightElf\\Barkskin\\BarkSkinTarget.mdl",x+r*Cos(an),y+r*Sin(an));//set e[i]=AddSpecialEffect("Abilities\\Spells\\NightElf\\Barkskin\\BarkSkinTarget.mdl",x+r*Cos(an),y+r*Sin(an))
				i = i+1;//set i=i+1
			}//endloop
			TriggerSleepAction(6.);//call TriggerSleepAction(6.)
			i = 0;//set i=0
			while (true) {//loop
				if (i>=ar) { break; }//exitwhen i>=ar
				DestroyEffect(e[i]);//call DestroyEffect(e[i])
				e[i] = null;//set e[i]=null
				i = i+1;//set i=i+1
			}//endloop
		}//endfunction
		private void br(unit u) {//function br takes unit u returns nothing
			IssuePointOrderByIdLoc(u, $D0012, Id[me[GetPlayerId(GetOwningPlayer(u))]+2]);//call IssuePointOrderByIdLoc(u,$D0012,Id[me[GetPlayerId(GetOwningPlayer(u))]+2])
		}//endfunction
		private bool Cr() {//function Cr takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitType(u,UNIT_TYPE_GROUND) && GetUnitAbilityLevel(u,1970684199)<=0 && GetUnitAbilityLevel(u,942686503)<=0;//local boolean Im=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and IsUnitType(u,UNIT_TYPE_GROUND)and GetUnitAbilityLevel(u,'Avul')<=0 and GetUnitAbilityLevel(u,'A08H')<=0
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void cr(unit u, int Dr) {//function cr takes unit u,integer Dr returns nothing
			player p = GetOwningPlayer(u);//local player p=GetOwningPlayer(u)
			int dk = GetPlayerId(p);//local integer dk=GetPlayerId(p)
			if ((ad>0)) {//if(ad>0)then
				if ((he[dk]+Dr>=ad)) {//if(he[dk]+Dr>=ad)then
					Dr = ad-he[dk];//set Dr=ad-he[dk]
					if ((Dr<=0)) {//if(Dr<=0)then
						return;//return
					}//endif
					he[dk] = ad;//set he[dk]=ad
				} else {//else
					he[dk] = he[dk]+(Dr);//set he[dk]=he[dk]+(Dr)
				}//endif
			}//endif
			AdjustPlayerStateBJ(Dr, p, PLAYER_STATE_RESOURCE_LUMBER);//call AdjustPlayerStateBJ(Dr,p,PLAYER_STATE_RESOURCE_LUMBER)
			bj_lastCreatedTextTag = CreateTextTag();//set bj_lastCreatedTextTag=CreateTextTag()
			SetTextTagText(bj_lastCreatedTextTag, I2S(Dr), .024);//call SetTextTagText(bj_lastCreatedTextTag,I2S(Dr),.024)
			SetTextTagPos(bj_lastCreatedTextTag, GetUnitX(u)-36., GetUnitY(u)-16., .0);//call SetTextTagPos(bj_lastCreatedTextTag,GetUnitX(u)-36.,GetUnitY(u)-16.,.0)
			SetTextTagColor(bj_lastCreatedTextTag, 0, $C8, 80, $FF);//call SetTextTagColor(bj_lastCreatedTextTag,0,$C8,80,$FF)
			SetTextTagPermanent(bj_lastCreatedTextTag, false);//call SetTextTagPermanent(bj_lastCreatedTextTag,false)
			SetTextTagLifespan(bj_lastCreatedTextTag, 3.);//call SetTextTagLifespan(bj_lastCreatedTextTag,3.)
			SetTextTagFadepoint(bj_lastCreatedTextTag, 1.);//call SetTextTagFadepoint(bj_lastCreatedTextTag,1.)
			SetTextTagVelocity(bj_lastCreatedTextTag, 0, .06);//call SetTextTagVelocity(bj_lastCreatedTextTag,0,.06)
			if ((p!=GetLocalPlayer())) {//if(p!=GetLocalPlayer())then
				SetTextTagVisibility(bj_lastCreatedTextTag, false);//call SetTextTagVisibility(bj_lastCreatedTextTag,false)
			} else {//else
				SetTextTagVisibility(bj_lastCreatedTextTag, true);//call SetTextTagVisibility(bj_lastCreatedTextTag,true)
			}//endif
		}//endfunction
		private void Er(unit u) {//function Er takes unit u returns nothing
			int i = GetUnitAbilityLevel(u,959463719);//local integer i=GetUnitAbilityLevel(u,'A09L')
			if ((i==2)) {//if(i==2)then
				SetUnitAbilityLevel(u, 'A09L', 1);//call SetUnitAbilityLevel(u,'A09L',1)
				SetUnitState(u, UNIT_STATE_MANA, GetUnitState(u, UNIT_STATE_MANA)+100.);//call SetUnitState(u,UNIT_STATE_MANA,GetUnitState(u,UNIT_STATE_MANA)+100.)
				UnitAddAbility(u, 'A09M');//call UnitAddAbility(u,'A09M')
				SetUnitAbilityLevel(u, 'A09M', 3);//call SetUnitAbilityLevel(u,'A09M',3)
				UnitRemoveAbility(u, 'A09M');//call UnitRemoveAbility(u,'A09M')
				SetUnitState(u, UNIT_STATE_LIFE, GetWidgetLife(u)+200.);//call SetUnitState(u,UNIT_STATE_LIFE,GetWidgetLife(u)+200.)
			} else {//else
				UnitRemoveAbility(u, 'A09L');//call UnitRemoveAbility(u,'A09L')
			}//endif
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Items\\AIvi\\AIviTarget.mdl", u, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Items\\AIvi\\AIviTarget.mdl",u,"origin"))
		}//endfunction
		private void Fr(unit u) {//function Fr takes unit u returns nothing
			int i = GetUnitAbilityLevel(u,959463719)+1;//local integer i=GetUnitAbilityLevel(u,'A09C')+1
			if ((i>=6)) {//if(i>=6)then
				return;//return
			}//endif
			SetUnitAbilityLevel(u, 'A09C', i);//call SetUnitAbilityLevel(u,'A09C',i)
			SetUnitAbilityLevel(u, 'A09B', i);//call SetUnitAbilityLevel(u,'A09B',i)
			SetUnitAbilityLevel(u, 'A00J', i);//call SetUnitAbilityLevel(u,'A00J',i)
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl", u, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl",u,"origin"))
		}//endfunction
		private bool Gr(unit u) {//function Gr takes unit u returns boolean
			if ((GetUnitAbilityLevel(u,959463719)>0)) {//if(GetUnitAbilityLevel(u,'A09L')>0)then
				Er(u);//call Er(u)
				return true;//return true
			} else if ((GetUnitTypeId(u)==825257511)) {//elseif(GetUnitTypeId(u)=='n01T')then
				if ((GetRandomInt(0,99)<60)) {//if(GetRandomInt(0,99)<60)then
					Fr(u);//call Fr(u)
					return true;//return true
				} else {//else
					return false;//return false
				}//endif
			}//endif
			return GetUnitAbilityLevel(u,925909287)>0;//return GetUnitAbilityLevel(u,'A070')>0
		}//endfunction
		private bool Hr(unit u) {//function Hr takes unit u returns boolean
			if ((Gr(u))) {//if(Gr(u))then
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl", u, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl",u,"origin"))
				return true;//return true
			}//endif
			return false;//return false
		}//endfunction
		private bool Ir() {//function Ir takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,1970684199)<=0 && GetUnitAbilityLevel(u,942686503)<=0;//local boolean Im=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and GetUnitAbilityLevel(u,'Avul')<=0 and GetUnitAbilityLevel(u,'A08H')<=0
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void lr() {//function lr takes nothing returns nothing
			Lo(GetEnumUnit());//call Lo(GetEnumUnit())
		}//endfunction
		private void Jr() {//function Jr takes nothing returns nothing
			ForGroup(z9, function lr);//call ForGroup(z9,function lr)
		}//endfunction
		private bool Kr() {//function Kr takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && GetUnitCurrentOrder(u)==0 && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,925909287)<=0 && GetUnitAbilityLevel(u,925909287)<=0;//local boolean Im=GetWidgetLife(u)>.405 and GetUnitCurrentOrder(u)==0 and IsUnitType(u,UNIT_TYPE_SAPPER)and GetUnitAbilityLevel(u,'A07I')<=0 and GetUnitAbilityLevel(u,'A07M')<=0
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void Lr() {//function Lr takes nothing returns nothing
			Po(GetEnumUnit());//call Po(GetEnumUnit())
		}//endfunction
		private void Mr() {//function Mr takes nothing returns nothing
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, A9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,A9)
			ForGroup(q4, function Lr);//call ForGroup(q4,function Lr)
		}//endfunction
		private void Nr() {//function Nr takes nothing returns nothing
			bool Pr = false;//local boolean Pr=false
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((Pd[i]==942696487 || Pd[i]==909142055)) {//if(Pd[i]=='h089' or Pd[i]=='h06P')then
					Pr = true;//set Pr=true
				}//endif
				i = i+1;//set i=i+1
				if (i>$B || Pr) { break; }//exitwhen i>$B or Pr
			}//endloop
			if ((Pr)) {//if(Pr)then
				TimerStart(a9, 2., true, function Jr);//call TimerStart(a9,2.,true,function Jr)
			}//endif
		}//endfunction
		private void Functions_CheckAndStartCommon() {//function Functions_CheckAndStartCommon takes nothing returns nothing
			TimerStart(B9, 4., true, function Mr);//call TimerStart(B9,4.,true,function Mr)
		}//endfunction
		private bool Qr() {//function Qr takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitType(u,UNIT_TYPE_PEON);//local boolean Im=GetWidgetLife(u)>.405 and IsUnitType(u,UNIT_TYPE_PEON)
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void Rr() {//function Rr takes nothing returns nothing
			SetUnitAnimation(GetEnumUnit(), "stand");//call SetUnitAnimation(GetEnumUnit(),"stand")
		}//endfunction
		private void Sr(unit u, unit Tr) {//function Sr takes unit u,unit Tr returns nothing
			player p = GetOwningPlayer(Tr);//local player p=GetOwningPlayer(Tr)
			int dk = GetPlayerId(p);//local integer dk=GetPlayerId(p)
			bool Ur = GetUnitAbilityLevel(Tr,825246247)>0;//local boolean Ur=GetUnitAbilityLevel(Tr,'B01K')>0
			if ((GetUnitAbilityLevel(u,1144013095)>0)) {//if(GetUnitAbilityLevel(u,'A0DZ')>0)then
				IssueImmediateOrderById(u, $D02BB);//call IssueImmediateOrderById(u,$D02BB)
				UnitApplyTimedLife(u, 'BTLF', 1.);//call UnitApplyTimedLife(u,'BTLF',1.)
				u = GetSummonedUnit();//set u=GetSummonedUnit()
				if ((u==null)) {//if(u==null)then
					return;//return
				}//endif
			}//endif
			if ((Ur)) {//if(Ur)then
				UnitAddAbility(u, 'A09M');//call UnitAddAbility(u,'A09M')
				SetUnitAbilityLevel(u, 'A09M', 3);//call SetUnitAbilityLevel(u,'A09M',3)
				UnitRemoveAbility(u, 'A09M');//call UnitRemoveAbility(u,'A09M')
				UnitAddAbility(u, 'A09Q');//call UnitAddAbility(u,'A09Q')
				UnitAddAbility(u, 'A09R');//call UnitAddAbility(u,'A09R')
			}//endif
			if ((GetUnitAbilityLevel(Tr,1160790311)>0 && GetRandomInt(0,99)<30)) {//if(GetUnitAbilityLevel(Tr,'A0EL')>0 and GetRandomInt(0,99)<30)then
				UnitAddAbility(u, 'A0EZ');//call UnitAddAbility(u,'A0EZ')
				UnitAddAbility(u, 'A0C5');//call UnitAddAbility(u,'A0C5')
			}//endif
			Vo(u);//call Vo(u)
			Rd[dk] = Rd[dk]+1;//set Rd[dk]=Rd[dk]+1
			if ((GetUnitAbilityLevel(u,925909287)>=1)) {//if(GetUnitAbilityLevel(u,'A07M')>=1)then
				Mo(u);//call Mo(u)
				GroupAddUnit(z9, u);//call GroupAddUnit(z9,u)
			}//endif
		}//endfunction
		private void Vr() {//function Vr takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u=GetEnumUnit()
			bj_forLoopAIndex = bj_forLoopAIndex+1;//set bj_forLoopAIndex=bj_forLoopAIndex+1
			if ((bj_forLoopAIndex<=2 && GetRandomInt(0,99)<17)) {//if(bj_forLoopAIndex<=2 and GetRandomInt(0,99)<17)then
				Sr(CreateUnit(GetOwningPlayer(u), GetUnitTypeId(bj_lastCreatedUnit), GetUnitX(bj_lastCreatedUnit), GetUnitY(bj_lastCreatedUnit), .0), bj_lastLoadedUnit);//call Sr(CreateUnit(GetOwningPlayer(u),GetUnitTypeId(bj_lastCreatedUnit),GetUnitX(bj_lastCreatedUnit),GetUnitY(bj_lastCreatedUnit),.0),bj_lastLoadedUnit)
				if ((GetUnitAbilityLevel(bj_lastCreatedUnit,959463719)>0)) {//if(GetUnitAbilityLevel(bj_lastCreatedUnit,'A09H')>0)then
					Sr(CreateUnit(GetOwningPlayer(u), GetUnitTypeId(bj_lastCreatedUnit), GetUnitX(bj_lastCreatedUnit), GetUnitY(bj_lastCreatedUnit), .0), bj_lastLoadedUnit);//call Sr(CreateUnit(GetOwningPlayer(u),GetUnitTypeId(bj_lastCreatedUnit),GetUnitX(bj_lastCreatedUnit),GetUnitY(bj_lastCreatedUnit),.0),bj_lastLoadedUnit)
				}//endif
			}//endif
			u = null;//set u=null
		}//endfunction
		private void Wr(unit u, unit Tr) {//function Wr takes unit u,unit Tr returns nothing
			player p = GetOwningPlayer(Tr);//local player p=GetOwningPlayer(Tr)
			int dk = GetPlayerId(p);//local integer dk=GetPlayerId(p)
			bool Ur = GetUnitAbilityLevel(Tr,825246247)>0;//local boolean Ur=GetUnitAbilityLevel(Tr,'B01K')>0
			if ((GetUnitAbilityLevel(u,1144013095)>0)) {//if(GetUnitAbilityLevel(u,'A0DZ')>0)then
				ShowUnit(u, false);//call ShowUnit(u,false)
				IssueImmediateOrderById(u, $D02BB);//call IssueImmediateOrderById(u,$D02BB)
				UnitApplyTimedLife(u, 'BTLF', 1.);//call UnitApplyTimedLife(u,'BTLF',1.)
			}//endif
			if ((Ur)) {//if(Ur)then
				UnitAddAbility(u, 'A09M');//call UnitAddAbility(u,'A09M')
				SetUnitAbilityLevel(u, 'A09M', 3);//call SetUnitAbilityLevel(u,'A09M',3)
				UnitRemoveAbility(u, 'A09M');//call UnitRemoveAbility(u,'A09M')
				UnitAddAbility(u, 'A09Q');//call UnitAddAbility(u,'A09Q')
				UnitAddAbility(u, 'A09R');//call UnitAddAbility(u,'A09R')
			}//endif
			Vo(u);//call Vo(u)
			Rd[dk] = Rd[dk]+1;//set Rd[dk]=Rd[dk]+1
			if ((GetUnitAbilityLevel(u,925909287)>=1)) {//if(GetUnitAbilityLevel(u,'A07M')>=1)then
				Mo(u);//call Mo(u)
				GroupAddUnit(z9, u);//call GroupAddUnit(z9,u)
			} else if ((GetUnitAbilityLevel(u,959463719)>0)) {//elseif(GetUnitAbilityLevel(u,'A09H')>0)then
				Sr(CreateUnit(p, GetUnitTypeId(u), GetUnitX(u), GetUnitY(u), .0), Tr);//call Sr(CreateUnit(p,GetUnitTypeId(u),GetUnitX(u),GetUnitY(u),.0),Tr)
			}//endif
			if ((GetUnitAbilityLevel(u,925909287)<=0)) {//if(GetUnitAbilityLevel(u,'A070')<=0)then
				bj_lastCreatedUnit = u;//set bj_lastCreatedUnit=u
				bj_lastLoadedUnit = Tr;//set bj_lastLoadedUnit=Tr
				bj_forLoopAIndex = 0;//set bj_forLoopAIndex=0
				ForGroup(Jd[me[dk]], function Vr);//call ForGroup(Jd[me[dk]],function Vr)
			}//endif
		}//endfunction
		private void Xr() {//function Xr takes nothing returns nothing
			y9 = Filter(function Ir);//set y9=Filter(function Ir)
			A9 = Filter(function Kr);//set A9=Filter(function Kr)
			x9 = Filter(function Cr);//set x9=Filter(function Cr)
			b9 = Filter(function Qr);//set b9=Filter(function Qr)
		}//endfunction
		private void Yr(int x, int y, string lb) {//function Yr takes integer x,integer y,string lb returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((D9[i]!=null)) {//if(D9[i]!=null)then
					J9 = MultiboardGetItem(D9[i],y,x);//set J9=MultiboardGetItem(D9[i],y,x)
					MultiboardSetItemValue(J9, lb);//call MultiboardSetItemValue(J9,lb)
					MultiboardReleaseItem(J9);//call MultiboardReleaseItem(J9)
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			if ((x==1)) {//if(x==1)then
				J9 = MultiboardGetItem(G9,1,(y-1)*6+1);//set J9=MultiboardGetItem(G9,1,(y-1)*6+1)
				MultiboardSetItemValue(J9, lb);//call MultiboardSetItemValue(J9,lb)
				MultiboardReleaseItem(J9);//call MultiboardReleaseItem(J9)
			} else if ((x>2 && x<5)) {//elseif(x>2 and x<5)then
				J9 = MultiboardGetItem(G9,1,(y-1)*6+x-1);//set J9=MultiboardGetItem(G9,1,(y-1)*6+x-1)
				MultiboardSetItemValue(J9, lb);//call MultiboardSetItemValue(J9,lb)
				MultiboardReleaseItem(J9);//call MultiboardReleaseItem(J9)
			} else if ((x==5)) {//elseif(x==5)then
				J9 = MultiboardGetItem(G9,I9,$A);//set J9=MultiboardGetItem(G9,I9,$A)
				MultiboardSetItemValue(J9, lb);//call MultiboardSetItemValue(J9,lb)
				MultiboardReleaseItem(J9);//call MultiboardReleaseItem(J9)
			}//endif
		}//endfunction
		private void Zr(int x, int y, string lb) {//function Zr takes integer x,integer y,string lb returns nothing
			J9 = MultiboardGetItem(G9,x,y);//set J9=MultiboardGetItem(G9,x,y)
			MultiboardSetItemValue(J9, lb);//call MultiboardSetItemValue(J9,lb)
			MultiboardReleaseItem(J9);//call MultiboardReleaseItem(J9)
		}//endfunction
		private string ds() {//function ds takes nothing returns string
			string s = I2S(N9);//local string s=I2S(N9)
			if ((N9<$A)) {//if(N9<$A)then
				s = "0"+s;//set s="0"+s
			}//endif
			return "|cffFFFF00"+I2S(M9)+"|cffFF8000:|cffFFFF00"+s+"|r";//return"|cffFFFF00"+I2S(M9)+"|cffFF8000:|cffFFFF00"+s+"|r"
		}//endfunction
		private void es() {//function es takes nothing returns nothing
			N9 = N9+1;//set N9=N9+1
			if ((N9==60)) {//if(N9==60)then
				N9 = 0;//set N9=0
				M9 = M9+1;//set M9=M9+1
			}//endif
			Yr(5, 3, ds());//call Yr(5,3,ds())
		}//endfunction
		private bool fs() {//function fs takes nothing returns boolean
			int pl = CountPlayersInForceBJ(ie);//local integer pl=CountPlayersInForceBJ(ie)
			int pr = CountPlayersInForceBJ(je);//local integer pr=CountPlayersInForceBJ(je)
			int pq = CountPlayersInForceBJ(ke);//local integer pq=CountPlayersInForceBJ(ke)
			int pc = pl+pr;//local integer pc=pl+pr
			int gs = IntegerTertiaryOp(Bd>0,2*Bd,-Bd);//local integer gs=IntegerTertiaryOp(Bd>0,2*Bd,-Bd)
			if ((bd>0 && pc*bd>l7-gs)) {//if(bd>0 and pc*bd>l7-gs)then
				return false;//return false
			}//endif
			if ((pc>l7-gs)) {//if(pc>l7-gs)then
				return false;//return false
			}//endif
			if ((pc*(bd-1)>pq)) {//if(pc*(bd-1)>pq)then
				return false;//return false
			}//endif
			if ((pc>l7 && td)) {//if(pc>l7 and td)then
				return false;//return false
			}//endif
			if ((Dd>0 && tn(IMaxBJ(pl,pr)*Dd,IMinBJ(pl,pr))*2>pq+pc)) {//if(Dd>0 and tn(IMaxBJ(pl,pr)*Dd,IMinBJ(pl,pr))*2>pq+pc)then
				return false;//return false
			}//endif
			return true;//return true
		}//endfunction
		private void hs(bool fl) {//function hs takes boolean fl returns nothing
			zd = fl;//set zd=fl
			zr();//call zr()
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00AI|r enabled. Units will choose targets by its armor type.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00AI|r enabled. Units will choose targets by its armor type.")
		}//endfunction
		private void is(bool fl) {//function is takes boolean fl returns nothing
			md = !fl;//set md=not fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Artillery|r enabled. You can build structures that attack enemy structures.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Artillery|r enabled. You can build structures that attack enemy structures.")
				df = 825257511;//set df='n01C'
				zf = 925909287;//set zf='A07T'
				We = 825245991;//set We='A01I'
				vf = 1110458663;//set vf='A0BD'
				x8 = 1144013095;//set x8='A0D1'
				y8 = 1144013095;//set y8='A0D0'
				z8 = 1160790311;//set z8='A0E3'
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Artillery|r has been chosen. You cannot build structures that attack enemy structures.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Artillery|r has been chosen. You cannot build structures that attack enemy structures.")
				df = 842034727;//set df='n021'
				zf = 942686503;//set zf='A08T'
				We = 892354855;//set We='A05H'
				vf = 1110458663;//set vf='A0BQ'
				x8 = 1144013095;//set x8='A0D2'
				y8 = 1144013095;//set y8='A0D3'
				z8 = 1160790311;//set z8='A0E4'
			}//endif
			bj_forLoopAIndex = 0;//set bj_forLoopAIndex=0
			bj_forLoopAIndexEnd = $B;//set bj_forLoopAIndexEnd=$B
			while (true) {//loop
				if (bj_forLoopAIndex>bj_forLoopAIndexEnd) { break; }//exitwhen bj_forLoopAIndex>bj_forLoopAIndexEnd
				SetPlayerUnitAvailableBJ('h001', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h001',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('h048', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h048',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('h01E', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h01E',fl,Player(bj_forLoopAIndex))
				bj_forLoopAIndex = bj_forLoopAIndex+1;//set bj_forLoopAIndex=bj_forLoopAIndex+1
			}//endloop
		}//endfunction
		private void js(bool fl) {//function js takes boolean fl returns nothing
			xd = fl;//set xd=fl
			if ((!fl)) {//if(not fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No AFK|r mode has been disabled. Command -afk enabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No AFK|r mode has been disabled. Command -afk enabled.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No AFK|r has been chosen. Command -afk disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No AFK|r has been chosen. Command -afk disabled.")
			}//endif
		}//endfunction
		private void ks() {//function ks takes nothing returns nothing
			Cd = 1;//set Cd=1
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Coin|r has been chosen. There will be a coin spawn every 40 seconds.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Coin|r has been chosen. There will be a coin spawn every 40 seconds.")
		}//endfunction
		private void ms() {//function ms takes nothing returns nothing
			Cd = $A;//set Cd=$A
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Crazy Coins|r has been chosen. Ten coins will spawn every 40 seconds.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Crazy Coins|r has been chosen. Ten coins will spawn every 40 seconds.")
		}//endfunction
		private void ns(bool fl) {//function ns takes boolean fl returns nothing
			kd = fl;//set kd=fl
			if ((!fl)) {//if(not fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Dual Race|r mode has been disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Dual Race|r mode has been disabled.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Dual Race|r has been chosen. Each race can be chosen more than once per team.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Dual Race|r has been chosen. Each race can be chosen more than once per team.")
			}//endif
		}//endfunction
		private void os(bool fl) {//function os takes boolean fl returns nothing
			td = fl;//set td=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Unique Races|r has been chosen. Each race can be chosen only once (even across the teams).");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Unique Races|r has been chosen. Each race can be chosen only once (even across the teams).")
				if (((CountPlayersInForceBJ(ie)+CountPlayersInForceBJ(je))+Bd*2>$A)) {//if((CountPlayersInForceBJ(ie)+CountPlayersInForceBJ(je))+Bd*2>$A)then
					td = false;//set td=false
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Unique Races|r mode has been disabled due so many players.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Unique Races|r mode has been disabled due so many players.")
				}//endif
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Unique Races|r mode has been disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Unique Races|r mode has been disabled.")
			}//endif
		}//endfunction
		private void ps(bool fl) {//function ps takes boolean fl returns nothing
			nd = fl;//set nd=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Treasure Box|r mode has been disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Treasure Box|r mode has been disabled.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Treasure Box|r has been chosen. You cannot build Treasure Boxes.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Treasure Box|r has been chosen. You cannot build Treasure Boxes.")
			}//endif
			bj_forLoopAIndex = 0;//set bj_forLoopAIndex=0
			bj_forLoopAIndexEnd = $B;//set bj_forLoopAIndexEnd=$B
			while (true) {//loop
				if (bj_forLoopAIndex>bj_forLoopAIndexEnd) { break; }//exitwhen bj_forLoopAIndex>bj_forLoopAIndexEnd
				SetPlayerUnitAvailableBJ('h008', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h008',fl,Player(bj_forLoopAIndex))
				bj_forLoopAIndex = bj_forLoopAIndex+1;//set bj_forLoopAIndex=bj_forLoopAIndex+1
			}//endloop
		}//endfunction
		private void qs(bool fl) {//function qs takes boolean fl returns nothing
			od = fl;//set od=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Bounty|r mode has been disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Bounty|r mode has been disabled.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Bounty|r has been chosen. Neither units nor buildings will give bounty when destroyed.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Bounty|r has been chosen. Neither units nor buildings will give bounty when destroyed.")
			}//endif
			bj_forLoopAIndex = 0;//set bj_forLoopAIndex=0
			bj_forLoopAIndexEnd = $B;//set bj_forLoopAIndexEnd=$B
			while (true) {//loop
				if (bj_forLoopAIndex>bj_forLoopAIndexEnd) { break; }//exitwhen bj_forLoopAIndex>bj_forLoopAIndexEnd
				SetPlayerFlagBJ(PLAYER_STATE_GIVES_BOUNTY, fl, Player(bj_forLoopAIndex));//call SetPlayerFlagBJ(PLAYER_STATE_GIVES_BOUNTY,fl,Player(bj_forLoopAIndex))
				bj_forLoopAIndex = bj_forLoopAIndex+1;//set bj_forLoopAIndex=bj_forLoopAIndex+1
			}//endloop
		}//endfunction
		private void rs(bool fl) {//function rs takes boolean fl returns nothing
			pd = fl;//set pd=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Specials|r mode has been disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Specials|r mode has been disabled.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Specials|r has been chosen. You can't build special buildings except towers and Treasure Boxes.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Specials|r has been chosen. You can't build special buildings except towers and Treasure Boxes.")
			}//endif
			bj_forLoopAIndex = 0;//set bj_forLoopAIndex=0
			bj_forLoopAIndexEnd = $B;//set bj_forLoopAIndexEnd=$B
			while (true) {//loop
				if (bj_forLoopAIndex>bj_forLoopAIndexEnd) { break; }//exitwhen bj_forLoopAIndex>bj_forLoopAIndexEnd
				SetPlayerUnitAvailableBJ('h01P', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h01P',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('h056', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h056',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('h014', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h014',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('h03Q', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h03Q',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('h01O', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h01O',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('o000', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('o000',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('h006', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h006',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('n01J', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('n01J',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('h073', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h073',fl,Player(bj_forLoopAIndex))
				SetPlayerUnitAvailableBJ('h05L', fl, Player(bj_forLoopAIndex));//call SetPlayerUnitAvailableBJ('h05L',fl,Player(bj_forLoopAIndex))
				bj_forLoopAIndex = bj_forLoopAIndex+1;//set bj_forLoopAIndex=bj_forLoopAIndex+1
			}//endloop
		}//endfunction
		private void ss(bool fl) {//function ss takes boolean fl returns nothing
			qd = fl;//set qd=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Items|r mode has been disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Items|r mode has been disabled.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Items|r has been chosen. The castle doesn't sell any items.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Items|r has been chosen. The castle doesn't sell any items.")
			}//endif
		}//endfunction
		private void ts(bool fl) {//function ts takes boolean fl returns nothing
			rd = fl;//set rd=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Legendaries|r mode has been disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Legendaries|r mode has been disabled.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Legendaries|r has been chosen. You don't get food to buy legendary buildings.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Legendaries|r has been chosen. You don't get food to buy legendary buildings.")
			}//endif
		}//endfunction
		private void us(bool fl) {//function us takes boolean fl returns nothing
			sd = fl;//set sd=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Rescue Strike|r mode has been disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Rescue Strike|r mode has been disabled.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Rescue Strike|r has been chosen. Your worker doesn't have a Rescue Strike!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Rescue Strike|r has been chosen. Your worker doesn't have a Rescue Strike!")
			}//endif
		}//endfunction
		private void vs(int ws) {//function vs takes integer ws returns nothing
			if ((ws<$96)) {//if(ws<$96)then
				ad = -1;//set ad=-1
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Lumber Limit|r mode has been disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Lumber Limit|r mode has been disabled.")
			} else {//else
				ad = ws;//set ad=ws
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Lumber Limit|r has been set to |cffFFFF00"+I2S(ad)+"|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Lumber Limit|r has been set to |cffFFFF00"+I2S(ad)+"|r.")
			}//endif
		}//endfunction
		private void xs(int ws) {//function xs takes integer ws returns nothing
			hd = IMaxBJ(IMinBJ(ws,'x'),2);//set hd=IMaxBJ(IMinBJ(ws,'x'),2)
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Income Timer|r has been set to |cffFFFF00"+I2S(hd)+"|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Income Timer|r has been set to |cffFFFF00"+I2S(hd)+"|r.")
		}//endfunction
		private void ys(int zs) {//function ys takes integer zs returns nothing
			Ad = zs;//set Ad=zs
			if ((Ad==1)) {//if(Ad==1)then
				kf = 1000.;//set kf=1000.
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00No Taxes|r has been chosen. You don't have to pay taxes on your income.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00No Taxes|r has been chosen. You don't have to pay taxes on your income.")
			} else if ((Ad==2)) {//elseif(Ad==2)then
				kf = 12.5;//set kf=12.5
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00High Taxes|r has been chosen. Tax rate increases 10% every 12.5 income.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00High Taxes|r has been chosen. Tax rate increases 10% every 12.5 income.")
			}//endif
		}//endfunction
		private void As(bool fl) {//function As takes boolean fl returns nothing
			ud = fl;//set ud=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Caging|r mode has been disabled.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Caging|r mode has been disabled.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Caging|r has been chosen. You can trap units with your buildings");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Caging|r has been chosen. You can trap units with your buildings")
			}//endif
		}//endfunction
		private void as(bool fl) {//function as takes boolean fl returns nothing
			vd = fl;//set vd=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Domination|r has been chosen. You gain extra income by controlling the lanes.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Domination|r has been chosen. You gain extra income by controlling the lanes.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "TODO::SetDOMStatus(false)");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"TODO::SetDOMStatus(false)")
			}//endif
		}//endfunction
		private void Bs(int zs) {//function Bs takes integer zs returns nothing
			if ((zs>2)) {//if(zs>2)then
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Wrong Autobalance variation!|r");//call DisplayTextToPlayer(Player(0),.0,.0,"|cffFF0000Wrong Autobalance variation!|r")
				return;//return
			}//endif
			fd = zs;//set fd=zs
			if ((zs==0)) {//if(zs==0)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Autobalance|r has been setted to |cffFFFF000|r. All units of any left player will be divided between members in team.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Autobalance|r has been setted to |cffFFFF000|r. All units of any left player will be divided between members in team.")
			} else if ((zs==1)) {//elseif(zs==1)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Autobalance|r has been setted to |cffFFFF001|r. All depended players of any left player will be shared between members in team.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Autobalance|r has been setted to |cffFFFF001|r. All depended players of any left player will be shared between members in team.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Autobalance|r has been setted to |cffFFFF001|r. AI will take control of any left player.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Autobalance|r has been setted to |cffFFFF001|r. AI will take control of any left player.")
			}//endif
		}//endfunction
		private void bs(int zs) {//function bs takes integer zs returns nothing
			if ((zs==0)) {//if(zs==0)then
				Bd = -1;//set Bd=-1
			} else {//else
				Bd = -zs;//set Bd=-zs
			}//endif
			if ((!fs())) {//if(not fs())then
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Too many players for Random Ban Race mode!|r");//call DisplayTextToPlayer(Player(0),.0,.0,"|cffFF0000Too many players for Random Ban Race mode!|r")
				Bd = 0;//set Bd=0
				return;//return
			}//endif
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Random Ban Race|r has been chosen. Number of bans: |cffFFFF00"+I2S(IAbsBJ(Bd))+"|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Random Ban Race|r has been chosen. Number of bans: |cffFFFF00"+I2S(IAbsBJ(Bd))+"|r.")
		}//endfunction
		private void Cs(int zs) {//function Cs takes integer zs returns nothing
			if ((zs==0)) {//if(zs==0)then
				Bd = 1;//set Bd=1
			} else {//else
				Bd = zs;//set Bd=zs
			}//endif
			if ((!fs())) {//if(not fs())then
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Too many players for Ban Race mode!|r");//call DisplayTextToPlayer(Player(0),.0,.0,"|cffFF0000Too many players for Ban Race mode!|r")
				Bd = 0;//set Bd=0
				return;//return
			}//endif
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Ban Race|r has been chosen. Number of bans per team: |cffFFFF00"+I2S(Bd)+"|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Ban Race|r has been chosen. Number of bans per team: |cffFFFF00"+I2S(Bd)+"|r.")
		}//endfunction
		private void cs(int zs) {//function cs takes integer zs returns nothing
			if ((zs==0)) {//if(zs==0)then
				Dd = 1;//set Dd=1
			} else {//else
				Dd = zs;//set Dd=zs
			}//endif
			bd = 0;//set bd=0
			if ((!fs())) {//if(not fs())then
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Too many players for Extended Multi Race mode!|r");//call DisplayTextToPlayer(Player(0),.0,.0,"|cffFF0000Too many players for Extended Multi Race mode!|r")
				Dd = 0;//set Dd=0
				return;//return
			}//endif
			fd = 1;//set fd=1
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Extended Multiple Players|r has been chosen. Parameter's value is: |cffFFFF00"+I2S(Dd)+"|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Extended Multiple Players|r has been chosen. Parameter's value is: |cffFFFF00"+I2S(Dd)+"|r.")
		}//endfunction
		private void Ds(int zs) {//function Ds takes integer zs returns nothing
			if ((zs<1 || zs>5)) {//if(zs<1 or zs>5)then
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Wrong number of players per player! Must be between 2 and 4!|r");//call DisplayTextToPlayer(Player(0),.0,.0,"|cffFF0000Wrong number of players per player! Must be between 2 and 4!|r")
				return;//return
			}//endif
			Dd = 0;//set Dd=0
			bd = zs;//set bd=zs
			if ((!fs())) {//if(not fs())then
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Too many players for Multi Race mode!|r");//call DisplayTextToPlayer(Player(0),.0,.0,"|cffFF0000Too many players for Multi Race mode!|r")
				bd = 0;//set bd=0
				return;//return
			}//endif
			fd = 1;//set fd=1
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Multiple Players|r has been chosen. Number of additional players per human player: |cffFFFF00"+I2S(zs)+"|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Multiple Players|r has been chosen. Number of additional players per human player: |cffFFFF00"+I2S(zs)+"|r")
		}//endfunction
		private void Es(bool fl) {//function Es takes boolean fl returns nothing
			wd = fl;//set wd=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Stop-detection|r system has been activated. Any player will be detected on bug usage.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Stop-detection|r system has been activated. Any player will be detected on bug usage.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "TODO::SetSDStatus(false)");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"TODO::SetSDStatus(false)")
			}//endif
		}//endfunction
		private void Fs(bool fl) {//function Fs takes boolean fl returns nothing
			yd = fl;//set yd=fl
			if ((fl)) {//if(fl)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Debuging|r is on.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Debuging|r is on.")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Debuging|r is off.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Debuging|r is off.")
			}//endif
		}//endfunction
		private void Gs(int yj) {//function Gs takes integer yj returns nothing
			if ((IAbsBJ(yj)>5)) {//if(IAbsBJ(yj)>5)then
				cd = yj;//set cd=yj
				if ((yj>0)) {//if(yj>0)then
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Round time limit for win|r has been activated. Round will automatically end after "+I2S(IAbsBJ(yj))+" minutes and owner of first building will win.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Round time limit for win|r has been activated. Round will automatically end after "+I2S(IAbsBJ(yj))+" minutes and owner of first building will win.")
				} else {//else
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Round time limit for draw|r has been activated. Round will automatically end after "+I2S(IAbsBJ(yj))+" minutes with draw result.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Round time limit for draw|r has been activated. Round will automatically end after "+I2S(IAbsBJ(yj))+" minutes with draw result.")
				}//endif
			} else {//else
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Wrong value of minutes for round time limitation! Must be more 5!|r");//call DisplayTextToPlayer(Player(0),.0,.0,"|cffFF0000Wrong value of minutes for round time limitation! Must be more 5!|r")
			}//endif
		}//endfunction
		private void Hs(int yj) {//function Hs takes integer yj returns nothing
			int p = l7;//local integer p=l7
			if ((yj==0)) {//if(yj==0)then
				yj = 1;//set yj=1
			}//endif
			l7 = l7-yj;//set l7=l7-yj
			if ((!fs())) {//if(not fs())then
				DisplayTextToPlayer(Player(0), .0, .0, "|cffFF0000Not possible to disable so many races!|r");//call DisplayTextToPlayer(Player(0),.0,.0,"|cffFF0000Not possible to disable so many races!|r")
				l7 = p;//set l7=p
				return;//return
			}//endif
			Ed = yj;//set Ed=yj
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00System-races-pool|r has been changed. There are |cffFFFF00"+I2S(yj)+"|r new races have been removed.|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00System-races-pool|r has been changed. There are |cffFFFF00"+I2S(yj)+"|r new races have been removed.|r")
		}//endfunction
		private void Is() {//function Is takes nothing returns nothing
			int i = 0;//local integer i=0
			int j;//local integer j
			player p;//local player p
			unit u;//local unit u
			while (true) {//loop
				if (i>$B) { break; }//exitwhen i>$B
				j = 1;//set j=1
				p = Player(i);//set p=Player(i)
				while (true) {//loop
					u = CreateUnitAtLoc(p,1667593255+j,R9,.0);//set u=CreateUnitAtLoc(p,'tec0'+j,R9,.0)
					ShowUnit(u, false);//call ShowUnit(u,false)
					j = j+1;//set j=j+1
					if (j>3) { break; }//exitwhen j>3
				}//endloop
				i = i+1;//set i=i+1
			}//endloop
		}//endfunction
		private void ls(int i) {//function ls takes integer i returns nothing
			ge[i] = 0;//set ge[i]=0
			mf[i] = .0;//set mf[i]=.0
			Rd[i] = -1;//set Rd[i]=-1
			Sd[i] = -1;//set Sd[i]=-1
			Td[i] = -1;//set Td[i]=-1
			Ud[i] = -1;//set Ud[i]=-1
			Vd[i] = -1;//set Vd[i]=-1
			Wd[i] = -1;//set Wd[i]=-1
			Xd[i] = -1;//set Xd[i]=-1
			Yd[i] = -1;//set Yd[i]=-1
			Zd[i] = -1;//set Zd[i]=-1
			de[i] = -1;//set de[i]=-1
			ee[i] = -1;//set ee[i]=-1
			fe[i] = -1;//set fe[i]=-1
			he[i] = 0;//set he[i]=0
		}//endfunction
		private void Js(int i) {//function Js takes integer i returns nothing
			ge[i] = 0;//set ge[i]=0
			mf[i] = .5;//set mf[i]=.5
			Rd[i] = 0;//set Rd[i]=0
			Sd[i] = 0;//set Sd[i]=0
			Td[i] = 0;//set Td[i]=0
			Ud[i] = 0;//set Ud[i]=0
			Vd[i] = 0;//set Vd[i]=0
			Wd[i] = 0;//set Wd[i]=0
			Xd[i] = 0;//set Xd[i]=0
			Yd[i] = 0;//set Yd[i]=0
			Zd[i] = 0;//set Zd[i]=0
			de[i] = 0;//set de[i]=0
			ee[i] = 0;//set ee[i]=0
			fe[i] = 0;//set fe[i]=0
			he[i] = '}';//set he[i]='}'
		}//endfunction
		private string Ks(int dk) {//function Ks takes integer dk returns string
			playercolor pc = GetPlayerColor(Player(dk));//local playercolor pc=GetPlayerColor(Player(dk))
			string Im;//local string Im
			if ((pc==PLAYER_COLOR_RED)) {//if(pc==PLAYER_COLOR_RED)then
				Im = "|cffff0000";//set Im="|cffff0000"
			} else if ((pc==PLAYER_COLOR_BLUE)) {//elseif(pc==PLAYER_COLOR_BLUE)then
				Im = "|cff0000FF";//set Im="|cff0000FF"
			} else if ((pc==PLAYER_COLOR_CYAN)) {//elseif(pc==PLAYER_COLOR_CYAN)then
				Im = "|cff00FFFF";//set Im="|cff00FFFF"
			} else if ((pc==PLAYER_COLOR_PURPLE)) {//elseif(pc==PLAYER_COLOR_PURPLE)then
				Im = "|cff800080";//set Im="|cff800080"
			} else if ((pc==PLAYER_COLOR_YELLOW)) {//elseif(pc==PLAYER_COLOR_YELLOW)then
				Im = "|cffFFFF00";//set Im="|cffFFFF00"
			} else if ((pc==PLAYER_COLOR_ORANGE)) {//elseif(pc==PLAYER_COLOR_ORANGE)then
				Im = "|cffFFCC00";//set Im="|cffFFCC00"
			} else if ((pc==PLAYER_COLOR_GREEN)) {//elseif(pc==PLAYER_COLOR_GREEN)then
				Im = "|cff00ff00";//set Im="|cff00ff00"
			} else if ((pc==PLAYER_COLOR_PINK)) {//elseif(pc==PLAYER_COLOR_PINK)then
				Im = "|cffff00ff";//set Im="|cffff00ff"
			} else if ((pc==PLAYER_COLOR_LIGHT_GRAY)) {//elseif(pc==PLAYER_COLOR_LIGHT_GRAY)then
				Im = "|cffc0c0c0";//set Im="|cffc0c0c0"
			} else if ((pc==PLAYER_COLOR_LIGHT_BLUE)) {//elseif(pc==PLAYER_COLOR_LIGHT_BLUE)then
				Im = "|cffCCFFFF";//set Im="|cffCCFFFF"
			} else if ((pc==PLAYER_COLOR_AQUA)) {//elseif(pc==PLAYER_COLOR_AQUA)then
				Im = "|cff087329";//set Im="|cff087329"
			} else if ((pc==PLAYER_COLOR_BROWN)) {//elseif(pc==PLAYER_COLOR_BROWN)then
				Im = "|cffC16D00";//set Im="|cffC16D00"
			} else {//else
				Im = "|CFFFFFFFF";//set Im="|CFFFFFFFF"
			}//endif
			pc = null;//set pc=null
			return Im;//return Im
		}//endfunction
		private void Ls(int dk) {//function Ls takes integer dk returns nothing
			pe[dk] = Ks(dk)+GetPlayerName(Player(dk))+"|r";//set pe[dk]=Ks(dk)+GetPlayerName(Player(dk))+"|r"
		}//endfunction
		private void Ms() {//function Ms takes nothing returns nothing
			player p = GetEnumPlayer();//local player p=GetEnumPlayer()
			int i = GetPlayerId(p);//local integer i=GetPlayerId(p)
			ForceRemovePlayer(ie, p);//call ForceRemovePlayer(ie,p)
			ForceRemovePlayer(je, p);//call ForceRemovePlayer(je,p)
			ForceAddPlayer(ke, p);//call ForceAddPlayer(ke,p)
			E9[i] = null;//set E9[i]=null
		}//endfunction
		private void Ns() {//function Ns takes nothing returns nothing
			int i = 0;//local integer i=0
			int j;//local integer j
			player p;//local player p
			bool Os;//local boolean Os
			while (true) {//loop
				if ((ne[i]!=null)) {//if(ne[i]!=null)then
					ForForce(ne[i], function Ms);//call ForForce(ne[i],function Ms)
					SetPlayerName(Player(i), l9[i]);//call SetPlayerName(Player(i),l9[i])
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			i = 0;//set i=0
			while (true) {//loop
				if ((ne[i]!=null)) {//if(ne[i]!=null)then
					Os = IsPlayerInForce(Player(i),ie);//set Os=IsPlayerInForce(Player(i),ie)
					j = 1;//set j=1
					while (true) {//loop
						p = zn(Os);//set p=zn(Os)
						ForceRemovePlayer(ke, p);//call ForceRemovePlayer(ke,p)
						ForceAddPlayer(ne[i], p);//call ForceAddPlayer(ne[i],p)
						if ((Os)) {//if(Os)then
							ForceAddPlayer(ie, p);//call ForceAddPlayer(ie,p)
							Qd[GetPlayerId(p)] = PolarProjectionBJ(Qd[i],96.*j,.0);//set Qd[GetPlayerId(p)]=PolarProjectionBJ(Qd[i],96.*j,.0)
						} else {//else
							ForceAddPlayer(je, p);//call ForceAddPlayer(je,p)
							Qd[GetPlayerId(p)] = PolarProjectionBJ(Qd[i],96.*j,180.);//set Qd[GetPlayerId(p)]=PolarProjectionBJ(Qd[i],96.*j,180.)
						}//endif
						SetPlayerName(p, l9[i]);//call SetPlayerName(p,l9[i])
						pe[GetPlayerId(p)] = Ks(GetPlayerId(p))+GetPlayerName(p)+"|r";//set pe[GetPlayerId(p)]=Ks(GetPlayerId(p))+GetPlayerName(p)+"|r"
						me[GetPlayerId(p)] = me[i];//set me[GetPlayerId(p)]=me[i]
						j = j+1;//set j=j+1
						if (j>=bd) { break; }//exitwhen j>=bd
					}//endloop
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void Ps() {//function Ps takes nothing returns nothing
			int pl = CountPlayersInForceBJ(ie);//local integer pl=CountPlayersInForceBJ(ie)
			int pr = CountPlayersInForceBJ(je);//local integer pr=CountPlayersInForceBJ(je)
			int Qs = tn(IMaxBJ(pl,pr)*Dd,IMinBJ(pl,pr));//local integer Qs=tn(IMaxBJ(pl,pr)*Dd,IMinBJ(pl,pr))
			int Rs = Qs/ pl;//local integer Rs=Qs/ pl
			int Ss = Qs/ pr;//local integer Ss=Qs/ pr
			int i = 0;//local integer i=0
			int j;//local integer j
			int l;//local integer l
			player p;//local player p
			bool Os;//local boolean Os
			while (true) {//loop
				if ((ne[i]!=null)) {//if(ne[i]!=null)then
					ForForce(ne[i], function Ms);//call ForForce(ne[i],function Ms)
					SetPlayerName(Player(i), l9[i]);//call SetPlayerName(Player(i),l9[i])
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			i = 0;//set i=0
			while (true) {//loop
				if ((ne[i]!=null)) {//if(ne[i]!=null)then
					Os = IsPlayerInForce(Player(i),ie);//set Os=IsPlayerInForce(Player(i),ie)
					l = IntegerTertiaryOp(Os,Rs,Ss);//set l=IntegerTertiaryOp(Os,Rs,Ss)
					j = 1;//set j=1
					while (true) {//loop
						if (j>=l) { break; }//exitwhen j>=l
						p = zn(Os);//set p=zn(Os)
						ForceRemovePlayer(ke, p);//call ForceRemovePlayer(ke,p)
						ForceAddPlayer(ne[i], p);//call ForceAddPlayer(ne[i],p)
						if ((Os)) {//if(Os)then
							ForceAddPlayer(ie, p);//call ForceAddPlayer(ie,p)
							Qd[GetPlayerId(p)] = PolarProjectionBJ(Qd[i],96.*j,.0);//set Qd[GetPlayerId(p)]=PolarProjectionBJ(Qd[i],96.*j,.0)
						} else {//else
							ForceAddPlayer(je, p);//call ForceAddPlayer(je,p)
							Qd[GetPlayerId(p)] = PolarProjectionBJ(Qd[i],96.*j,180.);//set Qd[GetPlayerId(p)]=PolarProjectionBJ(Qd[i],96.*j,180.)
						}//endif
						SetPlayerName(p, l9[i]);//call SetPlayerName(p,l9[i])
						pe[GetPlayerId(p)] = Ks(GetPlayerId(p))+GetPlayerName(p)+"|r";//set pe[GetPlayerId(p)]=Ks(GetPlayerId(p))+GetPlayerName(p)+"|r"
						me[GetPlayerId(p)] = me[i];//set me[GetPlayerId(p)]=me[i]
						j = j+1;//set j=j+1
					}//endloop
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void Ts() {//function Ts takes nothing returns nothing
			if ((Dd>0)) {//if(Dd>0)then
				Ps();//call Ps()
				return;//return
			} else if ((bd>0)) {//elseif(bd>0)then
				Ns();//call Ns()
				return;//return
			}//endif
			DisplayTimedTextToPlayer(GetLocalPlayer(), .0, .0, 60., "Unknown exception at module Main::SunAMP. Please report.");//call DisplayTimedTextToPlayer(GetLocalPlayer(),.0,.0,60.,"Unknown exception at module Main::SunAMP. Please report.")
		}//endfunction
		private void Us() {//function Us takes nothing returns nothing
			int i = 0;//local integer i=0
			player p = Player($C);//local player p=Player($C)
			C9 = GetWorldBounds();//set C9=GetWorldBounds()
			Q9 = Rect(-288.,3296.,-96.,3488.);//set Q9=Rect(-288.,3296.,-96.,3488.)
			while (true) {//loop
				me[i] = 0;//set me[i]=0
				if ((GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING)) {//if(GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING)then
					ForceAddPlayer(ie, Player(i));//call ForceAddPlayer(ie,Player(i))
					CreateFogModifierRectBJ(true, Player(i), FOG_OF_WAR_VISIBLE, Q9);//call CreateFogModifierRectBJ(true,Player(i),FOG_OF_WAR_VISIBLE,Q9)
					Qd[i] = dn(true);//set Qd[i]=dn(true)
					ne[i] = CreateForce();//set ne[i]=CreateForce()
					l9[i] = GetPlayerName(Player(i));//set l9[i]=GetPlayerName(Player(i))
				} else if ((GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_EMPTY)) {//elseif(GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_EMPTY)then
					ForceAddPlayer(ke, Player(i));//call ForceAddPlayer(ke,Player(i))
				}//endif
				me[i+6] = 1;//set me[i+6]=1
				if ((GetPlayerSlotState(Player(i+6))==PLAYER_SLOT_STATE_PLAYING)) {//if(GetPlayerSlotState(Player(i+6))==PLAYER_SLOT_STATE_PLAYING)then
					ForceAddPlayer(je, Player(i+6));//call ForceAddPlayer(je,Player(i+6))
					CreateFogModifierRectBJ(true, Player(i+6), FOG_OF_WAR_VISIBLE, Q9);//call CreateFogModifierRectBJ(true,Player(i+6),FOG_OF_WAR_VISIBLE,Q9)
					Qd[i+6] = dn(false);//set Qd[i+6]=dn(false)
					ne[i+6] = CreateForce();//set ne[i+6]=CreateForce()
					l9[i+6] = GetPlayerName(Player(i+6));//set l9[i+6]=GetPlayerName(Player(i+6))
				} else if ((GetPlayerSlotState(Player(i+6))==PLAYER_SLOT_STATE_EMPTY)) {//elseif(GetPlayerSlotState(Player(i+6))==PLAYER_SLOT_STATE_EMPTY)then
					ForceAddPlayer(ke, Player(i+6));//call ForceAddPlayer(ke,Player(i+6))
				}//endif
				i = i+1;//set i=i+1
				if (i>=6) { break; }//exitwhen i>=6
			}//endloop
			R9 = Location(-192.,3392.);//set R9=Location(-192.,3392.)
			Id[0] = GetRectCenter(Fg);//set Id[0]=GetRectCenter(Fg)
			Id[1] = GetRectCenter(Eg);//set Id[1]=GetRectCenter(Eg)
			Id[2] = GetRectCenter(Eg);//set Id[2]=GetRectCenter(Eg)
			Id[3] = GetRectCenter(Fg);//set Id[3]=GetRectCenter(Fg)
			Ld[0] = Dg;//set Ld[0]=Dg
			Ld[1] = cg;//set Ld[1]=cg
			Od[0] = "|cffff0303Western Forces|r";//set Od[0]="|cffff0303Western Forces|r"
			Jd[0] = CreateGroup();//set Jd[0]=CreateGroup()
			Od[1] = "|cff20c000Eastern Forces|r";//set Od[1]="|cff20c000Eastern Forces|r"
			Jd[1] = CreateGroup();//set Jd[1]=CreateGroup()
			i = 0;//set i=0
			while (true) {//loop
				GroupAddUnit(P9, CreateUnit(p, 'h00L', -192., 3392., 270.));//call GroupAddUnit(P9,CreateUnit(p,'h00L',-192.,3392.,270.))
				i = i+1;//set i=i+1
				if (i>33) { break; }//exitwhen i>33
			}//endloop
			p = Player($F);//set p=Player($F)
			CreateUnit(p, 'h00L', -192., 3392., 270.);//call CreateUnit(p,'h00L',-192.,3392.,270.)
			CreateUnit(p, 'nshp', 320., 1856., 270.);//call CreateUnit(p,'nshp',320.,1856.,270.)
			SetUnitColor(CreateUnit(p, 'nmrk', -256., -2816., 270.), ConvertPlayerColor(0));//call SetUnitColor(CreateUnit(p,'nmrk',-256.,-2816.,270.),ConvertPlayerColor(0))
			CreateUnit(p, 'nder', -4735.4, 3246.1, 109.526);//call CreateUnit(p,'nder',-4735.4,3246.1,109.526)
			CreateUnit(p, 'nfro', -1091.1, 2532.8, 224.842);//call CreateUnit(p,'nfro',-1091.1,2532.8,224.842)
			CreateUnit(p, 'nfro', -1750.8, 3170.3, 12.503);//call CreateUnit(p,'nfro',-1750.8,3170.3,12.503)
			CreateUnit(p, 'nfro', -4208.5, -3103.9, 62.844);//call CreateUnit(p,'nfro',-4208.5,-3103.9,62.844)
			CreateUnit(p, 'nrac', 3575.1, -3410.6, 28.565);//call CreateUnit(p,'nrac',3575.1,-3410.6,28.565)
			CreateUnit(p, 'nrac', 215.3, -2989.1, 39.991);//call CreateUnit(p,'nrac',215.3,-2989.1,39.991)
			CreateUnit(p, 'nder', -734.9, -2927.2, 354.77);//call CreateUnit(p,'nder',-734.9,-2927.2,354.77)
			CreateUnit(p, 'nder', -778.4, 3161.3, 100.297);//call CreateUnit(p,'nder',-778.4,3161.3,100.297)
			CreateUnit(p, 'nder', 486.3, 3092.6, 147.507);//call CreateUnit(p,'nder',486.3,3092.6,147.507)
			CreateUnit(p, 'nder', 2097.6, 2634.9, 173.293);//call CreateUnit(p,'nder',2097.6,2634.9,173.293)
			CreateUnit(p, 'necr', 2734.8, 2968., 320.909);//call CreateUnit(p,'necr',2734.8,2968.,320.909)
			CreateUnit(p, 'necr', -601.3, 1917.2, 359.418);//call CreateUnit(p,'necr',-601.3,1917.2,359.418)
			CreateUnit(p, 'necr', -2505.3, 3205.6, 108.405);//call CreateUnit(p,'necr',-2505.3,3205.6,108.405)
			CreateUnit(p, 'necr', -2553.8, 3097.9, 314.669);//call CreateUnit(p,'necr',-2553.8,3097.9,314.669)
			CreateUnit(p, 'nfro', 4466.5, 3139.7, 42.463);//call CreateUnit(p,'nfro',4466.5,3139.7,42.463)
			CreateUnit(p, 'nfro', 539.6, 2646.5, 108.054);//call CreateUnit(p,'nfro',539.6,2646.5,108.054)
			CreateUnit(p, 'necr', -5469.2, 2773.2, 240.63);//call CreateUnit(p,'necr',-5469.2,2773.2,240.63)
			CreateUnit(p, 'nrac', -3882.6, 3455.9, 171.348);//call CreateUnit(p,'nrac',-3882.6,3455.9,171.348)
			CreateUnit(p, 'necr', -2951.9, 3480.5, 75.248);//call CreateUnit(p,'necr',-2951.9,3480.5,75.248)
			CreateUnit(p, 'nder', -1995.2, 3031.8, 320.569);//call CreateUnit(p,'nder',-1995.2,3031.8,320.569)
			CreateUnit(p, 'nder', -4755.9, -3285.9, 96.265);//call CreateUnit(p,'nder',-4755.9,-3285.9,96.265)
			CreateUnit(p, 'necr', -2813.4, -3182.2, 270.799);//call CreateUnit(p,'necr',-2813.4,-3182.2,270.799)
			CreateUnit(p, 'nrac', -2009.7, -3134.2, 263.79);//call CreateUnit(p,'nrac',-2009.7,-3134.2,263.79)
			CreateUnit(p, 'nder', 5212.3, -3150.6, 44.199);//call CreateUnit(p,'nder',5212.3,-3150.6,44.199)
			CreateUnit(p, 'nfro', 4753.5, -3152.8, 349.596);//call CreateUnit(p,'nfro',4753.5,-3152.8,349.596)
			CreateUnit(p, 'nrac', -10.6, 3013.2, 169.052);//call CreateUnit(p,'nrac',-10.6,3013.2,169.052)
			CreateUnit(p, 'ndwm', 1689.8, -2774.7, 192.19);//call CreateUnit(p,'ndwm',1689.8,-2774.7,192.19)
			CreateUnit(p, 'ndog', -3610.9, -3243.8, 118.216);//call CreateUnit(p,'ndog',-3610.9,-3243.8,118.216)
			CreateUnit(p, 'ndog', 1334.7, 2849.5, 136.344);//call CreateUnit(p,'ndog',1334.7,2849.5,136.344)
			CreateUnit(p, 'ndog', 3868.8, 3221.9, 302.375);//call CreateUnit(p,'ndog',3868.8,3221.9,302.375)
			CreateUnit(p, 'nshe', -5537.3, 3457.1, 52.22);//call CreateUnit(p,'nshe',-5537.3,3457.1,52.22)
			CreateUnit(p, 'nsno', 824.5, 3262.9, 175.677);//call CreateUnit(p,'nsno',824.5,3262.9,175.677)
			CreateUnit(p, 'nsno', 202.1, -2945.4, 216.679);//call CreateUnit(p,'nsno',202.1,-2945.4,216.679)
			CreateUnit(p, 'npnw', 745.5, 2441.4, 238.74);//call CreateUnit(p,'npnw',745.5,2441.4,238.74)
			CreateUnit(p, 'npnw', -1503.3, 3397.6, 70.468);//call CreateUnit(p,'npnw',-1503.3,3397.6,70.468)
			CreateUnit(p, 'nhmc', -1045.4, 2540.1, 279.314);//call CreateUnit(p,'nhmc',-1045.4,2540.1,279.314)
			CreateUnit(p, 'nskk', -1729., 3470.5, 317.767);//call CreateUnit(p,'nskk',-1729.,3470.5,317.767)
			CreateUnit(p, 'nskk', -2433.4, 2555.1, 311.109);//call CreateUnit(p,'nskk',-2433.4,2555.1,311.109)
			CreateUnit(p, 'nskk', 3859.9, -3350.3, 329.995);//call CreateUnit(p,'nskk',3859.9,-3350.3,329.995)
			CreateUnit(p, 'ncrb', 4721.1, -3370.7, 285.192);//call CreateUnit(p,'ncrb',4721.1,-3370.7,285.192)
			CreateUnit(p, 'nalb', 4473.6, -3164.3, 324.601);//call CreateUnit(p,'nalb',4473.6,-3164.3,324.601)
			CreateUnit(p, 'nhmc', 4158.9, -3098.4, 273.93);//call CreateUnit(p,'nhmc',4158.9,-3098.4,273.93)
			Is();//call Is()
			bj_forLoopAIndex = 0;//set bj_forLoopAIndex=0
			bj_forLoopAIndexEnd = $B;//set bj_forLoopAIndexEnd=$B
			while (true) {//loop
				if (bj_forLoopAIndex>bj_forLoopAIndexEnd) { break; }//exitwhen bj_forLoopAIndex>bj_forLoopAIndexEnd
				SetPlayerFlagBJ(PLAYER_STATE_GIVES_BOUNTY, true, Player(bj_forLoopAIndex));//call SetPlayerFlagBJ(PLAYER_STATE_GIVES_BOUNTY,true,Player(bj_forLoopAIndex))
				pe[bj_forLoopAIndex] = Ks(bj_forLoopAIndex)+GetPlayerName(Player(bj_forLoopAIndex))+"|r";//set pe[bj_forLoopAIndex]=Ks(bj_forLoopAIndex)+GetPlayerName(Player(bj_forLoopAIndex))+"|r"
				Gd[bj_forLoopAIndex] = true;//set Gd[bj_forLoopAIndex]=true
				bj_forLoopAIndex = bj_forLoopAIndex+1;//set bj_forLoopAIndex=bj_forLoopAIndex+1
			}//endloop
			SetMapFlag(MAP_LOCK_RESOURCE_TRADING, true);//call SetMapFlag(MAP_LOCK_RESOURCE_TRADING,true)
			FogMaskEnable(false);//call FogMaskEnable(false)
			FogEnable(false);//call FogEnable(false)
			CreateQuestBJ(0, "Game Modes", "Gamemodes are entered by the red player in the first 20 seconds of game time.A gamemode consists of a dash followed by two characters and a number:The first character determines the race distribution.|cffFFFF00p :|r pick race|cffFFFF00d :|r draft race|cffFFFF00r :|r random race|cffFFFF00m :|r mirror mode (random)The second character determines how long races are kept:|cffFFFF00g :|r The race is determined in round one and then |cffFFFF80kept for the whole game|r|cffFFFF00r :|r The race is determined before |cffFFFF80EACH round|rThe 3rd character is a number between |cffFFFF001|r and |cffFFFF006|r determining the number of wins for overall victory|cffFFFF00Examples:|r-|cffFF0000r|cff00FF00r|cffFFFF002|r would start a |cffFF0000RANDOM|r race |cff00FF00EACH ROUND|r game with |cffFFFF002 wins|r for overall victory-|cffFF0000p|cff00FF00g|cffFFFF004|r would start a |cffFF0000PICK|r race |cff00FF00ONCE FOR WHOLE GAME|r game with |cffFFFF004 wins|r for overall victory", "ReplaceableTextures\\CommandButtons\\BTNPickUpItem.blp");//call CreateQuestBJ(0,"Game Modes","Gamemodes are entered by the red player in the first 20 seconds of game time.A gamemode consists of a dash followed by two characters and a number:The first character determines the race distribution.|cffFFFF00p :|r pick race|cffFFFF00d :|r draft race|cffFFFF00r :|r random race|cffFFFF00m :|r mirror mode (random)The second character determines how long races are kept:|cffFFFF00g :|r The race is determined in round one and then |cffFFFF80kept for the whole game|r|cffFFFF00r :|r The race is determined before |cffFFFF80EACH round|rThe 3rd character is a number between |cffFFFF001|r and |cffFFFF006|r determining the number of wins for overall victory|cffFFFF00Examples:|r-|cffFF0000r|cff00FF00r|cffFFFF002|r would start a |cffFF0000RANDOM|r race |cff00FF00EACH ROUND|r game with |cffFFFF002 wins|r for overall victory-|cffFF0000p|cff00FF00g|cffFFFF004|r would start a |cffFF0000PICK|r race |cff00FF00ONCE FOR WHOLE GAME|r game with |cffFFFF004 wins|r for overall victory","ReplaceableTextures\\CommandButtons\\BTNPickUpItem.blp")
			CreateQuestBJ(0, "Modifications", "TRIGSTR_005", "ReplaceableTextures\\CommandButtons\\BTNSpy.blp");//call CreateQuestBJ(0,"Modifications","TRIGSTR_005","ReplaceableTextures\\CommandButtons\\BTNSpy.blp")
			CreateQuestBJ(0, "Other Commands", "TRIGSTR_006", "ReplaceableTextures\\CommandButtons\\BTNAuraOfDarkness.blp");//call CreateQuestBJ(0,"Other Commands","TRIGSTR_006","ReplaceableTextures\\CommandButtons\\BTNAuraOfDarkness.blp")
			CreateQuestBJ(2, "First Match?", "|cffFFFF80This is your very first match of Castle Fight?|rWell, no problem, this game is very easy (even if playing with real good strategy can be very difficult). Just pick a worker and start building. Listen to your teammates, you will learn fast.Read the basic hints in this questlog and when you have played a couple of games and want even more information and tactics about this game, visit |cffFFFF80castle-fight.net.ru|r for a detailed documentation.|cffFF0000Note that the game has more than one round, so please don't leave if your castle is about to fall. Another round may come after this one and you ruin the game by leaving after round 1.|rGood luck and have fun!", "ReplaceableTextures\\CommandButtons\\BTNSelectHeroOff.blp");//call CreateQuestBJ(2,"First Match?","|cffFFFF80This is your very first match of Castle Fight?|rWell, no problem, this game is very easy (even if playing with real good strategy can be very difficult). Just pick a worker and start building. Listen to your teammates, you will learn fast.Read the basic hints in this questlog and when you have played a couple of games and want even more information and tactics about this game, visit |cffFFFF80castle-fight.net.ru|r for a detailed documentation.|cffFF0000Note that the game has more than one round, so please don't leave if your castle is about to fall. Another round may come after this one and you ruin the game by leaving after round 1.|rGood luck and have fun!","ReplaceableTextures\\CommandButtons\\BTNSelectHeroOff.blp")
			CreateQuestBJ(2, "Basic Hints", "TRIGSTR_010", "ReplaceableTextures\\CommandButtons\\BTNMilitia.blp");//call CreateQuestBJ(2,"Basic Hints","TRIGSTR_010","ReplaceableTextures\\CommandButtons\\BTNMilitia.blp")
			CreateQuestBJ(2, "About", "TRIGSTR_011", "ReplaceableTextures\\CommandButtons\\BTNTomeOfRetraining.blp");//call CreateQuestBJ(2,"About","TRIGSTR_011","ReplaceableTextures\\CommandButtons\\BTNTomeOfRetraining.blp")
		}//endfunction
		private void Vs(int Aj, int bj, float Ws) {//function Vs takes integer Aj,integer bj,real Ws returns nothing
			int at;//local integer at
			float Xs = Ws;//local real Xs=Ws
			float Ys = .5*Ws;//local real Ys=.5*Ws
			if ((ye[Aj]>0)) {//if(ye[Aj]>0)then
				at = bj+4;//set at=bj+4
				Ae[at] = Ae[at]+(Ys);//set Ae[at]=Ae[at]+(Ys)
			}//endif
			at = xe[Aj];//set at=xe[Aj]
			if ((at==1)) {//if(at==1)then
				Ae[bj+1] = Ae[bj+1]+(Xs);//set Ae[bj+1]=Ae[bj+1]+(Xs)
				Ae[bj+2] = Ae[bj+2]+(Ys);//set Ae[bj+2]=Ae[bj+2]+(Ys)
			} else if ((at==2)) {//elseif(at==2)then
				Ae[bj+2] = Ae[bj+2]+(Xs);//set Ae[bj+2]=Ae[bj+2]+(Xs)
				Ae[bj+3] = Ae[bj+3]+(Ys);//set Ae[bj+3]=Ae[bj+3]+(Ys)
			} else if ((at==3)) {//elseif(at==3)then
				Ae[bj+3] = Ae[bj+3]+(Xs);//set Ae[bj+3]=Ae[bj+3]+(Xs)
				Ae[bj+1] = Ae[bj+1]+(Ys);//set Ae[bj+1]=Ae[bj+1]+(Ys)
			} else if ((at==4)) {//elseif(at==4)then
				Ae[bj+4] = Ae[bj+4]+(Xs);//set Ae[bj+4]=Ae[bj+4]+(Xs)
				if ((ye[Aj]<2)) {//if(ye[Aj]<2)then
					Ae[bj+1] = Ae[bj+1]+(Ys);//set Ae[bj+1]=Ae[bj+1]+(Ys)
					Ae[bj+2] = Ae[bj+2]+(Ys);//set Ae[bj+2]=Ae[bj+2]+(Ys)
					Ae[bj+3] = Ae[bj+3]+(Ys);//set Ae[bj+3]=Ae[bj+3]+(Ys)
				}//endif
			} else if ((at==6)) {//elseif(at==6)then
				Ae[bj+6] = Ae[bj+6]+(Xs*1.5);//set Ae[bj+6]=Ae[bj+6]+(Xs*1.5)
				Ae[bj+1] = Ae[bj+1]+(Ys);//set Ae[bj+1]=Ae[bj+1]+(Ys)
				Ae[bj+2] = Ae[bj+2]+(Ys);//set Ae[bj+2]=Ae[bj+2]+(Ys)
				Ae[bj+3] = Ae[bj+3]+(Ys);//set Ae[bj+3]=Ae[bj+3]+(Ys)
			} else if ((at==5)) {//elseif(at==5)then
				Ae[bj+5] = Ae[bj+5]+(Xs);//set Ae[bj+5]=Ae[bj+5]+(Xs)
			}//endif
			Ae[bj+5] = Ae[bj+5]+(Ys);//set Ae[bj+5]=Ae[bj+5]+(Ys)
		}//endfunction
		private void Zs() {//function Zs takes nothing returns nothing
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			int id = GetUnitPointValue(u);//local integer id=GetUnitPointValue(u)
			float d = t4[id];//local real d=t4[id]
			int r = ve[id];//local integer r=ve[id]
			int a = id*7;//local integer a=id*7
			int z = 7*me[GetPlayerId(GetOwningPlayer(u))];//local integer z=7*me[GetPlayerId(GetOwningPlayer(u))]
			if ((r>0)) {//if(r>0)then
				r = r+(z);//set r=r+(z)
				ue[r] = ue[r]+(d);//set ue[r]=ue[r]+(d)
				Vs(id, z, d*.8);//call Vs(id,z,d*.8)
			}//endif
			u = null;//set u=null
		}//endfunction
		private bool dt(unit Jm, int to) {//function dt takes unit Jm,integer to returns boolean
			player p = GetOwningPlayer(Jm);//local player p=GetOwningPlayer(Jm)
			SetUnitOwner(Jm, Player($F), false);//call SetUnitOwner(Jm,Player($F),false)
			SetUnitOwner(Jm, p, false);//call SetUnitOwner(Jm,p,false)
			return IssueImmediateOrderById(Jm,to);//return IssueImmediateOrderById(Jm,to)
		}//endfunction
		private void et() {//function et takes nothing returns nothing
			if ((GetExpiredTimer()==ce[0])) {//if(GetExpiredTimer()==ce[0])then
				De[0] = true;//set De[0]=true
			} else {//else
				De[1] = true;//set De[1]=true
			}//endif
		}//endfunction
		private bool ft(int dk) {//function ft takes integer dk returns boolean
			if ((GetUnitAbilityLevel(ae[dk],808468775)<=0)) {//if(GetUnitAbilityLevel(ae[dk],'A005')<=0)then
				Ee[me[dk]] = Player($E);//set Ee[me[dk]]=Player($E)
				ForceRemovePlayer(Ce[me[dk]], Player(dk));//call ForceRemovePlayer(Ce[me[dk]],Player(dk))
			} else {//else
				De[me[dk]] = false;//set De[me[dk]]=false
				Ee[me[dk]] = Player(dk);//set Ee[me[dk]]=Player(dk)
				TimerStart(ce[me[dk]], 10., false, function et);//call TimerStart(ce[me[dk]],10.,false,function et)
				return Si(ae[dk],be[me[dk]]);//return Si(ae[dk],be[me[dk]])
			}//endif
			return false;//return false
		}//endfunction
		private void gt() {//function gt takes nothing returns nothing
			int ht = 0;//local integer ht=0
			int ai;//local integer ai
			int bi;//local integer bi
			float d1;//local real d1
			float d2;//local real d2
			float t;//local real t
			int i;//local integer i
			while (true) {//loop
				ai = 7*ht+1;//set ai=7*ht+1
				bi = 7*ModuloInteger(ht+1,2)+1;//set bi=7*ModuloInteger(ht+1,2)+1
				d1 = ue[bi+6]-Ae[ai+6];//set d1=ue[bi+6]-Ae[ai+6]
				d2 = d1;//set d2=d1
				i = 1;//set i=1
				Ie[ht*2] = 6;//set Ie[ht*2]=6
				Ie[ht*2+1] = 6;//set Ie[ht*2+1]=6
				while (true) {//loop
					t = ue[bi]-Ae[ai];//set t=ue[bi]-Ae[ai]
					if ((t>d1 && ue[bi]>Ae[ai])) {//if(t>d1 and ue[bi]>Ae[ai])then
						d1 = t;//set d1=t
						Ie[ht*2] = i;//set Ie[ht*2]=i
					} else if ((t<d2)) {//elseif(t<d2)then
						d2 = t;//set d2=t
						Ie[ht*2+1] = i;//set Ie[ht*2+1]=i
					}//endif
					ai = ai+1;//set ai=ai+1
					bi = bi+1;//set bi=bi+1
					i = i+1;//set i=i+1
					if (i>=He) { break; }//exitwhen i>=He
				}//endloop
				ht = ht+1;//set ht=ht+1
				if (ht>=2) { break; }//exitwhen ht>=2
			}//endloop
		}//endfunction
		private bool jt() {//function jt takes nothing returns boolean
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			int ht;//local integer ht
			player p;//local player p
			if ((IsUnitType(u,UNIT_TYPE_STRUCTURE))) {//if(IsUnitType(u,UNIT_TYPE_STRUCTURE))then
				r4 = GetOwningPlayer(u);//set r4=GetOwningPlayer(u)
				ht = me[GetPlayerId(r4)];//set ht=me[GetPlayerId(r4)]
				be[ht] = u;//set be[ht]=u
				GroupEnumUnitsInRange(q4, GetUnitX(u), GetUnitY(u), 1590.1, y9);//call GroupEnumUnitsInRange(q4,GetUnitX(u),GetUnitY(u),1590.1,y9)
				p = vn(Ce[ht]);//set p=vn(Ce[ht])
				if ((p!=null  && (GetWidgetLife(u)/ GetUnitState(u,UNIT_STATE_MAX_LIFE)*100.<40.4 || CountUnitsInGroup(q4)>=16) && (De[ht]or Ee[ht]==p))) {//if(p!=null and(GetWidgetLife(u)/ GetUnitState(u,UNIT_STATE_MAX_LIFE)*100.<40.4 or CountUnitsInGroup(q4)>=16)and(De[ht]or Ee[ht]==p))then
					Sj("AI", "STRIKE_ORDER_TARGET", GetPlayerName(p));//call Sj("AI","STRIKE_ORDER_TARGET",GetPlayerName(p))
					ft(GetPlayerId(p));//call ft(GetPlayerId(p))
				}//endif
			}//endif
			u = null;//set u=null
			return false;//return false
		}//endfunction
		private bool kt() {//function kt takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			float r = GetWidgetLife(u);//local real r=GetWidgetLife(u)
			bool Im = r>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_STRUCTURE) && GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>50.;//local boolean Im=r>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_STRUCTURE)and GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>50.
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private int mt(int nt, int ot, int pt, int qt) {//function mt takes integer nt,integer ot,integer pt,integer qt returns integer
			int v = qi();//local integer v=qi()
			int i = 0;//local integer i=0
			Ph[Qh[v]] = nt;//set Ph[Qh[v]]=nt
			Ph[Qh[v]+1] = ot;//set Ph[Qh[v]+1]=ot
			Ph[Qh[v]+2] = pt;//set Ph[Qh[v]+2]=pt
			Ph[Qh[v]+3] = qt;//set Ph[Qh[v]+3]=qt
			while (true) {//loop
				if ((Ph[Qh[v]+i]!=0)) {//if(Ph[Qh[v]+i]!=0)then
					Rh[v] = i;//set Rh[v]=i
				}//endif
				i = i+1;//set i=i+1
				if (i>=4) { break; }//exitwhen i>=4
			}//endloop
			return v;//return v
		}//endfunction
		private void rt(int oi, unit bm) {//function rt takes integer oi,unit bm returns nothing
			int i = Rh[oi]-1;//local integer i=Rh[oi]-1
			int st = $A;//local integer st=$A
			unit tt;//local unit tt
			r4 = GetOwningPlayer(bm);//set r4=GetOwningPlayer(bm)
			while (true) {//loop
				if ((i<0)) {//if(i<0)then
					bj_groupEnumTypeId = Ph[Qh[oi]];//set bj_groupEnumTypeId=Ph[Qh[oi]]
					if ((GetPlayerState(r4,PLAYER_STATE_RESOURCE_GOLD)>t4[GetUnitPointValueByType(bj_groupEnumTypeId)])) {//if(GetPlayerState(r4,PLAYER_STATE_RESOURCE_GOLD)>t4[GetUnitPointValueByType(bj_groupEnumTypeId)])then
						i = te[GetPlayerId(r4)];//set i=te[GetPlayerId(r4)]
						while (true) {//loop
							Oi(i);//call Oi(i)
							if (IssueBuildOrderById(bm,bj_groupEnumTypeId,A,B) || st<0) { break; }//exitwhen IssueBuildOrderById(bm,bj_groupEnumTypeId,A,B)or st<0
							st = st-1;//set st=st-1
							Qi(i);//call Qi(i)
						}//endloop
					}//endif
					if (true) { break; }//exitwhen true
				} else {//else
					bj_groupEnumTypeId = Ph[Qh[oi]+i];//set bj_groupEnumTypeId=Ph[Qh[oi]+i]
					GroupEnumUnitsOfPlayer(q4, r4, filterGetUnitsOfPlayerAndTypeId);//call GroupEnumUnitsOfPlayer(q4,r4,filterGetUnitsOfPlayerAndTypeId)
					tt = FirstOfGroup(q4);//set tt=FirstOfGroup(q4)
					if ((tt==null)) {//if(tt==null)then
						i = i-1;//set i=i-1
					} else {//else
						if ((GetPlayerState(r4,PLAYER_STATE_RESOURCE_GOLD)>t4[GetUnitPointValueByType(Ph[Qh[oi]+i+1])])) {//if(GetPlayerState(r4,PLAYER_STATE_RESOURCE_GOLD)>t4[GetUnitPointValueByType(Ph[Qh[oi]+i+1])])then
							dt(tt, Ph[Qh[oi]+i+1]);//call dt(tt,Ph[Qh[oi]+i+1])
						}//endif
						tt = null;//set tt=null
						if (true) { break; }//exitwhen true
					}//endif
				}//endif
			}//endloop
		}//endfunction
		private void ut(int oi, unit bm) {//function ut takes integer oi,unit bm returns nothing
			rt(oi, bm);//call rt(oi,bm)
			bj_groupEnumTypeId = Ph[Qh[oi]+Rh[oi]];//set bj_groupEnumTypeId=Ph[Qh[oi]+Rh[oi]]
			GroupEnumUnitsOfPlayer(q4, r4, filterGetUnitsOfPlayerAndTypeId);//call GroupEnumUnitsOfPlayer(q4,r4,filterGetUnitsOfPlayerAndTypeId)
			ze[GetPlayerId(r4)] = FirstOfGroup(q4)!=null;//set ze[GetPlayerId(r4)]=FirstOfGroup(q4)!=null
		}//endfunction
		private int vt(int oi) {//function vt takes integer oi returns integer
			return ve[GetUnitPointValueByType(Ph[Qh[oi]+Rh[oi]])];//return ve[GetUnitPointValueByType(Ph[Qh[oi]+Rh[oi]])]
		}//endfunction
		private void wt(int oi, int xt, int yt) {//function wt takes integer oi,integer xt,integer yt returns nothing
			Vh[Wh[oi]+xt*7+Xh[Yh[oi]+xt]] = yt;//set Vh[Wh[oi]+xt*7+Xh[Yh[oi]+xt]]=yt
			Xh[Yh[oi]+xt] = Xh[Yh[oi]+xt]+1;//set Xh[Yh[oi]+xt]=Xh[Yh[oi]+xt]+1
		}//endfunction
		private void zt(int oi, unit bm) {//function zt takes integer oi,unit bm returns nothing
			int i = 0;//local integer i=0
			int At = -1;//local integer At=-1
			int Bt = 2*me[GetPlayerId(GetOwningPlayer(bm))];//local integer Bt=2*me[GetPlayerId(GetOwningPlayer(bm))]
			while (true) {//loop
				if ((vt(Vh[Wh[oi]+Ie[Bt]*7+i])==Ie[Bt+1])) {//if(vt(Vh[Wh[oi]+Ie[Bt]*7+i])==Ie[Bt+1])then
					At = i;//set At=i
				}//endif
				i = i+1;//set i=i+1
				if (i>Xh[Yh[oi]+Ie[Bt]]) { break; }//exitwhen i>Xh[Yh[oi]+Ie[Bt]]
			}//endloop
			if ((At>-1)) {//if(At>-1)then
				rt(Vh[Wh[oi]+Ie[Bt]*7+At], bm);//call rt(Vh[Wh[oi]+Ie[Bt]*7+At],bm)
			} else {//else
				rt(Vh[Wh[oi]+Ie[Bt]*7+GetRandomInt(0, Xh[Yh[oi]+Ie[Bt]])], bm);//call rt(Vh[Wh[oi]+Ie[Bt]*7+GetRandomInt(0,Xh[Yh[oi]+Ie[Bt]])],bm)
			}//endif
		}//endfunction
		private void bt(int oi) {//function bt takes integer oi returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				Xh[Yh[oi]+i] = Xh[Yh[oi]+i]-1;//set Xh[Yh[oi]+i]=Xh[Yh[oi]+i]-1
				i = i+1;//set i=i+1
				if (i>=7) { break; }//exitwhen i>=7
			}//endloop
			ei[fi[oi]] = ei[fi[oi]]-1;//set ei[fi[oi]]=ei[fi[oi]]-1
			ei[fi[oi]+1] = ei[fi[oi]+1]-1;//set ei[fi[oi]+1]=ei[fi[oi]+1]-1
			ei[fi[oi]+2] = ei[fi[oi]+2]-1;//set ei[fi[oi]+2]=ei[fi[oi]+2]-1
			ei[fi[oi]+3] = ei[fi[oi]+3]-1;//set ei[fi[oi]+3]=ei[fi[oi]+3]-1
		}//endfunction
		private void Ct(int oi, int ct, int yt) {//function Ct takes integer oi,integer ct,integer yt returns nothing
			Zh[di[oi]+4*ct+ei[fi[oi]+ct]] = yt;//set Zh[di[oi]+4*ct+ei[fi[oi]+ct]]=yt
			ei[fi[oi]+ct] = ei[fi[oi]+ct]+1;//set ei[fi[oi]+ct]=ei[fi[oi]+ct]+1
		}//endfunction
		private void Dt(int oi, unit bm) {//function Dt takes integer oi,unit bm returns nothing
			int dk = GetPlayerId(GetOwningPlayer(bm));//local integer dk=GetPlayerId(GetOwningPlayer(bm))
			if ((rd  && (!ze[dk]))) {//if(rd and(not ze[dk]))then
				if (((!md) && ei[fi[oi]+3]>=0)) {//if((not md)and ei[fi[oi]+3]>=0)then
					ut(Zh[di[oi]+4*3+GetRandomInt(0, ei[fi[oi]+3])], bm);//call ut(Zh[di[oi]+4*3+GetRandomInt(0,ei[fi[oi]+3])],bm)
				} else if ((ei[fi[oi]]>=0)) {//elseif(ei[fi[oi]]>=0)then
					ut(Zh[di[oi]+4*0+GetRandomInt(0, ei[fi[oi]])], bm);//call ut(Zh[di[oi]+4*0+GetRandomInt(0,ei[fi[oi]])],bm)
				} else {//else
					ze[dk] = true;//set ze[dk]=true
				}//endif
			} else if (((!md) && ei[fi[oi]+1]>=0)) {//elseif((not md)and ei[fi[oi]+1]>=0)then
				rt(Zh[di[oi]+4*1+GetRandomInt(0, ei[fi[oi]+1])], bm);//call rt(Zh[di[oi]+4*1+GetRandomInt(0,ei[fi[oi]+1])],bm)
			} else if ((ei[fi[oi]+2]>=0)) {//elseif(ei[fi[oi]+2]>=0)then
				rt(Zh[di[oi]+4*2+GetRandomInt(0, ei[fi[oi]+2])], bm);//call rt(Zh[di[oi]+4*2+GetRandomInt(0,ei[fi[oi]+2])],bm)
			} else {//else
				zt(oi, bm);//call zt(oi,bm)
			}//endif
		}//endfunction
		private int Et(int aj) {//function Et takes integer aj returns integer
			if ((aj==808478759)) {//if(aj=='h00O')then
				return Je;//return Je
			}//endif
			if ((aj==808482087)) {//if(aj=='u006')then
				return Ke;//return Ke
			}//endif
			if ((aj==808478759)) {//if(aj=='h00C')then
				return Le;//return Le
			}//endif
			if ((aj==825255975)) {//if(aj=='h019')then
				return Me;//return Me
			}//endif
			if ((aj==808478759)) {//if(aj=='h00E')then
				return Ne;//return Ne
			}//endif
			if ((aj==825255975)) {//if(aj=='h017')then
				return Oe;//return Oe
			}//endif
			if ((aj==942696487)) {//if(aj=='h089')then
				return Pe;//return Pe
			}//endif
			if ((aj==808478759)) {//if(aj=='h00P')then
				return Qe;//return Qe
			}//endif
			if ((aj==825255975)) {//if(aj=='h018')then
				return Re;//return Re
			}//endif
			if ((aj==909142055)) {//if(aj=='h06P')then
				return Se;//return Se
			}//endif
			if ((aj==825255975)) {//if(aj=='h01A')then
				return Te;//return Te
			}//endif
			if ((aj==892364839)) {//if(aj=='h051')then
				return Ue;//return Ue
			}//endif
			return -1;//return-1
		}//endfunction
		private void Ft() {//function Ft takes nothing returns nothing
			int i = 0;//local integer i=0
			if ((Fe)) {//if(Fe)then
				return;//return
			}//endif
			while (true) {//loop
				if ((Be[i]and ae[i]!=null && GetWidgetLife(ae[i])>.405)) {//if(Be[i]and ae[i]!=null and GetWidgetLife(ae[i])>.405)then
					if ((be[me[i]]==null)) {//if(be[me[i]]==null)then
						if ((GetUnitCurrentOrder(ae[i])==0)) {//if(GetUnitCurrentOrder(ae[i])==0)then
							IssuePointOrderByIdLoc(ae[i], $D022D, Qd[i]);//call IssuePointOrderByIdLoc(ae[i],$D022D,Qd[i])
						}//endif
					} else if ((GetWidgetLife(be[me[i]])>.405 && GetUnitState(be[me[i]],UNIT_STATE_MAX_LIFE)-GetWidgetLife(be[me[i]])>50.)) {//elseif(GetWidgetLife(be[me[i]])>.405 and GetUnitState(be[me[i]],UNIT_STATE_MAX_LIFE)-GetWidgetLife(be[me[i]])>50.)then
						IssueTargetOrderById(ae[i], $D0038, be[me[i]]);//call IssueTargetOrderById(ae[i],$D0038,be[me[i]])
					} else {//else
						r4 = Player(i);//set r4=Player(i)
						GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, le);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,le)
						bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
						bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
						ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
						be[me[i]] = bj_groupRandomCurrentPick;//set be[me[i]]=bj_groupRandomCurrentPick
					}//endif
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void Gt() {//function Gt takes nothing returns nothing
			int i = 0;//local integer i=0
			int t;//local integer t
			if ((Fe)) {//if(Fe)then
				return;//return
			}//endif
			gt();//call gt()
			while (true) {//loop
				if ((Be[i])) {//if(Be[i])then
					r4 = Player(i);//set r4=Player(i)
					if ((ae[i]==null || GetWidgetLife(ae[i])<=.405)) {//if(ae[i]==null or GetWidgetLife(ae[i])<=.405)then
						GroupEnumUnitsOfPlayer(q4, r4, b9);//call GroupEnumUnitsOfPlayer(q4,r4,b9)
						ae[i] = FirstOfGroup(q4);//set ae[i]=FirstOfGroup(q4)
						if ((ae[i]!=null)) {//if(ae[i]!=null)then
							Ve[i] = Et(GetUnitTypeId(ae[i]));//set Ve[i]=Et(GetUnitTypeId(ae[i]))
							if ((GetUnitAbilityLevel(ae[i],808468775)>0)) {//if(GetUnitAbilityLevel(ae[i],'A005')>0)then
								ForceAddPlayer(Ce[me[i]], r4);//call ForceAddPlayer(Ce[me[i]],r4)
								Sj("AI", "MainOrdererRegistratorStrikeStack", GetPlayerName(r4));//call Sj("AI","MainOrdererRegistratorStrikeStack",GetPlayerName(r4))
							}//endif
						}//endif
					} else {//else
						t = GetPlayerState(Player(i),PLAYER_STATE_RESOURCE_LUMBER);//set t=GetPlayerState(Player(i),PLAYER_STATE_RESOURCE_LUMBER)
						if ((t<$7D0 || t>$BB8 || GetPlayerState(r4,PLAYER_STATE_RESOURCE_GOLD)>=$3E8)) {//if(t<$7D0 or t>$BB8 or GetPlayerState(r4,PLAYER_STATE_RESOURCE_GOLD)>=$3E8)then
							zt(Ve[i], ae[i]);//call zt(Ve[i],ae[i])
						} else {//else
							Dt(Ve[i], ae[i]);//call Dt(Ve[i],ae[i])
						}//endif
					}//endif
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void AILibrary_PrepareAI() {//function AILibrary_PrepareAI takes nothing returns nothing
			ExecuteFunc("Ht");//call ExecuteFunc("Ht")
		}//endfunction
		private void AILibrary_ResetBuildPlaces() {//function AILibrary_ResetBuildPlaces takes nothing returns nothing
			int i = 0;//local integer i=0
			if ((!Ge)) {//if(not Ge)then
				return;//return
			}//endif
			while (true) {//loop
				if ((Be[i])) {//if(Be[i])then
					if ((IsPlayerInForce(Player(i),ie))) {//if(IsPlayerInForce(Player(i),ie))then
						te[i] = ModuloInteger(i,2)+2;//set te[i]=ModuloInteger(i,2)+2
					} else if ((IsPlayerInForce(Player(i),je))) {//elseif(IsPlayerInForce(Player(i),je))then
						te[i] = ModuloInteger(i,2);//set te[i]=ModuloInteger(i,2)
					}//endif
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void It(int dk) {//function It takes integer dk returns nothing
			string s;//local string s
			ExecuteFunc("Ht");//call ExecuteFunc("Ht")
			if ((IsPlayerInForce(Player(dk),ie))) {//if(IsPlayerInForce(Player(dk),ie))then
				te[dk] = ModuloInteger(dk,2)+2;//set te[dk]=ModuloInteger(dk,2)+2
			} else if ((IsPlayerInForce(Player(dk),je))) {//elseif(IsPlayerInForce(Player(dk),je))then
				te[dk] = ModuloInteger(dk,2);//set te[dk]=ModuloInteger(dk,2)
			}//endif
			s = Ki();//set s=Ki()
			SetPlayerName(Player(dk), s);//call SetPlayerName(Player(dk),s)
			l9[dk] = s;//set l9[dk]=s
			Ls(dk);//call Ls(dk)
			Be[dk] = true;//set Be[dk]=true
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" joined to game with AI savvy!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" joined to game with AI savvy!")
		}//endfunction
		private bool lt(int dk) {//function lt takes integer dk returns boolean
			if ((!Be[dk])) {//if(not Be[dk])then
				return false;//return false
			}//endif
			Be[dk] = false;//set Be[dk]=false
			ForceRemovePlayer(Ce[me[dk]], Player(dk));//call ForceRemovePlayer(Ce[me[dk]],Player(dk))
			return true;//return true
		}//endfunction
		private void Jt() {//function Jt takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((qe[i])) {//if(qe[i])then
					DisplayTextToPlayer(Player(i), .0, .0, "|cffCA0000WARNING|r: AI took control over your units! Type -afk to disable AI.");//call DisplayTextToPlayer(Player(i),.0,.0,"|cffCA0000WARNING|r: AI took control over your units! Type -afk to disable AI.")
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void Kt(int dk) {//function Kt takes integer dk returns nothing
			if ((qe[dk])) {//if(qe[dk])then
				qe[dk] = false;//set qe[dk]=false
				lt(dk);//call lt(dk)
				SetPlayerName(Player(dk), l9[dk]);//call SetPlayerName(Player(dk),l9[dk])
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+"|cffCA0000 is no longer AFK!|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+"|cffCA0000 is no longer AFK!|r")
				re = re-1;//set re=re-1
				if ((re==0)) {//if(re==0)then
					PauseTimer(se);//call PauseTimer(se)
					DestroyTimer(se);//call DestroyTimer(se)
					se = null;//set se=null
				}//endif
			} else {//else
				qe[dk] = true;//set qe[dk]=true
				Gd[dk] = true;//set Gd[dk]=true
				ExecuteFunc("Ht");//call ExecuteFunc("Ht")
				if ((IsPlayerInForce(Player(dk),ie))) {//if(IsPlayerInForce(Player(dk),ie))then
					te[dk] = ModuloInteger(dk,2)+2;//set te[dk]=ModuloInteger(dk,2)+2
				} else if ((IsPlayerInForce(Player(dk),je))) {//elseif(IsPlayerInForce(Player(dk),je))then
					te[dk] = ModuloInteger(dk,2);//set te[dk]=ModuloInteger(dk,2)
				}//endif
				SetPlayerName(Player(dk), "[AFK] "+l9[dk]);//call SetPlayerName(Player(dk),"[AFK] "+l9[dk])
				Be[dk] = true;//set Be[dk]=true
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+"|cffCA0000 is AFK!|r AI took control over his units.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+"|cffCA0000 is AFK!|r AI took control over his units.")
				if ((re==0)) {//if(re==0)then
					se = CreateTimer();//set se=CreateTimer()
					TimerStart(se, 5., true, function Jt);//call TimerStart(se,5.,true,function Jt)
				}//endif
				re = re+1;//set re=re+1
			}//endif
		}//endfunction
		private void Lt() {//function Lt takes nothing returns nothing
			int i = 0;//local integer i=0
			bool b = false;//local boolean b=false
			while (true) {//loop
				if ((GetPlayerController(Player(i))==MAP_CONTROL_COMPUTER)) {//if(GetPlayerController(Player(i))==MAP_CONTROL_COMPUTER)then
					It(i);//call It(i)
					b = true;//set b=true
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			if ((b)) {//if(b)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "AI functionality damaged: you are playing with computer slots.In future use command -fill.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"AI functionality damaged: you are playing with computer slots.In future use command -fill.")
			}//endif
		}//endfunction
		private void Mt() {//function Mt takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				ue[i] = 0;//set ue[i]=0
				Ae[i] = 0;//set Ae[i]=0
				i = i+1;//set i=i+1
				if (i>7*2) { break; }//exitwhen i>7*2
			}//endloop
			i = 0;//set i=0
			while (true) {//loop
				ze[i] = false;//set ze[i]=false
				if (i>$B) { break; }//exitwhen i>$B
				i = i+1;//set i=i+1
			}//endloop
			Mi();//call Mi()
			ForceClear(Ce[0]);//call ForceClear(Ce[0])
			ForceClear(Ce[1]);//call ForceClear(Ce[1])
			PauseTimer(ce[0]);//call PauseTimer(ce[0])
			PauseTimer(ce[1]);//call PauseTimer(ce[1])
			De[0] = true;//set De[0]=true
			De[1] = true;//set De[1]=true
			Ee[0] = Player($E);//set Ee[0]=Player($E)
			Ee[1] = Player($E);//set Ee[1]=Player($E)
			Fe = false;//set Fe=false
		}//endfunction
		private void AILibrary_Sleep() {//function AILibrary_Sleep takes nothing returns nothing
			Fe = true;//set Fe=true
		}//endfunction
		private void Ht() {//function Ht takes nothing returns nothing
			int i;//local integer i
			trigger t;//local trigger t
			int Nt;//local integer Nt
			int Ot;//local integer Ot
			int Pt;//local integer Pt
			int Qt;//local integer Qt
			int Rt;//local integer Rt
			int St;//local integer St
			int Tt;//local integer Tt
			int Ut;//local integer Ut
			int Vt;//local integer Vt
			int Wt;//local integer Wt
			int Xt;//local integer Xt
			int Yt;//local integer Yt
			int Zt;//local integer Zt
			int du;//local integer du
			int eu;//local integer eu
			int fu;//local integer fu
			int gu;//local integer gu
			int hu;//local integer hu
			int iu;//local integer iu
			int ju;//local integer ju
			int ku;//local integer ku
			int mu;//local integer mu
			int nu;//local integer nu
			int ou;//local integer ou
			int pu;//local integer pu
			int qu;//local integer qu
			int ru;//local integer ru
			int su;//local integer su
			int tu;//local integer tu
			int uu;//local integer uu
			int vu;//local integer vu
			int wu;//local integer wu
			int xu;//local integer xu
			int yu;//local integer yu
			int zu;//local integer zu
			int Au;//local integer Au
			int au;//local integer au
			int Bu;//local integer Bu
			int bu;//local integer bu
			int Cu;//local integer Cu
			int cu;//local integer cu
			int Du;//local integer Du
			int Eu;//local integer Eu
			int Fu;//local integer Fu
			int Gu;//local integer Gu
			if ((Ge)) {//if(Ge)then
				return;//return
			}//endif
			Li();//call Li()
			Mi();//call Mi()
			le = Filter(function kt);//set le=Filter(function kt)
			TimerStart(CreateTimer(), 2., true, function Gt);//call TimerStart(CreateTimer(),2.,true,function Gt)
			TimerStart(CreateTimer(), 5., true, function Ft);//call TimerStart(CreateTimer(),5.,true,function Ft)
			t = CreateTrigger();//set t=CreateTrigger()
			TriggerAddAction(t, function Zs);//call TriggerAddAction(t,function Zs)
			TriggerRegisterAnyUnitEventBJ(t, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH);//call TriggerRegisterAnyUnitEventBJ(t,EVENT_PLAYER_UNIT_CONSTRUCT_FINISH)
			TriggerRegisterAnyUnitEventBJ(t, EVENT_PLAYER_UNIT_UPGRADE_FINISH);//call TriggerRegisterAnyUnitEventBJ(t,EVENT_PLAYER_UNIT_UPGRADE_FINISH)
			t = CreateTrigger();//set t=CreateTrigger()
			TriggerAddCondition(t, Condition(function jt));//call TriggerAddCondition(t,Condition(function jt))
			TriggerRegisterAnyUnitEventBJ(t, EVENT_PLAYER_UNIT_ATTACKED);//call TriggerRegisterAnyUnitEventBJ(t,EVENT_PLAYER_UNIT_ATTACKED)
			t = null;//set t=null
			Ce[0] = CreateForce();//set Ce[0]=CreateForce()
			Ce[1] = CreateForce();//set Ce[1]=CreateForce()
			ce[0] = CreateTimer();//set ce[0]=CreateTimer()
			ce[1] = CreateTimer();//set ce[1]=CreateTimer()
			De[0] = true;//set De[0]=true
			De[1] = true;//set De[1]=true
			Ee[0] = Player($E);//set Ee[0]=Player($E)
			Ee[1] = Player($E);//set Ee[1]=Player($E)
			Je = pi();//set Je=pi()
			Nt = mt(842033191,0,0,0);//set Nt=mt('h025',0,0,0)
			Ot = mt(808478759,0,0,0);//set Ot=mt('h009',0,0,0)
			Pt = mt(808478759,0,0,0);//set Pt=mt('h007',0,0,0)
			Qt = mt(825255975,0,0,0);//set Qt=mt('h01C',0,0,0)
			wt(Je, 2, mt('h01I', 'h026', 0, 0));//call wt(Je,2,mt('h01I','h026',0,0))
			wt(Je, 2, mt('h01D', 'h03G', 0, 0));//call wt(Je,2,mt('h01D','h03G',0,0))
			wt(Je, 3, Qt);//call wt(Je,3,Qt)
			wt(Je, 6, Nt);//call wt(Je,6,Nt)
			wt(Je, 6, Ot);//call wt(Je,6,Ot)
			wt(Je, 6, Pt);//call wt(Je,6,Pt)
			wt(Je, 1, Nt);//call wt(Je,1,Nt)
			wt(Je, 1, Qt);//call wt(Je,1,Qt)
			wt(Je, 4, Pt);//call wt(Je,4,Pt)
			wt(Je, 5, Ot);//call wt(Je,5,Ot)
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h025')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h009')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h007')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01C')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01I')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 2;//set xe[i]=2
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h026')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 2;//set xe[i]=2
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01D')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03G')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			Ct(Je, 0, mt('h01M', 'h01W', 'h01X', 0));//call Ct(Je,0,mt('h01M','h01W','h01X',0))
			Ct(Je, 3, mt('h01E', 0, 0, 0));//call Ct(Je,3,mt('h01E',0,0,0))
			Ct(Je, 2, mt('h01F', 0, 0, 0));//call Ct(Je,2,mt('h01F',0,0,0))
			bt(Je);//call bt(Je)
			Le = pi();//set Le=pi()
			Rt = mt(808478759,858810407,0,0);//set Rt=mt('h000','h039',0,0)
			St = mt(808478759,892364839,0,0);//set St=mt('h003','h05D',0,0)
			Tt = mt(858810407,858810407,0,0);//set Tt=mt('h037','h038',0,0)
			Ut = mt(825255975,0,0,0);//set Ut=mt('h015',0,0,0)
			wt(Le, 1, St);//call wt(Le,1,St)
			wt(Le, 2, Rt);//call wt(Le,2,Rt)
			wt(Le, 2, St);//call wt(Le,2,St)
			wt(Le, 2, Tt);//call wt(Le,2,Tt)
			wt(Le, 3, Tt);//call wt(Le,3,Tt)
			wt(Le, 3, Ut);//call wt(Le,3,Ut)
			wt(Le, 4, mt('h003', 'h0A1', 0, 0));//call wt(Le,4,mt('h003','h0A1',0,0))
			wt(Le, 5, mt('h004', 0, 0, 0));//call wt(Le,5,mt('h004',0,0,0))
			wt(Le, 5, Ut);//call wt(Le,5,Ut)
			wt(Le, 6, Tt);//call wt(Le,6,Tt)
			wt(Le, 6, mt('h00K', 0, 0, 0));//call wt(Le,6,mt('h00K',0,0,0))
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h000')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h039')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h003')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h05D')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(1093691431);//set i=GetUnitPointValueByType('h0A1')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 2;//set ye[i]=2
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h004')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 5;//set xe[i]=5
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h015')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h037')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h038')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00K')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			Ct(Le, 0, mt('h05G', 0, 0, 0));//call Ct(Le,0,mt('h05G',0,0,0))
			Ct(Le, 1, mt('h001', 0, 0, 0));//call Ct(Le,1,mt('h001',0,0,0))
			bt(Le);//call bt(Le)
			Ke = pi();//set Ke=pi()
			Vt = mt(875587623,875587623,0,0);//set Vt=mt('h04L','h04N',0,0)
			Wt = mt(875587623,875587623,0,0);//set Wt=mt('h04O','h04M',0,0)
			Xt = mt(875587623,875587623,0,0);//set Xt=mt('h04Q','h04P',0,0)
			Yt = mt(875587623,0,0,0);//set Yt=mt('h04U',0,0,0)
			wt(Ke, 1, mt('h04S', 0, 0, 0));//call wt(Ke,1,mt('h04S',0,0,0))
			wt(Ke, 2, mt('h04V', 'h04W', 0, 0));//call wt(Ke,2,mt('h04V','h04W',0,0))
			wt(Ke, 3, Vt);//call wt(Ke,3,Vt)
			wt(Ke, 3, Wt);//call wt(Ke,3,Wt)
			wt(Ke, 3, Xt);//call wt(Ke,3,Xt)
			wt(Ke, 4, Vt);//call wt(Ke,4,Vt)
			wt(Ke, 4, Yt);//call wt(Ke,4,Yt)
			wt(Ke, 5, Xt);//call wt(Ke,5,Xt)
			wt(Ke, 5, Wt);//call wt(Ke,5,Wt)
			wt(Ke, 6, Yt);//call wt(Ke,6,Yt)
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04S')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04V')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04W')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(959473703);//set i=GetUnitPointValueByType('h09Y')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04L')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04N')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04O')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04M')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04Q')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 5;//set xe[i]=5
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04P')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 5;//set xe[i]=5
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04U')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			Ct(Ke, 0, mt('h04T', 0, 0, 0));//call Ct(Ke,0,mt('h04T',0,0,0))
			Ct(Ke, 0, mt('h04V', 'h04W', 'h09Y', 0));//call Ct(Ke,0,mt('h04V','h04W','h09Y',0))
			Ct(Ke, 2, mt('h04K', 0, 0, 0));//call Ct(Ke,2,mt('h04K',0,0,0))
			Ct(Ke, 2, mt('h04R', 0, 0, 0));//call Ct(Ke,2,mt('h04R',0,0,0))
			bt(Ke);//call bt(Ke)
			Me = pi();//set Me=pi()
			Zt = mt(842033191,842033191,858810407,0);//set Zt=mt('h029','h02U','h031',0)
			du = mt(842033191,892364839,0,0);//set du=mt('h02H','h05E',0,0)
			eu = mt(842033191,0,0,0);//set eu=mt('h02I',0,0,0)
			fu = mt(842033191,0,0,0);//set fu=mt('h02B',0,0,0)
			wt(Me, 1, mt('h02K', 'h092', 0, 0));//call wt(Me,1,mt('h02K','h092',0,0))
			wt(Me, 1, mt('h02K', 'h035', 0, 0));//call wt(Me,1,mt('h02K','h035',0,0))
			wt(Me, 1, mt('h02K', 'h036', 0, 0));//call wt(Me,1,mt('h02K','h036',0,0))
			wt(Me, 1, mt('h02P', 0, 0, 0));//call wt(Me,1,mt('h02P',0,0,0))
			wt(Me, 2, Zt);//call wt(Me,2,Zt)
			wt(Me, 2, du);//call wt(Me,2,du)
			wt(Me, 3, Zt);//call wt(Me,3,Zt)
			wt(Me, 3, fu);//call wt(Me,3,fu)
			wt(Me, 4, du);//call wt(Me,4,du)
			wt(Me, 5, eu);//call wt(Me,5,eu)
			wt(Me, 6, Zt);//call wt(Me,6,Zt)
			wt(Me, 6, eu);//call wt(Me,6,eu)
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h02K')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(959473703);//set i=GetUnitPointValueByType('h092')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h035')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h036')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h02P')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h029')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h02U')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h031')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h02H')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 2;//set xe[i]=2
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h05E')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 2;//set xe[i]=2
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h02B')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h02I')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 5;//set xe[i]=5
			ye[i] = 0;//set ye[i]=0
			Ct(Me, 0, mt('h02O', 0, 0, 0));//call Ct(Me,0,mt('h02O',0,0,0))
			Ct(Me, 2, mt('h02R', 0, 0, 0));//call Ct(Me,2,mt('h02R',0,0,0))
			Ct(Me, 2, mt('h02N', 0, 0, 0));//call Ct(Me,2,mt('h02N',0,0,0))
			bt(Me);//call bt(Me)
			Ne = pi();//set Ne=pi()
			gu = mt(808478759,858810407,0,0);//set gu=mt('h00F','h032',0,0)
			hu = mt(842033191,842033191,842033191,0);//set hu=mt('h020','h021','h022',0)
			iu = mt(825255975,0,0,0);//set iu=mt('h01B',0,0,0)
			ju = mt(825255975,0,0,0);//set ju=mt('h01Z',0,0,0)
			ku = mt(808478759,0,0,0);//set ku=mt('h00J',0,0,0)
			wt(Ne, 1, gu);//call wt(Ne,1,gu)
			wt(Ne, 2, hu);//call wt(Ne,2,hu)
			wt(Ne, 2, iu);//call wt(Ne,2,iu)
			wt(Ne, 2, ku);//call wt(Ne,2,ku)
			wt(Ne, 3, gu);//call wt(Ne,3,gu)
			wt(Ne, 3, hu);//call wt(Ne,3,hu)
			wt(Ne, 3, iu);//call wt(Ne,3,iu)
			wt(Ne, 3, mt('h01Y', 0, 0, 0));//call wt(Ne,3,mt('h01Y',0,0,0))
			wt(Ne, 4, ku);//call wt(Ne,4,ku)
			wt(Ne, 4, iu);//call wt(Ne,4,iu)
			wt(Ne, 4, ju);//call wt(Ne,4,ju)
			wt(Ne, 5, iu);//call wt(Ne,5,iu)
			wt(Ne, 5, ju);//call wt(Ne,5,ju)
			wt(Ne, 6, ju);//call wt(Ne,6,ju)
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00F')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h032')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h020')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h021')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h022')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01B')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 5;//set xe[i]=5
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01Z')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01Y')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00J')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 2;//set xe[i]=2
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h05F')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			Ct(Ne, 0, mt('h00J', 'h05F', 0, 0));//call Ct(Ne,0,mt('h00J','h05F',0,0))
			Ct(Ne, 0, mt('h00N', 0, 0, 0));//call Ct(Ne,0,mt('h00N',0,0,0))
			Ct(Ne, 2, mt('h00I', 0, 0, 0));//call Ct(Ne,2,mt('h00I',0,0,0))
			Ct(Ne, 2, mt('h00M', 0, 0, 0));//call Ct(Ne,2,mt('h00M',0,0,0))
			bt(Ne);//call bt(Ne)
			Oe = pi();//set Oe=pi()
			mu = mt(858810407,0,0,0);//set mu=mt('h03S',0,0,0)
			nu = mt(858810407,0,0,0);//set nu=mt('h03I',0,0,0)
			wt(Oe, 1, mt('h03U', 0, 0, 0));//call wt(Oe,1,mt('h03U',0,0,0))
			wt(Oe, 1, mt('h03T', 'h043', 0, 0));//call wt(Oe,1,mt('h03T','h043',0,0))
			wt(Oe, 2, mt('h049', 'h04F', 'h03W', 0));//call wt(Oe,2,mt('h049','h04F','h03W',0))
			wt(Oe, 2, mu);//call wt(Oe,2,mu)
			wt(Oe, 2, nu);//call wt(Oe,2,nu)
			wt(Oe, 3, mt('h03K', 'h03J', 0, 0));//call wt(Oe,3,mt('h03K','h03J',0,0))
			wt(Oe, 3, mu);//call wt(Oe,3,mu)
			wt(Oe, 3, nu);//call wt(Oe,3,nu)
			wt(Oe, 4, mu);//call wt(Oe,4,mu)
			wt(Oe, 4, nu);//call wt(Oe,4,nu)
			wt(Oe, 5, mu);//call wt(Oe,5,mu)
			wt(Oe, 5, nu);//call wt(Oe,5,nu)
			wt(Oe, 6, mu);//call wt(Oe,6,mu)
			wt(Oe, 6, nu);//call wt(Oe,6,nu)
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03U')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03T')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h043')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h049')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04F')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03W')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03K')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03J')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h049')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04F')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			Ct(Oe, 0, mt('h03O', 0, 0, 0));//call Ct(Oe,0,mt('h03O',0,0,0))
			Ct(Oe, 1, mt('h048', 'h03L', 0, 0));//call Ct(Oe,1,mt('h048','h03L',0,0))
			Ct(Oe, 2, mt('h047', 0, 0, 0));//call Ct(Oe,2,mt('h047',0,0,0))
			bt(Oe);//call bt(Oe)
			Re = pi();//set Re=pi()
			ou = mt(825255975,892364839,0,0);//set ou=mt('h01P','h056',0,0)
			pu = mt(825255975,875587623,0,0);//set pu=mt('h01K','h04B',0,0)
			qu = mt(825255975,0,0,0);//set qu=mt('h01S',0,0,0)
			wt(Re, 1, mt('h01N', 'h054', 0, 0));//call wt(Re,1,mt('h01N','h054',0,0))
			wt(Re, 1, ou);//call wt(Re,1,ou)
			wt(Re, 1, pu);//call wt(Re,1,pu)
			wt(Re, 1, qu);//call wt(Re,1,qu)
			wt(Re, 2, ou);//call wt(Re,2,ou)
			wt(Re, 2, pu);//call wt(Re,2,pu)
			wt(Re, 2, qu);//call wt(Re,2,qu)
			wt(Re, 3, pu);//call wt(Re,3,pu)
			wt(Re, 3, mt('h01L', 0, 0, 0));//call wt(Re,3,mt('h01L',0,0,0))
			wt(Re, 3, qu);//call wt(Re,3,qu)
			wt(Re, 4, ou);//call wt(Re,4,ou)
			wt(Re, 4, pu);//call wt(Re,4,pu)
			wt(Re, 5, pu);//call wt(Re,5,pu)
			wt(Re, 5, mt('h01T', 0, 0, 0));//call wt(Re,5,mt('h01T',0,0,0))
			wt(Re, 5, qu);//call wt(Re,5,qu)
			wt(Re, 6, mt('h01R', 'h04Z', 'h03M', 0));//call wt(Re,6,mt('h01R','h04Z','h03M',0))
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01P')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h056')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01K')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04B')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h055')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01S')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 2;//set xe[i]=2
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01N')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h054')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01L')
			ve[i] = 6;//set ve[i]=6
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01T')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 5;//set xe[i]=5
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01R')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04Z')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03M')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			Ct(Re, 0, mt('h01K', 'h04B', 'h055', 0));//call Ct(Re,0,mt('h01K','h04B','h055',0))
			Ct(Re, 0, mt('h01Q', 0, 0, 0));//call Ct(Re,0,mt('h01Q',0,0,0))
			Ct(Re, 2, mt('h00A', 0, 0, 0));//call Ct(Re,2,mt('h00A',0,0,0))
			bt(Re);//call bt(Re)
			Pe = pi();//set Pe=pi()
			ru = mt(808478759,858810407,0,0);//set ru=mt('h00S','h03D',0,0)
			wt(Pe, 1, ru);//call wt(Pe,1,ru)
			wt(Pe, 1, mt('h07M', 'h07L', 0, 0));//call wt(Pe,1,mt('h07M','h07L',0,0))
			wt(Pe, 2, ru);//call wt(Pe,2,ru)
			wt(Pe, 3, mt('h07O', 'h07N', 0, 0));//call wt(Pe,3,mt('h07O','h07N',0,0))
			wt(Pe, 3, mt('h00B', 0, 0, 0));//call wt(Pe,3,mt('h00B',0,0,0))
			wt(Pe, 4, ru);//call wt(Pe,4,ru)
			wt(Pe, 5, ru);//call wt(Pe,5,ru)
			wt(Pe, 5, mt('h011', 0, 0, 0));//call wt(Pe,5,mt('h011',0,0,0))
			wt(Pe, 6, mt('h088', 'h07D', 0, 0));//call wt(Pe,6,mt('h088','h07D',0,0))
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00S')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03D')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03E')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(925919271);//set i=GetUnitPointValueByType('h07M')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(925919271);//set i=GetUnitPointValueByType('h07L')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(925919271);//set i=GetUnitPointValueByType('h07O')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 3;//set xe[i]=3
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(925919271);//set i=GetUnitPointValueByType('h07N')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 3;//set xe[i]=3
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00B')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h011')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 5;//set xe[i]=5
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(942696487);//set i=GetUnitPointValueByType('h088')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(925919271);//set i=GetUnitPointValueByType('h07D')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			Ct(Pe, 0, mt('h00S', 'h03D', 'h03E', 0));//call Ct(Pe,0,mt('h00S','h03D','h03E',0))
			Ct(Pe, 3, mt('h07I', 0, 0, 0));//call Ct(Pe,3,mt('h07I',0,0,0))
			Ct(Pe, 2, mt('h07H', 0, 0, 0));//call Ct(Pe,2,mt('h07H',0,0,0))
			Ct(Pe, 2, mt('h08P', 0, 0, 0));//call Ct(Pe,2,mt('h08P',0,0,0))
			bt(Pe);//call bt(Pe)
			Qe = pi();//set Qe=pi()
			su = mt(942696487,942696487,0,0);//set su=mt('h08X','h08Y',0,0)
			tu = mt(909142055,0,0,0);//set tu=mt('h06Y',0,0,0)
			uu = mt(808478759,858810407,0,0);//set uu=mt('h00T','h03F',0,0)
			vu = mt(959473703,0,0,0);//set vu=mt('h09X',0,0,0)
			wu = mt(808478759,0,0,0);//set wu=mt('h00V',0,0,0)
			wt(Qe, 1, su);//call wt(Qe,1,su)
			wt(Qe, 1, tu);//call wt(Qe,1,tu)
			wt(Qe, 2, uu);//call wt(Qe,2,uu)
			wt(Qe, 3, wu);//call wt(Qe,3,wu)
			wt(Qe, 3, vu);//call wt(Qe,3,vu)
			wt(Qe, 4, su);//call wt(Qe,4,su)
			wt(Qe, 4, tu);//call wt(Qe,4,tu)
			wt(Qe, 5, mt('h070', 0, 0, 0));//call wt(Qe,5,mt('h070',0,0,0))
			wt(Qe, 5, wu);//call wt(Qe,5,wu)
			wt(Qe, 6, su);//call wt(Qe,6,su)
			wt(Qe, 6, uu);//call wt(Qe,6,uu)
			wt(Qe, 6, vu);//call wt(Qe,6,vu)
			i = GetUnitPointValueByType(942696487);//set i=GetUnitPointValueByType('h08X')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(942696487);//set i=GetUnitPointValueByType('h08Y')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(909142055);//set i=GetUnitPointValueByType('h06Y')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00T')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03F')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00V')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(959473703);//set i=GetUnitPointValueByType('h09X')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00X')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(925919271);//set i=GetUnitPointValueByType('h070')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 5;//set xe[i]=5
			ye[i] = 0;//set ye[i]=0
			Ct(Qe, 0, mt('h09X', 'h00X', 0, 0));//call Ct(Qe,0,mt('h09X','h00X',0,0))
			Ct(Qe, 0, mt('h059', 0, 0, 0));//call Ct(Qe,0,mt('h059',0,0,0))
			Ct(Qe, 2, mt('h00Z', 0, 0, 0));//call Ct(Qe,2,mt('h00Z',0,0,0))
			Ct(Qe, 2, mt('h005', 0, 0, 0));//call Ct(Qe,2,mt('h005',0,0,0))
			bt(Qe);//call bt(Qe)
			Se = pi();//set Se=pi()
			xu = mt(892364839,959473703,0,0);//set xu=mt('h05X','h09I',0,0)
			yu = mt(892364839,959473703,0,0);//set yu=mt('h05X','h09B',0,0)
			zu = mt(892364839,959473703,0,0);//set zu=mt('h05X','h09J',0,0)
			Au = mt(892364839,959473703,0,0);//set Au=mt('h05T','h09P',0,0)
			wt(Se, 1, mt('h05U', 0, 0, 0));//call wt(Se,1,mt('h05U',0,0,0))
			wt(Se, 1, xu);//call wt(Se,1,xu)
			wt(Se, 1, Au);//call wt(Se,1,Au)
			wt(Se, 2, yu);//call wt(Se,2,yu)
			wt(Se, 2, zu);//call wt(Se,2,zu)
			wt(Se, 2, Au);//call wt(Se,2,Au)
			wt(Se, 3, xu);//call wt(Se,3,xu)
			wt(Se, 3, yu);//call wt(Se,3,yu)
			wt(Se, 3, zu);//call wt(Se,3,zu)
			wt(Se, 3, mt('h05M', 0, 0, 0));//call wt(Se,3,mt('h05M',0,0,0))
			wt(Se, 4, mt('h05X', 'h09B', 'h09H', 0));//call wt(Se,4,mt('h05X','h09B','h09H',0))
			wt(Se, 4, mt('h05J', 'h09L', 0, 0));//call wt(Se,4,mt('h05J','h09L',0,0))
			wt(Se, 5, xu);//call wt(Se,5,xu)
			wt(Se, 5, yu);//call wt(Se,5,yu)
			wt(Se, 5, Au);//call wt(Se,5,Au)
			wt(Se, 6, xu);//call wt(Se,6,xu)
			wt(Se, 6, mt('h05V', 0, 0, 0));//call wt(Se,6,mt('h05V',0,0,0))
			wt(Se, 6, Au);//call wt(Se,6,Au)
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h05X')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(959473703);//set i=GetUnitPointValueByType('h09I')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(959473703);//set i=GetUnitPointValueByType('h09B')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(959473703);//set i=GetUnitPointValueByType('h09J')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h05T')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(959473703);//set i=GetUnitPointValueByType('h09P')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h05U')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h05M')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 3;//set xe[i]=3
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(959473703);//set i=GetUnitPointValueByType('h09H')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 2;//set xe[i]=2
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h05J')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 1;//set xe[i]=1
			ye[i] = 2;//set ye[i]=2
			i = GetUnitPointValueByType(959473703);//set i=GetUnitPointValueByType('h09L')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 1;//set xe[i]=1
			ye[i] = 2;//set ye[i]=2
			i = GetUnitPointValueByType(892364839);//set i=GetUnitPointValueByType('h05V')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(959473703);//set i=GetUnitPointValueByType('h097')
			ve[i] = 6;//set ve[i]=6
			xe[i] = 6;//set xe[i]=6
			ye[i] = 0;//set ye[i]=0
			Ct(Se, 0, mt('h05V', 'h097', 0, 0));//call Ct(Se,0,mt('h05V','h097',0,0))
			Ct(Se, 2, mt('h06J', 'h05R', 0, 0));//call Ct(Se,2,mt('h06J','h05R',0,0))
			Ct(Se, 2, mt('h069', 0, 0, 0));//call Ct(Se,2,mt('h069',0,0,0))
			bt(Se);//call bt(Se)
			Te = pi();//set Te=pi()
			au = mt(808478759,808478759,808478759,0);//set au=mt('h002','h00Q','h00R',0)
			Bu = mt(842033191,0,0,0);//set Bu=mt('h028',0,0,0)
			bu = mt(808478759,825255975,0,0);//set bu=mt('h00Y','h012',0,0)
			Cu = mt(825255975,825255975,0,0);//set Cu=mt('h013','h01H',0,0)
			cu = mt(842033191,0,0,0);//set cu=mt('h027',0,0,0)
			wt(Te, 1, au);//call wt(Te,1,au)
			wt(Te, 1, Cu);//call wt(Te,1,Cu)
			wt(Te, 2, mt('h023', 'h024', 0, 0));//call wt(Te,2,mt('h023','h024',0,0))
			wt(Te, 2, Bu);//call wt(Te,2,Bu)
			wt(Te, 3, bu);//call wt(Te,3,bu)
			wt(Te, 4, bu);//call wt(Te,4,bu)
			wt(Te, 4, Cu);//call wt(Te,4,Cu)
			wt(Te, 4, Bu);//call wt(Te,4,Bu)
			wt(Te, 5, Bu);//call wt(Te,5,Bu)
			wt(Te, 5, cu);//call wt(Te,5,cu)
			wt(Te, 6, Bu);//call wt(Te,6,Bu)
			wt(Te, 6, cu);//call wt(Te,6,cu)
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h002')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00Q')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 1;//set xe[i]=1
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00R')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h028')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 5;//set xe[i]=5
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(808478759);//set i=GetUnitPointValueByType('h00Y')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h012')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h013')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01H')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(825255975);//set i=GetUnitPointValueByType('h01J')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h027')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h023')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(842033191);//set i=GetUnitPointValueByType('h024')
			ve[i] = 5;//set ve[i]=5
			xe[i] = 2;//set xe[i]=2
			ye[i] = 0;//set ye[i]=0
			Ct(Te, 0, mt('h013', 'h01H', 'h01J', 0));//call Ct(Te,0,mt('h013','h01H','h01J',0))
			Ct(Te, 0, mt('h02D', 0, 0, 0));//call Ct(Te,0,mt('h02D',0,0,0))
			Ct(Te, 2, mt('h02C', 0, 0, 0));//call Ct(Te,2,mt('h02C',0,0,0))
			Ct(Te, 2, mt('h02A', 0, 0, 0));//call Ct(Te,2,mt('h02A',0,0,0))
			bt(Te);//call bt(Te)
			Ue = pi();//set Ue=pi()
			Du = mt(875587623,875587623,0,0);//set Du=mt('h045','h046',0,0)
			Eu = mt(875587623,875587623,0,0);//set Eu=mt('h040','h041',0,0)
			Fu = mt(858810407,858810407,858810407,0);//set Fu=mt('h03X','h03Y','h03Z',0)
			Gu = mt(875587623,875587623,0,0);//set Gu=mt('h042','h044',0,0)
			wt(Ue, 1, Du);//call wt(Ue,1,Du)
			wt(Ue, 1, Fu);//call wt(Ue,1,Fu)
			wt(Ue, 1, Gu);//call wt(Ue,1,Gu)
			wt(Ue, 2, Fu);//call wt(Ue,2,Fu)
			wt(Ue, 3, Gu);//call wt(Ue,3,Gu)
			wt(Ue, 4, mt('h04A', 'h04C', 'h04D', 0));//call wt(Ue,4,mt('h04A','h04C','h04D',0))
			wt(Ue, 4, Du);//call wt(Ue,4,Du)
			wt(Ue, 5, Eu);//call wt(Ue,5,Eu)
			wt(Ue, 6, Du);//call wt(Ue,6,Du)
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h045')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h046')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 6;//set xe[i]=6
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h040')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 5;//set xe[i]=5
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h041')
			ve[i] = 2;//set ve[i]=2
			xe[i] = 5;//set xe[i]=5
			ye[i] = 0;//set ye[i]=0
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03X')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 2;//set xe[i]=2
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03Y')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 2;//set xe[i]=2
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(858810407);//set i=GetUnitPointValueByType('h03Z')
			ve[i] = 1;//set ve[i]=1
			xe[i] = 2;//set xe[i]=2
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h042')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h044')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04A')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 1;//set xe[i]=1
			ye[i] = 2;//set ye[i]=2
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04C')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04D')
			ve[i] = 4;//set ve[i]=4
			xe[i] = 1;//set xe[i]=1
			ye[i] = 1;//set ye[i]=1
			i = GetUnitPointValueByType(875587623);//set i=GetUnitPointValueByType('h04E')
			ve[i] = 3;//set ve[i]=3
			xe[i] = 3;//set xe[i]=3
			ye[i] = 1;//set ye[i]=1
			Ct(Ue, 0, mt('h045', 'h046', 'h04E', 0));//call Ct(Ue,0,mt('h045','h046','h04E',0))
			Ct(Ue, 0, mt('h063', 0, 0, 0));//call Ct(Ue,0,mt('h063',0,0,0))
			Ct(Ue, 2, mt('h060', 0, 0, 0));//call Ct(Ue,2,mt('h060',0,0,0))
			Ct(Ue, 2, mt('h05Z', 0, 0, 0));//call Ct(Ue,2,mt('h05Z',0,0,0))
			bt(Ue);//call bt(Ue)
			Ge = true;//set Ge=true
		}//endfunction
		private void Hu() {//function Hu takes nothing returns nothing
			unit c;//local unit c
			int i = GetRandomInt(0,8);//local integer i=GetRandomInt(0,8)
			float x;//local real x
			float y;//local real y
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl", GetUnitX(B4), GetUnitY(B4)));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl",GetUnitX(B4),GetUnitY(B4)))
			bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			if ((yd)) {//if(yd)then
				Pj("SE:CH:ST "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));//call Pj("SE:CH:ST "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick))
				Rj();//call Rj()
			}//endif
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl", bj_groupRandomCurrentPick, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl",bj_groupRandomCurrentPick,"origin"))
			if ((Hr(bj_groupRandomCurrentPick))) {//if(Hr(bj_groupRandomCurrentPick))then
				return;//return
			}//endif
			if ((i==0)) {//if(i==0)then
				ExplodeUnitBJ(bj_groupRandomCurrentPick);//call ExplodeUnitBJ(bj_groupRandomCurrentPick)
				i = GetPlayerId(r4);//set i=GetPlayerId(r4)
				Sd[i] = Sd[i]+1;//set Sd[i]=Sd[i]+1
			} else if ((i==1)) {//elseif(i==1)then
				UnitDamageTarget(B4, bj_groupRandomCurrentPick, 50000., true, false, ATTACK_TYPE_NORMAL, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(B4,bj_groupRandomCurrentPick,50000.,true,false,ATTACK_TYPE_NORMAL,DAMAGE_TYPE_DEATH,WEAPON_TYPE_WHOKNOWS)
			} else if ((i==2)) {//elseif(i==2)then
				UnitDamageTarget(B4, bj_groupRandomCurrentPick, 500., true, false, ATTACK_TYPE_NORMAL, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(B4,bj_groupRandomCurrentPick,500.,true,false,ATTACK_TYPE_NORMAL,DAMAGE_TYPE_DEATH,WEAPON_TYPE_WHOKNOWS)
			} else if ((i==3)) {//elseif(i==3)then
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl", bj_groupRandomCurrentPick, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Avatar\\AvatarCaster.mdl",bj_groupRandomCurrentPick,"origin"))
				UnitAddAbility(bj_groupRandomCurrentPick, 'A06T');//call UnitAddAbility(bj_groupRandomCurrentPick,'A06T')
				UnitAddAbility(bj_groupRandomCurrentPick, 'A06U');//call UnitAddAbility(bj_groupRandomCurrentPick,'A06U')
				SetUnitState(bj_groupRandomCurrentPick, UNIT_STATE_LIFE, GetUnitState(bj_groupRandomCurrentPick, UNIT_STATE_MAX_LIFE));//call SetUnitState(bj_groupRandomCurrentPick,UNIT_STATE_LIFE,GetUnitState(bj_groupRandomCurrentPick,UNIT_STATE_MAX_LIFE))
			} else if ((i==4)) {//elseif(i==4)then
				c = CreateUnit(r4,808477991,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);//set c=CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0)
				UnitAddAbility(c, 'A018');//call UnitAddAbility(c,'A018')
				UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
				IssueTargetOrderById(c, $D0216, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D0216,bj_groupRandomCurrentPick)
				UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
				UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
				c = bj_groupRandomCurrentPick;//set c=bj_groupRandomCurrentPick
				TriggerSleepAction(1.);//call TriggerSleepAction(1.)
				Po(c);//call Po(c)
				if ((GetUnitTypeId(c)==858810407)) {//if(GetUnitTypeId(c)=='h03A')then
					TriggerSleepAction(44.5);//call TriggerSleepAction(44.5)
					IssueImmediateOrderById(c, $D0057);//call IssueImmediateOrderById(c,$D0057)
					TriggerSleepAction(.5);//call TriggerSleepAction(.5)
					Po(c);//call Po(c)
				}//endif
				c = null;//set c=null
			} else if ((i==5)) {//elseif(i==5)then
				c = CreateUnit(r4,808477991,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);//set c=CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0)
				UnitAddAbility(c, 'A06S');//call UnitAddAbility(c,'A06S')
				UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
				IssueTargetOrderById(c, $D007F, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D007F,bj_groupRandomCurrentPick)
				UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
				UnitApplyTimedLife(c, 'BTLF', 2.);//call UnitApplyTimedLife(c,'BTLF',2.)
				c = null;//set c=null
			} else if ((i==6)) {//elseif(i==6)then
				i = GetPlayerId(r4);//set i=GetPlayerId(r4)
				Sd[i] = Sd[i]+1;//set Sd[i]=Sd[i]+1
				ShowUnit(bj_groupRandomCurrentPick, false);//call ShowUnit(bj_groupRandomCurrentPick,false)
				x = GetUnitX(bj_groupRandomCurrentPick);//set x=GetUnitX(bj_groupRandomCurrentPick)
				y = GetUnitY(bj_groupRandomCurrentPick);//set y=GetUnitY(bj_groupRandomCurrentPick)
				DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl", x, y));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\FeralSpirit\\feralspiritdone.mdl",x,y))
				Po(CreateUnit(r4, 'n01S', x, y, GetUnitFacing(bj_groupRandomCurrentPick)));//call Po(CreateUnit(r4,'n01S',x,y,GetUnitFacing(bj_groupRandomCurrentPick)))
				RemoveUnit(bj_groupRandomCurrentPick);//call RemoveUnit(bj_groupRandomCurrentPick)
			}//endif
		}//endfunction
		private bool Iu() {//function Iu takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && GetUnitTypeId(u)==Xe;//local boolean Im=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and GetUnitTypeId(u)==Xe
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void lu() {//function lu takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u=GetEnumUnit()
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Items\\AIil\\AIilTarget.mdl", u, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Items\\AIil\\AIilTarget.mdl",u,"origin"))
			if ((GetUnitAbilityLevel(u,925909287)<=0)) {//if(GetUnitAbilityLevel(u,'A070')<=0)then
				UnitDamageTarget(B4, u, 100500., true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(B4,u,100500.,true,false,ATTACK_TYPE_CHAOS,DAMAGE_TYPE_DEATH,WEAPON_TYPE_WHOKNOWS)
			}//endif
			u = null;//set u=null
		}//endfunction
		private void Ju() {//function Ju takes nothing returns nothing
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl", GetUnitX(B4), GetUnitY(B4)));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl",GetUnitX(B4),GetUnitY(B4)))
			bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			if ((yd)) {//if(yd)then
				Pj("SE:CH:SE "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));//call Pj("SE:CH:SE "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick))
				Rj();//call Rj()
			}//endif
			Xe = GetUnitTypeId(bj_groupRandomCurrentPick);//set Xe=GetUnitTypeId(bj_groupRandomCurrentPick)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Ye);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,Ye)
			ForGroup(q4, function lu);//call ForGroup(q4,function lu)
		}//endfunction
		private void Ku() {//function Ku takes nothing returns nothing
			float x;//local real x
			float y;//local real y
			unit c;//local unit c
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, x9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,x9)
			bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			if ((yd)) {//if(yd)then
				Pj("SE:CH:SV "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));//call Pj("SE:CH:SV "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick))
				Rj();//call Rj()
			}//endif
			x = GetUnitX(bj_groupRandomCurrentPick);//set x=GetUnitX(bj_groupRandomCurrentPick)
			y = GetUnitY(bj_groupRandomCurrentPick);//set y=GetUnitY(bj_groupRandomCurrentPick)
			c = CreateUnit(r4,808477991,x,y,.0);//set c=CreateUnit(r4,'e008',x,y,.0)
			UnitAddAbility(c, We);//call UnitAddAbility(c,We)
			IssuePointOrderById(c, $D0208, x, y);//call IssuePointOrderById(c,$D0208,x,y)
			UnitApplyTimedLife(c, 'BTLF', 6.);//call UnitApplyTimedLife(c,'BTLF',6.)
			c = null;//set c=null
		}//endfunction
		private bool Lu() {//function Lu takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_STRUCTURE) && GetPlayerId(GetOwningPlayer(u))<$C && GetUnitTypeId(u)!=1633904679 && GetUnitAbilityLevel(u,909132071)<=0;//local boolean Im=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_STRUCTURE)and GetPlayerId(GetOwningPlayer(u))<$C and GetUnitTypeId(u)!='hcas' and GetUnitAbilityLevel(u,'A06V')<=0
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void Mu() {//function Mu takes nothing returns nothing
			int t;//local integer t
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Ze);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,Ze)
			bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			if ((yd)) {//if(yd)then
				Pj("SE:CH:SD "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));//call Pj("SE:CH:SD "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick))
				Rj();//call Rj()
			}//endif
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosTarget.mdl", GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick)));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosTarget.mdl",GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick)))
			KillUnit(bj_groupRandomCurrentPick);//call KillUnit(bj_groupRandomCurrentPick)
			t = me[GetPlayerId(r4)];//set t=me[GetPlayerId(r4)]
			Nd[t] = Nd[t]+1;//set Nd[t]=Nd[t]+1
			Yr(3, t+1, I2S(Nd[t]));//call Yr(3,t+1,I2S(Nd[t]))
		}//endfunction
		private void Nu() {//function Nu takes nothing returns nothing
			unit c;//local unit c
			if ((yd)) {//if(yd)then
				Pj("SE:CH:SR "+GetUnitName(c4)+" ->[no target]");//call Pj("SE:CH:SR "+GetUnitName(c4)+" ->[no target]")
				Rj();//call Rj()
			}//endif
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\NightElf\\BattleRoar\\RoarCaster.mdl", c4, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\NightElf\\BattleRoar\\RoarCaster.mdl",c4,"origin"))
			c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//set c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(c, 'A03R');//call UnitAddAbility(c,'A03R')
			IssueImmediateOrderById(c, $D00C4);//call IssueImmediateOrderById(c,$D00C4)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = null;//set c=null
		}//endfunction
		private bool Ou() {//function Ou takes nothing returns boolean
			Bj(z4, 'h094', 74., 38.5, 28.);//call Bj(z4,'h094',74.,38.5,28.)
			Bj(z4, 'h093', 160., -42., -18.75);//call Bj(z4,'h093',160.,-42.,-18.75)
			Bj(z4, 'h093', 250., 3.75, -55.5);//call Bj(z4,'h093',250.,3.75,-55.5)
			Bj(z4, 'h08Z', 220., 43., 27.5);//call Bj(z4,'h08Z',220.,43.,27.5)
			return false;//return false
		}//endfunction
		private void Pu() {//function Pu takes nothing returns nothing
			lj('h05I', function Hu);//call lj('h05I',function Hu)
			zj('h025', 'n00L');//call zj('h025','n00L')
			lj('h01M', function Ju);//call lj('h01M',function Ju)
			lj('h01W', function Ju);//call lj('h01W',function Ju)
			lj('h01X', function Ju);//call lj('h01X',function Ju)
			zj('h01I', 'n00A');//call zj('h01I','n00A')
			zj('h026', 'z000');//call zj('h026','z000')
			lj('h01F', function Ku);//call lj('h01F',function Ku)
			lj('h01E', function Mu);//call lj('h01E',function Mu)
			zj('h01C', 'n008');//call zj('h01C','n008')
			zj('h01D', 'n009');//call zj('h01D','n009')
			zj('h03G', 'n00Z');//call zj('h03G','n00Z')
			Fj('h03G', function Ou);//call Fj('h03G',function Ou)
			zj('h009', 'n001');//call zj('h009','n001')
			zj('h007', 'n000');//call zj('h007','n000')
		}//endfunction
		private void Qu() {//function Qu takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h025')
			t4[id] = 280;//set t4[id]=280
			u4[id] = 280*.2/ 100.;//set u4[id]=280*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01I')
			t4[id] = 'x';//set t4[id]='x'
			u4[id] = 'x'*.2/ 100.;//set u4[id]='x'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h026')
			t4[id] = $E6;//set t4[id]=$E6
			u4[id] = $E6*.2/ 100.;//set u4[id]=$E6*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01C')
			t4[id] = $E6;//set t4[id]=$E6
			u4[id] = $E6*.2/ 100.;//set u4[id]=$E6*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01D')
			t4[id] = $A0;//set t4[id]=$A0
			u4[id] = $A0*.2/ 100.;//set u4[id]=$A0*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03G')
			t4[id] = $BE;//set t4[id]=$BE
			u4[id] = $BE*.2/ 100.;//set u4[id]=$BE*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h009')
			t4[id] = 350;//set t4[id]=350
			u4[id] = 350*.2/ 100.;//set u4[id]=350*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h007')
			t4[id] = 500;//set t4[id]=500
			u4[id] = 500*.2/ 100.;//set u4[id]=500*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05I')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.09/ 100.;//set u4[id]=$C8*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01M')
			t4[id] = 350;//set t4[id]=350
			u4[id] = 350*.09/ 100.;//set u4[id]=350*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01W')
			t4[id] = $AF;//set t4[id]=$AF
			u4[id] = $AF*.09/ 100.;//set u4[id]=$AF*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01X')
			t4[id] = $AF;//set t4[id]=$AF
			u4[id] = $AF*.09/ 100.;//set u4[id]=$AF*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01F')
			t4[id] = 340;//set t4[id]=340
			u4[id] = 340*.09/ 100.;//set u4[id]=340*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01E')
			t4[id] = 850;//set t4[id]=850
			u4[id] = 850*.12/ 100.;//set u4[id]=850*.12/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void Chaos___RegisterUnitCasts() {//function Chaos___RegisterUnitCasts takes nothing returns nothing
			Lj('n00Z', 'A03S', function Nu);//call Lj('n00Z','A03S',function Nu)
		}//endfunction
		private unit Ru(unit u, int aj) {//function Ru takes unit u,integer aj returns unit
			unit n;//local unit n
			ShowUnit(u, false);//call ShowUnit(u,false)
			n = CreateUnit(GetOwningPlayer(u),aj,GetUnitX(u),GetUnitY(u),GetUnitFacing(u));//set n=CreateUnit(GetOwningPlayer(u),aj,GetUnitX(u),GetUnitY(u),GetUnitFacing(u))
			RemoveUnit(u);//call RemoveUnit(u)
			return n;//return n
		}//endfunction
		private unit Su(unit u) {//function Su takes unit u returns unit
			int i = GetRandomInt(0,99);//local integer i=GetRandomInt(0,99)
			if ((i<5)) {//if(i<5)then
				u = Ru(u,808480295);//set u=Ru(u,'n00M')
			} else if ((i<$E)) {//elseif(i<$E)then
				u = Ru(u,808480295);//set u=Ru(u,'n00R')
			} else {//else
				i = GetRandomInt(0,3);//set i=GetRandomInt(0,3)
				if ((i==0)) {//if(i==0)then
					u = Ru(u,808480295);//set u=Ru(u,'n00Q')
				} else if ((i==1)) {//elseif(i==1)then
					u = Ru(u,808480295);//set u=Ru(u,'n00N')
				} else if ((i==2)) {//elseif(i==2)then
					u = Ru(u,808480295);//set u=Ru(u,'n00O')
				} else {//else
					u = Ru(u,808480295);//set u=Ru(u,'n00P')
				}//endif
			}//endif
			i = GetRandomInt(0,99);//set i=GetRandomInt(0,99)
			if ((i<20)) {//if(i<20)then
				UnitAddAbility(u, 'A009');//call UnitAddAbility(u,'A009')
			} else if ((i<55)) {//elseif(i<55)then
				UnitAddAbility(u, 'A01F');//call UnitAddAbility(u,'A01F')
			}//endif
			i = GetRandomInt(0,99);//set i=GetRandomInt(0,99)
			if ((i<18)) {//if(i<18)then
				UnitAddAbility(u, 'A02B');//call UnitAddAbility(u,'A02B')
			} else if ((i<30)) {//elseif(i<30)then
				UnitAddAbility(u, 'A01B');//call UnitAddAbility(u,'A01B')
			} else if ((i<33)) {//elseif(i<33)then
				UnitAddAbility(u, 'A00Z');//call UnitAddAbility(u,'A00Z')
			} else if ((i<43)) {//elseif(i<43)then
				UnitAddAbility(u, 'A07L');//call UnitAddAbility(u,'A07L')
			}//endif
			i = GetRandomInt(0,99);//set i=GetRandomInt(0,99)
			if ((i<$A)) {//if(i<$A)then
				UnitAddAbility(u, 'A00U');//call UnitAddAbility(u,'A00U')
			} else if ((i<32)) {//elseif(i<32)then
				UnitAddAbility(u, 'A00T');//call UnitAddAbility(u,'A00T')
			} else if ((i<35)) {//elseif(i<35)then
				UnitAddAbility(u, 'A05J');//call UnitAddAbility(u,'A05J')
			}//endif
			i = GetRandomInt(0,99);//set i=GetRandomInt(0,99)
			if ((i<25)) {//if(i<25)then
				UnitAddAbility(u, 'A01A');//call UnitAddAbility(u,'A01A')
			}//endif
			i = GetRandomInt(0,99);//set i=GetRandomInt(0,99)
			if ((i<$F)) {//if(i<$F)then
				UnitAddAbility(u, 'A00V');//call UnitAddAbility(u,'A00V')
			} else if ((i<40)) {//elseif(i<40)then
				UnitAddAbility(u, 'A00D');//call UnitAddAbility(u,'A00D')
			}//endif
			i = GetRandomInt(0,99);//set i=GetRandomInt(0,99)
			if ((i<8)) {//if(i<8)then
				UnitAddAbility(u, 'A01U');//call UnitAddAbility(u,'A01U')
			} else if ((i<16)) {//elseif(i<16)then
				UnitAddAbility(u, 'A010');//call UnitAddAbility(u,'A010')
			} else if ((i<24)) {//elseif(i<24)then
				UnitAddAbility(u, 'A01P');//call UnitAddAbility(u,'A01P')
			} else if ((i<34)) {//elseif(i<34)then
				UnitAddAbility(u, 'A006');//call UnitAddAbility(u,'A006')
			} else if ((i<44)) {//elseif(i<44)then
				UnitAddAbility(u, 'A01R');//call UnitAddAbility(u,'A01R')
			} else if ((i<47)) {//elseif(i<47)then
				UnitAddAbility(u, 'A012');//call UnitAddAbility(u,'A012')
			}//endif
			return u;//return u
		}//endfunction
		private void Tu() {//function Tu takes nothing returns nothing
			Pu();//call Pu()
			Qu();//call Qu()
			Lj('n00Z', 'A03S', function Nu);//call Lj('n00Z','A03S',function Nu)
			Ye = Filter(function Iu);//set Ye=Filter(function Iu)
			Ze = Filter(function Lu);//set Ze=Filter(function Lu)
		}//endfunction
		private void Uu() {//function Uu takes nothing returns nothing
			int i = 0;//local integer i=0
			float x;//local real x
			float y;//local real y
			float an;//local real an
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, x9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,x9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			x = GetUnitX(bj_groupRandomCurrentPick);//set x=GetUnitX(bj_groupRandomCurrentPick)
			y = GetUnitY(bj_groupRandomCurrentPick);//set y=GetUnitY(bj_groupRandomCurrentPick)
			while (true) {//loop
				an = 60.*I2R(i);//set an=60.*I2R(i)
				UnitApplyTimedLife(CreateUnit(r4, df, x+64.*Cos(an*bj_DEGTORAD), y+64.*Sin(an*bj_DEGTORAD), 360.-an), 'BTLF', 9.);//call UnitApplyTimedLife(CreateUnit(r4,df,x+64.*Cos(an*bj_DEGTORAD),y+64.*Sin(an*bj_DEGTORAD),360.-an),'BTLF',9.)
				i = i+1;//set i=i+1
				if (i>=6) { break; }//exitwhen i>=6
			}//endloop
		}//endfunction
		private void Vu() {//function Vu takes nothing returns nothing
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Undead\\DeathPact\\DeathPactTarget.mdl", bj_groupRandomCurrentPick, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Undead\\DeathPact\\DeathPactTarget.mdl",bj_groupRandomCurrentPick,"origin"))
			if (!Hr(bj_groupRandomCurrentPick)) {//if not Hr(bj_groupRandomCurrentPick)then
				UnitDamageTarget(B4, bj_groupRandomCurrentPick, 200., true, false, ATTACK_TYPE_NORMAL, DAMAGE_TYPE_SONIC, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(B4,bj_groupRandomCurrentPick,200.,true,false,ATTACK_TYPE_NORMAL,DAMAGE_TYPE_SONIC,WEAPON_TYPE_WHOKNOWS)
			}//endif
		}//endfunction
		private void Wu() {//function Wu takes nothing returns nothing
			player p = GetOwningPlayer(c4);//local player p=GetOwningPlayer(c4)
			float x = GetUnitX(c4);//local real x=GetUnitX(c4)
			float y = GetUnitY(c4);//local real y=GetUnitY(c4)
			float an = bj_RADTODEG*Atan2(GetUnitY(D4)-y,GetUnitX(D4)-x)-20.;//local real an=bj_RADTODEG*Atan2(GetUnitY(D4)-y,GetUnitX(D4)-x)-20.
			int i = 0;//local integer i=0
			unit c;//local unit c
			while (true) {//loop
				c = CreateUnit(p,808477991,x,y,an);//set c=CreateUnit(p,'e008',x,y,an)
				UnitAddAbility(c, 'A0AF');//call UnitAddAbility(c,'A0AF')
				IssuePointOrderById(c, $D024B, x+10.*Cos(an*bj_DEGTORAD), y+10.*Sin(an*bj_DEGTORAD));//call IssuePointOrderById(c,$D024B,x+10.*Cos(an*bj_DEGTORAD),y+10.*Sin(an*bj_DEGTORAD))
				UnitApplyTimedLife(c, 'BTLF', 2.);//call UnitApplyTimedLife(c,'BTLF',2.)
				an = an+(10.);//set an=an+(10.)
				i = i+1;//set i=i+1
				if (i>3) { break; }//exitwhen i>3
			}//endloop
			c = null;//set c=null
		}//endfunction
		private bool Xu() {//function Xu takes nothing returns boolean
			Bj(z4, 'h04J', 191., .0, .0);//call Bj(z4,'h04J',191.,.0,.0)
			return false;//return false
		}//endfunction
		private bool Yu() {//function Yu takes nothing returns boolean
			Bj(z4, 'h09Z', 270., .0, .0);//call Bj(z4,'h09Z',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool Zu() {//function Zu takes nothing returns boolean
			SetUnitVertexColor(z4, 82, 0, $87, 'f');//call SetUnitVertexColor(z4,82,0,$87,'f')
			return false;//return false
		}//endfunction
		private bool dv() {//function dv takes nothing returns boolean
			Bj(z4, 'h08I', .0, .0, .0);//call Bj(z4,'h08I',.0,.0,.0)
			return false;//return false
		}//endfunction
		private void ev() {//function ev takes nothing returns nothing
			Ij('n01J', 800.);//call Ij('n01J',800.)
			zj('h04V', 'n01I');//call zj('h04V','n01I')
			zj('h04W', 'n01H');//call zj('h04W','n01H')
			zj('h09Y', 'n027');//call zj('h09Y','n027')
			Fj('h09Y', function Yu);//call Fj('h09Y',function Yu)
			zj('h04U', 'h04I');//call zj('h04U','h04I')
			Fj('h04U', function Xu);//call Fj('h04U',function Xu)
			zj('h04S', 'n01G');//call zj('h04S','n01G')
			lj('h04R', function Uu);//call lj('h04R',function Uu)
			zj('h04Q', 'n01F');//call zj('h04Q','n01F')
			zj('h04P', 'n01E');//call zj('h04P','n01E')
			zj('h04O', 'n01D');//call zj('h04O','n01D')
			zj('h04M', 'n01B');//call zj('h04M','n01B')
			Fj('h04M', function Zu);//call Fj('h04M',function Zu)
			zj('h04L', 'n019');//call zj('h04L','n019')
			zj('h04N', 'n01A');//call zj('h04N','n01A')
			lj('h04K', function Vu);//call lj('h04K',function Vu)
			Fj('h04K', function dv);//call Fj('h04K',function dv)
		}//endfunction
		private void fv() {//function fv takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04V')
			t4[id] = '}';//set t4[id]='}'
			u4[id] = '}'*.2/ 100.;//set u4[id]='}'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04W')
			t4[id] = '}';//set t4[id]='}'
			u4[id] = '}'*.2/ 100.;//set u4[id]='}'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04U')
			t4[id] = 520;//set t4[id]=520
			u4[id] = 520*.2/ 100.;//set u4[id]=520*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04S')
			t4[id] = $F0;//set t4[id]=$F0
			u4[id] = $F0*.2/ 100.;//set u4[id]=$F0*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04Q')
			t4[id] = 300;//set t4[id]=300
			u4[id] = 300*.18/ 100.;//set u4[id]=300*.18/ 100.
			v4[id] = true;//set v4[id]=true
			w4[id] = true;//set w4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04P')
			t4[id] = $96;//set t4[id]=$96
			u4[id] = $96*.18/ 100.;//set u4[id]=$96*.18/ 100.
			v4[id] = true;//set v4[id]=true
			w4[id] = true;//set w4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04O')
			t4[id] = $EB;//set t4[id]=$EB
			u4[id] = $EB*.2/ 100.;//set u4[id]=$EB*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04M')
			t4[id] = $A5;//set t4[id]=$A5
			u4[id] = $A5*.2/ 100.;//set u4[id]=$A5*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04L')
			t4[id] = $BE;//set t4[id]=$BE
			u4[id] = $BE*.2/ 100.;//set u4[id]=$BE*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04N')
			t4[id] = $BE;//set t4[id]=$BE
			u4[id] = $BE*.2/ 100.;//set u4[id]=$BE*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825257511);//set id=GetUnitPointValueByType('n01J')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.08/ 100.;//set u4[id]=$C8*.08/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h09Y')
			t4[id] = 500;//set t4[id]=500
			u4[id] = 500*.2/ 100.;//set u4[id]=500*.2/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04T')
			t4[id] = 500;//set t4[id]=500
			u4[id] = 500*.12/ 100.;//set u4[id]=500*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04R')
			t4[id] = 260;//set t4[id]=260
			u4[id] = 260*.09/ 100.;//set u4[id]=260*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04K')
			t4[id] = 275;//set t4[id]=275
			u4[id] = 275*.09/ 100.;//set u4[id]=275*.09/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void Corrupted___RegisterUnitCasts() {//function Corrupted___RegisterUnitCasts takes nothing returns nothing
			Lj('n027', 'A0AE', function Wu);//call Lj('n027','A0AE',function Wu)
		}//endfunction
		private void gv() {//function gv takes nothing returns nothing
			ev();//call ev()
			fv();//call fv()
			Lj('n027', 'A0AE', function Wu);//call Lj('n027','A0AE',function Wu)
		}//endfunction
		private bool hv() {//function hv takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = IsUnitType(u,UNIT_TYPE_FLYING) && GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && !IsUnitType(u,UNIT_TYPE_MECHANICAL);//local boolean Im=IsUnitType(u,UNIT_TYPE_FLYING)and GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and not IsUnitType(u,UNIT_TYPE_MECHANICAL)
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void iv() {//function iv takes nothing returns nothing
			float x;//local real x
			float y;//local real y
			int i = 0;//local integer i=0
			unit t;//local unit t
			unit c;//local unit c
			r4 = GetOwningPlayer(c4);//set r4=GetOwningPlayer(c4)
			x = GetUnitX(c4);//set x=GetUnitX(c4)
			y = GetUnitY(c4);//set y=GetUnitY(c4)
			GroupEnumUnitsInRange(q4, GetUnitX(D4), GetUnitY(D4), 400., ef);//call GroupEnumUnitsInRange(q4,GetUnitX(D4),GetUnitY(D4),400.,ef)
			while (true) {//loop
				t = FirstOfGroup(q4);//set t=FirstOfGroup(q4)
				i = i+1;//set i=i+1
				if (i>4 || t==null) { break; }//exitwhen i>4 or t==null
				GroupRemoveUnit(q4, t);//call GroupRemoveUnit(q4,t)
				c = CreateUnit(GetOwningPlayer(c4),808477991,x,y,.0);//set c=CreateUnit(GetOwningPlayer(c4),'e008',x,y,.0)
				UnitAddAbility(c, 'A08U');//call UnitAddAbility(c,'A08U')
				IssueTargetOrderById(c, $D007F, t);//call IssueTargetOrderById(c,$D007F,t)
				UnitApplyTimedLife(c, 'BTLF', 3.);//call UnitApplyTimedLife(c,'BTLF',3.)
			}//endloop
			t = null;//set t=null
			c = null;//set c=null
		}//endfunction
		private void jv() {//function jv takes nothing returns nothing
			unit c;//local unit c
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null || Hr(bj_groupRandomCurrentPick))) {//if(bj_groupRandomCurrentPick==null or Hr(bj_groupRandomCurrentPick))then
				return;//return
			}//endif
			c = CreateUnit(r4,808477991,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);//set c=CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0)
			UnitAddAbility(c, 'A018');//call UnitAddAbility(c,'A018')
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
			IssueTargetOrderById(c, $D0216, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D0216,bj_groupRandomCurrentPick)
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = bj_groupRandomCurrentPick;//set c=bj_groupRandomCurrentPick
			TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			Po(c);//call Po(c)
			if ((GetUnitTypeId(c)==858810407)) {//if(GetUnitTypeId(c)=='h03A')then
				TriggerSleepAction(44.5);//call TriggerSleepAction(44.5)
				IssueImmediateOrderById(c, $D0057);//call IssueImmediateOrderById(c,$D0057)
				TriggerSleepAction(.5);//call TriggerSleepAction(.5)
				Po(c);//call Po(c)
			}//endif
			c = null;//set c=null
		}//endfunction
		private void kv() {//function kv takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//local unit c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(c, 'A0A8');//call UnitAddAbility(c,'A0A8')
			IssueTargetOrderById(c, $D0215, D4);//call IssueTargetOrderById(c,$D0215,D4)
			UnitApplyTimedLife(c, 'BTLF', 2.);//call UnitApplyTimedLife(c,'BTLF',2.)
			c = c4;//set c=c4
			TriggerSleepAction(.8);//call TriggerSleepAction(.8)
			Po(c);//call Po(c)
			c = null;//set c=null
		}//endfunction
		private void mv() {//function mv takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//local unit c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(c, 'A00Y');//call UnitAddAbility(c,'A00Y')
			IssueTargetOrderById(c, $D0215, D4);//call IssueTargetOrderById(c,$D0215,D4)
			UnitApplyTimedLife(c, 'BTLF', 2.);//call UnitApplyTimedLife(c,'BTLF',2.)
			c = c4;//set c=c4
			TriggerSleepAction(.8);//call TriggerSleepAction(.8)
			Po(c);//call Po(c)
			c = null;//set c=null
		}//endfunction
		private bool nv() {//function nv takes nothing returns boolean
			SetUnitVertexColor(z4, $FF, $FF, $FF, 0);//call SetUnitVertexColor(z4,$FF,$FF,$FF,0)
			Bj(z4, 'h08Z', 250., 46., 33.5);//call Bj(z4,'h08Z',250.,46.,33.5)
			Bj(z4, 'h090', 270., -17., 18.);//call Bj(z4,'h090',270.,-17.,18.)
			return false;//return false
		}//endfunction
		private bool ov() {//function ov takes nothing returns boolean
			SetUnitVertexColor(z4, $FF, $FF, $FF, 0);//call SetUnitVertexColor(z4,$FF,$FF,$FF,0)
			Bj(z4, 'h08Z', 250., 46., 33.5);//call Bj(z4,'h08Z',250.,46.,33.5)
			Bj(z4, 'h091', 270., -17., 18.);//call Bj(z4,'h091',270.,-17.,18.)
			Bj(z4, 'h08Z', 350., -22., -40.);//call Bj(z4,'h08Z',350.,-22.,-40.)
			return false;//return false
		}//endfunction
		private void pv() {//function pv takes nothing returns nothing
			lj('h00Z', function jv);//call lj('h00Z',function jv)
			Ij('h014', 675.);//call Ij('h014',675.)
			zj('h09X', 'h07B');//call zj('h09X','h07B')
			zj('h00X', 'h00W');//call zj('h00X','h00W')
			zj('h00V', 'h00U');//call zj('h00V','h00U')
			zj('h00T', 'n006');//call zj('h00T','n006')
			zj('h03F', 'n00Y');//call zj('h03F','n00Y')
			zj('h08X', 'n022');//call zj('h08X','n022')
			Fj('h08X', function nv);//call Fj('h08X',function nv)
			zj('h08Y', 'n023');//call zj('h08Y','n023')
			Fj('h08Y', function ov);//call Fj('h08Y',function ov)
			zj('h070', 'e005');//call zj('h070','e005')
			zj('h06Y', 'n01Y');//call zj('h06Y','n01Y')
		}//endfunction
		private void qv() {//function qv takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h09X')
			t4[id] = 360;//set t4[id]=360
			u4[id] = 360*.2/ 100.;//set u4[id]=360*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00V')
			t4[id] = 275;//set t4[id]=275
			u4[id] = 275*.2/ 100.;//set u4[id]=275*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00T')
			t4[id] = $DC;//set t4[id]=$DC
			u4[id] = $DC*.2/ 100.;//set u4[id]=$DC*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03F')
			t4[id] = $E6;//set t4[id]=$E6
			u4[id] = $E6*.2/ 100.;//set u4[id]=$E6*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(942696487);//set id=GetUnitPointValueByType('h08X')
			t4[id] = $B4;//set t4[id]=$B4
			u4[id] = $B4*.2/ 100.;//set u4[id]=$B4*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(942696487);//set id=GetUnitPointValueByType('h08Y')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(925919271);//set id=GetUnitPointValueByType('h070')
			t4[id] = 350;//set t4[id]=350
			u4[id] = 350*.18/ 100.;//set u4[id]=350*.18/ 100.
			v4[id] = true;//set v4[id]=true
			w4[id] = true;//set w4[id]=true
			id = GetUnitPointValueByType(909142055);//set id=GetUnitPointValueByType('h06Y')
			t4[id] = 310;//set t4[id]=310
			u4[id] = 310*.2/ 100.;//set u4[id]=310*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00Z')
			t4[id] = $F0;//set t4[id]=$F0
			u4[id] = $F0*.12/ 100.;//set u4[id]=$F0*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00X')
			t4[id] = 440;//set t4[id]=440
			u4[id] = 440*.2/ 100.;//set u4[id]=440*.2/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h059')
			t4[id] = 650;//set t4[id]=650
			u4[id] = 650*.12/ 100.;//set u4[id]=650*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h005')
			t4[id] = $FA;//set t4[id]=$FA
			u4[id] = $FA*.12/ 100.;//set u4[id]=$FA*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h014')
			t4[id] = $FA;//set t4[id]=$FA
			u4[id] = $FA*.08/ 100.;//set u4[id]=$FA*.08/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void rv() {//function rv takes nothing returns nothing
			Lj('n01Y', 'A08V', function iv);//call Lj('n01Y','A08V',function iv)
			Lj('h07B', 'A0A7', function kv);//call Lj('h07B','A0A7',function kv)
			Lj('h00W', 'A00X', function mv);//call Lj('h00W','A00X',function mv)
		}//endfunction
		private void sv(player p) {//function sv takes player p returns nothing
			int id = me[GetPlayerId(p)];//local integer id=me[GetPlayerId(p)]
			ld[id] = ld[id]+(20);//set ld[id]=ld[id]+(20)
		}//endfunction
		private void tv(unit u) {//function tv takes unit u returns nothing
			int id = me[GetPlayerId(GetOwningPlayer(u))];//local integer id=me[GetPlayerId(GetOwningPlayer(u))]
			ld[id] = ld[id]-(20);//set ld[id]=ld[id]-(20)
		}//endfunction
		private void uv() {//function uv takes nothing returns nothing
			pv();//call pv()
			qv();//call qv()
			rv();//call rv()
			ef = Filter(function hv);//set ef=Filter(function hv)
		}//endfunction
		private void vv() {//function vv takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u=GetEnumUnit()
			unit c = CreateUnit(r4,808477991,GetUnitX(u),GetUnitY(u),.0);//local unit c=CreateUnit(r4,'e008',GetUnitX(u),GetUnitY(u),.0)
			UnitAddAbility(c, 'A016');//call UnitAddAbility(c,'A016')
			IssueTargetOrderById(c, $D0085, u);//call IssueTargetOrderById(c,$D0085,u)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = null;//set c=null
			u = null;//set u=null
		}//endfunction
		private void wv() {//function wv takes nothing returns nothing
			float x = GetUnitX(B4);//local real x=GetUnitX(B4)
			float y = GetUnitY(B4);//local real y=GetUnitY(B4)
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\HowlOfTerror\\HowlCaster.mdl", x, y));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Other\\HowlOfTerror\\HowlCaster.mdl",x,y))
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRange(q4, x, y, 500., gf);//call GroupEnumUnitsInRange(q4,x,y,500.,gf)
			ForGroup(q4, function vv);//call ForGroup(q4,function vv)
		}//endfunction
		private void xv() {//function xv takes nothing returns nothing
			unit u = c4;//local unit u=c4
			IssueTargetOrderById(u, $D0062, D4);//call IssueTargetOrderById(u,$D0062,D4)
			TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			Po(u);//call Po(u)
			u = null;//set u=null
		}//endfunction
		private bool yv() {//function yv takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = IsUnitAlly(u,r4) && GetWidgetLife(u)<.405 && !IsUnitType(u,UNIT_TYPE_MECHANICAL);//local boolean Im=IsUnitAlly(u,r4)and GetWidgetLife(u)<.405 and not IsUnitType(u,UNIT_TYPE_MECHANICAL)
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void zv() {//function zv takes nothing returns nothing
			unit u = c4;//local unit u=c4
			IssueTargetOrderById(u, $D0062, D4);//call IssueTargetOrderById(u,$D0062,D4)
			UnitAddAbility(D4, 'A03L');//call UnitAddAbility(D4,'A03L')
			TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			r4 = GetOwningPlayer(u);//set r4=GetOwningPlayer(u)
			GroupEnumUnitsInRange(q4, GetUnitX(u), GetUnitY(u), 900., hf);//call GroupEnumUnitsInRange(q4,GetUnitX(u),GetUnitY(u),900.,hf)
			if ((FirstOfGroup(q4)!=null)) {//if(FirstOfGroup(q4)!=null)then
				IssueImmediateOrderById(u, $D007E);//call IssueImmediateOrderById(u,$D007E)
				TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			}//endif
			Po(u);//call Po(u)
			u = null;//set u=null
		}//endfunction
		private void Av() {//function Av takes nothing returns nothing
			unit u = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//local unit u=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(u, 'A00I');//call UnitAddAbility(u,'A00I')
			IssueImmediateOrderById(u, $D022E);//call IssueImmediateOrderById(u,$D022E)
			UnitApplyTimedLife(u, 'BTLF', 1.);//call UnitApplyTimedLife(u,'BTLF',1.)
			u = c4;//set u=c4
			UnitRemoveAbility(u, 'A00F');//call UnitRemoveAbility(u,'A00F')
			UnitAddAbility(u, 'A07I');//call UnitAddAbility(u,'A07I')
			TriggerSleepAction(.3);//call TriggerSleepAction(.3)
			br(u);//call br(u)
			TriggerSleepAction(5.);//call TriggerSleepAction(5.)
			if ((GetUnitAbilityLevel(u,808468775)<=0)) {//if(GetUnitAbilityLevel(u,'A00F')<=0)then
				IssueImmediateOrderById(u, $D0019);//call IssueImmediateOrderById(u,$D0019)
				TriggerSleepAction(6.6);//call TriggerSleepAction(6.6)
				if ((GetUnitAbilityLevel(u,808468775)<=0)) {//if(GetUnitAbilityLevel(u,'A00F')<=0)then
					UnitAddAbility(u, 'A00F');//call UnitAddAbility(u,'A00F')
					UnitRemoveAbility(u, 'A07I');//call UnitRemoveAbility(u,'A07I')
					UnitAddAbility(u, 'A0EZ');//call UnitAddAbility(u,'A0EZ')
					Po(u);//call Po(u)
				}//endif
			}//endif
			u = null;//set u=null
		}//endfunction
		private bool av() {//function av takes nothing returns boolean
			SetUnitVertexColor(z4, $FF, $FF, $FF, 0);//call SetUnitVertexColor(z4,$FF,$FF,$FF,0)
			Bj(z4, 'h0A0', 170., 31.25, -43.);//call Bj(z4,'h0A0',170.,31.25,-43.)
			Bj(z4, 'h0A0', 80., -38., -40.25);//call Bj(z4,'h0A0',80.,-38.,-40.25)
			Bj(z4, 'h0A0', 350., -30.25, 30.);//call Bj(z4,'h0A0',350.,-30.25,30.)
			Bj(z4, 'h08Z', 220., 43., 27.5);//call Bj(z4,'h08Z',220.,43.,27.5)
			return false;//return false
		}//endfunction
		private void Bv() {//function Bv takes nothing returns nothing
			zj('h000', 'hfoo');//call zj('h000','hfoo')
			zj('h039', 'h03A');//call zj('h039','h03A')
			zj('h003', 'hrif');//call zj('h003','hrif')
			zj('h0A1', 'h05C');//call zj('h0A1','h05C')
			Fj('h0A1', function av);//call Fj('h0A1',function av)
			zj('h05D', 'h0A2');//call zj('h05D','h0A2')
			zj('h004', 'hmtm');//call zj('h004','hmtm')
			Ij('h006', 950.);//call Ij('h006',950.)
			zj('h00K', 'n005');//call zj('h00K','n005')
			Ij('h010', 500.);//call Ij('h010',500.)
			lj('h010', function wv);//call lj('h010',function wv)
			zj('h015', 'h016');//call zj('h015','h016')
			zj('h037', 'h03B');//call zj('h037','h03B')
			zj('h038', 'h03C');//call zj('h038','h03C')
		}//endfunction
		private void bv() {//function bv takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h037')
			t4[id] = 265;//set t4[id]=265
			u4[id] = 265*.2/ 100.;//set u4[id]=265*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h015')
			t4[id] = $FA;//set t4[id]=$FA
			u4[id] = $FA*.2/ 100.;//set u4[id]=$FA*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00K')
			t4[id] = 300;//set t4[id]=300
			u4[id] = 300*.2/ 100.;//set u4[id]=300*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h004')
			t4[id] = $D2;//set t4[id]=$D2
			u4[id] = $D2*.18/ 100.;//set u4[id]=$D2*.18/ 100.
			v4[id] = true;//set v4[id]=true
			w4[id] = true;//set w4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h003')
			t4[id] = $8C;//set t4[id]=$8C
			u4[id] = $8C*.2/ 100.;//set u4[id]=$8C*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h000')
			t4[id] = 'd';//set t4[id]='d'
			u4[id] = 'd'*.2/ 100.;//set u4[id]='d'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h039')
			t4[id] = $AF;//set t4[id]=$AF
			u4[id] = $AF*.2/ 100.;//set u4[id]=$AF*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(1093691431);//set id=GetUnitPointValueByType('h0A1')
			t4[id] = $A0;//set t4[id]=$A0
			u4[id] = $A0*.2/ 100.;//set u4[id]=$A0*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05D')
			t4[id] = $B4;//set t4[id]=$B4
			u4[id] = $B4*.2/ 100.;//set u4[id]=$B4*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h038')
			t4[id] = 260;//set t4[id]=260
			u4[id] = 260*.2/ 100.;//set u4[id]=260*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h001')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.09/ 100.;//set u4[id]=$C8*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h006')
			t4[id] = $96;//set t4[id]=$96
			u4[id] = $96*.08/ 100.;//set u4[id]=$96*.08/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h010')
			t4[id] = $E1;//set t4[id]=$E1
			u4[id] = $E1*.12/ 100.;//set u4[id]=$E1*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05G')
			t4[id] = 550;//set t4[id]=550
			u4[id] = 550*.12/ 100.;//set u4[id]=550*.12/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void Cv() {//function Cv takes nothing returns nothing
			Lj('h03B', 'A03K', function xv);//call Lj('h03B','A03K',function xv)
			Lj('h03C', 'A03K', function zv);//call Lj('h03C','A03K',function zv)
			Lj('n005', 'A00K', function Av);//call Lj('n005','A00K',function Av)
		}//endfunction
		private void cv(unit u) {//function cv takes unit u returns nothing
			rect r = Ld[me[GetPlayerId(GetOwningPlayer(u))]];//local rect r=Ld[me[GetPlayerId(GetOwningPlayer(u))]]
			IssuePointOrderById(u, $D0010, GetRandomReal(GetRectMinX(r), GetRectMaxX(r)), GetRandomReal(GetRectMinY(r), GetRectMaxY(r)));//call IssuePointOrderById(u,$D0010,GetRandomReal(GetRectMinX(r),GetRectMaxX(r)),GetRandomReal(GetRectMinY(r),GetRectMaxY(r)))
			r = null;//set r=null
		}//endfunction
		private void Dv() {//function Dv takes nothing returns nothing
			cv(GetEnumUnit());//call cv(GetEnumUnit())
		}//endfunction
		private void Ev() {//function Ev takes nothing returns nothing
			ForGroup(ff, function Dv);//call ForGroup(ff,function Dv)
		}//endfunction
		private void Fv(unit u) {//function Fv takes unit u returns nothing
			GroupAddUnit(Jd[me[GetPlayerId(GetOwningPlayer(u))]], u);//call GroupAddUnit(Jd[me[GetPlayerId(GetOwningPlayer(u))]],u)
		}//endfunction
		private void Gv(unit u) {//function Gv takes unit u returns nothing
			GroupRemoveUnit(Jd[me[GetPlayerId(GetOwningPlayer(u))]], u);//call GroupRemoveUnit(Jd[me[GetPlayerId(GetOwningPlayer(u))]],u)
		}//endfunction
		private bool Hv() {//function Hv takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER);//local boolean Im=GetWidgetLife(u)>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void Iv() {//function Iv takes nothing returns nothing
			Bv();//call Bv()
			bv();//call bv()
			Cv();//call Cv()
			TimerStart(CreateTimer(), 9., true, function Ev);//call TimerStart(CreateTimer(),9.,true,function Ev)
			hf = Filter(function yv);//set hf=Filter(function yv)
			gf = Filter(function Hv);//set gf=Filter(function Hv)
		}//endfunction
		private float lv(int x) {//function lv takes integer x returns real
			if ((x<$A)) {//if(x<$A)then
				return pf[x]*.25+1.;//return pf[x]*.25+1.
			}//endif
			return ((((I2R(x-9))*.25)+5.11)*.25)+1.;//return((((I2R(x-9))*.25)+5.11)*.25)+1.
		}//endfunction
		private float Jv(int dk) {//function Jv takes integer dk returns real
			return (mf[(dk)]*10.)*lv(ge[dk]);//return(mf[(dk)]*10.)*lv(ge[dk])
		}//endfunction
		private int Kv(int dk) {//function Kv takes integer dk returns integer
			float i = Jv(dk);//local real i=Jv(dk)
			float j = .0;//local real j=.0
			float k = .0;//local real k=.0
			while (true) {//loop
				if ((i<kf) || (k>=8)) { break; }//exitwhen(i<kf)or(k>=8)
				i = i-kf;//set i=i-kf
				j = j+kf*(1.-k/ 10.);//set j=j+kf*(1.-k/ 10.)
				k = k+1.;//set k=k+1.
			}//endloop
			j = j+i*(1.-k/ 10.);//set j=j+i*(1.-k/ 10.)
			return R2I(j*i8[me[dk]]);//return R2I(j*i8[me[dk]])
		}//endfunction
		private void Lv(int dk, unit u) {//function Lv takes integer dk,unit u returns nothing
			float l = u4[GetUnitPointValue(u)];//local real l=u4[GetUnitPointValue(u)]
			int aj = GetHandleId(u);//local integer aj=GetHandleId(u)
			mf[dk] = mf[dk]+(l);//set mf[dk]=mf[dk]+(l)
			SaveReal(O9, aj, $A, LoadReal(O9, aj, $A)+l);//call SaveReal(O9,aj,$A,LoadReal(O9,aj,$A)+l)
		}//endfunction
		private void Mv(int dk, unit u) {//function Mv takes integer dk,unit u returns nothing
			mf[dk] = mf[dk]-(LoadReal(O9,GetHandleId(u),$A));//set mf[dk]=mf[dk]-(LoadReal(O9,GetHandleId(u),$A))
		}//endfunction
		private void Nv(int dk, unit u) {//function Nv takes integer dk,unit u returns nothing
			mf[dk] = mf[dk]+(LoadReal(O9,GetHandleId(u),$A));//set mf[dk]=mf[dk]+(LoadReal(O9,GetHandleId(u),$A))
		}//endfunction
		private void Ov() {//function Ov takes nothing returns nothing
			of = of+(" "+I2S(nf[GetPlayerId(GetEnumPlayer())]));//set of=of+(" "+I2S(nf[GetPlayerId(GetEnumPlayer())]))
		}//endfunction
		private void Pv() {//function Pv takes nothing returns nothing
			player p = GetEnumPlayer();//local player p=GetEnumPlayer()
			int id = GetPlayerId(p);//local integer id=GetPlayerId(p)
			int ws = Kv(id);//local integer ws=Kv(id)
			Vd[id] = Vd[id]+(ws);//set Vd[id]=Vd[id]+(ws)
			SetPlayerState(p, PLAYER_STATE_RESOURCE_GOLD, GetPlayerState(p, PLAYER_STATE_RESOURCE_GOLD)+ws);//call SetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD,GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)+ws)
			SetPlayerState(p, PLAYER_STATE_GOLD_GATHERED, GetPlayerState(p, PLAYER_STATE_GOLD_GATHERED)+ws);//call SetPlayerState(p,PLAYER_STATE_GOLD_GATHERED,GetPlayerState(p,PLAYER_STATE_GOLD_GATHERED)+ws)
			nf[id] = ws;//set nf[id]=ws
			qf = qf+(ws);//set qf=qf+(ws)
		}//endfunction
		private void Qv() {//function Qv takes nothing returns nothing
			int i = 0;//local integer i=0
			qf = 0;//set qf=0
			ForForce(ie, function Pv);//call ForForce(ie,function Pv)
			Yr(4, 1, I2S(qf));//call Yr(4,1,I2S(qf))
			qf = 0;//set qf=0
			ForForce(je, function Pv);//call ForForce(je,function Pv)
			Yr(4, 2, I2S(qf));//call Yr(4,2,I2S(qf))
			while (true) {//loop
				if ((nf[i]>0)) {//if(nf[i]>0)then
					of = "Income: |cffFFFF00"+I2S(nf[i]);//set of="Income: |cffFFFF00"+I2S(nf[i])
					if ((ne[i]!=null)) {//if(ne[i]!=null)then
						ForForce(ne[i], function Ov);//call ForForce(ne[i],function Ov)
					}//endif
					DisplayTextToPlayer(Player(i), 0, 0, of);//call DisplayTextToPlayer(Player(i),0,0,of)
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void Rv(player p) {//function Rv takes player p returns nothing
			int dk = GetPlayerId(p);//local integer dk=GetPlayerId(p)
			string s = "Your basic income is |cffFFFF00"+I2S(R2I((mf[(dk)]*10.)));//local string s="Your basic income is |cffFFFF00"+I2S(R2I((mf[(dk)]*10.)))
			s = s+("|r. Your Treasure Box income multiplier is |cffFFFF00"+R2SW(lv(ge[dk]),1,2));//set s=s+("|r. Your Treasure Box income multiplier is |cffFFFF00"+R2SW(lv(ge[dk]),1,2))
			s = s+("|r, boosting your income to |cffFFFF00"+I2S(R2I(Jv(dk))));//set s=s+("|r, boosting your income to |cffFFFF00"+I2S(R2I(Jv(dk))))
			s = s+("|r. After paying taxes your income is |cffFFFF00"+I2S(nf[dk])+"|r.");//set s=s+("|r. After paying taxes your income is |cffFFFF00"+I2S(nf[dk])+"|r.")
			DisplayTextToPlayer(p, .0, .0, s);//call DisplayTextToPlayer(p,.0,.0,s)
		}//endfunction
		private void Sv(player p) {//function Sv takes player p returns nothing
			int id = GetPlayerId(p);//local integer id=GetPlayerId(p)
			DisplayTimedTextToPlayer(p, .0, .0, 15., "-------- Current statistics: --------");//call DisplayTimedTextToPlayer(p,.0,.0,15.,"-------- Current statistics: --------")
			DisplayTimedTextToPlayer(p, .0, .0, 15., "Income: |cffFFFF00"+I2S(Kv(id))+"|r (|cffFFFF00"+I2S(Vd[id])+"|r gold in total)");//call DisplayTimedTextToPlayer(p,.0,.0,15.,"Income: |cffFFFF00"+I2S(Kv(id))+"|r (|cffFFFF00"+I2S(Vd[id])+"|r gold in total)")
			if ((Cd>0)) {//if(Cd>0)then
				DisplayTimedTextToPlayer(p, .0, .0, 15., "Coins collected: |cffFFFF00"+I2S(Yd[id])+"|r (|cffFFFF00"+I2S(Zd[id])+"|r gold in total)");//call DisplayTimedTextToPlayer(p,.0,.0,15.,"Coins collected: |cffFFFF00"+I2S(Yd[id])+"|r (|cffFFFF00"+I2S(Zd[id])+"|r gold in total)")
			}//endif
			DisplayTimedTextToPlayer(p, .0, .0, 15., "Units killed: |cffFFFF00"+I2S(Sd[id])+"|r (|cffFFFF00"+I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_GOLD)+ee[id]+fe[id]-de[id]-Vd[id]-Zd[id]-$FA)+"|r gold in total)");//call DisplayTimedTextToPlayer(p,.0,.0,15.,"Units killed: |cffFFFF00"+I2S(Sd[id])+"|r (|cffFFFF00"+I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)+ee[id]+fe[id]-de[id]-Vd[id]-Zd[id]-$FA)+"|r gold in total)")
			DisplayTimedTextToPlayer(p, .0, .0, 15., "Units trained: |cffFFFF00"+I2S(Rd[id])+"|r (|cffFFFF00"+I2S(Td[id])+"|r creepspawning buildings in total)");//call DisplayTimedTextToPlayer(p,.0,.0,15.,"Units trained: |cffFFFF00"+I2S(Rd[id])+"|r (|cffFFFF00"+I2S(Td[id])+"|r creepspawning buildings in total)")
			DisplayTimedTextToPlayer(p, .0, .0, 15., "Specials built: |cffFFFF00"+I2S(Ud[id])+"|r");//call DisplayTimedTextToPlayer(p,.0,.0,15.,"Specials built: |cffFFFF00"+I2S(Ud[id])+"|r")
			DisplayTimedTextToPlayer(p, .0, .0, 15., "Rescue Strike damage: |cffFFFF00"+I2S(Wd[id])+"|r (|cffFFFF00"+I2S(Xd[id])+"|r units killed)");//call DisplayTimedTextToPlayer(p,.0,.0,15.,"Rescue Strike damage: |cffFFFF00"+I2S(Wd[id])+"|r (|cffFFFF00"+I2S(Xd[id])+"|r units killed)")
			DisplayTimedTextToPlayer(p, .0, .0, 15., "----------------------------------------------------");//call DisplayTimedTextToPlayer(p,.0,.0,15.,"----------------------------------------------------")
		}//endfunction
		private int Tv() {//function Tv takes nothing returns integer
			int j = 0;//local integer j=0
			int i = 1;//local integer i=1
			while (true) {//loop
				if ((Wd[i]>Wd[j])) {//if(Wd[i]>Wd[j])then
					j = i;//set j=i
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			return j;//return j
		}//endfunction
		private int Uv() {//function Uv takes nothing returns integer
			int j = 0;//local integer j=0
			int i = 1;//local integer i=1
			while (true) {//loop
				if ((Ud[i]>Ud[j])) {//if(Ud[i]>Ud[j])then
					j = i;//set j=i
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			return Ud[j];//return Ud[j]
		}//endfunction
		private int Vv() {//function Vv takes nothing returns integer
			int j = 0;//local integer j=0
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((Td[j]>Td[i])) {//if(Td[j]>Td[i])then
					i = j;//set i=j
				}//endif
				j = j+1;//set j=j+1
				if (j>$B) { break; }//exitwhen j>$B
			}//endloop
			return j;//return j
		}//endfunction
		private int Wv() {//function Wv takes nothing returns integer
			int j = 0;//local integer j=0
			int i = 1;//local integer i=1
			while (true) {//loop
				if ((Sd[i]>Sd[j])) {//if(Sd[i]>Sd[j])then
					j = i;//set j=i
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			return j;//return j
		}//endfunction
		private int Xv() {//function Xv takes nothing returns integer
			int j = 0;//local integer j=0
			int i = 1;//local integer i=1
			while (true) {//loop
				if ((Yd[i]>Yd[j])) {//if(Yd[i]>Yd[j])then
					j = i;//set j=i
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			return j;//return j
		}//endfunction
		private int Yv() {//function Yv takes nothing returns integer
			int j = 0;//local integer j=0
			int v = Kv(0);//local integer v=Kv(0)
			int i = 1;//local integer i=1
			int t;//local integer t
			while (true) {//loop
				t = Kv(i);//set t=Kv(i)
				if ((t>v)) {//if(t>v)then
					v = t;//set v=t
					j = i;//set j=i
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			return j;//return j
		}//endfunction
		private void Zv() {//function Zv takes nothing returns nothing
			string s;//local string s
			string t;//local string t
			int g;//local integer g
			int i;//local integer i
			player p;//local player p
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "|cffFFFF80-----------  End of round statistics  -----------|r");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,20.,"|cffFFFF80-----------  End of round statistics  -----------|r")
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Round time: "+ds());//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,20.,"Round time: "+ds())
			g = Kv(Yv());//set g=Kv(Yv())
			s = "";//set s=""
			i = 0;//set i=0
			while (true) {//loop
				if ((Kv(i)==g)) {//if(Kv(i)==g)then
					if ((s=="")) {//if(s=="")then
						s = pe[i];//set s=pe[i]
						t = I2S(Vd[i]);//set t=I2S(Vd[i])
					} else {//else
						s = s+", "+pe[i];//set s=s+", "+pe[i]
						t = t+"|r, |cffFFFF00"+I2S(Vd[i]);//set t=t+"|r, |cffFFFF00"+I2S(Vd[i])
					}//endif
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Highest income: "+s+" - |cffFFFF00"+I2S(g)+"|r (|cffFFFF00"+t+"|r gold in total)");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,20.,"Highest income: "+s+" - |cffFFFF00"+I2S(g)+"|r (|cffFFFF00"+t+"|r gold in total)")
			if ((Cd>0)) {//if(Cd>0)then
				g = Xv();//set g=Xv()
				s = "";//set s=""
				i = 0;//set i=0
				while (true) {//loop
					p = Player(i);//set p=Player(i)
					if ((Yd[i]==Yd[g])) {//if(Yd[i]==Yd[g])then
						if ((s=="")) {//if(s=="")then
							s = pe[i];//set s=pe[i]
							t = I2S(Zd[i]);//set t=I2S(Zd[i])
						} else {//else
							s = s+", "+pe[i];//set s=s+", "+pe[i]
							t = t+"|r, |cffFFFF00"+I2S(Zd[i]);//set t=t+"|r, |cffFFFF00"+I2S(Zd[i])
						}//endif
					}//endif
					i = i+1;//set i=i+1
					if (i>$B) { break; }//exitwhen i>$B
				}//endloop
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Most coins collected: "+s+" - |cffFFFF00"+I2S(Yd[g])+"|r (|cffFFFF00"+t+"|r gold in total)");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,20.,"Most coins collected: "+s+" - |cffFFFF00"+I2S(Yd[g])+"|r (|cffFFFF00"+t+"|r gold in total)")
			}//endif
			g = Wv();//set g=Wv()
			s = "";//set s=""
			i = 0;//set i=0
			while (true) {//loop
				p = Player(i);//set p=Player(i)
				if ((Sd[i]==Sd[g])) {//if(Sd[i]==Sd[g])then
					if ((s=="")) {//if(s=="")then
						s = pe[i];//set s=pe[i]
						t = I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)+ee[i]+fe[i]-de[i]-Vd[i]-Zd[i]-$FA);//set t=I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)+ee[i]+fe[i]-de[i]-Vd[i]-Zd[i]-$FA)
					} else {//else
						s = s+", "+pe[i];//set s=s+", "+pe[i]
						t = t+"|r, |cffFFFF00"+I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)+ee[i]+fe[i]-de[i]-Vd[i]-Zd[i]-$FA);//set t=t+"|r, |cffFFFF00"+I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)+ee[i]+fe[i]-de[i]-Vd[i]-Zd[i]-$FA)
					}//endif
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			s = "Most units killed: "+s+" - |cffFFFF00"+I2S(Sd[g])+"|r";//set s="Most units killed: "+s+" - |cffFFFF00"+I2S(Sd[g])+"|r"
			if ((od)) {//if(od)then
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., s);//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,20.,s)
			} else {//else
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., s+" (|cffFFFF00"+t+"|r gold in total)");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,20.,s+" (|cffFFFF00"+t+"|r gold in total)")
			}//endif
			g = Td[Vv()];//set g=Td[Vv()]
			s = "";//set s=""
			i = 0;//set i=0
			while (true) {//loop
				if ((Td[i]==Td[g])) {//if(Td[i]==Td[g])then
					if ((s=="")) {//if(s=="")then
						s = pe[i];//set s=pe[i]
						t = I2S(Rd[i]);//set t=I2S(Rd[i])
					} else {//else
						s = s+", "+pe[i];//set s=s+", "+pe[i]
						t = t+"|r, |cffFFFF00"+I2S(Rd[i]);//set t=t+"|r, |cffFFFF00"+I2S(Rd[i])
					}//endif
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Most creepspawning buildings: "+s+" - |cffFFFF00"+I2S(Td[g])+"|r (|cffFFFF00"+t+"|r units in total)");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,20.,"Most creepspawning buildings: "+s+" - |cffFFFF00"+I2S(Td[g])+"|r (|cffFFFF00"+t+"|r units in total)")
			if ((pd)) {//if(pd)then
				g = Uv();//set g=Uv()
				s = "";//set s=""
				i = 0;//set i=0
				while (true) {//loop
					if ((Ud[i]==g)) {//if(Ud[i]==g)then
						if ((s=="")) {//if(s=="")then
							s = pe[i];//set s=pe[i]
						} else {//else
							s = s+", "+pe[i];//set s=s+", "+pe[i]
						}//endif
					}//endif
					i = i+1;//set i=i+1
					if (i>$B) { break; }//exitwhen i>$B
				}//endloop
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Most special buildings: "+s+" - |cffFFFF00"+I2S(g)+"|r");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,20.,"Most special buildings: "+s+" - |cffFFFF00"+I2S(g)+"|r")
			}//endif
			g = Tv();//set g=Tv()
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "Most damage dealt with RS: "+pe[g]+" - |cffFFFF00"+I2S(Wd[g])+"|r (|cffFFFF00"+I2S(Xd[g])+"|r units killed)");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,20.,"Most damage dealt with RS: "+pe[g]+" - |cffFFFF00"+I2S(Wd[g])+"|r (|cffFFFF00"+I2S(Xd[g])+"|r units killed)")
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 20., "|cffFFFF80--------------------------------------------------------------------|r");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,20.,"|cffFFFF80--------------------------------------------------------------------|r")
		}//endfunction
		private void dw() {//function dw takes nothing returns nothing
			pf[0] = .0;//set pf[0]=.0
			pf[1] = 1.;//set pf[1]=1.
			pf[2] = 1.85;//set pf[2]=1.85
			pf[3] = 2.57;//set pf[3]=2.57
			pf[4] = 3.18;//set pf[4]=3.18
			pf[5] = 3.7;//set pf[5]=3.7
			pf[6] = 4.14;//set pf[6]=4.14
			pf[7] = 4.52;//set pf[7]=4.52
			pf[8] = 4.84;//set pf[8]=4.84
			pf[9] = 5.11;//set pf[9]=5.11
			i8[0] = 1.;//set i8[0]=1.
			i8[1] = 1.;//set i8[1]=1.
		}//endfunction
		private bool ew() {//function ew takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,1970684199)<=0 && GetUnitAbilityLevel(u,959463719)<=0;//local boolean Im=GetWidgetLife(u)>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and GetUnitAbilityLevel(u,'Avul')<=0 and GetUnitAbilityLevel(u,'A09L')<=0
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void fw() {//function fw takes nothing returns nothing
			unit u;//local unit u
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			if ((yd)) {//if(yd)then
				Pj("SE:MC:SA "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));//call Pj("SE:MC:SA "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick))
				Rj();//call Rj()
			}//endif
			UnitAddAbility(bj_groupRandomCurrentPick, 'A09L');//call UnitAddAbility(bj_groupRandomCurrentPick,'A09L')
			u = B4;//set u=B4
			SetUnitAnimation(u, "death");//call SetUnitAnimation(u,"death")
			TriggerSleepAction(.3);//call TriggerSleepAction(.3)
			SetUnitAnimation(u, "stand");//call SetUnitAnimation(u,"stand")
			u = null;//set u=null
		}//endfunction
		private bool gw() {//function gw takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,1970684199)<=0;//local boolean Im=GetWidgetLife(u)>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and GetUnitAbilityLevel(u,'Avul')<=0
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void hw() {//function hw takes nothing returns nothing
			unit u;//local unit u
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, sf);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,sf)
			bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, tf);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,tf)
				bj_groupRandomCurrentPick = rn(q4);//set bj_groupRandomCurrentPick=rn(q4)
				if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
					return;//return
				}//endif
			} else {//else
				UnitAddAbility(bj_groupRandomCurrentPick, 'A09L');//call UnitAddAbility(bj_groupRandomCurrentPick,'A09L')
			}//endif
			if ((yd)) {//if(yd)then
				Pj("SE:MC:SA2 "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick));//call Pj("SE:MC:SA2 "+GetUnitName(B4)+" ->"+GetUnitName(bj_groupRandomCurrentPick))
				Rj();//call Rj()
			}//endif
			SetUnitAbilityLevel(bj_groupRandomCurrentPick, 'A09L', 2);//call SetUnitAbilityLevel(bj_groupRandomCurrentPick,'A09L',2)
			u = B4;//set u=B4
			SetUnitAnimation(u, "death");//call SetUnitAnimation(u,"death")
			TriggerSleepAction(.3);//call TriggerSleepAction(.3)
			SetUnitAnimation(u, "stand");//call SetUnitAnimation(u,"stand")
			u = null;//set u=null
		}//endfunction
		private void iw() {//function iw takes nothing returns nothing
			player p = GetOwningPlayer(c4);//local player p=GetOwningPlayer(c4)
			float x = GetUnitX(D4);//local real x=GetUnitX(D4)
			float y = GetUnitY(D4);//local real y=GetUnitY(D4)
			float sx = GetUnitX(c4);//local real sx=GetUnitX(c4)
			float sy = GetUnitY(c4);//local real sy=GetUnitY(c4)
			unit c = CreateUnit(p,959473703,sx,sy,.0);//local unit c=CreateUnit(p,'h09Q',sx,sy,.0)
			unit t;//local unit t
			if ((yd)) {//if(yd)then
				Pj("SE:MC:SG "+GetUnitName(c4)+" ->[no target]");//call Pj("SE:MC:SG "+GetUnitName(c4)+" ->[no target]")
				Rj();//call Rj()
			}//endif
			IssuePointOrderById(c, $D0010, x, y);//call IssuePointOrderById(c,$D0010,x,y)
			UnitApplyTimedLife(c, 'BTLF', 3.);//call UnitApplyTimedLife(c,'BTLF',3.)
			sx = sx-(x);//set sx=sx-(x)
			sy = sy-(y);//set sy=sy-(y)
			TriggerSleepAction(SquareRoot(sx*sx+sy*sy)/ 700.);//call TriggerSleepAction(SquareRoot(sx*sx+sy*sy)/ 700.)
			c = CreateUnit(p,808477991,x,y,.0);//set c=CreateUnit(p,'e008',x,y,.0)
			UnitAddAbility(c, 'A09E');//call UnitAddAbility(c,'A09E')
			IssueImmediateOrderById(c, $D0080);//call IssueImmediateOrderById(c,$D0080)
			UnitApplyTimedLife(c, 'BTLF', 3.);//call UnitApplyTimedLife(c,'BTLF',3.)
			r4 = p;//set r4=p
			GroupEnumUnitsInRange(q4, x, y, 300., x9);//call GroupEnumUnitsInRange(q4,x,y,300.,x9)
			while (true) {//loop
				t = FirstOfGroup(q4);//set t=FirstOfGroup(q4)
				if (t==null) { break; }//exitwhen t==null
				GroupRemoveUnit(q4, t);//call GroupRemoveUnit(q4,t)
				sx = GetUnitState(t,UNIT_STATE_MANA);//set sx=GetUnitState(t,UNIT_STATE_MANA)
				if ((sx>.0)) {//if(sx>.0)then
					sy = RMinBJ(sx,'d');//set sy=RMinBJ(sx,'d')
					SetUnitState(t, UNIT_STATE_MANA, sx-sy);//call SetUnitState(t,UNIT_STATE_MANA,sx-sy)
					DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Feedback\\SpellBreakerAttack.mdl", t, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Feedback\\SpellBreakerAttack.mdl",t,"origin"))
					UnitDamageTarget(c, t, sy, true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_NORMAL, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(c,t,sy,true,false,ATTACK_TYPE_CHAOS,DAMAGE_TYPE_NORMAL,WEAPON_TYPE_WHOKNOWS)
				}//endif
			}//endloop
			c = null;//set c=null
		}//endfunction
		private void jw() {//function jw takes nothing returns nothing
			player p = GetOwningPlayer(c4);//local player p=GetOwningPlayer(c4)
			float sx = GetUnitX(c4);//local real sx=GetUnitX(c4)
			float sy = GetUnitY(c4);//local real sy=GetUnitY(c4)
			float r = GetRandomReal(70.,300.);//local real r=GetRandomReal(70.,300.)
			float y = GetRandomReal(.0,360.)*bj_DEGTORAD;//local real y=GetRandomReal(.0,360.)*bj_DEGTORAD
			float x = sx+r*Cos(y);//local real x=sx+r*Cos(y)
			unit c = CreateUnit(p,959473703,sx,sy,.0);//local unit c=CreateUnit(p,'h09M',sx,sy,.0)
			if ((yd)) {//if(yd)then
				Pj("SE:MC:SM "+GetUnitName(c4)+" ->[no target]");//call Pj("SE:MC:SM "+GetUnitName(c4)+" ->[no target]")
				Rj();//call Rj()
			}//endif
			y = sy+r*Sin(y);//set y=sy+r*Sin(y)
			IssuePointOrderById(c, $D0010, x, y);//call IssuePointOrderById(c,$D0010,x,y)
			UnitApplyTimedLife(c, 'BTLF', 3.);//call UnitApplyTimedLife(c,'BTLF',3.)
			TriggerSleepAction(r/ 700.);//call TriggerSleepAction(r/ 700.)
			CreateUnit(p, 'n025', x, y, .0);//call CreateUnit(p,'n025',x,y,.0)
			c = null;//set c=null
		}//endfunction
		private bool kw() {//function kw takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool fl = GetWidgetLife(u)>=.405 && IsUnitType(u,UNIT_TYPE_STRUCTURE) && GetUnitTypeId(u)!=959473703  && (GetUnitAbilityLevel(u,1919304231)>0 || GetUnitAbilityLevel(u,808469031)>0) && GetRandomInt(0,99)<50;//local boolean fl=GetWidgetLife(u)>=.405 and IsUnitType(u,UNIT_TYPE_STRUCTURE)and GetUnitTypeId(u)!='h09T' and(GetUnitAbilityLevel(u,'Bfrz')>0 or GetUnitAbilityLevel(u,'B00M')>0)and GetRandomInt(0,99)<50
			u = null;//set u=null
			return fl;//return fl
		}//endfunction
		private void mw() {//function mw takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u=GetEnumUnit()
			UnitRemoveAbility(u, 'Bfrz');//call UnitRemoveAbility(u,'Bfrz')
			UnitRemoveAbility(u, 'B00M');//call UnitRemoveAbility(u,'B00M')
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\MirrorImage\\MirrorImageDeathCaster.mdl", GetUnitX(u), GetUnitY(u)));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Orc\\MirrorImage\\MirrorImageDeathCaster.mdl",GetUnitX(u),GetUnitY(u)))
			u = null;//set u=null
		}//endfunction
		private void nw() {//function nw takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u=GetEnumUnit()
			GroupEnumUnitsInRange(q4, GetUnitX(u), GetUnitY(u), 252., uf);//call GroupEnumUnitsInRange(q4,GetUnitX(u),GetUnitY(u),252.,uf)
			ForGroup(q4, function mw);//call ForGroup(q4,function mw)
			u = null;//set u=null
		}//endfunction
		private void ow() {//function ow takes nothing returns nothing
			ForGroup(rf, function nw);//call ForGroup(rf,function nw)
		}//endfunction
		private bool pw() {//function pw takes nothing returns boolean
			Bj(z4, 'h09V', 270., .0, .0);//call Bj(z4,'h09V',270.,.0,.0)
			Bj(z4, 'h09U', 90., 20., .0);//call Bj(z4,'h09U',90.,20.,.0)
			Bj(z4, 'h09U', .0, .0, -20.);//call Bj(z4,'h09U',.0,.0,-20.)
			Bj(z4, 'h09U', 270., -20., .0);//call Bj(z4,'h09U',270.,-20.,.0)
			Bj(z4, 'h09U', 180., .0, 20.);//call Bj(z4,'h09U',180.,.0,20.)
			return false;//return false
		}//endfunction
		private bool qw() {//function qw takes nothing returns boolean
			Bj(z4, 'h09R', 300., 3.5, 65.25);//call Bj(z4,'h09R',300.,3.5,65.25)
			Bj(z4, 'h09R', 70., -16.5, -51.);//call Bj(z4,'h09R',70.,-16.5,-51.)
			Bj(z4, 'h09N', 238., 36., 53.);//call Bj(z4,'h09N',238.,36.,53.)
			Bj(z4, 'h09O', 314., -38., -39.5);//call Bj(z4,'h09O',314.,-38.,-39.5)
			return false;//return false
		}//endfunction
		private bool rw() {//function rw takes nothing returns boolean
			Bj(z4, 'h09O', 279., -45.5, 24.75);//call Bj(z4,'h09O',279.,-45.5,24.75)
			Bj(z4, 'h09N', 300., 31., -32.25);//call Bj(z4,'h09N',300.,31.,-32.25)
			return false;//return false
		}//endfunction
		private bool sw() {//function sw takes nothing returns boolean
			Bj(z4, 'h09K', 238., .0, .0);//call Bj(z4,'h09K',238.,.0,.0)
			return false;//return false
		}//endfunction
		private bool tw() {//function tw takes nothing returns boolean
			Bj(z4, 'h09F', 2., 36.25, 41.);//call Bj(z4,'h09F',2.,36.25,41.)
			Bj(z4, 'h09F', 2., 33.25, -33.5);//call Bj(z4,'h09F',2.,33.25,-33.5)
			Bj(z4, 'h09F', 2., -46.25, 10.75);//call Bj(z4,'h09F',2.,-46.25,10.75)
			Bj(z4, 'h09A', 45., -5.25, 17.);//call Bj(z4,'h09A',45.,-5.25,17.)
			return false;//return false
		}//endfunction
		private bool uw() {//function uw takes nothing returns boolean
			Bj(z4, 'h09D', 225., 35., -29.75);//call Bj(z4,'h09D',225.,35.,-29.75)
			Bj(z4, 'h09D', 45., 20., 22.5);//call Bj(z4,'h09D',45.,20.,22.5)
			Bj(z4, 'h09D', 225., -31., 26.25);//call Bj(z4,'h09D',225.,-31.,26.25)
			Bj(z4, 'h09G', 23., -25.25, -36.);//call Bj(z4,'h09G',23.,-25.25,-36.)
			return false;//return false
		}//endfunction
		private bool vw() {//function vw takes nothing returns boolean
			Bj(z4, 'h09C', 33., 36.25, 36.5);//call Bj(z4,'h09C',33.,36.25,36.5)
			Bj(z4, 'h09C', 13., 21., -47.5);//call Bj(z4,'h09C',13.,21.,-47.5)
			Bj(z4, 'h09C', 319., -46.25, 11.75);//call Bj(z4,'h09C',319.,-46.25,11.75)
			return false;//return false
		}//endfunction
		private bool ww() {//function ww takes nothing returns boolean
			Bj(z4, 'h09C', 33., 36.25, 36.5);//call Bj(z4,'h09C',33.,36.25,36.5)
			Bj(z4, 'h09C', 13., 21., -47.5);//call Bj(z4,'h09C',13.,21.,-47.5)
			Bj(z4, 'h09C', 319., -46.25, 11.75);//call Bj(z4,'h09C',319.,-46.25,11.75)
			Bj(z4, 'h09E', 348., -6.5, 9.);//call Bj(z4,'h09E',348.,-6.5,9.)
			return false;//return false
		}//endfunction
		private bool xw() {//function xw takes nothing returns boolean
			Bj(z4, 'h09K', 45., .0, .0);//call Bj(z4,'h09K',45.,.0,.0)
			return false;//return false
		}//endfunction
		private bool yw() {//function yw takes nothing returns boolean
			Bj(z4, 'h096', 180., -45.75, 21.75);//call Bj(z4,'h096',180.,-45.75,21.75)
			Bj(z4, 'h096', 110., 9., -62.5);//call Bj(z4,'h096',110.,9.,-62.5)
			return false;//return false
		}//endfunction
		private void zw() {//function zw takes nothing returns nothing
			Fj('h09T', function pw);//call Fj('h09T',function pw)
			Ij('h09T', 180.);//call Ij('h09T',180.)
			zj('h069', 'n01U');//call zj('h069','n01U')
			Fj('h069', function qw);//call Fj('h069',function qw)
			lj('h06J', function fw);//call lj('h06J',function fw)
			lj('h05R', function hw);//call lj('h05R',function hw)
			zj('h05T', 'z002');//call zj('h05T','z002')
			zj('h09P', 'z003');//call zj('h09P','z003')
			Fj('h09P', function rw);//call Fj('h09P',function rw)
			zj('h05U', 'n01T');//call zj('h05U','n01T')
			zj('h05M', 'n01V');//call zj('h05M','n01V')
			zj('h05J', 'h06Q');//call zj('h05J','h06Q')
			zj('h09L', 'h06R');//call zj('h09L','h06R')
			Fj('h09L', function sw);//call Fj('h09L',function sw)
			zj('h05V', 'n01X');//call zj('h05V','n01X')
			zj('h097', 'n024');//call zj('h097','n024')
			Fj('h097', function yw);//call Fj('h097',function yw)
			zj('h05X', 'h06T');//call zj('h05X','h06T')
			zj('h09J', 'h06U');//call zj('h09J','h06U')
			Fj('h09J', function tw);//call Fj('h09J',function tw)
			zj('h09I', 'h099');//call zj('h09I','h099')
			Fj('h09I', function uw);//call Fj('h09I',function uw)
			zj('h09B', 'h06S');//call zj('h09B','h06S')
			Fj('h09B', function vw);//call Fj('h09B',function vw)
			zj('h09H', 'h098');//call zj('h09H','h098')
			Fj('h09H', function ww);//call Fj('h09H',function ww)
			Ij('h05L', 600.);//call Ij('h05L',600.)
			Fj('h05L', function xw);//call Fj('h05L',function xw)
		}//endfunction
		private void Aw() {//function Aw takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05T')
			t4[id] = $DC;//set t4[id]=$DC
			u4[id] = $DC*.2/ 100.;//set u4[id]=$DC*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h09P')
			t4[id] = $8C;//set t4[id]=$8C
			u4[id] = $8C*.2/ 100.;//set u4[id]=$8C*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05U')
			t4[id] = 375;//set t4[id]=375
			u4[id] = 375*.2/ 100.;//set u4[id]=375*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05M')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05J')
			t4[id] = $A0;//set t4[id]=$A0
			u4[id] = $A0*.2/ 100.;//set u4[id]=$A0*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h09L')
			t4[id] = $B4;//set t4[id]=$B4
			u4[id] = $B4*.2/ 100.;//set u4[id]=$B4*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05V')
			t4[id] = 270;//set t4[id]=270
			u4[id] = 270*.2/ 100.;//set u4[id]=270*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05X')
			t4[id] = $B4;//set t4[id]=$B4
			u4[id] = $B4*.2/ 100.;//set u4[id]=$B4*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h09J')
			t4[id] = $96;//set t4[id]=$96
			u4[id] = $96*.2/ 100.;//set u4[id]=$96*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h09I')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h09B')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h09H')
			t4[id] = $96;//set t4[id]=$96
			u4[id] = $96*.2/ 100.;//set u4[id]=$96*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h09T')
			t4[id] = 340;//set t4[id]=340
			u4[id] = 340*.12/ 100.;//set u4[id]=340*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(909142055);//set id=GetUnitPointValueByType('h069')
			t4[id] = $FA;//set t4[id]=$FA
			u4[id] = $FA*.12/ 100.;//set u4[id]=$FA*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(909142055);//set id=GetUnitPointValueByType('h06J')
			t4[id] = $BE;//set t4[id]=$BE
			u4[id] = $BE*.12/ 100.;//set u4[id]=$BE*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05R')
			t4[id] = $8C;//set t4[id]=$8C
			u4[id] = $8C*.12/ 100.;//set u4[id]=$8C*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(959473703);//set id=GetUnitPointValueByType('h097')
			t4[id] = 500;//set t4[id]=500
			u4[id] = 500*.2/ 100.;//set u4[id]=500*.2/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05L')
			t4[id] = $F0;//set t4[id]=$F0
			u4[id] = $F0*.08/ 100.;//set u4[id]=$F0*.08/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void aw() {//function aw takes nothing returns nothing
			Lj('z003', 'A09D', function iw);//call Lj('z003','A09D',function iw)
			Lj('h06U', 'A095', function jw);//call Lj('h06U','A095',function jw)
		}//endfunction
		private void Bw() {//function Bw takes nothing returns nothing
			zw();//call zw()
			Aw();//call Aw()
			aw();//call aw()
			tf = Filter(function gw);//set tf=Filter(function gw)
			sf = Filter(function ew);//set sf=Filter(function ew)
			uf = Filter(function kw);//set uf=Filter(function kw)
			TimerStart(CreateTimer(), 4., true, function ow);//call TimerStart(CreateTimer(),4.,true,function ow)
		}//endfunction
		private void bw() {//function bw takes nothing returns nothing
			unit c;//local unit c
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			c = CreateUnit(GetOwningPlayer(B4),808477991,GetUnitX(B4),GetUnitY(B4),.0);//set c=CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(B4),GetUnitY(B4),.0)
			UnitAddAbility(c, 'A00P');//call UnitAddAbility(c,'A00P')
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
			IssueTargetOrderById(c, $D00FA, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D00FA,bj_groupRandomCurrentPick)
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
			UnitApplyTimedLife(c, 'BTLF', 20.);//call UnitApplyTimedLife(c,'BTLF',20.)
			c = null;//set c=null
		}//endfunction
		private void Cw() {//function Cw takes nothing returns nothing
			unit c;//local unit c
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null || Hr(bj_groupRandomCurrentPick))) {//if(bj_groupRandomCurrentPick==null or Hr(bj_groupRandomCurrentPick))then
				return;//return
			}//endif
			c = CreateUnit(GetOwningPlayer(B4),808477991,GetUnitX(B4),GetUnitY(B4),.0);//set c=CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(B4),GetUnitY(B4),.0)
			UnitAddAbility(c, 'A00N');//call UnitAddAbility(c,'A00N')
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
			IssueTargetOrderById(c, $D0265, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D0265,bj_groupRandomCurrentPick)
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = null;//set c=null
		}//endfunction
		private void cw() {//function cw takes nothing returns nothing
			unit c;//local unit c
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, x9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,x9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			c = CreateUnit(r4,808477991,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);//set c=CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0)
			UnitAddAbility(c, 'A00B');//call UnitAddAbility(c,'A00B')
			IssueImmediateOrderById(c, $D0080);//call IssueImmediateOrderById(c,$D0080)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = null;//set c=null
		}//endfunction
		private void Dw() {//function Dw takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//local unit c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(c, 'A02T');//call UnitAddAbility(c,'A02T')
			IssueTargetOrderById(c, $D008F, D4);//call IssueTargetOrderById(c,$D008F,D4)
			UnitApplyTimedLife(c, 'BTLF', 2.);//call UnitApplyTimedLife(c,'BTLF',2.)
			c = c4;//set c=c4
			TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			if ((IssueImmediateOrderById(c,$D009E))) {//if(IssueImmediateOrderById(c,$D009E))then
				TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			}//endif
			Po(c);//call Po(c)
			c = null;//set c=null
		}//endfunction
		private void Ew() {//function Ew takes nothing returns nothing
			zj('h01Z', 'n00S');//call zj('h01Z','n00S')
			lj('h00N', function bw);//call lj('h00N',function bw)
			lj('h00M', function Cw);//call lj('h00M',function Cw)
			zj('h00J', 'n004');//call zj('h00J','n004')
			zj('h05F', 'n01P');//call zj('h05F','n01P')
			zj('h01B', 'n007');//call zj('h01B','n007')
			lj('h00I', function cw);//call lj('h00I',function cw)
			zj('h020', 'n00I');//call zj('h020','n00I')
			zj('h021', 'n00J');//call zj('h021','n00J')
			zj('h022', 'n00K');//call zj('h022','n00K')
			Ij('h00G', 700.);//call Ij('h00G',700.)
			zj('h01Y', 'n00H');//call zj('h01Y','n00H')
			zj('h00F', 'n002');//call zj('h00F','n002')
			zj('h032', 'n00X');//call zj('h032','n00X')
		}//endfunction
		private void Fw() {//function Fw takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01Z')
			t4[id] = 350;//set t4[id]=350
			u4[id] = 350*.2/ 100.;//set u4[id]=350*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00J')
			t4[id] = $AF;//set t4[id]=$AF
			u4[id] = $AF*.2/ 100.;//set u4[id]=$AF*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01B')
			t4[id] = 280;//set t4[id]=280
			u4[id] = 280*.18/ 100.;//set u4[id]=280*.18/ 100.
			v4[id] = true;//set v4[id]=true
			w4[id] = true;//set w4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h020')
			t4[id] = $AA;//set t4[id]=$AA
			u4[id] = $AA*.2/ 100.;//set u4[id]=$AA*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h021')
			t4[id] = $B4;//set t4[id]=$B4
			u4[id] = $B4*.2/ 100.;//set u4[id]=$B4*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h022')
			t4[id] = $BE;//set t4[id]=$BE
			u4[id] = $BE*.2/ 100.;//set u4[id]=$BE*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01Y')
			t4[id] = $E6;//set t4[id]=$E6
			u4[id] = $E6*.2/ 100.;//set u4[id]=$E6*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00F')
			t4[id] = $FA;//set t4[id]=$FA
			u4[id] = $FA*.2/ 100.;//set u4[id]=$FA*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h032')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00N')
			t4[id] = 750;//set t4[id]=750
			u4[id] = 750*.09/ 100.;//set u4[id]=750*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00I')
			t4[id] = 360;//set t4[id]=360
			u4[id] = 360*.18/ 100.;//set u4[id]=360*.18/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00M')
			t4[id] = 310;//set t4[id]=310
			u4[id] = 310*.18/ 100.;//set u4[id]=310*.18/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00G')
			t4[id] = $FA;//set t4[id]=$FA
			u4[id] = $FA*.18/ 100.;//set u4[id]=$FA*.18/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h05F')
			t4[id] = 725;//set t4[id]=725
			u4[id] = 725*.2/ 100.;//set u4[id]=725*.2/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void Naga___RegisterUnitCasts() {//function Naga___RegisterUnitCasts takes nothing returns nothing
			Lj('n00S', 'A02U', function Dw);//call Lj('n00S','A02U',function Dw)
		}//endfunction
		private void Gw() {//function Gw takes nothing returns nothing
			Ew();//call Ew()
			Fw();//call Fw()
			Lj('n00S', 'A02U', function Dw);//call Lj('n00S','A02U',function Dw)
		}//endfunction
		private bool Hw() {//function Hw takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool b = GetWidgetLife(u)>.405 && IsUnitType(u,UNIT_TYPE_GROUND) && IsUnitType(u,UNIT_TYPE_SAPPER);//local boolean b=GetWidgetLife(u)>.405 and IsUnitType(u,UNIT_TYPE_GROUND)and IsUnitType(u,UNIT_TYPE_SAPPER)
			u = null;//set u=null
			return b;//return b
		}//endfunction
		private void Iw() {//function Iw takes nothing returns nothing
			player p = GetOwningPlayer(c4);//local player p=GetOwningPlayer(c4)
			int i = 0;//local integer i=0
			float x = GetUnitX(c4);//local real x=GetUnitX(c4)
			float y = GetUnitY(c4);//local real y=GetUnitY(c4)
			JassArray<destructable> lw = new JassArray<destructable>();//local destructable array lw
			float an;//local real an
			float r;//local real r
			unit u;//local unit u
			float x2;//local real x2
			float y2;//local real y2
			GroupEnumUnitsInRange(q4, x, y, 144., xf);//call GroupEnumUnitsInRange(q4,x,y,144.,xf)
			while (true) {//loop
				u = FirstOfGroup(q4);//set u=FirstOfGroup(q4)
				if (u==null) { break; }//exitwhen u==null
				GroupRemoveUnit(q4, u);//call GroupRemoveUnit(q4,u)
				if ((u!=c4)) {//if(u!=c4)then
					r = GetRandomReal(160.,218.);//set r=GetRandomReal(160.,218.)
					an = (GetRandomReal(135.,234.)+180.*me[GetPlayerId(GetOwningPlayer(u))])*bj_DEGTORAD;//set an=(GetRandomReal(135.,234.)+180.*me[GetPlayerId(GetOwningPlayer(u))])*bj_DEGTORAD
					x2 = x+r*Cos(an);//set x2=x+r*Cos(an)
					y2 = y+r*Sin(an);//set y2=y+r*Sin(an)
					SetUnitX(u, x2);//call SetUnitX(u,x2)
					SetUnitY(u, y2);//call SetUnitY(u,y2)
					DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MassTeleport\\MassTeleportCaster.mdl", x2, y2));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\MassTeleport\\MassTeleportCaster.mdl",x2,y2))
				}//endif
			}//endloop
			u = c4;//set u=c4
			while (true) {//loop
				an = 72.*I2R(i);//set an=72.*I2R(i)
				lw[i] = CreateDestructable(1666472231,x+120.*Cos(an*bj_DEGTORAD),y+120.*Sin(an*bj_DEGTORAD),an,1.,0);//set lw[i]=CreateDestructable('YTct',x+120.*Cos(an*bj_DEGTORAD),y+120.*Sin(an*bj_DEGTORAD),an,1.,0)
				i = i+1;//set i=i+1
				if (i>=5) { break; }//exitwhen i>=5
			}//endloop
			TriggerSleepAction(3.);//call TriggerSleepAction(3.)
			if ((GetWidgetLife(u)>.405)) {//if(GetWidgetLife(u)>.405)then
				i = 0;//set i=0
				while (true) {//loop
					if ((GetWidgetLife(lw[i])>.405)) {//if(GetWidgetLife(lw[i])>.405)then
						KillDestructable(lw[i]);//call KillDestructable(lw[i])
						an = 72.*I2R(i);//set an=72.*I2R(i)
						x2 = x+112.*Cos(an*bj_DEGTORAD);//set x2=x+112.*Cos(an*bj_DEGTORAD)
						y2 = y+112.*Sin(an*bj_DEGTORAD);//set y2=y+112.*Sin(an*bj_DEGTORAD)
						UnitApplyTimedLife(CreateUnit(p, 'e00D', x2, y2, an), 'B021', 20.);//call UnitApplyTimedLife(CreateUnit(p,'e00D',x2,y2,an),'B021',20.)
						DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\EntBirthTarget\\EntBirthTarget.mdl", x2, y2));//call DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\EntBirthTarget\\EntBirthTarget.mdl",x2,y2))
					}//endif
					i = i+1;//set i=i+1
					if (i>=5) { break; }//exitwhen i>=5
				}//endloop
				Po(u);//call Po(u)
			} else {//else
				i = 0;//set i=0
				while (true) {//loop
					KillDestructable(lw[i]);//call KillDestructable(lw[i])
					i = i+1;//set i=i+1
					if (i>=5) { break; }//exitwhen i>=5
				}//endloop
			}//endif
			TriggerSleepAction(3.);//call TriggerSleepAction(3.)
			i = 0;//set i=0
			while (true) {//loop
				RemoveDestructable(lw[i]);//call RemoveDestructable(lw[i])
				lw[i] = null;//set lw[i]=null
				i = i+1;//set i=i+1
				if (i>=5) { break; }//exitwhen i>=5
			}//endloop
			u = null;//set u=null
		}//endfunction
		private void Jw() {//function Jw takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//local unit c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(c, 'A0AW');//call UnitAddAbility(c,'A0AW')
			IssueTargetOrderById(c, $D00C0, D4);//call IssueTargetOrderById(c,$D00C0,D4)
			UnitApplyTimedLife(c, 'BTLF', 2.);//call UnitApplyTimedLife(c,'BTLF',2.)
			c = c4;//set c=c4
			TriggerSleepAction(.8);//call TriggerSleepAction(.8)
			Po(c);//call Po(c)
			c = null;//set c=null
		}//endfunction
		private void Kw() {//function Kw takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//local unit c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(c, 'A0AW');//call UnitAddAbility(c,'A0AW')
			IssueTargetOrderById(c, $D00C0, D4);//call IssueTargetOrderById(c,$D00C0,D4)
			UnitApplyTimedLife(c, 'BTLF', 2.);//call UnitApplyTimedLife(c,'BTLF',2.)
			c = c4;//set c=c4
			TriggerSleepAction(.8);//call TriggerSleepAction(.8)
			Po(c);//call Po(c)
			c = null;//set c=null
		}//endfunction
		private void Lw() {//function Lw takes nothing returns nothing
			unit u = c4;//local unit u=c4
			IssueImmediateOrderById(u, $D0228);//call IssueImmediateOrderById(u,$D0228)
			TriggerSleepAction(.6);//call TriggerSleepAction(.6)
			Po(u);//call Po(u)
			u = null;//set u=null
		}//endfunction
		private bool Mw() {//function Mw takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			float r = GetWidgetLife(u);//local real r=GetWidgetLife(u)
			bool Im = r>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,942686503)<=0 && GetUnitAbilityLevel(u,1701331495)<=0 && GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>200.;//local boolean Im=r>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and GetUnitAbilityLevel(u,'A08C')<=0 and GetUnitAbilityLevel(u,'Bhea')<=0 and GetUnitState(u,UNIT_STATE_MAX_LIFE)-r>200.
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void Nw() {//function Nw takes nothing returns nothing
			unit u = c4;//local unit u=c4
			UnitAddAbility(D4, 'AId2');//call UnitAddAbility(D4,'AId2')
			DestroyEffect(AddSpecialEffectTarget("mdx\\sfx\\sin2.mdx", D4, "overhead"));//call DestroyEffect(AddSpecialEffectTarget("mdx\\sfx\\sin2.mdx",D4,"overhead"))
			TriggerSleepAction(.6);//call TriggerSleepAction(.6)
			Po(u);//call Po(u)
			u = null;//set u=null
		}//endfunction
		private void Ow() {//function Ow takes nothing returns nothing
			unit u = c4;//local unit u=c4
			UnitAddAbility(D4, 'AId3');//call UnitAddAbility(D4,'AId3')
			DestroyEffect(AddSpecialEffectTarget("mdx\\sfx\\sin2.mdx", D4, "overhead"));//call DestroyEffect(AddSpecialEffectTarget("mdx\\sfx\\sin2.mdx",D4,"overhead"))
			TriggerSleepAction(.6);//call TriggerSleepAction(.6)
			if ((IssueImmediateOrderById(u,$D009E))) {//if(IssueImmediateOrderById(u,$D009E))then
				TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			}//endif
			Po(u);//call Po(u)
			u = null;//set u=null
		}//endfunction
		private void Pw() {//function Pw takes nothing returns nothing
			unit u = c4;//local unit u=c4
			TriggerSleepAction(3.);//call TriggerSleepAction(3.)
			IssueImmediateOrderById(u, $D00F4);//call IssueImmediateOrderById(u,$D00F4)
			TriggerSleepAction(3.);//call TriggerSleepAction(3.)
			IssueImmediateOrderById(u, $D027A);//call IssueImmediateOrderById(u,$D027A)
			Po(u);//call Po(u)
			u = null;//set u=null
		}//endfunction
		private void Qw(unit w) {//function Qw takes unit w returns nothing
			unit u;//local unit u
			group g = CreateGroup();//local group g=CreateGroup()
			r4 = GetOwningPlayer(w);//set r4=GetOwningPlayer(w)
			GroupEnumUnitsInRange(g, GetUnitX(w), GetUnitY(w), 400., y9);//call GroupEnumUnitsInRange(g,GetUnitX(w),GetUnitY(w),400.,y9)
			while (true) {//loop
				u = FirstOfGroup(g);//set u=FirstOfGroup(g)
				if (u==null) { break; }//exitwhen u==null
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\NightElf\\Blink\\BlinkCaster.mdl", u, "head"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\NightElf\\Blink\\BlinkCaster.mdl",u,"head"))
				SetUnitState(u, UNIT_STATE_MANA, GetUnitState(u, UNIT_STATE_MANA)-100.);//call SetUnitState(u,UNIT_STATE_MANA,GetUnitState(u,UNIT_STATE_MANA)-100.)
				GroupRemoveUnit(g, u);//call GroupRemoveUnit(g,u)
			}//endloop
			DestroyGroup(g);//call DestroyGroup(g)
			g = null;//set g=null
			u = CreateUnit(r4,808477991,GetUnitX(w),GetUnitY(w),.0);//set u=CreateUnit(r4,'e008',GetUnitX(w),GetUnitY(w),.0)
			UnitAddAbility(u, 'A0ES');//call UnitAddAbility(u,'A0ES')
			UnitApplyTimedLife(u, 'BTLF', 8.);//call UnitApplyTimedLife(u,'BTLF',8.)
			u = null;//set u=null
		}//endfunction
		private void Rw() {//function Rw takes nothing returns nothing
			player p = GetOwningPlayer(B4);//local player p=GetOwningPlayer(B4)
			int sm = 2*me[GetPlayerId(p)];//local integer sm=2*me[GetPlayerId(p)]
			int i = 0;//local integer i=0
			int j = 0;//local integer j=0
			unit u;//local unit u
			while (true) {//loop
				u = rm(sm+j);//set u=rm(sm+j)
				UnitRemoveAbility(u, 'Awha');//call UnitRemoveAbility(u,'Awha')
				SetUnitOwner(u, p, false);//call SetUnitOwner(u,p,false)
				UnitAddType(u, UNIT_TYPE_SAPPER);//call UnitAddType(u,UNIT_TYPE_SAPPER)
				Po(u);//call Po(u)
				UnitApplyTimedLife(u, 'BTLF', 42.);//call UnitApplyTimedLife(u,'BTLF',42.)
				j = j+1;//set j=j+1
				if ((j>1)) {//if(j>1)then
					j = 0;//set j=0
				}//endif
				i = i+1;//set i=i+1
				TriggerSleepAction(.3);//call TriggerSleepAction(.3)
				if (i>=6) { break; }//exitwhen i>=6
			}//endloop
			u = null;//set u=null
		}//endfunction
		private void Sw() {//function Sw takes nothing returns nothing
			unit c;//local unit c
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null || Hr(bj_groupRandomCurrentPick))) {//if(bj_groupRandomCurrentPick==null or Hr(bj_groupRandomCurrentPick))then
				return;//return
			}//endif
			c = CreateUnit(r4,808477991,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);//set c=CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0)
			UnitAddAbility(c, 'A0BL');//call UnitAddAbility(c,'A0BL')
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
			IssueTargetOrderById(c, $D0206, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D0206,bj_groupRandomCurrentPick)
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = null;//set c=null
		}//endfunction
		private void Tw() {//function Tw takes nothing returns nothing
			unit c;//local unit c
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			c = CreateUnit(r4,808477991,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);//set c=CreateUnit(r4,'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0)
			UnitAddAbility(c, vf);//call UnitAddAbility(c,vf)
			IssuePointOrderById(c, $D0275, GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick));//call IssuePointOrderById(c,$D0275,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick))
			UnitApplyTimedLife(c, 'BTLF', 5.);//call UnitApplyTimedLife(c,'BTLF',5.)
			c = null;//set c=null
		}//endfunction
		private bool Uw() {//function Uw takes nothing returns boolean
			Bj(z4, 'h02J', 270., .0, .0);//call Bj(z4,'h02J',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool Vw() {//function Vw takes nothing returns boolean
			Bj(z4, 'h02J', 270., .0, .0);//call Bj(z4,'h02J',270.,.0,.0)
			Bj(z4, 'h02E', 270., .0, .0);//call Bj(z4,'h02E',270.,.0,.0)
			return false;//return false
		}//endfunction
		private bool Ww() {//function Ww takes nothing returns boolean
			Bj(z4, 'h02J', 270., .0, .0);//call Bj(z4,'h02J',270.,.0,.0)
			Bj(z4, 'h02E', 270., .0, .0);//call Bj(z4,'h02E',270.,.0,.0)
			Bj(z4, 'h02F', 270., -25., -25.);//call Bj(z4,'h02F',270.,-25.,-25.)
			return false;//return false
		}//endfunction
		private bool Xw() {//function Xw takes nothing returns boolean
			Bj(z4, 'h02J', 270., .0, .0);//call Bj(z4,'h02J',270.,.0,.0)
			Bj(z4, 'h02E', 270., .0, .0);//call Bj(z4,'h02E',270.,.0,.0)
			Bj(z4, 'h02F', 270., -35., -40.);//call Bj(z4,'h02F',270.,-35.,-40.)
			Bj(z4, 'h02G', 211., -35., 35.);//call Bj(z4,'h02G',211.,-35.,35.)
			return false;//return false
		}//endfunction
		private bool Yw() {//function Yw takes nothing returns boolean
			Bj(z4, 'h02Q', 270., -35., 30.);//call Bj(z4,'h02Q',270.,-35.,30.)
			return false;//return false
		}//endfunction
		private bool Zw() {//function Zw takes nothing returns boolean
			Bj(z4, 'h02L', 270., .0, .0);//call Bj(z4,'h02L',270.,.0,.0)
			Bj(z4, 'h02M', 270., 25, 20.);//call Bj(z4,'h02M',270.,25,20.)
			return false;//return false
		}//endfunction
		private bool dx() {//function dx takes nothing returns boolean
			Bj(z4, 'h02T', 49., -40., 20.);//call Bj(z4,'h02T',49.,-40.,20.)
			return false;//return false
		}//endfunction
		private void ex() {//function ex takes nothing returns nothing
			zj('n02C', 'n00T');//call zj('n02C','n00T')
			Fj('n02C', function Uw);//call Fj('n02C',function Uw)
			zj('h002', 'n00U');//call zj('h002','n00U')
			Fj('h002', function Vw);//call Fj('h002',function Vw)
			zj('h00Q', 'n01N');//call zj('h00Q','n01N')
			Fj('h00Q', function Ww);//call Fj('h00Q',function Ww)
			zj('h00R', 'n01W');//call zj('h00R','n01W')
			Fj('h00R', function Xw);//call Fj('h00R',function Xw)
			zj('h00Y', 'n026');//call zj('h00Y','n026')
			zj('h012', 'n028');//call zj('h012','n028')
			Fj('h012', function Yw);//call Fj('h012',function Yw)
			zj('h013', 'e006');//call zj('h013','e006')
			zj('h01H', 'e009');//call zj('h01H','e009')
			zj('h01J', 'e00C');//call zj('h01J','e00C')
			zj('h023', 'n029');//call zj('h023','n029')
			zj('h024', 'n02B');//call zj('h024','n02B')
			Fj('h024', function Zw);//call Fj('h024',function Zw)
			zj('h027', 'n02A');//call zj('h027','n02A')
			zj('h028', 'e00F');//call zj('h028','e00F')
			Fj('h028', function dx);//call Fj('h028',function dx)
			Ij('n02D', 700.);//call Ij('n02D',700.)
			lj('h02D', function Rw);//call lj('h02D',function Rw)
			lj('h02C', function Sw);//call lj('h02C',function Sw)
			lj('h02A', function Tw);//call lj('h02A',function Tw)
		}//endfunction
		private void fx() {//function fx takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h002')
			t4[id] = $AA;//set t4[id]=$AA
			u4[id] = $AA*.2/ 100.;//set u4[id]=$AA*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00Q')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00R')
			t4[id] = $FA;//set t4[id]=$FA
			u4[id] = $FA*.2/ 100.;//set u4[id]=$FA*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00Y')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h012')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h013')
			t4[id] = $DC;//set t4[id]=$DC
			u4[id] = $DC*.2/ 100.;//set u4[id]=$DC*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01H')
			t4[id] = $DC;//set t4[id]=$DC
			u4[id] = $DC*.2/ 100.;//set u4[id]=$DC*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h023')
			t4[id] = 260;//set t4[id]=260
			u4[id] = 260*.2/ 100.;//set u4[id]=260*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h024')
			t4[id] = 260;//set t4[id]=260
			u4[id] = 260*.2/ 100.;//set u4[id]=260*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h027')
			t4[id] = 310;//set t4[id]=310
			u4[id] = 310*.2/ 100.;//set u4[id]=310*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h028')
			t4[id] = 510;//set t4[id]=510
			u4[id] = 510*.2/ 100.;//set u4[id]=510*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(842034727);//set id=GetUnitPointValueByType('n02D')
			t4[id] = $D2;//set t4[id]=$D2
			u4[id] = $D2*.08/ 100.;//set u4[id]=$D2*.08/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01J')
			t4[id] = 400;//set t4[id]=400
			u4[id] = 400*.2/ 100.;//set u4[id]=400*.2/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02A')
			t4[id] = 350;//set t4[id]=350
			u4[id] = 350*.12/ 100.;//set u4[id]=350*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02C')
			t4[id] = $FA;//set t4[id]=$FA
			u4[id] = $FA*.09/ 100.;//set u4[id]=$FA*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(842033191);//set id=GetUnitPointValueByType('h02D')
			t4[id] = 600;//set t4[id]=600
			u4[id] = 600*.12/ 100.;//set u4[id]=600*.12/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void gx() {//function gx takes nothing returns nothing
			Lj('n026', 'A0C0', function Jw);//call Lj('n026','A0C0',function Jw)
			Lj('n028', 'A0C1', function Kw);//call Lj('n028','A0C1',function Kw)
			Lj('e006', 'A004', function Nw);//call Lj('e006','A004',function Nw)
			Lj('e009', 'A0BT', function Ow);//call Lj('e009','A0BT',function Ow)
			Lj('e00C', 'A0BX', function Iw);//call Lj('e00C','A0BX',function Iw)
			Lj('n01W', 'A0AV', function Pw);//call Lj('n01W','A0AV',function Pw)
			Lj('e00F', 'A0BJ', function Lw);//call Lj('e00F','A0BJ',function Lw)
		}//endfunction
		private void hx(unit u) {//function hx takes unit u returns nothing
			float x = GetUnitX(u);//local real x=GetUnitX(u)
			float y = GetUnitY(u);//local real y=GetUnitY(u)
			float an = GetUnitFacing(u)*bj_DEGTORAD;//local real an=GetUnitFacing(u)*bj_DEGTORAD
			destructable d = CreateDestructable(1817466407,x+32.*Cos(an),y+32.*Sin(an),GetRandomReal(0,360),GetRandomReal(.5,.8),0);//local destructable d=CreateDestructable('VTlt',x+32.*Cos(an),y+32.*Sin(an),GetRandomReal(0,360),GetRandomReal(.5,.8),0)
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\NEDeathMedium\\NEDeath.mdl", GetDestructableX(d), GetDestructableY(d)));//call DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\NightElf\\NEDeathMedium\\NEDeath.mdl",GetDestructableX(d),GetDestructableY(d)))
			IssueTargetOrderById(u, $D021F, d);//call IssueTargetOrderById(u,$D021F,d)
			TriggerSleepAction(1.6);//call TriggerSleepAction(1.6)
			Po(u);//call Po(u)
			TriggerSleepAction(2.);//call TriggerSleepAction(2.)
			RemoveDestructable(d);//call RemoveDestructable(d)
			d = null;//set d=null
		}//endfunction
		private void ix(unit u) {//function ix takes unit u returns nothing
			UnitRemoveAbility(u, 'A0C4');//call UnitRemoveAbility(u,'A0C4')
			SetUnitMoveSpeed(u, 370.);//call SetUnitMoveSpeed(u,370.)
			br(u);//call br(u)
			TriggerSleepAction(5.);//call TriggerSleepAction(5.)
			SetUnitMoveSpeed(u, 270.);//call SetUnitMoveSpeed(u,270.)
			UnitRemoveBuffs(u, true, true);//call UnitRemoveBuffs(u,true,true)
			IssueImmediateOrderById(u, $D0019);//call IssueImmediateOrderById(u,$D0019)
			UnitAddAbility(u, 'Asla');//call UnitAddAbility(u,'Asla')
			UnitAddAbility(u, 'A0C7');//call UnitAddAbility(u,'A0C7')
			UnitAddAbility(u, 'A0C8');//call UnitAddAbility(u,'A0C8')
			TriggerSleepAction(10.);//call TriggerSleepAction(10.)
			UnitRemoveAbility(u, 'Asla');//call UnitRemoveAbility(u,'Asla')
			UnitRemoveAbility(u, 'A0C7');//call UnitRemoveAbility(u,'A0C7')
			Po(u);//call Po(u)
		}//endfunction
		private void jx(unit u) {//function jx takes unit u returns nothing
			UnitRemoveAbility(u, 'A0C4');//call UnitRemoveAbility(u,'A0C4')
			SetUnitMoveSpeed(u, 370.);//call SetUnitMoveSpeed(u,370.)
			br(u);//call br(u)
			TriggerSleepAction(5.);//call TriggerSleepAction(5.)
			SetUnitMoveSpeed(u, 270.);//call SetUnitMoveSpeed(u,270.)
			UnitRemoveBuffs(u, true, true);//call UnitRemoveBuffs(u,true,true)
			IssueImmediateOrderById(u, $D0019);//call IssueImmediateOrderById(u,$D0019)
			UnitAddAbility(u, 'Asla');//call UnitAddAbility(u,'Asla')
			UnitAddAbility(u, 'A0C6');//call UnitAddAbility(u,'A0C6')
			TriggerSleepAction(10.);//call TriggerSleepAction(10.)
			UnitRemoveAbility(u, 'Asla');//call UnitRemoveAbility(u,'Asla')
			UnitRemoveAbility(u, 'A0C6');//call UnitRemoveAbility(u,'A0C6')
			Po(u);//call Po(u)
		}//endfunction
		private void kx() {//function kx takes nothing returns nothing
			ex();//call ex()
			fx();//call fx()
			gx();//call gx()
			yf = Filter(function Mw);//set yf=Filter(function Mw)
			xf = Filter(function Hw);//set xf=Filter(function Hw)
			wf = AddWeatherEffect(bj_mapInitialPlayableArea,1732527655);//set wf=AddWeatherEffect(bj_mapInitialPlayableArea,'FDgh')
			EnableWeatherEffect(wf, false);//call EnableWeatherEffect(wf,false)
		}//endfunction
		private bool nx() {//function nx takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,942686503)<=0;//local boolean Im=GetWidgetLife(u)>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and GetUnitAbilityLevel(u,'A08C')<=0
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void ox() {//function ox takes nothing returns nothing
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, af);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,af)
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Polymorph\\PolyMorphTarget.mdl", GetUnitX(B4), GetUnitY(B4)));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Human\\Polymorph\\PolyMorphTarget.mdl",GetUnitX(B4),GetUnitY(B4)))
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\ControlMagic\\ControlMagicTarget.mdl", bj_groupRandomCurrentPick, "overhead"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\ControlMagic\\ControlMagicTarget.mdl",bj_groupRandomCurrentPick,"overhead"))
			UnitAddAbility(bj_groupRandomCurrentPick, 'A08C');//call UnitAddAbility(bj_groupRandomCurrentPick,'A08C')
			UnitAddAbility(bj_groupRandomCurrentPick, 'A08D');//call UnitAddAbility(bj_groupRandomCurrentPick,'A08D')
			UnitAddAbility(bj_groupRandomCurrentPick, 'A08F');//call UnitAddAbility(bj_groupRandomCurrentPick,'A08F')
		}//endfunction
		private void px() {//function px takes nothing returns nothing
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			player p;//local player p
			int id;//local integer id
			float x;//local real x
			float y;//local real y
			if ((IsUnitType(u,UNIT_TYPE_STRUCTURE) || (!IsUnitType(GetTriggerUnit(),UNIT_TYPE_SAPPER)) || GetUnitAbilityLevel(u,942686503)>0)) {//if(IsUnitType(u,UNIT_TYPE_STRUCTURE)or(not IsUnitType(GetTriggerUnit(),UNIT_TYPE_SAPPER))or GetUnitAbilityLevel(u,'A08H')>0)then
				u = null;//set u=null
				return;//return
			}//endif
			p = GetOwningPlayer(u);//set p=GetOwningPlayer(u)
			id = me[GetPlayerId(p)];//set id=me[GetPlayerId(p)]
			if ((Bf[id]>0)) {//if(Bf[id]>0)then
				x = GetUnitX(u);//set x=GetUnitX(u)
				y = GetUnitY(u);//set y=GetUnitY(u)
				DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIda\\AIdaCaster.mdl", x, y));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIda\\AIdaCaster.mdl",x,y))
				u = CreateUnit(p,808477991,x,y,.0);//set u=CreateUnit(p,'e008',x,y,.0)
				UnitAddAbility(u, 'A08A');//call UnitAddAbility(u,'A08A')
				IssueImmediateOrderById(u, $D012D);//call IssueImmediateOrderById(u,$D012D)
				UnitApplyTimedLife(u, 'BTLF', 1.);//call UnitApplyTimedLife(u,'BTLF',1.)
				Bf[id] = Bf[id]-1;//set Bf[id]=Bf[id]-1
				if ((Bf[0]<=0 && Bf[1]<=0)) {//if(Bf[0]<=0 and Bf[1]<=0)then
					DisableTrigger(bf);//call DisableTrigger(bf)
				}//endif
			}//endif
			u = null;//set u=null
		}//endfunction
		private void qx() {//function qx takes nothing returns nothing
			int id = me[GetPlayerId(GetOwningPlayer(B4))];//local integer id=me[GetPlayerId(GetOwningPlayer(B4))]
			Bf[id] = Bf[id]+1;//set Bf[id]=Bf[id]+1
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl", GetUnitX(B4), GetUnitY(B4)));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl",GetUnitX(B4),GetUnitY(B4)))
			if ((!IsTriggerEnabled(bf))) {//if(not IsTriggerEnabled(bf))then
				EnableTrigger(bf);//call EnableTrigger(bf)
			}//endif
		}//endfunction
		private void rx() {//function rx takes nothing returns nothing
			effect e;//local effect e
			fogmodifier f;//local fogmodifier f
			float x;//local real x
			float y;//local real y
			bool fl;//local boolean fl
			unit c;//local unit c
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			e = AddSpecialEffect("Abilities\\Spells\\NightElf\\Starfall\\StarfallCaster.mdl",GetUnitX(B4),GetUnitY(B4));//set e=AddSpecialEffect("Abilities\\Spells\\NightElf\\Starfall\\StarfallCaster.mdl",GetUnitX(B4),GetUnitY(B4))
			x = GetUnitX(bj_groupRandomCurrentPick);//set x=GetUnitX(bj_groupRandomCurrentPick)
			y = GetUnitY(bj_groupRandomCurrentPick);//set y=GetUnitY(bj_groupRandomCurrentPick)
			fl = !U9;//set fl=not U9
			if ((fl)) {//if(fl)then
				f = CreateFogModifierRadius(r4,FOG_OF_WAR_VISIBLE,x,y,1100.,true,false);//set f=CreateFogModifierRadius(r4,FOG_OF_WAR_VISIBLE,x,y,1100.,true,false)
				FogModifierStart(f);//call FogModifierStart(f)
			}//endif
			c = CreateUnit(r4,808477991,x,y,.0);//set c=CreateUnit(r4,'e008',x,y,.0)
			UnitAddAbility(c, zf);//call UnitAddAbility(c,zf)
			IssueImmediateOrderById(c, $D00D7);//call IssueImmediateOrderById(c,$D00D7)
			UnitApplyTimedLife(c, 'BTLF', 11.);//call UnitApplyTimedLife(c,'BTLF',11.)
			c = null;//set c=null
			TriggerSleepAction(8.);//call TriggerSleepAction(8.)
			if ((fl)) {//if(fl)then
				DestroyFogModifier(f);//call DestroyFogModifier(f)
				f = null;//set f=null
			}//endif
			DestroyEffect(e);//call DestroyEffect(e)
			e = null;//set e=null
		}//endfunction
		private void ux() {//function ux takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(D4),GetUnitY(D4),.0);//local unit c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(D4),GetUnitY(D4),.0)
			UnitAddAbility(c, 'A07A');//call UnitAddAbility(c,'A07A')
			IssueTargetOrderById(c, $D00CB, D4);//call IssueTargetOrderById(c,$D00CB,D4)
			UnitApplyTimedLife(c, 'BTLF', 6.);//call UnitApplyTimedLife(c,'BTLF',6.)
			c = null;//set c=null
		}//endfunction
		private bool vx() {//function vx takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitType(u,UNIT_TYPE_GROUND) && GetUnitAbilityLevel(u,1970684199)<=0 && GetUnitAbilityLevel(u,942686503)<=0;//local boolean Im=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and IsUnitType(u,UNIT_TYPE_GROUND)and GetUnitAbilityLevel(u,'Avul')<=0 and GetUnitAbilityLevel(u,'A08H')<=0
			if ((Im && GetUnitAbilityLevel(u,1699037735)<=0 && GetUnitAbilityLevel(u,808469031)<=0)) {//if(Im and GetUnitAbilityLevel(u,'BEer')<=0 and GetUnitAbilityLevel(u,'B00M')<=0)then
				GroupAddUnit(Af, u);//call GroupAddUnit(Af,u)
				u = null;//set u=null
				return false;//return false
			}//endif
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void wx() {//function wx takes nothing returns nothing
			float x;//local real x
			float y;//local real y
			unit t;//local unit t
			unit c;//local unit c
			r4 = GetOwningPlayer(c4);//set r4=GetOwningPlayer(c4)
			x = GetUnitX(D4);//set x=GetUnitX(D4)
			y = GetUnitY(D4);//set y=GetUnitY(D4)
			bj_forLoopAIndex = 3;//set bj_forLoopAIndex=3
			GroupClear(Af);//call GroupClear(Af)
			GroupEnumUnitsInRange(q4, x, y, 300., Cf);//call GroupEnumUnitsInRange(q4,x,y,300.,Cf)
			while (true) {//loop
				t = FirstOfGroup(Af);//set t=FirstOfGroup(Af)
				if (bj_forLoopAIndex<=0 || t==null) { break; }//exitwhen bj_forLoopAIndex<=0 or t==null
				bj_forLoopAIndex = bj_forLoopAIndex-1;//set bj_forLoopAIndex=bj_forLoopAIndex-1
				GroupRemoveUnit(Af, t);//call GroupRemoveUnit(Af,t)
				c = CreateUnit(r4,808477991,x,y,.0);//set c=CreateUnit(r4,'e008',x,y,.0)
				UnitAddAbility(c, 'A07Q');//call UnitAddAbility(c,'A07Q')
				UnitShareVision(t, r4, true);//call UnitShareVision(t,r4,true)
				IssueTargetOrderById(c, $D00CB, t);//call IssueTargetOrderById(c,$D00CB,t)
				UnitShareVision(t, r4, false);//call UnitShareVision(t,r4,false)
				UnitApplyTimedLife(c, 'BTLF', 11.);//call UnitApplyTimedLife(c,'BTLF',11.)
			}//endloop
			if ((bj_forLoopAIndex>0)) {//if(bj_forLoopAIndex>0)then
				while (true) {//loop
					t = FirstOfGroup(q4);//set t=FirstOfGroup(q4)
					if (bj_forLoopAIndex<=0 || t==null) { break; }//exitwhen bj_forLoopAIndex<=0 or t==null
					bj_forLoopAIndex = bj_forLoopAIndex-1;//set bj_forLoopAIndex=bj_forLoopAIndex-1
					GroupRemoveUnit(q4, t);//call GroupRemoveUnit(q4,t)
					c = CreateUnit(r4,808477991,x,y,.0);//set c=CreateUnit(r4,'e008',x,y,.0)
					UnitAddAbility(c, 'A07Q');//call UnitAddAbility(c,'A07Q')
					UnitShareVision(t, r4, true);//call UnitShareVision(t,r4,true)
					IssueTargetOrderById(c, $D00CB, t);//call IssueTargetOrderById(c,$D00CB,t)
					UnitShareVision(t, r4, false);//call UnitShareVision(t,r4,false)
					UnitApplyTimedLife(c, 'BTLF', 11.);//call UnitApplyTimedLife(c,'BTLF',11.)
				}//endloop
			}//endif
			t = null;//set t=null
			c = null;//set c=null
		}//endfunction
		private void xx() {//function xx takes nothing returns nothing
			unit u = c4;//local unit u=c4
			TriggerSleepAction(1.2);//call TriggerSleepAction(1.2)
			Po(u);//call Po(u)
			u = null;//set u=null
		}//endfunction
		private bool yx() {//function yx takes nothing returns boolean
			Bj(z4, 'h08L', 32., 12., -11.5);//call Bj(z4,'h08L',32.,12.,-11.5)
			return false;//return false
		}//endfunction
		private bool zx() {//function zx takes nothing returns boolean
			Bj(z4, 'h08D', 116., -3., -10.5);//call Bj(z4,'h08D',116.,-3.,-10.5)
			Bj(z4, 'h08N', 323., 20., 5.75);//call Bj(z4,'h08N',323.,20.,5.75)
			return false;//return false
		}//endfunction
		private bool Ax() {//function Ax takes nothing returns boolean
			Bj(z4, 'h08A', .0, .0, .0);//call Bj(z4,'h08A',.0,.0,.0)
			return false;//return false
		}//endfunction
		private bool ax() {//function ax takes nothing returns boolean
			Bj(z4, 'h08K', .0, .0, .0);//call Bj(z4,'h08K',.0,.0,.0)
			return false;//return false
		}//endfunction
		private bool Bx() {//function Bx takes nothing returns boolean
			Bj(z4, 'h08K', .0, .0, .0);//call Bj(z4,'h08K',.0,.0,.0)
			Bj(z4, 'h08S', .0, .0, .0);//call Bj(z4,'h08S',.0,.0,.0)
			return false;//return false
		}//endfunction
		private bool bx() {//function bx takes nothing returns boolean
			Bj(z4, 'h08N', 226., 37.75, -41.5);//call Bj(z4,'h08N',226.,37.75,-41.5)
			return false;//return false
		}//endfunction
		private bool Cx() {//function Cx takes nothing returns boolean
			Bj(z4, 'h08O', 318, 43.5, -41.75);//call Bj(z4,'h08O',318,43.5,-41.75)
			Bj(z4, 'h08N', $E2, -38.25, 40.25);//call Bj(z4,'h08N',$E2,-38.25,40.25)
			return false;//return false
		}//endfunction
		private bool cx() {//function cx takes nothing returns boolean
			Bj(z4, 'h08K', .0, 15., .0);//call Bj(z4,'h08K',.0,15.,.0)
			Bj(z4, 'h08R', .0, .0, .0);//call Bj(z4,'h08R',.0,.0,.0)
			return false;//return false
		}//endfunction
		private bool Dx() {//function Dx takes nothing returns boolean
			Bj(z4, 'h08M', .0, .0, .0);//call Bj(z4,'h08M',.0,.0,.0)
			Bj(z4, 'h08Q', .0, .0, .0);//call Bj(z4,'h08Q',.0,.0,.0)
			return false;//return false
		}//endfunction
		private void Ex() {//function Ex takes nothing returns nothing
			lj('h07H', function ox);//call lj('h07H',function ox)
			Fj('h07H', function yx);//call Fj('h07H',function yx)
			lj('h08P', function qx);//call lj('h08P',function qx)
			Fj('h08P', function zx);//call Fj('h08P',function zx)
			Ij('h073', 850.);//call Ij('h073',850.)
			lj('h07I', function rx);//call lj('h07I',function rx)
			Fj('h07I', function Ax);//call Fj('h07I',function Ax)
			zj('h088', 'e007');//call zj('h088','e007')
			Fj('h088', function ax);//call Fj('h088',function ax)
			zj('h07D', 'e00J');//call zj('h07D','e00J')
			Fj('h07D', function Bx);//call Fj('h07D',function Bx)
			zj('h07M', 'n01Z');//call zj('h07M','n01Z')
			Fj('h07M', function bx);//call Fj('h07M',function bx)
			zj('h07L', 'n020');//call zj('h07L','n020')
			Fj('h07L', function Cx);//call Fj('h07L',function Cx)
			zj('h07O', 'e00B');//call zj('h07O','e00B')
			Fj('h07O', function cx);//call Fj('h07O',function cx)
			zj('h07N', 'e00A');//call zj('h07N','e00A')
			Fj('h07N', function Dx);//call Fj('h07N',function Dx)
			zj('h011', 'e002');//call zj('h011','e002')
			zj('h00S', 'e001');//call zj('h00S','e001')
			zj('h03D', 'e003');//call zj('h03D','e003')
			zj('h03E', 'e004');//call zj('h03E','e004')
			zj('h00B', 'e000');//call zj('h00B','e000')
		}//endfunction
		private void Fx() {//function Fx takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(942696487);//set id=GetUnitPointValueByType('h088')
			t4[id] = $BE;//set t4[id]=$BE
			u4[id] = $BE*.2/ 100.;//set u4[id]=$BE*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(925919271);//set id=GetUnitPointValueByType('h07D')
			t4[id] = $D2;//set t4[id]=$D2
			u4[id] = $D2*.2/ 100.;//set u4[id]=$D2*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(925919271);//set id=GetUnitPointValueByType('h07M')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(925919271);//set id=GetUnitPointValueByType('h07L')
			t4[id] = $AF;//set t4[id]=$AF
			u4[id] = $AF*.2/ 100.;//set u4[id]=$AF*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(925919271);//set id=GetUnitPointValueByType('h07O')
			t4[id] = $E6;//set t4[id]=$E6
			u4[id] = $E6*.2/ 100.;//set u4[id]=$E6*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(925919271);//set id=GetUnitPointValueByType('h07N')
			t4[id] = $F0;//set t4[id]=$F0
			u4[id] = $F0*.2/ 100.;//set u4[id]=$F0*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h011')
			t4[id] = 285;//set t4[id]=285
			u4[id] = 285*.18/ 100.;//set u4[id]=285*.18/ 100.
			v4[id] = true;//set v4[id]=true
			w4[id] = true;//set w4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00S')
			t4[id] = $96;//set t4[id]=$96
			u4[id] = $96*.2/ 100.;//set u4[id]=$96*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03D')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.2/ 100.;//set u4[id]=$C8*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03E')
			t4[id] = 400;//set t4[id]=400
			u4[id] = 400*.2/ 100.;//set u4[id]=400*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00B')
			t4[id] = 260;//set t4[id]=260
			u4[id] = 260*.2/ 100.;//set u4[id]=260*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(925919271);//set id=GetUnitPointValueByType('h07H')
			t4[id] = $DC;//set t4[id]=$DC
			u4[id] = $DC*.12/ 100.;//set u4[id]=$DC*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(942696487);//set id=GetUnitPointValueByType('h08P')
			t4[id] = $E1;//set t4[id]=$E1
			u4[id] = $E1*.12/ 100.;//set u4[id]=$E1*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(925919271);//set id=GetUnitPointValueByType('h073')
			t4[id] = $D2;//set t4[id]=$D2
			u4[id] = $D2*.08/ 100.;//set u4[id]=$D2*.08/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(925919271);//set id=GetUnitPointValueByType('h07I')
			t4[id] = 650;//set t4[id]=650
			u4[id] = 650*.09/ 100.;//set u4[id]=650*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03E')
			t4[id] = 400;//set t4[id]=400
			u4[id] = 400*.2/ 100.;//set u4[id]=400*.2/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void Gx() {//function Gx takes nothing returns nothing
			Lj('e007', 'A07P', function ux);//call Lj('e007','A07P',function ux)
			Lj('e00J', 'A07R', function wx);//call Lj('e00J','A07R',function wx)
			Lj('e000', 'A0CG', function xx);//call Lj('e000','A0CG',function xx)
		}//endfunction
		private void Hx() {//function Hx takes nothing returns nothing
			Ex();//call Ex()
			Fx();//call Fx()
			Gx();//call Gx()
			af = Filter(function nx);//set af=Filter(function nx)
			Cf = Filter(function vx);//set Cf=Filter(function vx)
			TriggerAddAction(bf, function px);//call TriggerAddAction(bf,function px)
			TriggerRegisterAnyUnitEventBJ(bf, EVENT_PLAYER_UNIT_ATTACKED);//call TriggerRegisterAnyUnitEventBJ(bf,EVENT_PLAYER_UNIT_ATTACKED)
			DisableTrigger(bf);//call DisableTrigger(bf)
		}//endfunction
		private bool Ix() {//function Ix takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && IsUnitType(u,UNIT_TYPE_FLYING);//local boolean Im=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and IsUnitType(u,UNIT_TYPE_FLYING)
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void lx() {//function lx takes nothing returns nothing
			unit c;//local unit c
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, cf);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,cf)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null || Hr(bj_groupRandomCurrentPick))) {//if(bj_groupRandomCurrentPick==null or Hr(bj_groupRandomCurrentPick))then
				return;//return
			}//endif
			c = CreateUnit(r4,808477991,GetUnitX(B4),GetUnitY(B4),.0);//set c=CreateUnit(r4,'e008',GetUnitX(B4),GetUnitY(B4),.0)
			UnitAddAbility(c, 'A0AK');//call UnitAddAbility(c,'A0AK')
			UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
			IssueTargetOrderById(c, $D007F, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D007F,bj_groupRandomCurrentPick)
			UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
			UnitApplyTimedLife(c, 'BTLF', 10.);//call UnitApplyTimedLife(c,'BTLF',10.)
			c = null;//set c=null
		}//endfunction
		private bool Jx() {//function Jx takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_STRUCTURE) && GetPlayerId(GetOwningPlayer(u))<$C && GetUnitTypeId(u)!=1633904679;//local boolean Im=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_STRUCTURE)and GetPlayerId(GetOwningPlayer(u))<$C and GetUnitTypeId(u)!='hcas'
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void Kx() {//function Kx takes nothing returns nothing
			float x;//local real x
			float y;//local real y
			unit c;//local unit c
			fogmodifier f;//local fogmodifier f
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Df);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,Df)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			x = GetUnitX(B4);//set x=GetUnitX(B4)
			y = GetUnitY(B4);//set y=GetUnitY(B4)
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\Naga\\NagaDeath\\NagaDeath.mdl", x, y));//call DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\Naga\\NagaDeath\\NagaDeath.mdl",x,y))
			c = CreateUnit(r4,875587623,x,y,.0);//set c=CreateUnit(r4,'h04G',x,y,.0)
			UnitApplyTimedLife(c, 'BTLF', 20.);//call UnitApplyTimedLife(c,'BTLF',20.)
			if ((U9)) {//if(U9)then
				IssueTargetOrderById(c, $D000F, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D000F,bj_groupRandomCurrentPick)
			} else {//else
				f = CreateFogModifierRadius(r4,FOG_OF_WAR_VISIBLE,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),128.,true,false);//set f=CreateFogModifierRadius(r4,FOG_OF_WAR_VISIBLE,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),128.,true,false)
				FogModifierStart(f);//call FogModifierStart(f)
				IssueTargetOrderById(c, $D000F, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D000F,bj_groupRandomCurrentPick)
				TriggerSleepAction(.1);//call TriggerSleepAction(.1)
				DestroyFogModifier(f);//call DestroyFogModifier(f)
				f = null;//set f=null
			}//endif
			c = null;//set c=null
		}//endfunction
		private void Lx() {//function Lx takes nothing returns nothing
			float x;//local real x
			float y;//local real y
			unit c;//local unit c
			fogmodifier f;//local fogmodifier f
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Df);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,Df)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			x = GetUnitX(B4);//set x=GetUnitX(B4)
			y = GetUnitY(B4);//set y=GetUnitY(B4)
			DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\Naga\\NagaDeath\\NagaDeath.mdl", x, y));//call DestroyEffect(AddSpecialEffect("Objects\\Spawnmodels\\Naga\\NagaDeath\\NagaDeath.mdl",x,y))
			c = CreateUnit(r4,875587623,x,y,.0);//set c=CreateUnit(r4,'h04H',x,y,.0)
			UnitApplyTimedLife(c, 'BTLF', 20.);//call UnitApplyTimedLife(c,'BTLF',20.)
			if ((U9)) {//if(U9)then
				IssueTargetOrderById(c, $D000F, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D000F,bj_groupRandomCurrentPick)
			} else {//else
				f = CreateFogModifierRadius(r4,FOG_OF_WAR_VISIBLE,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),128.,true,false);//set f=CreateFogModifierRadius(r4,FOG_OF_WAR_VISIBLE,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),128.,true,false)
				FogModifierStart(f);//call FogModifierStart(f)
				IssueTargetOrderById(c, $D000F, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D000F,bj_groupRandomCurrentPick)
				TriggerSleepAction(.1);//call TriggerSleepAction(.1)
				DestroyFogModifier(f);//call DestroyFogModifier(f)
				f = null;//set f=null
			}//endif
			c = null;//set c=null
		}//endfunction
		private void Mx() {//function Mx takes nothing returns nothing
			int i = 0;//local integer i=0
			float x;//local real x
			float y;//local real y
			float an;//local real an
			unit u;//local unit u
			unit c;//local unit c
			int t;//local integer t
			while (true) {//loop
				if (i>=Gf) { break; }//exitwhen i>=Gf
				u = Ff[i];//set u=Ff[i]
				an = GetUnitFacing(u);//set an=GetUnitFacing(u)
				x = GetUnitX(u)+10.*Cos(an*bj_DEGTORAD);//set x=GetUnitX(u)+10.*Cos(an*bj_DEGTORAD)
				if ((x>=lf || x<=If || GetWidgetLife(u)<.405)) {//if(x>=lf or x<=If or GetWidgetLife(u)<.405)then
					RemoveUnit(u);//call RemoveUnit(u)
					Gf = Gf-1;//set Gf=Gf-1
					Ff[i] = Ff[Gf];//set Ff[i]=Ff[Gf]
				} else {//else
					y = GetUnitY(u)+10.*Sin(an*bj_DEGTORAD);//set y=GetUnitY(u)+10.*Sin(an*bj_DEGTORAD)
					if ((y>=Kf || y<=Jf)) {//if(y>=Kf or y<=Jf)then
						y = GetUnitY(u)+30.*Sin((360.-an)*bj_DEGTORAD);//set y=GetUnitY(u)+30.*Sin((360.-an)*bj_DEGTORAD)
						SetUnitFacing(u, 360.-an);//call SetUnitFacing(u,360.-an)
					}//endif
					SetUnitX(u, x);//call SetUnitX(u,x)
					SetUnitY(u, y);//call SetUnitY(u,y)
					t = GetUnitUserData(u)+1;//set t=GetUnitUserData(u)+1
					if ((t>50)) {//if(t>50)then
						t = 0;//set t=0
						r4 = GetOwningPlayer(u);//set r4=GetOwningPlayer(u)
						GroupEnumUnitsInRange(q4, x, y, 700., y9);//call GroupEnumUnitsInRange(q4,x,y,700.,y9)
						bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
						bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
						ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
						if ((bj_groupRandomCurrentPick!=null)) {//if(bj_groupRandomCurrentPick!=null)then
							if ((IsUnitType(bj_groupRandomCurrentPick,UNIT_TYPE_FLYING))) {//if(IsUnitType(bj_groupRandomCurrentPick,UNIT_TYPE_FLYING))then
								c = CreateUnit(GetOwningPlayer(B4),808477991,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);//set c=CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0)
								UnitAddAbility(c, 'A082');//call UnitAddAbility(c,'A082')
								UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
								IssueTargetOrderById(c, $D007F, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D007F,bj_groupRandomCurrentPick)
								UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
								UnitApplyTimedLife(c, 'BTLF', 2.);//call UnitApplyTimedLife(c,'BTLF',2.)
							} else {//else
								c = CreateUnit(GetOwningPlayer(B4),808477991,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);//set c=CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0)
								UnitAddAbility(c, 'A083');//call UnitAddAbility(c,'A083')
								UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
								IssueTargetOrderById(c, $D007F, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D007F,bj_groupRandomCurrentPick)
								UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
								UnitApplyTimedLife(c, 'BTLF', 2.);//call UnitApplyTimedLife(c,'BTLF',2.)
								c = CreateUnit(GetOwningPlayer(B4),808477991,GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0);//set c=CreateUnit(GetOwningPlayer(B4),'e008',GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick),.0)
								UnitAddAbility(c, 'A04H');//call UnitAddAbility(c,'A04H')
								UnitShareVision(bj_groupRandomCurrentPick, r4, true);//call UnitShareVision(bj_groupRandomCurrentPick,r4,true)
								IssueTargetOrderById(c, $D00CB, bj_groupRandomCurrentPick);//call IssueTargetOrderById(c,$D00CB,bj_groupRandomCurrentPick)
								UnitShareVision(bj_groupRandomCurrentPick, r4, false);//call UnitShareVision(bj_groupRandomCurrentPick,r4,false)
								UnitApplyTimedLife(c, 'BTLF', 16.);//call UnitApplyTimedLife(c,'BTLF',16.)
							}//endif
						}//endif
					}//endif
					SetUnitUserData(u, t);//call SetUnitUserData(u,t)
					i = i+1;//set i=i+1
				}//endif
			}//endloop
			if ((Gf==0)) {//if(Gf==0)then
				PauseTimer(Ef);//call PauseTimer(Ef)
			}//endif
			u = null;//set u=null
			c = null;//set c=null
		}//endfunction
		private void Nx() {//function Nx takes nothing returns nothing
			unit u = B4;//local unit u=B4
			float x = GetUnitX(u);//local real x=GetUnitX(u)
			float y = GetUnitY(u);//local real y=GetUnitY(u)
			player p = GetOwningPlayer(u);//local player p=GetOwningPlayer(u)
			float an = me[GetPlayerId(p)]*180.;//local real an=me[GetPlayerId(p)]*180.
			int i = 0;//local integer i=0
			unit c;//local unit c
			SetUnitAnimation(u, "death");//call SetUnitAnimation(u,"death")
			TriggerSleepAction(1.5);//call TriggerSleepAction(1.5)
			TimerStart(Ef, .04, true, function Mx);//call TimerStart(Ef,.04,true,function Mx)
			while (true) {//loop
				c = CreateUnit(p,942696487,x,y,ModuloReal(an+GetRandomReal(-55.,55.)+360.,360.));//set c=CreateUnit(p,'h08U',x,y,ModuloReal(an+GetRandomReal(-55.,55.)+360.,360.))
				if ((md)) {//if(md)then
					UnitRemoveAbility(c, 'A080');//call UnitRemoveAbility(c,'A080')
					UnitAddAbility(c, 'A084');//call UnitAddAbility(c,'A084')
				}//endif
				Ff[Gf] = c;//set Ff[Gf]=c
				Gf = Gf+1;//set Gf=Gf+1
				i = i+1;//set i=i+1
				if (i>2) { break; }//exitwhen i>2
			}//endloop
			c = null;//set c=null
			EnableWeatherEffect(Hf, true);//call EnableWeatherEffect(Hf,true)
			TriggerSleepAction(3.7);//call TriggerSleepAction(3.7)
			SetUnitAnimation(u, "stand");//call SetUnitAnimation(u,"stand")
			TriggerSleepAction(2.6);//call TriggerSleepAction(2.6)
			EnableWeatherEffect(Hf, false);//call EnableWeatherEffect(Hf,false)
			u = null;//set u=null
		}//endfunction
		private bool Ox() {//function Ox takes nothing returns boolean
			SetUnitVertexColor(z4, 0, $A6, $FF, 's');//call SetUnitVertexColor(z4,0,$A6,$FF,'s')
			return false;//return false
		}//endfunction
		private void Px() {//function Px takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//local unit c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(c, 'A05D');//call UnitAddAbility(c,'A05D')
			IssueImmediateOrderById(c, $D009F);//call IssueImmediateOrderById(c,$D009F)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = null;//set c=null
		}//endfunction
		private void Qx() {//function Qx takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//local unit c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(c, 'A043');//call UnitAddAbility(c,'A043')
			IssueTargetOrderById(c, $D0102, D4);//call IssueTargetOrderById(c,$D0102,D4)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = null;//set c=null
		}//endfunction
		private void Rx() {//function Rx takes nothing returns nothing
			unit c = CreateUnit(GetOwningPlayer(c4),808477991,GetUnitX(c4),GetUnitY(c4),.0);//local unit c=CreateUnit(GetOwningPlayer(c4),'e008',GetUnitX(c4),GetUnitY(c4),.0)
			UnitAddAbility(c, 'A05B');//call UnitAddAbility(c,'A05B')
			IssueImmediateOrderById(c, $D026C);//call IssueImmediateOrderById(c,$D026C)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = null;//set c=null
		}//endfunction
		private void Sx() {//function Sx takes nothing returns nothing
			lj('h047', function lx);//call lj('h047',function lx)
			lj('h048', function Kx);//call lj('h048',function Kx)
			lj('h03L', function Lx);//call lj('h03L',function Lx)
			lj('h03O', function Nx);//call lj('h03O',function Nx)
			zj('h049', 'n017');//call zj('h049','n017')
			zj('h04F', 'n018');//call zj('h04F','n018')
			zj('h03W', 'n016');//call zj('h03W','n016')
			zj('h03T', 'n012');//call zj('h03T','n012')
			zj('h043', 'n013');//call zj('h043','n013')
			zj('h03S', 'n014');//call zj('h03S','n014')
			Fj('h03S', function Ox);//call Fj('h03S',function Ox)
			zj('h03K', 'n015');//call zj('h03K','n015')
			zj('h03J', 'o00A');//call zj('h03J','o00A')
			Ij('h03Q', 750.);//call Ij('h03Q',750.)
			zj('h03U', 'n011');//call zj('h03U','n011')
			zj('h03I', 'n010');//call zj('h03I','n010')
		}//endfunction
		private void Tx() {//function Tx takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h049')
			t4[id] = 's';//set t4[id]='s'
			u4[id] = 's'*.2/ 100.;//set u4[id]='s'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04F')
			t4[id] = '}';//set t4[id]='}'
			u4[id] = '}'*.2/ 100.;//set u4[id]='}'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03W')
			t4[id] = $FA;//set t4[id]=$FA
			u4[id] = $FA*.2/ 100.;//set u4[id]=$FA*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03T')
			t4[id] = 275;//set t4[id]=275
			u4[id] = 275*.2/ 100.;//set u4[id]=275*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h043')
			t4[id] = $E1;//set t4[id]=$E1
			u4[id] = $E1*.2/ 100.;//set u4[id]=$E1*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03S')
			t4[id] = 400;//set t4[id]=400
			u4[id] = 400*.2/ 100.;//set u4[id]=400*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03K')
			t4[id] = $AF;//set t4[id]=$AF
			u4[id] = $AF*.2/ 100.;//set u4[id]=$AF*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03J')
			t4[id] = $96;//set t4[id]=$96
			u4[id] = $96*.2/ 100.;//set u4[id]=$96*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03U')
			t4[id] = $A0;//set t4[id]=$A0
			u4[id] = $A0*.2/ 100.;//set u4[id]=$A0*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03I')
			t4[id] = 280;//set t4[id]=280
			u4[id] = 280*.2/ 100.;//set u4[id]=280*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h047')
			t4[id] = $BE;//set t4[id]=$BE
			u4[id] = $BE*.12/ 100.;//set u4[id]=$BE*.12/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03Q')
			t4[id] = $E6;//set t4[id]=$E6
			u4[id] = $E6*.08/ 100.;//set u4[id]=$E6*.08/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h048')
			t4[id] = $D2;//set t4[id]=$D2
			u4[id] = $D2*.09/ 100.;//set u4[id]=$D2*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03L')
			t4[id] = 290;//set t4[id]=290
			u4[id] = 290*.09/ 100.;//set u4[id]=290*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03O')
			t4[id] = 600;//set t4[id]=600
			u4[id] = 600*.09/ 100.;//set u4[id]=600*.09/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void Ux() {//function Ux takes nothing returns nothing
			Lj('n016', 'A05E', function Px);//call Lj('n016','A05E',function Px)
			Lj('n013', 'A05C', function Rx);//call Lj('n013','A05C',function Rx)
			Lj('n014', 'A044', function Qx);//call Lj('n014','A044',function Qx)
		}//endfunction
		private void Vx() {//function Vx takes nothing returns nothing
			Sx();//call Sx()
			Tx();//call Tx()
			Ux();//call Ux()
			cf = Filter(function Ix);//set cf=Filter(function Ix)
			Df = Filter(function Jx);//set Df=Filter(function Jx)
			If = GetRectMinX(bj_mapInitialPlayableArea);//set If=GetRectMinX(bj_mapInitialPlayableArea)
			lf = GetRectMaxX(bj_mapInitialPlayableArea);//set lf=GetRectMaxX(bj_mapInitialPlayableArea)
			Jf = GetRectMinY(bj_mapInitialPlayableArea);//set Jf=GetRectMinY(bj_mapInitialPlayableArea)
			Kf = GetRectMaxY(bj_mapInitialPlayableArea);//set Kf=GetRectMaxY(bj_mapInitialPlayableArea)
			Hf = AddWeatherEffect(bj_mapInitialPlayableArea,1749963559);//set Hf=AddWeatherEffect(bj_mapInitialPlayableArea,'SNhs')
			EnableWeatherEffect(Hf, false);//call EnableWeatherEffect(Hf,false)
		}//endfunction
		private bool Wx() {//function Wx takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)<.405 && IsUnitType(u,UNIT_TYPE_SAPPER) && !IsUnitType(u,UNIT_TYPE_UNDEAD);//local boolean Im=GetWidgetLife(u)<.405 and IsUnitType(u,UNIT_TYPE_SAPPER)and not IsUnitType(u,UNIT_TYPE_UNDEAD)
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void Xx() {//function Xx takes nothing returns nothing
			float x;//local real x
			float y;//local real y
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Lf);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,Lf)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			x = GetUnitX(bj_groupRandomCurrentPick);//set x=GetUnitX(bj_groupRandomCurrentPick)
			y = GetUnitY(bj_groupRandomCurrentPick);//set y=GetUnitY(bj_groupRandomCurrentPick)
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl", x, y));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl",x,y))
			if ((GetRandomInt(0,99)<$A)) {//if(GetRandomInt(0,99)<$A)then
				Po(CreateUnit(GetOwningPlayer(B4), Mf[3], x, y, .0));//call Po(CreateUnit(GetOwningPlayer(B4),Mf[3],x,y,.0))
			} else {//else
				Po(CreateUnit(GetOwningPlayer(B4), Mf[GetRandomInt(0, 2)], x, y, .0));//call Po(CreateUnit(GetOwningPlayer(B4),Mf[GetRandomInt(0,2)],x,y,.0))
			}//endif
			RemoveUnit(bj_groupRandomCurrentPick);//call RemoveUnit(bj_groupRandomCurrentPick)
		}//endfunction
		private void Yx() {//function Yx takes nothing returns nothing
			float x;//local real x
			float y;//local real y
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, Lf);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,Lf)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			x = GetUnitX(bj_groupRandomCurrentPick);//set x=GetUnitX(bj_groupRandomCurrentPick)
			y = GetUnitY(bj_groupRandomCurrentPick);//set y=GetUnitY(bj_groupRandomCurrentPick)
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl", x, y));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl",x,y))
			if ((GetRandomInt(0,99)<$A)) {//if(GetRandomInt(0,99)<$A)then
				Po(CreateUnit(GetOwningPlayer(B4), Mf[7], x, y, .0));//call Po(CreateUnit(GetOwningPlayer(B4),Mf[7],x,y,.0))
			} else {//else
				Po(CreateUnit(GetOwningPlayer(B4), Mf[GetRandomInt(1, 6)], x, y, .0));//call Po(CreateUnit(GetOwningPlayer(B4),Mf[GetRandomInt(1,6)],x,y,.0))
			}//endif
			RemoveUnit(bj_groupRandomCurrentPick);//call RemoveUnit(bj_groupRandomCurrentPick)
		}//endfunction
		private void Zx() {//function Zx takes nothing returns nothing
			unit u;//local unit u
			r4 = GetOwningPlayer(B4);//set r4=GetOwningPlayer(B4)
			GroupEnumUnitsInRect(q4, bj_mapInitialPlayableArea, y9);//call GroupEnumUnitsInRect(q4,bj_mapInitialPlayableArea,y9)
			bj_groupRandomConsidered = 0;//set bj_groupRandomConsidered=0
			bj_groupRandomCurrentPick = null;//set bj_groupRandomCurrentPick=null
			ForGroup(q4, function GroupPickRandomUnitEnum);//call ForGroup(q4,function GroupPickRandomUnitEnum)
			if ((bj_groupRandomCurrentPick==null)) {//if(bj_groupRandomCurrentPick==null)then
				return;//return
			}//endif
			if (!Hr(bj_groupRandomCurrentPick)) {//if not Hr(bj_groupRandomCurrentPick)then
				UnitDamageTarget(B4, bj_groupRandomCurrentPick, 50000., true, false, ATTACK_TYPE_NORMAL, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(B4,bj_groupRandomCurrentPick,50000.,true,false,ATTACK_TYPE_NORMAL,DAMAGE_TYPE_DEATH,WEAPON_TYPE_WHOKNOWS)
			}//endif
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathCoil\\DeathCoilSpecialArt.mdl", GetUnitX(bj_groupRandomCurrentPick), GetUnitY(bj_groupRandomCurrentPick)));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Undead\\DeathCoil\\DeathCoilSpecialArt.mdl",GetUnitX(bj_groupRandomCurrentPick),GetUnitY(bj_groupRandomCurrentPick)))
			u = B4;//set u=B4
			SetUnitAnimation(u, "work");//call SetUnitAnimation(u,"work")
			TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			SetUnitAnimation(u, "stand");//call SetUnitAnimation(u,"stand")
			u = null;//set u=null
		}//endfunction
		private void dy() {//function dy takes nothing returns nothing
			zj('h01K', 'u005');//call zj('h01K','u005')
			zj('h04B', 'u009');//call zj('h04B','u009')
			zj('h055', 'u00D');//call zj('h055','u00D')
			Ij('h01O', 800.);//call Ij('h01O',800.)
			zj('h01T', 'n00E');//call zj('h01T','n00E')
			lj('h01P', function Xx);//call lj('h01P',function Xx)
			lj('h056', function Yx);//call lj('h056',function Yx)
			zj('h01N', 'h01U');//call zj('h01N','h01U')
			zj('h054', 'h05H');//call zj('h054','h05H')
			zj('h01L', 'u001');//call zj('h01L','u001')
			zj('h01S', 'u000');//call zj('h01S','u000')
			lj('h00A', function Zx);//call lj('h00A',function Zx)
			zj('h01R', 'n00B');//call zj('h01R','n00B')
			zj('h04Z', 'n01K');//call zj('h04Z','n01K')
			zj('h03M', 'u007');//call zj('h03M','u007')
		}//endfunction
		private void ey() {//function ey takes nothing returns nothing
			int id;//local integer id
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01K')
			t4[id] = $D2;//set t4[id]=$D2
			u4[id] = $D2*.2/ 100.;//set u4[id]=$D2*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04B')
			t4[id] = $AA;//set t4[id]=$AA
			u4[id] = $AA*.2/ 100.;//set u4[id]=$AA*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01T')
			t4[id] = 370;//set t4[id]=370
			u4[id] = 370*.18/ 100.;//set u4[id]=370*.18/ 100.
			v4[id] = true;//set v4[id]=true
			w4[id] = true;//set w4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01P')
			t4[id] = $A0;//set t4[id]=$A0
			u4[id] = $A0*.12/ 100.;//set u4[id]=$A0*.12/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h056')
			t4[id] = $8C;//set t4[id]=$8C
			u4[id] = $8C*.12/ 100.;//set u4[id]=$8C*.12/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01N')
			t4[id] = $E6;//set t4[id]=$E6
			u4[id] = $E6*.2/ 100.;//set u4[id]=$E6*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h054')
			t4[id] = 265;//set t4[id]=265
			u4[id] = 265*.2/ 100.;//set u4[id]=265*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01L')
			t4[id] = 290;//set t4[id]=290
			u4[id] = 290*.2/ 100.;//set u4[id]=290*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01S')
			t4[id] = 500;//set t4[id]=500
			u4[id] = 500*.2/ 100.;//set u4[id]=500*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01R')
			t4[id] = 'x';//set t4[id]='x'
			u4[id] = 'x'*.2/ 100.;//set u4[id]='x'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(875587623);//set id=GetUnitPointValueByType('h04Z')
			t4[id] = 'd';//set t4[id]='d'
			u4[id] = 'd'*.2/ 100.;//set u4[id]='d'*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(858810407);//set id=GetUnitPointValueByType('h03M')
			t4[id] = $CD;//set t4[id]=$CD
			u4[id] = $CD*.2/ 100.;//set u4[id]=$CD*.2/ 100.
			v4[id] = true;//set v4[id]=true
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01O')
			t4[id] = $C8;//set t4[id]=$C8
			u4[id] = $C8*.08/ 100.;//set u4[id]=$C8*.08/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(892364839);//set id=GetUnitPointValueByType('h055')
			t4[id] = 370;//set t4[id]=370
			u4[id] = 370*.2/ 100.;//set u4[id]=370*.2/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(808478759);//set id=GetUnitPointValueByType('h00A')
			t4[id] = 360;//set t4[id]=360
			u4[id] = 360*.09/ 100.;//set u4[id]=360*.09/ 100.
			v4[id] = false;//set v4[id]=false
			id = GetUnitPointValueByType(825255975);//set id=GetUnitPointValueByType('h01Q')
			t4[id] = 650;//set t4[id]=650
			u4[id] = 650*.09/ 100.;//set u4[id]=650*.09/ 100.
			v4[id] = false;//set v4[id]=false
		}//endfunction
		private void fy() {//function fy takes nothing returns nothing
		}//endfunction
		private void gy() {//function gy takes nothing returns nothing
			unit u = GetSummonedUnit();//local unit u=GetSummonedUnit()
			int aj = GetUnitTypeId(u);//local integer aj=GetUnitTypeId(u)
			if ((aj==808482087)) {//if(aj=='u004')then
				Po(ReplaceUnitBJ(u, Mf[GetRandomInt(0, 2)], 2));//call Po(ReplaceUnitBJ(u,Mf[GetRandomInt(0,2)],2))
			} else if ((aj==808482087)) {//elseif(aj=='u008')then
				Po(ReplaceUnitBJ(u, Mf[GetRandomInt(0, 6)], 2));//call Po(ReplaceUnitBJ(u,Mf[GetRandomInt(0,6)],2))
			} else if ((aj==808482087)) {//elseif(aj=='u00E')then
				aj = GetRandomInt(0,7);//set aj=GetRandomInt(0,7)
				if ((aj==0)) {//if(aj==0)then
					aj = 7;//set aj=7
				} else {//else
					aj = GetRandomInt(3,6);//set aj=GetRandomInt(3,6)
				}//endif
				Po(ReplaceUnitBJ(u, Mf[aj], 2));//call Po(ReplaceUnitBJ(u,Mf[aj],2))
				UnitAddAbility(bj_lastReplacedUnit, 'A088');//call UnitAddAbility(bj_lastReplacedUnit,'A088')
				UnitAddAbility(bj_lastReplacedUnit, 'A089');//call UnitAddAbility(bj_lastReplacedUnit,'A089')
			}//endif
			u = null;//set u=null
		}//endfunction
		private void hy(unit k, unit d, int bj) {//function hy takes unit k,unit d,integer bj returns nothing
			float x = GetUnitX(d);//local real x=GetUnitX(d)
			float y = GetUnitY(d);//local real y=GetUnitY(d)
			CreateUnit(GetOwningPlayer(k), bj, x, y, .0);//call CreateUnit(GetOwningPlayer(k),bj,x,y,.0)
			RemoveUnit(d);//call RemoveUnit(d)
			DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl", x, y));//call DestroyEffect(AddSpecialEffect("Abilities\\Spells\\Items\\AIam\\AIamTarget.mdl",x,y))
		}//endfunction
		private void iy() {//function iy takes nothing returns nothing
			trigger t;//local trigger t
			dy();//call dy()
			ey();//call ey()
			fy();//call fy()
			Lf = Filter(function Wx);//set Lf=Filter(function Wx)
			Mf[0] = 808482087;//set Mf[0]='u002'
			Mf[1] = 808480295;//set Mf[1]='n00D'
			Mf[2] = 808482087;//set Mf[2]='u00A'
			Mf[3] = 808480295;//set Mf[3]='n00C'
			Mf[4] = 808482087;//set Mf[4]='u00B'
			Mf[5] = 825257511;//set Mf[5]='n01L'
			Mf[6] = 808482087;//set Mf[6]='u003'
			Mf[7] = 825257511;//set Mf[7]='n01M'
			t = CreateTrigger();//set t=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(t, EVENT_PLAYER_UNIT_SUMMON);//call TriggerRegisterAnyUnitEventBJ(t,EVENT_PLAYER_UNIT_SUMMON)
			TriggerAddAction(t, function gy);//call TriggerAddAction(t,function gy)
		}//endfunction
		private void jy(unit u, float x, float y) {//function jy takes unit u,real x,real y returns nothing
			unit c = CreateUnit(GetOwningPlayer(u),808477991,x,y,.0);//local unit c=CreateUnit(GetOwningPlayer(u),'e008',x,y,.0)
			UnitAddAbility(c, 'A086');//call UnitAddAbility(c,'A086')
			IssuePointOrderById(c, $D00FD, x, y);//call IssuePointOrderById(c,$D00FD,x,y)
			UnitApplyTimedLife(c, 'BTLF', 6.);//call UnitApplyTimedLife(c,'BTLF',6.)
			c = null;//set c=null
		}//endfunction
		private void ky(unit u, unit v) {//function ky takes unit u,unit v returns nothing
			int i = GetRandomInt(0,99);//local integer i=GetRandomInt(0,99)
			if ((i<$F && GetUnitAbilityLevel(v,925909287)<=0 && !IsUnitType(v,UNIT_TYPE_MECHANICAL))) {//if(i<$F and GetUnitAbilityLevel(v,'A070')<=0 and not IsUnitType(v,UNIT_TYPE_MECHANICAL))then
				if ((GetWidgetLife(v)<.405)) {//if(GetWidgetLife(v)<.405)then
					return;//return
				}//endif
				SetUnitState(u, UNIT_STATE_LIFE, GetUnitState(u, UNIT_STATE_LIFE)+GetUnitState(v, UNIT_STATE_LIFE)/ 2.);//call SetUnitState(u,UNIT_STATE_LIFE,GetUnitState(u,UNIT_STATE_LIFE)+GetUnitState(v,UNIT_STATE_LIFE)/ 2.)
				UnitDamageTarget(u, v, 10000., true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(u,v,10000.,true,false,ATTACK_TYPE_CHAOS,DAMAGE_TYPE_DEATH,WEAPON_TYPE_WHOKNOWS)
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Orc\\AncestralSpirit\\AncestralSpiritCaster.mdl", v, "chest"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Orc\\AncestralSpirit\\AncestralSpiritCaster.mdl",v,"chest"))
			} else if ((i<25)) {//elseif(i<25)then
				jy(u, GetUnitX(v), GetUnitY(v));//call jy(u,GetUnitX(v),GetUnitY(v))
			}//endif
		}//endfunction
		private void ny(unit u, unit v) {//function ny takes unit u,unit v returns nothing
			unit c;//local unit c
			if ((GetRandomInt(0,99)<$F)) {//if(GetRandomInt(0,99)<$F)then
				c = CreateUnit(GetOwningPlayer(u),808477991,GetUnitX(u),GetUnitY(u),.0);//set c=CreateUnit(GetOwningPlayer(u),'e008',GetUnitX(u),GetUnitY(u),.0)
				UnitAddAbility(c, 'A09T');//call UnitAddAbility(c,'A09T')
				IssueTargetOrderById(c, $D0097, v);//call IssueTargetOrderById(c,$D0097,v)
				UnitApplyTimedLife(c, 'BTLF', 4.);//call UnitApplyTimedLife(c,'BTLF',4.)
				c = null;//set c=null
			}//endif
		}//endfunction
		private void oy(unit u, unit v) {//function oy takes unit u,unit v returns nothing
			unit c;//local unit c
			if ((GetRandomInt(0,99)<40)) {//if(GetRandomInt(0,99)<40)then
				c = CreateUnit(GetOwningPlayer(u),808477991,GetUnitX(u),GetUnitY(u),.0);//set c=CreateUnit(GetOwningPlayer(u),'e008',GetUnitX(u),GetUnitY(u),.0)
				UnitAddAbility(c, 'A0DC');//call UnitAddAbility(c,'A0DC')
				IssueTargetOrderById(c, $D011C, v);//call IssueTargetOrderById(c,$D011C,v)
				UnitApplyTimedLife(c, 'BTLF', 4.);//call UnitApplyTimedLife(c,'BTLF',4.)
				c = null;//set c=null
			}//endif
		}//endfunction
		private void py(unit v) {//function py takes unit v returns nothing
			int i = GetUnitAbilityLevel(v,1127235879);//local integer i=GetUnitAbilityLevel(v,'A0C9')
			if ((i<=0)) {//if(i<=0)then
				UnitAddAbility(v, 'A0C9');//call UnitAddAbility(v,'A0C9')
			} else if ((i<3)) {//elseif(i<3)then
				SetUnitAbilityLevel(v, 'A0C9', i+1);//call SetUnitAbilityLevel(v,'A0C9',i+1)
			}//endif
		}//endfunction
		private void qy(unit v) {//function qy takes unit v returns nothing
			unit u;//local unit u
			if ((GetRandomInt(0,99)<$F)) {//if(GetRandomInt(0,99)<$F)then
				u = CreateUnit(GetOwningPlayer(v),808477991,GetUnitX(v),GetUnitY(v),.0);//set u=CreateUnit(GetOwningPlayer(v),'e008',GetUnitX(v),GetUnitY(v),.0)
				UnitAddAbility(u, 'A0B7');//call UnitAddAbility(u,'A0B7')
				IssueTargetOrderById(u, $D0062, v);//call IssueTargetOrderById(u,$D0062,v)
				UnitApplyTimedLife(u, 'BTLF', 2.);//call UnitApplyTimedLife(u,'BTLF',2.)
				u = CreateUnit(GetOwningPlayer(v),808477991,GetUnitX(v),GetUnitY(v),.0);//set u=CreateUnit(GetOwningPlayer(v),'e008',GetUnitX(v),GetUnitY(v),.0)
				UnitAddAbility(u, 'A0B5');//call UnitAddAbility(u,'A0B5')
				IssueTargetOrderById(u, $D0085, v);//call IssueTargetOrderById(u,$D0085,v)
				UnitApplyTimedLife(u, 'BTLF', 2.);//call UnitApplyTimedLife(u,'BTLF',2.)
				u = null;//set u=null
			}//endif
		}//endfunction
		private void ry(unit v) {//function ry takes unit v returns nothing
			unit u;//local unit u
			if ((GetRandomInt(0,99)<20)) {//if(GetRandomInt(0,99)<20)then
				u = CreateUnit(GetOwningPlayer(v),808477991,GetUnitX(v),GetUnitY(v),.0);//set u=CreateUnit(GetOwningPlayer(v),'e008',GetUnitX(v),GetUnitY(v),.0)
				UnitAddAbility(u, 'A0B8');//call UnitAddAbility(u,'A0B8')
				IssueTargetOrderById(u, $D0062, v);//call IssueTargetOrderById(u,$D0062,v)
				UnitApplyTimedLife(u, 'BTLF', 2.);//call UnitApplyTimedLife(u,'BTLF',2.)
				u = CreateUnit(GetOwningPlayer(v),808477991,GetUnitX(v),GetUnitY(v),.0);//set u=CreateUnit(GetOwningPlayer(v),'e008',GetUnitX(v),GetUnitY(v),.0)
				UnitAddAbility(u, 'A0B6');//call UnitAddAbility(u,'A0B6')
				IssueTargetOrderById(u, $D0085, v);//call IssueTargetOrderById(u,$D0085,v)
				UnitApplyTimedLife(u, 'BTLF', 2.);//call UnitApplyTimedLife(u,'BTLF',2.)
				u = null;//set u=null
			}//endif
		}//endfunction
		private void uy(unit u) {//function uy takes unit u returns nothing
			if ((GetRandomInt(0,99)<$F)) {//if(GetRandomInt(0,99)<$F)then
				UnitRemoveBuffsEx(u, true, false, true, false, false, false, false);//call UnitRemoveBuffsEx(u,true,false,true,false,false,false,false)
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl", u, "overhead"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl",u,"overhead"))
			}//endif
		}//endfunction
		private void vy(unit u) {//function vy takes unit u returns nothing
			if ((GetRandomInt(0,99)<20)) {//if(GetRandomInt(0,99)<20)then
				UnitRemoveBuffsEx(u, true, false, true, false, false, false, false);//call UnitRemoveBuffsEx(u,true,false,true,false,false,false,false)
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl", u, "overhead"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl",u,"overhead"))
			}//endif
		}//endfunction
		private void wy() {//function wy takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u=GetEnumUnit()
			UnitRemoveBuffsEx(u, true, false, true, false, false, false, false);//call UnitRemoveBuffsEx(u,true,false,true,false,false,false,false)
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl", u, "overhead"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\MarkOfChaos\\MarkOfChaosDone.mdl",u,"overhead"))
			u = null;//set u=null
		}//endfunction
		private void xy(unit u, unit t) {//function xy takes unit u,unit t returns nothing
			r4 = GetOwningPlayer(u);//set r4=GetOwningPlayer(u)
			if ((GetRandomInt(0,99)<25)) {//if(GetRandomInt(0,99)<25)then
				GroupEnumUnitsInRange(q4, GetUnitX(t), GetUnitY(t), 100., y9);//call GroupEnumUnitsInRange(q4,GetUnitX(t),GetUnitY(t),100.,y9)
				ForGroup(q4, function wy);//call ForGroup(q4,function wy)
			}//endif
		}//endfunction
		private void yy(unit s, unit u) {//function yy takes unit s,unit u returns nothing
			int zy = GetUnitLevel(u);//local integer zy=GetUnitLevel(u)
			unit c;//local unit c
			if ((IsUnitType(s,UNIT_TYPE_MELEE_ATTACKER) && GetRandomInt(0,99)<=$F*zy)) {//if(IsUnitType(s,UNIT_TYPE_MELEE_ATTACKER)and GetRandomInt(0,99)<=$F*zy)then
				c = CreateUnit(GetOwningPlayer(u),808477991,GetUnitX(u),GetUnitY(u),.0);//set c=CreateUnit(GetOwningPlayer(u),'e008',GetUnitX(u),GetUnitY(u),.0)
				UnitAddAbility(c, 'A0D5');//call UnitAddAbility(c,'A0D5')
				SetUnitAbilityLevel(c, 'A0D5', zy);//call SetUnitAbilityLevel(c,'A0D5',zy)
				IssueTargetOrderById(c, $D007F, s);//call IssueTargetOrderById(c,$D007F,s)
				UnitApplyTimedLife(c, 'BTLF', 4.);//call UnitApplyTimedLife(c,'BTLF',4.)
				c = null;//set c=null
			}//endif
		}//endfunction
		private void Ay(unit u) {//function Ay takes unit u returns nothing
			if ((GetRandomInt(0,99)<20)) {//if(GetRandomInt(0,99)<20)then
				IssueImmediateOrderById(u, $D009B);//call IssueImmediateOrderById(u,$D009B)
			}//endif
		}//endfunction
		private void ay(unit u, float d) {//function ay takes unit u,real d returns nothing
			float mp = GetUnitState(u,UNIT_STATE_MANA)+d;//local real mp=GetUnitState(u,UNIT_STATE_MANA)+d
			if ((mp>=680.)) {//if(mp>=680.)then
				UnitRemoveAbility(u, 'A0C5');//call UnitRemoveAbility(u,'A0C5')
				SetUnitMoveSpeed(u, 450.);//call SetUnitMoveSpeed(u,450.)
				UnitAddAbility(u, 'A0EN');//call UnitAddAbility(u,'A0EN')
				IssueImmediateOrderById(u, $D0049);//call IssueImmediateOrderById(u,$D0049)
			} else {//else
				SetUnitState(u, UNIT_STATE_MANA, mp);//call SetUnitState(u,UNIT_STATE_MANA,mp)
			}//endif
		}//endfunction
		private void By(unit u) {//function By takes unit u returns nothing
			float r = GetWidgetLife(u);//local real r=GetWidgetLife(u)
			if ((r<128. && r>.405)) {//if(r<128. and r>.405)then
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Undead\\DeathPact\\DeathPactCaster.mdl", u, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Undead\\DeathPact\\DeathPactCaster.mdl",u,"origin"))
				SetWidgetLife(u, 5000.);//call SetWidgetLife(u,5000.)
				UnitRemoveAbility(u, 'A0EZ');//call UnitRemoveAbility(u,'A0EZ')
			}//endif
		}//endfunction
		private bool by() {//function by takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetWidgetLife(u)>.405 && IsUnitEnemy(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER) && GetUnitAbilityLevel(u,1970684199)<=0  && ((Of && IsUnitType(u,UNIT_TYPE_GROUND)) || (Pf && IsUnitType(u,UNIT_TYPE_FLYING)));//local boolean Im=GetWidgetLife(u)>.405 and IsUnitEnemy(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER)and GetUnitAbilityLevel(u,'Avul')<=0 and((Of and IsUnitType(u,UNIT_TYPE_GROUND))or(Pf and IsUnitType(u,UNIT_TYPE_FLYING)))
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void Cy(unit Ui, float cy, float x, float y, bool Dy, bool Ey) {//function Cy takes unit Ui,real cy,real x,real y,boolean Dy,boolean Ey returns nothing
			player p = GetOwningPlayer(Ui);//local player p=GetOwningPlayer(Ui)
			unit u = CreateUnit(p,808477991,x,y,.0);//local unit u=CreateUnit(p,'e008',x,y,.0)
			unit j;//local unit j
			r4 = p;//set r4=p
			Of = Dy;//set Of=Dy
			Pf = Ey;//set Pf=Ey
			GroupEnumUnitsInRange(q4, x, y, 250., Qf);//call GroupEnumUnitsInRange(q4,x,y,250.,Qf)
			while (true) {//loop
				j = FirstOfGroup(q4);//set j=FirstOfGroup(q4)
				if (j==null) { break; }//exitwhen j==null
				GroupRemoveUnit(q4, j);//call GroupRemoveUnit(q4,j)
				UnitDamageTarget(u, j, cy, true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_UNKNOWN, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(u,j,cy,true,false,ATTACK_TYPE_CHAOS,DAMAGE_TYPE_UNKNOWN,WEAPON_TYPE_WHOKNOWS)
			}//endloop
			UnitApplyTimedLife(u, 'BTLF', 1.);//call UnitApplyTimedLife(u,'BTLF',1.)
			u = null;//set u=null
		}//endfunction
		private bool Fy() {//function Fy takes nothing returns boolean
			unit s = GetEventDamageSource();//local unit s=GetEventDamageSource()
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			int Gy;//local integer Gy
			if ((GetUnitAbilityLevel(s,858800423)>0)) {//if(GetUnitAbilityLevel(s,'A03Q')>0)then
				if ((GetUnitAbilityLevel(s,1177567527)>0)) {//if(GetUnitAbilityLevel(s,'A0F1')>0)then
					Cy(s, .5*GetEventDamage(), GetUnitX(u), GetUnitY(u), IsUnitType(s, UNIT_TYPE_ATTACKS_GROUND), IsUnitType(s, UNIT_TYPE_ATTACKS_FLYING));//call Cy(s,.5*GetEventDamage(),GetUnitX(u),GetUnitY(u),IsUnitType(s,UNIT_TYPE_ATTACKS_GROUND),IsUnitType(s,UNIT_TYPE_ATTACKS_FLYING))
				}//endif
				Gy = GetUnitTypeId(s);//set Gy=GetUnitTypeId(s)
				if ((Gy==808482087)) {//if(Gy=='u00D')then
					ky(s, u);//call ky(s,u)
				} else if ((Gy==892364839)) {//elseif(Gy=='h05L')then
					ny(s, u);//call ny(s,u)
				} else if ((Gy==909142055)) {//elseif(Gy=='h061')then
					oy(s, u);//call oy(s,u)
				} else if ((Gy==842034727)) {//elseif(Gy=='n02A')then
					py(u);//call py(u)
				} else if ((Gy==842034727)) {//elseif(Gy=='n02B')then
					UnitRemoveAbility(s, 'A0C8');//call UnitRemoveAbility(s,'A0C8')
				} else if ((Gy==808477991)) {//elseif(Gy=='e006')then
					uy(u);//call uy(u)
				} else if ((Gy==808477991)) {//elseif(Gy=='e009')then
					vy(u);//call vy(u)
				} else if ((Gy==808477991)) {//elseif(Gy=='e00C')then
					xy(s, u);//call xy(s,u)
				} else if ((GetUnitAbilityLevel(s,1144013095)>0)) {//elseif(GetUnitAbilityLevel(s,'A0DW')>0)then
					DisableTrigger(Nf);//call DisableTrigger(Nf)
					UnitDamageTarget(s, u, 50.*GetUnitLevel(s)*GetWidgetLife(s)/ GetUnitState(s, UNIT_STATE_MAX_LIFE), true, false, ATTACK_TYPE_SIEGE, DAMAGE_TYPE_DEMOLITION, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(s,u,50.*GetUnitLevel(s)*GetWidgetLife(s)/ GetUnitState(s,UNIT_STATE_MAX_LIFE),true,false,ATTACK_TYPE_SIEGE,DAMAGE_TYPE_DEMOLITION,WEAPON_TYPE_WHOKNOWS)
					EnableTrigger(Nf);//call EnableTrigger(Nf)
				} else if ((Gy==842033191)) {//elseif(Gy=='h02Y')then
					Ay(s);//call Ay(s)
				}//endif
			}//endif
			if ((GetWidgetLife(u)>.405 && GetUnitAbilityLevel(u,1127235879)>0)) {//if(GetWidgetLife(u)>.405 and GetUnitAbilityLevel(u,'A0C5')>0)then
				Gy = GetUnitTypeId(u);//set Gy=GetUnitTypeId(u)
				if ((Gy==842034727)) {//if(Gy=='n029')then
					qy(u);//call qy(u)
					if ((GetUnitAbilityLevel(u,1127235879)>0 && GetWidgetLife(u)<255.)) {//if(GetUnitAbilityLevel(u,'A0C4')>0 and GetWidgetLife(u)<255.)then
						jx(u);//call jx(u)
					} else {//else
						UnitRemoveAbility(u, 'Asla');//call UnitRemoveAbility(u,'Asla')
						UnitRemoveAbility(u, 'A0C6');//call UnitRemoveAbility(u,'A0C6')
					}//endif
				} else if ((Gy==842034727)) {//elseif(Gy=='n02B')then
					ry(u);//call ry(u)
					if ((GetUnitAbilityLevel(u,1127235879)>0 && GetWidgetLife(u)<255.)) {//if(GetUnitAbilityLevel(u,'A0C4')>0 and GetWidgetLife(u)<255.)then
						ix(u);//call ix(u)
					} else {//else
						UnitRemoveAbility(u, 'Asla');//call UnitRemoveAbility(u,'Asla')
						UnitRemoveAbility(u, 'A0C7');//call UnitRemoveAbility(u,'A0C7')
					}//endif
				} else if ((GetUnitAbilityLevel(u,1144013095)>0)) {//elseif(GetUnitAbilityLevel(u,'A0DX')>0)then
					yy(s, u);//call yy(s,u)
				} else if ((GetUnitAbilityLevel(u,1160790311)>0)) {//elseif(GetUnitAbilityLevel(u,'A0EZ')>0)then
					By(u);//call By(u)
				} else if ((Gy==808480551)) {//elseif(Gy=='o00E')then
					ay(u, GetEventDamage());//call ay(u,GetEventDamage())
				}//endif
			}//endif
			if ((zd)) {//if(zd)then
				yr(u);//call yr(u)
			}//endif
			u = null;//set u=null
			s = null;//set s=null
			return false;//return false
		}//endfunction
		private void Hy() {//function Hy takes nothing returns nothing
			if ((Nf!=null)) {//if(Nf!=null)then
				TriggerClearActions(Nf);//call TriggerClearActions(Nf)
				DestroyTrigger(Nf);//call DestroyTrigger(Nf)
			}//endif
			Nf = CreateTrigger();//set Nf=CreateTrigger()
			TriggerAddAction(Nf, function Fy);//call TriggerAddAction(Nf,function Fy)
			Qf = Filter(function by);//set Qf=Filter(function by)
		}//endfunction
		private void Iy() {//function Iy takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((D9[i]!=null)) {//if(D9[i]!=null)then
					if ((GetLocalPlayer()==Player(i))) {//if(GetLocalPlayer()==Player(i))then
						MultiboardDisplay(D9[i], true);//call MultiboardDisplay(D9[i],true)
					}//endif
				} else {//else
					if ((GetLocalPlayer()==Player(i))) {//if(GetLocalPlayer()==Player(i))then
						MultiboardDisplay(G9, true);//call MultiboardDisplay(G9,true)
					}//endif
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void ly() {//function ly takes nothing returns nothing
			int i = 0;//local integer i=0
			int x = 0;//local integer x=0
			multiboarditem Jy;//local multiboarditem Jy
			player p;//local player p
			while (true) {//loop
				if ((E9[i]!=null)) {//if(E9[i]!=null)then
					p = Player(i);//set p=Player(i)
					Jy = MultiboardGetItem(E9[i],F9[i],3);//set Jy=MultiboardGetItem(E9[i],F9[i],3)
					MultiboardSetItemValue(Jy, I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_GOLD)));//call MultiboardSetItemValue(Jy,I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)))
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					Jy = MultiboardGetItem(E9[i],F9[i],4);//set Jy=MultiboardGetItem(E9[i],F9[i],4)
					MultiboardSetItemValue(Jy, I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_LUMBER)));//call MultiboardSetItemValue(Jy,I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_LUMBER)))
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					Jy = MultiboardGetItem(E9[i],F9[i],5);//set Jy=MultiboardGetItem(E9[i],F9[i],5)
					MultiboardSetItemValue(Jy, I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_FOOD_USED))+"/"+I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_FOOD_CAP)));//call MultiboardSetItemValue(Jy,I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_FOOD_USED))+"/"+I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_FOOD_CAP)))
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				}//endif
				if ((H9[i]>0)) {//if(H9[i]>0)then
					p = Player(i);//set p=Player(i)
					if ((IsPlayerInForce(p,ie))) {//if(IsPlayerInForce(p,ie))then
						x = 0;//set x=0
					} else {//else
						x = 6;//set x=6
					}//endif
					Jy = MultiboardGetItem(G9,H9[i],x+2);//set Jy=MultiboardGetItem(G9,H9[i],x+2)
					MultiboardSetItemValue(Jy, I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_GOLD)));//call MultiboardSetItemValue(Jy,I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)))
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					Jy = MultiboardGetItem(G9,H9[i],x+3);//set Jy=MultiboardGetItem(G9,H9[i],x+3)
					MultiboardSetItemValue(Jy, I2S(GetPlayerState(p, PLAYER_STATE_RESOURCE_LUMBER)));//call MultiboardSetItemValue(Jy,I2S(GetPlayerState(p,PLAYER_STATE_RESOURCE_LUMBER)))
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					Jy = MultiboardGetItem(G9,H9[i],x+4);//set Jy=MultiboardGetItem(G9,H9[i],x+4)
					MultiboardSetItemValue(Jy, I2S(nf[i]));//call MultiboardSetItemValue(Jy,I2S(nf[i]))
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			Jy = null;//set Jy=null
		}//endfunction
		private void Ky(int dk, string Ly) {//function Ky takes integer dk,string Ly returns nothing
			int i = 0;//local integer i=0
			int j = 0;//local integer j=0
			multiboarditem Jy;//local multiboarditem Jy
			MultiboardSetRowCount(D9[dk], CountPlayersInForceBJ(ne[dk])+6);//call MultiboardSetRowCount(D9[dk],CountPlayersInForceBJ(ne[dk])+6)
			Jy = MultiboardGetItem(D9[dk],4,0);//set Jy=MultiboardGetItem(D9[dk],4,0)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],4,1);//set Jy=MultiboardGetItem(D9[dk],4,1)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],4,2);//set Jy=MultiboardGetItem(D9[dk],4,2)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],4,3);//set Jy=MultiboardGetItem(D9[dk],4,3)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],4,4);//set Jy=MultiboardGetItem(D9[dk],4,4)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],4,5);//set Jy=MultiboardGetItem(D9[dk],4,5)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],5,0);//set Jy=MultiboardGetItem(D9[dk],5,0)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],5,1);//set Jy=MultiboardGetItem(D9[dk],5,1)
			MultiboardSetItemStyle(Jy, true, false);//call MultiboardSetItemStyle(Jy,true,false)
			MultiboardSetItemValue(Jy, Ly);//call MultiboardSetItemValue(Jy,Ly)
			MultiboardSetItemWidth(Jy, .1);//call MultiboardSetItemWidth(Jy,.1)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],5,2);//set Jy=MultiboardGetItem(D9[dk],5,2)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],5,3);//set Jy=MultiboardGetItem(D9[dk],5,3)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],5,4);//set Jy=MultiboardGetItem(D9[dk],5,4)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(D9[dk],5,5);//set Jy=MultiboardGetItem(D9[dk],5,5)
			MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			while (true) {//loop
				if ((IsPlayerInForce(Player(i),ne[dk]))) {//if(IsPlayerInForce(Player(i),ne[dk]))then
					Jy = MultiboardGetItem(D9[dk],j+6,0);//set Jy=MultiboardGetItem(D9[dk],j+6,0)
					MultiboardSetItemStyle(Jy, true, false);//call MultiboardSetItemStyle(Jy,true,false)
					MultiboardSetItemValue(Jy, pe[i]);//call MultiboardSetItemValue(Jy,pe[i])
					MultiboardSetItemWidth(Jy, .09);//call MultiboardSetItemWidth(Jy,.09)
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					Jy = MultiboardGetItem(D9[dk],j+6,1);//set Jy=MultiboardGetItem(D9[dk],j+6,1)
					MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
					MultiboardSetItemWidth(Jy, .0001);//call MultiboardSetItemWidth(Jy,.0001)
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					Jy = MultiboardGetItem(D9[dk],j+6,2);//set Jy=MultiboardGetItem(D9[dk],j+6,2)
					MultiboardSetItemStyle(Jy, false, false);//call MultiboardSetItemStyle(Jy,false,false)
					MultiboardSetItemWidth(Jy, .0001);//call MultiboardSetItemWidth(Jy,.0001)
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					Jy = MultiboardGetItem(D9[dk],j+6,3);//set Jy=MultiboardGetItem(D9[dk],j+6,3)
					MultiboardSetItemStyle(Jy, true, true);//call MultiboardSetItemStyle(Jy,true,true)
					MultiboardSetItemIcon(Jy, "UI\\Feedback\\Resources\\ResourceGold.blp");//call MultiboardSetItemIcon(Jy,"UI\\Feedback\\Resources\\ResourceGold.blp")
					MultiboardSetItemWidth(Jy, .035);//call MultiboardSetItemWidth(Jy,.035)
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					Jy = MultiboardGetItem(D9[dk],j+6,4);//set Jy=MultiboardGetItem(D9[dk],j+6,4)
					MultiboardSetItemStyle(Jy, true, true);//call MultiboardSetItemStyle(Jy,true,true)
					MultiboardSetItemIcon(Jy, "UI\\Feedback\\Resources\\ResourceLumber.blp");//call MultiboardSetItemIcon(Jy,"UI\\Feedback\\Resources\\ResourceLumber.blp")
					MultiboardSetItemWidth(Jy, .035);//call MultiboardSetItemWidth(Jy,.035)
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					Jy = MultiboardGetItem(D9[dk],j+6,5);//set Jy=MultiboardGetItem(D9[dk],j+6,5)
					MultiboardSetItemStyle(Jy, true, true);//call MultiboardSetItemStyle(Jy,true,true)
					MultiboardSetItemIcon(Jy, "UI\\Feedback\\Resources\\ResourceManaStone.blp");//call MultiboardSetItemIcon(Jy,"UI\\Feedback\\Resources\\ResourceManaStone.blp")
					MultiboardSetItemWidth(Jy, .03);//call MultiboardSetItemWidth(Jy,.03)
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					E9[i] = D9[dk];//set E9[i]=D9[dk]
					F9[i] = j+6;//set F9[i]=j+6
					j = j+1;//set j=j+1
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			Jy = null;//set Jy=null
		}//endfunction
		private void My() {//function My takes nothing returns nothing
			int i = IMaxBJ(CountPlayersInForceBJ(ie),CountPlayersInForceBJ(je));//local integer i=IMaxBJ(CountPlayersInForceBJ(ie),CountPlayersInForceBJ(je))
			int j = 0;//local integer j=0
			multiboarditem Jy;//local multiboarditem Jy
			MultiboardSetTitleText(G9, Rf);//call MultiboardSetTitleText(G9,Rf)
			MultiboardSetRowCount(G9, 6+i);//call MultiboardSetRowCount(G9,6+i)
			I9 = 4+i;//set I9=4+i
			MultiboardSetColumnCount(G9, $B);//call MultiboardSetColumnCount(G9,$B)
			MultiboardSetItemStyleBJ(G9, 0, 0, true, false);//call MultiboardSetItemStyleBJ(G9,0,0,true,false)
			MultiboardSetItemWidthBJ(G9, 1, 0, 8.);//call MultiboardSetItemWidthBJ(G9,1,0,8.)
			MultiboardSetItemWidthBJ(G9, 6, 0, 1.);//call MultiboardSetItemWidthBJ(G9,6,0,1.)
			MultiboardSetItemWidthBJ(G9, 7, 0, 8.);//call MultiboardSetItemWidthBJ(G9,7,0,8.)
			Jy = MultiboardGetItem(G9,I9+1,0);//set Jy=MultiboardGetItem(G9,I9+1,0)
			MultiboardSetItemWidth(Jy, 10.);//call MultiboardSetItemWidth(Jy,10.)
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			i = 0;//set i=0
			while (true) {//loop
				Jy = MultiboardGetItem(G9,0,i+0);//set Jy=MultiboardGetItem(G9,0,i+0)
				MultiboardSetItemValue(Jy, "|cffFFFF80Team|r");//call MultiboardSetItemValue(Jy,"|cffFFFF80Team|r")
				MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				Jy = MultiboardGetItem(G9,0,i+1);//set Jy=MultiboardGetItem(G9,0,i+1)
				MultiboardSetItemValue(Jy, "|cffFFFF80Resc.|r");//call MultiboardSetItemValue(Jy,"|cffFFFF80Resc.|r")
				MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				Jy = MultiboardGetItem(G9,0,i+2);//set Jy=MultiboardGetItem(G9,0,i+2)
				MultiboardSetItemValue(Jy, "|cffFFFF80Destr.|r");//call MultiboardSetItemValue(Jy,"|cffFFFF80Destr.|r")
				MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				Jy = MultiboardGetItem(G9,0,i+3);//set Jy=MultiboardGetItem(G9,0,i+3)
				MultiboardSetItemValue(Jy, "|cffFFFF80Income|r");//call MultiboardSetItemValue(Jy,"|cffFFFF80Income|r")
				MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				Jy = MultiboardGetItem(G9,0,i+4);//set Jy=MultiboardGetItem(G9,0,i+4)
				MultiboardSetItemValue(Jy, "|cffFFFF80Wins|r");//call MultiboardSetItemValue(Jy,"|cffFFFF80Wins|r")
				MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				MultiboardSetItemWidthBJ(G9, i+5, 0, 1.8);//call MultiboardSetItemWidthBJ(G9,i+5,0,1.8)
				i = i+(6);//set i=i+(6)
				if (i>6) { break; }//exitwhen i>6
			}//endloop
			Jy = MultiboardGetItem(G9,1,0);//set Jy=MultiboardGetItem(G9,1,0)
			MultiboardSetItemValue(Jy, "|cffFF0000West|r");//call MultiboardSetItemValue(Jy,"|cffFF0000West|r")
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(G9,1,6);//set Jy=MultiboardGetItem(G9,1,6)
			MultiboardSetItemValue(Jy, "|cff00FF00East|r");//call MultiboardSetItemValue(Jy,"|cff00FF00East|r")
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(G9,1,2);//set Jy=MultiboardGetItem(G9,1,2)
			MultiboardSetItemValue(Jy, "0");//call MultiboardSetItemValue(Jy,"0")
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(G9,1,8);//set Jy=MultiboardGetItem(G9,1,8)
			MultiboardSetItemValue(Jy, "0");//call MultiboardSetItemValue(Jy,"0")
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(G9,1,4);//set Jy=MultiboardGetItem(G9,1,4)
			MultiboardSetItemValue(Jy, I2S(Hd[0]));//call MultiboardSetItemValue(Jy,I2S(Hd[0]))
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			Jy = MultiboardGetItem(G9,1,$A);//set Jy=MultiboardGetItem(G9,1,$A)
			MultiboardSetItemValue(Jy, I2S(Hd[1]));//call MultiboardSetItemValue(Jy,I2S(Hd[1]))
			MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
			i = 0;//set i=0
			while (true) {//loop
				Jy = MultiboardGetItem(G9,3,i+0);//set Jy=MultiboardGetItem(G9,3,i+0)
				MultiboardSetItemValue(Jy, "|cffFFFF80Player|r");//call MultiboardSetItemValue(Jy,"|cffFFFF80Player|r")
				MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				Jy = MultiboardGetItem(G9,3,i+1);//set Jy=MultiboardGetItem(G9,3,i+1)
				MultiboardSetItemStyle(Jy, false, true);//call MultiboardSetItemStyle(Jy,false,true)
				MultiboardSetItemIcon(Jy, "ReplaceableTextures\\CommandButtons\\BTNHolyBolt.blp");//call MultiboardSetItemIcon(Jy,"ReplaceableTextures\\CommandButtons\\BTNHolyBolt.blp")
				MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				Jy = MultiboardGetItem(G9,3,i+2);//set Jy=MultiboardGetItem(G9,3,i+2)
				MultiboardSetItemStyle(Jy, false, true);//call MultiboardSetItemStyle(Jy,false,true)
				MultiboardSetItemIcon(Jy, "UI\\Feedback\\Resources\\ResourceGold.blp");//call MultiboardSetItemIcon(Jy,"UI\\Feedback\\Resources\\ResourceGold.blp")
				MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				Jy = MultiboardGetItem(G9,3,i+3);//set Jy=MultiboardGetItem(G9,3,i+3)
				MultiboardSetItemStyle(Jy, false, true);//call MultiboardSetItemStyle(Jy,false,true)
				MultiboardSetItemIcon(Jy, "UI\\Feedback\\Resources\\ResourceLumber.blp");//call MultiboardSetItemIcon(Jy,"UI\\Feedback\\Resources\\ResourceLumber.blp")
				MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				Jy = MultiboardGetItem(G9,3,i+4);//set Jy=MultiboardGetItem(G9,3,i+4)
				MultiboardSetItemStyle(Jy, false, true);//call MultiboardSetItemStyle(Jy,false,true)
				MultiboardSetItemIcon(Jy, "ReplaceableTextures\\CommandButtons\\BTNChestOfGold.blp");//call MultiboardSetItemIcon(Jy,"ReplaceableTextures\\CommandButtons\\BTNChestOfGold.blp")
				MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
				i = i+(6);//set i=i+(6)
				if (i>6) { break; }//exitwhen i>6
			}//endloop
			i = 0;//set i=0
			j = 4;//set j=4
			while (true) {//loop
				if ((IsPlayerInForce(Player(i),ie))) {//if(IsPlayerInForce(Player(i),ie))then
					H9[i] = j;//set H9[i]=j
					Jy = MultiboardGetItem(G9,H9[i],0);//set Jy=MultiboardGetItem(G9,H9[i],0)
					MultiboardSetItemValue(Jy, pe[i]);//call MultiboardSetItemValue(Jy,pe[i])
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					j = j+1;//set j=j+1
				} else {//else
					H9[i] = 0;//set H9[i]=0
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			i = 0;//set i=0
			j = 4;//set j=4
			while (true) {//loop
				if ((IsPlayerInForce(Player(i),je))) {//if(IsPlayerInForce(Player(i),je))then
					H9[i] = j;//set H9[i]=j
					Jy = MultiboardGetItem(G9,H9[i],6);//set Jy=MultiboardGetItem(G9,H9[i],6)
					MultiboardSetItemValue(Jy, pe[i]);//call MultiboardSetItemValue(Jy,pe[i])
					MultiboardReleaseItem(Jy);//call MultiboardReleaseItem(Jy)
					j = j+1;//set j=j+1
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			Jy = null;//set Jy=null
		}//endfunction
		private void Ny() {//function Ny takes nothing returns nothing
			int i = 0;//local integer i=0
			player p;//local player p
			string Oy = GetLocalizedString("TEAM_RESOURCES")+":";//local string Oy=GetLocalizedString("TEAM_RESOURCES")+":"
			if ((bd>0 || Dd>0)) {//if(bd>0 or Dd>0)then
				if ((h8)) {//if(h8)then
					Ts();//call Ts()
				}//endif
			}//endif
			if ((h8)) {//if(h8)then
				Bn();//call Bn()
			}//endif
			if ((G9!=null)) {//if(G9!=null)then
				DestroyMultiboard(G9);//call DestroyMultiboard(G9)
			}//endif
			G9 = CreateMultiboard();//set G9=CreateMultiboard()
			My();//call My()
			while (true) {//loop
				p = Player(i);//set p=Player(i)
				if ((ne[i]!=null)) {//if(ne[i]!=null)then
					if ((D9[i]!=null)) {//if(D9[i]!=null)then
						DestroyMultiboard(D9[i]);//call DestroyMultiboard(D9[i])
					}//endif
					D9[i] = CreateMultiboard();//set D9[i]=CreateMultiboard()
					MultiboardSetRowCount(D9[i], 4);//call MultiboardSetRowCount(D9[i],4)
					MultiboardSetColumnCount(D9[i], 6);//call MultiboardSetColumnCount(D9[i],6)
					MultiboardSetTitleText(D9[i], Rf);//call MultiboardSetTitleText(D9[i],Rf)
					MultiboardSetItemStyleBJ(D9[i], 0, 0, true, false);//call MultiboardSetItemStyleBJ(D9[i],0,0,true,false)
					MultiboardSetItemValueBJ(D9[i], 0, 0, "0");//call MultiboardSetItemValueBJ(D9[i],0,0,"0")
					MultiboardSetItemValueBJ(D9[i], 0, 4, "");//call MultiboardSetItemValueBJ(D9[i],0,4,"")
					MultiboardSetItemColorBJ(D9[i], 6, 0, 'd', 90., .0, 0);//call MultiboardSetItemColorBJ(D9[i],6,0,'d',90.,.0,0)
					MultiboardSetItemValueBJ(D9[i], 1, 1, "");//call MultiboardSetItemValueBJ(D9[i],1,1,"")
					MultiboardSetItemValueBJ(D9[i], 2, 1, "Resc.");//call MultiboardSetItemValueBJ(D9[i],2,1,"Resc.")
					MultiboardSetItemValueBJ(D9[i], 3, 1, "Coins");//call MultiboardSetItemValueBJ(D9[i],3,1,"Coins")
					MultiboardSetItemValueBJ(D9[i], 4, 1, "Destr.");//call MultiboardSetItemValueBJ(D9[i],4,1,"Destr.")
					MultiboardSetItemValueBJ(D9[i], 5, 1, "Income");//call MultiboardSetItemValueBJ(D9[i],5,1,"Income")
					MultiboardSetItemValueBJ(D9[i], 6, 1, "|cffFFFF80Wins|r");//call MultiboardSetItemValueBJ(D9[i],6,1,"|cffFFFF80Wins|r")
					MultiboardSetItemValueBJ(D9[i], 1, 2, "|cffFF0000West|r");//call MultiboardSetItemValueBJ(D9[i],1,2,"|cffFF0000West|r")
					MultiboardSetItemValueBJ(D9[i], 1, 3, "|cff00FF00East|r");//call MultiboardSetItemValueBJ(D9[i],1,3,"|cff00FF00East|r")
					MultiboardSetItemValueBJ(D9[i], 1, 4, "|cffFFFF00Round Time:|r");//call MultiboardSetItemValueBJ(D9[i],1,4,"|cffFFFF00Round Time:|r")
					MultiboardSetItemValueBJ(D9[i], 6, 4, "|cffFFFF000|cffFF8000:|cffFFFF0000|r");//call MultiboardSetItemValueBJ(D9[i],6,4,"|cffFFFF000|cffFF8000:|cffFFFF0000|r")
					MultiboardSetItemWidthBJ(D9[i], 0, 4, 2.);//call MultiboardSetItemWidthBJ(D9[i],0,4,2.)
					MultiboardSetItemWidthBJ(D9[i], 1, 4, 7.);//call MultiboardSetItemWidthBJ(D9[i],1,4,7.)
					MultiboardSetItemWidthBJ(D9[i], 6, 4, 3.);//call MultiboardSetItemWidthBJ(D9[i],6,4,3.)
					if ((CountPlayersInForceBJ(ne[i])>0)) {//if(CountPlayersInForceBJ(ne[i])>0)then
						Ky(i, Oy);//call Ky(i,Oy)
					}//endif
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			if ((Sf==null)) {//if(Sf==null)then
				Sf = CreateTimer();//set Sf=CreateTimer()
				TimerStart(Sf, 1., true, function ly);//call TimerStart(Sf,1.,true,function ly)
			}//endif
			Yr(5, 1, I2S(Hd[0]));//call Yr(5,1,I2S(Hd[0]))
			Yr(5, 2, I2S(Hd[1]));//call Yr(5,2,I2S(Hd[1]))
			Iy();//call Iy()
		}//endfunction
		private void Py() {//function Py takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				if ((Uf[i]>3)) {//if(Uf[i]>3)then
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[i]+" |c00ff0000have used stopping bug!|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[i]+" |c00ff0000have used stopping bug!|r")
				}//endif
				Uf[i] = 0;//set Uf[i]=0
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private bool Qy() {//function Qy takes nothing returns boolean
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			if ((GetIssuedOrderId()==$D0003)) {//if(GetIssuedOrderId()==$D0003)then
				Vf[GetPlayerId(GetOwningPlayer(u))] = M9;//set Vf[GetPlayerId(GetOwningPlayer(u))]=M9
				if ((IsUnitType(u,UNIT_TYPE_SAPPER))) {//if(IsUnitType(u,UNIT_TYPE_SAPPER))then
					Qo(u);//call Qo(u)
				} else if ((GetUnitTypeId(u)==808478759)) {//elseif(GetUnitTypeId(u)=='h001')then
					cv(u);//call cv(u)
				}//endif
			}//endif
			u = null;//set u=null
			return false;//return false
		}//endfunction
		private bool Ry() {//function Ry takes nothing returns boolean
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			int dk = GetPlayerId(GetOwningPlayer(u));//local integer dk=GetPlayerId(GetOwningPlayer(u))
			if ((GetIssuedOrderId()==$D0003)) {//if(GetIssuedOrderId()==$D0003)then
				Vf[GetPlayerId(GetOwningPlayer(u))] = M9;//set Vf[GetPlayerId(GetOwningPlayer(u))]=M9
				if ((IsUnitType(u,UNIT_TYPE_SAPPER))) {//if(IsUnitType(u,UNIT_TYPE_SAPPER))then
					Qo(u);//call Qo(u)
					Uf[dk] = Uf[dk]+1;//set Uf[dk]=Uf[dk]+1
				} else if ((GetUnitTypeId(u)==808478759)) {//elseif(GetUnitTypeId(u)=='h001')then
					cv(u);//call cv(u)
				}//endif
			}//endif
			u = null;//set u=null
			return false;//return false
		}//endfunction
		private void Sy() {//function Sy takes nothing returns nothing
			if ((Tf!=null)) {//if(Tf!=null)then
				return;//return
			}//endif
			Tf = CreateTrigger();//set Tf=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(Tf, EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER);//call TriggerRegisterAnyUnitEventBJ(Tf,EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER)
			TriggerRegisterAnyUnitEventBJ(Tf, EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER);//call TriggerRegisterAnyUnitEventBJ(Tf,EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER)
			if ((wd)) {//if(wd)then
				TriggerAddCondition(Tf, Condition(function Ry));//call TriggerAddCondition(Tf,Condition(function Ry))
				TimerStart(CreateTimer(), 1.5, true, function Py);//call TimerStart(CreateTimer(),1.5,true,function Py)
			} else {//else
				TriggerAddCondition(Tf, Condition(function Qy));//call TriggerAddCondition(Tf,Condition(function Qy))
			}//endif
		}//endfunction
		private void Ty() {//function Ty takes nothing returns nothing
			int i = 0;//local integer i=0
			player p;//local player p
			while (true) {//loop
				p = Player(i);//set p=Player(i)
				if ((GetPlayerSlotState(p)==PLAYER_SLOT_STATE_PLAYING && GetPlayerController(p)==MAP_CONTROL_USER && !qe[i])) {//if(GetPlayerSlotState(p)==PLAYER_SLOT_STATE_PLAYING and GetPlayerController(p)==MAP_CONTROL_USER and not qe[i])then
					if ((M9-Vf[i]>4)) {//if(M9-Vf[i]>4)then
						DisplayTextToPlayer(Player(i), .0, .0, "|cffCA0000WARNING|r: You did not move your worker for 5 minutes. AI will take control in 60 seconds!");//call DisplayTextToPlayer(Player(i),.0,.0,"|cffCA0000WARNING|r: You did not move your worker for 5 minutes. AI will take control in 60 seconds!")
						if ((M9-Vf[i]>5)) {//if(M9-Vf[i]>5)then
							Kt(i);//call Kt(i)
						}//endif
					}//endif
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void Uy() {//function Uy takes nothing returns nothing
			if ((Wf!=null)) {//if(Wf!=null)then
				PauseTimer(Wf);//call PauseTimer(Wf)
			}//endif
		}//endfunction
		private void Vy() {//function Vy takes nothing returns nothing
			int i = 0;//local integer i=0
			while (true) {//loop
				Vf[i] = 0;//set Vf[i]=0
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			if ((Wf!=null)) {//if(Wf!=null)then
				TimerStart(Wf, 60., true, function Ty);//call TimerStart(Wf,60.,true,function Ty)
			}//endif
		}//endfunction
		private void Wy() {//function Wy takes nothing returns nothing
			if ((Wf==null)) {//if(Wf==null)then
				Wf = CreateTimer();//set Wf=CreateTimer()
			}//endif
		}//endfunction
		private void Xy(bool fl) {//function Xy takes boolean fl returns nothing
			string s1;//local string s1
			string s2;//local string s2
			if (((!fl) && fg)) {//if((not fl)and fg)then
				return;//return
			}//endif
			fg = true;//set fg=true
			if ((dd==1)) {//if(dd==1)then
				if ((Z9==0)) {//if(Z9==0)then
					s1 = pe[0]+" has chosen single round/pick race. You may pick your race! The first round determines the winner!";//set s1=pe[0]+" has chosen single round/pick race. You may pick your race! The first round determines the winner!"
					s2 = "Single Round Pick";//set s2="Single Round Pick"
				} else if ((Z9==1)) {//elseif(Z9==1)then
					s1 = pe[0]+" has chosen single round/random race. You will get a random race! The first round determines the winner!";//set s1=pe[0]+" has chosen single round/random race. You will get a random race! The first round determines the winner!"
					s2 = "Single Round Random";//set s2="Single Round Random"
				} else if ((Z9==2)) {//elseif(Z9==2)then
					s1 = pe[0]+" has chosen single round/mirror mode. Both teams will get the same random races! The first round determines the winner!";//set s1=pe[0]+" has chosen single round/mirror mode. Both teams will get the same random races! The first round determines the winner!"
					s2 = "Single Round Random";//set s2="Single Round Random"
				} else if ((Z9==3)) {//elseif(Z9==3)then
					s1 = pe[0]+" has chosen single round/draft race. Races will be drafted! The first round determines the winner!";//set s1=pe[0]+" has chosen single round/draft race. Races will be drafted! The first round determines the winner!"
					s2 = "Single Round Draft";//set s2="Single Round Draft"
				}//endif
			} else {//else
				if ((jd)) {//if(jd)then
					if ((Z9==0)) {//if(Z9==0)then
						s1 = pe[0]+" has chosen |cffFFFF00pick|r race. You may pick a race at the beginning that you keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";//set s1=pe[0]+" has chosen |cffFFFF00pick|r race. You may pick a race at the beginning that you keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r"
						s2 = "Pick once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";//set s2="Pick once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins"
					} else if ((Z9==1)) {//elseif(Z9==1)then
						s1 = pe[0]+" has chosen |cffFFFF00random|r race. You will get a random race at the beginning that you keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";//set s1=pe[0]+" has chosen |cffFFFF00random|r race. You will get a random race at the beginning that you keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r"
						s2 = "Random once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";//set s2="Random once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins"
					} else if ((Z9==2)) {//elseif(Z9==2)then
						s1 = pe[0]+" has chosen |cffFFFF00mirror mode|r. Both teams will get the same random races at the beginning that they will keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";//set s1=pe[0]+" has chosen |cffFFFF00mirror mode|r. Both teams will get the same random races at the beginning that they will keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r"
						s2 = "Mirror once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";//set s2="Mirror once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins"
					} else if ((Z9==3)) {//elseif(Z9==3)then
						s1 = pe[0]+" has chosen |cffFFFF00draft|r race. You will draft a race at the beginning that you keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";//set s1=pe[0]+" has chosen |cffFFFF00draft|r race. You will draft a race at the beginning that you keep for the |cffFFFF00whole game|r! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r"
						s2 = "Draft once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";//set s2="Draft once, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins"
					}//endif
				} else {//else
					if ((Z9==0)) {//if(Z9==0)then
						s1 = pe[0]+" has chosen |cffFFFF00pick|r race |cffFFFF00each round|r. You may pick a new race each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";//set s1=pe[0]+" has chosen |cffFFFF00pick|r race |cffFFFF00each round|r. You may pick a new race each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r"
						s2 = "Pick each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";//set s2="Pick each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins"
					} else if ((Z9==1)) {//elseif(Z9==1)then
						s1 = pe[0]+" has chosen |cffFFFF00random|r race |cffFFFF00each round|r. You will get a new random race each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";//set s1=pe[0]+" has chosen |cffFFFF00random|r race |cffFFFF00each round|r. You will get a new random race each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r"
						s2 = "Random each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";//set s2="Random each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins"
					} else if ((Z9==2)) {//elseif(Z9==2)then
						s1 = pe[0]+" has chosen  |cffFFFF00mirror mode each round|r. Both teams will get the same random races each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";//set s1=pe[0]+" has chosen  |cffFFFF00mirror mode each round|r. Both teams will get the same random races each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r"
						s2 = "Mirror each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";//set s2="Mirror each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins"
					} else if ((Z9==3)) {//elseif(Z9==3)then
						s1 = pe[0]+" has chosen |cffFFFF00draft|r race |cffFFFF00each round|r. You will draft a new race each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r";//set s1=pe[0]+" has chosen |cffFFFF00draft|r race |cffFFFF00each round|r. You will draft a new race each round! Number of wins for overall victory: |cffFFFF00"+I2S(dd)+"|r"
						s2 = "Draft each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins";//set s2="Draft each round, |cffFFCC00"+I2S(dd)+"|cffFFFF80 wins"
					}//endif
				}//endif
			}//endif
			Rf = "|cffFFFF80"+s2+"|r";//set Rf="|cffFFFF80"+s2+"|r"
			if ((fl || !c9)) {//if(fl or not c9)then
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 25., s1);//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,25.,s1)
			}//endif
		}//endfunction
		private void Yy() {//function Yy takes nothing returns nothing
			eg[0] = null;//set eg[0]=null
			eg[1] = null;//set eg[1]=null
			eg[2] = null;//set eg[2]=null
			eg[3] = null;//set eg[3]=null
			DialogClear(dg);//call DialogClear(dg)
			DialogDestroy(dg);//call DialogDestroy(dg)
			dg = null;//set dg=null
			DestroyTimerDialog(Yf);//call DestroyTimerDialog(Yf)
			Yf = null;//set Yf=null
			DestroyTimer(Xf);//call DestroyTimer(Xf)
			Xf = null;//set Xf=null
			DestroyTrigger(Zf);//call DestroyTrigger(Zf)
			Zf = null;//set Zf=null
			Xy(false);//call Xy(false)
			TriggerExecute(zg);//call TriggerExecute(zg)
		}//endfunction
		private void Zy() {//function Zy takes nothing returns nothing
			jd = not(GetClickedButton()==eg[0]);//set jd=not(GetClickedButton()==eg[0])
			TriggerSleepAction(.1);//call TriggerSleepAction(.1)
			Yy();//call Yy()
		}//endfunction
		private void dz() {//function dz takes nothing returns nothing
			TriggerSleepAction(.1);//call TriggerSleepAction(.1)
			DialogClear(dg);//call DialogClear(dg)
			DialogSetMessage(dg, "New races after each round?");//call DialogSetMessage(dg,"New races after each round?")
			eg[0] = DialogAddButton(dg,"YES",0);//set eg[0]=DialogAddButton(dg,"YES",0)
			eg[1] = DialogAddButton(dg,"NO",0);//set eg[1]=DialogAddButton(dg,"NO",0)
			TriggerClearActions(Zf);//call TriggerClearActions(Zf)
			TriggerAddAction(Zf, function Zy);//call TriggerAddAction(Zf,function Zy)
			DialogDisplay(Player(0), dg, true);//call DialogDisplay(Player(0),dg,true)
		}//endfunction
		private void ez() {//function ez takes nothing returns nothing
			if ((GetClickedButton()==eg[0])) {//if(GetClickedButton()==eg[0])then
				V9 = "fz";//set V9="fz"
				Z9 = 0;//set Z9=0
			} else {//else
				V9 = "gz";//set V9="gz"
				Z9 = 1;//set Z9=1
			}//endif
			if ((dd==1)) {//if(dd==1)then
				jd = false;//set jd=false
				Yy();//call Yy()
			} else {//else
				dz();//call dz()
			}//endif
		}//endfunction
		private void hz() {//function hz takes nothing returns nothing
			TriggerSleepAction(.1);//call TriggerSleepAction(.1)
			DialogClear(dg);//call DialogClear(dg)
			DialogSetMessage(dg, "Race selection?");//call DialogSetMessage(dg,"Race selection?")
			eg[0] = DialogAddButton(dg,"Pick your race!",0);//set eg[0]=DialogAddButton(dg,"Pick your race!",0)
			eg[1] = DialogAddButton(dg,"Random race!",0);//set eg[1]=DialogAddButton(dg,"Random race!",0)
			TriggerClearActions(Zf);//call TriggerClearActions(Zf)
			TriggerAddAction(Zf, function ez);//call TriggerAddAction(Zf,function ez)
			DialogDisplay(Player(0), dg, true);//call DialogDisplay(Player(0),dg,true)
		}//endfunction
		private void iz() {//function iz takes nothing returns nothing
			button cl = GetClickedButton();//local button cl=GetClickedButton()
			int i = 0;//local integer i=0
			while (true) {//loop
				if (cl==eg[i]) { break; }//exitwhen cl==eg[i]
				i = i+1;//set i=i+1
			}//endloop
			dd = i+1;//set dd=i+1
			cl = null;//set cl=null
			hz();//call hz()
		}//endfunction
		private void jz() {//function jz takes nothing returns nothing
			PauseTimer(Xf);//call PauseTimer(Xf)
			S9 = false;//set S9=false
			if ((Z9!=-1)) {//if(Z9!=-1)then
				Yy();//call Yy()
				return;//return
			}//endif
			DialogSetMessage(dg, "Number of victories?");//call DialogSetMessage(dg,"Number of victories?")
			eg[0] = DialogAddButton(dg,"1",0);//set eg[0]=DialogAddButton(dg,"1",0)
			eg[1] = DialogAddButton(dg,"2",0);//set eg[1]=DialogAddButton(dg,"2",0)
			eg[2] = DialogAddButton(dg,"3",0);//set eg[2]=DialogAddButton(dg,"3",0)
			eg[3] = DialogAddButton(dg,"4",0);//set eg[3]=DialogAddButton(dg,"4",0)
			TriggerAddAction(Zf, function iz);//call TriggerAddAction(Zf,function iz)
			DialogDisplay(Player(0), dg, true);//call DialogDisplay(Player(0),dg,true)
		}//endfunction
		private void kz() {//function kz takes nothing returns nothing
			TimerStart(Xf, 20., false, function jz);//call TimerStart(Xf,20.,false,function jz)
			Yf = CreateTimerDialog(Xf);//set Yf=CreateTimerDialog(Xf)
			TimerDialogSetTitle(Yf, "Game starts:");//call TimerDialogSetTitle(Yf,"Game starts:")
			TimerDialogDisplay(Yf, true);//call TimerDialogDisplay(Yf,true)
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 30., "Welcome to |cffFFFF80Castle Fight|r |c0000ffffES|r |c0080ff001.22a|r! |cffFF0000"+GetPlayerName(Player(0))+"|r has now 20 seconds to choose game modes. If you are new to this map, you can find some useful hints in the |cff80FF00Manual|r (|cffFFBA17F9|r).");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,30.,"Welcome to |cffFFFF80Castle Fight|r |c0000ffffES|r |c0080ff001.22a|r! |cffFF0000"+GetPlayerName(Player(0))+"|r has now 20 seconds to choose game modes. If you are new to this map, you can find some useful hints in the |cff80FF00Manual|r (|cffFFBA17F9|r).")
			DisplayTimedTextToPlayer(Player(0), .0, .0, 30., "Welcome to |cffFFFF80Castle Fight|r! You have 20 seconds to enter gamemodes. If you don't enter a valid command, you will be able to choose gamemodes via dialogues. If you don't know how to enter gamemodes read the |cff80FF00Manual|r (|cffFFBA17F9|r).");//call DisplayTimedTextToPlayer(Player(0),.0,.0,30.,"Welcome to |cffFFFF80Castle Fight|r! You have 20 seconds to enter gamemodes. If you don't enter a valid command, you will be able to choose gamemodes via dialogues. If you don't know how to enter gamemodes read the |cff80FF00Manual|r (|cffFFBA17F9|r).")
			CinematicFadeBJ(1, .0, "ReplaceableTextures\\CameraMasks\\Black_mask.blp", .0, 0, 0, 6.);//call CinematicFadeBJ(1,.0,"ReplaceableTextures\\CameraMasks\\Black_mask.blp",.0,0,0,6.)
			FlashQuestDialogButton();//call FlashQuestDialogButton()
		}//endfunction
		private void mz() {//function mz takes nothing returns nothing
			TimerStart(Xf, .01, false, function kz);//call TimerStart(Xf,.01,false,function kz)
			TriggerRegisterDialogEvent(Zf, dg);//call TriggerRegisterDialogEvent(Zf,dg)
		}//endfunction
		private void nz() {//function nz takes nothing returns nothing
			Rk(("Wins"), (GetEnumPlayer()), p7[('e')], I2S((1)), 'g');//call Rk(("Wins"),(GetEnumPlayer()),p7[('e')],I2S((1)),'g')
			dm(GetEnumPlayer(), 'g');//call dm(GetEnumPlayer(),'g')
		}//endfunction
		private void oz() {//function oz takes nothing returns nothing
			CustomVictoryBJ(GetEnumPlayer(), true, true);//call CustomVictoryBJ(GetEnumPlayer(),true,true)
		}//endfunction
		private void pz() {//function pz takes nothing returns nothing
			Rk(("Loses"), (GetEnumPlayer()), p7[('e')], I2S((1)), 'g');//call Rk(("Loses"),(GetEnumPlayer()),p7[('e')],I2S((1)),'g')
			dm(GetEnumPlayer(), 'f');//call dm(GetEnumPlayer(),'f')
			CustomDefeatBJ(GetEnumPlayer(), "You were defeated!");//call CustomDefeatBJ(GetEnumPlayer(),"You were defeated!")
		}//endfunction
		private void qz() {//function qz takes nothing returns nothing
			RemoveUnit(GetEnumUnit());//call RemoveUnit(GetEnumUnit())
		}//endfunction
		private void rz() {//function rz takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u=GetEnumUnit()
			ShowUnit(u, false);//call ShowUnit(u,false)
			KillUnit(u);//call KillUnit(u)
			RemoveUnit(u);//call RemoveUnit(u)
			u = null;//set u=null
		}//endfunction
		private void sz() {//function sz takes nothing returns nothing
			RemoveItem(GetEnumItem());//call RemoveItem(GetEnumItem())
		}//endfunction
		private void tz() {//function tz takes nothing returns nothing
			int i = 0;//local integer i=0
			gg = false;//set gg=false
			Fe = true;//set Fe=true
			Ym(false);//call Ym(false)
			Uy();//call Uy()
			FogEnable(false);//call FogEnable(false)
			PauseTimer(a9);//call PauseTimer(a9)
			PauseTimer(B9);//call PauseTimer(B9)
			PauseTimer(jf);//call PauseTimer(jf)
			PauseTimer(L9);//call PauseTimer(L9)
			dj(false);//call dj(false)
			DestroyFogModifier(Ag);//call DestroyFogModifier(Ag)
			DestroyFogModifier(ag);//call DestroyFogModifier(ag)
			TriggerClearActions(hg);//call TriggerClearActions(hg)
			DestroyTrigger(hg);//call DestroyTrigger(hg)
			TriggerClearActions(ig);//call TriggerClearActions(ig)
			DestroyTrigger(ig);//call DestroyTrigger(ig)
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "The Score is |cffFF0000West|r: |cffFFCC00"+I2S(Hd[0])+" |cff00FF00East|r:|cffFFCC00 "+I2S(Hd[1])+"|r. Number of wins for overall victory: |cffFFCC00"+I2S(dd)+"|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"The Score is |cffFF0000West|r: |cffFFCC00"+I2S(Hd[0])+" |cff00FF00East|r:|cffFFCC00 "+I2S(Hd[1])+"|r. Number of wins for overall victory: |cffFFCC00"+I2S(dd)+"|r")
			Zv();//call Zv()
			tm();//call tm()
			if ((mg>0)) {//if(mg>0)then
				if ((mg==2)) {//if(mg==2)then
					ForForce(ie, function nz);//call ForForce(ie,function nz)
				} else {//else
					ForForce(je, function nz);//call ForForce(je,function nz)
				}//endif
			}//endif
			TriggerSleepAction(4.);//call TriggerSleepAction(4.)
			CinematicFadeBJ(1, 2, "ReplaceableTextures\\CameraMasks\\Black_mask.blp", 0, 0, 0, 6.);//call CinematicFadeBJ(1,2,"ReplaceableTextures\\CameraMasks\\Black_mask.blp",0,0,0,6.)
			TriggerSleepAction(2.);//call TriggerSleepAction(2.)
			U9 = false;//set U9=false
			nh = false;//set nh=false
			while (true) {//loop
				GroupEnumUnitsOfPlayer(q4, Player(i), kg);//call GroupEnumUnitsOfPlayer(q4,Player(i),kg)
				ForGroup(q4, function rz);//call ForGroup(q4,function rz)
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			GroupEnumUnitsInRect(q4, C9, kg);//call GroupEnumUnitsInRect(q4,C9,kg)
			ForGroup(q4, function qz);//call ForGroup(q4,function qz)
			TriggerSleepAction(3.);//call TriggerSleepAction(3.)
			i = 0;//set i=0
			while (true) {//loop
				GroupEnumUnitsOfPlayer(q4, Player(i), kg);//call GroupEnumUnitsOfPlayer(q4,Player(i),kg)
				ForGroup(q4, function rz);//call ForGroup(q4,function rz)
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			GroupEnumUnitsInRect(q4, C9, kg);//call GroupEnumUnitsInRect(q4,C9,kg)
			ForGroup(q4, function qz);//call ForGroup(q4,function qz)
			nh = true;//set nh=true
			Bf[0] = 0;//set Bf[0]=0
			Bf[1] = 0;//set Bf[1]=0
			EnumItemsInRect(C9, null, function sz);//call EnumItemsInRect(C9,null,function sz)
			if ((mg>0)) {//if(mg>0)then
				TriggerSleepAction(11.);//call TriggerSleepAction(11.)
				if ((mg==2)) {//if(mg==2)then
					ForForce(ie, function oz);//call ForForce(ie,function oz)
					ForForce(je, function pz);//call ForForce(je,function pz)
				} else {//else
					ForForce(je, function oz);//call ForForce(je,function oz)
					ForForce(ie, function pz);//call ForForce(ie,function pz)
				}//endif
			} else {//else
				DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 10., "Preparing for new round...");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,10.,"Preparing for new round...")
				TriggerSleepAction(7.);//call TriggerSleepAction(7.)
				TriggerExecute(zg);//call TriggerExecute(zg)
			}//endif
		}//endfunction
		private bool uz() {//function uz takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			bool Im = GetPlayerId(GetOwningPlayer(u))<$C && GetUnitAbilityLevel(u,842023207)<1;//local boolean Im=GetPlayerId(GetOwningPlayer(u))<$C and GetUnitAbilityLevel(u,'A02E')<1
			u = null;//set u=null
			return Im;//return Im
		}//endfunction
		private void vz() {//function vz takes nothing returns nothing
			Rk(("RoundsWon"), (GetEnumPlayer()), p7[('e')], I2S((1)), 'g');//call Rk(("RoundsWon"),(GetEnumPlayer()),p7[('e')],I2S((1)),'g')
		}//endfunction
		private void wz() {//function wz takes nothing returns nothing
			Rk(("RoundsLost"), (GetEnumPlayer()), p7[('e')], I2S((1)), 'g');//call Rk(("RoundsLost"),(GetEnumPlayer()),p7[('e')],I2S((1)),'g')
		}//endfunction
		private void xz() {//function xz takes nothing returns nothing
			if ((!gg)) {//if(not gg)then
				return;//return
			}//endif
			ForForce(ie, function vz);//call ForForce(ie,function vz)
			ForForce(je, function wz);//call ForForce(je,function wz)
			Hd[1] = Hd[1]+1;//set Hd[1]=Hd[1]+1
			Yr(5, 2, I2S(Hd[1]));//call Yr(5,2,I2S(Hd[1]))
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cff00FF00Eastern Forces|r have won the round!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cff00FF00Eastern Forces|r have won the round!")
			if ((Hd[1]>=dd)) {//if(Hd[1]>=dd)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffFFFF00Congratulations! |cff00FF00Eastern Forces|r|cffFFFF00 have won the match! Game ends in one minute.|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffFFFF00Congratulations! |cff00FF00Eastern Forces|r|cffFFFF00 have won the match! Game ends in one minute.|r")
				mg = 1;//set mg=1
				T9 = true;//set T9=true
			}//endif
			tz();//call tz()
		}//endfunction
		private void yz() {//function yz takes nothing returns nothing
			if ((!gg)) {//if(not gg)then
				return;//return
			}//endif
			ForForce(je, function vz);//call ForForce(je,function vz)
			ForForce(ie, function wz);//call ForForce(ie,function wz)
			Hd[0] = Hd[0]+1;//set Hd[0]=Hd[0]+1
			Yr(5, 1, I2S(Hd[0]));//call Yr(5,1,I2S(Hd[0]))
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffFF0000Western Forces|r have won the round!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffFF0000Western Forces|r have won the round!")
			if ((Hd[0]>=dd)) {//if(Hd[0]>=dd)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffFFFF00Congratulations! |cffFF0000Western Forces|r|cffFFFF00 have won the match! Game ends in one minute.|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffFFFF00Congratulations! |cffFF0000Western Forces|r|cffFFFF00 have won the match! Game ends in one minute.|r")
				mg = 2;//set mg=2
				T9 = true;//set T9=true
			}//endif
			tz();//call tz()
		}//endfunction
		private void zz() {//function zz takes nothing returns nothing
			if ((!gg)) {//if(not gg)then
				return;//return
			}//endif
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffFFAC00All players have voted for a draw, round will restart!|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffFFAC00All players have voted for a draw, round will restart!|r")
			tz();//call tz()
		}//endfunction
		private void Az() {//function Az takes nothing returns nothing
			kg = Filter(function uz);//set kg=Filter(function uz)
			jg = CreateTrigger();//set jg=CreateTrigger()
			TriggerAddAction(jg, function zz);//call TriggerAddAction(jg,function zz)
		}//endfunction
		private void az() {//function az takes nothing returns nothing
			pg = -1;//set pg=-1
			TimerDialogDisplay(og, false);//call TimerDialogDisplay(og,false)
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "Time is up and not all players have agreed. Extra rounds declined!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"Time is up and not all players have agreed. Extra rounds declined!")
		}//endfunction
		private void Bz(int dk) {//function Bz takes integer dk returns nothing
			if ((pg==-1)) {//if(pg==-1)then
				return;//return
			}//endif
			if ((rg[dk])) {//if(rg[dk])then
				rg[dk] = false;//set rg[dk]=false
				qg = qg-1;//set qg=qg-1
				if ((qg>0)) {//if(qg>0)then
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" has agreed, "+I2S(qg)+" more votes needed");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" has agreed, "+I2S(qg)+" more votes needed")
				} else {//else
					dd = dd+(pg);//set dd=dd+(pg)
					PauseTimer(ng);//call PauseTimer(ng)
					TimerDialogDisplay(og, false);//call TimerDialogDisplay(og,false)
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "All players have agreed, number of rounds is increased by "+I2S(pg));//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"All players have agreed, number of rounds is increased by "+I2S(pg))
					c9 = true;//set c9=true
					Xy(true);//call Xy(true)
					pg = -1;//set pg=-1
				}//endif
			} else {//else
				DisplayTextToPlayer(Player(dk), .0, .0, "You have already agreed!");//call DisplayTextToPlayer(Player(dk),.0,.0,"You have already agreed!")
			}//endif
		}//endfunction
		private void bz(int ws) {//function bz takes integer ws returns nothing
			int i = 0;//local integer i=0
			if ((ws<1 || ws>3)) {//if(ws<1 or ws>3)then
				DisplayTextToPlayer(Player(0), .0, .0, "Invalid number of rounds, must be between 1 and 3");//call DisplayTextToPlayer(Player(0),.0,.0,"Invalid number of rounds, must be between 1 and 3")
				return;//return
			}//endif
			pg = ws;//set pg=ws
			qg = 0;//set qg=0
			while (true) {//loop
				if ((GetPlayerController(Player(i))==MAP_CONTROL_USER && GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING  && (IsPlayerInForce(Player(i),ie) || IsPlayerInForce(Player(i),je)))) {//if(GetPlayerController(Player(i))==MAP_CONTROL_USER and GetPlayerSlotState(Player(i))==PLAYER_SLOT_STATE_PLAYING and(IsPlayerInForce(Player(i),ie)or IsPlayerInForce(Player(i),je)))then
					rg[i] = true;//set rg[i]=true
					qg = qg+1;//set qg=qg+1
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			TimerStart(ng, 30., false, function az);//call TimerStart(ng,30.,false,function az)
			TimerDialogDisplay(og, true);//call TimerDialogDisplay(og,true)
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 30., "|cffC6FF00"+I2S(ws)+" Extra Rounds|r vote has been started. You have 30 seconds to agree to it by typing |cffFFFF00-agree|r. If all players agree, the number of wins for overall victory will be increased by "+I2S(ws));//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,30.,"|cffC6FF00"+I2S(ws)+" Extra Rounds|r vote has been started. You have 30 seconds to agree to it by typing |cffFFFF00-agree|r. If all players agree, the number of wins for overall victory will be increased by "+I2S(ws))
		}//endfunction
		private void Cz() {//function Cz takes nothing returns nothing
			TimerDialogDisplay(og, false);//call TimerDialogDisplay(og,false)
			TimerDialogSetTitle(og, "Voting XR");//call TimerDialogSetTitle(og,"Voting XR")
		}//endfunction
		private string cz() {//function cz takes nothing returns string
			string Im;//local string Im
			if ((tg!=null)) {//if(tg!=null)then
				return tg;//return tg
			}//endif
			if ((Z9==1)) {//if(Z9==1)then
				Im = " -r";//set Im=" -r"
			} else if ((Z9==2)) {//elseif(Z9==2)then
				Im = " -m";//set Im=" -m"
			} else if ((Z9==3)) {//elseif(Z9==3)then
				Im = " -d";//set Im=" -d"
			} else {//else
				Im = " -p";//set Im=" -p"
			}//endif
			if ((jd)) {//if(jd)then
				Im = Im+("p");//set Im=Im+("p")
			} else {//else
				Im = Im+("r");//set Im=Im+("r")
			}//endif
			Im = Im+(I2S(dd));//set Im=Im+(I2S(dd))
			if ((ed==1)) {//if(ed==1)then
				Im = Im+("-slt");//set Im=Im+("-slt")
			} else if ((ed==2)) {//elseif(ed==2)then
				Im = Im+("-slb");//set Im=Im+("-slb")
			}//endif
			if ((gd>0)) {//if(gd>0)then
				Im = Im+"-fow"+I2S(gd);//set Im=Im+"-fow"+I2S(gd)
			} else if ((gd==0)) {//elseif(gd==0)then
				Im = Im+("-nfow");//set Im=Im+("-nfow")
			}//endif
			if ((hd!=$A)) {//if(hd!=$A)then
				Im = Im+"-it"+I2S(hd);//set Im=Im+"-it"+I2S(hd)
			}//endif
			if ((kd)) {//if(kd)then
				Im = Im+("-du");//set Im=Im+("-du")
			}//endif
			if ((zd)) {//if(zd)then
				Im = Im+("-ai");//set Im=Im+("-ai")
			}//endif
			if ((Fd>0)) {//if(Fd>0)then
				Im = Im+("-fp");//set Im=Im+("-fp")
			}//endif
			if ((md)) {//if(md)then
				Im = Im+("-na");//set Im=Im+("-na")
			}//endif
			if ((nd)) {//if(nd)then
				Im = Im+("-ntb");//set Im=Im+("-ntb")
			}//endif
			if ((od)) {//if(od)then
				Im = Im+("-nb");//set Im=Im+("-nb")
			}//endif
			if ((!pd)) {//if(not pd)then
				Im = Im+("-ns");//set Im=Im+("-ns")
			}//endif
			if ((!qd)) {//if(not qd)then
				Im = Im+("-ni");//set Im=Im+("-ni")
			}//endif
			if ((!rd)) {//if(not rd)then
				Im = Im+("-la");//set Im=Im+("-la")
			}//endif
			if ((!sd)) {//if(not sd)then
				Im = Im+("-nrs");//set Im=Im+("-nrs")
			}//endif
			if ((td)) {//if(td)then
				Im = Im+("-ur");//set Im=Im+("-ur")
			}//endif
			if ((!sd)) {//if(not sd)then
				Im = Im+("-ca");//set Im=Im+("-ca")
			}//endif
			if ((vd)) {//if(vd)then
				Im = Im+("-dom");//set Im=Im+("-dom")
			}//endif
			if ((wd)) {//if(wd)then
				Im = Im+("-sd");//set Im=Im+("-sd")
			}//endif
			if ((xd)) {//if(xd)then
				Im = Im+("-nafk");//set Im=Im+("-nafk")
			}//endif
			if ((!yd)) {//if(not yd)then
				Im = Im+("-ndb");//set Im=Im+("-ndb")
			}//endif
			if ((Ad==1)) {//if(Ad==1)then
				Im = Im+("-nt");//set Im=Im+("-nt")
			} else if ((Ad==2)) {//elseif(Ad==2)then
				Im = Im+("-ht");//set Im=Im+("-ht")
			}//endif
			if ((ad>-1)) {//if(ad>-1)then
				Im = Im+"-ll"+I2S(ad);//set Im=Im+"-ll"+I2S(ad)
			}//endif
			if ((Bd>0)) {//if(Bd>0)then
				Im = Im+"-ban"+I2S(Bd);//set Im=Im+"-ban"+I2S(Bd)
			}//endif
			if ((Bd<0)) {//if(Bd<0)then
				Im = Im+"-rban"+I2S(-Bd);//set Im=Im+"-rban"+I2S(-Bd)
			}//endif
			if ((bd>0)) {//if(bd>0)then
				Im = Im+"-mp"+I2S(bd);//set Im=Im+"-mp"+I2S(bd)
			}//endif
			if ((Dd>0)) {//if(Dd>0)then
				Im = Im+"-emp"+I2S(Dd);//set Im=Im+"-emp"+I2S(Dd)
			}//endif
			if ((Cd==$A)) {//if(Cd==$A)then
				Im = Im+(Im+"-cc");//set Im=Im+(Im+"-cc")
			} else if ((Cd==1)) {//elseif(Cd==1)then
				Im = Im+("-co");//set Im=Im+("-co")
			}//endif
			if ((cd!=0)) {//if(cd!=0)then
				if ((cd>0)) {//if(cd>0)then
					Im = Im+"-glw"+I2S(cd);//set Im=Im+"-glw"+I2S(cd)
				} else {//else
					Im = Im+"-gld"+I2S(IAbsBJ(cd));//set Im=Im+"-gld"+I2S(IAbsBJ(cd))
				}//endif
			}//endif
			if ((!ud)) {//if(not ud)then
				Im = Im+("-ca");//set Im=Im+("-ca")
			}//endif
			if ((W9!=$FA)) {//if(W9!=$FA)then
				Im = Im+("-srg"+I2S(W9));//set Im=Im+("-srg"+I2S(W9))
			}//endif
			if ((X9!='}')) {//if(X9!='}')then
				Im = Im+("-srl"+I2S(X9));//set Im=Im+("-srl"+I2S(X9))
			}//endif
			if ((Y9!=1)) {//if(Y9!=1)then
				Im = Im+("-sru"+I2S(Y9));//set Im=Im+("-sru"+I2S(Y9))
			}//endif
			if ((Ed>0)) {//if(Ed>0)then
				Im = Im+("-nfr"+I2S(Ed));//set Im=Im+("-nfr"+I2S(Ed))
			}//endif
			Im = Im+"-bal"+I2S(fd);//set Im=Im+"-bal"+I2S(fd)
			tg = Im;//set tg=Im
			return Im;//return Im
		}//endfunction
		private void Dz(string s) {//function Dz takes string s returns nothing
			if ((StringLength(s)>0 && SubString(s,0,1)==" ")) {//if(StringLength(s)>0 and SubString(s,0,1)==" ")then
				s = SubString(s,1,StringLength(s));//set s=SubString(s,1,StringLength(s))
			}//endif
			s = StringCase(s,false);//set s=StringCase(s,false)
			if ((SubString(s,0,3)=="ice")) {//if(SubString(s,0,3)=="ice")then
				xj(0);//call xj(0)
			} else if ((SubString(s,0,4)=="lava")) {//elseif(SubString(s,0,4)=="lava")then
				xj(1);//call xj(1)
			} else if ((SubString(s,0,4)=="ice2")) {//elseif(SubString(s,0,4)=="ice2")then
				xj(2);//call xj(2)
			} else {//else
				DisplayTextToPlayer(Player(0), .0, .0, "Sorry, but landscape [|c00ff0000"+s+"|r] not found.");//call DisplayTextToPlayer(Player(0),.0,.0,"Sorry, but landscape [|c00ff0000"+s+"|r] not found.")
			}//endif
		}//endfunction
		private void Ez() {//function Ez takes nothing returns nothing
			ug = !ug;//set ug=not ug
			if ((ug)) {//if(ug)then
				PauseTimer(Xf);//call PauseTimer(Xf)
			} else {//else
				ResumeTimer(Xf);//call ResumeTimer(Xf)
				if ((sg)) {//if(sg)then
					jz();//call jz()
				}//endif
			}//endif
		}//endfunction
		private void Console_SpecControlSendsResume() {//function Console_SpecControlSendsResume takes nothing returns nothing
			if ((!ug)) {//if(not ug)then
				ResumeTimer(Xf);//call ResumeTimer(Xf)
				if ((sg)) {//if(sg)then
					jz();//call jz()
				}//endif
			}//endif
		}//endfunction
		private void Fz(player Gz, int Pk) {//function Fz takes player Gz,integer Pk returns nothing
			int i = 0;//local integer i=0
			player p;//local player p
			if ((Pk>6)) {//if(Pk>6)then
				Pk = 6;//set Pk=6
			}//endif
			if ((CountPlayersInForceBJ(ie)+CountPlayersInForceBJ(je)+CountPlayersInForceBJ(ke)<Pk*2)) {//if(CountPlayersInForceBJ(ie)+CountPlayersInForceBJ(je)+CountPlayersInForceBJ(ke)<Pk*2)then
				DisplayTextToPlayer(Gz, .0, .0, "Sorry, but command [|c00ff0000Fill|r] coudn't be executed. There are small count of quota players.");//call DisplayTextToPlayer(Gz,.0,.0,"Sorry, but command [|c00ff0000Fill|r] coudn't be executed. There are small count of quota players.")
				return;//return
			}//endif
			while (true) {//loop
				if (CountPlayersInForceBJ(ie)>=Pk) { break; }//exitwhen CountPlayersInForceBJ(ie)>=Pk
				p = zn(true);//set p=zn(true)
				ForceRemovePlayer(ke, p);//call ForceRemovePlayer(ke,p)
				ForceAddPlayer(ie, p);//call ForceAddPlayer(ie,p)
				CreateFogModifierRectBJ(true, p, FOG_OF_WAR_VISIBLE, Q9);//call CreateFogModifierRectBJ(true,p,FOG_OF_WAR_VISIBLE,Q9)
				Qd[GetPlayerId(p)] = dn(true);//set Qd[GetPlayerId(p)]=dn(true)
				ne[GetPlayerId(p)] = CreateForce();//set ne[GetPlayerId(p)]=CreateForce()
				It(GetPlayerId(p));//call It(GetPlayerId(p))
				i = i+1;//set i=i+1
			}//endloop
			while (true) {//loop
				if (CountPlayersInForceBJ(je)>=Pk) { break; }//exitwhen CountPlayersInForceBJ(je)>=Pk
				p = zn(false);//set p=zn(false)
				ForceRemovePlayer(ke, p);//call ForceRemovePlayer(ke,p)
				ForceAddPlayer(je, p);//call ForceAddPlayer(je,p)
				CreateFogModifierRectBJ(true, p, FOG_OF_WAR_VISIBLE, Q9);//call CreateFogModifierRectBJ(true,p,FOG_OF_WAR_VISIBLE,Q9)
				Qd[GetPlayerId(p)] = dn(false);//set Qd[GetPlayerId(p)]=dn(false)
				ne[GetPlayerId(p)] = CreateForce();//set ne[GetPlayerId(p)]=CreateForce()
				It(GetPlayerId(p));//call It(GetPlayerId(p))
				i = i+1;//set i=i+1
			}//endloop
			Bn();//call Bn()
			DisplayTextToPlayer(Gz, .0, .0, "There are added "+I2S(i)+" players.");//call DisplayTextToPlayer(Gz,.0,.0,"There are added "+I2S(i)+" players.")
		}//endfunction
		private bool Hz(string s) {//function Hz takes string s returns boolean
			int i = S2I(s);//local integer i=S2I(s)
			if ((i<=0)) {//if(i<=0)then
				return false;//return false
			}//endif
			dd = IMinBJ(i,6);//set dd=IMinBJ(i,6)
			return true;//return true
		}//endfunction
		private bool Iz(string s) {//function Iz takes string s returns boolean
			if ((s=="g")) {//if(s=="g")then
				jd = true;//set jd=true
				return true;//return true
			} else if ((s=="r")) {//elseif(s=="r")then
				jd = false;//set jd=false
				return true;//return true
			}//endif
			return false;//return false
		}//endfunction
		private void lz(int t) {//function lz takes integer t returns nothing
			if ((t<0)) {//if(t<0)then
				return;//return
			}//endif
			if ((t==0)) {//if(t==0)then
				if ((gd==-1)) {//if(gd==-1)then
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cff808080Deprecated activation of Permanent Fog of War has been encountered. Ignored.|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cff808080Deprecated activation of Permanent Fog of War has been encountered. Ignored.|r")
					return;//return
				}//endif
				gd = -1;//set gd=-1
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "Permanent |cffC6FF00Fog of War|r has been chosen");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"Permanent |cffC6FF00Fog of War|r has been chosen")
				return;//return
			}//endif
			gd = t;//set gd=t
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Fog of War|r time has been set to |cffFFFF00"+I2S(t)+"|r seconds.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Fog of War|r time has been set to |cffFFFF00"+I2S(t)+"|r seconds.")
		}//endfunction
		private void Jz() {//function Jz takes nothing returns nothing
			gd = 0;//set gd=0
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Fog of War|r has been removed. All map will be visible.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Fog of War|r has been removed. All map will be visible.")
		}//endfunction
		private void Kz(int Lz) {//function Kz takes integer Lz returns nothing
			if ((Lz==0)) {//if(Lz==0)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, I2S(GetRandomInt(0, 99)));//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,I2S(GetRandomInt(0,99)))
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, I2S(GetRandomInt(0, Lz)));//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,I2S(GetRandomInt(0,Lz)))
			}//endif
		}//endfunction
		private void Mz(string YC) {//function Mz takes string YC returns nothing
			int zC;//local integer zC
			string ZC;//local string ZC
			float i = $C0;//local real i=$C0
			float Nz;//local real Nz
			if (ed>0 ) {//if ed>0 then
				return;//return
			}//endif
			if (YC=="u" || YC=="t" ) {//if YC=="u" or YC=="t" then
				zC = -1;//set zC=-1
			} else if (YC=="d" || YC=="b" ) {//elseif YC=="d" or YC=="b" then
				zC = 1;//set zC=1
			} else {//else
				zC = (GetRandomInt(0,1)*2)-1;//set zC=(GetRandomInt(0,1)*2)-1
			}//endif
			if (zC==1 ) {//if zC==1 then
				ed = 2;//set ed=2
				ZC = "bottom";//set ZC="bottom"
			} else {//else
				ed = 1;//set ed=1
				ZC = "top";//set ZC="top"
			}//endif
			Nz = GetRectMaxY(bj_mapInitialPlayableArea);//set Nz=GetRectMaxY(bj_mapInitialPlayableArea)
			while (true) {//loop
				if (i>Nz) { break; }//exitwhen i>Nz
				CreateDestructable('YTfc', $5C0, i*zC, 270, 1, 0);//call CreateDestructable('YTfc',$5C0,i*zC,270,1,0)
				CreateDestructable('YTfc', -$5C0, i*zC, 270, 1, 0);//call CreateDestructable('YTfc',-$5C0,i*zC,270,1,0)
				i = i+$80;//set i=i+$80
			}//endloop
			i = -$5F0;//set i=-$5F0
			while (true) {//loop
				if (i>$5F0) { break; }//exitwhen i>$5F0
				SetTerrainPathable(i, 272*zC, PATHING_TYPE_WALKABILITY, false);//call SetTerrainPathable(i,272*zC,PATHING_TYPE_WALKABILITY,false)
				SetTerrainPathable(i, 272*zC, PATHING_TYPE_FLYABILITY, false);//call SetTerrainPathable(i,272*zC,PATHING_TYPE_FLYABILITY,false)
				i = i+32;//set i=i+32
			}//endloop
			CreateDestructable('B004', $5C0, 640*zC, 270, 1.1, 0);//call CreateDestructable('B004',$5C0,640*zC,270,1.1,0)
			CreateDestructable('B004', -$5C0, 640*zC, 270, 1.1, 0);//call CreateDestructable('B004',-$5C0,640*zC,270,1.1,0)
			CreateDestructable('B004', $5C0, 960*zC, 270, 1.1, 0);//call CreateDestructable('B004',$5C0,960*zC,270,1.1,0)
			CreateDestructable('B004', -$5C0, 960*zC, 270, 1.1, 0);//call CreateDestructable('B004',-$5C0,960*zC,270,1.1,0)
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Single Lane|r has been chosen. Units are only able to walk/fly over the |cffFFFF00"+ZC+" lane|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Single Lane|r has been chosen. Units are only able to walk/fly over the |cffFFFF00"+ZC+" lane|r.")
		}//endfunction
		private void Oz(int p, int Pk) {//function Oz takes integer p,integer Pk returns nothing
			if ((Pk==0)) {//if(Pk==0)then
				if ((Xm(p))) {//if(Xm(p))then
					DisplayTextToPlayer(Player(p), .0, .0, "Your |cffC6FF00Personal Timer|r has been disabled");//call DisplayTextToPlayer(Player(p),.0,.0,"Your |cffC6FF00Personal Timer|r has been disabled")
				} else {//else
					DisplayTextToPlayer(Player(p), .0, .0, "Your |cffC6FF00Personal Timer|r is already disabled!");//call DisplayTextToPlayer(Player(p),.0,.0,"Your |cffC6FF00Personal Timer|r is already disabled!")
				}//endif
				return;//return
			}//endif
			if ((Pk<4)) {//if(Pk<4)then
				DisplayTextToPlayer(Player(p), .0, .0, "The value for Personal Timer must be more that |c00ff00003|r!");//call DisplayTextToPlayer(Player(p),.0,.0,"The value for Personal Timer must be more that |c00ff00003|r!")
				return;//return
			}//endif
			Wm(p, Pk);//call Wm(p,Pk)
			DisplayTextToPlayer(Player(p), .0, .0, "Your |cffC6FF00Personal Timer|r has been started");//call DisplayTextToPlayer(Player(p),.0,.0,"Your |cffC6FF00Personal Timer|r has been started")
		}//endfunction
		private void Pz(int tk) {//function Pz takes integer tk returns nothing
			Gd[tk] = !Gd[tk];//set Gd[tk]=not Gd[tk]
			if ((Gd[tk])) {//if(Gd[tk])then
				DisplayTextToPlayer(Player(tk), .0, .0, "|cffC6FF00Auto Training|r has been activated");//call DisplayTextToPlayer(Player(tk),.0,.0,"|cffC6FF00Auto Training|r has been activated")
			} else {//else
				DisplayTextToPlayer(Player(tk), .0, .0, "|cffC6FF00Auto Training|r has been deactivated");//call DisplayTextToPlayer(Player(tk),.0,.0,"|cffC6FF00Auto Training|r has been deactivated")
			}//endif
		}//endfunction
		private void Qz(string Rz, int Pk) {//function Qz takes string Rz,integer Pk returns nothing
			if ((Rz=="g" || Rz=="G")) {//if(Rz=="g" or Rz=="G")then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Start Resources|r has been changed. The amount of start |c00ffdc00Gold|r is |cffFFFF00"+I2S(Pk)+"|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Start Resources|r has been changed. The amount of start |c00ffdc00Gold|r is |cffFFFF00"+I2S(Pk)+"|r.")
				W9 = Pk;//set W9=Pk
			} else if ((Rz=="l" || Rz=="L")) {//elseif(Rz=="l" or Rz=="L")then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Start Resources|r has been changed. The amount of start |c0000c850Lumber|r is |cffFFFF00"+I2S(Pk)+"|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Start Resources|r has been changed. The amount of start |c0000c850Lumber|r is |cffFFFF00"+I2S(Pk)+"|r.")
				X9 = Pk;//set X9=Pk
			} else if ((Rz=="u" || Rz=="U")) {//elseif(Rz=="u" or Rz=="U")then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "|cffC6FF00Start Resources|r has been changed. The amount of start |c008000ffLegendaries limit|r is |cffFFFF00"+I2S(Pk)+"|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"|cffC6FF00Start Resources|r has been changed. The amount of start |c008000ffLegendaries limit|r is |cffFFFF00"+I2S(Pk)+"|r.")
				Y9 = Pk;//set Y9=Pk
			} else {//else
				DisplayTextToPlayer(Player(0), .0, .0, "Sorry, but resorce [|c00ff0000"+Rz+"|r] couldn't be identified.");//call DisplayTextToPlayer(Player(0),.0,.0,"Sorry, but resorce [|c00ff0000"+Rz+"|r] couldn't be identified.")
			}//endif
		}//endfunction
		private void Sz(string s, int tk) {//function Sz takes string s,integer tk returns nothing
			player p;//local player p
			if ((StringLength(s)<=2)) {//if(StringLength(s)<=2)then
				return;//return
			}//endif
			if ((S9 && tk==0 && SubString(s,1,3)=="na")) {//if(S9 and tk==0 and SubString(s,1,3)=="na")then
				is(false);//call is(false)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ai")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="ai")then
				hs(true);//call hs(true)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="co")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="co")then
				ks();//call ks()
			} else if ((S9 && tk==0 && SubString(s,1,3)=="cc")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="cc")then
				ms();//call ms()
			} else if ((S9 && tk==0 && SubString(s,1,3)=="du")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="du")then
				ns(true);//call ns(true)
			} else if ((S9 && tk==0 && SubString(s,1,4)=="ntb")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="ntb")then
				ps(false);//call ps(false)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="nb")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="nb")then
				qs(false);//call qs(false)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ns")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="ns")then
				rs(false);//call rs(false)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ni")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="ni")then
				ss(false);//call ss(false)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="la")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="la")then
				ts(false);//call ts(false)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="sr" && StringLength(s)>4)) {//elseif(S9 and tk==0 and SubString(s,1,3)=="sr" and StringLength(s)>4)then
				Qz(SubString(s, 3, 4), S2I(SubString(s, 4, StringLength(s))));//call Qz(SubString(s,3,4),S2I(SubString(s,4,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,4)=="nrs")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="nrs")then
				us(false);//call us(false)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="sl" && ed==0)) {//elseif(S9 and tk==0 and SubString(s,1,3)=="sl" and ed==0)then
				Mz(SubString(s, 3, 4));//call Mz(SubString(s,3,4))
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ur")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="ur")then
				os(true);//call os(true)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="it")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="it")then
				xs(S2I(SubString(s, 3, StringLength(s))));//call xs(S2I(SubString(s,3,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,4)=="glw")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="glw")then
				Gs(S2I(SubString(s, 4, StringLength(s))));//call Gs(S2I(SubString(s,4,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,4)=="gld")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="gld")then
				Gs(-1*S2I(SubString(s, 4, StringLength(s))));//call Gs(-1*S2I(SubString(s,4,StringLength(s))))
			} else if (((!S9) && tk==0 && SubString(s,1,3)=="xr")) {//elseif((not S9)and tk==0 and SubString(s,1,3)=="xr")then
				bz(S2I(SubString(s, 3, StringLength(s))));//call bz(S2I(SubString(s,3,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,3)=="mp")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="mp")then
				Ds(S2I(SubString(s, 3, StringLength(s))));//call Ds(S2I(SubString(s,3,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,4)=="emp")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="emp")then
				cs(S2I(SubString(s, 4, StringLength(s))));//call cs(S2I(SubString(s,4,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ll")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="ll")then
				vs(S2I(SubString(s, 3, StringLength(s))));//call vs(S2I(SubString(s,3,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ht")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="ht")then
				ys(2);//call ys(2)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="nt")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="nt")then
				ys(1);//call ys(1)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="ca")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="ca")then
				As(false);//call As(false)
			} else if ((S9 && tk==0 && SubString(s,1,3)=="sd")) {//elseif(S9 and tk==0 and SubString(s,1,3)=="sd")then
				Es(true);//call Es(true)
			} else if ((S9 && tk==0 && SubString(s,1,4)=="dom")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="dom")then
				as(true);//call as(true)
			} else if ((S9 && tk==0 && SubString(s,1,4)=="fow")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="fow")then
				lz(S2I(SubString(s, 4, StringLength(s))));//call lz(S2I(SubString(s,4,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,5)=="nfow")) {//elseif(S9 and tk==0 and SubString(s,1,5)=="nfow")then
				Jz();//call Jz()
			} else if ((S9 && tk==0 && SubString(s,1,5)=="rban")) {//elseif(S9 and tk==0 and SubString(s,1,5)=="rban")then
				bs(S2I(SubString(s, 5, StringLength(s))));//call bs(S2I(SubString(s,5,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,4)=="ban")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="ban")then
				Cs(S2I(SubString(s, 4, StringLength(s))));//call Cs(S2I(SubString(s,4,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,4)=="bal")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="bal")then
				Bs(S2I(SubString(s, 4, StringLength(s))));//call Bs(S2I(SubString(s,4,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,4)=="nfr")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="nfr")then
				Hs(S2I(SubString(s, 4, StringLength(s))));//call Hs(S2I(SubString(s,4,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,4)=="ndb")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="ndb")then
				Fs(false);//call Fs(false)
			} else if ((S9 && tk==0 && SubString(s,1,4)=="env")) {//elseif(S9 and tk==0 and SubString(s,1,4)=="env")then
				Dz(SubString(s, 4, StringLength(s)));//call Dz(SubString(s,4,StringLength(s)))
			} else if ((S9 && tk==0 && SubString(s,1,5)=="fill")) {//elseif(S9 and tk==0 and SubString(s,1,5)=="fill")then
				Fz(Player(tk), S2I(SubString(s, 5, StringLength(s))));//call Fz(Player(tk),S2I(SubString(s,5,StringLength(s))))
			} else if ((S9 && tk==0 && SubString(s,1,5)=="nafk")) {//elseif(S9 and tk==0 and SubString(s,1,5)=="nafk")then
				js(true);//call js(true)
			} else if ((S9 && tk==0 && SubString(s,1,6)=="pause")) {//elseif(S9 and tk==0 and SubString(s,1,6)=="pause")then
				Ez();//call Ez()
			} else if ((S9 && tk==0 && SubString(s,1,5)=="skip")) {//elseif(S9 and tk==0 and SubString(s,1,5)=="skip")then
				if ((ug)) {//if(ug)then
					sg = true;//set sg=true
				} else {//else
					jz();//call jz()
				}//endif
			} else if ((S9 && tk==0 && SubString(s,1,2)=="r" && Iz(SubString(s,2,3)) && Hz(SubString(s,3,4)))) {//elseif(S9 and tk==0 and SubString(s,1,2)=="r" and Iz(SubString(s,2,3))and Hz(SubString(s,3,4)))then
				Z9 = 1;//set Z9=1
				V9 = "gz";//set V9="gz"
				Xy(true);//call Xy(true)
			} else if ((S9 && tk==0 && SubString(s,1,2)=="p" && Iz(SubString(s,2,3)) && Hz(SubString(s,3,4)))) {//elseif(S9 and tk==0 and SubString(s,1,2)=="p" and Iz(SubString(s,2,3))and Hz(SubString(s,3,4)))then
				Z9 = 0;//set Z9=0
				V9 = "fz";//set V9="fz"
				Xy(true);//call Xy(true)
			} else if ((S9 && tk==0 && SubString(s,1,2)=="m" && Iz(SubString(s,2,3)) && Hz(SubString(s,3,4)))) {//elseif(S9 and tk==0 and SubString(s,1,2)=="m" and Iz(SubString(s,2,3))and Hz(SubString(s,3,4)))then
				Z9 = 2;//set Z9=2
				V9 = "Tz";//set V9="Tz"
				Xy(true);//call Xy(true)
			} else if ((S9 && tk==0 && SubString(s,1,2)=="d" && Iz(SubString(s,2,3)) && Hz(SubString(s,3,4)))) {//elseif(S9 and tk==0 and SubString(s,1,2)=="d" and Iz(SubString(s,2,3))and Hz(SubString(s,3,4)))then
				Z9 = 3;//set Z9=3
				V9 = "Uz";//set V9="Uz"
				Xy(true);//call Xy(true)
			} else if ((SubString(s,1,6)=="stats" && !S9)) {//elseif(SubString(s,1,6)=="stats" and not S9)then
				Sv(Player(tk));//call Sv(Player(tk))
			} else if ((SubString(s,1,4)=="afk"  && (!S9) && !xd)) {//elseif(SubString(s,1,4)=="afk" and(not S9)and not xd)then
				Kt(tk);//call Kt(tk)
			} else if ((SubString(s,1,3)=="at")) {//elseif(SubString(s,1,3)=="at")then
				Pz(tk);//call Pz(tk)
			} else if ((SubString(s,1,5)=="mode"  && (!S9))) {//elseif(SubString(s,1,5)=="mode" and(not S9))then
				DisplayTimedTextToPlayer(Player(tk), .0, .0, 10., "|cffFFFF00Game-config-string|r:");//call DisplayTimedTextToPlayer(Player(tk),.0,.0,10.,"|cffFFFF00Game-config-string|r:")
				DisplayTimedTextToPlayer(Player(tk), .0, .0, 10., cz());//call DisplayTimedTextToPlayer(Player(tk),.0,.0,10.,cz())
			} else if ((SubString(s,1,7)=="income" && !S9)) {//elseif(SubString(s,1,7)=="income" and not S9)then
				Rv(Player(tk));//call Rv(Player(tk))
			} else if ((SubString(s,1,6)=="armor")) {//elseif(SubString(s,1,6)=="armor")then
				p = Player(tk);//set p=Player(tk)
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFFF00Armor table:");//call DisplayTimedTextToPlayer(p,.0,.0,10.,"|cffFFFF00Armor table:")
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Chaos damage:    |cffFFFF00neutral against all|r");//call DisplayTimedTextToPlayer(p,.0,.0,10.,"|cffFFCC00Chaos damage:    |cffFFFF00neutral against all|r")
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Normal damage: |cff00FF00good against:|r medium |cffFF0000bad against:|r light");//call DisplayTimedTextToPlayer(p,.0,.0,10.,"|cffFFCC00Normal damage: |cff00FF00good against:|r medium |cffFF0000bad against:|r light")
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Pierce damage:   |cff00FF00good against:|r light        |cffFF0000bad against:|r heavy");//call DisplayTimedTextToPlayer(p,.0,.0,10.,"|cffFFCC00Pierce damage:   |cff00FF00good against:|r light        |cffFF0000bad against:|r heavy")
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Magic damage:   |cff00FF00good against:|r heavy      |cffFF0000bad against:|r medium");//call DisplayTimedTextToPlayer(p,.0,.0,10.,"|cffFFCC00Magic damage:   |cff00FF00good against:|r heavy      |cffFF0000bad against:|r medium")
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Siege damage:     |cff00FF00good against:|r fortified |cffFF0000bad against:|r all others");//call DisplayTimedTextToPlayer(p,.0,.0,10.,"|cffFFCC00Siege damage:     |cff00FF00good against:|r fortified |cffFF0000bad against:|r all others")
				DisplayTimedTextToPlayer(p, .0, .0, 10., "|cffFFCC00Note:|r All attack types are |cffFF0000bad|r against divine besides chaos!");//call DisplayTimedTextToPlayer(p,.0,.0,10.,"|cffFFCC00Note:|r All attack types are |cffFF0000bad|r against divine besides chaos!")
			} else if ((tk==0 && SubString(s,1,5)=="roll")) {//elseif(tk==0 and SubString(s,1,5)=="roll")then
				Kz(S2I(SubString(s, 5, StringLength(s))));//call Kz(S2I(SubString(s,5,StringLength(s))))
			} else if ((SubString(s,1,5)=="draw")) {//elseif(SubString(s,1,5)=="draw")then
				Zj(tk);//call Zj(tk)
			} else if ((SubString(s,1,3)=="mt")) {//elseif(SubString(s,1,3)=="mt")then
				Oz(tk, S2I(SubString(s, 3, StringLength(s))));//call Oz(tk,S2I(SubString(s,3,StringLength(s))))
			} else if ((SubString(s,1,6)=="agree")) {//elseif(SubString(s,1,6)=="agree")then
				Bz(tk);//call Bz(tk)
			} else {//else
				DisplayTextToPlayer(Player(tk), .0, .0, "Sorry, but command [|c00ff0000"+SubString(s, 1, StringLength(s))+"|r] coudn't be executed. You are not allowed to perform it in current time or you have mistake in syntax.");//call DisplayTextToPlayer(Player(tk),.0,.0,"Sorry, but command [|c00ff0000"+SubString(s,1,StringLength(s))+"|r] coudn't be executed. You are not allowed to perform it in current time or you have mistake in syntax.")
			}//endif
		}//endfunction
		private bool Vz() {//function Vz takes nothing returns boolean
			return SubString(GetEventPlayerChatString(),0,1)=="-";//return SubString(GetEventPlayerChatString(),0,1)=="-"
		}//endfunction
		private void Wz() {//function Wz takes nothing returns nothing
			string Xz = GetEventPlayerChatString();//local string Xz=GetEventPlayerChatString()
			string s = StringCase(Xz,false);//local string s=StringCase(Xz,false)
			int Yz = 0;//local integer Yz=0
			int Zz = 0;//local integer Zz=0
			int dA = StringLength(s);//local integer dA=StringLength(s)
			int i = 0;//local integer i=0
			int id = GetPlayerId(GetTriggerPlayer());//local integer id=GetPlayerId(GetTriggerPlayer())
			string ch;//local string ch
			Pj("CE: "+Xz);//call Pj("CE: "+Xz)
			Rj();//call Rj()
			while (true) {//loop
				ch = SubString(s,i,i+1);//set ch=SubString(s,i,i+1)
				if (ch=="-" ) {//if ch=="-" then
					if (Yz!=i ) {//if Yz!=i then
						if (Zz>0 ) {//if Zz>0 then
							Sz(SubString(s, Yz, Zz)+SubString(Xz, Zz, i), id);//call Sz(SubString(s,Yz,Zz)+SubString(Xz,Zz,i),id)
						} else {//else
							Sz(SubString(s, Yz, i), id);//call Sz(SubString(s,Yz,i),id)
						}//endif
					}//endif
					Yz = i;//set Yz=i
					Zz = 0;//set Zz=0
				} else if (Zz==0 && ch==" " ) {//elseif Zz==0 and ch==" " then
					Zz = i;//set Zz=i
				}//endif
				i = i+1;//set i=i+1
				if (i>=dA) { break; }//exitwhen i>=dA
			}//endloop
			if (Zz>0 ) {//if Zz>0 then
				Sz(SubString(s, Yz, Zz)+SubString(Xz, Zz, i), id);//call Sz(SubString(s,Yz,Zz)+SubString(Xz,Zz,i),id)
			} else {//else
				Sz(SubString(s, Yz, i), id);//call Sz(SubString(s,Yz,i),id)
			}//endif
		}//endfunction
		private void eA() {//function eA takes nothing returns nothing
			trigger t = CreateTrigger();//local trigger t=CreateTrigger()
			DestroyTimer(GetExpiredTimer());//call DestroyTimer(GetExpiredTimer())
			TriggerRegisterPlayerChatEvent(t, Player(0), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player(0),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player(1), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player(1),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player(2), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player(2),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player(3), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player(3),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player(4), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player(4),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player(5), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player(5),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player(6), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player(6),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player(7), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player(7),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player(8), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player(8),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player(9), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player(9),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player($A), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player($A),"-",false)
			TriggerRegisterPlayerChatEvent(t, Player($B), "-", false);//call TriggerRegisterPlayerChatEvent(t,Player($B),"-",false)
			TriggerAddCondition(t, Condition(function Vz));//call TriggerAddCondition(t,Condition(function Vz))
			TriggerAddAction(t, function Wz);//call TriggerAddAction(t,function Wz)
			t = null;//set t=null
		}//endfunction
		private void fA() {//function fA takes nothing returns nothing
			TimerStart(CreateTimer(), .2, false, function eA);//call TimerStart(CreateTimer(),.2,false,function eA)
		}//endfunction
		private void gA() {//function gA takes nothing returns nothing
			FogEnable(false);//call FogEnable(false)
			U9 = true;//set U9=true
		}//endfunction
		private void hA() {//function hA takes nothing returns nothing
			int i;//local integer i
			unit u;//local unit u
			player pl;//local player pl
			player pr;//local player pr
			bool iA = false;//local boolean iA=false
			K9 = K9+1;//set K9=K9+1
			Pj("RE: "+I2S(K9));//call Pj("RE: "+I2S(K9))
			Rj();//call Rj()
			FogEnable(true);//call FogEnable(true)
			pl = ForcePickRandomPlayer(ie);//set pl=ForcePickRandomPlayer(ie)
			pr = ForcePickRandomPlayer(je);//set pr=ForcePickRandomPlayer(je)
			if ((K9==1)) {//if(K9==1)then
				Lt();//call Lt()
			}//endif
			if ((pl==null)) {//if(pl==null)then
				pl = Player(0);//set pl=Player(0)
			}//endif
			if ((pr==null)) {//if(pr==null)then
				pr = Player(6);//set pr=Player(6)
				if ((K9==1)) {//if(K9==1)then
					ForceRemovePlayer(ke, pr);//call ForceRemovePlayer(ke,pr)
					ForceAddPlayer(je, pr);//call ForceAddPlayer(je,pr)
					CreateFogModifierRectBJ(true, pr, FOG_OF_WAR_VISIBLE, Q9);//call CreateFogModifierRectBJ(true,pr,FOG_OF_WAR_VISIBLE,Q9)
					Qd[6] = dn(false);//set Qd[6]=dn(false)
					ne[6] = CreateForce();//set ne[6]=CreateForce()
					It(6);//call It(6)
				}//endif
			}//endif
			Ny();//call Ny()
			Wo();//call Wo()
			DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 9.5, "Get ready for round |cffFFCC00"+I2S(K9)+"|r!");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,9.5,"Get ready for round |cffFFCC00"+I2S(K9)+"|r!")
			CinematicFadeBJ(0, 4., "ReplaceableTextures\\CameraMasks\\Black_mask.blp", 0, 0, 0, 6.);//call CinematicFadeBJ(0,4.,"ReplaceableTextures\\CameraMasks\\Black_mask.blp",0,0,0,6.)
			Ag = CreateFogModifierRectBJ(true,ForcePickRandomPlayer(ie),FOG_OF_WAR_VISIBLE,cg);//set Ag=CreateFogModifierRectBJ(true,ForcePickRandomPlayer(ie),FOG_OF_WAR_VISIBLE,cg)
			ag = CreateFogModifierRectBJ(true,ForcePickRandomPlayer(je),FOG_OF_WAR_VISIBLE,Dg);//set ag=CreateFogModifierRectBJ(true,ForcePickRandomPlayer(je),FOG_OF_WAR_VISIBLE,Dg)
			hg = CreateTrigger();//set hg=CreateTrigger()
			ig = CreateTrigger();//set ig=CreateTrigger()
			oe[0] = CreateUnitAtLoc(pl,1633904679,Id[1],270.);//set oe[0]=CreateUnitAtLoc(pl,'hcas',Id[1],270.)
			SetUnitX(oe[0], GetLocationX(Id[1]));//call SetUnitX(oe[0],GetLocationX(Id[1]))
			SetUnitY(oe[0], GetLocationY(Id[1]));//call SetUnitY(oe[0],GetLocationY(Id[1]))
			SetUnitColor(oe[0], PLAYER_COLOR_RED);//call SetUnitColor(oe[0],PLAYER_COLOR_RED)
			if ((!qd)) {//if(not qd)then
				UnitRemoveAbility(oe[0], 'Aall');//call UnitRemoveAbility(oe[0],'Aall')
				UnitRemoveAbility(oe[0], 'Apit');//call UnitRemoveAbility(oe[0],'Apit')
			}//endif
			TriggerRegisterDeathEvent(hg, oe[0]);//call TriggerRegisterDeathEvent(hg,oe[0])
			oe[1] = CreateUnitAtLoc(pr,1633904679,Id[0],270.);//set oe[1]=CreateUnitAtLoc(pr,'hcas',Id[0],270.)
			SetUnitX(oe[1], GetLocationX(Id[0]));//call SetUnitX(oe[1],GetLocationX(Id[0]))
			SetUnitY(oe[1], GetLocationY(Id[0]));//call SetUnitY(oe[1],GetLocationY(Id[0]))
			SetUnitColor(oe[1], PLAYER_COLOR_GREEN);//call SetUnitColor(oe[1],PLAYER_COLOR_GREEN)
			if ((!qd)) {//if(not qd)then
				UnitRemoveAbility(oe[1], 'Aall');//call UnitRemoveAbility(oe[1],'Aall')
				UnitRemoveAbility(oe[1], 'Apit');//call UnitRemoveAbility(oe[1],'Apit')
			}//endif
			TriggerRegisterDeathEvent(ig, oe[1]);//call TriggerRegisterDeathEvent(ig,oe[1])
			TriggerAddAction(hg, function xz);//call TriggerAddAction(hg,function xz)
			TriggerAddAction(ig, function yz);//call TriggerAddAction(ig,function yz)
			if ((vd)) {//if(vd)then
				Dn();//call Dn()
			}//endif
			TriggerSleepAction(4.);//call TriggerSleepAction(4.)
			mn();//call mn()
			vm();//call vm()
			Hy();//call Hy()
			UnitShareVision(oe[0], pr, true);//call UnitShareVision(oe[0],pr,true)
			UnitShareVision(oe[1], pl, true);//call UnitShareVision(oe[1],pl,true)
			TriggerSleepAction(1.);//call TriggerSleepAction(1.)
			UnitShareVision(oe[0], pr, false);//call UnitShareVision(oe[0],pr,false)
			UnitShareVision(oe[1], pl, false);//call UnitShareVision(oe[1],pl,false)
			Sy();//call Sy()
			if ((!jd || K9==1)) {//if(not jd or K9==1)then
				if ((!xd)) {//if(not xd)then
					Wy();//call Wy()
				}//endif
				Lm();//call Lm()
				if ((Bd!=0)) {//if(Bd!=0)then
					if ((Bd>0)) {//if(Bd>0)then
						ExecuteFunc("jA");//call ExecuteFunc("jA")
					} else {//else
						ExecuteFunc("kA");//call ExecuteFunc("kA")
					}//endif
					while (true) {//loop
						TriggerSleepAction(1.);//call TriggerSleepAction(1.)
						if (wg) { break; }//exitwhen wg
					}//endloop
					wg = false;//set wg=false
				}//endif
				i = 0;//set i=0
				while (true) {//loop
					Pd[i] = 0;//set Pd[i]=0
					i = i+1;//set i=i+1
					if (i>$B) { break; }//exitwhen i>$B
				}//endloop
				Km();//call Km()
				ExecuteFunc(V9);//call ExecuteFunc(V9)
				while (true) {//loop
					TriggerSleepAction(1.);//call TriggerSleepAction(1.)
					if (wg) { break; }//exitwhen wg
				}//endloop
				wg = false;//set wg=false
				DisableTrigger(J7);//call DisableTrigger(J7)
			}//endif
			Md[0] = 0;//set Md[0]=0
			Md[1] = 0;//set Md[1]=0
			Nd[0] = 0;//set Nd[0]=0
			Nd[1] = 0;//set Nd[1]=0
			i = 0;//set i=0
			while (true) {//loop
				if ((Pd[i]!=0)) {//if(Pd[i]!=0)then
					if ((Pd[i]==808478759)) {//if(Pd[i]=='h00C')then
						iA = true;//set iA=true
					}//endif
					u = CreateUnitAtLoc(Player(i),Pd[i],Qd[i],180.*me[i]);//set u=CreateUnitAtLoc(Player(i),Pd[i],Qd[i],180.*me[i])
					if ((!sd)) {//if(not sd)then
						UnitRemoveAbility(u, 'A005');//call UnitRemoveAbility(u,'A005')
						UnitRemoveAbility(u, 'A06E');//call UnitRemoveAbility(u,'A06E')
					} else {//else
						Md[me[i]] = Md[me[i]]+1;//set Md[me[i]]=Md[me[i]]+1
						Zr(H9[i], me[i]*6+1, "V");//call Zr(H9[i],me[i]*6+1,"V")
					}//endif
					PanCameraToTimedLocForPlayer(Player(i), Qd[i], .01);//call PanCameraToTimedLocForPlayer(Player(i),Qd[i],.01)
					SetPlayerState(Player(i), PLAYER_STATE_RESOURCE_GOLD, W9);//call SetPlayerState(Player(i),PLAYER_STATE_RESOURCE_GOLD,W9)
					SetPlayerState(Player(i), PLAYER_STATE_RESOURCE_LUMBER, X9);//call SetPlayerState(Player(i),PLAYER_STATE_RESOURCE_LUMBER,X9)
					if ((rd)) {//if(rd)then
						SetPlayerState(Player(i), PLAYER_STATE_RESOURCE_FOOD_CAP, Y9);//call SetPlayerState(Player(i),PLAYER_STATE_RESOURCE_FOOD_CAP,Y9)
					} else {//else
						SetPlayerState(Player(i), PLAYER_STATE_RESOURCE_FOOD_CAP, 0);//call SetPlayerState(Player(i),PLAYER_STATE_RESOURCE_FOOD_CAP,0)
					}//endif
					if ((E9[i]!=null)) {//if(E9[i]!=null)then
						UnitAddAbility(u, 'A0A5');//call UnitAddAbility(u,'A0A5')
					}//endif
					Js(i);//call Js(i)
				} else {//else
					ls(i);//call ls(i)
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			Yr(1, 1, I2S(Md[0]));//call Yr(1,1,I2S(Md[0]))
			Yr(1, 2, I2S(Md[1]));//call Yr(1,2,I2S(Md[1]))
			TimerStart(jf, hd, true, function Qv);//call TimerStart(jf,hd,true,function Qv)
			fj();//call fj()
			if ((gd!=-1)) {//if(gd!=-1)then
				TimerStart(vg, gd, false, function gA);//call TimerStart(vg,gd,false,function gA)
			}//endif
			M9 = 0;//set M9=0
			N9 = 0;//set N9=0
			TimerStart(L9, 1., true, function es);//call TimerStart(L9,1.,true,function es)
			Nr();//call Nr()
			TimerStart(B9, 4., true, function Mr);//call TimerStart(B9,4.,true,function Mr)
			nk();//call nk()
			Xj();//call Xj()
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, "Round |cffFFCC00"+I2S(K9)+"|r started! gl & hf!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,"Round |cffFFCC00"+I2S(K9)+"|r started! gl & hf!")
			PlaySoundBJ(Gg);//call PlaySoundBJ(Gg)
			Mt();//call Mt()
			Um();//call Um()
			gg = true;//set gg=true
			u = null;//set u=null
			dp(iA);//call dp(iA)
			Ym(true);//call Ym(true)
			Vy();//call Vy()
			Zr(I9+1, 0, "|cffFFCC00Modes:|r"+cz());//call Zr(I9+1,0,"|cffFFCC00Modes:|r"+cz())
		}//endfunction
		private void mA() {//function mA takes nothing returns nothing
			xg = nn();//set xg=nn()
			yg = nn();//set yg=nn()
			Om(xg, yg);//call Om(xg,yg)
		}//endfunction
		private void nA() {//function nA takes nothing returns nothing
			li(xg);//call li(xg)
			li(yg);//call li(yg)
			wg = true;//set wg=true
		}//endfunction
		private void oA(int id, bool pA) {//function oA takes integer id,boolean pA returns nothing
			if ((kd)) {//if(kd)then
				if ((td)) {//if(td)then
					if ((pA)) {//if(pA)then
						on(yg, id);//call on(yg,id)
					} else {//else
						on(xg, id);//call on(xg,id)
					}//endif
				}//endif
			} else {//else
				if ((td)) {//if(td)then
					on(xg, id);//call on(xg,id)
					on(yg, id);//call on(yg,id)
				} else {//else
					if ((pA)) {//if(pA)then
						on(xg, id);//call on(xg,id)
					} else {//else
						on(yg, id);//call on(yg,id)
					}//endif
				}//endif
			}//endif
		}//endfunction
		private void qA() {//function qA takes nothing returns nothing
			TriggerAddAction(zg, function hA);//call TriggerAddAction(zg,function hA)
		}//endfunction
		private void jA() {//function jA takes nothing returns nothing
			timer rA;//local timer rA
			timerdialog sA;//local timerdialog sA
			int ct;//local integer ct
			int tA;//local integer tA
			player p;//local player p
			int uA;//local integer uA
			int dk;//local integer dk
			mA();//call mA()
			rA = CreateTimer();//set rA=CreateTimer()
			sA = CreateTimerDialog(rA);//set sA=CreateTimerDialog(rA)
			TimerDialogSetTitle(sA, "Time to ban:");//call TimerDialogSetTitle(sA,"Time to ban:")
			TimerDialogDisplay(sA, true);//call TimerDialogDisplay(sA,true)
			ct = GetRandomInt(0,1);//set ct=GetRandomInt(0,1)
			tA = Bd*2;//set tA=Bd*2
			while (true) {//loop
				if ((ct==0)) {//if(ct==0)then
					p = vn(ie);//set p=vn(ie)
					ct = 1;//set ct=1
				} else {//else
					p = vn(je);//set p=vn(je)
					ct = 0;//set ct=0
				}//endif
				dk = GetPlayerId(p);//set dk=GetPlayerId(p)
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+", your turn to ban race now...");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+", your turn to ban race now...")
				TimerStart(rA, 15., false, null);//call TimerStart(rA,15.,false,null)
				uA = Fm(CreateUnit(p,959473703,GetLocationX(Qd[dk]),GetLocationY(Qd[dk]),270.),15.);//set uA=Fm(CreateUnit(p,'h09W',GetLocationX(Qd[dk]),GetLocationY(Qd[dk]),270.),15.)
				if ((uA==-1)) {//if(uA==-1)then
					uA = pn(xg);//set uA=pn(xg)
				}//endif
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" has banned |cffFFFF00"+zm(uA));//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" has banned |cffFFFF00"+zm(uA))
				on(xg, uA);//call on(xg,uA)
				Bm(uA, false);//call Bm(uA,false)
				tA = tA-1;//set tA=tA-1
				if (tA<=0) { break; }//exitwhen tA<=0
			}//endloop
			DestroyTimerDialog(sA);//call DestroyTimerDialog(sA)
			sA = null;//set sA=null
			DestroyTimer(rA);//call DestroyTimer(rA)
			rA = null;//set rA=null
			nA();//call nA()
		}//endfunction
		private void vA(int Gz) {//function vA takes integer Gz returns nothing
			oA(Pd[Gz], IsPlayerInForce(Player(Gz), ie));//call oA(Pd[Gz],IsPlayerInForce(Player(Gz),ie))
			if ((kd)) {//if(kd)then
				if ((td)) {//if(td)then
					Cm(Pd[Gz], false, ModuloInteger(me[Gz]+1, 2));//call Cm(Pd[Gz],false,ModuloInteger(me[Gz]+1,2))
				}//endif
			} else {//else
				if ((td)) {//if(td)then
					Bm(Pd[Gz], false);//call Bm(Pd[Gz],false)
				} else {//else
					Cm(Pd[Gz], false, me[Gz]);//call Cm(Pd[Gz],false,me[Gz])
				}//endif
			}//endif
		}//endfunction
		private void wA() {//function wA takes nothing returns nothing
			trigger t = GetTriggeringTrigger();//local trigger t=GetTriggeringTrigger()
			timer rA;//local timer rA
			timerdialog sA;//local timerdialog sA
			int xA = 0;//local integer xA=0
			int yA = 0;//local integer yA=0
			int ct;//local integer ct
			player zA;//local player zA
			int i = 0;//local integer i=0
			int dk;//local integer dk
			mA();//call mA()
			rA = CreateTimer();//set rA=CreateTimer()
			sA = CreateTimerDialog(rA);//set sA=CreateTimerDialog(rA)
			TimerDialogSetTitle(sA, "Time to select:");//call TimerDialogSetTitle(sA,"Time to select:")
			TimerDialogDisplay(sA, true);//call TimerDialogDisplay(sA,true)
			if ((Bg<0)) {//if(Bg<0)then
				Bg = GetRandomInt(0,1);//set Bg=GetRandomInt(0,1)
			}//endif
			Bg = ModuloInteger(Bg+1,2);//set Bg=ModuloInteger(Bg+1,2)
			ct = 1+2*Bg;//set ct=1+2*Bg
			while (true) {//loop
				Pd[i] = 0;//set Pd[i]=0
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			while (true) {//loop
				zA = null;//set zA=null
				if ((ct<2)) {//if(ct<2)then
					while (true) {//loop
						if ((IsPlayerInForce(Player(xA),ie))) {//if(IsPlayerInForce(Player(xA),ie))then
							zA = Player(xA);//set zA=Player(xA)
						}//endif
						xA = xA+1;//set xA=xA+1
						if (zA!=null || xA>$B) { break; }//exitwhen zA!=null or xA>$B
					}//endloop
				} else {//else
					while (true) {//loop
						if ((IsPlayerInForce(Player(yA),je))) {//if(IsPlayerInForce(Player(yA),je))then
							zA = Player(yA);//set zA=Player(yA)
						}//endif
						yA = yA+1;//set yA=yA+1
						if (zA!=null || yA>$B) { break; }//exitwhen zA!=null or yA>$B
					}//endloop
				}//endif
				ct = ct+1;//set ct=ct+1
				if ((ct>=4)) {//if(ct>=4)then
					ct = 0;//set ct=0
				}//endif
				if (zA==null && xA>$B && yA>$B) { break; }//exitwhen zA==null and xA>$B and yA>$B
				if ((zA!=null)) {//if(zA!=null)then
					dk = GetPlayerId(zA);//set dk=GetPlayerId(zA)
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" is selecting now...");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" is selecting now...")
					TimerStart(rA, 15., false, null);//call TimerStart(rA,15.,false,null)
					Pd[dk] = Fm(CreateUnit(zA,858810407,GetLocationX(Qd[dk]),GetLocationY(Qd[dk]),270.),15.);//set Pd[dk]=Fm(CreateUnit(zA,'h033',GetLocationX(Qd[dk]),GetLocationY(Qd[dk]),270.),15.)
					if ((Pd[dk]==-1)) {//if(Pd[dk]==-1)then
						DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" skipped selection.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" skipped selection.")
					} else {//else
						DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" controls |cffFFFF00"+zm(Pd[dk])+"|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" controls |cffFFFF00"+zm(Pd[dk])+"|r.")
						vA(dk);//call vA(dk)
					}//endif
				}//endif
			}//endloop
			i = 0;//set i=0
			while (true) {//loop
				if ((Pd[i]==-1)) {//if(Pd[i]==-1)then
					zA = Player(i);//set zA=Player(i)
					if ((IsPlayerInForce(zA,ie))) {//if(IsPlayerInForce(zA,ie))then
						Pd[i] = pn(xg);//set Pd[i]=pn(xg)
						vA(i);//call vA(i)
					} else if ((IsPlayerInForce(zA,je))) {//elseif(IsPlayerInForce(zA,je))then
						Pd[i] = pn(yg);//set Pd[i]=pn(yg)
						vA(i);//call vA(i)
					}//endif
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[i]+" controls |cffFFFF00"+zm(Pd[i])+"|r.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[i]+" controls |cffFFFF00"+zm(Pd[i])+"|r.")
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			DestroyTimerDialog(sA);//call DestroyTimerDialog(sA)
			sA = null;//set sA=null
			DestroyTimer(rA);//call DestroyTimer(rA)
			rA = null;//set rA=null
			nA();//call nA()
			TriggerClearActions(t);//call TriggerClearActions(t)
			DestroyTrigger(t);//call DestroyTrigger(t)
			t = null;//set t=null
		}//endfunction
		private void Uz() {//function Uz takes nothing returns nothing
			trigger t = CreateTrigger();//local trigger t=CreateTrigger()
			TriggerAddAction(t, function wA);//call TriggerAddAction(t,function wA)
			TriggerExecute(t);//call TriggerExecute(t)
			t = null;//set t=null
		}//endfunction
		private void Tz() {//function Tz takes nothing returns nothing
			int i = 0;//local integer i=0
			int j = 0;//local integer j=0
			JassArray<int> AA = new JassArray<int>();//local integer array AA
			force f1;//local force f1
			force f2;//local force f2
			mA();//call mA()
			if ((CountPlayersInForceBJ(ie)>=CountPlayersInForceBJ(je))) {//if(CountPlayersInForceBJ(ie)>=CountPlayersInForceBJ(je))then
				f1 = ie;//set f1=ie
				f2 = je;//set f2=je
			} else {//else
				f1 = je;//set f1=je
				f2 = ie;//set f2=ie
			}//endif
			while (true) {//loop
				if ((IsPlayerInForce(Player(i),f1))) {//if(IsPlayerInForce(Player(i),f1))then
					Pd[i] = pn(xg);//set Pd[i]=pn(xg)
					if ((!kd)) {//if(not kd)then
						on(xg, Pd[i]);//call on(xg,Pd[i])
					}//endif
					AA[j] = Pd[i];//set AA[j]=Pd[i]
					j = j+1;//set j=j+1
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			i = 0;//set i=0
			j = 0;//set j=0
			while (true) {//loop
				if ((IsPlayerInForce(Player(i),f2))) {//if(IsPlayerInForce(Player(i),f2))then
					Pd[i] = AA[j];//set Pd[i]=AA[j]
					j = j+1;//set j=j+1
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			f1 = null;//set f1=null
			f2 = null;//set f2=null
			nA();//call nA()
		}//endfunction
		private void aA(int Gz) {//function aA takes integer Gz returns nothing
			oA(D7[Gz], IsPlayerInForce(Player(Gz), ie));//call oA(D7[Gz],IsPlayerInForce(Player(Gz),ie))
			if ((kd)) {//if(kd)then
				if ((td)) {//if(td)then
					Cm(D7[Gz], false, ModuloInteger(me[Gz]+1, 2));//call Cm(D7[Gz],false,ModuloInteger(me[Gz]+1,2))
				}//endif
			} else {//else
				if ((td)) {//if(td)then
					Bm(D7[Gz], false);//call Bm(D7[Gz],false)
				} else {//else
					Cm(D7[Gz], false, me[Gz]);//call Cm(D7[Gz],false,me[Gz])
				}//endif
			}//endif
		}//endfunction
		private bool BA() {//function BA takes nothing returns boolean
			bg = bg-1;//set bg=bg-1
			if ((D7[c7]==-1)) {//if(D7[c7]==-1)then
				return false;//return false
			}//endif
			aA(c7);//call aA(c7)
			return false;//return false
		}//endfunction
		private void bA() {//function bA takes nothing returns nothing
			trigger t = GetTriggeringTrigger();//local trigger t=GetTriggeringTrigger()
			timer rA;//local timer rA
			timerdialog sA;//local timerdialog sA
			JassArray<unit> CA = new JassArray<unit>();//local unit array CA
			int i = 0;//local integer i=0
			player p;//local player p
			int uA;//local integer uA
			int dk;//local integer dk
			mA();//call mA()
			rA = CreateTimer();//set rA=CreateTimer()
			sA = CreateTimerDialog(rA);//set sA=CreateTimerDialog(rA)
			TimerDialogSetTitle(sA, "Time to select:");//call TimerDialogSetTitle(sA,"Time to select:")
			TimerDialogDisplay(sA, true);//call TimerDialogDisplay(sA,true)
			Cg = CreateTrigger();//set Cg=CreateTrigger()
			TriggerAddCondition(Cg, Condition(function BA));//call TriggerAddCondition(Cg,Condition(function BA))
			C7 = Cg;//set C7=Cg
			bg = 0;//set bg=0
			while (true) {//loop
				p = Player(i);//set p=Player(i)
				if ((IsPlayerInForce(p,ie) || IsPlayerInForce(p,je))) {//if(IsPlayerInForce(p,ie)or IsPlayerInForce(p,je))then
					CA[i] = Em(CreateUnit(p,858810407,GetLocationX(Qd[i]),GetLocationY(Qd[i]),270.));//set CA[i]=Em(CreateUnit(p,'h033',GetLocationX(Qd[i]),GetLocationY(Qd[i]),270.))
					bg = bg+1;//set bg=bg+1
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			TimerStart(rA, 15., false, null);//call TimerStart(rA,15.,false,null)
			while (true) {//loop
				TriggerSleepAction(.33);//call TriggerSleepAction(.33)
				if (TimerGetRemaining(rA)<.33 || bg<=0) { break; }//exitwhen TimerGetRemaining(rA)<.33 or bg<=0
			}//endloop
			TriggerClearConditions(Cg);//call TriggerClearConditions(Cg)
			DestroyTrigger(Cg);//call DestroyTrigger(Cg)
			i = 0;//set i=0
			while (true) {//loop
				p = Player(i);//set p=Player(i)
				if ((IsPlayerInForce(p,ie) || IsPlayerInForce(p,je))) {//if(IsPlayerInForce(p,ie)or IsPlayerInForce(p,je))then
					if ((D7[i]==-1 || D7[i]==0)) {//if(D7[i]==-1 or D7[i]==0)then
						if ((IsPlayerInForce(p,ie))) {//if(IsPlayerInForce(p,ie))then
							D7[i] = pn(xg);//set D7[i]=pn(xg)
						} else if ((IsPlayerInForce(p,je))) {//elseif(IsPlayerInForce(p,je))then
							D7[i] = pn(yg);//set D7[i]=pn(yg)
						}//endif
						aA(i);//call aA(i)
					}//endif
					Pd[i] = D7[i];//set Pd[i]=D7[i]
				} else {//else
					Pd[i] = 0;//set Pd[i]=0
				}//endif
				RemoveUnit(CA[i]);//call RemoveUnit(CA[i])
				CA[i] = null;//set CA[i]=null
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			DestroyTimerDialog(sA);//call DestroyTimerDialog(sA)
			sA = null;//set sA=null
			DestroyTimer(rA);//call DestroyTimer(rA)
			rA = null;//set rA=null
			nA();//call nA()
			TriggerClearActions(t);//call TriggerClearActions(t)
			DestroyTrigger(t);//call DestroyTrigger(t)
			t = null;//set t=null
		}//endfunction
		private void fz() {//function fz takes nothing returns nothing
			trigger t = CreateTrigger();//local trigger t=CreateTrigger()
			TriggerAddAction(t, function bA);//call TriggerAddAction(t,function bA)
			TriggerExecute(t);//call TriggerExecute(t)
			t = null;//set t=null
		}//endfunction
		private void kA() {//function kA takes nothing returns nothing
			int tA = IAbsBJ(Bd);//local integer tA=IAbsBJ(Bd)
			string s = "";//local string s=""
			int uA;//local integer uA
			mA();//call mA()
			while (true) {//loop
				uA = pn(xg);//set uA=pn(xg)
				on(xg, uA);//call on(xg,uA)
				Bm(uA, false);//call Bm(uA,false)
				if ((s=="")) {//if(s=="")then
					s = zm(uA);//set s=zm(uA)
				} else {//else
					s = s+", "+zm(uA);//set s=s+", "+zm(uA)
				}//endif
				tA = tA-1;//set tA=tA-1
				if (tA<=0) { break; }//exitwhen tA<=0
			}//endloop
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, s+" have banned by Random.");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,s+" have banned by Random.")
			nA();//call nA()
		}//endfunction
		private void gz() {//function gz takes nothing returns nothing
			int i = 0;//local integer i=0
			mA();//call mA()
			while (true) {//loop
				if ((IsPlayerInForce(Player(i),ie))) {//if(IsPlayerInForce(Player(i),ie))then
					Pd[i] = pn(xg);//set Pd[i]=pn(xg)
					oA(Pd[i], true);//call oA(Pd[i],true)
				} else if ((IsPlayerInForce(Player(i),je))) {//elseif(IsPlayerInForce(Player(i),je))then
					Pd[i] = pn(yg);//set Pd[i]=pn(yg)
					oA(Pd[i], false);//call oA(Pd[i],false)
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
			nA();//call nA()
		}//endfunction
		private void cA(unit u, unit j) {//function cA takes unit u,unit j returns nothing
			if ((GetUnitAbilityLevel(j,1144013095)>0)) {//if(GetUnitAbilityLevel(j,'A0DZ')>0)then
				Wr(u, j);//call Wr(u,j)
			}//endif
		}//endfunction
		private void DA() {//function DA takes nothing returns nothing
			unit u = GetSummonedUnit();//local unit u=GetSummonedUnit()
			int aj = GetUnitTypeId(u);//local integer aj=GetUnitTypeId(u)
			if ((aj==858810407)) {//if(aj=='h03C')then
				SetUnitState(u, UNIT_STATE_MANA, 30.);//call SetUnitState(u,UNIT_STATE_MANA,30.)
			} else if ((aj==858810407)) {//elseif(aj=='h03A')then
				TriggerSleepAction(.7);//call TriggerSleepAction(.7)
				IssueImmediateOrderById(u, $D0057);//call IssueImmediateOrderById(u,$D0057)
				TriggerSleepAction(.1);//call TriggerSleepAction(.1)
			} else if ((GetUnitAbilityLevel(u,925909287)>0)) {//elseif(GetUnitAbilityLevel(u,'A07M')>0)then
				Mo(u);//call Mo(u)
				GroupAddUnit(z9, u);//call GroupAddUnit(z9,u)
			} else if ((aj==858810407)) {//elseif(aj=='h030')then
				UnitRemoveType(u, UNIT_TYPE_SUMMONED);//call UnitRemoveType(u,UNIT_TYPE_SUMMONED)
				if ((GetUnitTypeId(GetSummoningUnit())==858810407)) {//if(GetUnitTypeId(GetSummoningUnit())=='h030')then
					u = ReplaceUnitBJ(u,842033191,2);//set u=ReplaceUnitBJ(u,'h02Z',2)
				} else {//else
					cA(u, GetSummoningUnit());//call cA(u,GetSummoningUnit())
				}//endif
			}//endif
			Qo(u);//call Qo(u)
			u = null;//set u=null
		}//endfunction
		private void FA(int dk) {//function FA takes integer dk returns nothing
			unit u;//local unit u
			GroupEnumUnitsOfPlayer(q4, Player(dk), b9);//call GroupEnumUnitsOfPlayer(q4,Player(dk),b9)
			u = FirstOfGroup(q4);//set u=FirstOfGroup(q4)
			if ((u==null)) {//if(u==null)then
				return;//return
			}//endif
			if ((GetUnitAbilityLevel(u,808468775)>0)) {//if(GetUnitAbilityLevel(u,'A005')>0)then
				Md[me[dk]] = Md[me[dk]]-1;//set Md[me[dk]]=Md[me[dk]]-1
				if ((Md[me[dk]]==0)) {//if(Md[me[dk]]==0)then
					Yr(1, me[dk]+1, "|cffFF00000|r");//call Yr(1,me[dk]+1,"|cffFF00000|r")
				} else {//else
					Yr(1, me[dk]+1, I2S(Md[me[dk]]));//call Yr(1,me[dk]+1,I2S(Md[me[dk]]))
				}//endif
			}//endif
			RemoveUnit(u);//call RemoveUnit(u)
			u = null;//set u=null
		}//endfunction
		private void GA() {//function GA takes nothing returns nothing
			unit u = GetEnumUnit();//local unit u=GetEnumUnit()
			int HA;//local integer HA
			if ((IsUnitType(u,UNIT_TYPE_STRUCTURE))) {//if(IsUnitType(u,UNIT_TYPE_STRUCTURE))then
				SetUnitOwner(u, ForcePickRandomPlayer(mh), true);//call SetUnitOwner(u,ForcePickRandomPlayer(mh),true)
				HA = (x4[GetUnitPointValue((u))]);//set HA=(x4[GetUnitPointValue((u))])
				if ((HA>0)) {//if(HA>0)then
					IssueImmediateOrderById(u, HA);//call IssueImmediateOrderById(u,HA)
					IssueImmediateOrderById(u, HA);//call IssueImmediateOrderById(u,HA)
				}//endif
				HA = GetPlayerId(GetOwningPlayer(u));//set HA=GetPlayerId(GetOwningPlayer(u))
				Nv(HA, u);//call Nv(HA,u)
				if ((!v4[GetUnitPointValue(u)])) {//if(not v4[GetUnitPointValue(u)])then
					Ud[HA] = Ud[HA]+1;//set Ud[HA]=Ud[HA]+1
				}//endif
			} else {//else
				SetUnitOwner(u, ForcePickRandomPlayer(mh), true);//call SetUnitOwner(u,ForcePickRandomPlayer(mh),true)
				Qo(u);//call Qo(u)
			}//endif
			u = null;//set u=null
		}//endfunction
		private void IA() {//function IA takes nothing returns nothing
			player p = GetEnumPlayer();//local player p=GetEnumPlayer()
			int dk = GetPlayerId(p);//local integer dk=GetPlayerId(p)
			int i = CountPlayersInForceBJ(mh);//local integer i=CountPlayersInForceBJ(mh)
			int g = GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)/ i;//local integer g=GetPlayerState(p,PLAYER_STATE_RESOURCE_GOLD)/ i
			int l = GetPlayerState(p,PLAYER_STATE_RESOURCE_LUMBER)/ i;//local integer l=GetPlayerState(p,PLAYER_STATE_RESOURCE_LUMBER)/ i
			string s = "You received |cffFFFF00"+I2S(g)+"|r gold && |cffFFFF00"+I2S(l)+"|r lumber from "+pe[dk];//local string s="You received |cffFFFF00"+I2S(g)+"|r gold and |cffFFFF00"+I2S(l)+"|r lumber from "+pe[dk]
			ls(dk);//call ls(dk)
			FA(dk);//call FA(dk)
			fn(Qd[dk]);//call fn(Qd[dk])
			ForceAddPlayer(ke, p);//call ForceAddPlayer(ke,p)
			GroupEnumUnitsOfPlayer(q4, p, null);//call GroupEnumUnitsOfPlayer(q4,p,null)
			ForGroup(q4, function GA);//call ForGroup(q4,function GA)
			i = 0;//set i=0
			while (true) {//loop
				p = Player(i);//set p=Player(i)
				if ((IsPlayerInForce(p,mh))) {//if(IsPlayerInForce(p,mh))then
					AdjustPlayerStateBJ(g, p, PLAYER_STATE_RESOURCE_GOLD);//call AdjustPlayerStateBJ(g,p,PLAYER_STATE_RESOURCE_GOLD)
					AdjustPlayerStateBJ(l, p, PLAYER_STATE_RESOURCE_LUMBER);//call AdjustPlayerStateBJ(l,p,PLAYER_STATE_RESOURCE_LUMBER)
					DisplayTextToPlayer(p, .0, .0, s);//call DisplayTextToPlayer(p,.0,.0,s)
				}//endif
				i = i+1;//set i=i+1
				if (i>$B) { break; }//exitwhen i>$B
			}//endloop
		}//endfunction
		private void lA(int dk) {//function lA takes integer dk returns nothing
			player p = Player(dk);//local player p=Player(dk)
			ForceRemovePlayer(mh, p);//call ForceRemovePlayer(mh,p)
			wn(mh, ne[dk]);//call wn(mh,ne[dk])
			ForceAddPlayer(ne[dk], p);//call ForceAddPlayer(ne[dk],p)
			ForForce(ne[dk], function IA);//call ForForce(ne[dk],function IA)
			DestroyForce(ne[dk]);//call DestroyForce(ne[dk])
			ne[dk] = null;//set ne[dk]=null
		}//endfunction
		private void JA(int dk) {//function JA takes integer dk returns nothing
			int i = 0;//local integer i=0
			player p = Player(dk);//local player p=Player(dk)
			force KA = ne[dk];//local force KA=ne[dk]
			unit u;//local unit u
			ForceAddPlayer(KA, p);//call ForceAddPlayer(KA,p)
			ne[dk] = null;//set ne[dk]=null
			while (true) {//loop
				if ((IsPlayerInForce(Player(i),mh) && ne[i]!=null)) {//if(IsPlayerInForce(Player(i),mh)and ne[i]!=null)then
					p = vn(KA);//set p=vn(KA)
					if (p==null) { break; }//exitwhen p==null
					ForceRemovePlayer(KA, p);//call ForceRemovePlayer(KA,p)
					ForceAddPlayer(ne[i], p);//call ForceAddPlayer(ne[i],p)
					SetPlayerName(p, l9[i]);//call SetPlayerName(p,l9[i])
					Ls(GetPlayerId(p));//call Ls(GetPlayerId(p))
					GroupEnumUnitsOfPlayer(q4, p, b9);//call GroupEnumUnitsOfPlayer(q4,p,b9)
					u = FirstOfGroup(q4);//set u=FirstOfGroup(q4)
					if ((u!=null && GetUnitAbilityLevel(u,1093681447)<=0)) {//if(u!=null and GetUnitAbilityLevel(u,'A0A5')<=0)then
						UnitAddAbility(u, 'A0A5');//call UnitAddAbility(u,'A0A5')
					}//endif
				}//endif
				i = i+1;//set i=i+1
				if ((i>$B)) {//if(i>$B)then
					i = 0;//set i=0
				}//endif
			}//endloop
			h8 = true;//set h8=true
			Ny();//call Ny()
			u = null;//set u=null
		}//endfunction
		private void LA(player p) {//function LA takes player p returns nothing
			int dk = GetPlayerId(p);//local integer dk=GetPlayerId(p)
			if ((T9)) {//if(T9)then
				return;//return
			}//endif
			DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" |cffCA0000has left the game!|r");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" |cffCA0000has left the game!|r")
			Zj(dk);//call Zj(dk)
			if ((IsPlayerInForce(p,ie))) {//if(IsPlayerInForce(p,ie))then
				Rk(("Loses"), (p), p7[('e')], I2S((1)), 'g');//call Rk(("Loses"),(p),p7[('e')],I2S((1)),'g')
				dm(p, 'h');//call dm(p,'h')
				mh = ie;//set mh=ie
				if ((xn()<=1)) {//if(xn()<=1)then
					mg = 1;//set mg=1
					T9 = true;//set T9=true
					DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 60., "All players of |cffFF0000Western Forces|r left. |cff00FF00Eastern Forces|r have won!");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,60.,"All players of |cffFF0000Western Forces|r left. |cff00FF00Eastern Forces|r have won!")
					TriggerExecute(hg);//call TriggerExecute(hg)
					return;//return
				}//endif
			} else if ((IsPlayerInForce(p,je))) {//elseif(IsPlayerInForce(p,je))then
				Rk(("Loses"), (p), p7[('e')], I2S((1)), 'g');//call Rk(("Loses"),(p),p7[('e')],I2S((1)),'g')
				dm(p, 'h');//call dm(p,'h')
				mh = je;//set mh=je
				if ((yn()<=1)) {//if(yn()<=1)then
					mg = 2;//set mg=2
					T9 = true;//set T9=true
					DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS, 60., "All players of |cff00FF00Eastern Forces|r left. |cffFF0000Western Forces|r have won!");//call DisplayTimedTextToForce(bj_FORCE_ALL_PLAYERS,60.,"All players of |cff00FF00Eastern Forces|r left. |cffFF0000Western Forces|r have won!")
					TriggerExecute(ig);//call TriggerExecute(ig)
					return;//return
				}//endif
			} else {//else
				return;//return
			}//endif
			if ((fd==0)) {//if(fd==0)then
				lA(dk);//call lA(dk)
			} else if ((fd==1)) {//elseif(fd==1)then
				JA(dk);//call JA(dk)
			} else {//else
				It(dk);//call It(dk)
			}//endif
		}//endfunction
		private void MA() {//function MA takes nothing returns nothing
			LA(GetTriggerPlayer());//call LA(GetTriggerPlayer())
		}//endfunction
		private void OA(int dk) {//function OA takes integer dk returns nothing
			Q[me[dk]+4] = Q[me[dk]+4]+1;//set Q[me[dk]+4]=Q[me[dk]+4]+1
			Yr(2, me[dk]+1, I2S(Q[me[dk]+4]));//call Yr(2,me[dk]+1,I2S(Q[me[dk]+4]))
			if ((Q[me[dk]]==dk)) {//if(Q[me[dk]]==dk)then
				Q[me[dk]+2] = Q[me[dk]+2]+1;//set Q[me[dk]+2]=Q[me[dk]+2]+1
				if ((Q[me[dk]+2]==3)) {//if(Q[me[dk]+2]==3)then
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+"|cffFFFF80 just collected |cffFFFF003|cffFFFF80 coins in a row for the "+Od[me[dk]]+"|cffFFFF00! Very nice!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+"|cffFFFF80 just collected |cffFFFF003|cffFFFF80 coins in a row for the "+Od[me[dk]]+"|cffFFFF00! Very nice!")
				} else if ((Q[me[dk]+2]==5)) {//elseif(Q[me[dk]+2]==5)then
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+"|cffFFFF80 just collected|cffFFFF00 5|cffFFFF80 coins in a row for the "+Od[me[dk]]+"|cffFFFF00! Impressive!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+"|cffFFFF80 just collected|cffFFFF00 5|cffFFFF80 coins in a row for the "+Od[me[dk]]+"|cffFFFF00! Impressive!")
				} else if ((Q[me[dk]+2]==$A)) {//elseif(Q[me[dk]+2]==$A)then
					DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+"|cffFFFF80 just collected|cffFFFF00 10|cffFFFF80 coins in a row for the "+Od[me[dk]]+"|cffFFFF00! Sick!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+"|cffFFFF80 just collected|cffFFFF00 10|cffFFFF80 coins in a row for the "+Od[me[dk]]+"|cffFFFF00! Sick!")
				}//endif
			} else {//else
				Q[me[dk]] = dk;//set Q[me[dk]]=dk
				Q[me[dk]+2] = 1;//set Q[me[dk]+2]=1
			}//endif
		}//endfunction
		private void PA() {//function PA takes nothing returns nothing
			int mk;//local integer mk
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			player p = GetOwningPlayer(u);//local player p=GetOwningPlayer(u)
			item it = GetManipulatedItem();//local item it=GetManipulatedItem()
			int bj = GetItemTypeId(it);//local integer bj=GetItemTypeId(it)
			if ((bj==808470823)) {//if(bj=='I004')then
				RemoveItem(it);//call RemoveItem(it)
				if ((rd)) {//if(rd)then
					mk = GetPlayerId(p);//set mk=GetPlayerId(p)
					fe[mk] = fe[mk]+($5DC);//set fe[mk]=fe[mk]+($5DC)
					AdjustPlayerStateBJ(1, p, PLAYER_STATE_RESOURCE_FOOD_CAP);//call AdjustPlayerStateBJ(1,p,PLAYER_STATE_RESOURCE_FOOD_CAP)
				} else {//else
					AdjustPlayerStateBJ($5DC, p, PLAYER_STATE_RESOURCE_GOLD);//call AdjustPlayerStateBJ($5DC,p,PLAYER_STATE_RESOURCE_GOLD)
					DisplayTextToPlayer(p, .0, .0, "|cffFF0000You can't increase your Legendaries limit! No Legendaries is activated!|r");//call DisplayTextToPlayer(p,.0,.0,"|cffFF0000You can't increase your Legendaries limit! No Legendaries is activated!|r")
				}//endif
			} else if ((bj==808470823)) {//elseif(bj=='I008')then
				mk = GetPlayerId(p);//set mk=GetPlayerId(p)
				fe[mk] = fe[mk]+(600);//set fe[mk]=fe[mk]+(600)
				u = CreateUnitAtLoc(p,808477991,R9,.0);//set u=CreateUnitAtLoc(p,'e008',R9,.0)
				UnitAddAbility(u, 'A06D');//call UnitAddAbility(u,'A06D')
				UnitApplyTimedLife(u, 'BTLF', 29.);//call UnitApplyTimedLife(u,'BTLF',29.)
			} else if ((bj==808470823)) {//elseif(bj=='I007')then
				mk = GetPlayerId(p);//set mk=GetPlayerId(p)
				fe[mk] = fe[mk]+($578);//set fe[mk]=fe[mk]+($578)
				u = CreateUnitAtLoc(p,808477991,R9,.0);//set u=CreateUnitAtLoc(p,'e008',R9,.0)
				UnitAddAbility(u, 'A06C');//call UnitAddAbility(u,'A06C')
				UnitApplyTimedLife(u, 'BTLF', 29.);//call UnitApplyTimedLife(u,'BTLF',29.)
			} else if ((bj==808470823)) {//elseif(bj=='I001')then
				mk = GetPlayerId(p);//set mk=GetPlayerId(p)
				fe[mk] = fe[mk]+($96);//set fe[mk]=fe[mk]+($96)
			} else if ((bj==808470823)) {//elseif(bj=='I005')then
				mk = GetPlayerId(p);//set mk=GetPlayerId(p)
				fe[mk] = fe[mk]+($96);//set fe[mk]=fe[mk]+($96)
			} else if ((bj==808470823)) {//elseif(bj=='I003')then
				mk = GetPlayerId(p);//set mk=GetPlayerId(p)
				fe[mk] = fe[mk]+(650);//set fe[mk]=fe[mk]+(650)
			} else if ((bj==808470823)) {//elseif(bj=='I00A')then
				mk = GetPlayerId(p);//set mk=GetPlayerId(p)
				fe[mk] = fe[mk]+(600);//set fe[mk]=fe[mk]+(600)
			} else if ((bj==808470823)) {//elseif(bj=='I009')then
				mk = GetPlayerId(p);//set mk=GetPlayerId(p)
				fe[mk] = fe[mk]+(500);//set fe[mk]=fe[mk]+(500)
			} else if ((bj==808470823)) {//elseif(bj=='I006')then
				mk = GetPlayerId(p);//set mk=GetPlayerId(p)
				fe[mk] = fe[mk]+(550);//set fe[mk]=fe[mk]+(550)
			} else if ((bj==808470823)) {//elseif(bj=='I000')then
				Yi(p);//call Yi(p)
				RemoveItem(it);//call RemoveItem(it)
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Other\\Transmute\\PileofGold.mdl", u, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Other\\Transmute\\PileofGold.mdl",u,"origin"))
				OA(GetPlayerId(p));//call OA(GetPlayerId(p))
			}//endif
			it = null;//set it=null
			u = null;//set u=null
		}//endfunction
		private bool RA() {//function RA takes nothing returns boolean
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			player p;//local player p
			if ((IsUnitType(u,UNIT_TYPE_PEON))) {//if(IsUnitType(u,UNIT_TYPE_PEON))then
				p = GetOwningPlayer(u);//set p=GetOwningPlayer(u)
				PingMinimapForPlayer(p, GetUnitX(u), GetUnitY(u), 1.);//call PingMinimapForPlayer(p,GetUnitX(u),GetUnitY(u),1.)
				SetUnitPositionLoc(u, Qd[GetPlayerId(p)]);//call SetUnitPositionLoc(u,Qd[GetPlayerId(p)])
				DisplayTextToPlayer(p, .0, .0, "|cffFF0000Your worker may not leave your castle!|r");//call DisplayTextToPlayer(p,.0,.0,"|cffFF0000Your worker may not leave your castle!|r")
			}//endif
			u = null;//set u=null
			return false;//return false
		}//endfunction
		private void TA() {//function TA takes nothing returns nothing
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			player p = GetOwningPlayer(u);//local player p=GetOwningPlayer(u)
			int HA = GetPlayerId(p);//local integer HA=GetPlayerId(p)
			int aj = GetUnitPointValue(u);//local integer aj=GetUnitPointValue(u)
			Hj(u);//call Hj(u)
			ee[HA] = ee[HA]+(t4[aj]);//set ee[HA]=ee[HA]+(t4[aj])
			if ((v4[aj])) {//if(v4[aj])then
				if ((w4[aj])) {//if(w4[aj])then
					cr(u, t4[aj]*3/ 4);//call cr(u,t4[aj]*3/ 4)
				} else {//else
					cr(u, t4[aj]);//call cr(u,t4[aj])
				}//endif
			} else {//else
				Ud[HA] = Ud[HA]+1;//set Ud[HA]=Ud[HA]+1
			}//endif
			Lv(HA, u);//call Lv(HA,u)
			GroupEnumUnitsOfPlayer(q4, p, b9);//call GroupEnumUnitsOfPlayer(q4,p,b9)
			ForGroup(q4, function Rr);//call ForGroup(q4,function Rr)
			HA = (x4[GetUnitPointValue((u))]);//set HA=(x4[GetUnitPointValue((u))])
			if ((HA>0)) {//if(HA>0)then
				if ((Gd[GetPlayerId(p)])) {//if(Gd[GetPlayerId(p)])then
					IssueImmediateOrderById(u, HA);//call IssueImmediateOrderById(u,HA)
					IssueImmediateOrderById(u, HA);//call IssueImmediateOrderById(u,HA)
				}//endif
			} else {//else
				aj = GetUnitTypeId(u);//set aj=GetUnitTypeId(u)
				if ((aj==808478759)) {//if(aj=='h001')then
					cv(u);//call cv(u)
					GroupAddUnit(ff, u);//call GroupAddUnit(ff,u)
				} else if ((aj==892364839)) {//elseif(aj=='h05G')then
					Fv(u);//call Fv(u)
				} else if ((aj==892364839)) {//elseif(aj=='h059')then
					sv(p);//call sv(p)
				} else if ((aj==909142055)) {//elseif(aj=='h063')then
					qo(p);//call qo(p)
				} else if ((aj==842033191)) {//elseif(aj=='h02D')then
					TimerStart(A7, 4., true, function qm);//call TimerStart(A7,4.,true,function qm)
				} else if ((aj==808478759)) {//elseif(aj=='h00G')then
					UnitAddAbility(u, 'A008');//call UnitAddAbility(u,'A008')
					UnitAddAbility(u, 'A007');//call UnitAddAbility(u,'A007')
				} else if ((aj==909142055)) {//elseif(aj=='h061')then
					oo(u);//call oo(u)
				} else if ((aj==892364839 || aj==858810407 || aj==825255975 || aj==825255975 || aj==892364839)) {//elseif(aj=='h056' or aj=='h03L' or aj=='h01W' or aj=='h01X' or aj=='h05R')then
					IssueImmediateOrderById(u, $D027A);//call IssueImmediateOrderById(u,$D027A)
					TriggerSleepAction(1.);//call TriggerSleepAction(1.)
					IssueImmediateOrderById(u, $D027A);//call IssueImmediateOrderById(u,$D027A)
					IssueTargetOrderById(u, $D0279, GroupPickRandomUnit(P9));//call IssueTargetOrderById(u,$D0279,GroupPickRandomUnit(P9))
					TriggerSleepAction(45.);//call TriggerSleepAction(45.)
					IssueTargetOrderById(u, $D0279, GroupPickRandomUnit(P9));//call IssueTargetOrderById(u,$D0279,GroupPickRandomUnit(P9))
				} else if ((aj==959473703)) {//elseif(aj=='h09T')then
					UnitAddAbility(u, 'A09S');//call UnitAddAbility(u,'A09S')
					UnitAddAbility(u, 'A09P');//call UnitAddAbility(u,'A09P')
					UnitAddAbility(u, 'A09V');//call UnitAddAbility(u,'A09V')
					GroupAddUnit(rf, u);//call GroupAddUnit(rf,u)
				} else if ((aj==825255975)) {//elseif(aj=='h01O')then
					UnitAddAbility(u, 'A01V');//call UnitAddAbility(u,'A01V')
				} else if ((aj==808478759)) {//elseif(aj=='h008')then
					aj = GetPlayerId(p);//set aj=GetPlayerId(p)
					ge[aj] = ge[aj]+1;//set ge[aj]=ge[aj]+1
				}//endif
			}//endif
			if ((yd)) {//if(yd)then
				Pj("BE: "+GetPlayerName(p)+" ->"+GetUnitName(u));//call Pj("BE: "+GetPlayerName(p)+" ->"+GetUnitName(u))
				Rj();//call Rj()
			}//endif
			u = null;//set u=null
		}//endfunction
		private void VA() {//function VA takes nothing returns nothing
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			cj(u);//call cj(u)
			u = null;//set u=null
		}//endfunction
		private void XA() {//function XA takes nothing returns nothing
			Hj(GetTriggerUnit());//call Hj(GetTriggerUnit())
		}//endfunction
		private bool ZA() {//function ZA takes nothing returns boolean
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			int dk;//local integer dk
			if (((x4[GetUnitPointValue((u))])>0)) {//if((x4[GetUnitPointValue((u))])>0)then
				dk = GetPlayerId(GetOwningPlayer(u));//set dk=GetPlayerId(GetOwningPlayer(u))
				Td[dk] = Td[dk]+1;//set Td[dk]=Td[dk]+1
				if ((GetUnitAbilityLevel(u,1144013095)>0)) {//if(GetUnitAbilityLevel(u,'A0DS')>0)then
					Gn(u);//call Gn(u)
				}//endif
			}//endif
			u = null;//set u=null
			return false;//return false
		}//endfunction
		private bool ea() {//function ea takes nothing returns boolean
			unit u = GetFilterUnit();//local unit u=GetFilterUnit()
			if ((GetWidgetLife(u)>.405 && IsUnitAlly(u,r4) && IsUnitType(u,UNIT_TYPE_SAPPER))) {//if(GetWidgetLife(u)>.405 and IsUnitAlly(u,r4)and IsUnitType(u,UNIT_TYPE_SAPPER))then
				if ((GetUnitTypeId(u)==bj_forLoopAIndex)) {//if(GetUnitTypeId(u)==bj_forLoopAIndex)then
					SetWidgetLife(u, GetWidgetLife(u)+bj_forLoopAIndexEnd);//call SetWidgetLife(u,GetWidgetLife(u)+bj_forLoopAIndexEnd)
				} else {//else
					SetWidgetLife(u, GetWidgetLife(u)+.3*bj_forLoopAIndexEnd);//call SetWidgetLife(u,GetWidgetLife(u)+.3*bj_forLoopAIndexEnd)
				}//endif
				DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Heal\\HealTarget.mdl", u, "overhead"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Heal\\HealTarget.mdl",u,"overhead"))
			}//endif
			u = null;//set u=null
			return false;//return false
		}//endfunction
		private void fa() {//function fa takes nothing returns nothing
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			unit k = GetKillingUnit();//local unit k=GetKillingUnit()
			int t;//local integer t
			if ((IsUnitType(u,UNIT_TYPE_SAPPER))) {//if(IsUnitType(u,UNIT_TYPE_SAPPER))then
				if ((GetUnitAbilityLevel(u,925909287)>=1)) {//if(GetUnitAbilityLevel(u,'A07M')>=1)then
					GroupRemoveUnit(z9, u);//call GroupRemoveUnit(z9,u)
					M8[GetUnitUserData((u))] = false;//set M8[GetUnitUserData((u))]=false
				} else if ((GetUnitTypeId(u)==909142055)) {//elseif(GetUnitTypeId(u)=='h06B')then
					Qw(u);//call Qw(u)
				}//endif
				if ((k!=null)) {//if(k!=null)then
					if ((!IsUnitType(k,UNIT_TYPE_STRUCTURE))) {//if(not IsUnitType(k,UNIT_TYPE_STRUCTURE))then
						t = GetPlayerId(GetOwningPlayer(k));//set t=GetPlayerId(GetOwningPlayer(k))
						Sd[t] = Sd[t]+1;//set Sd[t]=Sd[t]+1
						if ((GetUnitTypeId(u)==808477991)) {//if(GetUnitTypeId(u)=='e00A')then
							UnitDamageTarget(u, k, 350., true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_NORMAL, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(u,k,350.,true,false,ATTACK_TYPE_CHAOS,DAMAGE_TYPE_NORMAL,WEAPON_TYPE_WHOKNOWS)
						}//endif
						t = GetUnitTypeId(k);//set t=GetUnitTypeId(k)
						if ((t==808480295 || t==825257511)) {//if(t=='n00V' or t=='n01O')then
							IssueImmediateOrderById(k, $D0084);//call IssueImmediateOrderById(k,$D0084)
							Po(k);//call Po(k)
						} else if ((t==808477991)) {//elseif(t=='e00B')then
							SetUnitLifePercentBJ(k, GetUnitLifePercent(k)+14.);//call SetUnitLifePercentBJ(k,GetUnitLifePercent(k)+14.)
						} else if ((t==808477991)) {//elseif(t=='e00A')then
							SetUnitLifePercentBJ(k, GetUnitLifePercent(k)+20.);//call SetUnitLifePercentBJ(k,GetUnitLifePercent(k)+20.)
						} else if ((t==825255975 && GetUnitAbilityLevel(u,942686503)<=0  && (!IsUnitType(u,UNIT_TYPE_MECHANICAL)) && (!IsUnitType(u,UNIT_TYPE_UNDEAD)))) {//elseif(t=='h01U' and GetUnitAbilityLevel(u,'A08H')<=0 and(not IsUnitType(u,UNIT_TYPE_MECHANICAL))and(not IsUnitType(u,UNIT_TYPE_UNDEAD)))then
							hy(k, u, 'h01V');//call hy(k,u,'h01V')
							u = null;//set u=null
						} else if ((t==892364839 && GetUnitAbilityLevel(u,942686503)<=0  && (!IsUnitType(u,UNIT_TYPE_MECHANICAL)) && (!IsUnitType(u,UNIT_TYPE_UNDEAD)))) {//elseif(t=='h05H' and GetUnitAbilityLevel(u,'A08H')<=0 and(not IsUnitType(u,UNIT_TYPE_MECHANICAL))and(not IsUnitType(u,UNIT_TYPE_UNDEAD)))then
							hy(k, u, 'h01U');//call hy(k,u,'h01U')
							u = null;//set u=null
						} else if ((GetUnitAbilityLevel(u,925909287)>=1)) {//elseif(GetUnitAbilityLevel(u,'A07M')>=1)then
							Lo(u);//call Lo(u)
						}//endif
					}//endif
					if ((GetUnitAbilityLevel(u,925909287)<=0 && GetUnitAbilityLevel(u,925909287)<=0 && !IsUnitType(u,UNIT_TYPE_SUMMONED))) {//if(GetUnitAbilityLevel(u,'A07G')<=0 and GetUnitAbilityLevel(u,'A07H')<=0 and not IsUnitType(u,UNIT_TYPE_SUMMONED))then
						t = me[GetPlayerId(GetOwningPlayer(u))];//set t=me[GetPlayerId(GetOwningPlayer(u))]
						if ((Kd[t]>0 && GetUnitAbilityLevel(u,1177567527)>0)) {//if(Kd[t]>0 and GetUnitAbilityLevel(u,'A0F5')>0)then
							r4 = GetOwningPlayer(u);//set r4=GetOwningPlayer(u)
							bj_forLoopAIndexEnd = IMinBJ(20*Fn(GetPlayerId(r4)),500);//set bj_forLoopAIndexEnd=IMinBJ(20*Fn(GetPlayerId(r4)),500)
							GroupEnumUnitsInRange(q4, GetUnitX(u), GetUnitY(u), 512., oh);//call GroupEnumUnitsInRange(q4,GetUnitX(u),GetUnitY(u),512.,oh)
						}//endif
						if ((ld[t]>0)) {//if(ld[t]>0)then
							TriggerSleepAction(2.);//call TriggerSleepAction(2.)
							if ((u!=null && GetWidgetLife(u)<.405 && GetRandomInt(0,99)<IMinBJ(ld[t],40))) {//if(u!=null and GetWidgetLife(u)<.405 and GetRandomInt(0,99)<IMinBJ(ld[t],40))then
								k = CreateUnit(GetOwningPlayer(u),GetUnitTypeId(u),GetUnitX(u),GetUnitY(u),.0);//set k=CreateUnit(GetOwningPlayer(u),GetUnitTypeId(u),GetUnitX(u),GetUnitY(u),.0)
								RemoveUnit(u);//call RemoveUnit(u)
								DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Resurrect\\ResurrectCaster.mdl", k, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\Resurrect\\ResurrectCaster.mdl",k,"origin"))
								if ((GetUnitAbilityLevel(k,925909287)>=1)) {//if(GetUnitAbilityLevel(k,'A07M')>=1)then
									Mo(k);//call Mo(k)
									GroupAddUnit(z9, k);//call GroupAddUnit(z9,k)
								}//endif
							}//endif
						}//endif
					}//endif
				}//endif
			} else if ((IsUnitType(u,UNIT_TYPE_STRUCTURE))) {//elseif(IsUnitType(u,UNIT_TYPE_STRUCTURE))then
				cj(u);//call cj(u)
				Mv(GetPlayerId(GetOwningPlayer(u)), u);//call Mv(GetPlayerId(GetOwningPlayer(u)),u)
				if ((GetUnitAbilityLevel(u,1160790311)>0)) {//if(GetUnitAbilityLevel(u,'A0EL')>0)then
					Mn(u);//call Mn(u)
				}//endif
				t = GetUnitTypeId(u);//set t=GetUnitTypeId(u)
				if ((t==892364839)) {//if(t=='h05G')then
					Gv(u);//call Gv(u)
				} else if ((t==892364839)) {//elseif(t=='h059')then
					tv(u);//call tv(u)
				} else if ((t==909142055)) {//elseif(t=='h063')then
					ro(u);//call ro(u)
				} else if ((t==808478759)) {//elseif(t=='h008')then
					t = GetPlayerId(GetOwningPlayer(u));//set t=GetPlayerId(GetOwningPlayer(u))
					ge[t] = ge[t]-1;//set ge[t]=ge[t]-1
				} else if ((GetUnitAbilityLevel(u,1144013095)>0)) {//elseif(GetUnitAbilityLevel(u,'A0DS')>0)then
					In(u);//call In(u)
				} else if ((t==909142055)) {//elseif(t=='h061')then
					po(u);//call po(u)
				}//endif
				FlushChildHashtable(O9, GetHandleId(u));//call FlushChildHashtable(O9,GetHandleId(u))
				GroupRemoveUnit(ff, u);//call GroupRemoveUnit(ff,u)
				GroupRemoveUnit(rf, u);//call GroupRemoveUnit(rf,u)
				u = GetKillingUnit();//set u=GetKillingUnit()
				if ((u!=null && nh)) {//if(u!=null and nh)then
					t = me[GetPlayerId(GetOwningPlayer(u))];//set t=me[GetPlayerId(GetOwningPlayer(u))]
					Nd[t] = Nd[t]+1;//set Nd[t]=Nd[t]+1
					Yr(3, t+1, I2S(Nd[t]));//call Yr(3,t+1,I2S(Nd[t]))
				}//endif
			}//endif
			k = null;//set k=null
			u = null;//set u=null
		}//endfunction
		private void ha(unit u, float tx, float ty) {//function ha takes unit u,real tx,real ty returns nothing
			player p = GetOwningPlayer(u);//local player p=GetOwningPlayer(u)
			unit c = CreateUnit(p,875587623,tx,ty,.0);//local unit c=CreateUnit(p,'h04X',tx,ty,.0)
			group g = CreateGroup();//local group g=CreateGroup()
			float mj = .0;//local real mj=.0
			int Dj = 0;//local integer Dj=0
			unit j;//local unit j
			bool ia;//local boolean ia
			int dk;//local integer dk
			SetUnitVertexColor(c, 0, 0, 0, 0);//call SetUnitVertexColor(c,0,0,0,0)
			UnitRemoveAbility(u, 'A005');//call UnitRemoveAbility(u,'A005')
			UnitRemoveAbility(u, 'A06E');//call UnitRemoveAbility(u,'A06E')
			DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl", u, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Items\\TomeOfRetraining\\TomeOfRetrainingCaster.mdl",u,"origin"))
			DestroyEffect(AddSpecialEffectTarget("Units\\NightElf\\Wisp\\WispExplode.mdl", c, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Units\\NightElf\\Wisp\\WispExplode.mdl",c,"origin"))
			DestroyEffect(AddSpecialEffectTarget("Units\\NightElf\\Wisp\\WispExplode.mdl", c, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Units\\NightElf\\Wisp\\WispExplode.mdl",c,"origin"))
			DestroyEffect(AddSpecialEffectTarget("Units\\NightElf\\Wisp\\WispExplode.mdl", c, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Units\\NightElf\\Wisp\\WispExplode.mdl",c,"origin"))
			TriggerSleepAction(.35);//call TriggerSleepAction(.35)
			r4 = p;//set r4=p
			GroupEnumUnitsInRange(g, tx, ty, 700., null);//call GroupEnumUnitsInRange(g,tx,ty,700.,null)
			ia = zd;//set ia=zd
			zd = false;//set zd=false
			while (true) {//loop
				j = FirstOfGroup(g);//set j=FirstOfGroup(g)
				if (j==null) { break; }//exitwhen j==null
				GroupRemoveUnit(g, j);//call GroupRemoveUnit(g,j)
				if ((IsUnitEnemy(j,p) && GetWidgetLife(j)>.405 && GetUnitAbilityLevel(j,1970684199)<=0)) {//if(IsUnitEnemy(j,p)and GetWidgetLife(j)>.405 and GetUnitAbilityLevel(j,'Avul')<=0)then
					Dj = Dj+1;//set Dj=Dj+1
					mj = mj+(GetWidgetLife(j));//set mj=mj+(GetWidgetLife(j))
					UnitDamageTarget(u, j, 4444., true, false, ATTACK_TYPE_CHAOS, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(u,j,4444.,true,false,ATTACK_TYPE_CHAOS,DAMAGE_TYPE_DEATH,WEAPON_TYPE_WHOKNOWS)
					UnitDamageTarget(u, j, 4444., true, false, ATTACK_TYPE_MAGIC, DAMAGE_TYPE_DEATH, WEAPON_TYPE_WHOKNOWS);//call UnitDamageTarget(u,j,4444.,true,false,ATTACK_TYPE_MAGIC,DAMAGE_TYPE_DEATH,WEAPON_TYPE_WHOKNOWS)
				}//endif
			}//endloop
			DestroyGroup(g);//call DestroyGroup(g)
			g = null;//set g=null
			IssueImmediateOrderById(c, $D022E);//call IssueImmediateOrderById(c,$D022E)
			zd = ia;//set zd=ia
			TriggerSleepAction(1.5);//call TriggerSleepAction(1.5)
			RemoveUnit(c);//call RemoveUnit(c)
			c = null;//set c=null
			dk = GetPlayerId(p);//set dk=GetPlayerId(p)
			Wd[dk] = R2I(mj);//set Wd[dk]=R2I(mj)
			Xd[dk] = Dj;//set Xd[dk]=Dj
			Md[me[dk]] = Md[me[dk]]-1;//set Md[me[dk]]=Md[me[dk]]-1
			if ((Md[me[dk]]==0)) {//if(Md[me[dk]]==0)then
				Yr(1, me[dk]+1, "|cffFF00000|r");//call Yr(1,me[dk]+1,"|cffFF00000|r")
			} else {//else
				Yr(1, me[dk]+1, I2S(Md[me[dk]]));//call Yr(1,me[dk]+1,I2S(Md[me[dk]]))
			}//endif
			Zr(H9[dk], me[dk]*6+1, " ");//call Zr(H9[dk],me[dk]*6+1," ")
			if ((Dj==0)) {//if(Dj==0)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" wasted his Rescue Strike, killing no unit! Epic Fail!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" wasted his Rescue Strike, killing no unit! Epic Fail!")
			} else if ((Dj==1)) {//elseif(Dj==1)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" wasted his Rescue Strike, killing only one unit!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" wasted his Rescue Strike, killing only one unit!")
			} else if ((Dj<5)) {//elseif(Dj<5)then
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" wasted his Rescue Strike, dealing only |cffFFFF00"+I2S(Wd[dk])+"|r damage and killing only |cffFFFF00"+I2S(Dj)+"|r units!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" wasted his Rescue Strike, dealing only |cffFFFF00"+I2S(Wd[dk])+"|r damage and killing only |cffFFFF00"+I2S(Dj)+"|r units!")
			} else {//else
				DisplayTextToForce(bj_FORCE_ALL_PLAYERS, pe[dk]+" dealt |cffFFFF00"+I2S(Wd[dk])+"|r damage with his Rescue Strike, killing |cffFFFF00"+I2S(Dj)+"|r units!");//call DisplayTextToForce(bj_FORCE_ALL_PLAYERS,pe[dk]+" dealt |cffFFFF00"+I2S(Wd[dk])+"|r damage with his Rescue Strike, killing |cffFFFF00"+I2S(Dj)+"|r units!")
			}//endif
		}//endfunction
		private void ja(unit u, float tx, float ty) {//function ja takes unit u,real tx,real ty returns nothing
			unit c = CreateUnit(GetOwningPlayer(u),808477991,tx,ty,.0);//local unit c=CreateUnit(GetOwningPlayer(u),'e008',tx,ty,.0)
			UnitAddAbility(c, 'A02G');//call UnitAddAbility(c,'A02G')
			IssueImmediateOrderById(c, $D012D);//call IssueImmediateOrderById(c,$D012D)
			UnitApplyTimedLife(c, 'BTLF', 1.);//call UnitApplyTimedLife(c,'BTLF',1.)
			c = null;//set c=null
		}//endfunction
		private void ka(unit u, int ma) {//function ka takes unit u,integer ma returns nothing
			player p = GetOwningPlayer(u);//local player p=GetOwningPlayer(u)
			if ((ma==0)) {//if(ma==0)then
				ma = 808470823;//set ma='I008'
			} else if ((ma==1)) {//elseif(ma==1)then
				ma = 808470823;//set ma='I007'
			} else if ((ma==2)) {//elseif(ma==2)then
				ma = 808470823;//set ma='I006'
			} else if ((ma==3)) {//elseif(ma==3)then
				ma = 808470823;//set ma='I003'
			} else if ((ma==4)) {//elseif(ma==4)then
				ma = 808470823;//set ma='I004'
			} else if ((ma==5)) {//elseif(ma==5)then
				ma = 808470823;//set ma='I005'
			} else if ((ma==6)) {//elseif(ma==6)then
				ma = 808470823;//set ma='I00A'
			} else if ((ma==7)) {//elseif(ma==7)then
				ma = 808470823;//set ma='I001'
			} else if ((ma==8)) {//elseif(ma==8)then
				ma = 808470823;//set ma='I009'
			}//endif
			IssueNeutralImmediateOrderById(p, oe[me[GetPlayerId(p)]], ma);//call IssueNeutralImmediateOrderById(p,oe[me[GetPlayerId(p)]],ma)
		}//endfunction
		private void na() {//function na takes nothing returns nothing
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			int oa = GetSpellAbilityId();//local integer oa=GetSpellAbilityId()
			if ((IsUnitType(u,UNIT_TYPE_STRUCTURE))) {//if(IsUnitType(u,UNIT_TYPE_STRUCTURE))then
				if ((oa==959463719)) {//if(oa=='A09A')then
					Ar(u, (A4[GetUnitPointValue((u))]));//call Ar(u,(A4[GetUnitPointValue((u))]))
				} else if ((oa==1160790311)) {//elseif(oa=='A0EK')then
					Jn(u, GetSpellTargetUnit());//call Jn(u,GetSpellTargetUnit())
				} else {//else
					Kj(u);//call Kj(u)
				}//endif
			} else if ((oa==808468775)) {//elseif(oa=='A005')then
				ha(u, GetSpellTargetX(), GetSpellTargetY());//call ha(u,GetSpellTargetX(),GetSpellTargetY())
			} else if ((oa==942686503)) {//elseif(oa=='A08Y')then
				ja(u, GetSpellTargetX(), GetSpellTargetY());//call ja(u,GetSpellTargetX(),GetSpellTargetY())
			} else if ((oa>=1094863143 && oa<=1094863143)) {//elseif(oa>='IBA0' and oa<='IBA8')then
				ka(u, oa-'IBA0');//call ka(u,oa-'IBA0')
			} else {//else
				Nj(u, oa, GetSpellTargetUnit());//call Nj(u,oa,GetSpellTargetUnit())
			}//endif
			u = null;//set u=null
		}//endfunction
		private void qa() {//function qa takes nothing returns nothing
			unit u = GetTrainedUnit();//local unit u=GetTrainedUnit()
			unit j = GetTriggerUnit();//local unit j=GetTriggerUnit()
			int bj = GetTrainedUnitType();//local integer bj=GetTrainedUnitType()
			if ((GetUnitAbilityLevel(u,925909287)>0)) {//if(GetUnitAbilityLevel(u,'A07J')>0)then
				u = Su(u);//set u=Su(u)
			} else if ((GetUnitTypeId(u)==909142055)) {//elseif(GetUnitTypeId(u)=='h06U')then
				SetUnitState(u, UNIT_STATE_MANA, GetRandomReal(.0, 50.));//call SetUnitState(u,UNIT_STATE_MANA,GetRandomReal(.0,50.))
			}//endif
			Wr(u, j);//call Wr(u,j)
			u = null;//set u=null
			if ((Gd[GetPlayerId(GetOwningPlayer(j))])) {//if(Gd[GetPlayerId(GetOwningPlayer(j))])then
				TriggerSleepAction(.1);//call TriggerSleepAction(.1)
				IssueImmediateOrderById(j, bj);//call IssueImmediateOrderById(j,bj)
			}//endif
			j = null;//set j=null
		}//endfunction
		private bool sa() {//function sa takes nothing returns boolean
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			int aj;//local integer aj
			if ((IsUnitType(u,UNIT_TYPE_SAPPER))) {//if(IsUnitType(u,UNIT_TYPE_SAPPER))then
				TriggerRegisterUnitEvent(Nf, u, EVENT_UNIT_DAMAGED);//call TriggerRegisterUnitEvent(Nf,u,EVENT_UNIT_DAMAGED)
				aj = GetUnitTypeId(u);//set aj=GetUnitTypeId(u)
				if ((aj==825257511)) {//if(aj=='n01B')then
					SetUnitVertexColor(u, 82, 0, $87, 'f');//call SetUnitVertexColor(u,82,0,$87,'f')
				} else if ((aj==808477991)) {//elseif(aj=='e00F')then
					u = null;//set u=null
					return true;//return true
				} else if ((GetUnitAbilityLevel(u,1160790311)>0)) {//elseif(GetUnitAbilityLevel(u,'A0E5')>0)then
					SetUnitVertexColor(u, $FF, $FF, $FF, $FF-60*GetUnitLevel(u));//call SetUnitVertexColor(u,$FF,$FF,$FF,$FF-60*GetUnitLevel(u))
				}//endif
				Qo(u);//call Qo(u)
			}//endif
			u = null;//set u=null
			return false;//return false
		}//endfunction
		private void ta() {//function ta takes nothing returns nothing
			hx(GetTriggerUnit());//call hx(GetTriggerUnit())
		}//endfunction
		private void va() {//function va takes nothing returns nothing
			unit u = GetTriggerUnit();//local unit u=GetTriggerUnit()
			if ((IsUnitType(GetTriggerUnit(),UNIT_TYPE_SAPPER) && !IsUnitType(GetTriggerUnit(),UNIT_TYPE_STRUCTURE))) {//if(IsUnitType(GetTriggerUnit(),UNIT_TYPE_SAPPER)and not IsUnitType(GetTriggerUnit(),UNIT_TYPE_STRUCTURE))then
				if ((GetUnitAbilityLevel(u,925909287)>0)) {//if(GetUnitAbilityLevel(u,'A07H')>0)then
					DisableTrigger(kh);//call DisableTrigger(kh)
					SetUnitOwner(u, GetChangingUnitPrevOwner(), true);//call SetUnitOwner(u,GetChangingUnitPrevOwner(),true)
					EnableTrigger(kh);//call EnableTrigger(kh)
					DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl", u, "origin"));//call DestroyEffect(AddSpecialEffectTarget("Abilities\\Spells\\Human\\DispelMagic\\DispelMagicTarget.mdl",u,"origin"))
				} else if ((GetUnitTypeId(GetTriggerUnit())==858810407)) {//elseif(GetUnitTypeId(GetTriggerUnit())=='h03A')then
					TriggerSleepAction(.1);//call TriggerSleepAction(.1)
					IssueImmediateOrderById(u, $D0057);//call IssueImmediateOrderById(u,$D0057)
					TriggerSleepAction(.1);//call TriggerSleepAction(.1)
				}//endif
			}//endif
			Qo(u);//call Qo(u)
			u = null;//set u=null
		}//endfunction
		private void InitCustomTeams() {//function InitCustomTeams takes nothing returns nothing
			SetPlayerTeam(Player(0), 0);//call SetPlayerTeam(Player(0),0)
			SetPlayerState(Player(0), PLAYER_STATE_ALLIED_VICTORY, 1);//call SetPlayerState(Player(0),PLAYER_STATE_ALLIED_VICTORY,1)
			SetPlayerTeam(Player(1), 0);//call SetPlayerTeam(Player(1),0)
			SetPlayerState(Player(1), PLAYER_STATE_ALLIED_VICTORY, 1);//call SetPlayerState(Player(1),PLAYER_STATE_ALLIED_VICTORY,1)
			SetPlayerAllianceStateAllyBJ(Player(0), Player(1), true);//call SetPlayerAllianceStateAllyBJ(Player(0),Player(1),true)
			SetPlayerAllianceStateAllyBJ(Player(1), Player(0), true);//call SetPlayerAllianceStateAllyBJ(Player(1),Player(0),true)
			SetPlayerAllianceStateVisionBJ(Player(0), Player(1), true);//call SetPlayerAllianceStateVisionBJ(Player(0),Player(1),true)
			SetPlayerAllianceStateVisionBJ(Player(1), Player(0), true);//call SetPlayerAllianceStateVisionBJ(Player(1),Player(0),true)
			SetPlayerTeam(Player(6), 1);//call SetPlayerTeam(Player(6),1)
			SetPlayerState(Player(6), PLAYER_STATE_ALLIED_VICTORY, 1);//call SetPlayerState(Player(6),PLAYER_STATE_ALLIED_VICTORY,1)
			SetPlayerTeam(Player(7), 1);//call SetPlayerTeam(Player(7),1)
			SetPlayerState(Player(7), PLAYER_STATE_ALLIED_VICTORY, 1);//call SetPlayerState(Player(7),PLAYER_STATE_ALLIED_VICTORY,1)
			SetPlayerAllianceStateAllyBJ(Player(6), Player(7), true);//call SetPlayerAllianceStateAllyBJ(Player(6),Player(7),true)
			SetPlayerAllianceStateAllyBJ(Player(7), Player(6), true);//call SetPlayerAllianceStateAllyBJ(Player(7),Player(6),true)
			SetPlayerAllianceStateVisionBJ(Player(6), Player(7), true);//call SetPlayerAllianceStateVisionBJ(Player(6),Player(7),true)
			SetPlayerAllianceStateVisionBJ(Player(7), Player(6), true);//call SetPlayerAllianceStateVisionBJ(Player(7),Player(6),true)
		}//endfunction
		private void main() {//function main takes nothing returns nothing
			weathereffect we;//local weathereffect we
			SetCameraBounds(-5632.+GetCameraMargin(CAMERA_MARGIN_LEFT), -3584.+GetCameraMargin(CAMERA_MARGIN_BOTTOM), 5632.-GetCameraMargin(CAMERA_MARGIN_RIGHT), 3584.-GetCameraMargin(CAMERA_MARGIN_TOP), -5632.+GetCameraMargin(CAMERA_MARGIN_LEFT), 3584.-GetCameraMargin(CAMERA_MARGIN_TOP), 5632.-GetCameraMargin(CAMERA_MARGIN_RIGHT), -3584.+GetCameraMargin(CAMERA_MARGIN_BOTTOM));//call SetCameraBounds(-5632.+GetCameraMargin(CAMERA_MARGIN_LEFT),-3584.+GetCameraMargin(CAMERA_MARGIN_BOTTOM),5632.-GetCameraMargin(CAMERA_MARGIN_RIGHT),3584.-GetCameraMargin(CAMERA_MARGIN_TOP),-5632.+GetCameraMargin(CAMERA_MARGIN_LEFT),3584.-GetCameraMargin(CAMERA_MARGIN_TOP),5632.-GetCameraMargin(CAMERA_MARGIN_RIGHT),-3584.+GetCameraMargin(CAMERA_MARGIN_BOTTOM))
			SetDayNightModels("Environment\\DNC\\DNCAshenvale\\DNCAshenvaleTerrain\\DNCAshenvaleTerrain.mdl", "Environment\\DNC\\DNCAshenvale\\DNCAshenvaleUnit\\DNCAshenvaleUnit.mdl");//call SetDayNightModels("Environment\\DNC\\DNCAshenvale\\DNCAshenvaleTerrain\\DNCAshenvaleTerrain.mdl","Environment\\DNC\\DNCAshenvale\\DNCAshenvaleUnit\\DNCAshenvaleUnit.mdl")
			NewSoundEnvironment("Default");//call NewSoundEnvironment("Default")
			SetAmbientDaySound("AshenvaleDay");//call SetAmbientDaySound("AshenvaleDay")
			SetAmbientNightSound("AshenvaleNight");//call SetAmbientNightSound("AshenvaleNight")
			SetMapMusic("Music", true, 0);//call SetMapMusic("Music",true,0)
			Gg = CreateSound("Sound\\Ambient\\DoodadEffects\\TheHornOfCenarius.wav",false,false,false,$A,$A,"DefaultEAXON");//set Gg=CreateSound("Sound\\Ambient\\DoodadEffects\\TheHornOfCenarius.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Gg, "HornOfCenariusSound");//call SetSoundParamsFromLabel(Gg,"HornOfCenariusSound")
			SetSoundDuration(Gg, $2F59);//call SetSoundDuration(Gg,$2F59)
			Hg = CreateSound("Sound\\Interface\\CreepAggroWhat1.wav",false,false,false,$A,$A,"DefaultEAXON");//set Hg=CreateSound("Sound\\Interface\\CreepAggroWhat1.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Hg, "CreepAggro");//call SetSoundParamsFromLabel(Hg,"CreepAggro")
			SetSoundDuration(Hg, $4D4);//call SetSoundDuration(Hg,$4D4)
			Ig = CreateSound("Units\\Demon\\HeroPitLord\\HPitLordYesAttack2.wav",false,false,false,$A,$A,"HeroAcksEAX");//set Ig=CreateSound("Units\\Demon\\HeroPitLord\\HPitLordYesAttack2.wav",false,false,false,$A,$A,"HeroAcksEAX")
			SetSoundParamsFromLabel(Ig, "HeroPitLordYesAttack");//call SetSoundParamsFromLabel(Ig,"HeroPitLordYesAttack")
			SetSoundDuration(Ig, $9C7);//call SetSoundDuration(Ig,$9C7)
			lg = CreateSound("Units\\NightElf\\Wisp\\WispPissed3.wav",false,false,false,$A,$A,"DefaultEAXON");//set lg=CreateSound("Units\\NightElf\\Wisp\\WispPissed3.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(lg, "WispPissed");//call SetSoundParamsFromLabel(lg,"WispPissed")
			SetSoundDuration(lg, $A7A);//call SetSoundDuration(lg,$A7A)
			Jg = CreateSound("Units\\Critters\\BloodElfPeasant\\BloodElfEngineerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON");//set Jg=CreateSound("Units\\Critters\\BloodElfPeasant\\BloodElfEngineerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Jg, "BloodElfEngineerWarcry");//call SetSoundParamsFromLabel(Jg,"BloodElfEngineerWarcry")
			SetSoundDuration(Jg, $44E);//call SetSoundDuration(Jg,$44E)
			Kg = CreateSound("Units\\Human\\Peasant\\PeasantReady1.wav",false,false,false,$A,$A,"DefaultEAXON");//set Kg=CreateSound("Units\\Human\\Peasant\\PeasantReady1.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Kg, "PeasantReady");//call SetSoundParamsFromLabel(Kg,"PeasantReady")
			SetSoundDuration(Kg, 892);//call SetSoundDuration(Kg,892)
			Lg = CreateSound("Units\\Creeps\\HeroTinker\\HeroTinkerReady1.wav",false,false,false,$A,$A,"HeroAcksEAX");//set Lg=CreateSound("Units\\Creeps\\HeroTinker\\HeroTinkerReady1.wav",false,false,false,$A,$A,"HeroAcksEAX")
			SetSoundParamsFromLabel(Lg, "HeroTinkerReady");//call SetSoundParamsFromLabel(Lg,"HeroTinkerReady")
			SetSoundDuration(Lg, $AF3);//call SetSoundDuration(Lg,$AF3)
			Mg = CreateSound("Units\\Creeps\\Murloc\\MurlocPissed2.wav",false,false,false,$A,$A,"DefaultEAXON");//set Mg=CreateSound("Units\\Creeps\\Murloc\\MurlocPissed2.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Mg, "MurlocPissed");//call SetSoundParamsFromLabel(Mg,"MurlocPissed")
			SetSoundDuration(Mg, 853);//call SetSoundDuration(Mg,853)
			Ng = CreateSound("Units\\NightElf\\Ent\\EntReady1.wav",false,false,false,$A,$A,"DefaultEAXON");//set Ng=CreateSound("Units\\NightElf\\Ent\\EntReady1.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Ng, "EntReady");//call SetSoundParamsFromLabel(Ng,"EntReady")
			SetSoundDuration(Ng, $912);//call SetSoundDuration(Ng,$912)
			SetSoundChannel(Ng, 1);//call SetSoundChannel(Ng,1)
			Og = CreateSound("Units\\NightElf\\Runner\\RunnerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON");//set Og=CreateSound("Units\\NightElf\\Runner\\RunnerWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Og, "RunnerWarcry");//call SetSoundParamsFromLabel(Og,"RunnerWarcry")
			SetSoundDuration(Og, $478);//call SetSoundDuration(Og,$478)
			Pg = CreateSound("Units\\Creeps\\Bandit\\BanditWhat1.wav",false,false,false,$A,$A,"DefaultEAXON");//set Pg=CreateSound("Units\\Creeps\\Bandit\\BanditWhat1.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Pg, "BanditWhat");//call SetSoundParamsFromLabel(Pg,"BanditWhat")
			SetSoundDuration(Pg, 520);//call SetSoundDuration(Pg,520)
			Qg = CreateSound("Units\\Orc\\Peon\\PeonReady1.wav",false,false,false,$A,$A,"DefaultEAXON");//set Qg=CreateSound("Units\\Orc\\Peon\\PeonReady1.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Qg, "PeonReady");//call SetSoundParamsFromLabel(Qg,"PeonReady")
			SetSoundDuration(Qg, $6BC);//call SetSoundDuration(Qg,$6BC)
			SetSoundChannel(Qg, 1);//call SetSoundChannel(Qg,1)
			Rg = CreateSound("Units\\Undead\\Acolyte\\AcolyteWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON");//set Rg=CreateSound("Units\\Undead\\Acolyte\\AcolyteWarcry1.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Rg, "AcolyteWarcry");//call SetSoundParamsFromLabel(Rg,"AcolyteWarcry")
			SetSoundDuration(Rg, $72D);//call SetSoundDuration(Rg,$72D)
			Sg = CreateSound("Units\\Demon\\Pitlord\\PitLordYesAttack1.wav",false,false,true,$A,$A,"DefaultEAXON");//set Sg=CreateSound("Units\\Demon\\Pitlord\\PitLordYesAttack1.wav",false,false,true,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Sg, "PitLordYesAttack");//call SetSoundParamsFromLabel(Sg,"PitLordYesAttack")
			SetSoundDuration(Sg, $A67);//call SetSoundDuration(Sg,$A67)
			SetSoundChannel(Sg, 1);//call SetSoundChannel(Sg,1)
			Tg = CreateSound("Sound\\Interface\\BattleNetTick.wav",false,false,false,$A,$A,"DefaultEAXON");//set Tg=CreateSound("Sound\\Interface\\BattleNetTick.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Tg, "ChatroomTimerTick");//call SetSoundParamsFromLabel(Tg,"ChatroomTimerTick")
			SetSoundDuration(Tg, 476);//call SetSoundDuration(Tg,476)
			Ug = CreateSound("Sound\\Interface\\Hint.wav",false,false,false,$A,$A,"DefaultEAXON");//set Ug=CreateSound("Sound\\Interface\\Hint.wav",false,false,false,$A,$A,"DefaultEAXON")
			SetSoundParamsFromLabel(Ug, "Hint");//call SetSoundParamsFromLabel(Ug,"Hint")
			SetSoundDuration(Ug, $7D6);//call SetSoundDuration(Ug,$7D6)
			cg = Rect(-5632.,-2048.,-1440.,2048.);//set cg=Rect(-5632.,-2048.,-1440.,2048.)
			Dg = Rect(1440.,-2048.,5632.,2048.);//set Dg=Rect(1440.,-2048.,5632.,2048.)
			Eg = Rect(-5248.,-384.,-4480.,384.);//set Eg=Rect(-5248.,-384.,-4480.,384.)
			Fg = Rect(4480.,-384.,5248.,384.);//set Fg=Rect(4480.,-384.,5248.,384.)
			InitBlizzard();//call InitBlizzard()
			ExecuteFunc("xa");//call ExecuteFunc("xa")
			ExecuteFunc("gj");//call ExecuteFunc("gj")
			ExecuteFunc("pj");//call ExecuteFunc("pj")
			ExecuteFunc("Oj");//call ExecuteFunc("Oj")
			ExecuteFunc("Wj");//call ExecuteFunc("Wj")
			ExecuteFunc("ik");//call ExecuteFunc("ik")
			ExecuteFunc("ok");//call ExecuteFunc("ok")
			ExecuteFunc("qk");//call ExecuteFunc("qk")
			ExecuteFunc("ak");//call ExecuteFunc("ak")
			ExecuteFunc("pm");//call ExecuteFunc("pm")
			ExecuteFunc("ym");//call ExecuteFunc("ym")
			ExecuteFunc("Pm");//call ExecuteFunc("Pm")
			ExecuteFunc("Zm");//call ExecuteFunc("Zm")
			ExecuteFunc("hn");//call ExecuteFunc("hn")
			ExecuteFunc("bn");//call ExecuteFunc("bn")
			ExecuteFunc("so");//call ExecuteFunc("so")
			ExecuteFunc("ao");//call ExecuteFunc("ao")
			ExecuteFunc("Go");//call ExecuteFunc("Go")
			ExecuteFunc("No");//call ExecuteFunc("No")
			ExecuteFunc("Zo");//call ExecuteFunc("Zo")
			ExecuteFunc("Xr");//call ExecuteFunc("Xr")
			ExecuteFunc("Us");//call ExecuteFunc("Us")
			ExecuteFunc("Tu");//call ExecuteFunc("Tu")
			ExecuteFunc("gv");//call ExecuteFunc("gv")
			ExecuteFunc("uv");//call ExecuteFunc("uv")
			ExecuteFunc("Iv");//call ExecuteFunc("Iv")
			ExecuteFunc("dw");//call ExecuteFunc("dw")
			ExecuteFunc("Bw");//call ExecuteFunc("Bw")
			ExecuteFunc("Gw");//call ExecuteFunc("Gw")
			ExecuteFunc("kx");//call ExecuteFunc("kx")
			ExecuteFunc("Hx");//call ExecuteFunc("Hx")
			ExecuteFunc("Vx");//call ExecuteFunc("Vx")
			ExecuteFunc("iy");//call ExecuteFunc("iy")
			ExecuteFunc("mz");//call ExecuteFunc("mz")
			ExecuteFunc("Az");//call ExecuteFunc("Az")
			ExecuteFunc("Cz");//call ExecuteFunc("Cz")
			ExecuteFunc("fA");//call ExecuteFunc("fA")
			ExecuteFunc("qA");//call ExecuteFunc("qA")
			Vg = CreateTrigger();//set Vg=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(Vg, EVENT_PLAYER_UNIT_SUMMON);//call TriggerRegisterAnyUnitEventBJ(Vg,EVENT_PLAYER_UNIT_SUMMON)
			TriggerAddAction(Vg, function DA);//call TriggerAddAction(Vg,function DA)
			Wg = CreateTrigger();//set Wg=CreateTrigger()
			TriggerRegisterPlayerEventLeave(Wg, Player(0));//call TriggerRegisterPlayerEventLeave(Wg,Player(0))
			TriggerRegisterPlayerEventLeave(Wg, Player(1));//call TriggerRegisterPlayerEventLeave(Wg,Player(1))
			TriggerRegisterPlayerEventLeave(Wg, Player(2));//call TriggerRegisterPlayerEventLeave(Wg,Player(2))
			TriggerRegisterPlayerEventLeave(Wg, Player(3));//call TriggerRegisterPlayerEventLeave(Wg,Player(3))
			TriggerRegisterPlayerEventLeave(Wg, Player(4));//call TriggerRegisterPlayerEventLeave(Wg,Player(4))
			TriggerRegisterPlayerEventLeave(Wg, Player(5));//call TriggerRegisterPlayerEventLeave(Wg,Player(5))
			TriggerRegisterPlayerEventLeave(Wg, Player(6));//call TriggerRegisterPlayerEventLeave(Wg,Player(6))
			TriggerRegisterPlayerEventLeave(Wg, Player(7));//call TriggerRegisterPlayerEventLeave(Wg,Player(7))
			TriggerRegisterPlayerEventLeave(Wg, Player(8));//call TriggerRegisterPlayerEventLeave(Wg,Player(8))
			TriggerRegisterPlayerEventLeave(Wg, Player(9));//call TriggerRegisterPlayerEventLeave(Wg,Player(9))
			TriggerRegisterPlayerEventLeave(Wg, Player($A));//call TriggerRegisterPlayerEventLeave(Wg,Player($A))
			TriggerRegisterPlayerEventLeave(Wg, Player($B));//call TriggerRegisterPlayerEventLeave(Wg,Player($B))
			TriggerAddAction(Wg, function MA);//call TriggerAddAction(Wg,function MA)
			Xg = CreateTrigger();//set Xg=CreateTrigger()
			TriggerAddAction(Xg, function PA);//call TriggerAddAction(Xg,function PA)
			TriggerRegisterAnyUnitEventBJ(Xg, EVENT_PLAYER_UNIT_PICKUP_ITEM);//call TriggerRegisterAnyUnitEventBJ(Xg,EVENT_PLAYER_UNIT_PICKUP_ITEM)
			Yg = CreateTrigger();//set Yg=CreateTrigger()
			TriggerRegisterLeaveRectSimple(Yg, cg);//call TriggerRegisterLeaveRectSimple(Yg,cg)
			TriggerRegisterLeaveRectSimple(Yg, Dg);//call TriggerRegisterLeaveRectSimple(Yg,Dg)
			TriggerAddCondition(Yg, Condition(function RA));//call TriggerAddCondition(Yg,Condition(function RA))
			Zg = CreateTrigger();//set Zg=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(Zg, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH);//call TriggerRegisterAnyUnitEventBJ(Zg,EVENT_PLAYER_UNIT_CONSTRUCT_FINISH)
			TriggerRegisterAnyUnitEventBJ(Zg, EVENT_PLAYER_UNIT_UPGRADE_FINISH);//call TriggerRegisterAnyUnitEventBJ(Zg,EVENT_PLAYER_UNIT_UPGRADE_FINISH)
			TriggerAddAction(Zg, function TA);//call TriggerAddAction(Zg,function TA)
			dh = CreateTrigger();//set dh=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(dh, EVENT_PLAYER_UNIT_UPGRADE_START);//call TriggerRegisterAnyUnitEventBJ(dh,EVENT_PLAYER_UNIT_UPGRADE_START)
			TriggerAddAction(dh, function VA);//call TriggerAddAction(dh,function VA)
			eh = CreateTrigger();//set eh=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(eh, EVENT_PLAYER_UNIT_UPGRADE_CANCEL);//call TriggerRegisterAnyUnitEventBJ(eh,EVENT_PLAYER_UNIT_UPGRADE_CANCEL)
			TriggerAddAction(eh, function XA);//call TriggerAddAction(eh,function XA)
			fh = CreateTrigger();//set fh=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(fh, EVENT_PLAYER_UNIT_CONSTRUCT_FINISH);//call TriggerRegisterAnyUnitEventBJ(fh,EVENT_PLAYER_UNIT_CONSTRUCT_FINISH)
			TriggerAddCondition(fh, Condition(function ZA));//call TriggerAddCondition(fh,Condition(function ZA))
			gh = CreateTrigger();//set gh=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(gh, EVENT_PLAYER_UNIT_DEATH);//call TriggerRegisterAnyUnitEventBJ(gh,EVENT_PLAYER_UNIT_DEATH)
			TriggerAddAction(gh, function fa);//call TriggerAddAction(gh,function fa)
			oh = Filter(function ea);//set oh=Filter(function ea)
			hh = CreateTrigger();//set hh=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(hh, EVENT_PLAYER_UNIT_SPELL_EFFECT);//call TriggerRegisterAnyUnitEventBJ(hh,EVENT_PLAYER_UNIT_SPELL_EFFECT)
			TriggerAddAction(hh, function na);//call TriggerAddAction(hh,function na)
			ih = CreateTrigger();//set ih=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(ih, EVENT_PLAYER_UNIT_TRAIN_FINISH);//call TriggerRegisterAnyUnitEventBJ(ih,EVENT_PLAYER_UNIT_TRAIN_FINISH)
			TriggerAddAction(ih, function qa);//call TriggerAddAction(ih,function qa)
			jh = CreateTrigger();//set jh=CreateTrigger()
			TriggerRegisterEnterRectSimple(jh, bj_mapInitialPlayableArea);//call TriggerRegisterEnterRectSimple(jh,bj_mapInitialPlayableArea)
			TriggerAddCondition(jh, Condition(function sa));//call TriggerAddCondition(jh,Condition(function sa))
			TriggerAddAction(jh, function ta);//call TriggerAddAction(jh,function ta)
			kh = CreateTrigger();//set kh=CreateTrigger()
			TriggerRegisterAnyUnitEventBJ(kh, EVENT_PLAYER_UNIT_CHANGE_OWNER);//call TriggerRegisterAnyUnitEventBJ(kh,EVENT_PLAYER_UNIT_CHANGE_OWNER)
			TriggerAddAction(kh, function va);//call TriggerAddAction(kh,function va)
		}//endfunction
		private void config() {//function config takes nothing returns nothing
			SetMapName("|cffFFD700Castle Fight 1.22a ES");//call SetMapName("|cffFFD700Castle Fight 1.22a ES")
			SetMapDescription("An epic battle between the two castles!Recommended gamemode is 4on4 with 2 wins.hf!");//call SetMapDescription("An epic battle between the two castles!Recommended gamemode is 4on4 with 2 wins.hf!")
			SetPlayers(4);//call SetPlayers(4)
			SetTeams(4);//call SetTeams(4)
			SetGamePlacement(MAP_PLACEMENT_TEAMS_TOGETHER);//call SetGamePlacement(MAP_PLACEMENT_TEAMS_TOGETHER)
			DefineStartLocation(0, -4288., 448.);//call DefineStartLocation(0,-4288.,448.)
			DefineStartLocation(1, -4288., 320.);//call DefineStartLocation(1,-4288.,320.)
			DefineStartLocation(2, 4288., 448.);//call DefineStartLocation(2,4288.,448.)
			DefineStartLocation(3, 4288., 320.);//call DefineStartLocation(3,4288.,320.)
			SetPlayerStartLocation(Player(0), 0);//call SetPlayerStartLocation(Player(0),0)
			ForcePlayerStartLocation(Player(0), 0);//call ForcePlayerStartLocation(Player(0),0)
			SetPlayerColor(Player(0), ConvertPlayerColor(0));//call SetPlayerColor(Player(0),ConvertPlayerColor(0))
			SetPlayerRacePreference(Player(0), RACE_PREF_NIGHTELF);//call SetPlayerRacePreference(Player(0),RACE_PREF_NIGHTELF)
			SetPlayerRaceSelectable(Player(0), false);//call SetPlayerRaceSelectable(Player(0),false)
			SetPlayerController(Player(0), MAP_CONTROL_USER);//call SetPlayerController(Player(0),MAP_CONTROL_USER)
			SetPlayerStartLocation(Player(1), 1);//call SetPlayerStartLocation(Player(1),1)
			ForcePlayerStartLocation(Player(1), 1);//call ForcePlayerStartLocation(Player(1),1)
			SetPlayerColor(Player(1), ConvertPlayerColor(1));//call SetPlayerColor(Player(1),ConvertPlayerColor(1))
			SetPlayerRacePreference(Player(1), RACE_PREF_NIGHTELF);//call SetPlayerRacePreference(Player(1),RACE_PREF_NIGHTELF)
			SetPlayerRaceSelectable(Player(1), false);//call SetPlayerRaceSelectable(Player(1),false)
			SetPlayerController(Player(1), MAP_CONTROL_USER);//call SetPlayerController(Player(1),MAP_CONTROL_USER)
			SetPlayerStartLocation(Player(6), 2);//call SetPlayerStartLocation(Player(6),2)
			ForcePlayerStartLocation(Player(6), 2);//call ForcePlayerStartLocation(Player(6),2)
			SetPlayerColor(Player(6), ConvertPlayerColor(6));//call SetPlayerColor(Player(6),ConvertPlayerColor(6))
			SetPlayerRacePreference(Player(6), RACE_PREF_UNDEAD);//call SetPlayerRacePreference(Player(6),RACE_PREF_UNDEAD)
			SetPlayerRaceSelectable(Player(6), false);//call SetPlayerRaceSelectable(Player(6),false)
			SetPlayerController(Player(6), MAP_CONTROL_USER);//call SetPlayerController(Player(6),MAP_CONTROL_USER)
			SetPlayerStartLocation(Player(7), 3);//call SetPlayerStartLocation(Player(7),3)
			ForcePlayerStartLocation(Player(7), 3);//call ForcePlayerStartLocation(Player(7),3)
			SetPlayerColor(Player(7), ConvertPlayerColor(7));//call SetPlayerColor(Player(7),ConvertPlayerColor(7))
			SetPlayerRacePreference(Player(7), RACE_PREF_UNDEAD);//call SetPlayerRacePreference(Player(7),RACE_PREF_UNDEAD)
			SetPlayerRaceSelectable(Player(7), false);//call SetPlayerRaceSelectable(Player(7),false)
			SetPlayerController(Player(7), MAP_CONTROL_USER);//call SetPlayerController(Player(7),MAP_CONTROL_USER)
			InitCustomTeams();//call InitCustomTeams()
			SetStartLocPrioCount(0, 1);//call SetStartLocPrioCount(0,1)
			SetStartLocPrio(0, 0, 1, MAP_LOC_PRIO_HIGH);//call SetStartLocPrio(0,0,1,MAP_LOC_PRIO_HIGH)
			SetStartLocPrioCount(1, 1);//call SetStartLocPrioCount(1,1)
			SetStartLocPrio(1, 0, 0, MAP_LOC_PRIO_HIGH);//call SetStartLocPrio(1,0,0,MAP_LOC_PRIO_HIGH)
			SetStartLocPrioCount(2, 1);//call SetStartLocPrioCount(2,1)
			SetStartLocPrio(2, 0, 3, MAP_LOC_PRIO_HIGH);//call SetStartLocPrio(2,0,3,MAP_LOC_PRIO_HIGH)
			SetStartLocPrioCount(3, 1);//call SetStartLocPrioCount(3,1)
			SetStartLocPrio(3, 0, 2, MAP_LOC_PRIO_HIGH);//call SetStartLocPrio(3,0,2,MAP_LOC_PRIO_HIGH)
		}//endfunction
		private bool ya() {//function ya takes nothing returns boolean
			int oi = ki;//local integer oi=ki
			FlushStoredInteger(t7, "val:"+vh[oi], th[oi]);//call FlushStoredInteger(t7,"val:"+vh[oi],th[oi])
			FlushStoredInteger(t7, "chk:"+vh[oi], vh[oi]);//call FlushStoredInteger(t7,"chk:"+vh[oi],vh[oi])
			th[oi] = null;//set th[oi]=null
			vh[oi] = null;//set vh[oi]=null
			wh[oi] = 0;//set wh[oi]=0
			return true;//return true
		}//endfunction
		private bool za() {//function za takes nothing returns boolean
			mi = tp(ki,ii);//set mi=tp(ki,ii)
			return true;//return true
		}//endfunction
		private bool Aa() {//function Aa takes nothing returns boolean
			mi = sp(ki,ii);//set mi=sp(ki,ii)
			return true;//return true
		}//endfunction
		private bool aa() {//function aa takes nothing returns boolean
			mi = rp(ki,ii);//set mi=rp(ki,ii)
			return true;//return true
		}//endfunction
		private bool Ba() {//function Ba takes nothing returns boolean
			mi = qp(ki,ii);//set mi=qp(ki,ii)
			return true;//return true
		}//endfunction
		private bool ba() {//function ba takes nothing returns boolean
			mi = pp(ki,ii);//set mi=pp(ki,ii)
			return true;//return true
		}//endfunction
		private bool Ca() {//function Ca takes nothing returns boolean
			mi = np(ki,ii);//set mi=np(ki,ii)
			return true;//return true
		}//endfunction
		private bool ca() {//function ca takes nothing returns boolean
			mi = kp(ki,ii);//set mi=kp(ki,ii)
			return true;//return true
		}//endfunction
		private bool Da() {//function Da takes nothing returns boolean
			mi = jp(ki,ii);//set mi=jp(ki,ii)
			return true;//return true
		}//endfunction
		private bool Ea() {//function Ea takes nothing returns boolean
			mi = ip(ki,ii);//set mi=ip(ki,ii)
			return true;//return true
		}//endfunction
		private bool Fa() {//function Fa takes nothing returns boolean
			mi = hp(ki,ii);//set mi=hp(ki,ii)
			return true;//return true
		}//endfunction
		private bool Ga() {//function Ga takes nothing returns boolean
			mi = gp(ki,ii);//set mi=gp(ki,ii)
			return true;//return true
		}//endfunction
		private bool Ha() {//function Ha takes nothing returns boolean
			mi = fp(ki,ii);//set mi=fp(ki,ii)
			return true;//return true
		}//endfunction
		private bool Ia() {//function Ia takes nothing returns boolean
			int oi = ki;//local integer oi=ki
			int Hi = ji;//local integer Hi=ji
			Eh[Fh[oi]+Gh[oi]] = Hi;//set Eh[Fh[oi]+Gh[oi]]=Hi
			Gh[oi] = Gh[oi]+1;//set Gh[oi]=Gh[oi]+1
			return true;//return true
		}//endfunction
		private bool la() {//function la takes nothing returns boolean
			mi = up(ki,ii);//set mi=up(ki,ii)
			return true;//return true
		}//endfunction
		private void xa() {//function xa takes nothing returns nothing
			gi = CreateTrigger();//set gi=CreateTrigger()
			TriggerAddCondition(gi, Condition(function ya));//call TriggerAddCondition(gi,Condition(function ya))
			Bh[16] = CreateTrigger();//set Bh[16]=CreateTrigger()
			TriggerAddCondition(Bh[16], Condition(function za));//call TriggerAddCondition(Bh[16],Condition(function za))
			TriggerAddAction(Bh[16], function za);//call TriggerAddAction(Bh[16],function za)
			ah[16] = null;//set ah[16]=null
			Bh[$F] = CreateTrigger();//set Bh[$F]=CreateTrigger()
			TriggerAddCondition(Bh[$F], Condition(function Aa));//call TriggerAddCondition(Bh[$F],Condition(function Aa))
			TriggerAddAction(Bh[$F], function Aa);//call TriggerAddAction(Bh[$F],function Aa)
			ah[$F] = null;//set ah[$F]=null
			Bh[$E] = CreateTrigger();//set Bh[$E]=CreateTrigger()
			TriggerAddCondition(Bh[$E], Condition(function aa));//call TriggerAddCondition(Bh[$E],Condition(function aa))
			TriggerAddAction(Bh[$E], function aa);//call TriggerAddAction(Bh[$E],function aa)
			ah[$E] = null;//set ah[$E]=null
			Bh[$D] = CreateTrigger();//set Bh[$D]=CreateTrigger()
			TriggerAddCondition(Bh[$D], Condition(function Ba));//call TriggerAddCondition(Bh[$D],Condition(function Ba))
			TriggerAddAction(Bh[$D], function Ba);//call TriggerAddAction(Bh[$D],function Ba)
			ah[$D] = null;//set ah[$D]=null
			Bh[$C] = CreateTrigger();//set Bh[$C]=CreateTrigger()
			TriggerAddCondition(Bh[$C], Condition(function ba));//call TriggerAddCondition(Bh[$C],Condition(function ba))
			TriggerAddAction(Bh[$C], function ba);//call TriggerAddAction(Bh[$C],function ba)
			ah[$C] = null;//set ah[$C]=null
			Bh[$B] = CreateTrigger();//set Bh[$B]=CreateTrigger()
			TriggerAddCondition(Bh[$B], Condition(function Ca));//call TriggerAddCondition(Bh[$B],Condition(function Ca))
			TriggerAddAction(Bh[$B], function Ca);//call TriggerAddAction(Bh[$B],function Ca)
			ah[$B] = null;//set ah[$B]=null
			Bh[$A] = CreateTrigger();//set Bh[$A]=CreateTrigger()
			TriggerAddCondition(Bh[$A], Condition(function ca));//call TriggerAddCondition(Bh[$A],Condition(function ca))
			TriggerAddAction(Bh[$A], function ca);//call TriggerAddAction(Bh[$A],function ca)
			ah[$A] = null;//set ah[$A]=null
			Bh[9] = CreateTrigger();//set Bh[9]=CreateTrigger()
			TriggerAddCondition(Bh[9], Condition(function Da));//call TriggerAddCondition(Bh[9],Condition(function Da))
			TriggerAddAction(Bh[9], function Da);//call TriggerAddAction(Bh[9],function Da)
			ah[9] = null;//set ah[9]=null
			Bh[8] = CreateTrigger();//set Bh[8]=CreateTrigger()
			TriggerAddCondition(Bh[8], Condition(function Ea));//call TriggerAddCondition(Bh[8],Condition(function Ea))
			TriggerAddAction(Bh[8], function Ea);//call TriggerAddAction(Bh[8],function Ea)
			ah[8] = null;//set ah[8]=null
			Bh[7] = CreateTrigger();//set Bh[7]=CreateTrigger()
			TriggerAddCondition(Bh[7], Condition(function Fa));//call TriggerAddCondition(Bh[7],Condition(function Fa))
			TriggerAddAction(Bh[7], function Fa);//call TriggerAddAction(Bh[7],function Fa)
			ah[7] = null;//set ah[7]=null
			Bh[6] = CreateTrigger();//set Bh[6]=CreateTrigger()
			TriggerAddCondition(Bh[6], Condition(function Ga));//call TriggerAddCondition(Bh[6],Condition(function Ga))
			TriggerAddAction(Bh[6], function Ga);//call TriggerAddAction(Bh[6],function Ga)
			ah[6] = null;//set ah[6]=null
			Bh[5] = CreateTrigger();//set Bh[5]=CreateTrigger()
			TriggerAddCondition(Bh[5], Condition(function Ha));//call TriggerAddCondition(Bh[5],Condition(function Ha))
			TriggerAddAction(Bh[5], function Ha);//call TriggerAddAction(Bh[5],function Ha)
			ah[5] = null;//set ah[5]=null
			hi = CreateTrigger();//set hi=CreateTrigger()
			TriggerAddCondition(hi, Condition(function Ia));//call TriggerAddCondition(hi,Condition(function Ia))
			Bh[17] = CreateTrigger();//set Bh[17]=CreateTrigger()
			TriggerAddCondition(Bh[17], Condition(function la));//call TriggerAddCondition(Bh[17],Condition(function la))
			TriggerAddAction(Bh[17], function la);//call TriggerAddAction(Bh[17],function la)
			ah[17] = null;//set ah[17]=null
		}//endfunction

	
	}
}

