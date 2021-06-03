using LINQtoCSV;

namespace RandomGameDialog.Web.Models
{
    public static class LocationContext
    {
        public static string[] AllGeneric = new string[]
            {
                Generic,
                DAGeneric,
                DarkBrotherhoodGeneral,
                DarkBrotherhoodGeneralNPC,
                FightersGuildGeneric,
                GenericDremora,
                GenericFodderCombat,
                MagesGuildGeneral,
                SENQDGeneric
            };

        public static string Generic = "Generic";
        public static string ArenaDialogue = "ArenaDialogue";
        public static string CharacterGeneration = "Charactergen";
        public static string Crime = "Crime";
        public static string DAGeneric = "DAGeneric";
        public static string DANamira = "DANamira";
        public static string DarkBrotherhoodGeneral = "Dark00General";
        public static string DarkBrotherhoodGeneralNPC = "Dark00GeneralNPC";
        public static string DarkBrotherhoodAssassinated = "Dark05Assassinated";
        public static string DarkBrotherhoodMother = "Dark18Mother";
        public static string DarkBrotherhoodConversationSystem = "DarkConvSystem";
        public static string DAVaermina = "DAVaermina";
        public static string DispositionBlockers = "DispositionBlockers";
        public static string FightersGuildCProtect = "FGC02Protect";
        public static string FightersGuildCThieves = "FGC03Thieves";
        public static string FightersGuildCPrison = "FGC08Prison";
        public static string FightersGuildConversations = "FGConversations";
        public static string FightersGuildKidnap = "FGD07Kidnap";
        public static string FightersGuildGeneric = "FGGeneric";
        public static string GenericDremora = "GenericDremora";
        public static string GenericFodderCombat = "GenericFodderCombat";
        public static string MagesGuildGeneral = "MG00General";
        public static string MagesGuildDestruction = "MG01Destruct";
        public static string MagesGuildAlteration = "MG02Alter";
        public static string MagesGuildIllusion = "MG03Illusion";
        public static string MagesGuildA = "MG05A";
        public static string MagesGuildFIN = "MG05FIN";
        public static string MagesGuildFingers = "MG05Fingers";
        public static string MagesGuildLeyawin = "MG07Leyawin";
        public static string MagesGuildInformation = "MG13Information";
        public static string MagesGuildHelm = "MG15Helm";
        public static string MQ00 = "MQ00";
        public static string MQ05 = "MQ05";
        public static string MQ13 = "MQ13";
        public static string MQ15 = "MQ15";
        public static string MS05 = "MS05";
        public static string MS12 = "MS12";
        public static string MS14 = "MS14";
        public static string MS16 = "MS16";
        public static string MS18 = "MS18";
        public static string MS26 = "MS26";
        public static string MS38 = "MS38";
        public static string MS45 = "MS45";
        public static string MS48 = "MS48";
        public static string MS52 = "MS52";
        public static string MS91FIN = "MS91FIN";
        public static string MS92FIN = "MS92FIN";
        public static string MSFIN = "MSFIN";
        public static string NQDHackdirt = "NQDHackdirt";
        public static string SE00 = "SE00";
        public static string SE03A = "SE03A";
        public static string SE04 = "SE04";
        public static string SE07A = "SE07A";
        public static string SE10 = "SE10";
        public static string SE11a = "SE11a";
        public static string SE12 = "SE12";
        public static string SE13 = "SE13";
        public static string SE32 = "SE32";
        public static string SE36 = "SE36";
        public static string SE37 = "SE37";
        public static string SENQDDementia = "SENQDDementia";
        public static string SENQDGeneric = "SENQDGeneric";
        public static string SENQDMania = "SENQDMania";
        public static string ThievesGuildElven = "TG03Elven";
        public static string ThievesGuildMistake = "TG04Mistake";
        public static string ThievesGuildMisdirection = "TG05Misdirection";
        public static string ThievesGuildAtonement = "TG06Atonement";
        public static string ThievesGuildLex = "TG07Lex";
        public static string ThievesGuildBlind = "TG08Blind";
        public static string ThievesGuildArrow = "TG09Arrow";
        public static string ThievesGuildBoots = "TG10Boots";
        public static string ThievesGuildHeist = "TG11Heist";
        public static string TrainingAcrobatics = "TrainingAcrobatics";
        public static string TrainingAlchemy = "TrainingAlchemy";
        public static string TrainingAlteration = "TrainingAlteration";
        public static string TrainingArmorer = "TrainingArmorer";
        public static string TrainingAthletics = "TrainingAthletics";
        public static string TrainingBlade = "TrainingBlade";
        public static string TrainingBlock = "TrainingBlock";
        public static string TrainingBlunt = "TrainingBlunt";
        public static string TrainingConjuration = "TrainingConjuration";
        public static string TrainingDestruction = "TrainingDestruction";
        public static string TrainingHandToHand = "TrainingHandToHand";
        public static string TrainingHeavyArmor = "TrainingHeavyArmor";
        public static string TrainingIllusion = "TrainingIllusion";
        public static string TrainingLightArmor = "TrainingLightArmor";
        public static string TrainingMarksman = "TrainingMarksman";
        public static string TrainingMercantile = "TrainingMercantile";
        public static string TrainingMysticism = "TrainingMysticism";
        public static string TrainingRestoration = "TrainingRestoration";
        public static string TrainingSecurity = "TrainingSecurity";
        public static string TrainingSneak = "TrainingSneak";
        public static string TrainingSpeechcraft = "TrainingSpeechcraft";
    }

    public static class BehaviorContext
    {
        public static string TimeToGo = "TimeToGo";
        public static string Corpse = "Corpse";
        public static string ObserveCombat = "ObserveCombat";
        public static string Idle = "Idle";
        public static string InfoRefusal = "InfoRefusal";
        public static string Recharge = "Recharge";
        public static string BarterExit = "BarterExit";
        public static string BarterSellItem = "BarterSellItem";
        public static string BarterBuyItem = "BarterBuyItem";
        public static string Training = "Training";
        public static string Repair = "Repair";
        public static string BarterFail = "BarterFail";
        public static string Barter = "Barter";
        public static string ServiceRefusal = "ServiceRefusal";
        public static string Lost = "Lost";
        public static string Unseen = "Unseen";
        public static string Seen = "Seen";
        public static string Noticed = "Noticed";
        public static string PERSUASIONEXIT = "PERSUASIONEXIT";
        public static string PERSUASIONENTER = "PERSUASIONENTER";
        public static string Bribe = "BRIBE";
        public static string JOKEDISLIKE = "JOKEDISLIKE";
        public static string JOKELIKE = "JOKELIKE";
        public static string JOKELOVE = "JOKELOVE";
        public static string JOKEHATE = "JOKEHATE";
        public static string BOASTDISLIKE = "BOASTDISLIKE";
        public static string BOASTLIKE = "BOASTLIKE";
        public static string BOASTLOVE = "BOASTLOVE";
        public static string BOASTHATE = "BOASTHATE";
        public static string COERCEDISLIKE = "COERCEDISLIKE";
        public static string COERCELIKE = "COERCELIKE";
        public static string COERCELOVE = "COERCELOVE";
        public static string COERCEHATE = "COERCEHATE";
        public static string ADMIREDISLIKE = "ADMIREDISLIKE";
        public static string ADMIRELIKE = "ADMIRELIKE";
        public static string ADMIRELOVE = "ADMIRELOVE";
        public static string ADMIREHATE = "ADMIREHATE";
        public static string TrespassNoCrime = "TrespassNoCrime";
        public static string StealNoCrime = "StealNoCrime";
        public static string PickpocketNoCrime = "PickpocketNoCrime";
        public static string MurderNoCrime = "MurderNoCrime";
        public static string AssaultNoCrime = "AssaultNoCrime";
        public static string PowerAttack = "PowerAttack";
        public static string Murder = "Murder";
        public static string Assault = "Assault";
        public static string Pickpocket = "Pickpocket";
        public static string AcceptYield = "AcceptYield";
        public static string Yield = "Yield";
        public static string Trespass = "Trespass";
        public static string Steal = "Steal";
        public static string Flee = "Flee";
        public static string Hit = "Hit";
        public static string Attack = "Attack";
        public static string InfoGeneral = "INFOGENERAL";
        public static string Goodbye = "GOODBYE";
        public static string Hello = "HELLO";
        public static string Greeting = "GREETING";
        public static string Farewell = "Farewell";
        public static string Praise = "Praise";
        public static string Salutation = "Salutation";
    }

    public class OblivionDialogue
    {
        [CsvColumn(FieldIndex = 0)]
        public string SpecificCharacter { get; set; }
        [CsvColumn(FieldIndex = 1)]
        public string Race { get; set; }
        [CsvColumn(FieldIndex = 2)]
        public string Faction { get; set; }
        [CsvColumn(FieldIndex = 3)]
        public string Gender { get; set; }
        [CsvColumn(FieldIndex = 4)]
        public string LocationContext { get; set; }
        [CsvColumn(FieldIndex = 5)]
        public string BehaviorContext { get; set; }
        [CsvColumn(FieldIndex = 6)]
        public string Dialogue { get; set; }
        [CsvColumn(FieldIndex = 7)]
        public string RelationCondition { get; set; }
        [CsvColumn(FieldIndex = 8)]
        public string Notes { get; set; }
    }
}
