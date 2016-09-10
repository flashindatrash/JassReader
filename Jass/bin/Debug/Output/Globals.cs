using System;
using System.Collections.Generic;

namespace Jass {

	/* global constant */
	public class Globals {

		 //
		 //
		 //
		 //
		private int ARCHMAGE = 'Hamg'; //constant integer ARCHMAGE           = 'Hamg'
		private int PALADIN = 'Hpal'; //constant integer PALADIN            = 'Hpal'
		private int MTN_KING = 'Hmkg'; //constant integer MTN_KING           = 'Hmkg'
		private int BLOOD_MAGE = 'Hblm'; //constant integer BLOOD_MAGE         = 'Hblm'
		 //
		private int AVATAR = 'AHav'; //constant integer AVATAR             = 'AHav'
		private int BASH = 'AHbh'; //constant integer BASH               = 'AHbh'
		private int THUNDER_BOLT = 'AHtb'; //constant integer THUNDER_BOLT       = 'AHtb'
		private int THUNDER_CLAP = 'AHtc'; //constant integer THUNDER_CLAP       = 'AHtc'
		private int DEVOTION_AURA = 'AHad'; //constant integer DEVOTION_AURA      = 'AHad'
		private int DIVINE_SHIELD = 'AHds'; //constant integer DIVINE_SHIELD      = 'AHds'
		private int HOLY_BOLT = 'AHhb'; //constant integer HOLY_BOLT          = 'AHhb'
		private int RESURRECTION = 'AHre'; //constant integer RESURRECTION       = 'AHre'
		private int BLIZZARD = 'AHbz'; //constant integer BLIZZARD           = 'AHbz'
		private int BRILLIANCE_AURA = 'AHab'; //constant integer BRILLIANCE_AURA    = 'AHab'
		private int MASS_TELEPORT = 'AHmt'; //constant integer MASS_TELEPORT      = 'AHmt'
		private int WATER_ELEMENTAL = 'AHwe'; //constant integer WATER_ELEMENTAL    = 'AHwe'
		private int BANISH = 'AHbn'; //constant integer BANISH             = 'AHbn'
		private int FLAME_STRIKE = 'AHfs'; //constant integer FLAME_STRIKE       = 'AHfs'
		private int SUMMON_PHOENIX = 'AHpx'; //constant integer SUMMON_PHOENIX     = 'AHpx'
		private int SIPHON_MANA = 'AHdr'; //constant integer SIPHON_MANA        = 'AHdr'
		 //
		private int JAINA = 'Hjai'; //constant integer JAINA              = 'Hjai'
		private int MURADIN = 'Hmbr'; //constant integer MURADIN            = 'Hmbr'
		private int GARITHOS = 'Hlgr'; //constant integer GARITHOS           = 'Hlgr'
		private int KAEL = 'Hkal'; //constant integer KAEL               = 'Hkal'
		 //
		private int COPTER = 'hgyr'; //constant integer COPTER             = 'hgyr'
		private int GYRO = COPTER; //constant integer GYRO               =  COPTER
		private int ELEMENTAL = 'hwat'; //constant integer ELEMENTAL          = 'hwat'
		private int FOOTMAN = 'hfoo'; //constant integer FOOTMAN            = 'hfoo'
		private int FOOTMEN = FOOTMAN; //constant integer FOOTMEN            =  FOOTMAN
		private int GRYPHON = 'hgry'; //constant integer GRYPHON            = 'hgry'
		private int KNIGHT = 'hkni'; //constant integer KNIGHT             = 'hkni'
		private int MORTAR = 'hmtm'; //constant integer MORTAR             = 'hmtm'
		private int PEASANT = 'hpea'; //constant integer PEASANT            = 'hpea'
		private int PRIEST = 'hmpr'; //constant integer PRIEST             = 'hmpr'
		private int RIFLEMAN = 'hrif'; //constant integer RIFLEMAN           = 'hrif'
		private int RIFLEMEN = RIFLEMAN; //constant integer RIFLEMEN           =  RIFLEMAN
		private int SORCERESS = 'hsor'; //constant integer SORCERESS          = 'hsor'
		private int TANK = 'hmtt'; //constant integer TANK               = 'hmtt'
		private int STEAM_TANK = TANK; //constant integer STEAM_TANK         =  TANK
		private int ROCKET_TANK = 'hrtt'; //constant integer ROCKET_TANK        = 'hrtt'
		private int MILITIA = 'hmil'; //constant integer MILITIA            = 'hmil'
		private int SPELL_BREAKER = 'hspt'; //constant integer SPELL_BREAKER      = 'hspt'
		private int HUMAN_DRAGON_HAWK = 'hdhw'; //constant integer HUMAN_DRAGON_HAWK  = 'hdhw'
		 //
		private int BLOOD_PRIEST = 'hbep'; //constant integer BLOOD_PRIEST       = 'hbep'
		private int BLOOD_SORCERESS = 'hbes'; //constant integer BLOOD_SORCERESS    = 'hbes'
		private int BLOOD_PEASANT = 'nhew'; //constant integer BLOOD_PEASANT      = 'nhew'
		 //
		private int AVIARY = 'hgra'; //constant integer AVIARY             = 'hgra'
		private int BARRACKS = 'hbar'; //constant integer BARRACKS           = 'hbar'
		private int BLACKSMITH = 'hbla'; //constant integer BLACKSMITH         = 'hbla'
		private int CANNON_TOWER = 'hctw'; //constant integer CANNON_TOWER       = 'hctw'
		private int CASTLE = 'hcas'; //constant integer CASTLE             = 'hcas'
		private int CHURCH = 'htws'; //constant integer CHURCH             = 'htws'
		private int MAGE_TOWER = CHURCH; //constant integer MAGE_TOWER         =  CHURCH
		private int GUARD_TOWER = 'hgtw'; //constant integer GUARD_TOWER        = 'hgtw'
		private int HOUSE = 'hhou'; //constant integer HOUSE              = 'hhou'
		private int HUMAN_ALTAR = 'halt'; //constant integer HUMAN_ALTAR        = 'halt'
		private int KEEP = 'hkee'; //constant integer KEEP               = 'hkee'
		private int LUMBER_MILL = 'hlum'; //constant integer LUMBER_MILL        = 'hlum'
		private int SANCTUM = 'hars'; //constant integer SANCTUM            = 'hars'
		private int ARCANE_SANCTUM = SANCTUM; //constant integer ARCANE_SANCTUM     =  SANCTUM
		private int TOWN_HALL = 'htow'; //constant integer TOWN_HALL          = 'htow'
		private int WATCH_TOWER = 'hwtw'; //constant integer WATCH_TOWER        = 'hwtw'
		private int WORKSHOP = 'harm'; //constant integer WORKSHOP           = 'harm'
		private int ARCANE_VAULT = 'hvlt'; //constant integer ARCANE_VAULT       = 'hvlt'
		private int ARCANE_TOWER = 'hatw'; //constant integer ARCANE_TOWER       = 'hatw'
		 //
		private int UPG_MELEE = 'Rhme'; //constant integer UPG_MELEE          = 'Rhme'
		private int UPG_RANGED = 'Rhra'; //constant integer UPG_RANGED         = 'Rhra'
		private int UPG_ARTILLERY = 'Rhaa'; //constant integer UPG_ARTILLERY      = 'Rhaa'
		private int UPG_ARMOR = 'Rhar'; //constant integer UPG_ARMOR          = 'Rhar'
		private int UPG_GOLD = 'Rhmi'; //constant integer UPG_GOLD           = 'Rhmi'
		private int UPG_MASONRY = 'Rhac'; //constant integer UPG_MASONRY        = 'Rhac'
		private int UPG_SIGHT = 'Rhss'; //constant integer UPG_SIGHT          = 'Rhss'
		private int UPG_DEFEND = 'Rhde'; //constant integer UPG_DEFEND         = 'Rhde'
		private int UPG_BREEDING = 'Rhan'; //constant integer UPG_BREEDING       = 'Rhan'
		private int UPG_PRAYING = 'Rhpt'; //constant integer UPG_PRAYING        = 'Rhpt'
		private int UPG_SORCERY = 'Rhst'; //constant integer UPG_SORCERY        = 'Rhst'
		private int UPG_LEATHER = 'Rhla'; //constant integer UPG_LEATHER        = 'Rhla'
		private int UPG_GUN_RANGE = 'Rhri'; //constant integer UPG_GUN_RANGE      = 'Rhri'
		private int UPG_WOOD = 'Rhlh'; //constant integer UPG_WOOD           = 'Rhlh'
		private int UPG_SENTINEL = 'Rhse'; //constant integer UPG_SENTINEL       = 'Rhse'
		private int UPG_SCATTER = 'Rhsr'; //constant integer UPG_SCATTER        = 'Rhsr'
		private int UPG_BOMBS = 'Rhgb'; //constant integer UPG_BOMBS          = 'Rhgb'
		private int UPG_HAMMERS = 'Rhhb'; //constant integer UPG_HAMMERS        = 'Rhhb'
		private int UPG_CONT_MAGIC = 'Rhss'; //constant integer UPG_CONT_MAGIC     = 'Rhss'
		private int UPG_FRAGS = 'Rhfs'; //constant integer UPG_FRAGS          = 'Rhfs'
		private int UPG_TANK = 'Rhrt'; //constant integer UPG_TANK           = 'Rhrt'
		private int UPG_FLAK = 'Rhfc'; //constant integer UPG_FLAK           = 'Rhfc'
		private int UPG_CLOUD = 'Rhcd'; //constant integer UPG_CLOUD          = 'Rhcd'
		 //
		 //
		 //
		 //
		private int BLADE_MASTER = 'Obla'; //constant integer BLADE_MASTER       = 'Obla'
		private int FAR_SEER = 'Ofar'; //constant integer FAR_SEER           = 'Ofar'
		private int TAUREN_CHIEF = 'Otch'; //constant integer TAUREN_CHIEF       = 'Otch'
		private int SHADOW_HUNTER = 'Oshd'; //constant integer SHADOW_HUNTER      = 'Oshd'
		 //
		private int GROM = 'Ogrh'; //constant integer GROM               = 'Ogrh'
		private int THRALL = 'Othr'; //constant integer THRALL             = 'Othr'
		 //
		private int CRITICAL_STRIKE = 'AOcr'; //constant integer CRITICAL_STRIKE    = 'AOcr'
		private int MIRROR_IMAGE = 'AOmi'; //constant integer MIRROR_IMAGE       = 'AOmi'
		private int BLADE_STORM = 'AOww'; //constant integer BLADE_STORM        = 'AOww'
		private int WIND_WALK = 'AOwk'; //constant integer WIND_WALK          = 'AOwk'
		private int CHAIN_LIGHTNING = 'AOcl'; //constant integer CHAIN_LIGHTNING    = 'AOcl'
		private int EARTHQUAKE = 'AOeq'; //constant integer EARTHQUAKE         = 'AOeq'
		private int FAR_SIGHT = 'AOfs'; //constant integer FAR_SIGHT          = 'AOfs'
		private int SPIRIT_WOLF = 'AOsf'; //constant integer SPIRIT_WOLF        = 'AOsf'
		private int ENDURANE_AURA = 'AOae'; //constant integer ENDURANE_AURA      = 'AOae'
		private int REINCARNATION = 'AOre'; //constant integer REINCARNATION      = 'AOre'
		private int SHOCKWAVE = 'AOsh'; //constant integer SHOCKWAVE          = 'AOsh'
		private int WAR_STOMP = 'AOws'; //constant integer WAR_STOMP          = 'AOws'
		private int HEALING_WAVE = 'AOhw'; //constant integer HEALING_WAVE       = 'AOhw'
		private int HEX = 'AOhx'; //constant integer HEX                = 'AOhx'
		private int SERPENT_WARD = 'AOsw'; //constant integer SERPENT_WARD       = 'AOsw'
		private int VOODOO = 'AOvd'; //constant integer VOODOO             = 'AOvd'
		 //
		private int GUARDIAN = 'oang'; //constant integer GUARDIAN           = 'oang'
		private int CATAPULT = 'ocat'; //constant integer CATAPULT           = 'ocat'
		private int WITCH_DOCTOR = 'odoc'; //constant integer WITCH_DOCTOR       = 'odoc'
		private int GRUNT = 'ogru'; //constant integer GRUNT              = 'ogru'
		private int HEAD_HUNTER = 'ohun'; //constant integer HEAD_HUNTER        = 'ohun'
		private int BERSERKER = 'otbk'; //constant integer BERSERKER          = 'otbk'
		private int KODO_BEAST = 'okod'; //constant integer KODO_BEAST         = 'okod'
		private int PEON = 'opeo'; //constant integer PEON               = 'opeo'
		private int RAIDER = 'orai'; //constant integer RAIDER             = 'orai'
		private int SHAMAN = 'oshm'; //constant integer SHAMAN             = 'oshm'
		private int TAUREN = 'otau'; //constant integer TAUREN             = 'otau'
		private int WYVERN = 'owyv'; //constant integer WYVERN             = 'owyv'
		private int BATRIDER = 'otbr'; //constant integer BATRIDER           = 'otbr'
		private int SPIRIT_WALKER = 'ospw'; //constant integer SPIRIT_WALKER      = 'ospw'
		private int SPIRIT_WALKER_M = 'ospm'; //constant integer SPIRIT_WALKER_M    = 'ospm'
		 //
		private int ORC_ALTAR = 'oalt'; //constant integer ORC_ALTAR          = 'oalt'
		private int ORC_BARRACKS = 'obar'; //constant integer ORC_BARRACKS       = 'obar'
		private int BESTIARY = 'obea'; //constant integer BESTIARY           = 'obea'
		private int FORGE = 'ofor'; //constant integer FORGE              = 'ofor'
		private int FORTRESS = 'ofrt'; //constant integer FORTRESS           = 'ofrt'
		private int GREAT_HALL = 'ogre'; //constant integer GREAT_HALL         = 'ogre'
		private int LODGE = 'osld'; //constant integer LODGE              = 'osld'
		private int STRONGHOLD = 'ostr'; //constant integer STRONGHOLD         = 'ostr'
		private int BURROW = 'otrb'; //constant integer BURROW             = 'otrb'
		private int TOTEM = 'otto'; //constant integer TOTEM              = 'otto'
		private int ORC_WATCH_TOWER = 'owtw'; //constant integer ORC_WATCH_TOWER    = 'owtw'
		private int VOODOO_LOUNGE = 'ovln'; //constant integer VOODOO_LOUNGE      = 'ovln'
		 //
		private int UPG_ORC_MELEE = 'Rome'; //constant integer UPG_ORC_MELEE      = 'Rome'
		private int UPG_ORC_RANGED = 'Rora'; //constant integer UPG_ORC_RANGED     = 'Rora'
		private int UPG_ORC_ARTILLERY = 'Roaa'; //constant integer UPG_ORC_ARTILLERY  = 'Roaa'
		private int UPG_ORC_ARMOR = 'Roar'; //constant integer UPG_ORC_ARMOR      = 'Roar'
		private int UPG_ORC_WAR_DRUMS = 'Rwdm'; //constant integer UPG_ORC_WAR_DRUMS  = 'Rwdm'
		private int UPG_ORC_PILLAGE = 'Ropg'; //constant integer UPG_ORC_PILLAGE    = 'Ropg'
		private int UPG_ORC_BERSERK = 'Robs'; //constant integer UPG_ORC_BERSERK    = 'Robs'
		private int UPG_ORC_PULVERIZE = 'Rows'; //constant integer UPG_ORC_PULVERIZE  = 'Rows'
		private int UPG_ORC_ENSNARE = 'Roen'; //constant integer UPG_ORC_ENSNARE    = 'Roen'
		private int UPG_ORC_VENOM = 'Rovs'; //constant integer UPG_ORC_VENOM      = 'Rovs'
		private int UPG_ORC_DOCS = 'Rowd'; //constant integer UPG_ORC_DOCS       = 'Rowd'
		private int UPG_ORC_SHAMAN = 'Rost'; //constant integer UPG_ORC_SHAMAN     = 'Rost'
		private int UPG_ORC_SPIKES = 'Rosp'; //constant integer UPG_ORC_SPIKES     = 'Rosp'
		private int UPG_ORC_BURROWS = 'Rorb'; //constant integer UPG_ORC_BURROWS    = 'Rorb'
		private int UPG_ORC_REGEN = 'Rotr'; //constant integer UPG_ORC_REGEN      = 'Rotr'
		private int UPG_ORC_FIRE = 'Rolf'; //constant integer UPG_ORC_FIRE       = 'Rolf'
		private int UPG_ORC_SWALKER = 'Rowt'; //constant integer UPG_ORC_SWALKER    = 'Rowt'
		private int UPG_ORC_BERSERKER = 'Robk'; //constant integer UPG_ORC_BERSERKER  = 'Robk'
		private int UPG_ORC_NAPTHA = 'Robf'; //constant integer UPG_ORC_NAPTHA     = 'Robf'
		private int UPG_ORC_CHAOS = 'Roch'; //constant integer UPG_ORC_CHAOS      = 'Roch'
		 //
		private int OGRE_MAGI = 'nomg'; //constant integer OGRE_MAGI          = 'nomg'
		private int ORC_DRAGON = 'nrwm'; //constant integer ORC_DRAGON         = 'nrwm'
		private int SAPPER = 'ngsp'; //constant integer SAPPER             = 'ngsp'
		private int ZEPPLIN = 'nzep'; //constant integer ZEPPLIN            = 'nzep'
		private int ZEPPELIN = ZEPPLIN; //constant integer ZEPPELIN           =  ZEPPLIN
		private int W2_WARLOCK = 'nw2w'; //constant integer W2_WARLOCK         = 'nw2w'
		private int PIG_FARM = 'npgf'; //constant integer PIG_FARM           = 'npgf'
		 //
		private int CHAOS_GRUNT = 'nchg'; //constant integer CHAOS_GRUNT        = 'nchg'
		private int CHAOS_WARLOCK = 'nchw'; //constant integer CHAOS_WARLOCK      = 'nchw'
		private int CHAOS_RAIDER = 'nchr'; //constant integer CHAOS_RAIDER       = 'nchr'
		private int CHAOS_PEON = 'ncpn'; //constant integer CHAOS_PEON         = 'ncpn'
		private int CHAOS_KODO = 'nckb'; //constant integer CHAOS_KODO         = 'nckb'
		private int CHAOS_GROM = 'Opgh'; //constant integer CHAOS_GROM         = 'Opgh'
		private int CHAOS_BLADEMASTER = 'Nbbc'; //constant integer CHAOS_BLADEMASTER  = 'Nbbc'
		private int CHAOS_BURROW = 'ocbw'; //constant integer CHAOS_BURROW       = 'ocbw'
		 //
		 //
		 //
		 //
		private int DEATH_KNIGHT = 'Udea'; //constant integer DEATH_KNIGHT       = 'Udea'
		private int DREAD_LORD = 'Udre'; //constant integer DREAD_LORD         = 'Udre'
		private int LICH = 'Ulic'; //constant integer LICH               = 'Ulic'
		private int CRYPT_LORD = 'Ucrl'; //constant integer CRYPT_LORD         = 'Ucrl'
		 //
		private int MALGANIS = 'Umal'; //constant integer MALGANIS           = 'Umal'
		private int TICHONDRIUS = 'Utic'; //constant integer TICHONDRIUS        = 'Utic'
		private int PIT_LORD = 'Npld'; //constant integer PIT_LORD           = 'Npld'
		private int DETHEROC = 'Udth'; //constant integer DETHEROC           = 'Udth'
		 //
		private int SLEEP = 'AUsl'; //constant integer SLEEP              = 'AUsl'
		private int VAMP_AURA = 'AUav'; //constant integer VAMP_AURA          = 'AUav'
		private int CARRION_SWARM = 'AUcs'; //constant integer CARRION_SWARM      = 'AUcs'
		private int INFERNO = 'AUin'; //constant integer INFERNO            = 'AUin'
		private int DARK_RITUAL = 'AUdr'; //constant integer DARK_RITUAL        = 'AUdr'
		private int DEATH_DECAY = 'AUdd'; //constant integer DEATH_DECAY        = 'AUdd'
		private int FROST_ARMOR = 'AUfu'; //constant integer FROST_ARMOR        = 'AUfu'
		private int FROST_NOVA = 'AUfn'; //constant integer FROST_NOVA         = 'AUfn'
		private int ANIM_DEAD = 'AUan'; //constant integer ANIM_DEAD          = 'AUan'
		private int DEATH_COIL = 'AUdc'; //constant integer DEATH_COIL         = 'AUdc'
		private int DEATH_PACT = 'AUdp'; //constant integer DEATH_PACT         = 'AUdp'
		private int UNHOLY_AURA = 'AUau'; //constant integer UNHOLY_AURA        = 'AUau'
		private int CARRION_SCARAB = 'AUcb'; //constant integer CARRION_SCARAB     = 'AUcb'
		private int IMPALE = 'AUim'; //constant integer IMPALE             = 'AUim'
		private int LOCUST_SWARM = 'AUls'; //constant integer LOCUST_SWARM       = 'AUls'
		private int THORNY_SHIELD = 'AUts'; //constant integer THORNY_SHIELD      = 'AUts'
		 //
		private int ABOMINATION = 'uabo'; //constant integer ABOMINATION        = 'uabo'
		private int ACOLYTE = 'uaco'; //constant integer ACOLYTE            = 'uaco'
		private int BANSHEE = 'uban'; //constant integer BANSHEE            = 'uban'
		private int PIT_FIEND = 'ucry'; //constant integer PIT_FIEND          = 'ucry'
		private int CRYPT_FIEND = PIT_FIEND; //constant integer CRYPT_FIEND        =  PIT_FIEND
		private int FROST_WYRM = 'ufro'; //constant integer FROST_WYRM         = 'ufro'
		private int GARGOYLE = 'ugar'; //constant integer GARGOYLE           = 'ugar'
		private int GARGOYLE_MORPH = 'ugrm'; //constant integer GARGOYLE_MORPH     = 'ugrm'
		private int GHOUL = 'ugho'; //constant integer GHOUL              = 'ugho'
		private int MEAT_WAGON = 'umtw'; //constant integer MEAT_WAGON         = 'umtw'
		private int NECRO = 'unec'; //constant integer NECRO              = 'unec'
		private int SKEL_WARRIOR = 'uske'; //constant integer SKEL_WARRIOR       = 'uske'
		private int SHADE = 'ushd'; //constant integer SHADE              = 'ushd'
		private int UNDEAD_BARGE = 'uarb'; //constant integer UNDEAD_BARGE       = 'uarb'
		private int OBSIDIAN_STATUE = 'uobs'; //constant integer OBSIDIAN_STATUE    = 'uobs'
		private int OBS_STATUE = OBSIDIAN_STATUE; //constant integer OBS_STATUE         =  OBSIDIAN_STATUE
		private int BLK_SPHINX = 'ubsp'; //constant integer BLK_SPHINX         = 'ubsp'
		 //
		private int UNDEAD_MINE = 'ugol'; //constant integer UNDEAD_MINE        = 'ugol'
		private int UNDEAD_ALTAR = 'uaod'; //constant integer UNDEAD_ALTAR       = 'uaod'
		private int BONEYARD = 'ubon'; //constant integer BONEYARD           = 'ubon'
		private int GARG_SPIRE = 'ugsp'; //constant integer GARG_SPIRE         = 'ugsp'
		private int NECROPOLIS_1 = 'unpl'; //constant integer NECROPOLIS_1       = 'unpl'
		private int NECROPOLIS_2 = 'unp1'; //constant integer NECROPOLIS_2       = 'unp1'
		private int NECROPOLIS_3 = 'unp2'; //constant integer NECROPOLIS_3       = 'unp2'
		private int SAC_PIT = 'usap'; //constant integer SAC_PIT            = 'usap'
		private int CRYPT = 'usep'; //constant integer CRYPT              = 'usep'
		private int SLAUGHTERHOUSE = 'uslh'; //constant integer SLAUGHTERHOUSE     = 'uslh'
		private int DAMNED_TEMPLE = 'utod'; //constant integer DAMNED_TEMPLE      = 'utod'
		private int ZIGGURAT_1 = 'uzig'; //constant integer ZIGGURAT_1         = 'uzig'
		private int ZIGGURAT_2 = 'uzg1'; //constant integer ZIGGURAT_2         = 'uzg1'
		private int ZIGGURAT_FROST = 'uzg2'; //constant integer ZIGGURAT_FROST     = 'uzg2'
		private int GRAVEYARD = 'ugrv'; //constant integer GRAVEYARD          = 'ugrv'
		private int TOMB_OF_RELICS = 'utom'; //constant integer TOMB_OF_RELICS     = 'utom'
		 //
		private int UPG_UNHOLY_STR = 'Rume'; //constant integer UPG_UNHOLY_STR     = 'Rume'
		private int UPG_CR_ATTACK = 'Rura'; //constant integer UPG_CR_ATTACK      = 'Rura'
		private int UPG_UNHOLY_ARMOR = 'Ruar'; //constant integer UPG_UNHOLY_ARMOR   = 'Ruar'
		private int UPG_CANNIBALIZE = 'Ruac'; //constant integer UPG_CANNIBALIZE    = 'Ruac'
		private int UPG_GHOUL_FRENZY = 'Rugf'; //constant integer UPG_GHOUL_FRENZY   = 'Rugf'
		private int UPG_FIEND_WEB = 'Ruwb'; //constant integer UPG_FIEND_WEB      = 'Ruwb'
		private int UPG_ABOM = 'Ruab'; //constant integer UPG_ABOM           = 'Ruab'
		private int UPG_STONE_FORM = 'Rusf'; //constant integer UPG_STONE_FORM     = 'Rusf'
		private int UPG_NECROS = 'Rune'; //constant integer UPG_NECROS         = 'Rune'
		private int UPG_BANSHEE = 'Ruba'; //constant integer UPG_BANSHEE        = 'Ruba'
		private int UPG_MEAT_WAGON = 'Rump'; //constant integer UPG_MEAT_WAGON     = 'Rump'
		private int UPG_WYRM_BREATH = 'Rufb'; //constant integer UPG_WYRM_BREATH    = 'Rufb'
		private int UPG_SKEL_LIFE = 'Rusl'; //constant integer UPG_SKEL_LIFE      = 'Rusl'
		private int UPG_SKEL_MASTERY = 'Rusm'; //constant integer UPG_SKEL_MASTERY   = 'Rusm'
		private int UPG_EXHUME = 'Ruex'; //constant integer UPG_EXHUME         = 'Ruex'
		private int UPG_SACRIFICE = 'Rurs'; //constant integer UPG_SACRIFICE      = 'Rurs'
		private int UPG_ABOM_EXPL = 'Ruax'; //constant integer UPG_ABOM_EXPL      = 'Ruax'
		private int UPG_CR_ARMOR = 'Rucr'; //constant integer UPG_CR_ARMOR       = 'Rucr'
		private int UPG_PLAGUE = 'Rupc'; //constant integer UPG_PLAGUE         = 'Rupc'
		private int UPG_BLK_SPHINX = 'Rusp'; //constant integer UPG_BLK_SPHINX     = 'Rusp'
		private int UPG_BURROWING = 'Rubu'; //constant integer UPG_BURROWING      = 'Rubu'
		 //
		 //
		 //
		 //
		private int DEMON_HUNTER = 'Edem'; //constant integer DEMON_HUNTER       = 'Edem'
		private int DEMON_HUNTER_M = 'Edmm'; //constant integer DEMON_HUNTER_M     = 'Edmm'
		private int KEEPER = 'Ekee'; //constant integer KEEPER             = 'Ekee'
		private int MOON_CHICK = 'Emoo'; //constant integer MOON_CHICK         = 'Emoo'
		private int MOON_BABE = MOON_CHICK; //constant integer MOON_BABE          =  MOON_CHICK
		private int MOON_HONEY = MOON_CHICK; //constant integer MOON_HONEY         =  MOON_CHICK
		private int WARDEN = 'Ewar'; //constant integer WARDEN             = 'Ewar'
		 //
		private int SYLVANUS = 'Hvwd'; //constant integer SYLVANUS           = 'Hvwd'
		private int CENARIUS = 'Ecen'; //constant integer CENARIUS           = 'Ecen'
		private int ILLIDAN = 'Eevi'; //constant integer ILLIDAN            = 'Eevi'
		private int ILLIDAN_DEMON = 'Eevm'; //constant integer ILLIDAN_DEMON      = 'Eevm'
		private int MAIEV = 'Ewrd'; //constant integer MAIEV              = 'Ewrd'
		 //
		private int FORCE_NATURE = 'AEfn'; //constant integer FORCE_NATURE       = 'AEfn'
		private int ENT_ROOTS = 'AEer'; //constant integer ENT_ROOTS          = 'AEer'
		private int THORNS_AURA = 'AEah'; //constant integer THORNS_AURA        = 'AEah'
		private int TRANQUILITY = 'AEtq'; //constant integer TRANQUILITY        = 'AEtq'
		private int EVASION = 'AEev'; //constant integer EVASION            = 'AEev'
		private int IMMOLATION = 'AEim'; //constant integer IMMOLATION         = 'AEim'
		private int MANA_BURN = 'AEmb'; //constant integer MANA_BURN          = 'AEmb'
		private int METAMORPHOSIS = 'AEme'; //constant integer METAMORPHOSIS      = 'AEme'
		private int SEARING_ARROWS = 'AHfa'; //constant integer SEARING_ARROWS     = 'AHfa'
		private int SCOUT = 'AEst'; //constant integer SCOUT              = 'AEst'
		private int STARFALL = 'AEsf'; //constant integer STARFALL           = 'AEsf'
		private int TRUESHOT = 'AEar'; //constant integer TRUESHOT           = 'AEar'
		private int BLINK = 'AEbl'; //constant integer BLINK              = 'AEbl'
		private int FAN_KNIVES = 'AEfk'; //constant integer FAN_KNIVES         = 'AEfk'
		private int SHADOW_TOUCH = 'AEsh'; //constant integer SHADOW_TOUCH       = 'AEsh'
		private int VENGEANCE = 'AEsv'; //constant integer VENGEANCE          = 'AEsv'
		 //
		private int WISP = 'ewsp'; //constant integer WISP               = 'ewsp'
		private int ARCHER = 'earc'; //constant integer ARCHER             = 'earc'
		private int DRUID_TALON = 'edot'; //constant integer DRUID_TALON        = 'edot'
		private int DRUID_TALON_M = 'edtm'; //constant integer DRUID_TALON_M      = 'edtm'
		private int BALLISTA = 'ebal'; //constant integer BALLISTA           = 'ebal'
		private int DRUID_CLAW = 'edoc'; //constant integer DRUID_CLAW         = 'edoc'
		private int DRUID_CLAW_M = 'edcm'; //constant integer DRUID_CLAW_M       = 'edcm'
		private int DRYAD = 'edry'; //constant integer DRYAD              = 'edry'
		private int HIPPO = 'ehip'; //constant integer HIPPO              = 'ehip'
		private int HIPPO_RIDER = 'ehpr'; //constant integer HIPPO_RIDER        = 'ehpr'
		private int HUNTRESS = 'esen'; //constant integer HUNTRESS           = 'esen'
		private int CHIMAERA = 'echm'; //constant integer CHIMAERA           = 'echm'
		private int ENT = 'efon'; //constant integer ENT                = 'efon'
		private int MOUNTAIN_GIANT = 'emtg'; //constant integer MOUNTAIN_GIANT     = 'emtg'
		private int FAERIE_DRAGON = 'efdr'; //constant integer FAERIE_DRAGON      = 'efdr'
		 //
		private int HIGH_ARCHER = 'nhea'; //constant integer HIGH_ARCHER        = 'nhea'
		private int HIGH_FOOTMAN = 'hcth'; //constant integer HIGH_FOOTMAN       = 'hcth'
		private int HIGH_FOOTMEN = HIGH_FOOTMAN; //constant integer HIGH_FOOTMEN       =  HIGH_FOOTMAN
		private int HIGH_SWORDMAN = 'hhes'; //constant integer HIGH_SWORDMAN      = 'hhes'
		private int DRAGON_HAWK = 'nws1'; //constant integer DRAGON_HAWK        = 'nws1'
		private int CORRUPT_TREANT = 'nenc'; //constant integer CORRUPT_TREANT     = 'nenc'
		private int POISON_TREANT = 'nenp'; //constant integer POISON_TREANT      = 'nenp'
		private int PLAGUE_TREANT = 'nepl'; //constant integer PLAGUE_TREANT      = 'nepl'
		private int SHANDRIS = 'eshd'; //constant integer SHANDRIS           = 'eshd'
		 //
		private int ANCIENT_LORE = 'eaoe'; //constant integer ANCIENT_LORE       = 'eaoe'
		private int ANCIENT_WAR = 'eaom'; //constant integer ANCIENT_WAR        = 'eaom'
		private int ANCIENT_WIND = 'eaow'; //constant integer ANCIENT_WIND       = 'eaow'
		private int TREE_AGES = 'etoa'; //constant integer TREE_AGES          = 'etoa'
		private int TREE_ETERNITY = 'etoe'; //constant integer TREE_ETERNITY      = 'etoe'
		private int TREE_LIFE = 'etol'; //constant integer TREE_LIFE          = 'etol'
		private int ANCIENT_PROTECT = 'etrp'; //constant integer ANCIENT_PROTECT    = 'etrp'
		private int ELF_ALTAR = 'eate'; //constant integer ELF_ALTAR          = 'eate'
		private int BEAR_DEN = 'edol'; //constant integer BEAR_DEN           = 'edol'
		private int CHIMAERA_ROOST = 'edos'; //constant integer CHIMAERA_ROOST     = 'edos'
		private int HUNTERS_HALL = 'edob'; //constant integer HUNTERS_HALL       = 'edob'
		private int MOON_WELL = 'emow'; //constant integer MOON_WELL          = 'emow'
		private int ELF_MINE = 'egol'; //constant integer ELF_MINE           = 'egol'
		private int DEN_OF_WONDERS = 'eden'; //constant integer DEN_OF_WONDERS     = 'eden'
		 //
		private int ELF_FARM = 'nefm'; //constant integer ELF_FARM           = 'nefm'
		private int ELF_GUARD_TOWER = 'negt'; //constant integer ELF_GUARD_TOWER    = 'negt'
		private int HIGH_SKY = 'negm'; //constant integer HIGH_SKY           = 'negm'
		private int HIGH_EARTH = 'negf'; //constant integer HIGH_EARTH         = 'negf'
		private int HIGH_TOWER = 'negt'; //constant integer HIGH_TOWER         = 'negt'
		private int ELF_HIGH_BARRACKS = 'nheb'; //constant integer ELF_HIGH_BARRACKS  = 'nheb'
		private int CORRUPT_LIFE = 'nctl'; //constant integer CORRUPT_LIFE       = 'nctl'
		private int CORRUPT_WELL = 'ncmw'; //constant integer CORRUPT_WELL       = 'ncmw'
		private int CORRUPT_PROTECTOR = 'ncap'; //constant integer CORRUPT_PROTECTOR  = 'ncap'
		private int CORRUPT_WAR = 'ncaw'; //constant integer CORRUPT_WAR        = 'ncaw'
		 //
		private int UPG_STR_MOON = 'Resm'; //constant integer UPG_STR_MOON       = 'Resm'
		private int UPG_STR_WILD = 'Resw'; //constant integer UPG_STR_WILD       = 'Resw'
		private int UPG_MOON_ARMOR = 'Rema'; //constant integer UPG_MOON_ARMOR     = 'Rema'
		private int UPG_HIDES = 'Rerh'; //constant integer UPG_HIDES          = 'Rerh'
		private int UPG_ULTRAVISION = 'Reuv'; //constant integer UPG_ULTRAVISION    = 'Reuv'
		private int UPG_BLESSING = 'Renb'; //constant integer UPG_BLESSING       = 'Renb'
		private int UPG_SCOUT = 'Resc'; //constant integer UPG_SCOUT          = 'Resc'
		private int UPG_GLAIVE = 'Remg'; //constant integer UPG_GLAIVE         = 'Remg'
		private int UPG_BOWS = 'Reib'; //constant integer UPG_BOWS           = 'Reib'
		private int UPG_MARKSMAN = 'Remk'; //constant integer UPG_MARKSMAN       = 'Remk'
		private int UPG_DRUID_TALON = 'Redt'; //constant integer UPG_DRUID_TALON    = 'Redt'
		private int UPG_DRUID_CLAW = 'Redc'; //constant integer UPG_DRUID_CLAW     = 'Redc'
		private int UPG_ABOLISH = 'Resi'; //constant integer UPG_ABOLISH        = 'Resi'
		private int UPG_CHIM_ACID = 'Recb'; //constant integer UPG_CHIM_ACID      = 'Recb'
		private int UPG_HIPPO_TAME = 'Reht'; //constant integer UPG_HIPPO_TAME     = 'Reht'
		private int UPG_BOLT = 'Repd'; //constant integer UPG_BOLT           = 'Repd'
		private int UPG_MARK_CLAW = 'Reeb'; //constant integer UPG_MARK_CLAW      = 'Reeb'
		private int UPG_MARK_TALON = 'Reec'; //constant integer UPG_MARK_TALON     = 'Reec'
		private int UPG_HARD_SKIN = 'Rehs'; //constant integer UPG_HARD_SKIN      = 'Rehs'
		private int UPG_RESIST_SKIN = 'Rers'; //constant integer UPG_RESIST_SKIN    = 'Rers'
		private int UPG_WELL_SPRING = 'Rews'; //constant integer UPG_WELL_SPRING    = 'Rews'
		 //
		 //
		 //
		private int DEMON_GATE = 'ndmg'; //constant integer DEMON_GATE         = 'ndmg'
		private int FELLHOUND = 'nfel'; //constant integer FELLHOUND          = 'nfel'
		private int INFERNAL = 'ninf'; //constant integer INFERNAL           = 'ninf'
		private int DOOMGUARD = 'nbal'; //constant integer DOOMGUARD          = 'nbal'
		private int SATYR = 'nsty'; //constant integer SATYR              = 'nsty'
		private int TRICKSTER = 'nsat'; //constant integer TRICKSTER          = 'nsat'
		private int SHADOWDANCER = 'nsts'; //constant integer SHADOWDANCER       = 'nsts'
		private int SOULSTEALER = 'nstl'; //constant integer SOULSTEALER        = 'nstl'
		private int HELLCALLER = 'nsth'; //constant integer HELLCALLER         = 'nsth'
		private int SKEL_ARCHER = 'nska'; //constant integer SKEL_ARCHER        = 'nska'
		private int SKEL_MARKSMAN = 'nskm'; //constant integer SKEL_MARKSMAN      = 'nskm'
		private int SKEL_BURNING = 'nskf'; //constant integer SKEL_BURNING       = 'nskf'
		private int SKEL_GIANT = 'nskg'; //constant integer SKEL_GIANT         = 'nskg'
		private int FURBOLG = 'nfrl'; //constant integer FURBOLG            = 'nfrl'
		private int FURBOLG_TRACKER = 'nfrb'; //constant integer FURBOLG_TRACKER    = 'nfrb'
		private int FURBOLG_SHAMAN = 'nfrs'; //constant integer FURBOLG_SHAMAN     = 'nfrs'
		private int FURBOLG_CHAMP = 'nfrg'; //constant integer FURBOLG_CHAMP      = 'nfrg'
		private int FURBOLG_ELDER = 'nfre'; //constant integer FURBOLG_ELDER      = 'nfre'
		 //
		 //
		 //
		 //
		private int NAGA_SORCERESS = 'Nngs'; //constant integer NAGA_SORCERESS     = 'Nngs'
		private int NAGA_VASHJ = 'Hvsh'; //constant integer NAGA_VASHJ         = 'Hvsh'
		 //
		private int NAGA_DRAGON = 'nsnp'; //constant integer NAGA_DRAGON        = 'nsnp'
		private int NAGA_WITCH = 'nnsw'; //constant integer NAGA_WITCH         = 'nnsw'
		private int NAGA_SERPENT = 'nwgs'; //constant integer NAGA_SERPENT       = 'nwgs'
		private int NAGA_HYDRA = 'nhyc'; //constant integer NAGA_HYDRA         = 'nhyc'
		private int NAGA_SLAVE = 'nmpe'; //constant integer NAGA_SLAVE         = 'nmpe'
		private int NAGA_SNAP_DRAGON = NAGA_DRAGON; //constant integer NAGA_SNAP_DRAGON   =  NAGA_DRAGON
		private int NAGA_COUATL = NAGA_SERPENT; //constant integer NAGA_COUATL        =  NAGA_SERPENT
		private int NAGA_SIREN = NAGA_WITCH; //constant integer NAGA_SIREN         =  NAGA_WITCH
		private int NAGA_MYRMIDON = 'nmyr'; //constant integer NAGA_MYRMIDON      = 'nmyr'
		private int NAGA_REAVER = 'nnmg'; //constant integer NAGA_REAVER        = 'nnmg'
		private int NAGA_TURTLE = NAGA_HYDRA; //constant integer NAGA_TURTLE        =  NAGA_HYDRA
		private int NAGA_ROYAL = 'nnrg'; //constant integer NAGA_ROYAL         = 'nnrg'
		 //
		private int NAGA_TEMPLE = 'nntt'; //constant integer NAGA_TEMPLE        = 'nntt'
		private int NAGA_CORAL = 'nnfm'; //constant integer NAGA_CORAL         = 'nnfm'
		private int NAGA_SHRINE = 'nnsa'; //constant integer NAGA_SHRINE        = 'nnsa'
		private int NAGA_SPAWNING = 'nnsg'; //constant integer NAGA_SPAWNING      = 'nnsg'
		private int NAGA_GUARDIAN = 'nntg'; //constant integer NAGA_GUARDIAN      = 'nntg'
		private int NAGA_ALTAR = 'nnad'; //constant integer NAGA_ALTAR         = 'nnad'
		 //
		private int UPG_NAGA_ARMOR = 'Rnam'; //constant integer UPG_NAGA_ARMOR     = 'Rnam'
		private int UPG_NAGA_ATTACK = 'Rnat'; //constant integer UPG_NAGA_ATTACK    = 'Rnat'
		private int UPG_NAGA_ABOLISH = 'Rnsi'; //constant integer UPG_NAGA_ABOLISH   = 'Rnsi'
		private int UPG_SIREN = 'Rnsw'; //constant integer UPG_SIREN          = 'Rnsw'
		private int UPG_NAGA_ENSNARE = 'Rnen'; //constant integer UPG_NAGA_ENSNARE   = 'Rnen'
		 //
		private int M1 = 60; //constant integer M1                 =    60
		private int M2 = 2*60; //constant integer M2                 =  2*60
		private int M3 = 3*60; //constant integer M3                 =  3*60
		private int M4 = 4*60; //constant integer M4                 =  4*60
		private int M5 = 5*60; //constant integer M5                 =  5*60
		private int M6 = 6*60; //constant integer M6                 =  6*60
		private int M7 = 7*60; //constant integer M7                 =  7*60
		private int M8 = 8*60; //constant integer M8                 =  8*60
		private int M9 = 9*60; //constant integer M9                 =  9*60
		private int M10 = 10*60; //constant integer M10                = 10*60
		private int M11 = 11*60; //constant integer M11                = 11*60
		private int M12 = 12*60; //constant integer M12                = 12*60
		private int M13 = 13*60; //constant integer M13                = 13*60
		private int M14 = 14*60; //constant integer M14                = 14*60
		private int M15 = 15*60; //constant integer M15                = 15*60
		private int EASY = 1; //constant integer EASY               = 1
		private int NORMAL = 2; //constant integer NORMAL             = 2
		private int HARD = 3; //constant integer HARD               = 3
		private int INSANE = 4; //constant integer INSANE             = 4
		private int MELEE_NEWBIE = 1; //constant integer MELEE_NEWBIE       = 1
		private int MELEE_NORMAL = 2; //constant integer MELEE_NORMAL       = 2
		private int MELEE_INSANE = 3; //constant integer MELEE_INSANE       = 3
		private int ATTACK_CAPTAIN = 1; //constant integer ATTACK_CAPTAIN     = 1
		private int DEFENSE_CAPTAIN = 2; //constant integer DEFENSE_CAPTAIN    = 2
		private int BOTH_CAPTAINS = 3; //constant integer BOTH_CAPTAINS      = 3
		private int BUILD_UNIT = 1; //constant integer BUILD_UNIT         = 1
		private int BUILD_UPGRADE = 2; //constant integer BUILD_UPGRADE      = 2
		private int BUILD_EXPAND = 3; //constant integer BUILD_EXPAND       = 3
		private int UPKEEP_TIER1 = 50; //constant integer UPKEEP_TIER1       = 50
		private int UPKEEP_TIER2 = 80; //constant integer UPKEEP_TIER2       = 80
		 //
		private player ai_player; //player  ai_player
		private int sleep_seconds; //integer sleep_seconds
		private int total_gold = 0; //integer total_gold              = 0
		private int total_wood = 0; //integer total_wood              = 0
		private int gold_buffer = 0; //integer gold_buffer             = 0
		private int difficulty = NORMAL; //integer difficulty              = NORMAL
		private int exp_seen = 0; //integer exp_seen                = 0
		private int racial_farm = 'hhou'; //integer racial_farm             = 'hhou'
		private int hero_id = 'Hamg'; //integer hero_id                 = 'Hamg'
		private int hero_id2 = 'Hmkg'; //integer hero_id2                = 'Hmkg'
		private int hero_id3 = 'Hpal'; //integer hero_id3                = 'Hpal'
		private int[]skill; //integer array skill
		private int[]skills1; //integer array skills1
		private int[]skills2; //integer array skills2
		private int[]skills3; //integer array skills3
		private int max_hero_level = 0; //integer max_hero_level          = 0
		private int[]harass_qty; //integer array harass_qty
		private int[]harass_max; //integer array harass_max
		private int[]harass_units; //integer array harass_units
		private int harass_length = 0; //integer harass_length           = 0
		private int[]defense_qty; //integer array defense_qty
		private int[]defense_units; //integer array defense_units
		private int defense_length = 0; //integer defense_length          = 0
		private int[]build_qty; //integer array build_qty
		private int[]build_type; //integer array build_type
		private int[]build_item; //integer array build_item
		private int[]build_town; //integer array build_town
		private int build_length = 0; //integer build_length            = 0
		private int campaign_gold_peons = 5; //integer campaign_gold_peons     = 5
		private int campaign_wood_peons = 3; //integer campaign_wood_peons     = 3
		private int campaign_basics_speed = 5; //integer campaign_basics_speed   = 5
		private int min_creeps = -1; //integer min_creeps              = -1
		private int max_creeps = -1; //integer max_creeps              = -1
		private bool harvest_town1 = true; //boolean harvest_town1           = true
		private bool harvest_town2 = true; //boolean harvest_town2           = true
		private bool harvest_town3 = true; //boolean harvest_town3           = true
		private bool do_campaign_farms = true; //boolean do_campaign_farms       = true
		private bool two_heroes = false; //boolean two_heroes              = false
		private bool allow_air_creeps = false; //boolean allow_air_creeps        = false
		private bool take_exp = false; //boolean take_exp                = false
		private bool allow_signal_abort = false; //boolean allow_signal_abort      = false
		private bool ready_for_zeppelin = true; //boolean ready_for_zeppelin      = true
		private bool get_zeppelin = false; //boolean get_zeppelin            = false
		private bool build_campaign_attackers = true; //boolean build_campaign_attackers = true
		private bool do_debug_cheats = false; //boolean do_debug_cheats         = false
		private bool trace_on = true; //boolean trace_on                = true
		private bool zep_next_wave = false; //boolean zep_next_wave           = false
		private bool form_group_timeouts = true; //boolean form_group_timeouts     = true

	
	}
}

