using System;
using System.Collections.Generic;

namespace Jass {

	/* global constant */
	public class Globals {

		//
		//
		//
		//
		private real bj_PI = 3.14159;//constant real      bj_PI                            = 3.14159
		private real bj_E = 2.71828;//constant real      bj_E                             = 2.71828
		private real bj_CELLWIDTH = 128.0;//constant real      bj_CELLWIDTH                     = 128.0
		private real bj_CLIFFHEIGHT = 128.0;//constant real      bj_CLIFFHEIGHT                   = 128.0
		private real bj_UNIT_FACING = 270.0;//constant real      bj_UNIT_FACING                   = 270.0
		private real bj_RADTODEG = 180.0/bj_PI;//constant real      bj_RADTODEG                      = 180.0/bj_PI
		private real bj_DEGTORAD = bj_PI/180.0;//constant real      bj_DEGTORAD                      = bj_PI/180.0
		private real bj_TEXT_DELAY_QUEST = 20.00;//constant real      bj_TEXT_DELAY_QUEST              = 20.00
		private real bj_TEXT_DELAY_QUESTUPDATE = 20.00;//constant real      bj_TEXT_DELAY_QUESTUPDATE        = 20.00
		private real bj_TEXT_DELAY_QUESTDONE = 20.00;//constant real      bj_TEXT_DELAY_QUESTDONE          = 20.00
		private real bj_TEXT_DELAY_QUESTFAILED = 20.00;//constant real      bj_TEXT_DELAY_QUESTFAILED        = 20.00
		private real bj_TEXT_DELAY_QUESTREQUIREMENT = 20.00;//constant real      bj_TEXT_DELAY_QUESTREQUIREMENT   = 20.00
		private real bj_TEXT_DELAY_MISSIONFAILED = 20.00;//constant real      bj_TEXT_DELAY_MISSIONFAILED      = 20.00
		private real bj_TEXT_DELAY_ALWAYSHINT = 12.00;//constant real      bj_TEXT_DELAY_ALWAYSHINT         = 12.00
		private real bj_TEXT_DELAY_HINT = 12.00;//constant real      bj_TEXT_DELAY_HINT               = 12.00
		private real bj_TEXT_DELAY_SECRET = 10.00;//constant real      bj_TEXT_DELAY_SECRET             = 10.00
		private real bj_TEXT_DELAY_UNITACQUIRED = 15.00;//constant real      bj_TEXT_DELAY_UNITACQUIRED       = 15.00
		private real bj_TEXT_DELAY_UNITAVAILABLE = 10.00;//constant real      bj_TEXT_DELAY_UNITAVAILABLE      = 10.00
		private real bj_TEXT_DELAY_ITEMACQUIRED = 10.00;//constant real      bj_TEXT_DELAY_ITEMACQUIRED       = 10.00
		private real bj_TEXT_DELAY_WARNING = 12.00;//constant real      bj_TEXT_DELAY_WARNING            = 12.00
		private real bj_QUEUE_DELAY_QUEST = 5.00;//constant real      bj_QUEUE_DELAY_QUEST             =  5.00
		private real bj_QUEUE_DELAY_HINT = 5.00;//constant real      bj_QUEUE_DELAY_HINT              =  5.00
		private real bj_QUEUE_DELAY_SECRET = 3.00;//constant real      bj_QUEUE_DELAY_SECRET            =  3.00
		private real bj_HANDICAP_EASY = 60.00;//constant real      bj_HANDICAP_EASY                 = 60.00
		private real bj_GAME_STARTED_THRESHOLD = 0.01;//constant real      bj_GAME_STARTED_THRESHOLD        =  0.01
		private real bj_WAIT_FOR_COND_MIN_INTERVAL = 0.10;//constant real      bj_WAIT_FOR_COND_MIN_INTERVAL    =  0.10
		private real bj_POLLED_WAIT_INTERVAL = 0.10;//constant real      bj_POLLED_WAIT_INTERVAL          =  0.10
		private real bj_POLLED_WAIT_SKIP_THRESHOLD = 2.00;//constant real      bj_POLLED_WAIT_SKIP_THRESHOLD    =  2.00
		//
		private int bj_MAX_INVENTORY = 6;//constant integer   bj_MAX_INVENTORY                 =   6
		private int bj_MAX_PLAYERS = 12;//constant integer   bj_MAX_PLAYERS                   =  12
		private int bj_PLAYER_NEUTRAL_VICTIM = 13;//constant integer   bj_PLAYER_NEUTRAL_VICTIM         =  13
		private int bj_PLAYER_NEUTRAL_EXTRA = 14;//constant integer   bj_PLAYER_NEUTRAL_EXTRA          =  14
		private int bj_MAX_PLAYER_SLOTS = 16;//constant integer   bj_MAX_PLAYER_SLOTS              =  16
		private int bj_MAX_SKELETONS = 25;//constant integer   bj_MAX_SKELETONS                 =  25
		private int bj_MAX_STOCK_ITEM_SLOTS = 11;//constant integer   bj_MAX_STOCK_ITEM_SLOTS          =  11
		private int bj_MAX_STOCK_UNIT_SLOTS = 11;//constant integer   bj_MAX_STOCK_UNIT_SLOTS          =  11
		private int bj_MAX_ITEM_LEVEL = 10;//constant integer   bj_MAX_ITEM_LEVEL                =  10
		//
		//
		private real bj_TOD_DAWN = 6.00;//constant real      bj_TOD_DAWN                      = 6.00
		private real bj_TOD_DUSK = 18.00;//constant real      bj_TOD_DUSK                      = 18.00
		//
		//
		//
		//
		//
		//
		//
		//
		//
		private real bj_MELEE_STARTING_TOD = 8.00;//constant real      bj_MELEE_STARTING_TOD            = 8.00
		private int bj_MELEE_STARTING_GOLD_V0 = 750;//constant integer   bj_MELEE_STARTING_GOLD_V0        = 750
		private int bj_MELEE_STARTING_GOLD_V1 = 500;//constant integer   bj_MELEE_STARTING_GOLD_V1        = 500
		private int bj_MELEE_STARTING_LUMBER_V0 = 200;//constant integer   bj_MELEE_STARTING_LUMBER_V0      = 200
		private int bj_MELEE_STARTING_LUMBER_V1 = 150;//constant integer   bj_MELEE_STARTING_LUMBER_V1      = 150
		private int bj_MELEE_STARTING_HERO_TOKENS = 1;//constant integer   bj_MELEE_STARTING_HERO_TOKENS    = 1
		private int bj_MELEE_HERO_LIMIT = 3;//constant integer   bj_MELEE_HERO_LIMIT              = 3
		private int bj_MELEE_HERO_TYPE_LIMIT = 1;//constant integer   bj_MELEE_HERO_TYPE_LIMIT         = 1
		private real bj_MELEE_MINE_SEARCH_RADIUS = 2000;//constant real      bj_MELEE_MINE_SEARCH_RADIUS      = 2000
		private real bj_MELEE_CLEAR_UNITS_RADIUS = 1500;//constant real      bj_MELEE_CLEAR_UNITS_RADIUS      = 1500
		private real bj_MELEE_CRIPPLE_TIMEOUT = 120.00;//constant real      bj_MELEE_CRIPPLE_TIMEOUT         = 120.00
		private real bj_MELEE_CRIPPLE_MSG_DURATION = 20.00;//constant real      bj_MELEE_CRIPPLE_MSG_DURATION    = 20.00
		private int bj_MELEE_MAX_TWINKED_HEROES_V0 = 3;//constant integer   bj_MELEE_MAX_TWINKED_HEROES_V0   = 3
		private int bj_MELEE_MAX_TWINKED_HEROES_V1 = 1;//constant integer   bj_MELEE_MAX_TWINKED_HEROES_V1   = 1
		//
		private real bj_CREEP_ITEM_DELAY = 0.50;//constant real      bj_CREEP_ITEM_DELAY              = 0.50
		//
		private real bj_STOCK_RESTOCK_INITIAL_DELAY = 120;//constant real      bj_STOCK_RESTOCK_INITIAL_DELAY   = 120
		private real bj_STOCK_RESTOCK_INTERVAL = 30;//constant real      bj_STOCK_RESTOCK_INTERVAL        = 30
		private int bj_STOCK_MAX_ITERATIONS = 20;//constant integer   bj_STOCK_MAX_ITERATIONS          = 20
		//
		private int bj_MAX_DEST_IN_REGION_EVENTS = 64;//constant integer   bj_MAX_DEST_IN_REGION_EVENTS     = 64
		//
		private int bj_CAMERA_MIN_FARZ = 100;//constant integer   bj_CAMERA_MIN_FARZ               = 100
		private int bj_CAMERA_DEFAULT_DISTANCE = 1650;//constant integer   bj_CAMERA_DEFAULT_DISTANCE       = 1650
		private int bj_CAMERA_DEFAULT_FARZ = 5000;//constant integer   bj_CAMERA_DEFAULT_FARZ           = 5000
		private int bj_CAMERA_DEFAULT_AOA = 304;//constant integer   bj_CAMERA_DEFAULT_AOA            = 304
		private int bj_CAMERA_DEFAULT_FOV = 70;//constant integer   bj_CAMERA_DEFAULT_FOV            = 70
		private int bj_CAMERA_DEFAULT_ROLL = 0;//constant integer   bj_CAMERA_DEFAULT_ROLL           = 0
		private int bj_CAMERA_DEFAULT_ROTATION = 90;//constant integer   bj_CAMERA_DEFAULT_ROTATION       = 90
		//
		private real bj_RESCUE_PING_TIME = 2.00;//constant real      bj_RESCUE_PING_TIME              = 2.00
		//
		private real bj_NOTHING_SOUND_DURATION = 5.00;//constant real      bj_NOTHING_SOUND_DURATION        = 5.00
		private real bj_TRANSMISSION_PING_TIME = 1.00;//constant real      bj_TRANSMISSION_PING_TIME        = 1.00
		private int bj_TRANSMISSION_IND_RED = 255;//constant integer   bj_TRANSMISSION_IND_RED          = 255
		private int bj_TRANSMISSION_IND_BLUE = 255;//constant integer   bj_TRANSMISSION_IND_BLUE         = 255
		private int bj_TRANSMISSION_IND_GREEN = 255;//constant integer   bj_TRANSMISSION_IND_GREEN        = 255
		private int bj_TRANSMISSION_IND_ALPHA = 255;//constant integer   bj_TRANSMISSION_IND_ALPHA        = 255
		private real bj_TRANSMISSION_PORT_HANGTIME = 1.50;//constant real      bj_TRANSMISSION_PORT_HANGTIME    = 1.50
		//
		private real bj_CINEMODE_INTERFACEFADE = 0.50;//constant real      bj_CINEMODE_INTERFACEFADE        = 0.50
		private gamespeed bj_CINEMODE_GAMESPEED = MAP_SPEED_NORMAL;//constant gamespeed bj_CINEMODE_GAMESPEED            = MAP_SPEED_NORMAL
		//
		private real bj_CINEMODE_VOLUME_UNITMOVEMENT = 0.40;//constant real      bj_CINEMODE_VOLUME_UNITMOVEMENT  = 0.40
		private real bj_CINEMODE_VOLUME_UNITSOUNDS = 0.00;//constant real      bj_CINEMODE_VOLUME_UNITSOUNDS    = 0.00
		private real bj_CINEMODE_VOLUME_COMBAT = 0.40;//constant real      bj_CINEMODE_VOLUME_COMBAT        = 0.40
		private real bj_CINEMODE_VOLUME_SPELLS = 0.40;//constant real      bj_CINEMODE_VOLUME_SPELLS        = 0.40
		private real bj_CINEMODE_VOLUME_UI = 0.00;//constant real      bj_CINEMODE_VOLUME_UI            = 0.00
		private real bj_CINEMODE_VOLUME_MUSIC = 0.55;//constant real      bj_CINEMODE_VOLUME_MUSIC         = 0.55
		private real bj_CINEMODE_VOLUME_AMBIENTSOUNDS = 1.00;//constant real      bj_CINEMODE_VOLUME_AMBIENTSOUNDS = 1.00
		private real bj_CINEMODE_VOLUME_FIRE = 0.60;//constant real      bj_CINEMODE_VOLUME_FIRE          = 0.60
		//
		private real bj_SPEECH_VOLUME_UNITMOVEMENT = 0.25;//constant real      bj_SPEECH_VOLUME_UNITMOVEMENT    = 0.25
		private real bj_SPEECH_VOLUME_UNITSOUNDS = 0.00;//constant real      bj_SPEECH_VOLUME_UNITSOUNDS      = 0.00
		private real bj_SPEECH_VOLUME_COMBAT = 0.25;//constant real      bj_SPEECH_VOLUME_COMBAT          = 0.25
		private real bj_SPEECH_VOLUME_SPELLS = 0.25;//constant real      bj_SPEECH_VOLUME_SPELLS          = 0.25
		private real bj_SPEECH_VOLUME_UI = 0.00;//constant real      bj_SPEECH_VOLUME_UI              = 0.00
		private real bj_SPEECH_VOLUME_MUSIC = 0.55;//constant real      bj_SPEECH_VOLUME_MUSIC           = 0.55
		private real bj_SPEECH_VOLUME_AMBIENTSOUNDS = 1.00;//constant real      bj_SPEECH_VOLUME_AMBIENTSOUNDS   = 1.00
		private real bj_SPEECH_VOLUME_FIRE = 0.60;//constant real      bj_SPEECH_VOLUME_FIRE            = 0.60
		//
		private real bj_SMARTPAN_TRESHOLD_PAN = 500;//constant real      bj_SMARTPAN_TRESHOLD_PAN         = 500
		private real bj_SMARTPAN_TRESHOLD_SNAP = 3500;//constant real      bj_SMARTPAN_TRESHOLD_SNAP        = 3500
		//
		private int bj_MAX_QUEUED_TRIGGERS = 100;//constant integer   bj_MAX_QUEUED_TRIGGERS           = 100
		private real bj_QUEUED_TRIGGER_TIMEOUT = 180.00;//constant real      bj_QUEUED_TRIGGER_TIMEOUT        = 180.00
		//
		private int bj_CAMPAIGN_INDEX_T = 0;//constant integer   bj_CAMPAIGN_INDEX_T        = 0
		private int bj_CAMPAIGN_INDEX_H = 1;//constant integer   bj_CAMPAIGN_INDEX_H        = 1
		private int bj_CAMPAIGN_INDEX_U = 2;//constant integer   bj_CAMPAIGN_INDEX_U        = 2
		private int bj_CAMPAIGN_INDEX_O = 3;//constant integer   bj_CAMPAIGN_INDEX_O        = 3
		private int bj_CAMPAIGN_INDEX_N = 4;//constant integer   bj_CAMPAIGN_INDEX_N        = 4
		private int bj_CAMPAIGN_INDEX_XN = 5;//constant integer   bj_CAMPAIGN_INDEX_XN       = 5
		private int bj_CAMPAIGN_INDEX_XH = 6;//constant integer   bj_CAMPAIGN_INDEX_XH       = 6
		private int bj_CAMPAIGN_INDEX_XU = 7;//constant integer   bj_CAMPAIGN_INDEX_XU       = 7
		private int bj_CAMPAIGN_INDEX_XO = 8;//constant integer   bj_CAMPAIGN_INDEX_XO       = 8
		//
		private int bj_CAMPAIGN_OFFSET_T = 0;//constant integer   bj_CAMPAIGN_OFFSET_T       = 0
		private int bj_CAMPAIGN_OFFSET_H = 1;//constant integer   bj_CAMPAIGN_OFFSET_H       = 1
		private int bj_CAMPAIGN_OFFSET_U = 2;//constant integer   bj_CAMPAIGN_OFFSET_U       = 2
		private int bj_CAMPAIGN_OFFSET_O = 3;//constant integer   bj_CAMPAIGN_OFFSET_O       = 3
		private int bj_CAMPAIGN_OFFSET_N = 4;//constant integer   bj_CAMPAIGN_OFFSET_N       = 4
		private int bj_CAMPAIGN_OFFSET_XN = 0;//constant integer   bj_CAMPAIGN_OFFSET_XN      = 0
		private int bj_CAMPAIGN_OFFSET_XH = 1;//constant integer   bj_CAMPAIGN_OFFSET_XH      = 1
		private int bj_CAMPAIGN_OFFSET_XU = 2;//constant integer   bj_CAMPAIGN_OFFSET_XU      = 2
		private int bj_CAMPAIGN_OFFSET_XO = 3;//constant integer   bj_CAMPAIGN_OFFSET_XO      = 3
		//
		//
		private int bj_MISSION_INDEX_T00 = bj_CAMPAIGN_OFFSET_T * 1000 + 0;//constant integer   bj_MISSION_INDEX_T00       = bj_CAMPAIGN_OFFSET_T * 1000 + 0
		private int bj_MISSION_INDEX_T01 = bj_CAMPAIGN_OFFSET_T * 1000 + 1;//constant integer   bj_MISSION_INDEX_T01       = bj_CAMPAIGN_OFFSET_T * 1000 + 1
		//
		private int bj_MISSION_INDEX_H00 = bj_CAMPAIGN_OFFSET_H * 1000 + 0;//constant integer   bj_MISSION_INDEX_H00       = bj_CAMPAIGN_OFFSET_H * 1000 + 0
		private int bj_MISSION_INDEX_H01 = bj_CAMPAIGN_OFFSET_H * 1000 + 1;//constant integer   bj_MISSION_INDEX_H01       = bj_CAMPAIGN_OFFSET_H * 1000 + 1
		private int bj_MISSION_INDEX_H02 = bj_CAMPAIGN_OFFSET_H * 1000 + 2;//constant integer   bj_MISSION_INDEX_H02       = bj_CAMPAIGN_OFFSET_H * 1000 + 2
		private int bj_MISSION_INDEX_H03 = bj_CAMPAIGN_OFFSET_H * 1000 + 3;//constant integer   bj_MISSION_INDEX_H03       = bj_CAMPAIGN_OFFSET_H * 1000 + 3
		private int bj_MISSION_INDEX_H04 = bj_CAMPAIGN_OFFSET_H * 1000 + 4;//constant integer   bj_MISSION_INDEX_H04       = bj_CAMPAIGN_OFFSET_H * 1000 + 4
		private int bj_MISSION_INDEX_H05 = bj_CAMPAIGN_OFFSET_H * 1000 + 5;//constant integer   bj_MISSION_INDEX_H05       = bj_CAMPAIGN_OFFSET_H * 1000 + 5
		private int bj_MISSION_INDEX_H06 = bj_CAMPAIGN_OFFSET_H * 1000 + 6;//constant integer   bj_MISSION_INDEX_H06       = bj_CAMPAIGN_OFFSET_H * 1000 + 6
		private int bj_MISSION_INDEX_H07 = bj_CAMPAIGN_OFFSET_H * 1000 + 7;//constant integer   bj_MISSION_INDEX_H07       = bj_CAMPAIGN_OFFSET_H * 1000 + 7
		private int bj_MISSION_INDEX_H08 = bj_CAMPAIGN_OFFSET_H * 1000 + 8;//constant integer   bj_MISSION_INDEX_H08       = bj_CAMPAIGN_OFFSET_H * 1000 + 8
		private int bj_MISSION_INDEX_H09 = bj_CAMPAIGN_OFFSET_H * 1000 + 9;//constant integer   bj_MISSION_INDEX_H09       = bj_CAMPAIGN_OFFSET_H * 1000 + 9
		private int bj_MISSION_INDEX_H10 = bj_CAMPAIGN_OFFSET_H * 1000 + 10;//constant integer   bj_MISSION_INDEX_H10       = bj_CAMPAIGN_OFFSET_H * 1000 + 10
		private int bj_MISSION_INDEX_H11 = bj_CAMPAIGN_OFFSET_H * 1000 + 11;//constant integer   bj_MISSION_INDEX_H11       = bj_CAMPAIGN_OFFSET_H * 1000 + 11
		//
		private int bj_MISSION_INDEX_U00 = bj_CAMPAIGN_OFFSET_U * 1000 + 0;//constant integer   bj_MISSION_INDEX_U00       = bj_CAMPAIGN_OFFSET_U * 1000 + 0
		private int bj_MISSION_INDEX_U01 = bj_CAMPAIGN_OFFSET_U * 1000 + 1;//constant integer   bj_MISSION_INDEX_U01       = bj_CAMPAIGN_OFFSET_U * 1000 + 1
		private int bj_MISSION_INDEX_U02 = bj_CAMPAIGN_OFFSET_U * 1000 + 2;//constant integer   bj_MISSION_INDEX_U02       = bj_CAMPAIGN_OFFSET_U * 1000 + 2
		private int bj_MISSION_INDEX_U03 = bj_CAMPAIGN_OFFSET_U * 1000 + 3;//constant integer   bj_MISSION_INDEX_U03       = bj_CAMPAIGN_OFFSET_U * 1000 + 3
		private int bj_MISSION_INDEX_U05 = bj_CAMPAIGN_OFFSET_U * 1000 + 4;//constant integer   bj_MISSION_INDEX_U05       = bj_CAMPAIGN_OFFSET_U * 1000 + 4
		private int bj_MISSION_INDEX_U07 = bj_CAMPAIGN_OFFSET_U * 1000 + 5;//constant integer   bj_MISSION_INDEX_U07       = bj_CAMPAIGN_OFFSET_U * 1000 + 5
		private int bj_MISSION_INDEX_U08 = bj_CAMPAIGN_OFFSET_U * 1000 + 6;//constant integer   bj_MISSION_INDEX_U08       = bj_CAMPAIGN_OFFSET_U * 1000 + 6
		private int bj_MISSION_INDEX_U09 = bj_CAMPAIGN_OFFSET_U * 1000 + 7;//constant integer   bj_MISSION_INDEX_U09       = bj_CAMPAIGN_OFFSET_U * 1000 + 7
		private int bj_MISSION_INDEX_U10 = bj_CAMPAIGN_OFFSET_U * 1000 + 8;//constant integer   bj_MISSION_INDEX_U10       = bj_CAMPAIGN_OFFSET_U * 1000 + 8
		private int bj_MISSION_INDEX_U11 = bj_CAMPAIGN_OFFSET_U * 1000 + 9;//constant integer   bj_MISSION_INDEX_U11       = bj_CAMPAIGN_OFFSET_U * 1000 + 9
		//
		private int bj_MISSION_INDEX_O00 = bj_CAMPAIGN_OFFSET_O * 1000 + 0;//constant integer   bj_MISSION_INDEX_O00       = bj_CAMPAIGN_OFFSET_O * 1000 + 0
		private int bj_MISSION_INDEX_O01 = bj_CAMPAIGN_OFFSET_O * 1000 + 1;//constant integer   bj_MISSION_INDEX_O01       = bj_CAMPAIGN_OFFSET_O * 1000 + 1
		private int bj_MISSION_INDEX_O02 = bj_CAMPAIGN_OFFSET_O * 1000 + 2;//constant integer   bj_MISSION_INDEX_O02       = bj_CAMPAIGN_OFFSET_O * 1000 + 2
		private int bj_MISSION_INDEX_O03 = bj_CAMPAIGN_OFFSET_O * 1000 + 3;//constant integer   bj_MISSION_INDEX_O03       = bj_CAMPAIGN_OFFSET_O * 1000 + 3
		private int bj_MISSION_INDEX_O04 = bj_CAMPAIGN_OFFSET_O * 1000 + 4;//constant integer   bj_MISSION_INDEX_O04       = bj_CAMPAIGN_OFFSET_O * 1000 + 4
		private int bj_MISSION_INDEX_O05 = bj_CAMPAIGN_OFFSET_O * 1000 + 5;//constant integer   bj_MISSION_INDEX_O05       = bj_CAMPAIGN_OFFSET_O * 1000 + 5
		private int bj_MISSION_INDEX_O06 = bj_CAMPAIGN_OFFSET_O * 1000 + 6;//constant integer   bj_MISSION_INDEX_O06       = bj_CAMPAIGN_OFFSET_O * 1000 + 6
		private int bj_MISSION_INDEX_O07 = bj_CAMPAIGN_OFFSET_O * 1000 + 7;//constant integer   bj_MISSION_INDEX_O07       = bj_CAMPAIGN_OFFSET_O * 1000 + 7
		private int bj_MISSION_INDEX_O08 = bj_CAMPAIGN_OFFSET_O * 1000 + 8;//constant integer   bj_MISSION_INDEX_O08       = bj_CAMPAIGN_OFFSET_O * 1000 + 8
		private int bj_MISSION_INDEX_O09 = bj_CAMPAIGN_OFFSET_O * 1000 + 9;//constant integer   bj_MISSION_INDEX_O09       = bj_CAMPAIGN_OFFSET_O * 1000 + 9
		private int bj_MISSION_INDEX_O10 = bj_CAMPAIGN_OFFSET_O * 1000 + 10;//constant integer   bj_MISSION_INDEX_O10       = bj_CAMPAIGN_OFFSET_O * 1000 + 10
		//
		private int bj_MISSION_INDEX_N00 = bj_CAMPAIGN_OFFSET_N * 1000 + 0;//constant integer   bj_MISSION_INDEX_N00       = bj_CAMPAIGN_OFFSET_N * 1000 + 0
		private int bj_MISSION_INDEX_N01 = bj_CAMPAIGN_OFFSET_N * 1000 + 1;//constant integer   bj_MISSION_INDEX_N01       = bj_CAMPAIGN_OFFSET_N * 1000 + 1
		private int bj_MISSION_INDEX_N02 = bj_CAMPAIGN_OFFSET_N * 1000 + 2;//constant integer   bj_MISSION_INDEX_N02       = bj_CAMPAIGN_OFFSET_N * 1000 + 2
		private int bj_MISSION_INDEX_N03 = bj_CAMPAIGN_OFFSET_N * 1000 + 3;//constant integer   bj_MISSION_INDEX_N03       = bj_CAMPAIGN_OFFSET_N * 1000 + 3
		private int bj_MISSION_INDEX_N04 = bj_CAMPAIGN_OFFSET_N * 1000 + 4;//constant integer   bj_MISSION_INDEX_N04       = bj_CAMPAIGN_OFFSET_N * 1000 + 4
		private int bj_MISSION_INDEX_N05 = bj_CAMPAIGN_OFFSET_N * 1000 + 5;//constant integer   bj_MISSION_INDEX_N05       = bj_CAMPAIGN_OFFSET_N * 1000 + 5
		private int bj_MISSION_INDEX_N06 = bj_CAMPAIGN_OFFSET_N * 1000 + 6;//constant integer   bj_MISSION_INDEX_N06       = bj_CAMPAIGN_OFFSET_N * 1000 + 6
		private int bj_MISSION_INDEX_N07 = bj_CAMPAIGN_OFFSET_N * 1000 + 7;//constant integer   bj_MISSION_INDEX_N07       = bj_CAMPAIGN_OFFSET_N * 1000 + 7
		private int bj_MISSION_INDEX_N08 = bj_CAMPAIGN_OFFSET_N * 1000 + 8;//constant integer   bj_MISSION_INDEX_N08       = bj_CAMPAIGN_OFFSET_N * 1000 + 8
		private int bj_MISSION_INDEX_N09 = bj_CAMPAIGN_OFFSET_N * 1000 + 9;//constant integer   bj_MISSION_INDEX_N09       = bj_CAMPAIGN_OFFSET_N * 1000 + 9
		//
		private int bj_MISSION_INDEX_XN00 = bj_CAMPAIGN_OFFSET_XN * 1000 + 0;//constant integer   bj_MISSION_INDEX_XN00       = bj_CAMPAIGN_OFFSET_XN * 1000 + 0
		private int bj_MISSION_INDEX_XN01 = bj_CAMPAIGN_OFFSET_XN * 1000 + 1;//constant integer   bj_MISSION_INDEX_XN01       = bj_CAMPAIGN_OFFSET_XN * 1000 + 1
		private int bj_MISSION_INDEX_XN02 = bj_CAMPAIGN_OFFSET_XN * 1000 + 2;//constant integer   bj_MISSION_INDEX_XN02       = bj_CAMPAIGN_OFFSET_XN * 1000 + 2
		private int bj_MISSION_INDEX_XN03 = bj_CAMPAIGN_OFFSET_XN * 1000 + 3;//constant integer   bj_MISSION_INDEX_XN03       = bj_CAMPAIGN_OFFSET_XN * 1000 + 3
		private int bj_MISSION_INDEX_XN04 = bj_CAMPAIGN_OFFSET_XN * 1000 + 4;//constant integer   bj_MISSION_INDEX_XN04       = bj_CAMPAIGN_OFFSET_XN * 1000 + 4
		private int bj_MISSION_INDEX_XN05 = bj_CAMPAIGN_OFFSET_XN * 1000 + 5;//constant integer   bj_MISSION_INDEX_XN05       = bj_CAMPAIGN_OFFSET_XN * 1000 + 5
		private int bj_MISSION_INDEX_XN06 = bj_CAMPAIGN_OFFSET_XN * 1000 + 6;//constant integer   bj_MISSION_INDEX_XN06       = bj_CAMPAIGN_OFFSET_XN * 1000 + 6
		private int bj_MISSION_INDEX_XN07 = bj_CAMPAIGN_OFFSET_XN * 1000 + 7;//constant integer   bj_MISSION_INDEX_XN07       = bj_CAMPAIGN_OFFSET_XN * 1000 + 7
		private int bj_MISSION_INDEX_XN08 = bj_CAMPAIGN_OFFSET_XN * 1000 + 8;//constant integer   bj_MISSION_INDEX_XN08       = bj_CAMPAIGN_OFFSET_XN * 1000 + 8
		private int bj_MISSION_INDEX_XN09 = bj_CAMPAIGN_OFFSET_XN * 1000 + 9;//constant integer   bj_MISSION_INDEX_XN09       = bj_CAMPAIGN_OFFSET_XN * 1000 + 9
		private int bj_MISSION_INDEX_XN10 = bj_CAMPAIGN_OFFSET_XN * 1000 + 10;//constant integer   bj_MISSION_INDEX_XN10       = bj_CAMPAIGN_OFFSET_XN * 1000 + 10
		//
		private int bj_MISSION_INDEX_XH00 = bj_CAMPAIGN_OFFSET_XH * 1000 + 0;//constant integer   bj_MISSION_INDEX_XH00       = bj_CAMPAIGN_OFFSET_XH * 1000 + 0
		private int bj_MISSION_INDEX_XH01 = bj_CAMPAIGN_OFFSET_XH * 1000 + 1;//constant integer   bj_MISSION_INDEX_XH01       = bj_CAMPAIGN_OFFSET_XH * 1000 + 1
		private int bj_MISSION_INDEX_XH02 = bj_CAMPAIGN_OFFSET_XH * 1000 + 2;//constant integer   bj_MISSION_INDEX_XH02       = bj_CAMPAIGN_OFFSET_XH * 1000 + 2
		private int bj_MISSION_INDEX_XH03 = bj_CAMPAIGN_OFFSET_XH * 1000 + 3;//constant integer   bj_MISSION_INDEX_XH03       = bj_CAMPAIGN_OFFSET_XH * 1000 + 3
		private int bj_MISSION_INDEX_XH04 = bj_CAMPAIGN_OFFSET_XH * 1000 + 4;//constant integer   bj_MISSION_INDEX_XH04       = bj_CAMPAIGN_OFFSET_XH * 1000 + 4
		private int bj_MISSION_INDEX_XH05 = bj_CAMPAIGN_OFFSET_XH * 1000 + 5;//constant integer   bj_MISSION_INDEX_XH05       = bj_CAMPAIGN_OFFSET_XH * 1000 + 5
		private int bj_MISSION_INDEX_XH06 = bj_CAMPAIGN_OFFSET_XH * 1000 + 6;//constant integer   bj_MISSION_INDEX_XH06       = bj_CAMPAIGN_OFFSET_XH * 1000 + 6
		private int bj_MISSION_INDEX_XH07 = bj_CAMPAIGN_OFFSET_XH * 1000 + 7;//constant integer   bj_MISSION_INDEX_XH07       = bj_CAMPAIGN_OFFSET_XH * 1000 + 7
		private int bj_MISSION_INDEX_XH08 = bj_CAMPAIGN_OFFSET_XH * 1000 + 8;//constant integer   bj_MISSION_INDEX_XH08       = bj_CAMPAIGN_OFFSET_XH * 1000 + 8
		private int bj_MISSION_INDEX_XH09 = bj_CAMPAIGN_OFFSET_XH * 1000 + 9;//constant integer   bj_MISSION_INDEX_XH09       = bj_CAMPAIGN_OFFSET_XH * 1000 + 9
		//
		private int bj_MISSION_INDEX_XU00 = bj_CAMPAIGN_OFFSET_XU * 1000 + 0;//constant integer   bj_MISSION_INDEX_XU00       = bj_CAMPAIGN_OFFSET_XU * 1000 + 0
		private int bj_MISSION_INDEX_XU01 = bj_CAMPAIGN_OFFSET_XU * 1000 + 1;//constant integer   bj_MISSION_INDEX_XU01       = bj_CAMPAIGN_OFFSET_XU * 1000 + 1
		private int bj_MISSION_INDEX_XU02 = bj_CAMPAIGN_OFFSET_XU * 1000 + 2;//constant integer   bj_MISSION_INDEX_XU02       = bj_CAMPAIGN_OFFSET_XU * 1000 + 2
		private int bj_MISSION_INDEX_XU03 = bj_CAMPAIGN_OFFSET_XU * 1000 + 3;//constant integer   bj_MISSION_INDEX_XU03       = bj_CAMPAIGN_OFFSET_XU * 1000 + 3
		private int bj_MISSION_INDEX_XU04 = bj_CAMPAIGN_OFFSET_XU * 1000 + 4;//constant integer   bj_MISSION_INDEX_XU04       = bj_CAMPAIGN_OFFSET_XU * 1000 + 4
		private int bj_MISSION_INDEX_XU05 = bj_CAMPAIGN_OFFSET_XU * 1000 + 5;//constant integer   bj_MISSION_INDEX_XU05       = bj_CAMPAIGN_OFFSET_XU * 1000 + 5
		private int bj_MISSION_INDEX_XU06 = bj_CAMPAIGN_OFFSET_XU * 1000 + 6;//constant integer   bj_MISSION_INDEX_XU06       = bj_CAMPAIGN_OFFSET_XU * 1000 + 6
		private int bj_MISSION_INDEX_XU07 = bj_CAMPAIGN_OFFSET_XU * 1000 + 7;//constant integer   bj_MISSION_INDEX_XU07       = bj_CAMPAIGN_OFFSET_XU * 1000 + 7
		private int bj_MISSION_INDEX_XU08 = bj_CAMPAIGN_OFFSET_XU * 1000 + 8;//constant integer   bj_MISSION_INDEX_XU08       = bj_CAMPAIGN_OFFSET_XU * 1000 + 8
		private int bj_MISSION_INDEX_XU09 = bj_CAMPAIGN_OFFSET_XU * 1000 + 9;//constant integer   bj_MISSION_INDEX_XU09       = bj_CAMPAIGN_OFFSET_XU * 1000 + 9
		private int bj_MISSION_INDEX_XU10 = bj_CAMPAIGN_OFFSET_XU * 1000 + 10;//constant integer   bj_MISSION_INDEX_XU10       = bj_CAMPAIGN_OFFSET_XU * 1000 + 10
		private int bj_MISSION_INDEX_XU11 = bj_CAMPAIGN_OFFSET_XU * 1000 + 11;//constant integer   bj_MISSION_INDEX_XU11       = bj_CAMPAIGN_OFFSET_XU * 1000 + 11
		private int bj_MISSION_INDEX_XU12 = bj_CAMPAIGN_OFFSET_XU * 1000 + 12;//constant integer   bj_MISSION_INDEX_XU12       = bj_CAMPAIGN_OFFSET_XU * 1000 + 12
		private int bj_MISSION_INDEX_XU13 = bj_CAMPAIGN_OFFSET_XU * 1000 + 13;//constant integer   bj_MISSION_INDEX_XU13       = bj_CAMPAIGN_OFFSET_XU * 1000 + 13
		//
		private int bj_MISSION_INDEX_XO00 = bj_CAMPAIGN_OFFSET_XO * 1000 + 0;//constant integer   bj_MISSION_INDEX_XO00       = bj_CAMPAIGN_OFFSET_XO * 1000 + 0
		//
		private int bj_CINEMATICINDEX_TOP = 0;//constant integer   bj_CINEMATICINDEX_TOP      = 0
		private int bj_CINEMATICINDEX_HOP = 1;//constant integer   bj_CINEMATICINDEX_HOP      = 1
		private int bj_CINEMATICINDEX_HED = 2;//constant integer   bj_CINEMATICINDEX_HED      = 2
		private int bj_CINEMATICINDEX_OOP = 3;//constant integer   bj_CINEMATICINDEX_OOP      = 3
		private int bj_CINEMATICINDEX_OED = 4;//constant integer   bj_CINEMATICINDEX_OED      = 4
		private int bj_CINEMATICINDEX_UOP = 5;//constant integer   bj_CINEMATICINDEX_UOP      = 5
		private int bj_CINEMATICINDEX_UED = 6;//constant integer   bj_CINEMATICINDEX_UED      = 6
		private int bj_CINEMATICINDEX_NOP = 7;//constant integer   bj_CINEMATICINDEX_NOP      = 7
		private int bj_CINEMATICINDEX_NED = 8;//constant integer   bj_CINEMATICINDEX_NED      = 8
		private int bj_CINEMATICINDEX_XOP = 9;//constant integer   bj_CINEMATICINDEX_XOP      = 9
		private int bj_CINEMATICINDEX_XED = 10;//constant integer   bj_CINEMATICINDEX_XED      = 10
		//
		private int bj_ALLIANCE_UNALLIED = 0;//constant integer   bj_ALLIANCE_UNALLIED        = 0
		private int bj_ALLIANCE_UNALLIED_VISION = 1;//constant integer   bj_ALLIANCE_UNALLIED_VISION = 1
		private int bj_ALLIANCE_ALLIED = 2;//constant integer   bj_ALLIANCE_ALLIED          = 2
		private int bj_ALLIANCE_ALLIED_VISION = 3;//constant integer   bj_ALLIANCE_ALLIED_VISION   = 3
		private int bj_ALLIANCE_ALLIED_UNITS = 4;//constant integer   bj_ALLIANCE_ALLIED_UNITS    = 4
		private int bj_ALLIANCE_ALLIED_ADVUNITS = 5;//constant integer   bj_ALLIANCE_ALLIED_ADVUNITS = 5
		private int bj_ALLIANCE_NEUTRAL = 6;//constant integer   bj_ALLIANCE_NEUTRAL         = 6
		private int bj_ALLIANCE_NEUTRAL_VISION = 7;//constant integer   bj_ALLIANCE_NEUTRAL_VISION  = 7
		//
		private int bj_KEYEVENTTYPE_DEPRESS = 0;//constant integer   bj_KEYEVENTTYPE_DEPRESS     = 0
		private int bj_KEYEVENTTYPE_RELEASE = 1;//constant integer   bj_KEYEVENTTYPE_RELEASE     = 1
		//
		private int bj_KEYEVENTKEY_LEFT = 0;//constant integer   bj_KEYEVENTKEY_LEFT         = 0
		private int bj_KEYEVENTKEY_RIGHT = 1;//constant integer   bj_KEYEVENTKEY_RIGHT        = 1
		private int bj_KEYEVENTKEY_DOWN = 2;//constant integer   bj_KEYEVENTKEY_DOWN         = 2
		private int bj_KEYEVENTKEY_UP = 3;//constant integer   bj_KEYEVENTKEY_UP           = 3
		//
		private int bj_TIMETYPE_ADD = 0;//constant integer   bj_TIMETYPE_ADD             = 0
		private int bj_TIMETYPE_SET = 1;//constant integer   bj_TIMETYPE_SET             = 1
		private int bj_TIMETYPE_SUB = 2;//constant integer   bj_TIMETYPE_SUB             = 2
		//
		private int bj_CAMERABOUNDS_ADJUST_ADD = 0;//constant integer   bj_CAMERABOUNDS_ADJUST_ADD  = 0
		private int bj_CAMERABOUNDS_ADJUST_SUB = 1;//constant integer   bj_CAMERABOUNDS_ADJUST_SUB  = 1
		//
		private int bj_QUESTTYPE_REQ_DISCOVERED = 0;//constant integer   bj_QUESTTYPE_REQ_DISCOVERED   = 0
		private int bj_QUESTTYPE_REQ_UNDISCOVERED = 1;//constant integer   bj_QUESTTYPE_REQ_UNDISCOVERED = 1
		private int bj_QUESTTYPE_OPT_DISCOVERED = 2;//constant integer   bj_QUESTTYPE_OPT_DISCOVERED   = 2
		private int bj_QUESTTYPE_OPT_UNDISCOVERED = 3;//constant integer   bj_QUESTTYPE_OPT_UNDISCOVERED = 3
		//
		private int bj_QUESTMESSAGE_DISCOVERED = 0;//constant integer   bj_QUESTMESSAGE_DISCOVERED    = 0
		private int bj_QUESTMESSAGE_UPDATED = 1;//constant integer   bj_QUESTMESSAGE_UPDATED       = 1
		private int bj_QUESTMESSAGE_COMPLETED = 2;//constant integer   bj_QUESTMESSAGE_COMPLETED     = 2
		private int bj_QUESTMESSAGE_FAILED = 3;//constant integer   bj_QUESTMESSAGE_FAILED        = 3
		private int bj_QUESTMESSAGE_REQUIREMENT = 4;//constant integer   bj_QUESTMESSAGE_REQUIREMENT   = 4
		private int bj_QUESTMESSAGE_MISSIONFAILED = 5;//constant integer   bj_QUESTMESSAGE_MISSIONFAILED = 5
		private int bj_QUESTMESSAGE_ALWAYSHINT = 6;//constant integer   bj_QUESTMESSAGE_ALWAYSHINT    = 6
		private int bj_QUESTMESSAGE_HINT = 7;//constant integer   bj_QUESTMESSAGE_HINT          = 7
		private int bj_QUESTMESSAGE_SECRET = 8;//constant integer   bj_QUESTMESSAGE_SECRET        = 8
		private int bj_QUESTMESSAGE_UNITACQUIRED = 9;//constant integer   bj_QUESTMESSAGE_UNITACQUIRED  = 9
		private int bj_QUESTMESSAGE_UNITAVAILABLE = 10;//constant integer   bj_QUESTMESSAGE_UNITAVAILABLE = 10
		private int bj_QUESTMESSAGE_ITEMACQUIRED = 11;//constant integer   bj_QUESTMESSAGE_ITEMACQUIRED  = 11
		private int bj_QUESTMESSAGE_WARNING = 12;//constant integer   bj_QUESTMESSAGE_WARNING       = 12
		//
		private int bj_SORTTYPE_SORTBYVALUE = 0;//constant integer   bj_SORTTYPE_SORTBYVALUE     = 0
		private int bj_SORTTYPE_SORTBYPLAYER = 1;//constant integer   bj_SORTTYPE_SORTBYPLAYER    = 1
		private int bj_SORTTYPE_SORTBYLABEL = 2;//constant integer   bj_SORTTYPE_SORTBYLABEL     = 2
		//
		private int bj_CINEFADETYPE_FADEIN = 0;//constant integer   bj_CINEFADETYPE_FADEIN      = 0
		private int bj_CINEFADETYPE_FADEOUT = 1;//constant integer   bj_CINEFADETYPE_FADEOUT     = 1
		private int bj_CINEFADETYPE_FADEOUTIN = 2;//constant integer   bj_CINEFADETYPE_FADEOUTIN   = 2
		//
		private int bj_REMOVEBUFFS_POSITIVE = 0;//constant integer   bj_REMOVEBUFFS_POSITIVE     = 0
		private int bj_REMOVEBUFFS_NEGATIVE = 1;//constant integer   bj_REMOVEBUFFS_NEGATIVE     = 1
		private int bj_REMOVEBUFFS_ALL = 2;//constant integer   bj_REMOVEBUFFS_ALL          = 2
		private int bj_REMOVEBUFFS_NONTLIFE = 3;//constant integer   bj_REMOVEBUFFS_NONTLIFE     = 3
		//
		private int bj_BUFF_POLARITY_POSITIVE = 0;//constant integer   bj_BUFF_POLARITY_POSITIVE   = 0
		private int bj_BUFF_POLARITY_NEGATIVE = 1;//constant integer   bj_BUFF_POLARITY_NEGATIVE   = 1
		private int bj_BUFF_POLARITY_EITHER = 2;//constant integer   bj_BUFF_POLARITY_EITHER     = 2
		//
		private int bj_BUFF_RESIST_MAGIC = 0;//constant integer   bj_BUFF_RESIST_MAGIC        = 0
		private int bj_BUFF_RESIST_PHYSICAL = 1;//constant integer   bj_BUFF_RESIST_PHYSICAL     = 1
		private int bj_BUFF_RESIST_EITHER = 2;//constant integer   bj_BUFF_RESIST_EITHER       = 2
		private int bj_BUFF_RESIST_BOTH = 3;//constant integer   bj_BUFF_RESIST_BOTH         = 3
		//
		private int bj_HEROSTAT_STR = 0;//constant integer   bj_HEROSTAT_STR             = 0
		private int bj_HEROSTAT_AGI = 1;//constant integer   bj_HEROSTAT_AGI             = 1
		private int bj_HEROSTAT_INT = 2;//constant integer   bj_HEROSTAT_INT             = 2
		//
		private int bj_MODIFYMETHOD_ADD = 0;//constant integer   bj_MODIFYMETHOD_ADD    = 0
		private int bj_MODIFYMETHOD_SUB = 1;//constant integer   bj_MODIFYMETHOD_SUB    = 1
		private int bj_MODIFYMETHOD_SET = 2;//constant integer   bj_MODIFYMETHOD_SET    = 2
		//
		private int bj_UNIT_STATE_METHOD_ABSOLUTE = 0;//constant integer   bj_UNIT_STATE_METHOD_ABSOLUTE = 0
		private int bj_UNIT_STATE_METHOD_RELATIVE = 1;//constant integer   bj_UNIT_STATE_METHOD_RELATIVE = 1
		private int bj_UNIT_STATE_METHOD_DEFAULTS = 2;//constant integer   bj_UNIT_STATE_METHOD_DEFAULTS = 2
		private int bj_UNIT_STATE_METHOD_MAXIMUM = 3;//constant integer   bj_UNIT_STATE_METHOD_MAXIMUM  = 3
		//
		private int bj_GATEOPERATION_CLOSE = 0;//constant integer   bj_GATEOPERATION_CLOSE      = 0
		private int bj_GATEOPERATION_OPEN = 1;//constant integer   bj_GATEOPERATION_OPEN       = 1
		private int bj_GATEOPERATION_DESTROY = 2;//constant integer   bj_GATEOPERATION_DESTROY    = 2
		//
		private int bj_GAMECACHE_BOOLEAN = 0;//constant integer   bj_GAMECACHE_BOOLEAN                 = 0
		private int bj_GAMECACHE_INTEGER = 1;//constant integer   bj_GAMECACHE_INTEGER                 = 1
		private int bj_GAMECACHE_REAL = 2;//constant integer   bj_GAMECACHE_REAL                    = 2
		private int bj_GAMECACHE_UNIT = 3;//constant integer   bj_GAMECACHE_UNIT                    = 3
		private int bj_GAMECACHE_STRING = 4;//constant integer   bj_GAMECACHE_STRING                  = 4
		//
		private int bj_HASHTABLE_BOOLEAN = 0;//constant integer   bj_HASHTABLE_BOOLEAN                 = 0
		private int bj_HASHTABLE_INTEGER = 1;//constant integer   bj_HASHTABLE_INTEGER                 = 1
		private int bj_HASHTABLE_REAL = 2;//constant integer   bj_HASHTABLE_REAL                    = 2
		private int bj_HASHTABLE_STRING = 3;//constant integer   bj_HASHTABLE_STRING                  = 3
		private int bj_HASHTABLE_HANDLE = 4;//constant integer   bj_HASHTABLE_HANDLE                  = 4
		//
		private int bj_ITEM_STATUS_HIDDEN = 0;//constant integer   bj_ITEM_STATUS_HIDDEN       = 0
		private int bj_ITEM_STATUS_OWNED = 1;//constant integer   bj_ITEM_STATUS_OWNED        = 1
		private int bj_ITEM_STATUS_INVULNERABLE = 2;//constant integer   bj_ITEM_STATUS_INVULNERABLE = 2
		private int bj_ITEM_STATUS_POWERUP = 3;//constant integer   bj_ITEM_STATUS_POWERUP      = 3
		private int bj_ITEM_STATUS_SELLABLE = 4;//constant integer   bj_ITEM_STATUS_SELLABLE     = 4
		private int bj_ITEM_STATUS_PAWNABLE = 5;//constant integer   bj_ITEM_STATUS_PAWNABLE     = 5
		//
		private int bj_ITEMCODE_STATUS_POWERUP = 0;//constant integer   bj_ITEMCODE_STATUS_POWERUP  = 0
		private int bj_ITEMCODE_STATUS_SELLABLE = 1;//constant integer   bj_ITEMCODE_STATUS_SELLABLE = 1
		private int bj_ITEMCODE_STATUS_PAWNABLE = 2;//constant integer   bj_ITEMCODE_STATUS_PAWNABLE = 2
		//
		private int bj_MINIMAPPINGSTYLE_SIMPLE = 0;//constant integer   bj_MINIMAPPINGSTYLE_SIMPLE  = 0
		private int bj_MINIMAPPINGSTYLE_FLASHY = 1;//constant integer   bj_MINIMAPPINGSTYLE_FLASHY  = 1
		private int bj_MINIMAPPINGSTYLE_ATTACK = 2;//constant integer   bj_MINIMAPPINGSTYLE_ATTACK  = 2
		//
		private real bj_CORPSE_MAX_DEATH_TIME = 8.00;//constant real      bj_CORPSE_MAX_DEATH_TIME    = 8.00
		//
		private int bj_CORPSETYPE_FLESH = 0;//constant integer   bj_CORPSETYPE_FLESH         = 0
		private int bj_CORPSETYPE_BONE = 1;//constant integer   bj_CORPSETYPE_BONE          = 1
		//
		private int bj_ELEVATOR_BLOCKER_CODE = 'DTep';//constant integer   bj_ELEVATOR_BLOCKER_CODE    = 'DTep'
		private int bj_ELEVATOR_CODE01 = 'DTrf';//constant integer   bj_ELEVATOR_CODE01          = 'DTrf'
		private int bj_ELEVATOR_CODE02 = 'DTrx';//constant integer   bj_ELEVATOR_CODE02          = 'DTrx'
		//
		private int bj_ELEVATOR_WALL_TYPE_ALL = 0;//constant integer   bj_ELEVATOR_WALL_TYPE_ALL        = 0
		private int bj_ELEVATOR_WALL_TYPE_EAST = 1;//constant integer   bj_ELEVATOR_WALL_TYPE_EAST       = 1
		private int bj_ELEVATOR_WALL_TYPE_NORTH = 2;//constant integer   bj_ELEVATOR_WALL_TYPE_NORTH      = 2
		private int bj_ELEVATOR_WALL_TYPE_SOUTH = 3;//constant integer   bj_ELEVATOR_WALL_TYPE_SOUTH      = 3
		private int bj_ELEVATOR_WALL_TYPE_WEST = 4;//constant integer   bj_ELEVATOR_WALL_TYPE_WEST       = 4
		//
		//
		//
		//
		private force bj_FORCE_ALL_PLAYERS = null;//force              bj_FORCE_ALL_PLAYERS        = null
		private force[] bj_FORCE_PLAYER;//force array        bj_FORCE_PLAYER
		private int bj_MELEE_MAX_TWINKED_HEROES = 0;//integer            bj_MELEE_MAX_TWINKED_HEROES = 0
		//
		private rect bj_mapInitialPlayableArea = null;//rect               bj_mapInitialPlayableArea   = null
		private rect bj_mapInitialCameraBounds = null;//rect               bj_mapInitialCameraBounds   = null
		//
		private int bj_forLoopAIndex = 0;//integer            bj_forLoopAIndex            = 0
		private int bj_forLoopBIndex = 0;//integer            bj_forLoopBIndex            = 0
		private int bj_forLoopAIndexEnd = 0;//integer            bj_forLoopAIndexEnd         = 0
		private int bj_forLoopBIndexEnd = 0;//integer            bj_forLoopBIndexEnd         = 0
		private bool bj_slotControlReady = false;//boolean            bj_slotControlReady         = false
		private bool[] bj_slotControlUsed;//boolean array      bj_slotControlUsed
		private mapcontrol[] bj_slotControl;//mapcontrol array   bj_slotControl
		//
		private timer bj_gameStartedTimer = null;//timer              bj_gameStartedTimer         = null
		private bool bj_gameStarted = false;//boolean            bj_gameStarted              = false
		private timer bj_volumeGroupsTimer = CreateTimer();//timer              bj_volumeGroupsTimer        = CreateTimer()
		//
		private bool bj_isSinglePlayer = false;//boolean            bj_isSinglePlayer           = false
		//
		private trigger bj_dncSoundsDay = null;//trigger            bj_dncSoundsDay             = null
		private trigger bj_dncSoundsNight = null;//trigger            bj_dncSoundsNight           = null
		private sound bj_dayAmbientSound = null;//sound              bj_dayAmbientSound          = null
		private sound bj_nightAmbientSound = null;//sound              bj_nightAmbientSound        = null
		private trigger bj_dncSoundsDawn = null;//trigger            bj_dncSoundsDawn            = null
		private trigger bj_dncSoundsDusk = null;//trigger            bj_dncSoundsDusk            = null
		private sound bj_dawnSound = null;//sound              bj_dawnSound                = null
		private sound bj_duskSound = null;//sound              bj_duskSound                = null
		private bool bj_useDawnDuskSounds = true;//boolean            bj_useDawnDuskSounds        = true
		private bool bj_dncIsDaytime = false;//boolean            bj_dncIsDaytime             = false
		//
		//
		private sound bj_rescueSound = null;//sound              bj_rescueSound              = null
		private sound bj_questDiscoveredSound = null;//sound              bj_questDiscoveredSound     = null
		private sound bj_questUpdatedSound = null;//sound              bj_questUpdatedSound        = null
		private sound bj_questCompletedSound = null;//sound              bj_questCompletedSound      = null
		private sound bj_questFailedSound = null;//sound              bj_questFailedSound         = null
		private sound bj_questHintSound = null;//sound              bj_questHintSound           = null
		private sound bj_questSecretSound = null;//sound              bj_questSecretSound         = null
		private sound bj_questItemAcquiredSound = null;//sound              bj_questItemAcquiredSound   = null
		private sound bj_questWarningSound = null;//sound              bj_questWarningSound        = null
		private sound bj_victoryDialogSound = null;//sound              bj_victoryDialogSound       = null
		private sound bj_defeatDialogSound = null;//sound              bj_defeatDialogSound        = null
		//
		private trigger bj_stockItemPurchased = null;//trigger            bj_stockItemPurchased       = null
		private timer bj_stockUpdateTimer = null;//timer              bj_stockUpdateTimer         = null
		private bool[] bj_stockAllowedPermanent;//boolean array      bj_stockAllowedPermanent
		private bool[] bj_stockAllowedCharged;//boolean array      bj_stockAllowedCharged
		private bool[] bj_stockAllowedArtifact;//boolean array      bj_stockAllowedArtifact
		private int bj_stockPickedItemLevel = 0;//integer            bj_stockPickedItemLevel     = 0
		private itemtype bj_stockPickedItemType;//itemtype           bj_stockPickedItemType
		//
		private trigger bj_meleeVisibilityTrained = null;//trigger            bj_meleeVisibilityTrained   = null
		private bool bj_meleeVisibilityIsDay = true;//boolean            bj_meleeVisibilityIsDay     = true
		private bool bj_meleeGrantHeroItems = false;//boolean            bj_meleeGrantHeroItems      = false
		private location bj_meleeNearestMineToLoc = null;//location           bj_meleeNearestMineToLoc    = null
		private int bj_meleeNearestMine = null;//unit               bj_meleeNearestMine         = null
		private real bj_meleeNearestMineDist = 0.00;//real               bj_meleeNearestMineDist     = 0.00
		private bool bj_meleeGameOver = false;//boolean            bj_meleeGameOver            = false
		private bool[] bj_meleeDefeated;//boolean array      bj_meleeDefeated
		private bool[] bj_meleeVictoried;//boolean array      bj_meleeVictoried
		private int[] bj_ghoul;//unit array         bj_ghoul
		private timer[] bj_crippledTimer;//timer array        bj_crippledTimer
		private timerdialog[] bj_crippledTimerWindows;//timerdialog array  bj_crippledTimerWindows
		private bool[] bj_playerIsCrippled;//boolean array      bj_playerIsCrippled
		private bool[] bj_playerIsExposed;//boolean array      bj_playerIsExposed
		private bool bj_finishSoonAllExposed = false;//boolean            bj_finishSoonAllExposed     = false
		private timerdialog bj_finishSoonTimerDialog = null;//timerdialog        bj_finishSoonTimerDialog    = null
		private int[] bj_meleeTwinkedHeroes;//integer array      bj_meleeTwinkedHeroes
		//
		private trigger bj_rescueUnitBehavior = null;//trigger            bj_rescueUnitBehavior       = null
		private bool bj_rescueChangeColorUnit = true;//boolean            bj_rescueChangeColorUnit    = true
		private bool bj_rescueChangeColorBldg = true;//boolean            bj_rescueChangeColorBldg    = true
		//
		private timer bj_cineSceneEndingTimer = null;//timer              bj_cineSceneEndingTimer     = null
		private sound bj_cineSceneLastSound = null;//sound              bj_cineSceneLastSound       = null
		private trigger bj_cineSceneBeingSkipped = null;//trigger            bj_cineSceneBeingSkipped    = null
		//
		private gamespeed bj_cineModePriorSpeed = MAP_SPEED_NORMAL;//gamespeed          bj_cineModePriorSpeed       = MAP_SPEED_NORMAL
		private bool bj_cineModePriorFogSetting = false;//boolean            bj_cineModePriorFogSetting  = false
		private bool bj_cineModePriorMaskSetting = false;//boolean            bj_cineModePriorMaskSetting = false
		private bool bj_cineModeAlreadyIn = false;//boolean            bj_cineModeAlreadyIn        = false
		private bool bj_cineModePriorDawnDusk = false;//boolean            bj_cineModePriorDawnDusk    = false
		private int bj_cineModeSavedSeed = 0;//integer            bj_cineModeSavedSeed        = 0
		//
		private timer bj_cineFadeFinishTimer = null;//timer              bj_cineFadeFinishTimer      = null
		private timer bj_cineFadeContinueTimer = null;//timer              bj_cineFadeContinueTimer    = null
		private real bj_cineFadeContinueRed = 0;//real               bj_cineFadeContinueRed      = 0
		private real bj_cineFadeContinueGreen = 0;//real               bj_cineFadeContinueGreen    = 0
		private real bj_cineFadeContinueBlue = 0;//real               bj_cineFadeContinueBlue     = 0
		private real bj_cineFadeContinueTrans = 0;//real               bj_cineFadeContinueTrans    = 0
		private real bj_cineFadeContinueDuration = 0;//real               bj_cineFadeContinueDuration = 0
		private string bj_cineFadeContinueTex = "";//string             bj_cineFadeContinueTex      = ""
		//
		private int bj_queuedExecTotal = 0;//integer            bj_queuedExecTotal          = 0
		private trigger[] bj_queuedExecTriggers;//trigger array      bj_queuedExecTriggers
		private bool[] bj_queuedExecUseConds;//boolean array      bj_queuedExecUseConds
		private timer bj_queuedExecTimeoutTimer = CreateTimer();//timer              bj_queuedExecTimeoutTimer   = CreateTimer()
		private trigger bj_queuedExecTimeout = null;//trigger            bj_queuedExecTimeout        = null
		//
		private int bj_destInRegionDiesCount = 0;//integer            bj_destInRegionDiesCount    = 0
		private trigger bj_destInRegionDiesTrig = null;//trigger            bj_destInRegionDiesTrig     = null
		private int bj_groupCountUnits = 0;//integer            bj_groupCountUnits          = 0
		private int bj_forceCountPlayers = 0;//integer            bj_forceCountPlayers        = 0
		private int bj_groupEnumTypeId = 0;//integer            bj_groupEnumTypeId          = 0
		private player bj_groupEnumOwningPlayer = null;//player             bj_groupEnumOwningPlayer    = null
		private group bj_groupAddGroupDest = null;//group              bj_groupAddGroupDest        = null
		private group bj_groupRemoveGroupDest = null;//group              bj_groupRemoveGroupDest     = null
		private int bj_groupRandomConsidered = 0;//integer            bj_groupRandomConsidered    = 0
		private int bj_groupRandomCurrentPick = null;//unit               bj_groupRandomCurrentPick   = null
		private group bj_groupLastCreatedDest = null;//group              bj_groupLastCreatedDest     = null
		private group bj_randomSubGroupGroup = null;//group              bj_randomSubGroupGroup      = null
		private int bj_randomSubGroupWant = 0;//integer            bj_randomSubGroupWant       = 0
		private int bj_randomSubGroupTotal = 0;//integer            bj_randomSubGroupTotal      = 0
		private real bj_randomSubGroupChance = 0;//real               bj_randomSubGroupChance     = 0
		private int bj_destRandomConsidered = 0;//integer            bj_destRandomConsidered     = 0
		private destructable bj_destRandomCurrentPick = null;//destructable       bj_destRandomCurrentPick    = null
		private destructable bj_elevatorWallBlocker = null;//destructable       bj_elevatorWallBlocker      = null
		private destructable bj_elevatorNeighbor = null;//destructable       bj_elevatorNeighbor         = null
		private int bj_itemRandomConsidered = 0;//integer            bj_itemRandomConsidered     = 0
		private item bj_itemRandomCurrentPick = null;//item               bj_itemRandomCurrentPick    = null
		private int bj_forceRandomConsidered = 0;//integer            bj_forceRandomConsidered    = 0
		private player bj_forceRandomCurrentPick = null;//player             bj_forceRandomCurrentPick   = null
		private int bj_makeUnitRescuableUnit = null;//unit               bj_makeUnitRescuableUnit    = null
		private bool bj_makeUnitRescuableFlag = true;//boolean            bj_makeUnitRescuableFlag    = true
		private bool bj_pauseAllUnitsFlag = true;//boolean            bj_pauseAllUnitsFlag        = true
		private location bj_enumDestructableCenter = null;//location           bj_enumDestructableCenter   = null
		private real bj_enumDestructableRadius = 0;//real               bj_enumDestructableRadius   = 0
		private playercolor bj_setPlayerTargetColor = null;//playercolor        bj_setPlayerTargetColor     = null
		private bool bj_isUnitGroupDeadResult = true;//boolean            bj_isUnitGroupDeadResult    = true
		private bool bj_isUnitGroupEmptyResult = true;//boolean            bj_isUnitGroupEmptyResult   = true
		private bool bj_isUnitGroupInRectResult = true;//boolean            bj_isUnitGroupInRectResult  = true
		private rect bj_isUnitGroupInRectRect = null;//rect               bj_isUnitGroupInRectRect    = null
		private bool bj_changeLevelShowScores = false;//boolean            bj_changeLevelShowScores    = false
		private string bj_changeLevelMapName = null;//string             bj_changeLevelMapName       = null
		private group bj_suspendDecayFleshGroup = CreateGroup();//group              bj_suspendDecayFleshGroup   = CreateGroup()
		private group bj_suspendDecayBoneGroup = CreateGroup();//group              bj_suspendDecayBoneGroup    = CreateGroup()
		private timer bj_delayedSuspendDecayTimer = CreateTimer();//timer              bj_delayedSuspendDecayTimer = CreateTimer()
		private trigger bj_delayedSuspendDecayTrig = null;//trigger            bj_delayedSuspendDecayTrig  = null
		private int bj_livingPlayerUnitsTypeId = 0;//integer            bj_livingPlayerUnitsTypeId  = 0
		private widget bj_lastDyingWidget = null;//widget             bj_lastDyingWidget          = null
		//
		private int bj_randDistCount = 0;//integer            bj_randDistCount            = 0
		private int[] bj_randDistID;//integer array      bj_randDistID
		private int[] bj_randDistChance;//integer array      bj_randDistChance
		//
		private int bj_lastCreatedUnit = null;//unit               bj_lastCreatedUnit          = null
		private item bj_lastCreatedItem = null;//item               bj_lastCreatedItem          = null
		private item bj_lastRemovedItem = null;//item               bj_lastRemovedItem          = null
		private int bj_lastHauntedGoldMine = null;//unit               bj_lastHauntedGoldMine      = null
		private destructable bj_lastCreatedDestructable = null;//destructable       bj_lastCreatedDestructable  = null
		private group bj_lastCreatedGroup = CreateGroup();//group              bj_lastCreatedGroup         = CreateGroup()
		private fogmodifier bj_lastCreatedFogModifier = null;//fogmodifier        bj_lastCreatedFogModifier   = null
		private effect bj_lastCreatedEffect = null;//effect             bj_lastCreatedEffect        = null
		private weathereffect bj_lastCreatedWeatherEffect = null;//weathereffect      bj_lastCreatedWeatherEffect = null
		private terraindeformation bj_lastCreatedTerrainDeformation = null;//terraindeformation bj_lastCreatedTerrainDeformation = null
		private quest bj_lastCreatedQuest = null;//quest              bj_lastCreatedQuest         = null
		private questitem bj_lastCreatedQuestItem = null;//questitem          bj_lastCreatedQuestItem     = null
		private defeatcondition bj_lastCreatedDefeatCondition = null;//defeatcondition    bj_lastCreatedDefeatCondition = null
		private timer bj_lastStartedTimer = CreateTimer();//timer              bj_lastStartedTimer         = CreateTimer()
		private timerdialog bj_lastCreatedTimerDialog = null;//timerdialog        bj_lastCreatedTimerDialog   = null
		private leaderboard bj_lastCreatedLeaderboard = null;//leaderboard        bj_lastCreatedLeaderboard   = null
		private multiboard bj_lastCreatedMultiboard = null;//multiboard         bj_lastCreatedMultiboard    = null
		private sound bj_lastPlayedSound = null;//sound              bj_lastPlayedSound          = null
		private string bj_lastPlayedMusic = "";//string             bj_lastPlayedMusic          = ""
		private real bj_lastTransmissionDuration = 0;//real               bj_lastTransmissionDuration = 0
		private gamecache bj_lastCreatedGameCache = null;//gamecache          bj_lastCreatedGameCache     = null
		private hashtable bj_lastCreatedHashtable = null;//hashtable          bj_lastCreatedHashtable     = null
		private int bj_lastLoadedUnit = null;//unit               bj_lastLoadedUnit           = null
		private button bj_lastCreatedButton = null;//button             bj_lastCreatedButton        = null
		private int bj_lastReplacedUnit = null;//unit               bj_lastReplacedUnit         = null
		private texttag bj_lastCreatedTextTag = null;//texttag            bj_lastCreatedTextTag       = null
		private lightning bj_lastCreatedLightning = null;//lightning          bj_lastCreatedLightning     = null
		private image bj_lastCreatedImage = null;//image              bj_lastCreatedImage         = null
		private ubersplat bj_lastCreatedUbersplat = null;//ubersplat          bj_lastCreatedUbersplat     = null
		//
		private boolexpr filterIssueHauntOrderAtLocBJ = null;//boolexpr           filterIssueHauntOrderAtLocBJ      = null
		private boolexpr filterEnumDestructablesInCircleBJ = null;//boolexpr           filterEnumDestructablesInCircleBJ = null
		private boolexpr filterGetUnitsInRectOfPlayer = null;//boolexpr           filterGetUnitsInRectOfPlayer      = null
		private boolexpr filterGetUnitsOfTypeIdAll = null;//boolexpr           filterGetUnitsOfTypeIdAll         = null
		private boolexpr filterGetUnitsOfPlayerAndTypeId = null;//boolexpr           filterGetUnitsOfPlayerAndTypeId   = null
		private boolexpr filterMeleeTrainedUnitIsHeroBJ = null;//boolexpr           filterMeleeTrainedUnitIsHeroBJ    = null
		private boolexpr filterLivingPlayerUnitsOfTypeId = null;//boolexpr           filterLivingPlayerUnitsOfTypeId   = null
		//
		private bool bj_wantDestroyGroup = false;//boolean            bj_wantDestroyGroup         = false
		//
		private real bj_DEBUG_CAMFIELD_SPEED = 0;//constant real     bj_DEBUG_CAMFIELD_SPEED     = 0
		private string bj_DEBUG_CHAT_GIMME = "gimme";//constant string   bj_DEBUG_CHAT_GIMME         = "gimme"
		private string bj_DEBUG_CHAT_DEMO = "demo";//constant string   bj_DEBUG_CHAT_DEMO          = "demo"
		private string bj_DEBUG_CHAT_TELEPORT = "teleport";//constant string   bj_DEBUG_CHAT_TELEPORT      = "teleport"
		private string bj_DEBUG_CHAT_UNITINFO = "unitinfo";//constant string   bj_DEBUG_CHAT_UNITINFO      = "unitinfo"
		private string bj_DEBUG_CHAT_UNITINFO2 = "ui";//constant string   bj_DEBUG_CHAT_UNITINFO2     = "ui"
		private string bj_DEBUG_CHAT_CAMINFO = "caminfo";//constant string   bj_DEBUG_CHAT_CAMINFO       = "caminfo"
		private string bj_DEBUG_CHAT_CAMINFO2 = "ci";//constant string   bj_DEBUG_CHAT_CAMINFO2      = "ci"
		private string bj_DEBUG_CHAT_CAMDIST = "camdist";//constant string   bj_DEBUG_CHAT_CAMDIST       = "camdist"
		private string bj_DEBUG_CHAT_CAMFARZ = "camfarz";//constant string   bj_DEBUG_CHAT_CAMFARZ       = "camfarz"
		private string bj_DEBUG_CHAT_CAMAOA = "camaoa";//constant string   bj_DEBUG_CHAT_CAMAOA        = "camaoa"
		private string bj_DEBUG_CHAT_CAMFOV = "camfov";//constant string   bj_DEBUG_CHAT_CAMFOV        = "camfov"
		private string bj_DEBUG_CHAT_CAMROLL = "camroll";//constant string   bj_DEBUG_CHAT_CAMROLL       = "camroll"
		private string bj_DEBUG_CHAT_CAMROT = "camrot";//constant string   bj_DEBUG_CHAT_CAMROT        = "camrot"
		private string bj_DEBUG_CHAT_CAMRESET = "camreset";//constant string   bj_DEBUG_CHAT_CAMRESET      = "camreset"
		private string bj_DEBUG_CHAT_REMOVEUNIT = "ru";//constant string   bj_DEBUG_CHAT_REMOVEUNIT    = "ru"
		private string bj_DEBUG_CHAT_GOTOX = "gotox";//constant string   bj_DEBUG_CHAT_GOTOX         = "gotox"
		private string bj_DEBUG_CHAT_GOTOY = "gotoy";//constant string   bj_DEBUG_CHAT_GOTOY         = "gotoy"
		private string bj_DEBUG_CHAT_GOTOXY = "gotoxy";//constant string   bj_DEBUG_CHAT_GOTOXY        = "gotoxy"
		private string bj_DEBUG_CHAT_GOTOUNIT = "gotounit";//constant string   bj_DEBUG_CHAT_GOTOUNIT      = "gotounit"
		private string bj_DEBUG_CHAT_DIFFICULTY = "difficulty";//constant string   bj_DEBUG_CHAT_DIFFICULTY    = "difficulty"
		private string bj_DEBUG_CHAT_FINGEROFDEATH = "fingerofdeath";//constant string   bj_DEBUG_CHAT_FINGEROFDEATH = "fingerofdeath"
		private trigger bj_debugGimmeTrig;//trigger           bj_debugGimmeTrig
		private trigger bj_debugDemoTrig;//trigger           bj_debugDemoTrig
		private trigger bj_debugTeleportTrig;//trigger           bj_debugTeleportTrig
		private trigger bj_debugUnitInfoTrig;//trigger           bj_debugUnitInfoTrig
		private trigger bj_debugCamInfoTrig;//trigger           bj_debugCamInfoTrig
		private trigger bj_debugCamDistTrig;//trigger           bj_debugCamDistTrig
		private trigger bj_debugCamFarzTrig;//trigger           bj_debugCamFarzTrig
		private trigger bj_debugCamAoaTrig;//trigger           bj_debugCamAoaTrig
		private trigger bj_debugCamFovTrig;//trigger           bj_debugCamFovTrig
		private trigger bj_debugCamRollTrig;//trigger           bj_debugCamRollTrig
		private trigger bj_debugCamRotTrig;//trigger           bj_debugCamRotTrig
		private trigger bj_debugCamResetTrig;//trigger           bj_debugCamResetTrig
		private trigger bj_debugRuTrig;//trigger           bj_debugRuTrig
		private trigger bj_debugGotoXTrig;//trigger           bj_debugGotoXTrig
		private trigger bj_debugGotoYTrig;//trigger           bj_debugGotoYTrig
		private trigger bj_debugGotoXYTrig;//trigger           bj_debugGotoXYTrig
		private trigger bj_debugGotoUnitTrig;//trigger           bj_debugGotoUnitTrig
		private trigger bj_debugDifficultyTrig;//trigger           bj_debugDifficultyTrig
		private trigger[] bj_debugFingerOfDeathTrig;//trigger  array    bj_debugFingerOfDeathTrig
		private trigger[] bj_debugToolOfDeathTrig;//trigger  array    bj_debugToolOfDeathTrig
		private bool[] bj_debugFingerOfDeathEnabled;//boolean  array    bj_debugFingerOfDeathEnabled
		private real bj_debugGotoUnitX = 0;//real              bj_debugGotoUnitX = 0
		private real bj_debugGotoUnitY = 0;//real              bj_debugGotoUnitY = 0
		private int bj_debugGotoUnits = 0;//integer           bj_debugGotoUnits = 0
		//
		//
		//
		//
		private int ARCHMAGE = 'Hamg';//constant integer ARCHMAGE           = 'Hamg'
		private int PALADIN = 'Hpal';//constant integer PALADIN            = 'Hpal'
		private int MTN_KING = 'Hmkg';//constant integer MTN_KING           = 'Hmkg'
		private int BLOOD_MAGE = 'Hblm';//constant integer BLOOD_MAGE         = 'Hblm'
		//
		private int AVATAR = 'AHav';//constant integer AVATAR             = 'AHav'
		private int BASH = 'AHbh';//constant integer BASH               = 'AHbh'
		private int THUNDER_BOLT = 'AHtb';//constant integer THUNDER_BOLT       = 'AHtb'
		private int THUNDER_CLAP = 'AHtc';//constant integer THUNDER_CLAP       = 'AHtc'
		private int DEVOTION_AURA = 'AHad';//constant integer DEVOTION_AURA      = 'AHad'
		private int DIVINE_SHIELD = 'AHds';//constant integer DIVINE_SHIELD      = 'AHds'
		private int HOLY_BOLT = 'AHhb';//constant integer HOLY_BOLT          = 'AHhb'
		private int RESURRECTION = 'AHre';//constant integer RESURRECTION       = 'AHre'
		private int BLIZZARD = 'AHbz';//constant integer BLIZZARD           = 'AHbz'
		private int BRILLIANCE_AURA = 'AHab';//constant integer BRILLIANCE_AURA    = 'AHab'
		private int MASS_TELEPORT = 'AHmt';//constant integer MASS_TELEPORT      = 'AHmt'
		private int WATER_ELEMENTAL = 'AHwe';//constant integer WATER_ELEMENTAL    = 'AHwe'
		private int BANISH = 'AHbn';//constant integer BANISH             = 'AHbn'
		private int FLAME_STRIKE = 'AHfs';//constant integer FLAME_STRIKE       = 'AHfs'
		private int SUMMON_PHOENIX = 'AHpx';//constant integer SUMMON_PHOENIX     = 'AHpx'
		private int SIPHON_MANA = 'AHdr';//constant integer SIPHON_MANA        = 'AHdr'
		//
		private int JAINA = 'Hjai';//constant integer JAINA              = 'Hjai'
		private int MURADIN = 'Hmbr';//constant integer MURADIN            = 'Hmbr'
		private int GARITHOS = 'Hlgr';//constant integer GARITHOS           = 'Hlgr'
		private int KAEL = 'Hkal';//constant integer KAEL               = 'Hkal'
		//
		private int COPTER = 'hgyr';//constant integer COPTER             = 'hgyr'
		private int GYRO = COPTER;//constant integer GYRO               =  COPTER
		private int ELEMENTAL = 'hwat';//constant integer ELEMENTAL          = 'hwat'
		private int FOOTMAN = 'hfoo';//constant integer FOOTMAN            = 'hfoo'
		private int FOOTMEN = FOOTMAN;//constant integer FOOTMEN            =  FOOTMAN
		private int GRYPHON = 'hgry';//constant integer GRYPHON            = 'hgry'
		private int KNIGHT = 'hkni';//constant integer KNIGHT             = 'hkni'
		private int MORTAR = 'hmtm';//constant integer MORTAR             = 'hmtm'
		private int PEASANT = 'hpea';//constant integer PEASANT            = 'hpea'
		private int PRIEST = 'hmpr';//constant integer PRIEST             = 'hmpr'
		private int RIFLEMAN = 'hrif';//constant integer RIFLEMAN           = 'hrif'
		private int RIFLEMEN = RIFLEMAN;//constant integer RIFLEMEN           =  RIFLEMAN
		private int SORCERESS = 'hsor';//constant integer SORCERESS          = 'hsor'
		private int TANK = 'hmtt';//constant integer TANK               = 'hmtt'
		private int STEAM_TANK = TANK;//constant integer STEAM_TANK         =  TANK
		private int ROCKET_TANK = 'hrtt';//constant integer ROCKET_TANK        = 'hrtt'
		private int MILITIA = 'hmil';//constant integer MILITIA            = 'hmil'
		private int SPELL_BREAKER = 'hspt';//constant integer SPELL_BREAKER      = 'hspt'
		private int HUMAN_DRAGON_HAWK = 'hdhw';//constant integer HUMAN_DRAGON_HAWK  = 'hdhw'
		//
		private int BLOOD_PRIEST = 'hbep';//constant integer BLOOD_PRIEST       = 'hbep'
		private int BLOOD_SORCERESS = 'hbes';//constant integer BLOOD_SORCERESS    = 'hbes'
		private int BLOOD_PEASANT = 'nhew';//constant integer BLOOD_PEASANT      = 'nhew'
		//
		private int AVIARY = 'hgra';//constant integer AVIARY             = 'hgra'
		private int BARRACKS = 'hbar';//constant integer BARRACKS           = 'hbar'
		private int BLACKSMITH = 'hbla';//constant integer BLACKSMITH         = 'hbla'
		private int CANNON_TOWER = 'hctw';//constant integer CANNON_TOWER       = 'hctw'
		private int CASTLE = 'hcas';//constant integer CASTLE             = 'hcas'
		private int CHURCH = 'htws';//constant integer CHURCH             = 'htws'
		private int MAGE_TOWER = CHURCH;//constant integer MAGE_TOWER         =  CHURCH
		private int GUARD_TOWER = 'hgtw';//constant integer GUARD_TOWER        = 'hgtw'
		private int HOUSE = 'hhou';//constant integer HOUSE              = 'hhou'
		private int HUMAN_ALTAR = 'halt';//constant integer HUMAN_ALTAR        = 'halt'
		private int KEEP = 'hkee';//constant integer KEEP               = 'hkee'
		private int LUMBER_MILL = 'hlum';//constant integer LUMBER_MILL        = 'hlum'
		private int SANCTUM = 'hars';//constant integer SANCTUM            = 'hars'
		private int ARCANE_SANCTUM = SANCTUM;//constant integer ARCANE_SANCTUM     =  SANCTUM
		private int TOWN_HALL = 'htow';//constant integer TOWN_HALL          = 'htow'
		private int WATCH_TOWER = 'hwtw';//constant integer WATCH_TOWER        = 'hwtw'
		private int WORKSHOP = 'harm';//constant integer WORKSHOP           = 'harm'
		private int ARCANE_VAULT = 'hvlt';//constant integer ARCANE_VAULT       = 'hvlt'
		private int ARCANE_TOWER = 'hatw';//constant integer ARCANE_TOWER       = 'hatw'
		//
		private int UPG_MELEE = 'Rhme';//constant integer UPG_MELEE          = 'Rhme'
		private int UPG_RANGED = 'Rhra';//constant integer UPG_RANGED         = 'Rhra'
		private int UPG_ARTILLERY = 'Rhaa';//constant integer UPG_ARTILLERY      = 'Rhaa'
		private int UPG_ARMOR = 'Rhar';//constant integer UPG_ARMOR          = 'Rhar'
		private int UPG_GOLD = 'Rhmi';//constant integer UPG_GOLD           = 'Rhmi'
		private int UPG_MASONRY = 'Rhac';//constant integer UPG_MASONRY        = 'Rhac'
		private int UPG_SIGHT = 'Rhss';//constant integer UPG_SIGHT          = 'Rhss'
		private int UPG_DEFEND = 'Rhde';//constant integer UPG_DEFEND         = 'Rhde'
		private int UPG_BREEDING = 'Rhan';//constant integer UPG_BREEDING       = 'Rhan'
		private int UPG_PRAYING = 'Rhpt';//constant integer UPG_PRAYING        = 'Rhpt'
		private int UPG_SORCERY = 'Rhst';//constant integer UPG_SORCERY        = 'Rhst'
		private int UPG_LEATHER = 'Rhla';//constant integer UPG_LEATHER        = 'Rhla'
		private int UPG_GUN_RANGE = 'Rhri';//constant integer UPG_GUN_RANGE      = 'Rhri'
		private int UPG_WOOD = 'Rhlh';//constant integer UPG_WOOD           = 'Rhlh'
		private int UPG_SENTINEL = 'Rhse';//constant integer UPG_SENTINEL       = 'Rhse'
		private int UPG_SCATTER = 'Rhsr';//constant integer UPG_SCATTER        = 'Rhsr'
		private int UPG_BOMBS = 'Rhgb';//constant integer UPG_BOMBS          = 'Rhgb'
		private int UPG_HAMMERS = 'Rhhb';//constant integer UPG_HAMMERS        = 'Rhhb'
		private int UPG_CONT_MAGIC = 'Rhss';//constant integer UPG_CONT_MAGIC     = 'Rhss'
		private int UPG_FRAGS = 'Rhfs';//constant integer UPG_FRAGS          = 'Rhfs'
		private int UPG_TANK = 'Rhrt';//constant integer UPG_TANK           = 'Rhrt'
		private int UPG_FLAK = 'Rhfc';//constant integer UPG_FLAK           = 'Rhfc'
		private int UPG_CLOUD = 'Rhcd';//constant integer UPG_CLOUD          = 'Rhcd'
		//
		//
		//
		//
		private int BLADE_MASTER = 'Obla';//constant integer BLADE_MASTER       = 'Obla'
		private int FAR_SEER = 'Ofar';//constant integer FAR_SEER           = 'Ofar'
		private int TAUREN_CHIEF = 'Otch';//constant integer TAUREN_CHIEF       = 'Otch'
		private int SHADOW_HUNTER = 'Oshd';//constant integer SHADOW_HUNTER      = 'Oshd'
		//
		private int GROM = 'Ogrh';//constant integer GROM               = 'Ogrh'
		private int THRALL = 'Othr';//constant integer THRALL             = 'Othr'
		//
		private int CRITICAL_STRIKE = 'AOcr';//constant integer CRITICAL_STRIKE    = 'AOcr'
		private int MIRROR_IMAGE = 'AOmi';//constant integer MIRROR_IMAGE       = 'AOmi'
		private int BLADE_STORM = 'AOww';//constant integer BLADE_STORM        = 'AOww'
		private int WIND_WALK = 'AOwk';//constant integer WIND_WALK          = 'AOwk'
		private int CHAIN_LIGHTNING = 'AOcl';//constant integer CHAIN_LIGHTNING    = 'AOcl'
		private int EARTHQUAKE = 'AOeq';//constant integer EARTHQUAKE         = 'AOeq'
		private int FAR_SIGHT = 'AOfs';//constant integer FAR_SIGHT          = 'AOfs'
		private int SPIRIT_WOLF = 'AOsf';//constant integer SPIRIT_WOLF        = 'AOsf'
		private int ENDURANE_AURA = 'AOae';//constant integer ENDURANE_AURA      = 'AOae'
		private int REINCARNATION = 'AOre';//constant integer REINCARNATION      = 'AOre'
		private int SHOCKWAVE = 'AOsh';//constant integer SHOCKWAVE          = 'AOsh'
		private int WAR_STOMP = 'AOws';//constant integer WAR_STOMP          = 'AOws'
		private int HEALING_WAVE = 'AOhw';//constant integer HEALING_WAVE       = 'AOhw'
		private int HEX = 'AOhx';//constant integer HEX                = 'AOhx'
		private int SERPENT_WARD = 'AOsw';//constant integer SERPENT_WARD       = 'AOsw'
		private int VOODOO = 'AOvd';//constant integer VOODOO             = 'AOvd'
		//
		private int GUARDIAN = 'oang';//constant integer GUARDIAN           = 'oang'
		private int CATAPULT = 'ocat';//constant integer CATAPULT           = 'ocat'
		private int WITCH_DOCTOR = 'odoc';//constant integer WITCH_DOCTOR       = 'odoc'
		private int GRUNT = 'ogru';//constant integer GRUNT              = 'ogru'
		private int HEAD_HUNTER = 'ohun';//constant integer HEAD_HUNTER        = 'ohun'
		private int BERSERKER = 'otbk';//constant integer BERSERKER          = 'otbk'
		private int KODO_BEAST = 'okod';//constant integer KODO_BEAST         = 'okod'
		private int PEON = 'opeo';//constant integer PEON               = 'opeo'
		private int RAIDER = 'orai';//constant integer RAIDER             = 'orai'
		private int SHAMAN = 'oshm';//constant integer SHAMAN             = 'oshm'
		private int TAUREN = 'otau';//constant integer TAUREN             = 'otau'
		private int WYVERN = 'owyv';//constant integer WYVERN             = 'owyv'
		private int BATRIDER = 'otbr';//constant integer BATRIDER           = 'otbr'
		private int SPIRIT_WALKER = 'ospw';//constant integer SPIRIT_WALKER      = 'ospw'
		private int SPIRIT_WALKER_M = 'ospm';//constant integer SPIRIT_WALKER_M    = 'ospm'
		//
		private int ORC_ALTAR = 'oalt';//constant integer ORC_ALTAR          = 'oalt'
		private int ORC_BARRACKS = 'obar';//constant integer ORC_BARRACKS       = 'obar'
		private int BESTIARY = 'obea';//constant integer BESTIARY           = 'obea'
		private int FORGE = 'ofor';//constant integer FORGE              = 'ofor'
		private int FORTRESS = 'ofrt';//constant integer FORTRESS           = 'ofrt'
		private int GREAT_HALL = 'ogre';//constant integer GREAT_HALL         = 'ogre'
		private int LODGE = 'osld';//constant integer LODGE              = 'osld'
		private int STRONGHOLD = 'ostr';//constant integer STRONGHOLD         = 'ostr'
		private int BURROW = 'otrb';//constant integer BURROW             = 'otrb'
		private int TOTEM = 'otto';//constant integer TOTEM              = 'otto'
		private int ORC_WATCH_TOWER = 'owtw';//constant integer ORC_WATCH_TOWER    = 'owtw'
		private int VOODOO_LOUNGE = 'ovln';//constant integer VOODOO_LOUNGE      = 'ovln'
		//
		private int UPG_ORC_MELEE = 'Rome';//constant integer UPG_ORC_MELEE      = 'Rome'
		private int UPG_ORC_RANGED = 'Rora';//constant integer UPG_ORC_RANGED     = 'Rora'
		private int UPG_ORC_ARTILLERY = 'Roaa';//constant integer UPG_ORC_ARTILLERY  = 'Roaa'
		private int UPG_ORC_ARMOR = 'Roar';//constant integer UPG_ORC_ARMOR      = 'Roar'
		private int UPG_ORC_WAR_DRUMS = 'Rwdm';//constant integer UPG_ORC_WAR_DRUMS  = 'Rwdm'
		private int UPG_ORC_PILLAGE = 'Ropg';//constant integer UPG_ORC_PILLAGE    = 'Ropg'
		private int UPG_ORC_BERSERK = 'Robs';//constant integer UPG_ORC_BERSERK    = 'Robs'
		private int UPG_ORC_PULVERIZE = 'Rows';//constant integer UPG_ORC_PULVERIZE  = 'Rows'
		private int UPG_ORC_ENSNARE = 'Roen';//constant integer UPG_ORC_ENSNARE    = 'Roen'
		private int UPG_ORC_VENOM = 'Rovs';//constant integer UPG_ORC_VENOM      = 'Rovs'
		private int UPG_ORC_DOCS = 'Rowd';//constant integer UPG_ORC_DOCS       = 'Rowd'
		private int UPG_ORC_SHAMAN = 'Rost';//constant integer UPG_ORC_SHAMAN     = 'Rost'
		private int UPG_ORC_SPIKES = 'Rosp';//constant integer UPG_ORC_SPIKES     = 'Rosp'
		private int UPG_ORC_BURROWS = 'Rorb';//constant integer UPG_ORC_BURROWS    = 'Rorb'
		private int UPG_ORC_REGEN = 'Rotr';//constant integer UPG_ORC_REGEN      = 'Rotr'
		private int UPG_ORC_FIRE = 'Rolf';//constant integer UPG_ORC_FIRE       = 'Rolf'
		private int UPG_ORC_SWALKER = 'Rowt';//constant integer UPG_ORC_SWALKER    = 'Rowt'
		private int UPG_ORC_BERSERKER = 'Robk';//constant integer UPG_ORC_BERSERKER  = 'Robk'
		private int UPG_ORC_NAPTHA = 'Robf';//constant integer UPG_ORC_NAPTHA     = 'Robf'
		private int UPG_ORC_CHAOS = 'Roch';//constant integer UPG_ORC_CHAOS      = 'Roch'
		//
		private int OGRE_MAGI = 'nomg';//constant integer OGRE_MAGI          = 'nomg'
		private int ORC_DRAGON = 'nrwm';//constant integer ORC_DRAGON         = 'nrwm'
		private int SAPPER = 'ngsp';//constant integer SAPPER             = 'ngsp'
		private int ZEPPLIN = 'nzep';//constant integer ZEPPLIN            = 'nzep'
		private int ZEPPELIN = ZEPPLIN;//constant integer ZEPPELIN           =  ZEPPLIN
		private int W2_WARLOCK = 'nw2w';//constant integer W2_WARLOCK         = 'nw2w'
		private int PIG_FARM = 'npgf';//constant integer PIG_FARM           = 'npgf'
		//
		private int CHAOS_GRUNT = 'nchg';//constant integer CHAOS_GRUNT        = 'nchg'
		private int CHAOS_WARLOCK = 'nchw';//constant integer CHAOS_WARLOCK      = 'nchw'
		private int CHAOS_RAIDER = 'nchr';//constant integer CHAOS_RAIDER       = 'nchr'
		private int CHAOS_PEON = 'ncpn';//constant integer CHAOS_PEON         = 'ncpn'
		private int CHAOS_KODO = 'nckb';//constant integer CHAOS_KODO         = 'nckb'
		private int CHAOS_GROM = 'Opgh';//constant integer CHAOS_GROM         = 'Opgh'
		private int CHAOS_BLADEMASTER = 'Nbbc';//constant integer CHAOS_BLADEMASTER  = 'Nbbc'
		private int CHAOS_BURROW = 'ocbw';//constant integer CHAOS_BURROW       = 'ocbw'
		//
		//
		//
		//
		private int DEATH_KNIGHT = 'Udea';//constant integer DEATH_KNIGHT       = 'Udea'
		private int DREAD_LORD = 'Udre';//constant integer DREAD_LORD         = 'Udre'
		private int LICH = 'Ulic';//constant integer LICH               = 'Ulic'
		private int CRYPT_LORD = 'Ucrl';//constant integer CRYPT_LORD         = 'Ucrl'
		//
		private int MALGANIS = 'Umal';//constant integer MALGANIS           = 'Umal'
		private int TICHONDRIUS = 'Utic';//constant integer TICHONDRIUS        = 'Utic'
		private int PIT_LORD = 'Npld';//constant integer PIT_LORD           = 'Npld'
		private int DETHEROC = 'Udth';//constant integer DETHEROC           = 'Udth'
		//
		private int SLEEP = 'AUsl';//constant integer SLEEP              = 'AUsl'
		private int VAMP_AURA = 'AUav';//constant integer VAMP_AURA          = 'AUav'
		private int CARRION_SWARM = 'AUcs';//constant integer CARRION_SWARM      = 'AUcs'
		private int INFERNO = 'AUin';//constant integer INFERNO            = 'AUin'
		private int DARK_RITUAL = 'AUdr';//constant integer DARK_RITUAL        = 'AUdr'
		private int DEATH_DECAY = 'AUdd';//constant integer DEATH_DECAY        = 'AUdd'
		private int FROST_ARMOR = 'AUfu';//constant integer FROST_ARMOR        = 'AUfu'
		private int FROST_NOVA = 'AUfn';//constant integer FROST_NOVA         = 'AUfn'
		private int ANIM_DEAD = 'AUan';//constant integer ANIM_DEAD          = 'AUan'
		private int DEATH_COIL = 'AUdc';//constant integer DEATH_COIL         = 'AUdc'
		private int DEATH_PACT = 'AUdp';//constant integer DEATH_PACT         = 'AUdp'
		private int UNHOLY_AURA = 'AUau';//constant integer UNHOLY_AURA        = 'AUau'
		private int CARRION_SCARAB = 'AUcb';//constant integer CARRION_SCARAB     = 'AUcb'
		private int IMPALE = 'AUim';//constant integer IMPALE             = 'AUim'
		private int LOCUST_SWARM = 'AUls';//constant integer LOCUST_SWARM       = 'AUls'
		private int THORNY_SHIELD = 'AUts';//constant integer THORNY_SHIELD      = 'AUts'
		//
		private int ABOMINATION = 'uabo';//constant integer ABOMINATION        = 'uabo'
		private int ACOLYTE = 'uaco';//constant integer ACOLYTE            = 'uaco'
		private int BANSHEE = 'uban';//constant integer BANSHEE            = 'uban'
		private int PIT_FIEND = 'ucry';//constant integer PIT_FIEND          = 'ucry'
		private int CRYPT_FIEND = PIT_FIEND;//constant integer CRYPT_FIEND        =  PIT_FIEND
		private int FROST_WYRM = 'ufro';//constant integer FROST_WYRM         = 'ufro'
		private int GARGOYLE = 'ugar';//constant integer GARGOYLE           = 'ugar'
		private int GARGOYLE_MORPH = 'ugrm';//constant integer GARGOYLE_MORPH     = 'ugrm'
		private int GHOUL = 'ugho';//constant integer GHOUL              = 'ugho'
		private int MEAT_WAGON = 'umtw';//constant integer MEAT_WAGON         = 'umtw'
		private int NECRO = 'unec';//constant integer NECRO              = 'unec'
		private int SKEL_WARRIOR = 'uske';//constant integer SKEL_WARRIOR       = 'uske'
		private int SHADE = 'ushd';//constant integer SHADE              = 'ushd'
		private int UNDEAD_BARGE = 'uarb';//constant integer UNDEAD_BARGE       = 'uarb'
		private int OBSIDIAN_STATUE = 'uobs';//constant integer OBSIDIAN_STATUE    = 'uobs'
		private int OBS_STATUE = OBSIDIAN_STATUE;//constant integer OBS_STATUE         =  OBSIDIAN_STATUE
		private int BLK_SPHINX = 'ubsp';//constant integer BLK_SPHINX         = 'ubsp'
		//
		private int UNDEAD_MINE = 'ugol';//constant integer UNDEAD_MINE        = 'ugol'
		private int UNDEAD_ALTAR = 'uaod';//constant integer UNDEAD_ALTAR       = 'uaod'
		private int BONEYARD = 'ubon';//constant integer BONEYARD           = 'ubon'
		private int GARG_SPIRE = 'ugsp';//constant integer GARG_SPIRE         = 'ugsp'
		private int NECROPOLIS_1 = 'unpl';//constant integer NECROPOLIS_1       = 'unpl'
		private int NECROPOLIS_2 = 'unp1';//constant integer NECROPOLIS_2       = 'unp1'
		private int NECROPOLIS_3 = 'unp2';//constant integer NECROPOLIS_3       = 'unp2'
		private int SAC_PIT = 'usap';//constant integer SAC_PIT            = 'usap'
		private int CRYPT = 'usep';//constant integer CRYPT              = 'usep'
		private int SLAUGHTERHOUSE = 'uslh';//constant integer SLAUGHTERHOUSE     = 'uslh'
		private int DAMNED_TEMPLE = 'utod';//constant integer DAMNED_TEMPLE      = 'utod'
		private int ZIGGURAT_1 = 'uzig';//constant integer ZIGGURAT_1         = 'uzig'
		private int ZIGGURAT_2 = 'uzg1';//constant integer ZIGGURAT_2         = 'uzg1'
		private int ZIGGURAT_FROST = 'uzg2';//constant integer ZIGGURAT_FROST     = 'uzg2'
		private int GRAVEYARD = 'ugrv';//constant integer GRAVEYARD          = 'ugrv'
		private int TOMB_OF_RELICS = 'utom';//constant integer TOMB_OF_RELICS     = 'utom'
		//
		private int UPG_UNHOLY_STR = 'Rume';//constant integer UPG_UNHOLY_STR     = 'Rume'
		private int UPG_CR_ATTACK = 'Rura';//constant integer UPG_CR_ATTACK      = 'Rura'
		private int UPG_UNHOLY_ARMOR = 'Ruar';//constant integer UPG_UNHOLY_ARMOR   = 'Ruar'
		private int UPG_CANNIBALIZE = 'Ruac';//constant integer UPG_CANNIBALIZE    = 'Ruac'
		private int UPG_GHOUL_FRENZY = 'Rugf';//constant integer UPG_GHOUL_FRENZY   = 'Rugf'
		private int UPG_FIEND_WEB = 'Ruwb';//constant integer UPG_FIEND_WEB      = 'Ruwb'
		private int UPG_ABOM = 'Ruab';//constant integer UPG_ABOM           = 'Ruab'
		private int UPG_STONE_FORM = 'Rusf';//constant integer UPG_STONE_FORM     = 'Rusf'
		private int UPG_NECROS = 'Rune';//constant integer UPG_NECROS         = 'Rune'
		private int UPG_BANSHEE = 'Ruba';//constant integer UPG_BANSHEE        = 'Ruba'
		private int UPG_MEAT_WAGON = 'Rump';//constant integer UPG_MEAT_WAGON     = 'Rump'
		private int UPG_WYRM_BREATH = 'Rufb';//constant integer UPG_WYRM_BREATH    = 'Rufb'
		private int UPG_SKEL_LIFE = 'Rusl';//constant integer UPG_SKEL_LIFE      = 'Rusl'
		private int UPG_SKEL_MASTERY = 'Rusm';//constant integer UPG_SKEL_MASTERY   = 'Rusm'
		private int UPG_EXHUME = 'Ruex';//constant integer UPG_EXHUME         = 'Ruex'
		private int UPG_SACRIFICE = 'Rurs';//constant integer UPG_SACRIFICE      = 'Rurs'
		private int UPG_ABOM_EXPL = 'Ruax';//constant integer UPG_ABOM_EXPL      = 'Ruax'
		private int UPG_CR_ARMOR = 'Rucr';//constant integer UPG_CR_ARMOR       = 'Rucr'
		private int UPG_PLAGUE = 'Rupc';//constant integer UPG_PLAGUE         = 'Rupc'
		private int UPG_BLK_SPHINX = 'Rusp';//constant integer UPG_BLK_SPHINX     = 'Rusp'
		private int UPG_BURROWING = 'Rubu';//constant integer UPG_BURROWING      = 'Rubu'
		//
		//
		//
		//
		private int DEMON_HUNTER = 'Edem';//constant integer DEMON_HUNTER       = 'Edem'
		private int DEMON_HUNTER_M = 'Edmm';//constant integer DEMON_HUNTER_M     = 'Edmm'
		private int KEEPER = 'Ekee';//constant integer KEEPER             = 'Ekee'
		private int MOON_CHICK = 'Emoo';//constant integer MOON_CHICK         = 'Emoo'
		private int MOON_BABE = MOON_CHICK;//constant integer MOON_BABE          =  MOON_CHICK
		private int MOON_HONEY = MOON_CHICK;//constant integer MOON_HONEY         =  MOON_CHICK
		private int WARDEN = 'Ewar';//constant integer WARDEN             = 'Ewar'
		//
		private int SYLVANUS = 'Hvwd';//constant integer SYLVANUS           = 'Hvwd'
		private int CENARIUS = 'Ecen';//constant integer CENARIUS           = 'Ecen'
		private int ILLIDAN = 'Eevi';//constant integer ILLIDAN            = 'Eevi'
		private int ILLIDAN_DEMON = 'Eevm';//constant integer ILLIDAN_DEMON      = 'Eevm'
		private int MAIEV = 'Ewrd';//constant integer MAIEV              = 'Ewrd'
		//
		private int FORCE_NATURE = 'AEfn';//constant integer FORCE_NATURE       = 'AEfn'
		private int ENT_ROOTS = 'AEer';//constant integer ENT_ROOTS          = 'AEer'
		private int THORNS_AURA = 'AEah';//constant integer THORNS_AURA        = 'AEah'
		private int TRANQUILITY = 'AEtq';//constant integer TRANQUILITY        = 'AEtq'
		private int EVASION = 'AEev';//constant integer EVASION            = 'AEev'
		private int IMMOLATION = 'AEim';//constant integer IMMOLATION         = 'AEim'
		private int MANA_BURN = 'AEmb';//constant integer MANA_BURN          = 'AEmb'
		private int METAMORPHOSIS = 'AEme';//constant integer METAMORPHOSIS      = 'AEme'
		private int SEARING_ARROWS = 'AHfa';//constant integer SEARING_ARROWS     = 'AHfa'
		private int SCOUT = 'AEst';//constant integer SCOUT              = 'AEst'
		private int STARFALL = 'AEsf';//constant integer STARFALL           = 'AEsf'
		private int TRUESHOT = 'AEar';//constant integer TRUESHOT           = 'AEar'
		private int BLINK = 'AEbl';//constant integer BLINK              = 'AEbl'
		private int FAN_KNIVES = 'AEfk';//constant integer FAN_KNIVES         = 'AEfk'
		private int SHADOW_TOUCH = 'AEsh';//constant integer SHADOW_TOUCH       = 'AEsh'
		private int VENGEANCE = 'AEsv';//constant integer VENGEANCE          = 'AEsv'
		//
		private int WISP = 'ewsp';//constant integer WISP               = 'ewsp'
		private int ARCHER = 'earc';//constant integer ARCHER             = 'earc'
		private int DRUID_TALON = 'edot';//constant integer DRUID_TALON        = 'edot'
		private int DRUID_TALON_M = 'edtm';//constant integer DRUID_TALON_M      = 'edtm'
		private int BALLISTA = 'ebal';//constant integer BALLISTA           = 'ebal'
		private int DRUID_CLAW = 'edoc';//constant integer DRUID_CLAW         = 'edoc'
		private int DRUID_CLAW_M = 'edcm';//constant integer DRUID_CLAW_M       = 'edcm'
		private int DRYAD = 'edry';//constant integer DRYAD              = 'edry'
		private int HIPPO = 'ehip';//constant integer HIPPO              = 'ehip'
		private int HIPPO_RIDER = 'ehpr';//constant integer HIPPO_RIDER        = 'ehpr'
		private int HUNTRESS = 'esen';//constant integer HUNTRESS           = 'esen'
		private int CHIMAERA = 'echm';//constant integer CHIMAERA           = 'echm'
		private int ENT = 'efon';//constant integer ENT                = 'efon'
		private int MOUNTAIN_GIANT = 'emtg';//constant integer MOUNTAIN_GIANT     = 'emtg'
		private int FAERIE_DRAGON = 'efdr';//constant integer FAERIE_DRAGON      = 'efdr'
		//
		private int HIGH_ARCHER = 'nhea';//constant integer HIGH_ARCHER        = 'nhea'
		private int HIGH_FOOTMAN = 'hcth';//constant integer HIGH_FOOTMAN       = 'hcth'
		private int HIGH_FOOTMEN = HIGH_FOOTMAN;//constant integer HIGH_FOOTMEN       =  HIGH_FOOTMAN
		private int HIGH_SWORDMAN = 'hhes';//constant integer HIGH_SWORDMAN      = 'hhes'
		private int DRAGON_HAWK = 'nws1';//constant integer DRAGON_HAWK        = 'nws1'
		private int CORRUPT_TREANT = 'nenc';//constant integer CORRUPT_TREANT     = 'nenc'
		private int POISON_TREANT = 'nenp';//constant integer POISON_TREANT      = 'nenp'
		private int PLAGUE_TREANT = 'nepl';//constant integer PLAGUE_TREANT      = 'nepl'
		private int SHANDRIS = 'eshd';//constant integer SHANDRIS           = 'eshd'
		//
		private int ANCIENT_LORE = 'eaoe';//constant integer ANCIENT_LORE       = 'eaoe'
		private int ANCIENT_WAR = 'eaom';//constant integer ANCIENT_WAR        = 'eaom'
		private int ANCIENT_WIND = 'eaow';//constant integer ANCIENT_WIND       = 'eaow'
		private int TREE_AGES = 'etoa';//constant integer TREE_AGES          = 'etoa'
		private int TREE_ETERNITY = 'etoe';//constant integer TREE_ETERNITY      = 'etoe'
		private int TREE_LIFE = 'etol';//constant integer TREE_LIFE          = 'etol'
		private int ANCIENT_PROTECT = 'etrp';//constant integer ANCIENT_PROTECT    = 'etrp'
		private int ELF_ALTAR = 'eate';//constant integer ELF_ALTAR          = 'eate'
		private int BEAR_DEN = 'edol';//constant integer BEAR_DEN           = 'edol'
		private int CHIMAERA_ROOST = 'edos';//constant integer CHIMAERA_ROOST     = 'edos'
		private int HUNTERS_HALL = 'edob';//constant integer HUNTERS_HALL       = 'edob'
		private int MOON_WELL = 'emow';//constant integer MOON_WELL          = 'emow'
		private int ELF_MINE = 'egol';//constant integer ELF_MINE           = 'egol'
		private int DEN_OF_WONDERS = 'eden';//constant integer DEN_OF_WONDERS     = 'eden'
		//
		private int ELF_FARM = 'nefm';//constant integer ELF_FARM           = 'nefm'
		private int ELF_GUARD_TOWER = 'negt';//constant integer ELF_GUARD_TOWER    = 'negt'
		private int HIGH_SKY = 'negm';//constant integer HIGH_SKY           = 'negm'
		private int HIGH_EARTH = 'negf';//constant integer HIGH_EARTH         = 'negf'
		private int HIGH_TOWER = 'negt';//constant integer HIGH_TOWER         = 'negt'
		private int ELF_HIGH_BARRACKS = 'nheb';//constant integer ELF_HIGH_BARRACKS  = 'nheb'
		private int CORRUPT_LIFE = 'nctl';//constant integer CORRUPT_LIFE       = 'nctl'
		private int CORRUPT_WELL = 'ncmw';//constant integer CORRUPT_WELL       = 'ncmw'
		private int CORRUPT_PROTECTOR = 'ncap';//constant integer CORRUPT_PROTECTOR  = 'ncap'
		private int CORRUPT_WAR = 'ncaw';//constant integer CORRUPT_WAR        = 'ncaw'
		//
		private int UPG_STR_MOON = 'Resm';//constant integer UPG_STR_MOON       = 'Resm'
		private int UPG_STR_WILD = 'Resw';//constant integer UPG_STR_WILD       = 'Resw'
		private int UPG_MOON_ARMOR = 'Rema';//constant integer UPG_MOON_ARMOR     = 'Rema'
		private int UPG_HIDES = 'Rerh';//constant integer UPG_HIDES          = 'Rerh'
		private int UPG_ULTRAVISION = 'Reuv';//constant integer UPG_ULTRAVISION    = 'Reuv'
		private int UPG_BLESSING = 'Renb';//constant integer UPG_BLESSING       = 'Renb'
		private int UPG_SCOUT = 'Resc';//constant integer UPG_SCOUT          = 'Resc'
		private int UPG_GLAIVE = 'Remg';//constant integer UPG_GLAIVE         = 'Remg'
		private int UPG_BOWS = 'Reib';//constant integer UPG_BOWS           = 'Reib'
		private int UPG_MARKSMAN = 'Remk';//constant integer UPG_MARKSMAN       = 'Remk'
		private int UPG_DRUID_TALON = 'Redt';//constant integer UPG_DRUID_TALON    = 'Redt'
		private int UPG_DRUID_CLAW = 'Redc';//constant integer UPG_DRUID_CLAW     = 'Redc'
		private int UPG_ABOLISH = 'Resi';//constant integer UPG_ABOLISH        = 'Resi'
		private int UPG_CHIM_ACID = 'Recb';//constant integer UPG_CHIM_ACID      = 'Recb'
		private int UPG_HIPPO_TAME = 'Reht';//constant integer UPG_HIPPO_TAME     = 'Reht'
		private int UPG_BOLT = 'Repd';//constant integer UPG_BOLT           = 'Repd'
		private int UPG_MARK_CLAW = 'Reeb';//constant integer UPG_MARK_CLAW      = 'Reeb'
		private int UPG_MARK_TALON = 'Reec';//constant integer UPG_MARK_TALON     = 'Reec'
		private int UPG_HARD_SKIN = 'Rehs';//constant integer UPG_HARD_SKIN      = 'Rehs'
		private int UPG_RESIST_SKIN = 'Rers';//constant integer UPG_RESIST_SKIN    = 'Rers'
		private int UPG_WELL_SPRING = 'Rews';//constant integer UPG_WELL_SPRING    = 'Rews'
		//
		//
		//
		private int DEMON_GATE = 'ndmg';//constant integer DEMON_GATE         = 'ndmg'
		private int FELLHOUND = 'nfel';//constant integer FELLHOUND          = 'nfel'
		private int INFERNAL = 'ninf';//constant integer INFERNAL           = 'ninf'
		private int DOOMGUARD = 'nbal';//constant integer DOOMGUARD          = 'nbal'
		private int SATYR = 'nsty';//constant integer SATYR              = 'nsty'
		private int TRICKSTER = 'nsat';//constant integer TRICKSTER          = 'nsat'
		private int SHADOWDANCER = 'nsts';//constant integer SHADOWDANCER       = 'nsts'
		private int SOULSTEALER = 'nstl';//constant integer SOULSTEALER        = 'nstl'
		private int HELLCALLER = 'nsth';//constant integer HELLCALLER         = 'nsth'
		private int SKEL_ARCHER = 'nska';//constant integer SKEL_ARCHER        = 'nska'
		private int SKEL_MARKSMAN = 'nskm';//constant integer SKEL_MARKSMAN      = 'nskm'
		private int SKEL_BURNING = 'nskf';//constant integer SKEL_BURNING       = 'nskf'
		private int SKEL_GIANT = 'nskg';//constant integer SKEL_GIANT         = 'nskg'
		private int FURBOLG = 'nfrl';//constant integer FURBOLG            = 'nfrl'
		private int FURBOLG_TRACKER = 'nfrb';//constant integer FURBOLG_TRACKER    = 'nfrb'
		private int FURBOLG_SHAMAN = 'nfrs';//constant integer FURBOLG_SHAMAN     = 'nfrs'
		private int FURBOLG_CHAMP = 'nfrg';//constant integer FURBOLG_CHAMP      = 'nfrg'
		private int FURBOLG_ELDER = 'nfre';//constant integer FURBOLG_ELDER      = 'nfre'
		//
		//
		//
		//
		private int NAGA_SORCERESS = 'Nngs';//constant integer NAGA_SORCERESS     = 'Nngs'
		private int NAGA_VASHJ = 'Hvsh';//constant integer NAGA_VASHJ         = 'Hvsh'
		//
		private int NAGA_DRAGON = 'nsnp';//constant integer NAGA_DRAGON        = 'nsnp'
		private int NAGA_WITCH = 'nnsw';//constant integer NAGA_WITCH         = 'nnsw'
		private int NAGA_SERPENT = 'nwgs';//constant integer NAGA_SERPENT       = 'nwgs'
		private int NAGA_HYDRA = 'nhyc';//constant integer NAGA_HYDRA         = 'nhyc'
		private int NAGA_SLAVE = 'nmpe';//constant integer NAGA_SLAVE         = 'nmpe'
		private int NAGA_SNAP_DRAGON = NAGA_DRAGON;//constant integer NAGA_SNAP_DRAGON   =  NAGA_DRAGON
		private int NAGA_COUATL = NAGA_SERPENT;//constant integer NAGA_COUATL        =  NAGA_SERPENT
		private int NAGA_SIREN = NAGA_WITCH;//constant integer NAGA_SIREN         =  NAGA_WITCH
		private int NAGA_MYRMIDON = 'nmyr';//constant integer NAGA_MYRMIDON      = 'nmyr'
		private int NAGA_REAVER = 'nnmg';//constant integer NAGA_REAVER        = 'nnmg'
		private int NAGA_TURTLE = NAGA_HYDRA;//constant integer NAGA_TURTLE        =  NAGA_HYDRA
		private int NAGA_ROYAL = 'nnrg';//constant integer NAGA_ROYAL         = 'nnrg'
		//
		private int NAGA_TEMPLE = 'nntt';//constant integer NAGA_TEMPLE        = 'nntt'
		private int NAGA_CORAL = 'nnfm';//constant integer NAGA_CORAL         = 'nnfm'
		private int NAGA_SHRINE = 'nnsa';//constant integer NAGA_SHRINE        = 'nnsa'
		private int NAGA_SPAWNING = 'nnsg';//constant integer NAGA_SPAWNING      = 'nnsg'
		private int NAGA_GUARDIAN = 'nntg';//constant integer NAGA_GUARDIAN      = 'nntg'
		private int NAGA_ALTAR = 'nnad';//constant integer NAGA_ALTAR         = 'nnad'
		//
		private int UPG_NAGA_ARMOR = 'Rnam';//constant integer UPG_NAGA_ARMOR     = 'Rnam'
		private int UPG_NAGA_ATTACK = 'Rnat';//constant integer UPG_NAGA_ATTACK    = 'Rnat'
		private int UPG_NAGA_ABOLISH = 'Rnsi';//constant integer UPG_NAGA_ABOLISH   = 'Rnsi'
		private int UPG_SIREN = 'Rnsw';//constant integer UPG_SIREN          = 'Rnsw'
		private int UPG_NAGA_ENSNARE = 'Rnen';//constant integer UPG_NAGA_ENSNARE   = 'Rnen'
		//
		private int M1 = 60;//constant integer M1                 =    60
		private int M2 = 2*60;//constant integer M2                 =  2*60
		private int M3 = 3*60;//constant integer M3                 =  3*60
		private int M4 = 4*60;//constant integer M4                 =  4*60
		private int M5 = 5*60;//constant integer M5                 =  5*60
		private int M6 = 6*60;//constant integer M6                 =  6*60
		private int M7 = 7*60;//constant integer M7                 =  7*60
		private int M8 = 8*60;//constant integer M8                 =  8*60
		private int M9 = 9*60;//constant integer M9                 =  9*60
		private int M10 = 10*60;//constant integer M10                = 10*60
		private int M11 = 11*60;//constant integer M11                = 11*60
		private int M12 = 12*60;//constant integer M12                = 12*60
		private int M13 = 13*60;//constant integer M13                = 13*60
		private int M14 = 14*60;//constant integer M14                = 14*60
		private int M15 = 15*60;//constant integer M15                = 15*60
		private int EASY = 1;//constant integer EASY               = 1
		private int NORMAL = 2;//constant integer NORMAL             = 2
		private int HARD = 3;//constant integer HARD               = 3
		private int INSANE = 4;//constant integer INSANE             = 4
		private int MELEE_NEWBIE = 1;//constant integer MELEE_NEWBIE       = 1
		private int MELEE_NORMAL = 2;//constant integer MELEE_NORMAL       = 2
		private int MELEE_INSANE = 3;//constant integer MELEE_INSANE       = 3
		private int ATTACK_CAPTAIN = 1;//constant integer ATTACK_CAPTAIN     = 1
		private int DEFENSE_CAPTAIN = 2;//constant integer DEFENSE_CAPTAIN    = 2
		private int BOTH_CAPTAINS = 3;//constant integer BOTH_CAPTAINS      = 3
		private int BUILD_UNIT = 1;//constant integer BUILD_UNIT         = 1
		private int BUILD_UPGRADE = 2;//constant integer BUILD_UPGRADE      = 2
		private int BUILD_EXPAND = 3;//constant integer BUILD_EXPAND       = 3
		private int UPKEEP_TIER1 = 50;//constant integer UPKEEP_TIER1       = 50
		private int UPKEEP_TIER2 = 80;//constant integer UPKEEP_TIER2       = 80
		//
		private player ai_player;//player  ai_player
		private int sleep_seconds;//integer sleep_seconds
		private int total_gold = 0;//integer total_gold              = 0
		private int total_wood = 0;//integer total_wood              = 0
		private int gold_buffer = 0;//integer gold_buffer             = 0
		private int difficulty = NORMAL;//integer difficulty              = NORMAL
		private int exp_seen = 0;//integer exp_seen                = 0
		private int racial_farm = 'hhou';//integer racial_farm             = 'hhou'
		private int hero_id = 'Hamg';//integer hero_id                 = 'Hamg'
		private int hero_id2 = 'Hmkg';//integer hero_id2                = 'Hmkg'
		private int hero_id3 = 'Hpal';//integer hero_id3                = 'Hpal'
		private int[] skill;//integer array skill
		private int[] skills1;//integer array skills1
		private int[] skills2;//integer array skills2
		private int[] skills3;//integer array skills3
		private int max_hero_level = 0;//integer max_hero_level          = 0
		private int[] harass_qty;//integer array harass_qty
		private int[] harass_max;//integer array harass_max
		private int[] harass_units;//integer array harass_units
		private int harass_length = 0;//integer harass_length           = 0
		private int[] defense_qty;//integer array defense_qty
		private int[] defense_units;//integer array defense_units
		private int defense_length = 0;//integer defense_length          = 0
		private int[] build_qty;//integer array build_qty
		private int[] build_type;//integer array build_type
		private int[] build_item;//integer array build_item
		private int[] build_town;//integer array build_town
		private int build_length = 0;//integer build_length            = 0
		private int campaign_gold_peons = 5;//integer campaign_gold_peons     = 5
		private int campaign_wood_peons = 3;//integer campaign_wood_peons     = 3
		private int campaign_basics_speed = 5;//integer campaign_basics_speed   = 5
		private int min_creeps = -1;//integer min_creeps              = -1
		private int max_creeps = -1;//integer max_creeps              = -1
		private bool harvest_town1 = true;//boolean harvest_town1           = true
		private bool harvest_town2 = true;//boolean harvest_town2           = true
		private bool harvest_town3 = true;//boolean harvest_town3           = true
		private bool do_campaign_farms = true;//boolean do_campaign_farms       = true
		private bool two_heroes = false;//boolean two_heroes              = false
		private bool allow_air_creeps = false;//boolean allow_air_creeps        = false
		private bool take_exp = false;//boolean take_exp                = false
		private bool allow_signal_abort = false;//boolean allow_signal_abort      = false
		private bool ready_for_zeppelin = true;//boolean ready_for_zeppelin      = true
		private bool get_zeppelin = false;//boolean get_zeppelin            = false
		private bool build_campaign_attackers = true;//boolean build_campaign_attackers = true
		private bool do_debug_cheats = false;//boolean do_debug_cheats         = false
		private bool trace_on = true;//boolean trace_on                = true
		private bool zep_next_wave = false;//boolean zep_next_wave           = false
		private bool form_group_timeouts = true;//boolean form_group_timeouts     = true
		//
		//
		//
		//
		private bool FALSE = false;//constant boolean            FALSE                           = false
		private bool TRUE = true;//constant boolean            TRUE                            = true
		private int JASS_MAX_ARRAY_SIZE = 8192;//constant integer            JASS_MAX_ARRAY_SIZE             = 8192
		private int PLAYER_NEUTRAL_PASSIVE = 15;//constant integer            PLAYER_NEUTRAL_PASSIVE          = 15
		private int PLAYER_NEUTRAL_AGGRESSIVE = 12;//constant integer            PLAYER_NEUTRAL_AGGRESSIVE       = 12
		private playercolor PLAYER_COLOR_RED = ConvertPlayerColor(0);//constant playercolor        PLAYER_COLOR_RED                = ConvertPlayerColor(0)
		private playercolor PLAYER_COLOR_BLUE = ConvertPlayerColor(1);//constant playercolor        PLAYER_COLOR_BLUE               = ConvertPlayerColor(1)
		private playercolor PLAYER_COLOR_CYAN = ConvertPlayerColor(2);//constant playercolor        PLAYER_COLOR_CYAN               = ConvertPlayerColor(2)
		private playercolor PLAYER_COLOR_PURPLE = ConvertPlayerColor(3);//constant playercolor        PLAYER_COLOR_PURPLE             = ConvertPlayerColor(3)
		private playercolor PLAYER_COLOR_YELLOW = ConvertPlayerColor(4);//constant playercolor        PLAYER_COLOR_YELLOW             = ConvertPlayerColor(4)
		private playercolor PLAYER_COLOR_ORANGE = ConvertPlayerColor(5);//constant playercolor        PLAYER_COLOR_ORANGE             = ConvertPlayerColor(5)
		private playercolor PLAYER_COLOR_GREEN = ConvertPlayerColor(6);//constant playercolor        PLAYER_COLOR_GREEN              = ConvertPlayerColor(6)
		private playercolor PLAYER_COLOR_PINK = ConvertPlayerColor(7);//constant playercolor        PLAYER_COLOR_PINK               = ConvertPlayerColor(7)
		private playercolor PLAYER_COLOR_LIGHT_GRAY = ConvertPlayerColor(8);//constant playercolor        PLAYER_COLOR_LIGHT_GRAY         = ConvertPlayerColor(8)
		private playercolor PLAYER_COLOR_LIGHT_BLUE = ConvertPlayerColor(9);//constant playercolor        PLAYER_COLOR_LIGHT_BLUE         = ConvertPlayerColor(9)
		private playercolor PLAYER_COLOR_AQUA = ConvertPlayerColor(10);//constant playercolor        PLAYER_COLOR_AQUA               = ConvertPlayerColor(10)
		private playercolor PLAYER_COLOR_BROWN = ConvertPlayerColor(11);//constant playercolor        PLAYER_COLOR_BROWN              = ConvertPlayerColor(11)
		private race RACE_HUMAN = ConvertRace(1);//constant race               RACE_HUMAN                      = ConvertRace(1)
		private race RACE_ORC = ConvertRace(2);//constant race               RACE_ORC                        = ConvertRace(2)
		private race RACE_UNDEAD = ConvertRace(3);//constant race               RACE_UNDEAD                     = ConvertRace(3)
		private race RACE_NIGHTELF = ConvertRace(4);//constant race               RACE_NIGHTELF                   = ConvertRace(4)
		private race RACE_DEMON = ConvertRace(5);//constant race               RACE_DEMON                      = ConvertRace(5)
		private race RACE_OTHER = ConvertRace(7);//constant race               RACE_OTHER                      = ConvertRace(7)
		private playergameresult PLAYER_GAME_RESULT_VICTORY = ConvertPlayerGameResult(0);//constant playergameresult   PLAYER_GAME_RESULT_VICTORY      = ConvertPlayerGameResult(0)
		private playergameresult PLAYER_GAME_RESULT_DEFEAT = ConvertPlayerGameResult(1);//constant playergameresult   PLAYER_GAME_RESULT_DEFEAT       = ConvertPlayerGameResult(1)
		private playergameresult PLAYER_GAME_RESULT_TIE = ConvertPlayerGameResult(2);//constant playergameresult   PLAYER_GAME_RESULT_TIE          = ConvertPlayerGameResult(2)
		private playergameresult PLAYER_GAME_RESULT_NEUTRAL = ConvertPlayerGameResult(3);//constant playergameresult   PLAYER_GAME_RESULT_NEUTRAL      = ConvertPlayerGameResult(3)
		private alliancetype ALLIANCE_PASSIVE = ConvertAllianceType(0);//constant alliancetype       ALLIANCE_PASSIVE                = ConvertAllianceType(0)
		private alliancetype ALLIANCE_HELP_REQUEST = ConvertAllianceType(1);//constant alliancetype       ALLIANCE_HELP_REQUEST           = ConvertAllianceType(1)
		private alliancetype ALLIANCE_HELP_RESPONSE = ConvertAllianceType(2);//constant alliancetype       ALLIANCE_HELP_RESPONSE          = ConvertAllianceType(2)
		private alliancetype ALLIANCE_SHARED_XP = ConvertAllianceType(3);//constant alliancetype       ALLIANCE_SHARED_XP              = ConvertAllianceType(3)
		private alliancetype ALLIANCE_SHARED_SPELLS = ConvertAllianceType(4);//constant alliancetype       ALLIANCE_SHARED_SPELLS          = ConvertAllianceType(4)
		private alliancetype ALLIANCE_SHARED_VISION = ConvertAllianceType(5);//constant alliancetype       ALLIANCE_SHARED_VISION          = ConvertAllianceType(5)
		private alliancetype ALLIANCE_SHARED_CONTROL = ConvertAllianceType(6);//constant alliancetype       ALLIANCE_SHARED_CONTROL         = ConvertAllianceType(6)
		private alliancetype ALLIANCE_SHARED_ADVANCED_CONTROL = ConvertAllianceType(7);//constant alliancetype       ALLIANCE_SHARED_ADVANCED_CONTROL= ConvertAllianceType(7)
		private alliancetype ALLIANCE_RESCUABLE = ConvertAllianceType(8);//constant alliancetype       ALLIANCE_RESCUABLE              = ConvertAllianceType(8)
		private alliancetype ALLIANCE_SHARED_VISION_FORCED = ConvertAllianceType(9);//constant alliancetype       ALLIANCE_SHARED_VISION_FORCED   = ConvertAllianceType(9)
		private version VERSION_REIGN_OF_CHAOS = ConvertVersion(0);//constant version            VERSION_REIGN_OF_CHAOS          = ConvertVersion(0)
		private version VERSION_FROZEN_THRONE = ConvertVersion(1);//constant version            VERSION_FROZEN_THRONE           = ConvertVersion(1)
		private attacktype ATTACK_TYPE_NORMAL = ConvertAttackType(0);//constant attacktype         ATTACK_TYPE_NORMAL              = ConvertAttackType(0)
		private attacktype ATTACK_TYPE_MELEE = ConvertAttackType(1);//constant attacktype         ATTACK_TYPE_MELEE               = ConvertAttackType(1)
		private attacktype ATTACK_TYPE_PIERCE = ConvertAttackType(2);//constant attacktype         ATTACK_TYPE_PIERCE              = ConvertAttackType(2)
		private attacktype ATTACK_TYPE_SIEGE = ConvertAttackType(3);//constant attacktype         ATTACK_TYPE_SIEGE               = ConvertAttackType(3)
		private attacktype ATTACK_TYPE_MAGIC = ConvertAttackType(4);//constant attacktype         ATTACK_TYPE_MAGIC               = ConvertAttackType(4)
		private attacktype ATTACK_TYPE_CHAOS = ConvertAttackType(5);//constant attacktype         ATTACK_TYPE_CHAOS               = ConvertAttackType(5)
		private attacktype ATTACK_TYPE_HERO = ConvertAttackType(6);//constant attacktype         ATTACK_TYPE_HERO                = ConvertAttackType(6)
		private damagetype DAMAGE_TYPE_UNKNOWN = ConvertDamageType(0);//constant damagetype         DAMAGE_TYPE_UNKNOWN             = ConvertDamageType(0)
		private damagetype DAMAGE_TYPE_NORMAL = ConvertDamageType(4);//constant damagetype         DAMAGE_TYPE_NORMAL              = ConvertDamageType(4)
		private damagetype DAMAGE_TYPE_ENHANCED = ConvertDamageType(5);//constant damagetype         DAMAGE_TYPE_ENHANCED            = ConvertDamageType(5)
		private damagetype DAMAGE_TYPE_FIRE = ConvertDamageType(8);//constant damagetype         DAMAGE_TYPE_FIRE                = ConvertDamageType(8)
		private damagetype DAMAGE_TYPE_COLD = ConvertDamageType(9);//constant damagetype         DAMAGE_TYPE_COLD                = ConvertDamageType(9)
		private damagetype DAMAGE_TYPE_LIGHTNING = ConvertDamageType(10);//constant damagetype         DAMAGE_TYPE_LIGHTNING           = ConvertDamageType(10)
		private damagetype DAMAGE_TYPE_POISON = ConvertDamageType(11);//constant damagetype         DAMAGE_TYPE_POISON              = ConvertDamageType(11)
		private damagetype DAMAGE_TYPE_DISEASE = ConvertDamageType(12);//constant damagetype         DAMAGE_TYPE_DISEASE             = ConvertDamageType(12)
		private damagetype DAMAGE_TYPE_DIVINE = ConvertDamageType(13);//constant damagetype         DAMAGE_TYPE_DIVINE              = ConvertDamageType(13)
		private damagetype DAMAGE_TYPE_MAGIC = ConvertDamageType(14);//constant damagetype         DAMAGE_TYPE_MAGIC               = ConvertDamageType(14)
		private damagetype DAMAGE_TYPE_SONIC = ConvertDamageType(15);//constant damagetype         DAMAGE_TYPE_SONIC               = ConvertDamageType(15)
		private damagetype DAMAGE_TYPE_ACID = ConvertDamageType(16);//constant damagetype         DAMAGE_TYPE_ACID                = ConvertDamageType(16)
		private damagetype DAMAGE_TYPE_FORCE = ConvertDamageType(17);//constant damagetype         DAMAGE_TYPE_FORCE               = ConvertDamageType(17)
		private damagetype DAMAGE_TYPE_DEATH = ConvertDamageType(18);//constant damagetype         DAMAGE_TYPE_DEATH               = ConvertDamageType(18)
		private damagetype DAMAGE_TYPE_MIND = ConvertDamageType(19);//constant damagetype         DAMAGE_TYPE_MIND                = ConvertDamageType(19)
		private damagetype DAMAGE_TYPE_PLANT = ConvertDamageType(20);//constant damagetype         DAMAGE_TYPE_PLANT               = ConvertDamageType(20)
		private damagetype DAMAGE_TYPE_DEFENSIVE = ConvertDamageType(21);//constant damagetype         DAMAGE_TYPE_DEFENSIVE           = ConvertDamageType(21)
		private damagetype DAMAGE_TYPE_DEMOLITION = ConvertDamageType(22);//constant damagetype         DAMAGE_TYPE_DEMOLITION          = ConvertDamageType(22)
		private damagetype DAMAGE_TYPE_SLOW_POISON = ConvertDamageType(23);//constant damagetype         DAMAGE_TYPE_SLOW_POISON         = ConvertDamageType(23)
		private damagetype DAMAGE_TYPE_SPIRIT_LINK = ConvertDamageType(24);//constant damagetype         DAMAGE_TYPE_SPIRIT_LINK         = ConvertDamageType(24)
		private damagetype DAMAGE_TYPE_SHADOW_STRIKE = ConvertDamageType(25);//constant damagetype         DAMAGE_TYPE_SHADOW_STRIKE       = ConvertDamageType(25)
		private damagetype DAMAGE_TYPE_UNIVERSAL = ConvertDamageType(26);//constant damagetype         DAMAGE_TYPE_UNIVERSAL           = ConvertDamageType(26)
		private weapontype WEAPON_TYPE_WHOKNOWS = ConvertWeaponType(0);//constant weapontype         WEAPON_TYPE_WHOKNOWS            = ConvertWeaponType(0)
		private weapontype WEAPON_TYPE_METAL_LIGHT_CHOP = ConvertWeaponType(1);//constant weapontype         WEAPON_TYPE_METAL_LIGHT_CHOP    = ConvertWeaponType(1)
		private weapontype WEAPON_TYPE_METAL_MEDIUM_CHOP = ConvertWeaponType(2);//constant weapontype         WEAPON_TYPE_METAL_MEDIUM_CHOP   = ConvertWeaponType(2)
		private weapontype WEAPON_TYPE_METAL_HEAVY_CHOP = ConvertWeaponType(3);//constant weapontype         WEAPON_TYPE_METAL_HEAVY_CHOP    = ConvertWeaponType(3)
		private weapontype WEAPON_TYPE_METAL_LIGHT_SLICE = ConvertWeaponType(4);//constant weapontype         WEAPON_TYPE_METAL_LIGHT_SLICE   = ConvertWeaponType(4)
		private weapontype WEAPON_TYPE_METAL_MEDIUM_SLICE = ConvertWeaponType(5);//constant weapontype         WEAPON_TYPE_METAL_MEDIUM_SLICE  = ConvertWeaponType(5)
		private weapontype WEAPON_TYPE_METAL_HEAVY_SLICE = ConvertWeaponType(6);//constant weapontype         WEAPON_TYPE_METAL_HEAVY_SLICE   = ConvertWeaponType(6)
		private weapontype WEAPON_TYPE_METAL_MEDIUM_BASH = ConvertWeaponType(7);//constant weapontype         WEAPON_TYPE_METAL_MEDIUM_BASH   = ConvertWeaponType(7)
		private weapontype WEAPON_TYPE_METAL_HEAVY_BASH = ConvertWeaponType(8);//constant weapontype         WEAPON_TYPE_METAL_HEAVY_BASH    = ConvertWeaponType(8)
		private weapontype WEAPON_TYPE_METAL_MEDIUM_STAB = ConvertWeaponType(9);//constant weapontype         WEAPON_TYPE_METAL_MEDIUM_STAB   = ConvertWeaponType(9)
		private weapontype WEAPON_TYPE_METAL_HEAVY_STAB = ConvertWeaponType(10);//constant weapontype         WEAPON_TYPE_METAL_HEAVY_STAB    = ConvertWeaponType(10)
		private weapontype WEAPON_TYPE_WOOD_LIGHT_SLICE = ConvertWeaponType(11);//constant weapontype         WEAPON_TYPE_WOOD_LIGHT_SLICE    = ConvertWeaponType(11)
		private weapontype WEAPON_TYPE_WOOD_MEDIUM_SLICE = ConvertWeaponType(12);//constant weapontype         WEAPON_TYPE_WOOD_MEDIUM_SLICE   = ConvertWeaponType(12)
		private weapontype WEAPON_TYPE_WOOD_HEAVY_SLICE = ConvertWeaponType(13);//constant weapontype         WEAPON_TYPE_WOOD_HEAVY_SLICE    = ConvertWeaponType(13)
		private weapontype WEAPON_TYPE_WOOD_LIGHT_BASH = ConvertWeaponType(14);//constant weapontype         WEAPON_TYPE_WOOD_LIGHT_BASH     = ConvertWeaponType(14)
		private weapontype WEAPON_TYPE_WOOD_MEDIUM_BASH = ConvertWeaponType(15);//constant weapontype         WEAPON_TYPE_WOOD_MEDIUM_BASH    = ConvertWeaponType(15)
		private weapontype WEAPON_TYPE_WOOD_HEAVY_BASH = ConvertWeaponType(16);//constant weapontype         WEAPON_TYPE_WOOD_HEAVY_BASH     = ConvertWeaponType(16)
		private weapontype WEAPON_TYPE_WOOD_LIGHT_STAB = ConvertWeaponType(17);//constant weapontype         WEAPON_TYPE_WOOD_LIGHT_STAB     = ConvertWeaponType(17)
		private weapontype WEAPON_TYPE_WOOD_MEDIUM_STAB = ConvertWeaponType(18);//constant weapontype         WEAPON_TYPE_WOOD_MEDIUM_STAB    = ConvertWeaponType(18)
		private weapontype WEAPON_TYPE_CLAW_LIGHT_SLICE = ConvertWeaponType(19);//constant weapontype         WEAPON_TYPE_CLAW_LIGHT_SLICE    = ConvertWeaponType(19)
		private weapontype WEAPON_TYPE_CLAW_MEDIUM_SLICE = ConvertWeaponType(20);//constant weapontype         WEAPON_TYPE_CLAW_MEDIUM_SLICE   = ConvertWeaponType(20)
		private weapontype WEAPON_TYPE_CLAW_HEAVY_SLICE = ConvertWeaponType(21);//constant weapontype         WEAPON_TYPE_CLAW_HEAVY_SLICE    = ConvertWeaponType(21)
		private weapontype WEAPON_TYPE_AXE_MEDIUM_CHOP = ConvertWeaponType(22);//constant weapontype         WEAPON_TYPE_AXE_MEDIUM_CHOP     = ConvertWeaponType(22)
		private weapontype WEAPON_TYPE_ROCK_HEAVY_BASH = ConvertWeaponType(23);//constant weapontype         WEAPON_TYPE_ROCK_HEAVY_BASH     = ConvertWeaponType(23)
		private pathingtype PATHING_TYPE_ANY = ConvertPathingType(0);//constant pathingtype        PATHING_TYPE_ANY                = ConvertPathingType(0)
		private pathingtype PATHING_TYPE_WALKABILITY = ConvertPathingType(1);//constant pathingtype        PATHING_TYPE_WALKABILITY        = ConvertPathingType(1)
		private pathingtype PATHING_TYPE_FLYABILITY = ConvertPathingType(2);//constant pathingtype        PATHING_TYPE_FLYABILITY         = ConvertPathingType(2)
		private pathingtype PATHING_TYPE_BUILDABILITY = ConvertPathingType(3);//constant pathingtype        PATHING_TYPE_BUILDABILITY       = ConvertPathingType(3)
		private pathingtype PATHING_TYPE_PEONHARVESTPATHING = ConvertPathingType(4);//constant pathingtype        PATHING_TYPE_PEONHARVESTPATHING = ConvertPathingType(4)
		private pathingtype PATHING_TYPE_BLIGHTPATHING = ConvertPathingType(5);//constant pathingtype        PATHING_TYPE_BLIGHTPATHING      = ConvertPathingType(5)
		private pathingtype PATHING_TYPE_FLOATABILITY = ConvertPathingType(6);//constant pathingtype        PATHING_TYPE_FLOATABILITY       = ConvertPathingType(6)
		private pathingtype PATHING_TYPE_AMPHIBIOUSPATHING = ConvertPathingType(7);//constant pathingtype        PATHING_TYPE_AMPHIBIOUSPATHING  = ConvertPathingType(7)
		//
		//
		//
		private racepreference RACE_PREF_HUMAN = ConvertRacePref(1);//constant racepreference     RACE_PREF_HUMAN                     = ConvertRacePref(1)
		private racepreference RACE_PREF_ORC = ConvertRacePref(2);//constant racepreference     RACE_PREF_ORC                       = ConvertRacePref(2)
		private racepreference RACE_PREF_NIGHTELF = ConvertRacePref(4);//constant racepreference     RACE_PREF_NIGHTELF                  = ConvertRacePref(4)
		private racepreference RACE_PREF_UNDEAD = ConvertRacePref(8);//constant racepreference     RACE_PREF_UNDEAD                    = ConvertRacePref(8)
		private racepreference RACE_PREF_DEMON = ConvertRacePref(16);//constant racepreference     RACE_PREF_DEMON                     = ConvertRacePref(16)
		private racepreference RACE_PREF_RANDOM = ConvertRacePref(32);//constant racepreference     RACE_PREF_RANDOM                    = ConvertRacePref(32)
		private racepreference RACE_PREF_USER_SELECTABLE = ConvertRacePref(64);//constant racepreference     RACE_PREF_USER_SELECTABLE           = ConvertRacePref(64)
		private mapcontrol MAP_CONTROL_USER = ConvertMapControl(0);//constant mapcontrol         MAP_CONTROL_USER                    = ConvertMapControl(0)
		private mapcontrol MAP_CONTROL_COMPUTER = ConvertMapControl(1);//constant mapcontrol         MAP_CONTROL_COMPUTER                = ConvertMapControl(1)
		private mapcontrol MAP_CONTROL_RESCUABLE = ConvertMapControl(2);//constant mapcontrol         MAP_CONTROL_RESCUABLE               = ConvertMapControl(2)
		private mapcontrol MAP_CONTROL_NEUTRAL = ConvertMapControl(3);//constant mapcontrol         MAP_CONTROL_NEUTRAL                 = ConvertMapControl(3)
		private mapcontrol MAP_CONTROL_CREEP = ConvertMapControl(4);//constant mapcontrol         MAP_CONTROL_CREEP                   = ConvertMapControl(4)
		private mapcontrol MAP_CONTROL_NONE = ConvertMapControl(5);//constant mapcontrol         MAP_CONTROL_NONE                    = ConvertMapControl(5)
		private gametype GAME_TYPE_MELEE = ConvertGameType(1);//constant gametype           GAME_TYPE_MELEE                     = ConvertGameType(1)
		private gametype GAME_TYPE_FFA = ConvertGameType(2);//constant gametype           GAME_TYPE_FFA                       = ConvertGameType(2)
		private gametype GAME_TYPE_USE_MAP_SETTINGS = ConvertGameType(4);//constant gametype           GAME_TYPE_USE_MAP_SETTINGS          = ConvertGameType(4)
		private gametype GAME_TYPE_BLIZ = ConvertGameType(8);//constant gametype           GAME_TYPE_BLIZ                      = ConvertGameType(8)
		private gametype GAME_TYPE_ONE_ON_ONE = ConvertGameType(16);//constant gametype           GAME_TYPE_ONE_ON_ONE                = ConvertGameType(16)
		private gametype GAME_TYPE_TWO_TEAM_PLAY = ConvertGameType(32);//constant gametype           GAME_TYPE_TWO_TEAM_PLAY             = ConvertGameType(32)
		private gametype GAME_TYPE_THREE_TEAM_PLAY = ConvertGameType(64);//constant gametype           GAME_TYPE_THREE_TEAM_PLAY           = ConvertGameType(64)
		private gametype GAME_TYPE_FOUR_TEAM_PLAY = ConvertGameType(128);//constant gametype           GAME_TYPE_FOUR_TEAM_PLAY            = ConvertGameType(128)
		private mapflag MAP_FOG_HIDE_TERRAIN = ConvertMapFlag(1);//constant mapflag            MAP_FOG_HIDE_TERRAIN                = ConvertMapFlag(1)
		private mapflag MAP_FOG_MAP_EXPLORED = ConvertMapFlag(2);//constant mapflag            MAP_FOG_MAP_EXPLORED                = ConvertMapFlag(2)
		private mapflag MAP_FOG_ALWAYS_VISIBLE = ConvertMapFlag(4);//constant mapflag            MAP_FOG_ALWAYS_VISIBLE              = ConvertMapFlag(4)
		private mapflag MAP_USE_HANDICAPS = ConvertMapFlag(8);//constant mapflag            MAP_USE_HANDICAPS                   = ConvertMapFlag(8)
		private mapflag MAP_OBSERVERS = ConvertMapFlag(16);//constant mapflag            MAP_OBSERVERS                       = ConvertMapFlag(16)
		private mapflag MAP_OBSERVERS_ON_DEATH = ConvertMapFlag(32);//constant mapflag            MAP_OBSERVERS_ON_DEATH              = ConvertMapFlag(32)
		private mapflag MAP_FIXED_COLORS = ConvertMapFlag(128);//constant mapflag            MAP_FIXED_COLORS                    = ConvertMapFlag(128)
		private mapflag MAP_LOCK_RESOURCE_TRADING = ConvertMapFlag(256);//constant mapflag            MAP_LOCK_RESOURCE_TRADING           = ConvertMapFlag(256)
		private mapflag MAP_RESOURCE_TRADING_ALLIES_ONLY = ConvertMapFlag(512);//constant mapflag            MAP_RESOURCE_TRADING_ALLIES_ONLY    = ConvertMapFlag(512)
		private mapflag MAP_LOCK_ALLIANCE_CHANGES = ConvertMapFlag(1024);//constant mapflag            MAP_LOCK_ALLIANCE_CHANGES           = ConvertMapFlag(1024)
		private mapflag MAP_ALLIANCE_CHANGES_HIDDEN = ConvertMapFlag(2048);//constant mapflag            MAP_ALLIANCE_CHANGES_HIDDEN         = ConvertMapFlag(2048)
		private mapflag MAP_CHEATS = ConvertMapFlag(4096);//constant mapflag            MAP_CHEATS                          = ConvertMapFlag(4096)
		private mapflag MAP_CHEATS_HIDDEN = ConvertMapFlag(8192);//constant mapflag            MAP_CHEATS_HIDDEN                   = ConvertMapFlag(8192)
		private mapflag MAP_LOCK_SPEED = ConvertMapFlag(8192*2);//constant mapflag            MAP_LOCK_SPEED                      = ConvertMapFlag(8192*2)
		private mapflag MAP_LOCK_RANDOM_SEED = ConvertMapFlag(8192*4);//constant mapflag            MAP_LOCK_RANDOM_SEED                = ConvertMapFlag(8192*4)
		private mapflag MAP_SHARED_ADVANCED_CONTROL = ConvertMapFlag(8192*8);//constant mapflag            MAP_SHARED_ADVANCED_CONTROL         = ConvertMapFlag(8192*8)
		private mapflag MAP_RANDOM_HERO = ConvertMapFlag(8192*16);//constant mapflag            MAP_RANDOM_HERO                     = ConvertMapFlag(8192*16)
		private mapflag MAP_RANDOM_RACES = ConvertMapFlag(8192*32);//constant mapflag            MAP_RANDOM_RACES                    = ConvertMapFlag(8192*32)
		private mapflag MAP_RELOADED = ConvertMapFlag(8192*64);//constant mapflag            MAP_RELOADED                        = ConvertMapFlag(8192*64)
		private placement MAP_PLACEMENT_RANDOM = ConvertPlacement(0);//constant placement          MAP_PLACEMENT_RANDOM                = ConvertPlacement(0)
		private placement MAP_PLACEMENT_FIXED = ConvertPlacement(1);//constant placement          MAP_PLACEMENT_FIXED                 = ConvertPlacement(1)
		private placement MAP_PLACEMENT_USE_MAP_SETTINGS = ConvertPlacement(2);//constant placement          MAP_PLACEMENT_USE_MAP_SETTINGS      = ConvertPlacement(2)
		private placement MAP_PLACEMENT_TEAMS_TOGETHER = ConvertPlacement(3);//constant placement          MAP_PLACEMENT_TEAMS_TOGETHER        = ConvertPlacement(3)
		private startlocprio MAP_LOC_PRIO_LOW = ConvertStartLocPrio(0);//constant startlocprio       MAP_LOC_PRIO_LOW                    = ConvertStartLocPrio(0)
		private startlocprio MAP_LOC_PRIO_HIGH = ConvertStartLocPrio(1);//constant startlocprio       MAP_LOC_PRIO_HIGH                   = ConvertStartLocPrio(1)
		private startlocprio MAP_LOC_PRIO_NOT = ConvertStartLocPrio(2);//constant startlocprio       MAP_LOC_PRIO_NOT                    = ConvertStartLocPrio(2)
		private mapdensity MAP_DENSITY_NONE = ConvertMapDensity(0);//constant mapdensity         MAP_DENSITY_NONE                    = ConvertMapDensity(0)
		private mapdensity MAP_DENSITY_LIGHT = ConvertMapDensity(1);//constant mapdensity         MAP_DENSITY_LIGHT                   = ConvertMapDensity(1)
		private mapdensity MAP_DENSITY_MEDIUM = ConvertMapDensity(2);//constant mapdensity         MAP_DENSITY_MEDIUM                  = ConvertMapDensity(2)
		private mapdensity MAP_DENSITY_HEAVY = ConvertMapDensity(3);//constant mapdensity         MAP_DENSITY_HEAVY                   = ConvertMapDensity(3)
		private gamedifficulty MAP_DIFFICULTY_EASY = ConvertGameDifficulty(0);//constant gamedifficulty     MAP_DIFFICULTY_EASY                 = ConvertGameDifficulty(0)
		private gamedifficulty MAP_DIFFICULTY_NORMAL = ConvertGameDifficulty(1);//constant gamedifficulty     MAP_DIFFICULTY_NORMAL               = ConvertGameDifficulty(1)
		private gamedifficulty MAP_DIFFICULTY_HARD = ConvertGameDifficulty(2);//constant gamedifficulty     MAP_DIFFICULTY_HARD                 = ConvertGameDifficulty(2)
		private gamedifficulty MAP_DIFFICULTY_INSANE = ConvertGameDifficulty(3);//constant gamedifficulty     MAP_DIFFICULTY_INSANE               = ConvertGameDifficulty(3)
		private gamespeed MAP_SPEED_SLOWEST = ConvertGameSpeed(0);//constant gamespeed          MAP_SPEED_SLOWEST                   = ConvertGameSpeed(0)
		private gamespeed MAP_SPEED_SLOW = ConvertGameSpeed(1);//constant gamespeed          MAP_SPEED_SLOW                      = ConvertGameSpeed(1)
		private gamespeed MAP_SPEED_NORMAL = ConvertGameSpeed(2);//constant gamespeed          MAP_SPEED_NORMAL                    = ConvertGameSpeed(2)
		private gamespeed MAP_SPEED_FAST = ConvertGameSpeed(3);//constant gamespeed          MAP_SPEED_FAST                      = ConvertGameSpeed(3)
		private gamespeed MAP_SPEED_FASTEST = ConvertGameSpeed(4);//constant gamespeed          MAP_SPEED_FASTEST                   = ConvertGameSpeed(4)
		private playerslotstate PLAYER_SLOT_STATE_EMPTY = ConvertPlayerSlotState(0);//constant playerslotstate    PLAYER_SLOT_STATE_EMPTY             = ConvertPlayerSlotState(0)
		private playerslotstate PLAYER_SLOT_STATE_PLAYING = ConvertPlayerSlotState(1);//constant playerslotstate    PLAYER_SLOT_STATE_PLAYING           = ConvertPlayerSlotState(1)
		private playerslotstate PLAYER_SLOT_STATE_LEFT = ConvertPlayerSlotState(2);//constant playerslotstate    PLAYER_SLOT_STATE_LEFT              = ConvertPlayerSlotState(2)
		//
		//
		//
		private volumegroup SOUND_VOLUMEGROUP_UNITMOVEMENT = ConvertVolumeGroup(0);//constant volumegroup        SOUND_VOLUMEGROUP_UNITMOVEMENT      = ConvertVolumeGroup(0)
		private volumegroup SOUND_VOLUMEGROUP_UNITSOUNDS = ConvertVolumeGroup(1);//constant volumegroup        SOUND_VOLUMEGROUP_UNITSOUNDS        = ConvertVolumeGroup(1)
		private volumegroup SOUND_VOLUMEGROUP_COMBAT = ConvertVolumeGroup(2);//constant volumegroup        SOUND_VOLUMEGROUP_COMBAT            = ConvertVolumeGroup(2)
		private volumegroup SOUND_VOLUMEGROUP_SPELLS = ConvertVolumeGroup(3);//constant volumegroup        SOUND_VOLUMEGROUP_SPELLS            = ConvertVolumeGroup(3)
		private volumegroup SOUND_VOLUMEGROUP_UI = ConvertVolumeGroup(4);//constant volumegroup        SOUND_VOLUMEGROUP_UI                = ConvertVolumeGroup(4)
		private volumegroup SOUND_VOLUMEGROUP_MUSIC = ConvertVolumeGroup(5);//constant volumegroup        SOUND_VOLUMEGROUP_MUSIC             = ConvertVolumeGroup(5)
		private volumegroup SOUND_VOLUMEGROUP_AMBIENTSOUNDS = ConvertVolumeGroup(6);//constant volumegroup        SOUND_VOLUMEGROUP_AMBIENTSOUNDS     = ConvertVolumeGroup(6)
		private volumegroup SOUND_VOLUMEGROUP_FIRE = ConvertVolumeGroup(7);//constant volumegroup        SOUND_VOLUMEGROUP_FIRE              = ConvertVolumeGroup(7)
		//
		//
		//
		//
		//
		//
		private igamestate GAME_STATE_DIVINE_INTERVENTION = ConvertIGameState(0);//constant igamestate GAME_STATE_DIVINE_INTERVENTION          = ConvertIGameState(0)
		private igamestate GAME_STATE_DISCONNECTED = ConvertIGameState(1);//constant igamestate GAME_STATE_DISCONNECTED                 = ConvertIGameState(1)
		private fgamestate GAME_STATE_TIME_OF_DAY = ConvertFGameState(2);//constant fgamestate GAME_STATE_TIME_OF_DAY                  = ConvertFGameState(2)
		private playerstate PLAYER_STATE_GAME_RESULT = ConvertPlayerState(0);//constant playerstate PLAYER_STATE_GAME_RESULT               = ConvertPlayerState(0)
		//
		//
		private playerstate PLAYER_STATE_RESOURCE_GOLD = ConvertPlayerState(1);//constant playerstate PLAYER_STATE_RESOURCE_GOLD             = ConvertPlayerState(1)
		private playerstate PLAYER_STATE_RESOURCE_LUMBER = ConvertPlayerState(2);//constant playerstate PLAYER_STATE_RESOURCE_LUMBER           = ConvertPlayerState(2)
		private playerstate PLAYER_STATE_RESOURCE_HERO_TOKENS = ConvertPlayerState(3);//constant playerstate PLAYER_STATE_RESOURCE_HERO_TOKENS      = ConvertPlayerState(3)
		private playerstate PLAYER_STATE_RESOURCE_FOOD_CAP = ConvertPlayerState(4);//constant playerstate PLAYER_STATE_RESOURCE_FOOD_CAP         = ConvertPlayerState(4)
		private playerstate PLAYER_STATE_RESOURCE_FOOD_USED = ConvertPlayerState(5);//constant playerstate PLAYER_STATE_RESOURCE_FOOD_USED        = ConvertPlayerState(5)
		private playerstate PLAYER_STATE_FOOD_CAP_CEILING = ConvertPlayerState(6);//constant playerstate PLAYER_STATE_FOOD_CAP_CEILING          = ConvertPlayerState(6)
		private playerstate PLAYER_STATE_GIVES_BOUNTY = ConvertPlayerState(7);//constant playerstate PLAYER_STATE_GIVES_BOUNTY              = ConvertPlayerState(7)
		private playerstate PLAYER_STATE_ALLIED_VICTORY = ConvertPlayerState(8);//constant playerstate PLAYER_STATE_ALLIED_VICTORY            = ConvertPlayerState(8)
		private playerstate PLAYER_STATE_PLACED = ConvertPlayerState(9);//constant playerstate PLAYER_STATE_PLACED                    = ConvertPlayerState(9)
		private playerstate PLAYER_STATE_OBSERVER_ON_DEATH = ConvertPlayerState(10);//constant playerstate PLAYER_STATE_OBSERVER_ON_DEATH         = ConvertPlayerState(10)
		private playerstate PLAYER_STATE_OBSERVER = ConvertPlayerState(11);//constant playerstate PLAYER_STATE_OBSERVER                  = ConvertPlayerState(11)
		private playerstate PLAYER_STATE_UNFOLLOWABLE = ConvertPlayerState(12);//constant playerstate PLAYER_STATE_UNFOLLOWABLE              = ConvertPlayerState(12)
		//
		//
		private playerstate PLAYER_STATE_GOLD_UPKEEP_RATE = ConvertPlayerState(13);//constant playerstate PLAYER_STATE_GOLD_UPKEEP_RATE          = ConvertPlayerState(13)
		private playerstate PLAYER_STATE_LUMBER_UPKEEP_RATE = ConvertPlayerState(14);//constant playerstate PLAYER_STATE_LUMBER_UPKEEP_RATE        = ConvertPlayerState(14)
		//
		//
		private playerstate PLAYER_STATE_GOLD_GATHERED = ConvertPlayerState(15);//constant playerstate PLAYER_STATE_GOLD_GATHERED             = ConvertPlayerState(15)
		private playerstate PLAYER_STATE_LUMBER_GATHERED = ConvertPlayerState(16);//constant playerstate PLAYER_STATE_LUMBER_GATHERED           = ConvertPlayerState(16)
		private playerstate PLAYER_STATE_NO_CREEP_SLEEP = ConvertPlayerState(25);//constant playerstate PLAYER_STATE_NO_CREEP_SLEEP            = ConvertPlayerState(25)
		private unitstate UNIT_STATE_LIFE = ConvertUnitState(0);//constant unitstate UNIT_STATE_LIFE                          = ConvertUnitState(0)
		private unitstate UNIT_STATE_MAX_LIFE = ConvertUnitState(1);//constant unitstate UNIT_STATE_MAX_LIFE                      = ConvertUnitState(1)
		private unitstate UNIT_STATE_MANA = ConvertUnitState(2);//constant unitstate UNIT_STATE_MANA                          = ConvertUnitState(2)
		private unitstate UNIT_STATE_MAX_MANA = ConvertUnitState(3);//constant unitstate UNIT_STATE_MAX_MANA                      = ConvertUnitState(3)
		private aidifficulty AI_DIFFICULTY_NEWBIE = ConvertAIDifficulty(0);//constant aidifficulty AI_DIFFICULTY_NEWBIE                  = ConvertAIDifficulty(0)
		private aidifficulty AI_DIFFICULTY_NORMAL = ConvertAIDifficulty(1);//constant aidifficulty AI_DIFFICULTY_NORMAL                  = ConvertAIDifficulty(1)
		private aidifficulty AI_DIFFICULTY_INSANE = ConvertAIDifficulty(2);//constant aidifficulty AI_DIFFICULTY_INSANE                  = ConvertAIDifficulty(2)
		//
		private playerscore PLAYER_SCORE_UNITS_TRAINED = ConvertPlayerScore(0);//constant playerscore PLAYER_SCORE_UNITS_TRAINED             = ConvertPlayerScore(0)
		private playerscore PLAYER_SCORE_UNITS_KILLED = ConvertPlayerScore(1);//constant playerscore PLAYER_SCORE_UNITS_KILLED              = ConvertPlayerScore(1)
		private playerscore PLAYER_SCORE_STRUCT_BUILT = ConvertPlayerScore(2);//constant playerscore PLAYER_SCORE_STRUCT_BUILT              = ConvertPlayerScore(2)
		private playerscore PLAYER_SCORE_STRUCT_RAZED = ConvertPlayerScore(3);//constant playerscore PLAYER_SCORE_STRUCT_RAZED              = ConvertPlayerScore(3)
		private playerscore PLAYER_SCORE_TECH_PERCENT = ConvertPlayerScore(4);//constant playerscore PLAYER_SCORE_TECH_PERCENT              = ConvertPlayerScore(4)
		private playerscore PLAYER_SCORE_FOOD_MAXPROD = ConvertPlayerScore(5);//constant playerscore PLAYER_SCORE_FOOD_MAXPROD              = ConvertPlayerScore(5)
		private playerscore PLAYER_SCORE_FOOD_MAXUSED = ConvertPlayerScore(6);//constant playerscore PLAYER_SCORE_FOOD_MAXUSED              = ConvertPlayerScore(6)
		private playerscore PLAYER_SCORE_HEROES_KILLED = ConvertPlayerScore(7);//constant playerscore PLAYER_SCORE_HEROES_KILLED             = ConvertPlayerScore(7)
		private playerscore PLAYER_SCORE_ITEMS_GAINED = ConvertPlayerScore(8);//constant playerscore PLAYER_SCORE_ITEMS_GAINED              = ConvertPlayerScore(8)
		private playerscore PLAYER_SCORE_MERCS_HIRED = ConvertPlayerScore(9);//constant playerscore PLAYER_SCORE_MERCS_HIRED               = ConvertPlayerScore(9)
		private playerscore PLAYER_SCORE_GOLD_MINED_TOTAL = ConvertPlayerScore(10);//constant playerscore PLAYER_SCORE_GOLD_MINED_TOTAL          = ConvertPlayerScore(10)
		private playerscore PLAYER_SCORE_GOLD_MINED_UPKEEP = ConvertPlayerScore(11);//constant playerscore PLAYER_SCORE_GOLD_MINED_UPKEEP         = ConvertPlayerScore(11)
		private playerscore PLAYER_SCORE_GOLD_LOST_UPKEEP = ConvertPlayerScore(12);//constant playerscore PLAYER_SCORE_GOLD_LOST_UPKEEP          = ConvertPlayerScore(12)
		private playerscore PLAYER_SCORE_GOLD_LOST_TAX = ConvertPlayerScore(13);//constant playerscore PLAYER_SCORE_GOLD_LOST_TAX             = ConvertPlayerScore(13)
		private playerscore PLAYER_SCORE_GOLD_GIVEN = ConvertPlayerScore(14);//constant playerscore PLAYER_SCORE_GOLD_GIVEN                = ConvertPlayerScore(14)
		private playerscore PLAYER_SCORE_GOLD_RECEIVED = ConvertPlayerScore(15);//constant playerscore PLAYER_SCORE_GOLD_RECEIVED             = ConvertPlayerScore(15)
		private playerscore PLAYER_SCORE_LUMBER_TOTAL = ConvertPlayerScore(16);//constant playerscore PLAYER_SCORE_LUMBER_TOTAL              = ConvertPlayerScore(16)
		private playerscore PLAYER_SCORE_LUMBER_LOST_UPKEEP = ConvertPlayerScore(17);//constant playerscore PLAYER_SCORE_LUMBER_LOST_UPKEEP        = ConvertPlayerScore(17)
		private playerscore PLAYER_SCORE_LUMBER_LOST_TAX = ConvertPlayerScore(18);//constant playerscore PLAYER_SCORE_LUMBER_LOST_TAX           = ConvertPlayerScore(18)
		private playerscore PLAYER_SCORE_LUMBER_GIVEN = ConvertPlayerScore(19);//constant playerscore PLAYER_SCORE_LUMBER_GIVEN              = ConvertPlayerScore(19)
		private playerscore PLAYER_SCORE_LUMBER_RECEIVED = ConvertPlayerScore(20);//constant playerscore PLAYER_SCORE_LUMBER_RECEIVED           = ConvertPlayerScore(20)
		private playerscore PLAYER_SCORE_UNIT_TOTAL = ConvertPlayerScore(21);//constant playerscore PLAYER_SCORE_UNIT_TOTAL                = ConvertPlayerScore(21)
		private playerscore PLAYER_SCORE_HERO_TOTAL = ConvertPlayerScore(22);//constant playerscore PLAYER_SCORE_HERO_TOTAL                = ConvertPlayerScore(22)
		private playerscore PLAYER_SCORE_RESOURCE_TOTAL = ConvertPlayerScore(23);//constant playerscore PLAYER_SCORE_RESOURCE_TOTAL            = ConvertPlayerScore(23)
		private playerscore PLAYER_SCORE_TOTAL = ConvertPlayerScore(24);//constant playerscore PLAYER_SCORE_TOTAL                     = ConvertPlayerScore(24)
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		//
		private gameevent EVENT_GAME_VICTORY = ConvertGameEvent(0);//constant gameevent EVENT_GAME_VICTORY                       = ConvertGameEvent(0)
		private gameevent EVENT_GAME_END_LEVEL = ConvertGameEvent(1);//constant gameevent EVENT_GAME_END_LEVEL                     = ConvertGameEvent(1)
		private gameevent EVENT_GAME_VARIABLE_LIMIT = ConvertGameEvent(2);//constant gameevent EVENT_GAME_VARIABLE_LIMIT                = ConvertGameEvent(2)
		private gameevent EVENT_GAME_STATE_LIMIT = ConvertGameEvent(3);//constant gameevent EVENT_GAME_STATE_LIMIT                   = ConvertGameEvent(3)
		private gameevent EVENT_GAME_TIMER_EXPIRED = ConvertGameEvent(4);//constant gameevent EVENT_GAME_TIMER_EXPIRED                 = ConvertGameEvent(4)
		private gameevent EVENT_GAME_ENTER_REGION = ConvertGameEvent(5);//constant gameevent EVENT_GAME_ENTER_REGION                  = ConvertGameEvent(5)
		private gameevent EVENT_GAME_LEAVE_REGION = ConvertGameEvent(6);//constant gameevent EVENT_GAME_LEAVE_REGION                  = ConvertGameEvent(6)
		private gameevent EVENT_GAME_TRACKABLE_HIT = ConvertGameEvent(7);//constant gameevent EVENT_GAME_TRACKABLE_HIT                 = ConvertGameEvent(7)
		private gameevent EVENT_GAME_TRACKABLE_TRACK = ConvertGameEvent(8);//constant gameevent EVENT_GAME_TRACKABLE_TRACK               = ConvertGameEvent(8)
		private gameevent EVENT_GAME_SHOW_SKILL = ConvertGameEvent(9);//constant gameevent EVENT_GAME_SHOW_SKILL                    = ConvertGameEvent(9)
		private gameevent EVENT_GAME_BUILD_SUBMENU = ConvertGameEvent(10);//constant gameevent EVENT_GAME_BUILD_SUBMENU                 = ConvertGameEvent(10)
		//
		//
		//
		private playerevent EVENT_PLAYER_STATE_LIMIT = ConvertPlayerEvent(11);//constant playerevent EVENT_PLAYER_STATE_LIMIT               = ConvertPlayerEvent(11)
		private playerevent EVENT_PLAYER_ALLIANCE_CHANGED = ConvertPlayerEvent(12);//constant playerevent EVENT_PLAYER_ALLIANCE_CHANGED          = ConvertPlayerEvent(12)
		private playerevent EVENT_PLAYER_DEFEAT = ConvertPlayerEvent(13);//constant playerevent EVENT_PLAYER_DEFEAT                    = ConvertPlayerEvent(13)
		private playerevent EVENT_PLAYER_VICTORY = ConvertPlayerEvent(14);//constant playerevent EVENT_PLAYER_VICTORY                   = ConvertPlayerEvent(14)
		private playerevent EVENT_PLAYER_LEAVE = ConvertPlayerEvent(15);//constant playerevent EVENT_PLAYER_LEAVE                     = ConvertPlayerEvent(15)
		private playerevent EVENT_PLAYER_CHAT = ConvertPlayerEvent(16);//constant playerevent EVENT_PLAYER_CHAT                      = ConvertPlayerEvent(16)
		private playerevent EVENT_PLAYER_END_CINEMATIC = ConvertPlayerEvent(17);//constant playerevent EVENT_PLAYER_END_CINEMATIC             = ConvertPlayerEvent(17)
		//
		//
		//
		private playerunitevent EVENT_PLAYER_UNIT_ATTACKED = ConvertPlayerUnitEvent(18);//constant playerunitevent EVENT_PLAYER_UNIT_ATTACKED                 = ConvertPlayerUnitEvent(18)
		private playerunitevent EVENT_PLAYER_UNIT_RESCUED = ConvertPlayerUnitEvent(19);//constant playerunitevent EVENT_PLAYER_UNIT_RESCUED                  = ConvertPlayerUnitEvent(19)
		private playerunitevent EVENT_PLAYER_UNIT_DEATH = ConvertPlayerUnitEvent(20);//constant playerunitevent EVENT_PLAYER_UNIT_DEATH                    = ConvertPlayerUnitEvent(20)
		private playerunitevent EVENT_PLAYER_UNIT_DECAY = ConvertPlayerUnitEvent(21);//constant playerunitevent EVENT_PLAYER_UNIT_DECAY                    = ConvertPlayerUnitEvent(21)
		private playerunitevent EVENT_PLAYER_UNIT_DETECTED = ConvertPlayerUnitEvent(22);//constant playerunitevent EVENT_PLAYER_UNIT_DETECTED                 = ConvertPlayerUnitEvent(22)
		private playerunitevent EVENT_PLAYER_UNIT_HIDDEN = ConvertPlayerUnitEvent(23);//constant playerunitevent EVENT_PLAYER_UNIT_HIDDEN                   = ConvertPlayerUnitEvent(23)
		private playerunitevent EVENT_PLAYER_UNIT_SELECTED = ConvertPlayerUnitEvent(24);//constant playerunitevent EVENT_PLAYER_UNIT_SELECTED                 = ConvertPlayerUnitEvent(24)
		private playerunitevent EVENT_PLAYER_UNIT_DESELECTED = ConvertPlayerUnitEvent(25);//constant playerunitevent EVENT_PLAYER_UNIT_DESELECTED               = ConvertPlayerUnitEvent(25)
		private playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_START = ConvertPlayerUnitEvent(26);//constant playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_START          = ConvertPlayerUnitEvent(26)
		private playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL = ConvertPlayerUnitEvent(27);//constant playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_CANCEL         = ConvertPlayerUnitEvent(27)
		private playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_FINISH = ConvertPlayerUnitEvent(28);//constant playerunitevent EVENT_PLAYER_UNIT_CONSTRUCT_FINISH         = ConvertPlayerUnitEvent(28)
		private playerunitevent EVENT_PLAYER_UNIT_UPGRADE_START = ConvertPlayerUnitEvent(29);//constant playerunitevent EVENT_PLAYER_UNIT_UPGRADE_START            = ConvertPlayerUnitEvent(29)
		private playerunitevent EVENT_PLAYER_UNIT_UPGRADE_CANCEL = ConvertPlayerUnitEvent(30);//constant playerunitevent EVENT_PLAYER_UNIT_UPGRADE_CANCEL           = ConvertPlayerUnitEvent(30)
		private playerunitevent EVENT_PLAYER_UNIT_UPGRADE_FINISH = ConvertPlayerUnitEvent(31);//constant playerunitevent EVENT_PLAYER_UNIT_UPGRADE_FINISH           = ConvertPlayerUnitEvent(31)
		private playerunitevent EVENT_PLAYER_UNIT_TRAIN_START = ConvertPlayerUnitEvent(32);//constant playerunitevent EVENT_PLAYER_UNIT_TRAIN_START              = ConvertPlayerUnitEvent(32)
		private playerunitevent EVENT_PLAYER_UNIT_TRAIN_CANCEL = ConvertPlayerUnitEvent(33);//constant playerunitevent EVENT_PLAYER_UNIT_TRAIN_CANCEL             = ConvertPlayerUnitEvent(33)
		private playerunitevent EVENT_PLAYER_UNIT_TRAIN_FINISH = ConvertPlayerUnitEvent(34);//constant playerunitevent EVENT_PLAYER_UNIT_TRAIN_FINISH             = ConvertPlayerUnitEvent(34)
		private playerunitevent EVENT_PLAYER_UNIT_RESEARCH_START = ConvertPlayerUnitEvent(35);//constant playerunitevent EVENT_PLAYER_UNIT_RESEARCH_START           = ConvertPlayerUnitEvent(35)
		private playerunitevent EVENT_PLAYER_UNIT_RESEARCH_CANCEL = ConvertPlayerUnitEvent(36);//constant playerunitevent EVENT_PLAYER_UNIT_RESEARCH_CANCEL          = ConvertPlayerUnitEvent(36)
		private playerunitevent EVENT_PLAYER_UNIT_RESEARCH_FINISH = ConvertPlayerUnitEvent(37);//constant playerunitevent EVENT_PLAYER_UNIT_RESEARCH_FINISH          = ConvertPlayerUnitEvent(37)
		private playerunitevent EVENT_PLAYER_UNIT_ISSUED_ORDER = ConvertPlayerUnitEvent(38);//constant playerunitevent EVENT_PLAYER_UNIT_ISSUED_ORDER             = ConvertPlayerUnitEvent(38)
		private playerunitevent EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER = ConvertPlayerUnitEvent(39);//constant playerunitevent EVENT_PLAYER_UNIT_ISSUED_POINT_ORDER       = ConvertPlayerUnitEvent(39)
		private playerunitevent EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER = ConvertPlayerUnitEvent(40);//constant playerunitevent EVENT_PLAYER_UNIT_ISSUED_TARGET_ORDER      = ConvertPlayerUnitEvent(40)
		private playerunitevent EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER = ConvertPlayerUnitEvent(40);//constant playerunitevent EVENT_PLAYER_UNIT_ISSUED_UNIT_ORDER        = ConvertPlayerUnitEvent(40)
		private playerunitevent EVENT_PLAYER_HERO_LEVEL = ConvertPlayerUnitEvent(41);//constant playerunitevent EVENT_PLAYER_HERO_LEVEL                    = ConvertPlayerUnitEvent(41)
		private playerunitevent EVENT_PLAYER_HERO_SKILL = ConvertPlayerUnitEvent(42);//constant playerunitevent EVENT_PLAYER_HERO_SKILL                    = ConvertPlayerUnitEvent(42)
		private playerunitevent EVENT_PLAYER_HERO_REVIVABLE = ConvertPlayerUnitEvent(43);//constant playerunitevent EVENT_PLAYER_HERO_REVIVABLE                = ConvertPlayerUnitEvent(43)
		private playerunitevent EVENT_PLAYER_HERO_REVIVE_START = ConvertPlayerUnitEvent(44);//constant playerunitevent EVENT_PLAYER_HERO_REVIVE_START             = ConvertPlayerUnitEvent(44)
		private playerunitevent EVENT_PLAYER_HERO_REVIVE_CANCEL = ConvertPlayerUnitEvent(45);//constant playerunitevent EVENT_PLAYER_HERO_REVIVE_CANCEL            = ConvertPlayerUnitEvent(45)
		private playerunitevent EVENT_PLAYER_HERO_REVIVE_FINISH = ConvertPlayerUnitEvent(46);//constant playerunitevent EVENT_PLAYER_HERO_REVIVE_FINISH            = ConvertPlayerUnitEvent(46)
		private playerunitevent EVENT_PLAYER_UNIT_SUMMON = ConvertPlayerUnitEvent(47);//constant playerunitevent EVENT_PLAYER_UNIT_SUMMON                   = ConvertPlayerUnitEvent(47)
		private playerunitevent EVENT_PLAYER_UNIT_DROP_ITEM = ConvertPlayerUnitEvent(48);//constant playerunitevent EVENT_PLAYER_UNIT_DROP_ITEM                = ConvertPlayerUnitEvent(48)
		private playerunitevent EVENT_PLAYER_UNIT_PICKUP_ITEM = ConvertPlayerUnitEvent(49);//constant playerunitevent EVENT_PLAYER_UNIT_PICKUP_ITEM              = ConvertPlayerUnitEvent(49)
		private playerunitevent EVENT_PLAYER_UNIT_USE_ITEM = ConvertPlayerUnitEvent(50);//constant playerunitevent EVENT_PLAYER_UNIT_USE_ITEM                 = ConvertPlayerUnitEvent(50)
		private playerunitevent EVENT_PLAYER_UNIT_LOADED = ConvertPlayerUnitEvent(51);//constant playerunitevent EVENT_PLAYER_UNIT_LOADED                   = ConvertPlayerUnitEvent(51)
		//
		//
		//
		private unitevent EVENT_UNIT_DAMAGED = ConvertUnitEvent(52);//constant unitevent EVENT_UNIT_DAMAGED                               = ConvertUnitEvent(52)
		private unitevent EVENT_UNIT_DEATH = ConvertUnitEvent(53);//constant unitevent EVENT_UNIT_DEATH                                 = ConvertUnitEvent(53)
		private unitevent EVENT_UNIT_DECAY = ConvertUnitEvent(54);//constant unitevent EVENT_UNIT_DECAY                                 = ConvertUnitEvent(54)
		private unitevent EVENT_UNIT_DETECTED = ConvertUnitEvent(55);//constant unitevent EVENT_UNIT_DETECTED                              = ConvertUnitEvent(55)
		private unitevent EVENT_UNIT_HIDDEN = ConvertUnitEvent(56);//constant unitevent EVENT_UNIT_HIDDEN                                = ConvertUnitEvent(56)
		private unitevent EVENT_UNIT_SELECTED = ConvertUnitEvent(57);//constant unitevent EVENT_UNIT_SELECTED                              = ConvertUnitEvent(57)
		private unitevent EVENT_UNIT_DESELECTED = ConvertUnitEvent(58);//constant unitevent EVENT_UNIT_DESELECTED                            = ConvertUnitEvent(58)
		private unitevent EVENT_UNIT_STATE_LIMIT = ConvertUnitEvent(59);//constant unitevent EVENT_UNIT_STATE_LIMIT                           = ConvertUnitEvent(59)
		//
		//
		private unitevent EVENT_UNIT_ACQUIRED_TARGET = ConvertUnitEvent(60);//constant unitevent EVENT_UNIT_ACQUIRED_TARGET                       = ConvertUnitEvent(60)
		private unitevent EVENT_UNIT_TARGET_IN_RANGE = ConvertUnitEvent(61);//constant unitevent EVENT_UNIT_TARGET_IN_RANGE                       = ConvertUnitEvent(61)
		private unitevent EVENT_UNIT_ATTACKED = ConvertUnitEvent(62);//constant unitevent EVENT_UNIT_ATTACKED                              = ConvertUnitEvent(62)
		private unitevent EVENT_UNIT_RESCUED = ConvertUnitEvent(63);//constant unitevent EVENT_UNIT_RESCUED                               = ConvertUnitEvent(63)
		private unitevent EVENT_UNIT_CONSTRUCT_CANCEL = ConvertUnitEvent(64);//constant unitevent EVENT_UNIT_CONSTRUCT_CANCEL                      = ConvertUnitEvent(64)
		private unitevent EVENT_UNIT_CONSTRUCT_FINISH = ConvertUnitEvent(65);//constant unitevent EVENT_UNIT_CONSTRUCT_FINISH                      = ConvertUnitEvent(65)
		private unitevent EVENT_UNIT_UPGRADE_START = ConvertUnitEvent(66);//constant unitevent EVENT_UNIT_UPGRADE_START                         = ConvertUnitEvent(66)
		private unitevent EVENT_UNIT_UPGRADE_CANCEL = ConvertUnitEvent(67);//constant unitevent EVENT_UNIT_UPGRADE_CANCEL                        = ConvertUnitEvent(67)
		private unitevent EVENT_UNIT_UPGRADE_FINISH = ConvertUnitEvent(68);//constant unitevent EVENT_UNIT_UPGRADE_FINISH                        = ConvertUnitEvent(68)
		//
		//
		//
		private unitevent EVENT_UNIT_TRAIN_START = ConvertUnitEvent(69);//constant unitevent EVENT_UNIT_TRAIN_START                           = ConvertUnitEvent(69)
		private unitevent EVENT_UNIT_TRAIN_CANCEL = ConvertUnitEvent(70);//constant unitevent EVENT_UNIT_TRAIN_CANCEL                          = ConvertUnitEvent(70)
		private unitevent EVENT_UNIT_TRAIN_FINISH = ConvertUnitEvent(71);//constant unitevent EVENT_UNIT_TRAIN_FINISH                          = ConvertUnitEvent(71)
		private unitevent EVENT_UNIT_RESEARCH_START = ConvertUnitEvent(72);//constant unitevent EVENT_UNIT_RESEARCH_START                        = ConvertUnitEvent(72)
		private unitevent EVENT_UNIT_RESEARCH_CANCEL = ConvertUnitEvent(73);//constant unitevent EVENT_UNIT_RESEARCH_CANCEL                       = ConvertUnitEvent(73)
		private unitevent EVENT_UNIT_RESEARCH_FINISH = ConvertUnitEvent(74);//constant unitevent EVENT_UNIT_RESEARCH_FINISH                       = ConvertUnitEvent(74)
		private unitevent EVENT_UNIT_ISSUED_ORDER = ConvertUnitEvent(75);//constant unitevent EVENT_UNIT_ISSUED_ORDER                          = ConvertUnitEvent(75)
		private unitevent EVENT_UNIT_ISSUED_POINT_ORDER = ConvertUnitEvent(76);//constant unitevent EVENT_UNIT_ISSUED_POINT_ORDER                    = ConvertUnitEvent(76)
		private unitevent EVENT_UNIT_ISSUED_TARGET_ORDER = ConvertUnitEvent(77);//constant unitevent EVENT_UNIT_ISSUED_TARGET_ORDER                   = ConvertUnitEvent(77)
		private unitevent EVENT_UNIT_HERO_LEVEL = ConvertUnitEvent(78);//constant unitevent EVENT_UNIT_HERO_LEVEL                            = ConvertUnitEvent(78)
		private unitevent EVENT_UNIT_HERO_SKILL = ConvertUnitEvent(79);//constant unitevent EVENT_UNIT_HERO_SKILL                            = ConvertUnitEvent(79)
		private unitevent EVENT_UNIT_HERO_REVIVABLE = ConvertUnitEvent(80);//constant unitevent EVENT_UNIT_HERO_REVIVABLE                        = ConvertUnitEvent(80)
		private unitevent EVENT_UNIT_HERO_REVIVE_START = ConvertUnitEvent(81);//constant unitevent EVENT_UNIT_HERO_REVIVE_START                     = ConvertUnitEvent(81)
		private unitevent EVENT_UNIT_HERO_REVIVE_CANCEL = ConvertUnitEvent(82);//constant unitevent EVENT_UNIT_HERO_REVIVE_CANCEL                    = ConvertUnitEvent(82)
		private unitevent EVENT_UNIT_HERO_REVIVE_FINISH = ConvertUnitEvent(83);//constant unitevent EVENT_UNIT_HERO_REVIVE_FINISH                    = ConvertUnitEvent(83)
		private unitevent EVENT_UNIT_SUMMON = ConvertUnitEvent(84);//constant unitevent EVENT_UNIT_SUMMON                                = ConvertUnitEvent(84)
		private unitevent EVENT_UNIT_DROP_ITEM = ConvertUnitEvent(85);//constant unitevent EVENT_UNIT_DROP_ITEM                             = ConvertUnitEvent(85)
		private unitevent EVENT_UNIT_PICKUP_ITEM = ConvertUnitEvent(86);//constant unitevent EVENT_UNIT_PICKUP_ITEM                           = ConvertUnitEvent(86)
		private unitevent EVENT_UNIT_USE_ITEM = ConvertUnitEvent(87);//constant unitevent EVENT_UNIT_USE_ITEM                              = ConvertUnitEvent(87)
		private unitevent EVENT_UNIT_LOADED = ConvertUnitEvent(88);//constant unitevent EVENT_UNIT_LOADED                                = ConvertUnitEvent(88)
		private widgetevent EVENT_WIDGET_DEATH = ConvertWidgetEvent(89);//constant widgetevent EVENT_WIDGET_DEATH                             = ConvertWidgetEvent(89)
		private dialogevent EVENT_DIALOG_BUTTON_CLICK = ConvertDialogEvent(90);//constant dialogevent EVENT_DIALOG_BUTTON_CLICK                      = ConvertDialogEvent(90)
		private dialogevent EVENT_DIALOG_CLICK = ConvertDialogEvent(91);//constant dialogevent EVENT_DIALOG_CLICK                             = ConvertDialogEvent(91)
		//
		//
		//
		//
		//
		//
		//
		private gameevent EVENT_GAME_LOADED = ConvertGameEvent(256);//constant gameevent          EVENT_GAME_LOADED                       = ConvertGameEvent(256)
		private gameevent EVENT_GAME_TOURNAMENT_FINISH_SOON = ConvertGameEvent(257);//constant gameevent          EVENT_GAME_TOURNAMENT_FINISH_SOON       = ConvertGameEvent(257)
		private gameevent EVENT_GAME_TOURNAMENT_FINISH_NOW = ConvertGameEvent(258);//constant gameevent          EVENT_GAME_TOURNAMENT_FINISH_NOW        = ConvertGameEvent(258)
		private gameevent EVENT_GAME_SAVE = ConvertGameEvent(259);//constant gameevent          EVENT_GAME_SAVE                         = ConvertGameEvent(259)
		//
		//
		//
		private playerevent EVENT_PLAYER_ARROW_LEFT_DOWN = ConvertPlayerEvent(261);//constant playerevent        EVENT_PLAYER_ARROW_LEFT_DOWN            = ConvertPlayerEvent(261)
		private playerevent EVENT_PLAYER_ARROW_LEFT_UP = ConvertPlayerEvent(262);//constant playerevent        EVENT_PLAYER_ARROW_LEFT_UP              = ConvertPlayerEvent(262)
		private playerevent EVENT_PLAYER_ARROW_RIGHT_DOWN = ConvertPlayerEvent(263);//constant playerevent        EVENT_PLAYER_ARROW_RIGHT_DOWN           = ConvertPlayerEvent(263)
		private playerevent EVENT_PLAYER_ARROW_RIGHT_UP = ConvertPlayerEvent(264);//constant playerevent        EVENT_PLAYER_ARROW_RIGHT_UP             = ConvertPlayerEvent(264)
		private playerevent EVENT_PLAYER_ARROW_DOWN_DOWN = ConvertPlayerEvent(265);//constant playerevent        EVENT_PLAYER_ARROW_DOWN_DOWN            = ConvertPlayerEvent(265)
		private playerevent EVENT_PLAYER_ARROW_DOWN_UP = ConvertPlayerEvent(266);//constant playerevent        EVENT_PLAYER_ARROW_DOWN_UP              = ConvertPlayerEvent(266)
		private playerevent EVENT_PLAYER_ARROW_UP_DOWN = ConvertPlayerEvent(267);//constant playerevent        EVENT_PLAYER_ARROW_UP_DOWN              = ConvertPlayerEvent(267)
		private playerevent EVENT_PLAYER_ARROW_UP_UP = ConvertPlayerEvent(268);//constant playerevent        EVENT_PLAYER_ARROW_UP_UP                = ConvertPlayerEvent(268)
		//
		//
		//
		private playerunitevent EVENT_PLAYER_UNIT_SELL = ConvertPlayerUnitEvent(269);//constant playerunitevent    EVENT_PLAYER_UNIT_SELL                  = ConvertPlayerUnitEvent(269)
		private playerunitevent EVENT_PLAYER_UNIT_CHANGE_OWNER = ConvertPlayerUnitEvent(270);//constant playerunitevent    EVENT_PLAYER_UNIT_CHANGE_OWNER          = ConvertPlayerUnitEvent(270)
		private playerunitevent EVENT_PLAYER_UNIT_SELL_ITEM = ConvertPlayerUnitEvent(271);//constant playerunitevent    EVENT_PLAYER_UNIT_SELL_ITEM             = ConvertPlayerUnitEvent(271)
		private playerunitevent EVENT_PLAYER_UNIT_SPELL_CHANNEL = ConvertPlayerUnitEvent(272);//constant playerunitevent    EVENT_PLAYER_UNIT_SPELL_CHANNEL         = ConvertPlayerUnitEvent(272)
		private playerunitevent EVENT_PLAYER_UNIT_SPELL_CAST = ConvertPlayerUnitEvent(273);//constant playerunitevent    EVENT_PLAYER_UNIT_SPELL_CAST            = ConvertPlayerUnitEvent(273)
		private playerunitevent EVENT_PLAYER_UNIT_SPELL_EFFECT = ConvertPlayerUnitEvent(274);//constant playerunitevent    EVENT_PLAYER_UNIT_SPELL_EFFECT          = ConvertPlayerUnitEvent(274)
		private playerunitevent EVENT_PLAYER_UNIT_SPELL_FINISH = ConvertPlayerUnitEvent(275);//constant playerunitevent    EVENT_PLAYER_UNIT_SPELL_FINISH          = ConvertPlayerUnitEvent(275)
		private playerunitevent EVENT_PLAYER_UNIT_SPELL_ENDCAST = ConvertPlayerUnitEvent(276);//constant playerunitevent    EVENT_PLAYER_UNIT_SPELL_ENDCAST         = ConvertPlayerUnitEvent(276)
		private playerunitevent EVENT_PLAYER_UNIT_PAWN_ITEM = ConvertPlayerUnitEvent(277);//constant playerunitevent    EVENT_PLAYER_UNIT_PAWN_ITEM             = ConvertPlayerUnitEvent(277)
		//
		//
		//
		private unitevent EVENT_UNIT_SELL = ConvertUnitEvent(286);//constant unitevent          EVENT_UNIT_SELL                         = ConvertUnitEvent(286)
		private unitevent EVENT_UNIT_CHANGE_OWNER = ConvertUnitEvent(287);//constant unitevent          EVENT_UNIT_CHANGE_OWNER                 = ConvertUnitEvent(287)
		private unitevent EVENT_UNIT_SELL_ITEM = ConvertUnitEvent(288);//constant unitevent          EVENT_UNIT_SELL_ITEM                    = ConvertUnitEvent(288)
		private unitevent EVENT_UNIT_SPELL_CHANNEL = ConvertUnitEvent(289);//constant unitevent          EVENT_UNIT_SPELL_CHANNEL                = ConvertUnitEvent(289)
		private unitevent EVENT_UNIT_SPELL_CAST = ConvertUnitEvent(290);//constant unitevent          EVENT_UNIT_SPELL_CAST                   = ConvertUnitEvent(290)
		private unitevent EVENT_UNIT_SPELL_EFFECT = ConvertUnitEvent(291);//constant unitevent          EVENT_UNIT_SPELL_EFFECT                 = ConvertUnitEvent(291)
		private unitevent EVENT_UNIT_SPELL_FINISH = ConvertUnitEvent(292);//constant unitevent          EVENT_UNIT_SPELL_FINISH                 = ConvertUnitEvent(292)
		private unitevent EVENT_UNIT_SPELL_ENDCAST = ConvertUnitEvent(293);//constant unitevent          EVENT_UNIT_SPELL_ENDCAST                = ConvertUnitEvent(293)
		private unitevent EVENT_UNIT_PAWN_ITEM = ConvertUnitEvent(294);//constant unitevent          EVENT_UNIT_PAWN_ITEM                    = ConvertUnitEvent(294)
		//
		//
		//
		//
		//
		private limitop LESS_THAN = ConvertLimitOp(0);//constant limitop LESS_THAN                              = ConvertLimitOp(0)
		private limitop LESS_THAN_OR_EQUAL = ConvertLimitOp(1);//constant limitop LESS_THAN_OR_EQUAL                     = ConvertLimitOp(1)
		private limitop EQUAL = ConvertLimitOp(2);//constant limitop EQUAL                                  = ConvertLimitOp(2)
		private limitop GREATER_THAN_OR_EQUAL = ConvertLimitOp(3);//constant limitop GREATER_THAN_OR_EQUAL                  = ConvertLimitOp(3)
		private limitop GREATER_THAN = ConvertLimitOp(4);//constant limitop GREATER_THAN                           = ConvertLimitOp(4)
		private limitop NOT_EQUAL = ConvertLimitOp(5);//constant limitop NOT_EQUAL                              = ConvertLimitOp(5)
		//
		//
		//
		private unittype UNIT_TYPE_HERO = ConvertUnitType(0);//constant unittype UNIT_TYPE_HERO                        = ConvertUnitType(0)
		private unittype UNIT_TYPE_DEAD = ConvertUnitType(1);//constant unittype UNIT_TYPE_DEAD                        = ConvertUnitType(1)
		private unittype UNIT_TYPE_STRUCTURE = ConvertUnitType(2);//constant unittype UNIT_TYPE_STRUCTURE                   = ConvertUnitType(2)
		private unittype UNIT_TYPE_FLYING = ConvertUnitType(3);//constant unittype UNIT_TYPE_FLYING                      = ConvertUnitType(3)
		private unittype UNIT_TYPE_GROUND = ConvertUnitType(4);//constant unittype UNIT_TYPE_GROUND                      = ConvertUnitType(4)
		private unittype UNIT_TYPE_ATTACKS_FLYING = ConvertUnitType(5);//constant unittype UNIT_TYPE_ATTACKS_FLYING              = ConvertUnitType(5)
		private unittype UNIT_TYPE_ATTACKS_GROUND = ConvertUnitType(6);//constant unittype UNIT_TYPE_ATTACKS_GROUND              = ConvertUnitType(6)
		private unittype UNIT_TYPE_MELEE_ATTACKER = ConvertUnitType(7);//constant unittype UNIT_TYPE_MELEE_ATTACKER              = ConvertUnitType(7)
		private unittype UNIT_TYPE_RANGED_ATTACKER = ConvertUnitType(8);//constant unittype UNIT_TYPE_RANGED_ATTACKER             = ConvertUnitType(8)
		private unittype UNIT_TYPE_GIANT = ConvertUnitType(9);//constant unittype UNIT_TYPE_GIANT                       = ConvertUnitType(9)
		private unittype UNIT_TYPE_SUMMONED = ConvertUnitType(10);//constant unittype UNIT_TYPE_SUMMONED                    = ConvertUnitType(10)
		private unittype UNIT_TYPE_STUNNED = ConvertUnitType(11);//constant unittype UNIT_TYPE_STUNNED                     = ConvertUnitType(11)
		private unittype UNIT_TYPE_PLAGUED = ConvertUnitType(12);//constant unittype UNIT_TYPE_PLAGUED                     = ConvertUnitType(12)
		private unittype UNIT_TYPE_SNARED = ConvertUnitType(13);//constant unittype UNIT_TYPE_SNARED                      = ConvertUnitType(13)
		private unittype UNIT_TYPE_UNDEAD = ConvertUnitType(14);//constant unittype UNIT_TYPE_UNDEAD                      = ConvertUnitType(14)
		private unittype UNIT_TYPE_MECHANICAL = ConvertUnitType(15);//constant unittype UNIT_TYPE_MECHANICAL                  = ConvertUnitType(15)
		private unittype UNIT_TYPE_PEON = ConvertUnitType(16);//constant unittype UNIT_TYPE_PEON                        = ConvertUnitType(16)
		private unittype UNIT_TYPE_SAPPER = ConvertUnitType(17);//constant unittype UNIT_TYPE_SAPPER                      = ConvertUnitType(17)
		private unittype UNIT_TYPE_TOWNHALL = ConvertUnitType(18);//constant unittype UNIT_TYPE_TOWNHALL                    = ConvertUnitType(18)
		private unittype UNIT_TYPE_ANCIENT = ConvertUnitType(19);//constant unittype UNIT_TYPE_ANCIENT                     = ConvertUnitType(19)
		private unittype UNIT_TYPE_TAUREN = ConvertUnitType(20);//constant unittype UNIT_TYPE_TAUREN                      = ConvertUnitType(20)
		private unittype UNIT_TYPE_POISONED = ConvertUnitType(21);//constant unittype UNIT_TYPE_POISONED                    = ConvertUnitType(21)
		private unittype UNIT_TYPE_POLYMORPHED = ConvertUnitType(22);//constant unittype UNIT_TYPE_POLYMORPHED                 = ConvertUnitType(22)
		private unittype UNIT_TYPE_SLEEPING = ConvertUnitType(23);//constant unittype UNIT_TYPE_SLEEPING                    = ConvertUnitType(23)
		private unittype UNIT_TYPE_RESISTANT = ConvertUnitType(24);//constant unittype UNIT_TYPE_RESISTANT                   = ConvertUnitType(24)
		private unittype UNIT_TYPE_ETHEREAL = ConvertUnitType(25);//constant unittype UNIT_TYPE_ETHEREAL                    = ConvertUnitType(25)
		private unittype UNIT_TYPE_MAGIC_IMMUNE = ConvertUnitType(26);//constant unittype UNIT_TYPE_MAGIC_IMMUNE                = ConvertUnitType(26)
		//
		//
		//
		private itemtype ITEM_TYPE_PERMANENT = ConvertItemType(0);//constant itemtype ITEM_TYPE_PERMANENT                   = ConvertItemType(0)
		private itemtype ITEM_TYPE_CHARGED = ConvertItemType(1);//constant itemtype ITEM_TYPE_CHARGED                     = ConvertItemType(1)
		private itemtype ITEM_TYPE_POWERUP = ConvertItemType(2);//constant itemtype ITEM_TYPE_POWERUP                     = ConvertItemType(2)
		private itemtype ITEM_TYPE_ARTIFACT = ConvertItemType(3);//constant itemtype ITEM_TYPE_ARTIFACT                    = ConvertItemType(3)
		private itemtype ITEM_TYPE_PURCHASABLE = ConvertItemType(4);//constant itemtype ITEM_TYPE_PURCHASABLE                 = ConvertItemType(4)
		private itemtype ITEM_TYPE_CAMPAIGN = ConvertItemType(5);//constant itemtype ITEM_TYPE_CAMPAIGN                    = ConvertItemType(5)
		private itemtype ITEM_TYPE_MISCELLANEOUS = ConvertItemType(6);//constant itemtype ITEM_TYPE_MISCELLANEOUS               = ConvertItemType(6)
		private itemtype ITEM_TYPE_UNKNOWN = ConvertItemType(7);//constant itemtype ITEM_TYPE_UNKNOWN                     = ConvertItemType(7)
		private itemtype ITEM_TYPE_ANY = ConvertItemType(8);//constant itemtype ITEM_TYPE_ANY                         = ConvertItemType(8)
		//
		private itemtype ITEM_TYPE_TOME = ConvertItemType(2);//constant itemtype ITEM_TYPE_TOME                        = ConvertItemType(2)
		//
		//
		//
		private camerafield CAMERA_FIELD_TARGET_DISTANCE = ConvertCameraField(0);//constant camerafield CAMERA_FIELD_TARGET_DISTANCE       = ConvertCameraField(0)
		private camerafield CAMERA_FIELD_FARZ = ConvertCameraField(1);//constant camerafield CAMERA_FIELD_FARZ                  = ConvertCameraField(1)
		private camerafield CAMERA_FIELD_ANGLE_OF_ATTACK = ConvertCameraField(2);//constant camerafield CAMERA_FIELD_ANGLE_OF_ATTACK       = ConvertCameraField(2)
		private camerafield CAMERA_FIELD_FIELD_OF_VIEW = ConvertCameraField(3);//constant camerafield CAMERA_FIELD_FIELD_OF_VIEW         = ConvertCameraField(3)
		private camerafield CAMERA_FIELD_ROLL = ConvertCameraField(4);//constant camerafield CAMERA_FIELD_ROLL                  = ConvertCameraField(4)
		private camerafield CAMERA_FIELD_ROTATION = ConvertCameraField(5);//constant camerafield CAMERA_FIELD_ROTATION              = ConvertCameraField(5)
		private camerafield CAMERA_FIELD_ZOFFSET = ConvertCameraField(6);//constant camerafield CAMERA_FIELD_ZOFFSET               = ConvertCameraField(6)
		private blendmode BLEND_MODE_NONE = ConvertBlendMode(0);//constant blendmode   BLEND_MODE_NONE                    = ConvertBlendMode(0)
		private blendmode BLEND_MODE_DONT_CARE = ConvertBlendMode(0);//constant blendmode   BLEND_MODE_DONT_CARE               = ConvertBlendMode(0)
		private blendmode BLEND_MODE_KEYALPHA = ConvertBlendMode(1);//constant blendmode   BLEND_MODE_KEYALPHA                = ConvertBlendMode(1)
		private blendmode BLEND_MODE_BLEND = ConvertBlendMode(2);//constant blendmode   BLEND_MODE_BLEND                   = ConvertBlendMode(2)
		private blendmode BLEND_MODE_ADDITIVE = ConvertBlendMode(3);//constant blendmode   BLEND_MODE_ADDITIVE                = ConvertBlendMode(3)
		private blendmode BLEND_MODE_MODULATE = ConvertBlendMode(4);//constant blendmode   BLEND_MODE_MODULATE                = ConvertBlendMode(4)
		private blendmode BLEND_MODE_MODULATE_2X = ConvertBlendMode(5);//constant blendmode   BLEND_MODE_MODULATE_2X             = ConvertBlendMode(5)
		private raritycontrol RARITY_FREQUENT = ConvertRarityControl(0);//constant raritycontrol  RARITY_FREQUENT                 = ConvertRarityControl(0)
		private raritycontrol RARITY_RARE = ConvertRarityControl(1);//constant raritycontrol  RARITY_RARE                     = ConvertRarityControl(1)
		private texmapflags TEXMAP_FLAG_NONE = ConvertTexMapFlags(0);//constant texmapflags    TEXMAP_FLAG_NONE                = ConvertTexMapFlags(0)
		private texmapflags TEXMAP_FLAG_WRAP_U = ConvertTexMapFlags(1);//constant texmapflags    TEXMAP_FLAG_WRAP_U              = ConvertTexMapFlags(1)
		private texmapflags TEXMAP_FLAG_WRAP_V = ConvertTexMapFlags(2);//constant texmapflags    TEXMAP_FLAG_WRAP_V              = ConvertTexMapFlags(2)
		private texmapflags TEXMAP_FLAG_WRAP_UV = ConvertTexMapFlags(3);//constant texmapflags    TEXMAP_FLAG_WRAP_UV             = ConvertTexMapFlags(3)
		private fogstate FOG_OF_WAR_MASKED = ConvertFogState(1);//constant fogstate       FOG_OF_WAR_MASKED               = ConvertFogState(1)
		private fogstate FOG_OF_WAR_FOGGED = ConvertFogState(2);//constant fogstate       FOG_OF_WAR_FOGGED               = ConvertFogState(2)
		private fogstate FOG_OF_WAR_VISIBLE = ConvertFogState(4);//constant fogstate       FOG_OF_WAR_VISIBLE              = ConvertFogState(4)
		//
		//
		//
		private int CAMERA_MARGIN_LEFT = 0;//constant integer        CAMERA_MARGIN_LEFT              = 0
		private int CAMERA_MARGIN_RIGHT = 1;//constant integer        CAMERA_MARGIN_RIGHT             = 1
		private int CAMERA_MARGIN_TOP = 2;//constant integer        CAMERA_MARGIN_TOP               = 2
		private int CAMERA_MARGIN_BOTTOM = 3;//constant integer        CAMERA_MARGIN_BOTTOM            = 3
		//
		//
		//
		private effecttype EFFECT_TYPE_EFFECT = ConvertEffectType(0);//constant effecttype     EFFECT_TYPE_EFFECT              = ConvertEffectType(0)
		private effecttype EFFECT_TYPE_TARGET = ConvertEffectType(1);//constant effecttype     EFFECT_TYPE_TARGET              = ConvertEffectType(1)
		private effecttype EFFECT_TYPE_CASTER = ConvertEffectType(2);//constant effecttype     EFFECT_TYPE_CASTER              = ConvertEffectType(2)
		private effecttype EFFECT_TYPE_SPECIAL = ConvertEffectType(3);//constant effecttype     EFFECT_TYPE_SPECIAL             = ConvertEffectType(3)
		private effecttype EFFECT_TYPE_AREA_EFFECT = ConvertEffectType(4);//constant effecttype     EFFECT_TYPE_AREA_EFFECT         = ConvertEffectType(4)
		private effecttype EFFECT_TYPE_MISSILE = ConvertEffectType(5);//constant effecttype     EFFECT_TYPE_MISSILE             = ConvertEffectType(5)
		private effecttype EFFECT_TYPE_LIGHTNING = ConvertEffectType(6);//constant effecttype     EFFECT_TYPE_LIGHTNING           = ConvertEffectType(6)
		private soundtype SOUND_TYPE_EFFECT = ConvertSoundType(0);//constant soundtype      SOUND_TYPE_EFFECT               = ConvertSoundType(0)
		private soundtype SOUND_TYPE_EFFECT_LOOPED = ConvertSoundType(1);//constant soundtype      SOUND_TYPE_EFFECT_LOOPED        = ConvertSoundType(1)
		//
		//
		private int total_gold;//integer total_gold
		private int total_wood;//integer total_wood
		private int total_stones;//integer total_stones
		//
		//
		private int altar = 'halt';//integer altar       = 'halt'
		private int sanctum = 'hars';//integer sanctum     = 'hars'
		private int armory = 'harm';//integer armory      = 'harm'
		private int garrison = 'hbar';//integer garrison    = 'hbar'
		private int house = 'hhou';//integer house       = 'hhou'
		private int town_hall = 'htow';//integer town_hall   = 'htow'
		private int smith = 'hbla';//integer smith       = 'hbla'
		private int castle = 'hcas';//integer castle      = 'hcas'
		private int cannon = 'hctw';//integer cannon      = 'hctw'
		private int guard = 'hgtw';//integer guard       = 'hgtw'
		private int keep = 'hkee';//integer keep        = 'hkee'
		private int church = 'htws';//integer church      = 'htws'
		private int mill = 'hlum';//integer mill        = 'hlum'
		//
		//
		private int peon = 'hpea';//integer peon        = 'hpea'
		private int footman = 'hfoo';//integer footman     = 'hfoo'
		private int serpent = 'hegr';//integer serpent     = 'hegr'
		private int copter = 'hgyr';//integer copter      = 'hgyr'
		private int knight = 'hkni';//integer knight      = 'hkni'
		private int priest = 'hmpr';//integer priest      = 'hmpr'
		private int mortar = 'hmtm';//integer mortar      = 'hmtm'
		private int rifle = 'hrif';//integer rifle       = 'hrif'
		private int caster = 'hsor';//integer caster      = 'hsor'
		private int tank = 'hstt';//integer tank        = 'hstt'
		private int elemental = 'hwat';//integer elemental   = 'hwat'
		//
		//
		private int Uweapons = 'Rhme';//integer Uweapons    = 'Rhme'
		private int Uranged = 'Rhra';//integer Uranged     = 'Rhra'
		private int Uartillery = 'Rhaa';//integer Uartillery  = 'Rhaa'
		private int Uarmor = 'Rhar';//integer Uarmor      = 'Rhar'
		private int Ubldgs = 'Rhac';//integer Ubldgs      = 'Rhac'
		private int Usight = 'Rhss';//integer Usight      = 'Rhss'
		//
		//
		private int paladin = 'Hpal';//integer paladin     = 'Hpal'
		private int king = 'Hamg';//integer king        = 'Hamg'
		private int mage = 'Hmkg';//integer mage        = 'Hmkg'
		private int ranger = 'Hran';//integer ranger      = 'Hran'
		//
		//
		private int END_ASSAULT = 0;//constant integer END_ASSAULT    = 0
		private int NO_CREEPS = 1;//constant integer NO_CREEPS      = 1
		private int CHECK_CREEPS = 2;//constant integer CHECK_CREEPS   = 2
		private int AWAIT_TROOPS = 3;//constant integer AWAIT_TROOPS   = 3
		private int KILL_CREEP = 4;//constant integer KILL_CREEP     = 4
		private int AWAIT_BATTLE = 5;//constant integer AWAIT_BATTLE   = 5
		private int AWAIT_GOAL = 6;//constant integer AWAIT_GOAL     = 6
		private int RETURN_HOME = 7;//constant integer RETURN_HOME    = 7
		private int AWAIT_HEALING = 8;//constant integer AWAIT_HEALING  = 8
		private int assault_timer = 0;//integer assault_timer   = 0
		private int assaultN = 1;//integer assaultN        = 1
		private int assault_state = CHECK_CREEPS;//integer assault_state   = CHECK_CREEPS
		private int PEON_ASSIGNMENT = 10;//constant integer PEON_ASSIGNMENT = 10
		private int peon_timer = 0;//integer peon_timer = 0
		private int creep_target;//unit creep_target
		//
		//
		private int build_index;//integer build_index
		private int[] build_qty;//integer array build_qty
		private int[] build_item;//integer array build_item
		private int[] build_type;//integer array build_type
		private int NORMAL = 1;//constant integer NORMAL     = 1
		private int UPGRADE = 2;//constant integer UPGRADE    = 2
		private int assault_index;//integer assault_index
		private int[] assault_qty;//integer array assault_qty
		private int[] assault_item;//integer array assault_item
		private bool startup = true;//boolean startup     = true
		private int C_huntress = 0;//integer C_huntress  = 0
		private int C_archers = 0;//integer C_archers   = 0
		private int C_dryads = 0;//integer C_dryads    = 0
		private int C_chimaera = 0;//integer C_chimaera  = 0
		private bool lore = false;//boolean lore        = false
		private bool wind = false;//boolean wind        = false
		private bool ages = false;//boolean ages        = false
		private bool eternity = false;//boolean eternity    = false
		private bool war = false;//boolean war         = false
		private bool hunters = false;//boolean hunters     = false
		private bool ballista = false;//boolean ballista    = false
		private bool claws = false;//boolean claws       = false
		private bool roost = false;//boolean roost       = false
		private bool use_bears = false;//boolean use_bears   = false
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private player user = Player(1);//player user = Player(1)
		private int USER = 1;//constant integer USER = 1
		private int USER = 7;//constant integer USER = 7
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private player user = PlayerEx(7);//player user = PlayerEx(7)
		private player user = PlayerEx(1);//player user     = PlayerEx(1)
		private player akama = PlayerEx(7);//player akama    = PlayerEx(7)
		private player targ = user;//player targ     = user
		private player targ1 = PlayerEx(6);//player targ1 = PlayerEx(6)
		private player targ2 = PlayerEx(4);//player targ2 = PlayerEx(4)
		private player targ = targ1;//player targ  = targ1
		private int AKAMA = 'Naka';//constant integer AKAMA          = 'Naka'
		private int DPEON = 'ndrl';//constant integer DPEON          = 'ndrl'
		private int DCATAPULT = 'ncat';//constant integer DCATAPULT      = 'ncat'
		private int DSALAMANDER = 'ndsa';//constant integer DSALAMANDER    = 'ndsa'
		private int DSTALKER = 'ndrt';//constant integer DSTALKER       = 'ndrt'
		private int DVINDICATOR = 'ndrn';//constant integer DVINDICATOR    = 'ndrn'
		private int DHARBINGER = 'ndrh';//constant integer DHARBINGER     = 'ndrh'
		private int DSEER = 'ndrs';//constant integer DSEER          = 'ndrs'
		private int SET_SLOT = 1;//constant integer SET_SLOT       = 1
		private int TURN_ON = 2;//constant integer TURN_ON        = 2
		private int TURN_OFF = 3;//constant integer TURN_OFF       = 3
		private int CAPT_X = 4;//constant integer CAPT_X         = 4
		private int CAPT_Y = 5;//constant integer CAPT_Y         = 5
		private int FEL_GUARD = 'nfgu';//constant integer FEL_GUARD      = 'nfgu'
		private int BLOODFIEND = 'nfgb';//constant integer BLOODFIEND     = 'nfgb'
		private int FEL_BEAST = 'npfl';//constant integer FEL_BEAST      = 'npfl'
		private int ELDER_VOID = 'nvde';//constant integer ELDER_VOID     = 'nvde'
		private int GREATER_VOID = 'nvdg';//constant integer GREATER_VOID   = 'nvdg'
		private int NETHER_DRAKE = 'nndk';//constant integer NETHER_DRAKE   = 'nndk'
		private int NETHER_HATCH = 'nnht';//constant integer NETHER_HATCH   = 'nnht'
		private int OVERLORD = 'nfov';//constant integer OVERLORD       = 'nfov'
		private int SORCEROR = 'ners';//constant integer SORCEROR       = 'ners'
		private int DIABOLIST = 'nerd';//constant integer DIABOLIST      = 'nerd'
		private int FEL_RAVAGER = 'npfm';//constant integer FEL_RAVAGER    = 'npfm'
		private int ERE_WARLOCK = 'nerw';//constant integer ERE_WARLOCK    = 'nerw'
		private int NETHER_DRAGON = 'nndr';//constant integer NETHER_DRAGON  = 'nndr'
		private int TORMENTOR = 'ndqv';//constant integer TORMENTOR      = 'ndqv'
		private int TEMPTRESS = 'ndqt';//constant integer TEMPTRESS      = 'ndqt'
		private int MAIDEN = 'ndqp';//constant integer MAIDEN         = 'ndqp'
		private int QUEEN = 'ndqs';//constant integer QUEEN          = 'ndqs'
		private int ILLIDAN_SLOT = 11;//constant integer ILLIDAN_SLOT   = 11
		private int slot = 0;//integer slot                    = 0
		private bool gate_open = false;//boolean gate_open               = false
		private bool suicide_off = true;//boolean suicide_off             = true
		private int[] suicide_list;//integer array suicide_list
		private int next_suicide = 0;//integer next_suicide            = 0
		private int next_declare = 0;//integer next_declare            = 0
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private int SAGRANEL = 'N00A';//constant integer SAGRANEL       = 'N00A'
		private int ORC_JUGG = 'ojgn';//constant integer ORC_JUGG       = 'ojgn'
		private int ORC_FRIGATE = 'odes';//constant integer ORC_FRIGATE    = 'odes'
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private int NERATHOR = 'O000';//constant integer NERATHOR       = 'O000'
		private int ORC_JUGG = 'ojgn';//constant integer ORC_JUGG       = 'ojgn'
		private int ORC_FRIGATE = 'odes';//constant integer ORC_FRIGATE    = 'odes'
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private int SET_GOAL_X = 1;//constant integer SET_GOAL_X             = 1
		private int SET_GOAL_Y = 2;//constant integer SET_GOAL_Y             = 2
		private int ATTACK_GOAL = 3;//constant integer ATTACK_GOAL            = 3
		private int ATTACK_PLAYER = 4;//constant integer ATTACK_PLAYER          = 4
		private int SET_TELEPORT_X = 5;//constant integer SET_TELEPORT_X         = 5
		private int SET_TELEPORT_Y = 6;//constant integer SET_TELEPORT_Y         = 6
		private int TELEPORT = 7;//constant integer TELEPORT               = 7
		private int STOP_CURRENT_ATTACK = 8;//constant integer STOP_CURRENT_ATTACK    = 8
		private int ATTACK_ZOMBIES = 9;//constant integer ATTACK_ZOMBIES         = 9
		private player USER = Player(1);//constant player USER                    = Player(1)
		private player ZOMBIES = Player(2);//constant player ZOMBIES                 = Player(2)
		private int command;//integer command
		private int command_data;//integer command_data
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player attacked = Player(8);//player attacked = Player(8)
		private player attacked = Player(8);//player attacked = Player(8)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(2);//player user = Player(2)
		private int upg_level = 1;//integer upg_level = 1
		private player user = Player(1);//player user = Player(1)
		private bool startup = true;//boolean startup     = true
		private int C_footmen = 0;//integer C_footmen   = 0
		private int C_priest = 0;//integer C_priest    = 0
		private int C_riflemen = 0;//integer C_riflemen  = 0
		private int C_gyro = 0;//integer C_gyro      = 0
		private int C_gryphon = 0;//integer C_gryphon   = 0
		private int C_vs_air = 0;//integer C_vs_air    = 0
		private int max_rifle = 0;//integer max_rifle   = 0
		private int max_gyro = 0;//integer max_gyro    = 0
		private int max_gryphon = 0;//integer max_gryphon = 0
		private bool keep = false;//boolean keep        = false
		private bool castle = false;//boolean castle      = false
		private bool mill = false;//boolean mill        = false
		private bool smith = false;//boolean smith       = false
		private bool barracks = false;//boolean barracks    = false
		private bool knights = false;//boolean knights     = false
		private bool workshop = false;//boolean workshop    = false
		private bool sanctum = false;//boolean sanctum     = false
		private bool aviary = false;//boolean aviary      = false
		private bool priests = false;//boolean priests     = false
		private bool sorcery = false;//boolean sorcery     = false
		private bool icj_initCheats = InitDebugTriggers();//boolean  icj_initCheats = InitDebugTriggers()
		private player user = Player(0);//player user = Player(0)
		private int SIDE_HUMAN = 1;//constant integer SIDE_HUMAN = 1
		private int SIDE_ORC = 2;//constant integer SIDE_ORC   = 2
		private int side;//integer side
		private player user = Player(1);//constant player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//constant player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private player attacked = Player(4);//player attacked = Player(4)
		private real MAIN_TOWN_X = -4279;//constant real MAIN_TOWN_X   = -4279
		private real MAIN_TOWN_Y = 3057;//constant real MAIN_TOWN_Y   =  3057
		private real DEFENSE_X = -3919;//constant real DEFENSE_X     = -3919
		private real DEFENSE_Y = 1198;//constant real DEFENSE_Y     =  1198
		private real GRAVEYARD_X = -1979;//constant real GRAVEYARD_X   = -1979
		private real GRAVEYARD_Y = -1037;//constant real GRAVEYARD_Y   = -1037
		private int MIN_GHOULS = 3;//constant integer MIN_GHOULS        =  3
		private int MAX_GHOULS_NORMAL = 10;//constant integer MAX_GHOULS_NORMAL = 10
		private int MAX_GHOULS_HARD = 15;//constant integer MAX_GHOULS_HARD   = 15
		private bool on_alert = false;//boolean on_alert            = false
		private int defcon = 5;//integer defcon              = 5
		private int trees_alive = 100;//integer trees_alive         = 100
		private int best_ghouls = 0;//integer best_ghouls         = 0
		private player user = Player(2);//constant player user = Player(2)
		private real MAIN_TOWN_X = -4279;//constant real MAIN_TOWN_X   = -4279
		private real MAIN_TOWN_Y = 3057;//constant real MAIN_TOWN_Y   =  3057
		private real DEFENSE_X = -3919;//constant real DEFENSE_X     = -3919
		private real DEFENSE_Y = 1198;//constant real DEFENSE_Y     =  1198
		private real FAILSAFE_X = -2700;//constant real FAILSAFE_X    = -2700
		private real FAILSAFE_Y = 80;//constant real FAILSAFE_Y    =    80
		private real GRAVEYARD_X = -1979;//constant real GRAVEYARD_X   = -1979
		private real GRAVEYARD_Y = -1037;//constant real GRAVEYARD_Y   = -1037
		private int MIN_GHOULS_NORMAL = 3;//constant integer MIN_GHOULS_NORMAL =  3
		private int MIN_GHOULS_HARD = 8;//constant integer MIN_GHOULS_HARD   =  8
		private int MAX_GHOULS_NORMAL = 10;//constant integer MAX_GHOULS_NORMAL = 10
		private int MAX_GHOULS_HARD = 15;//constant integer MAX_GHOULS_HARD   = 15
		private bool on_alert = false;//boolean on_alert            = false
		private int defcon = 5;//integer defcon              = 5
		private int trees_alive = 100;//integer trees_alive         = 100
		private int best_ghouls = 0;//integer best_ghouls         = 0
		private player user = Player(1);//player user = Player(1)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player undead = Player(3);//constant player undead = Player(3)
		private player undead = Player(3);//constant player undead = Player(3)
		private player User = Player(1);//player User = Player(1)
		private player orcs = Player(0);//constant player orcs = Player(0)
		private player humans = Player(9);//constant player humans = Player(9)
		private player undead = Player(3);//constant player undead = Player(3)
		private player user = Player(1);//player user = Player(1)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private real TICH_CAPT_X = 6987;//constant real TICH_CAPT_X = 6987
		private real TICH_CAPT_Y = 2537;//constant real TICH_CAPT_Y = 2537
		private real WAVE_CAPT_X = 5530;//constant real WAVE_CAPT_X = 5530
		private real WAVE_CAPT_Y = 1270;//constant real WAVE_CAPT_Y = 1270
		private player user = Player(1);//player user = Player(1)
		private int WAVE_DOOMS = 'nC00';//constant integer WAVE_DOOMS = 'nC00'
		private player targ = PlayerEx(6);//player targ = PlayerEx(6)
		private player targ = PlayerEx(1);//player targ = PlayerEx(1)
		private player targ = PlayerEx(2);//player targ   = PlayerEx(2)
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private int NORMAL_WAVE_DUR = 75;//constant integer NORMAL_WAVE_DUR    = 75
		private int HARD_WAVE_DUR = 75;//constant integer HARD_WAVE_DUR      = 75
		private int NORM_ALLOW_TREES = 0;//constant integer NORM_ALLOW_TREES   = 0
		private int NORM_TREE_FACTOR = 5;//constant integer NORM_TREE_FACTOR   = 5
		private int NORM_BASE_BONUS = 0;//constant integer NORM_BASE_BONUS    = 0
		private int NORM_BONUS_CAP = 10;//constant integer NORM_BONUS_CAP     = 10
		private int HARD_ALLOW_TREES = 0;//constant integer HARD_ALLOW_TREES   = 0
		private int HARD_TREE_FACTOR = 4;//constant integer HARD_TREE_FACTOR   = 4
		private int HARD_BASE_BONUS = 1;//constant integer HARD_BASE_BONUS    = 1
		private int HARD_BONUS_CAP = 10;//constant integer HARD_BONUS_CAP     = 10
		private int PIT_STOP_WAVE = 0;//constant integer PIT_STOP_WAVE      = 0
		private int BASIC_WAVE1 = 1;//constant integer BASIC_WAVE1        = 1
		private int BASIC_WAVE2 = 2;//constant integer BASIC_WAVE2        = 2
		private int AIR_WAVE = 3;//constant integer AIR_WAVE           = 3
		private int ANTI_AIR_WAVE = 4;//constant integer ANTI_AIR_WAVE      = 4
		private int ANTIMAGIC_WAVE = 5;//constant integer ANTIMAGIC_WAVE     = 5
		private int SIEGE_WAVE = 6;//constant integer SIEGE_WAVE         = 6
		private int POSSESS_WAVE = 7;//constant integer POSSESS_WAVE       = 7
		private int SKELETON_WAVE = 8;//constant integer SKELETON_WAVE      = 8
		private int PLAGUE_WAVE = 9;//constant integer PLAGUE_WAVE        = 9
		private int BURNING_WAVE = 10;//constant integer BURNING_WAVE       = 10
		private int F_U1_WAVE = 11;//constant integer F_U1_WAVE          = 11
		private int F_U2_WAVE = 12;//constant integer F_U2_WAVE          = 12
		private int F_U3_WAVE = 13;//constant integer F_U3_WAVE          = 13
		private int CMD_SET_X1 = 1;//constant integer CMD_SET_X1         = 1
		private int CMD_SET_Y1 = 2;//constant integer CMD_SET_Y1         = 2
		private int CMD_SET_SEQUENCE = 3;//constant integer CMD_SET_SEQUENCE   = 3
		private int CMD_SET_TARGET = 4;//constant integer CMD_SET_TARGET     = 4
		private int CMD_STOP = 5;//constant integer CMD_STOP           = 5
		private int CMD_SET_X2 = 6;//constant integer CMD_SET_X2         = 6
		private int CMD_SET_Y2 = 7;//constant integer CMD_SET_Y2         = 7
		private int BANSHEE_POSSESS = 'uC00';//constant integer BANSHEE_POSSESS    = 'uC00'
		private int BANSHEE_CURSE = 'uC01';//constant integer BANSHEE_CURSE      = 'uC01'
		private int BANSHEE_ANTIMAGIC = 'uC02';//constant integer BANSHEE_ANTIMAGIC  = 'uC02'
		//
		//
		//
		//
		//
		private int BUILD_INFERNAL = 'nC08';//constant integer BUILD_INFERNAL     = 'nC08'
		//
		//
		//
		private int GHOULZ = 'uC12';//constant integer GHOULZ             = 'uC12'
		private player USER = Player(1);//player USER                         = Player(1)
		private int stage_x1 = 0;//integer stage_x1                    = 0
		private int stage_y1 = 0;//integer stage_y1                    = 0
		private int stage_x2 = 0;//integer stage_x2                    = 0
		private int stage_y2 = 0;//integer stage_y2                    = 0
		private bool need_stage2 = true;//boolean need_stage2                 = true
		private bool at_stage1 = false;//boolean at_stage1                   = false
		private bool aborting = false;//boolean aborting                    = false
		private bool send_lich = false;//boolean send_lich                   = false
		private bool send_lord = false;//boolean send_lord                   = false
		private bool send_azga = false;//boolean send_azga                   = false
		private int wave_count = 0;//integer wave_count                  = 0
		private int wave_restart = 0;//integer wave_restart                = 0
		private int strength = 0;//integer strength                    = 0
		private int target = 0;//integer target                      = 0
		private int harvest_ghouls = 0;//integer harvest_ghouls              = 0
		private int[] wave_type;//integer array wave_type
		private int[] wave_sleep;//integer array wave_sleep
		private int[] wave_hero;//integer array wave_hero
		private int SWISP = 'e001';//constant integer SWISP          = 'e001'
		private int SHUNTRESS = 'e000';//constant integer SHUNTRESS      = 'e000'
		private int SARCHER = 'e005';//constant integer SARCHER        = 'e005'
		private int SANCIENTWAR = 'e009';//constant integer SANCIENTWAR    = 'e009'
		private int SPROTECTOR = 'e008';//constant integer SPROTECTOR     = 'e008'
		private int SMOONWELL = 'e007';//constant integer SMOONWELL      = 'e007'
		private player user = PlayerEx(3);//player user = PlayerEx(3)
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		//
		private player user = Player(9);//player user = Player(9)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(8);//player user = Player(8)
		private player user = Player(8);//player user = Player(8)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		private player user = Player(1);//player user = Player(1)
		//
		private player user = Player(0);//player user = Player(0)
		private player user = PlayerEx(10);//player user = PlayerEx(10)
		//
		private int ORGE = 'nogo';//constant integer ORGE           = 'nogo'
		private int MAGI = 'nomg';//constant integer MAGI           = 'nomg'
		private player user = PlayerEx(03);//player user = PlayerEx(03)
		private int ELITE_FOOTMAN = 'hcth';//constant integer ELITE_FOOTMAN  = 'hcth'
		private int CHAPLIN = 'nchp';//constant integer CHAPLIN        = 'nchp'
		private int HYDROMANCER = 'nhym';//constant integer HYDROMANCER    = 'nhym'
		private player user = PlayerEx(03);//player user = PlayerEx(03)
		private int ELITE_FOOTMAN = 'hcth';//constant integer ELITE_FOOTMAN  = 'hcth'
		private int CHAPLIN = 'nchp';//constant integer CHAPLIN        = 'nchp'
		private int HYDROMANCER = 'nhym';//constant integer HYDROMANCER    = 'nhym'
		private int user = 7;//integer user = 7
		private int user = 8;//integer user = 8
		private int user = 9;//integer user = 9
		private int user = 3;//integer user = 3
		private int user = 4;//integer user = 4
		private int user = 5;//integer user = 5
		private player user = Player(0);//player user = Player(0)
		private player user = Player(0);//player user = Player(0)
		private player user = Player(0);//player user = Player(0)
		private int GO_AGRO = 1;//constant integer GO_AGRO        = 1
		private int GO_KILL = 2;//constant integer GO_KILL        = 2
		private int PLAYER_DIED = 3;//constant integer PLAYER_DIED    = 3
		private int PLAYER_ASS = 4;//constant integer PLAYER_ASS     = 4
		private int CLEAR_AGRO = 5;//constant integer CLEAR_AGRO     = 5
		private int USER = 0;//constant integer USER           = 0
		private int BLUE = 1;//constant integer BLUE           = 1
		private int GRAY = 8;//constant integer GRAY           = 8
		private int LIGHT_BLUE = 9;//constant integer LIGHT_BLUE     = 9
		private int GREEN = 10;//constant integer GREEN          = 10
		private int EASY_AGRO = 120;//constant integer EASY_AGRO      = 120
		private int NORMAL_AGRO = 120;//constant integer NORMAL_AGRO    = 120
		private int HARD_AGRO = 120;//constant integer HARD_AGRO      = 120
		private int grom_target = -1;//integer grom_target             = -1
		private int wave_index = 0;//integer wave_index              = 0
		private int strength = 1;//integer strength                = 1
		private bool agro_mode = true;//boolean agro_mode               = true
		private bool[] alive;//boolean array alive
		private bool[] needs_agro;//boolean array needs_agro
		private player user = Player(0);//player user = Player(0)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(0);//player user = Player(0)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private int factor = 1;//integer factor = 1
		private player user = Player(3);//player user = Player(3)
		private int factor = 1;//integer factor = 1
		private player user = Player(0);//player user = Player(0)
		private player user = Player(0);//player user = Player(0)
		private player user = Player(0);//player user	 = Player(0)
		private player jaina = Player(9);//player jaina = Player(9)
		private player purple = Player(3);//player purple	= Player(3)
		private player green = Player(10);//player green	= Player(10)
		private player user = Player(0);//player user	 = Player(0)
		private player jaina = Player(9);//player jaina = Player(9)
		private player Thrall = Player(0);//player Thrall = Player(0)
		private player Jaina = Player(9);//player Jaina  = Player(9)
		private bool startup = true;//boolean startup         = true
		private int C_hunters = 0;//integer C_hunters       = 0
		private int C_grunt = 0;//integer C_grunt         = 0
		private int C_raiders = 0;//integer C_raiders       = 0
		private bool forge = false;//boolean forge           = false
		private bool stronghold = false;//boolean stronghold      = false
		private bool fortress = false;//boolean fortress        = false
		private bool bestiary = false;//boolean bestiary        = false
		private bool lodge = false;//boolean lodge           = false
		private bool totem = false;//boolean totem           = false
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private int VARIMATHRAS = 'Uvar';//constant integer VARIMATHRAS    = 'Uvar'
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private int NO_CLOUD_HAWK = 'h001';//constant integer NO_CLOUD_HAWK  = 'h001'
		private int CLOUD_HAWK = HUMAN_DRAGON_HAWK;//constant integer CLOUD_HAWK     = HUMAN_DRAGON_HAWK
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		//
		private int NSPIDERLING = 'nspd';//constant integer NSPIDERLING    = 'nspd'
		private int NWARRIOR = 'nnwa';//constant integer NWARRIOR       = 'nnwa'
		//
		private int NWEBSPIDERLING = 'n00I';//constant integer NWEBSPIDERLING = 'n00I'
		private int NSPIDER = 'n00G';//constant integer NSPIDER        = 'n00G'
		//
		private int NSPIDERLING02 = 'n00J';//constant integer NSPIDERLING02  = 'n00J'
		private int NWARRIOR02 = 'n00K';//constant integer NWARRIOR02     = 'n00K'
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private int delay = M5;//integer delay       = M5
		private int hard_delay = M4;//integer hard_delay  = M4
		private int fast_delay = M3;//integer fast_delay  = M3
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private int delay = M5;//integer delay       = M5
		private int hard_delay = M4;//integer hard_delay  = M4
		private int fast_delay = M3;//integer fast_delay  = M3
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private int delay = M5;//integer delay       = M5
		private int hard_delay = M4;//integer hard_delay  = M4
		private int fast_delay = M3;//integer fast_delay  = M3
		private player user = PlayerEx(4);//player user = PlayerEx(4)
		private int delay = M5;//integer delay       = M5
		private int hard_delay = M4;//integer hard_delay  = M4
		private int fast_delay = M3;//integer fast_delay  = M3
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player sylvie = PlayerEx(2);//player sylvie = PlayerEx(2)
		private player garit = PlayerEx(9);//player garit  = PlayerEx(9)
		private int BALNAZZAR = 'Ubal';//constant integer BALNAZZAR  = 'Ubal'
		private int LICH2 = 'U000';//constant integer LICH2 = 'U000'
		private player user = PlayerEx(2);//player user = PlayerEx(2)
		private int LICH2 = 'U001';//constant integer LICH2 = 'U001'
		private player user = PlayerEx(9);//player user = PlayerEx(9)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(3);//player user = Player(3)
		private player user = Player(6);//player user = Player(6)
		private player user = Player(6);//player user = Player(6)
		private player user = Player(6);//player user = Player(6)
		private int ILLIDAN_TOWN_X = 4400;//constant integer ILLIDAN_TOWN_X     = 4400
		private int ILLIDAN_TOWN_Y = 6300;//constant integer ILLIDAN_TOWN_Y     = 6300
		private int ILLIDAN_DEF_X = 5050;//constant integer ILLIDAN_DEF_X      = 5050
		private int ILLIDAN_DEF_Y = 6600;//constant integer ILLIDAN_DEF_Y      = 6600
		private player USER = PlayerEx(1);//constant player USER                = PlayerEx(1)
		private int OFFSET_X = 600;//constant integer OFFSET_X           = 600
		private int OFFSET_Y = 500;//constant integer OFFSET_Y           = 500
		private int NAGA_COUATL2 = 'n000';//constant integer NAGA_COUATL2       = 'n000'
		private int NAGA_REAVER2 = 'n001';//constant integer NAGA_REAVER2       = 'n001'
		private int NAGA_ROYAL2 = 'n002';//constant integer NAGA_ROYAL2        = 'n002'
		private int NAGA_MYRMIDON2 = 'n003';//constant integer NAGA_MYRMIDON2     = 'n003'
		private int NAGA_SNAP_DRAGON2 = 'n004';//constant integer NAGA_SNAP_DRAGON2  = 'n004'
		private int NAGA_TURTLE2 = 'n005';//constant integer NAGA_TURTLE2       = 'n005'
		private int NAGA_SIREN2 = 'n007';//constant integer NAGA_SIREN2        = 'n007'
		private int BUCKET_COUATL = 0;//constant integer BUCKET_COUATL      = 0
		private int BUCKET_SNAP_DRAGON = 1;//constant integer BUCKET_SNAP_DRAGON = 1
		private int BUCKET_REAVER = 2;//constant integer BUCKET_REAVER      = 2
		private int BUCKET_MYRMIDON = 3;//constant integer BUCKET_MYRMIDON    = 3
		private int BUCKET_SIREN = 4;//constant integer BUCKET_SIREN       = 4
		private int BUCKET_TURTLE = 5;//constant integer BUCKET_TURTLE      = 5
		private int BUCKET_ROYAL = 6;//constant integer BUCKET_ROYAL       = 6
		private int BUCKET_END = 7;//constant integer BUCKET_END         = 7
		private int SET_TOWN_1_X = 1;//constant integer SET_TOWN_1_X       =  1
		private int SET_TOWN_1_Y = 2;//constant integer SET_TOWN_1_Y       =  2
		private int SET_TOWN_2_X = 3;//constant integer SET_TOWN_2_X       =  3
		private int SET_TOWN_2_Y = 4;//constant integer SET_TOWN_2_Y       =  4
		private int SET_TOWN_3_X = 5;//constant integer SET_TOWN_3_X       =  5
		private int SET_TOWN_3_Y = 6;//constant integer SET_TOWN_3_Y       =  6
		private int SET_TOWN_4_X = 7;//constant integer SET_TOWN_4_X       =  7
		private int SET_TOWN_4_Y = 8;//constant integer SET_TOWN_4_Y       =  8
		private int PEONS_LOST = 9;//constant integer PEONS_LOST         =  9
		private int SLOT_LOST = 10;//constant integer SLOT_LOST          = 10
		private int SLOT_GAINED = 11;//constant integer SLOT_GAINED        = 11
		private int SLOT_STEPPED_ON = 12;//constant integer SLOT_STEPPED_ON    = 12
		private int STARTUP_CMDS = 12;//constant integer STARTUP_CMDS       = 12
		private bool NORMAL_ATTACK = true;//constant boolean NORMAL_ATTACK      = true
		private bool PEON_ATTACK = false;//constant boolean PEON_ATTACK        = false
		private int NO_CONTROL = 1;//constant integer NO_CONTROL         = 1
		private int ILLIDAN_CONTROL = 2;//constant integer ILLIDAN_CONTROL    = 2
		private int ARTHAS_CONTROL = 3;//constant integer ARTHAS_CONTROL     = 3
		private int NOT_POSSIBLE = 1;//constant integer NOT_POSSIBLE       = 1
		private int START_SLOT = 2;//constant integer START_SLOT         = 2
		private int startup = 0;//integer startup                     = 0
		private bool first_attack = true;//boolean first_attack                = true
		private int action_state = SLOT_LOST;//integer action_state                = SLOT_LOST
		private int next_slot = -1;//integer next_slot                   = -1
		private int attack_delay = 1;//integer attack_delay                = 1
		private int attack_index = 0;//integer attack_index                = 0
		private bool rebuild_Illidan = true;//boolean rebuild_Illidan             = true
		private bool stepped_on = false;//boolean stepped_on                  = false
		private bool suicide_mode = false;//boolean suicide_mode                = false
		private bool did_suicide = false;//boolean did_suicide                 = false
		private bool timeout_failure = false;//boolean timeout_failure             = false
		private int[] town_x;//integer array town_x
		private int[] town_y;//integer array town_y
		private bool[] peons_lost;//boolean array peons_lost
		private bool[] slot_owned;//boolean array slot_owned
		private int[] slot_control;//integer array slot_control
		private int[] Illidan0;//integer array Illidan0
		private int[] Illidan1;//integer array Illidan1
		private int[] Illidan2;//integer array Illidan2
		private int[] Illidan3;//integer array Illidan3
		private int[] attack_min_COPs;//integer array attack_min_COPs
		private int[] attack_max_COPs;//integer array attack_max_COPs
		private int[] attack_qty;//integer array attack_qty
		private int[] attack_bucket;//integer array attack_bucket
		private int[] bucket_qty;//integer array bucket_qty
		private int[] bucket_unitid;//integer array bucket_unitid
		private real[] food_factor;//real array food_factor
		private real dragon_factor;//real dragon_factor
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private int NO_CLOUD_HAWK = 'h000';//constant integer NO_CLOUD_HAWK  = 'h000'
		private int CLOUD_HAWK = HUMAN_DRAGON_HAWK;//constant integer CLOUD_HAWK     = HUMAN_DRAGON_HAWK
		private player user = PlayerEx(1);//player user = PlayerEx(1)
		private int SET_X = 1;//constant integer SET_X = 1
		private int SET_Y = 2;//constant integer SET_Y = 2
		private int SET_X = 1;//constant integer SET_X = 1
		private int SET_Y = 2;//constant integer SET_Y = 2
		private int SET_X = 1;//constant integer SET_X = 1
		private int SET_Y = 2;//constant integer SET_Y = 2
		private int SET_X = 1;//constant integer SET_X = 1
		private int SET_Y = 2;//constant integer SET_Y = 2
		private player user = Player(3);//player user = Player(3)
		private player kel = Player(6);//player kel	= Player(6)
		private player user = Player(3);//player user = Player(3)
		private player kel = Player(6);//player kel	= Player(6)
		private player user = Player(3);//player user = Player(3)
		private player kel = Player(6);//player kel	= Player(6)
		private int AG = 0;//integer AG          = 0
		private int wave = 1;//integer wave        = 1
		private bool halls = false;//boolean halls       = false
		private bool citadel = false;//boolean citadel     = false
		private bool grave = false;//boolean grave       = false
		private bool melee = false;//boolean melee       = false
		private bool ranged = false;//boolean ranged      = false
		private bool C_aboms = false;//boolean C_aboms     = false
		private bool M_aboms = false;//boolean M_aboms     = false
		private bool banshees = false;//boolean banshees    = false
		private bool sac_pit = false;//boolean sac_pit     = false
		private bool boneyard = false;//boolean boneyard    = false
		private bool fiends = false;//boolean fiends      = false
		private bool slaught = false;//boolean slaught     = false
		private bool temple = false;//boolean temple      = false
		private bool wagons = false;//boolean wagons      = false

	
	}
}

