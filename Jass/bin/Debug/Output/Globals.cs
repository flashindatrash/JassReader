using System;
using System.Collections.Generic;

namespace Jass {

	/* global constant */
	public class Globals {

		
		//--------------------------------------------------------------------
		//  HUMANS
		//--------------------------------------------------------------------
		// human heroes
		private int ARCHMAGE = 'Hamg';
		private int PALADIN = 'Hpal';
		private int MTN_KING = 'Hmkg';
		private int BLOOD_MAGE = 'Hblm';
		// human hero abilities
		private int AVATAR = 'AHav';
		private int BASH = 'AHbh';
		private int THUNDER_BOLT = 'AHtb';
		private int THUNDER_CLAP = 'AHtc';
		private int DEVOTION_AURA = 'AHad';
		private int DIVINE_SHIELD = 'AHds';
		private int HOLY_BOLT = 'AHhb';
		private int RESURRECTION = 'AHre';
		private int BLIZZARD = 'AHbz';
		private int BRILLIANCE_AURA = 'AHab';
		private int MASS_TELEPORT = 'AHmt';
		private int WATER_ELEMENTAL = 'AHwe';
		private int BANISH = 'AHbn';
		private int FLAME_STRIKE = 'AHfs';
		private int SUMMON_PHOENIX = 'AHpx';
		private int SIPHON_MANA = 'AHdr';
		// special human heroes
		private int JAINA = 'Hjai';
		private int MURADIN = 'Hmbr';
		private int GARITHOS = 'Hlgr';
		private int KAEL = 'Hkal';
		// human units
		private int COPTER = 'hgyr';
		private int GYRO = COPTER;
		private int ELEMENTAL = 'hwat';
		private int FOOTMAN = 'hfoo';
		private int FOOTMEN = FOOTMAN;
		private int GRYPHON = 'hgry';
		private int KNIGHT = 'hkni';
		private int MORTAR = 'hmtm';
		private int PEASANT = 'hpea';
		private int PRIEST = 'hmpr';
		private int RIFLEMAN = 'hrif';
		private int RIFLEMEN = RIFLEMAN;
		private int SORCERESS = 'hsor';
		private int TANK = 'hmtt';
		private int STEAM_TANK = TANK;
		private int ROCKET_TANK = 'hrtt';
		private int MILITIA = 'hmil';
		private int SPELL_BREAKER = 'hspt';
		private int HUMAN_DRAGON_HAWK = 'hdhw';
		// special human units
		private int BLOOD_PRIEST = 'hbep';
		private int BLOOD_SORCERESS = 'hbes';
		private int BLOOD_PEASANT = 'nhew';
		// human buildings
		private int AVIARY = 'hgra';
		private int BARRACKS = 'hbar';
		private int BLACKSMITH = 'hbla';
		private int CANNON_TOWER = 'hctw';
		private int CASTLE = 'hcas';
		private int CHURCH = 'htws';
		private int MAGE_TOWER = CHURCH;
		private int GUARD_TOWER = 'hgtw';
		private int HOUSE = 'hhou';
		private int HUMAN_ALTAR = 'halt';
		private int KEEP = 'hkee';
		private int LUMBER_MILL = 'hlum';
		private int SANCTUM = 'hars';
		private int ARCANE_SANCTUM = SANCTUM;
		private int TOWN_HALL = 'htow';
		private int WATCH_TOWER = 'hwtw';
		private int WORKSHOP = 'harm';
		private int ARCANE_VAULT = 'hvlt';
		private int ARCANE_TOWER = 'hatw';
		// human upgrades
		private int UPG_MELEE = 'Rhme';
		private int UPG_RANGED = 'Rhra';
		private int UPG_ARTILLERY = 'Rhaa';
		private int UPG_ARMOR = 'Rhar';
		private int UPG_GOLD = 'Rhmi';
		private int UPG_MASONRY = 'Rhac';
		private int UPG_SIGHT = 'Rhss';
		private int UPG_DEFEND = 'Rhde';
		private int UPG_BREEDING = 'Rhan';
		private int UPG_PRAYING = 'Rhpt';
		private int UPG_SORCERY = 'Rhst';
		private int UPG_LEATHER = 'Rhla';
		private int UPG_GUN_RANGE = 'Rhri';
		private int UPG_WOOD = 'Rhlh';
		private int UPG_SENTINEL = 'Rhse';
		private int UPG_SCATTER = 'Rhsr';
		private int UPG_BOMBS = 'Rhgb';
		private int UPG_HAMMERS = 'Rhhb';
		private int UPG_CONT_MAGIC = 'Rhss';
		private int UPG_FRAGS = 'Rhfs';
		private int UPG_TANK = 'Rhrt';
		private int UPG_FLAK = 'Rhfc';
		private int UPG_CLOUD = 'Rhcd';
		//--------------------------------------------------------------------
		//  ORCS
		//--------------------------------------------------------------------
		// orc heroes
		private int BLADE_MASTER = 'Obla';
		private int FAR_SEER = 'Ofar';
		private int TAUREN_CHIEF = 'Otch';
		private int SHADOW_HUNTER = 'Oshd';
		// special orc heroes
		private int GROM = 'Ogrh';
		private int THRALL = 'Othr';
		// orc hero abilities
		private int CRITICAL_STRIKE = 'AOcr';
		private int MIRROR_IMAGE = 'AOmi';
		private int BLADE_STORM = 'AOww';
		private int WIND_WALK = 'AOwk';
		private int CHAIN_LIGHTNING = 'AOcl';
		private int EARTHQUAKE = 'AOeq';
		private int FAR_SIGHT = 'AOfs';
		private int SPIRIT_WOLF = 'AOsf';
		private int ENDURANE_AURA = 'AOae';
		private int REINCARNATION = 'AOre';
		private int SHOCKWAVE = 'AOsh';
		private int WAR_STOMP = 'AOws';
		private int HEALING_WAVE = 'AOhw';
		private int HEX = 'AOhx';
		private int SERPENT_WARD = 'AOsw';
		private int VOODOO = 'AOvd';
		// orc units
		private int GUARDIAN = 'oang';
		private int CATAPULT = 'ocat';
		private int WITCH_DOCTOR = 'odoc';
		private int GRUNT = 'ogru';
		private int HEAD_HUNTER = 'ohun';
		private int BERSERKER = 'otbk';
		private int KODO_BEAST = 'okod';
		private int PEON = 'opeo';
		private int RAIDER = 'orai';
		private int SHAMAN = 'oshm';
		private int TAUREN = 'otau';
		private int WYVERN = 'owyv';
		private int BATRIDER = 'otbr';
		private int SPIRIT_WALKER = 'ospw';
		private int SPIRIT_WALKER_M = 'ospm';
		// orc buildings
		private int ORC_ALTAR = 'oalt';
		private int ORC_BARRACKS = 'obar';
		private int BESTIARY = 'obea';
		private int FORGE = 'ofor';
		private int FORTRESS = 'ofrt';
		private int GREAT_HALL = 'ogre';
		private int LODGE = 'osld';
		private int STRONGHOLD = 'ostr';
		private int BURROW = 'otrb';
		private int TOTEM = 'otto';
		private int ORC_WATCH_TOWER = 'owtw';
		private int VOODOO_LOUNGE = 'ovln';
		// orc upgrades
		private int UPG_ORC_MELEE = 'Rome';
		private int UPG_ORC_RANGED = 'Rora';
		private int UPG_ORC_ARTILLERY = 'Roaa';
		private int UPG_ORC_ARMOR = 'Roar';
		private int UPG_ORC_WAR_DRUMS = 'Rwdm';
		private int UPG_ORC_PILLAGE = 'Ropg';
		private int UPG_ORC_BERSERK = 'Robs';
		private int UPG_ORC_PULVERIZE = 'Rows';
		private int UPG_ORC_ENSNARE = 'Roen';
		private int UPG_ORC_VENOM = 'Rovs';
		private int UPG_ORC_DOCS = 'Rowd';
		private int UPG_ORC_SHAMAN = 'Rost';
		private int UPG_ORC_SPIKES = 'Rosp';
		private int UPG_ORC_BURROWS = 'Rorb';
		private int UPG_ORC_REGEN = 'Rotr';
		private int UPG_ORC_FIRE = 'Rolf';
		private int UPG_ORC_SWALKER = 'Rowt';
		private int UPG_ORC_BERSERKER = 'Robk';
		private int UPG_ORC_NAPTHA = 'Robf';
		private int UPG_ORC_CHAOS = 'Roch';
		// Warcraft 2 orc units
		private int OGRE_MAGI = 'nomg';
		private int ORC_DRAGON = 'nrwm';
		private int SAPPER = 'ngsp';
		private int ZEPPLIN = 'nzep';
		private int ZEPPELIN = ZEPPLIN;
		private int W2_WARLOCK = 'nw2w';
		private int PIG_FARM = 'npgf';
		// special orc units
		private int CHAOS_GRUNT = 'nchg';
		private int CHAOS_WARLOCK = 'nchw';
		private int CHAOS_RAIDER = 'nchr';
		private int CHAOS_PEON = 'ncpn';
		private int CHAOS_KODO = 'nckb';
		private int CHAOS_GROM = 'Opgh';
		private int CHAOS_BLADEMASTER = 'Nbbc';
		private int CHAOS_BURROW = 'ocbw';
		//--------------------------------------------------------------------
		//  UNDEAD
		//--------------------------------------------------------------------
		// undead heroes
		private int DEATH_KNIGHT = 'Udea';
		private int DREAD_LORD = 'Udre';
		private int LICH = 'Ulic';
		private int CRYPT_LORD = 'Ucrl';
		// special undead heroes
		private int MALGANIS = 'Umal';
		private int TICHONDRIUS = 'Utic';
		private int PIT_LORD = 'Npld';
		private int DETHEROC = 'Udth';
		// undead hero abilities
		private int SLEEP = 'AUsl';
		private int VAMP_AURA = 'AUav';
		private int CARRION_SWARM = 'AUcs';
		private int INFERNO = 'AUin';
		private int DARK_RITUAL = 'AUdr';
		private int DEATH_DECAY = 'AUdd';
		private int FROST_ARMOR = 'AUfu';
		private int FROST_NOVA = 'AUfn';
		private int ANIM_DEAD = 'AUan';
		private int DEATH_COIL = 'AUdc';
		private int DEATH_PACT = 'AUdp';
		private int UNHOLY_AURA = 'AUau';
		private int CARRION_SCARAB = 'AUcb';
		private int IMPALE = 'AUim';
		private int LOCUST_SWARM = 'AUls';
		private int THORNY_SHIELD = 'AUts';
		// undead units
		private int ABOMINATION = 'uabo';
		private int ACOLYTE = 'uaco';
		private int BANSHEE = 'uban';
		private int PIT_FIEND = 'ucry';
		private int CRYPT_FIEND = PIT_FIEND;
		private int FROST_WYRM = 'ufro';
		private int GARGOYLE = 'ugar';
		private int GARGOYLE_MORPH = 'ugrm';
		private int GHOUL = 'ugho';
		private int MEAT_WAGON = 'umtw';
		private int NECRO = 'unec';
		private int SKEL_WARRIOR = 'uske';
		private int SHADE = 'ushd';
		private int UNDEAD_BARGE = 'uarb';
		private int OBSIDIAN_STATUE = 'uobs';
		private int OBS_STATUE = OBSIDIAN_STATUE;
		private int BLK_SPHINX = 'ubsp';
		// undead buildings
		private int UNDEAD_MINE = 'ugol';
		private int UNDEAD_ALTAR = 'uaod';
		private int BONEYARD = 'ubon';
		private int GARG_SPIRE = 'ugsp';
		private int NECROPOLIS_1 = 'unpl';// normal
		private int NECROPOLIS_2 = 'unp1';// upgraded once
		private int NECROPOLIS_3 = 'unp2';// full upgrade
		private int SAC_PIT = 'usap';
		private int CRYPT = 'usep';
		private int SLAUGHTERHOUSE = 'uslh';
		private int DAMNED_TEMPLE = 'utod';
		private int ZIGGURAT_1 = 'uzig';// normal
		private int ZIGGURAT_2 = 'uzg1';// upgraded
		private int ZIGGURAT_FROST = 'uzg2';// frost tower
		private int GRAVEYARD = 'ugrv';
		private int TOMB_OF_RELICS = 'utom';
		// undead upgrades
		private int UPG_UNHOLY_STR = 'Rume';
		private int UPG_CR_ATTACK = 'Rura';
		private int UPG_UNHOLY_ARMOR = 'Ruar';
		private int UPG_CANNIBALIZE = 'Ruac';
		private int UPG_GHOUL_FRENZY = 'Rugf';
		private int UPG_FIEND_WEB = 'Ruwb';
		private int UPG_ABOM = 'Ruab';
		private int UPG_STONE_FORM = 'Rusf';
		private int UPG_NECROS = 'Rune';
		private int UPG_BANSHEE = 'Ruba';
		private int UPG_MEAT_WAGON = 'Rump';
		private int UPG_WYRM_BREATH = 'Rufb';
		private int UPG_SKEL_LIFE = 'Rusl';
		private int UPG_SKEL_MASTERY = 'Rusm';
		private int UPG_EXHUME = 'Ruex';
		private int UPG_SACRIFICE = 'Rurs';
		private int UPG_ABOM_EXPL = 'Ruax';
		private int UPG_CR_ARMOR = 'Rucr';
		private int UPG_PLAGUE = 'Rupc';
		private int UPG_BLK_SPHINX = 'Rusp';
		private int UPG_BURROWING = 'Rubu';
		//--------------------------------------------------------------------
		//  ELVES
		//--------------------------------------------------------------------
		// elf heroes
		private int DEMON_HUNTER = 'Edem';
		private int DEMON_HUNTER_M = 'Edmm';
		private int KEEPER = 'Ekee';
		private int MOON_CHICK = 'Emoo';
		private int MOON_BABE = MOON_CHICK;
		private int MOON_HONEY = MOON_CHICK;
		private int WARDEN = 'Ewar';
		// special elf heroes
		private int SYLVANUS = 'Hvwd';
		private int CENARIUS = 'Ecen';
		private int ILLIDAN = 'Eevi';
		private int ILLIDAN_DEMON = 'Eevm';
		private int MAIEV = 'Ewrd';
		// elf hero abilities
		private int FORCE_NATURE = 'AEfn';
		private int ENT_ROOTS = 'AEer';
		private int THORNS_AURA = 'AEah';
		private int TRANQUILITY = 'AEtq';
		private int EVASION = 'AEev';
		private int IMMOLATION = 'AEim';
		private int MANA_BURN = 'AEmb';
		private int METAMORPHOSIS = 'AEme';
		private int SEARING_ARROWS = 'AHfa';
		private int SCOUT = 'AEst';
		private int STARFALL = 'AEsf';
		private int TRUESHOT = 'AEar';
		private int BLINK = 'AEbl';
		private int FAN_KNIVES = 'AEfk';
		private int SHADOW_TOUCH = 'AEsh';
		private int VENGEANCE = 'AEsv';
		// elf units
		private int WISP = 'ewsp';
		private int ARCHER = 'earc';
		private int DRUID_TALON = 'edot';
		private int DRUID_TALON_M = 'edtm';
		private int BALLISTA = 'ebal';
		private int DRUID_CLAW = 'edoc';
		private int DRUID_CLAW_M = 'edcm';
		private int DRYAD = 'edry';
		private int HIPPO = 'ehip';
		private int HIPPO_RIDER = 'ehpr';
		private int HUNTRESS = 'esen';
		private int CHIMAERA = 'echm';
		private int ENT = 'efon';
		private int MOUNTAIN_GIANT = 'emtg';
		private int FAERIE_DRAGON = 'efdr';
		// special elf units
		private int HIGH_ARCHER = 'nhea';
		private int HIGH_FOOTMAN = 'hcth';
		private int HIGH_FOOTMEN = HIGH_FOOTMAN;
		private int HIGH_SWORDMAN = 'hhes';
		private int DRAGON_HAWK = 'nws1';
		private int CORRUPT_TREANT = 'nenc';
		private int POISON_TREANT = 'nenp';
		private int PLAGUE_TREANT = 'nepl';
		private int SHANDRIS = 'eshd';
		// elf buildings
		private int ANCIENT_LORE = 'eaoe';
		private int ANCIENT_WAR = 'eaom';
		private int ANCIENT_WIND = 'eaow';
		private int TREE_AGES = 'etoa';
		private int TREE_ETERNITY = 'etoe';
		private int TREE_LIFE = 'etol';
		private int ANCIENT_PROTECT = 'etrp';
		private int ELF_ALTAR = 'eate';
		private int BEAR_DEN = 'edol';
		private int CHIMAERA_ROOST = 'edos';
		private int HUNTERS_HALL = 'edob';
		private int MOON_WELL = 'emow';
		private int ELF_MINE = 'egol';
		private int DEN_OF_WONDERS = 'eden';
		// special elf buildings
		private int ELF_FARM = 'nefm';
		private int ELF_GUARD_TOWER = 'negt';
		private int HIGH_SKY = 'negm';
		private int HIGH_EARTH = 'negf';
		private int HIGH_TOWER = 'negt';
		private int ELF_HIGH_BARRACKS = 'nheb';
		private int CORRUPT_LIFE = 'nctl';
		private int CORRUPT_WELL = 'ncmw';
		private int CORRUPT_PROTECTOR = 'ncap';
		private int CORRUPT_WAR = 'ncaw';
		// elf upgrades
		private int UPG_STR_MOON = 'Resm';
		private int UPG_STR_WILD = 'Resw';
		private int UPG_MOON_ARMOR = 'Rema';
		private int UPG_HIDES = 'Rerh';
		private int UPG_ULTRAVISION = 'Reuv';
		private int UPG_BLESSING = 'Renb';
		private int UPG_SCOUT = 'Resc';
		private int UPG_GLAIVE = 'Remg';
		private int UPG_BOWS = 'Reib';
		private int UPG_MARKSMAN = 'Remk';
		private int UPG_DRUID_TALON = 'Redt';
		private int UPG_DRUID_CLAW = 'Redc';
		private int UPG_ABOLISH = 'Resi';
		private int UPG_CHIM_ACID = 'Recb';
		private int UPG_HIPPO_TAME = 'Reht';
		private int UPG_BOLT = 'Repd';
		private int UPG_MARK_CLAW = 'Reeb';
		private int UPG_MARK_TALON = 'Reec';
		private int UPG_HARD_SKIN = 'Rehs';
		private int UPG_RESIST_SKIN = 'Rers';
		private int UPG_WELL_SPRING = 'Rews';
		//--------------------------------------------------------------------
		// Neutral
		//--------------------------------------------------------------------
		private int DEMON_GATE = 'ndmg';
		private int FELLHOUND = 'nfel';
		private int INFERNAL = 'ninf';
		private int DOOMGUARD = 'nbal';
		private int SATYR = 'nsty';
		private int TRICKSTER = 'nsat';
		private int SHADOWDANCER = 'nsts';
		private int SOULSTEALER = 'nstl';
		private int HELLCALLER = 'nsth';
		private int SKEL_ARCHER = 'nska';
		private int SKEL_MARKSMAN = 'nskm';
		private int SKEL_BURNING = 'nskf';
		private int SKEL_GIANT = 'nskg';
		private int FURBOLG = 'nfrl';
		private int FURBOLG_TRACKER = 'nfrb';
		private int FURBOLG_SHAMAN = 'nfrs';
		private int FURBOLG_CHAMP = 'nfrg';
		private int FURBOLG_ELDER = 'nfre';
		//--------------------------------------------------------------------
		// NAGA
		//--------------------------------------------------------------------
		// naga heroes
		private int NAGA_SORCERESS = 'Nngs';
		private int NAGA_VASHJ = 'Hvsh';
		// naga units
		private int NAGA_DRAGON = 'nsnp';// old names
		private int NAGA_WITCH = 'nnsw';
		private int NAGA_SERPENT = 'nwgs';
		private int NAGA_HYDRA = 'nhyc';
		private int NAGA_SLAVE = 'nmpe';// peon
		private int NAGA_SNAP_DRAGON = NAGA_DRAGON;// weak ranged
		private int NAGA_COUATL = NAGA_SERPENT;// weak air
		private int NAGA_SIREN = NAGA_WITCH;// caster
		private int NAGA_MYRMIDON = 'nmyr';// knight
		private int NAGA_REAVER = 'nnmg';// footman
		private int NAGA_TURTLE = NAGA_HYDRA;// siege
		private int NAGA_ROYAL = 'nnrg';// royal guard
		// naga buildings
		private int NAGA_TEMPLE = 'nntt';// town hall
		private int NAGA_CORAL = 'nnfm';// farm
		private int NAGA_SHRINE = 'nnsa';// sirens & couatls
		private int NAGA_SPAWNING = 'nnsg';// myrm, snap dragon, hydra
		private int NAGA_GUARDIAN = 'nntg';// tower
		private int NAGA_ALTAR = 'nnad';// altar
		// naga upgrades
		private int UPG_NAGA_ARMOR = 'Rnam';
		private int UPG_NAGA_ATTACK = 'Rnat';
		private int UPG_NAGA_ABOLISH = 'Rnsi';
		private int UPG_SIREN = 'Rnsw';
		private int UPG_NAGA_ENSNARE = 'Rnen';
		//--------------------------------------------------------------------
		private int M1 = 60;
		private int M2 = 2*60;
		private int M3 = 3*60;
		private int M4 = 4*60;
		private int M5 = 5*60;
		private int M6 = 6*60;
		private int M7 = 7*60;
		private int M8 = 8*60;
		private int M9 = 9*60;
		private int M10 = 10*60;
		private int M11 = 11*60;
		private int M12 = 12*60;
		private int M13 = 13*60;
		private int M14 = 14*60;
		private int M15 = 15*60;
		private int EASY = 1;
		private int NORMAL = 2;
		private int HARD = 3;
		private int INSANE = 4;// not used
		private int MELEE_NEWBIE = 1;
		private int MELEE_NORMAL = 2;
		private int MELEE_INSANE = 3;
		private int ATTACK_CAPTAIN = 1;
		private int DEFENSE_CAPTAIN = 2;
		private int BOTH_CAPTAINS = 3;
		private int BUILD_UNIT = 1;
		private int BUILD_UPGRADE = 2;
		private int BUILD_EXPAND = 3;
		private int UPKEEP_TIER1 = 50;
		private int UPKEEP_TIER2 = 80;
		//--------------------------------------------------------------------
		private player ai_player;
		private int sleep_seconds;
		private int total_gold = 0;
		private int total_wood = 0;
		private int gold_buffer = 0;// usually for potion money
		private int difficulty = NORMAL;
		private int exp_seen = 0;
		private int racial_farm = 'hhou';
		private int hero_id = 'Hamg';
		private int hero_id2 = 'Hmkg';
		private int hero_id3 = 'Hpal';
		private int[]skill;
		private int[]skills1;
		private int[]skills2;
		private int[]skills3;
		private int max_hero_level = 0;
		private int[]harass_qty;
		private int[]harass_max;
		private int[]harass_units;
		private int harass_length = 0;
		private int[]defense_qty;
		private int[]defense_units;
		private int defense_length = 0;
		private int[]build_qty;
		private int[]build_type;
		private int[]build_item;
		private int[]build_town;
		private int build_length = 0;
		private int campaign_gold_peons = 5;
		private int campaign_wood_peons = 3;
		private int campaign_basics_speed = 5;
		private int min_creeps = -1;
		private int max_creeps = -1;
		private bool harvest_town1 = true;
		private bool harvest_town2 = true;
		private bool harvest_town3 = true;
		private bool do_campaign_farms = true;
		private bool two_heroes = false;
		private bool allow_air_creeps = false;
		private bool take_exp = false;
		private bool allow_signal_abort = false;
		private bool ready_for_zeppelin = true;
		private bool get_zeppelin = false;
		private bool build_campaign_attackers = true;
		private bool do_debug_cheats = false;
		private bool trace_on = true;
		private bool zep_next_wave = false;
		private bool form_group_timeouts = true;

	
	}
}

