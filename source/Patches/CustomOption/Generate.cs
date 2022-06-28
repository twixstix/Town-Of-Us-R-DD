using System;

namespace TownOfUs.CustomOption
{
    public class Generate
    {
        public static CustomHeaderOption CrewInvestigativeRoles;
        public static CustomNumberOption DetectiveOn;
        public static CustomNumberOption HaunterOn;
        public static CustomNumberOption InvestigatorOn;
        public static CustomNumberOption MysticOn;
        public static CustomNumberOption SeerOn;
        public static CustomNumberOption SnitchOn;
        public static CustomNumberOption SpyOn;
        public static CustomNumberOption TrackerOn;
        public static CustomNumberOption TrapperOn;

        public static CustomHeaderOption CrewProtectiveRoles;
        public static CustomNumberOption AltruistOn;
        public static CustomNumberOption MedicOn;

        public static CustomHeaderOption CrewKillingRoles;
        public static CustomNumberOption SheriffOn;
        public static CustomNumberOption VeteranOn;
        public static CustomNumberOption VigilanteOn;

        public static CustomHeaderOption CrewSupportRoles;
        public static CustomNumberOption EngineerOn;
        public static CustomNumberOption MayorOn;
        public static CustomNumberOption MediumOn;
        public static CustomNumberOption SwapperOn;
        public static CustomNumberOption TimeLordOn;
        public static CustomNumberOption TransporterOn;

        public static CustomHeaderOption NeutralBenignRoles;
        public static CustomNumberOption AmnesiacOn;
        public static CustomNumberOption GuardianAngelOn;
        public static CustomNumberOption SurvivorOn;

        public static CustomHeaderOption NeutralEvilRoles;
        public static CustomNumberOption ExecutionerOn;
        public static CustomNumberOption JesterOn;
        public static CustomNumberOption PhantomOn;

        public static CustomHeaderOption NeutralKillingRoles;
        public static CustomNumberOption ArsonistOn;
        public static CustomNumberOption PlaguebearerOn;
        public static CustomNumberOption GlitchOn;
        public static CustomNumberOption WerewolfOn;

        public static CustomHeaderOption ImpostorConcealingRoles;
        public static CustomNumberOption MorphlingOn;
        public static CustomNumberOption SwooperOn;
        public static CustomNumberOption GrenadierOn;

        public static CustomHeaderOption ImpostorKillingRoles;
        public static CustomNumberOption PoisonerOn;
        public static CustomNumberOption TraitorOn;
        public static CustomNumberOption UnderdogOn;

        public static CustomHeaderOption ImpostorSupportRoles;
        public static CustomNumberOption BlackmailerOn;
        public static CustomNumberOption JanitorOn;
        public static CustomNumberOption MinerOn;
        public static CustomNumberOption UndertakerOn;

        public static CustomHeaderOption CrewmateModifiers;
        public static CustomNumberOption BaitOn;
        public static CustomNumberOption DiseasedOn;
        public static CustomNumberOption TorchOn;

        public static CustomHeaderOption GlobalModifiers;
        public static CustomNumberOption BlindOn;
        public static CustomNumberOption ButtonBarryOn;
        public static CustomNumberOption FlashOn;
        public static CustomNumberOption GiantOn;
        public static CustomNumberOption LoversOn;
        public static CustomNumberOption SleuthOn;
        public static CustomNumberOption TiebreakerOn;

        public static CustomHeaderOption CustomGameSettings;
        public static CustomToggleOption ColourblindComms;
        public static CustomToggleOption ImpostorSeeRoles;
        public static CustomToggleOption DeadSeeRoles;
        public static CustomToggleOption DisableLevels;
        public static CustomToggleOption WhiteNameplates;
        public static CustomNumberOption VanillaGame;
        public static CustomNumberOption InitialCooldowns;
        public static CustomToggleOption ParallelMedScans;
        public static CustomStringOption SkipButtonDisable;

        public static CustomHeaderOption RoleCountSettings;
        public static CustomNumberOption MinNeutralNonKillingRoles;
        public static CustomNumberOption MaxNeutralNonKillingRoles;
        public static CustomNumberOption MinNeutralKillingRoles;
        public static CustomNumberOption MaxNeutralKillingRoles;

        public static CustomHeaderOption TaskTrackingSettings;
        public static CustomToggleOption SeeTasksDuringRound;
        public static CustomToggleOption SeeTasksDuringMeeting;
        public static CustomToggleOption SeeTasksWhenDead;

        public static CustomHeaderOption Mayor;
        public static CustomNumberOption MayorVoteBank;
        public static CustomToggleOption MayorAnonymous;

        public static CustomHeaderOption Sheriff;
        public static CustomToggleOption SheriffKillOther;
        public static CustomToggleOption SheriffKillsJester;
        public static CustomToggleOption SheriffKillsGlitch;
        public static CustomToggleOption SheriffKillsExecutioner;
        public static CustomToggleOption SheriffKillsArsonist;
        public static CustomToggleOption SheriffKillsWerewolf;
        public static CustomToggleOption SheriffKillsPlaguebearer;
        public static CustomNumberOption SheriffKillCd;
        public static CustomToggleOption SheriffBodyReport;


        public static CustomHeaderOption Engineer;
        public static CustomStringOption EngineerPer;

        public static CustomHeaderOption Investigator;
        public static CustomNumberOption FootprintSize;
        public static CustomNumberOption FootprintInterval;
        public static CustomNumberOption FootprintDuration;
        public static CustomToggleOption AnonymousFootPrint;
        public static CustomToggleOption VentFootprintVisible;

        public static CustomHeaderOption TimeLord;
        public static CustomToggleOption RewindRevive;
        public static CustomNumberOption RewindDuration;
        public static CustomNumberOption RewindCooldown;
        public static CustomNumberOption RewindMaxUses;
        public static CustomToggleOption TimeLordVitals;

        public static CustomHeaderOption Medic;
        public static CustomStringOption ShowShielded;
        public static CustomStringOption WhoGetsNotification;
        public static CustomToggleOption ShieldBreaks;
        public static CustomToggleOption MedicReportSwitch;
        public static CustomNumberOption MedicReportNameDuration;
        public static CustomNumberOption MedicReportColorDuration;

        public static CustomHeaderOption Seer;
        public static CustomNumberOption SeerCooldown;
        public static CustomToggleOption CrewKillingRed;
        public static CustomToggleOption NeutBenignRed;
        public static CustomToggleOption NeutEvilRed;
        public static CustomToggleOption NeutKillingRed;
        public static CustomToggleOption TraitorColourSwap;

        public static CustomHeaderOption Swapper;
        public static CustomToggleOption SwapperButton;

        public static CustomHeaderOption Transporter;
        public static CustomNumberOption TransportCooldown;
        public static CustomNumberOption TransportMaxUses;
        public static CustomToggleOption TransporterVitals;

        public static CustomHeaderOption Jester;
        public static CustomToggleOption JesterButton;
        public static CustomToggleOption JesterVent;

        public static CustomHeaderOption TheGlitch;
        public static CustomNumberOption MimicCooldownOption;
        public static CustomNumberOption MimicDurationOption;
        public static CustomNumberOption HackCooldownOption;
        public static CustomNumberOption HackDurationOption;
        public static CustomNumberOption GlitchKillCooldownOption;
        public static CustomStringOption GlitchHackDistanceOption;
        public static CustomToggleOption GlitchVent;

        public static CustomHeaderOption Morphling;
        public static CustomNumberOption MorphlingCooldown;
        public static CustomNumberOption MorphlingDuration;
        public static CustomToggleOption MorphlingVent;

        public static CustomHeaderOption Executioner;
        public static CustomStringOption OnTargetDead;
        public static CustomToggleOption ExecutionerButton;

        public static CustomHeaderOption Phantom;
        public static CustomNumberOption PhantomTasksRemaining;

        public static CustomHeaderOption Snitch;
        public static CustomToggleOption SnitchOnLaunch;
        public static CustomToggleOption SnitchSeesNeutrals;
        public static CustomNumberOption SnitchTasksRemaining;
        public static CustomToggleOption SnitchSeesImpInMeeting;

        public static CustomHeaderOption Altruist;
        public static CustomNumberOption ReviveDuration;
        public static CustomToggleOption AltruistTargetBody;

        public static CustomHeaderOption Miner;
        public static CustomNumberOption MineCooldown;

        public static CustomHeaderOption Swooper;
        public static CustomNumberOption SwoopCooldown;
        public static CustomNumberOption SwoopDuration;
        public static CustomToggleOption SwooperVent;

        public static CustomHeaderOption Arsonist;
        public static CustomNumberOption DouseCooldown;
        public static CustomNumberOption MaxDoused;

        public static CustomHeaderOption Undertaker;
        public static CustomNumberOption DragCooldown;
        public static CustomToggleOption UndertakerVent;
        public static CustomToggleOption UndertakerVentWithBody;

        public static CustomHeaderOption Assassin;
        public static CustomNumberOption NumberOfAssassins;
        public static CustomToggleOption AmneTurnAssassin;
        public static CustomToggleOption TraitorCanAssassin;
        public static CustomNumberOption AssassinKills;
        public static CustomToggleOption AssassinMultiKill;
        public static CustomToggleOption AssassinCrewmateGuess;
        public static CustomToggleOption AssassinSnitchViaCrewmate;
        public static CustomToggleOption AssassinGuessNeutralBenign;
        public static CustomToggleOption AssassinGuessNeutralEvil;
        public static CustomToggleOption AssassinGuessNeutralKilling;
        public static CustomToggleOption AssassinGuessModifiers;
        public static CustomToggleOption AssassinGuessLovers;
        public static CustomToggleOption AssassinateAfterVoting;

        public static CustomHeaderOption Underdog;
        public static CustomNumberOption UnderdogKillBonus;
        public static CustomToggleOption UnderdogIncreasedKC;

        public static CustomHeaderOption Vigilante;
        public static CustomNumberOption VigilanteKills;
        public static CustomToggleOption VigilanteMultiKill;
        public static CustomToggleOption VigilanteGuessNeutralBenign;
        public static CustomToggleOption VigilanteGuessNeutralEvil;
        public static CustomToggleOption VigilanteGuessNeutralKilling;
        public static CustomToggleOption VigilanteGuessLovers;
        public static CustomToggleOption VigilanteAfterVoting;

        public static CustomHeaderOption Haunter;
        public static CustomNumberOption HaunterTasksRemainingClicked;
        public static CustomNumberOption HaunterTasksRemainingAlert;
        public static CustomToggleOption HaunterRevealsNeutrals;
        public static CustomStringOption HaunterCanBeClickedBy;

        public static CustomHeaderOption Grenadier;
        public static CustomNumberOption GrenadeCooldown;
        public static CustomNumberOption GrenadeDuration;
        public static CustomToggleOption GrenadierIndicators;
        public static CustomToggleOption GrenadierVent;
        public static CustomNumberOption FlashRadius;

        public static CustomHeaderOption Veteran;
        public static CustomToggleOption KilledOnAlert;
        public static CustomNumberOption AlertCooldown;
        public static CustomNumberOption AlertDuration;
        public static CustomNumberOption MaxAlerts;

        public static CustomHeaderOption Tracker;
        public static CustomNumberOption UpdateInterval;
        public static CustomNumberOption TrackCooldown;
        public static CustomToggleOption ResetOnNewRound;
        public static CustomNumberOption MaxTracks;

        public static CustomHeaderOption Trapper;
        public static CustomNumberOption TrapCooldown;
        public static CustomToggleOption TrapsRemoveOnNewRound;
        public static CustomNumberOption MaxTraps;
        public static CustomNumberOption MinAmountOfTimeInTrap;
        public static CustomNumberOption TrapSize;
        public static CustomNumberOption MinAmountOfPlayersInTrap;

        public static CustomHeaderOption Poisoner;
        public static CustomNumberOption PoisonCooldown;
        public static CustomNumberOption PoisonDuration;
        public static CustomToggleOption PoisonerVent;

        public static CustomHeaderOption Traitor;
        public static CustomNumberOption LatestSpawn;
        public static CustomToggleOption NeutralKillingStopsTraitor;

        public static CustomHeaderOption Amnesiac;
        public static CustomToggleOption RememberArrows;
        public static CustomNumberOption RememberArrowDelay;

        public static CustomHeaderOption Medium;
        public static CustomNumberOption MediateCooldown;
        public static CustomToggleOption ShowMediatePlayer;
        public static CustomToggleOption ShowMediumToDead;
        public static CustomStringOption DeadRevealed;

        public static CustomHeaderOption Survivor;
        public static CustomNumberOption VestCd;
        public static CustomNumberOption VestDuration;
        public static CustomNumberOption VestKCReset;
        public static CustomNumberOption MaxVests;

        public static CustomHeaderOption GuardianAngel;
        public static CustomNumberOption ProtectCd;
        public static CustomNumberOption ProtectDuration;
        public static CustomNumberOption ProtectKCReset;
        public static CustomNumberOption MaxProtects;
        public static CustomStringOption ShowProtect;
        public static CustomStringOption GaOnTargetDeath;
        public static CustomToggleOption GATargetKnows;
        public static CustomToggleOption GAKnowsTargetRole;

        public static CustomHeaderOption Mystic;
        public static CustomNumberOption MysticArrowDuration;

        public static CustomHeaderOption Blackmailer;
        public static CustomNumberOption BlackmailCooldown;

        public static CustomHeaderOption Plaguebearer;
        public static CustomNumberOption InfectCooldown;
        public static CustomNumberOption PestKillCooldown;
        public static CustomToggleOption PestVent;

        public static CustomHeaderOption Werewolf;
        public static CustomNumberOption RampageCooldown;
        public static CustomNumberOption RampageDuration;
        public static CustomNumberOption RampageKillCooldown;
        public static CustomToggleOption WerewolfVent;

        public static CustomHeaderOption Detective;
        public static CustomNumberOption InitialExamineCooldown;
        public static CustomNumberOption ExamineCooldown;
        public static CustomNumberOption RecentKill;
        public static CustomToggleOption DetectiveReportOn;
        public static CustomNumberOption DetectiveRoleDuration;
        public static CustomNumberOption DetectiveFactionDuration;

        public static CustomHeaderOption Giant;
        public static CustomNumberOption GiantSlow;

        public static CustomHeaderOption Flash;
        public static CustomNumberOption FlashSpeed;

        public static CustomHeaderOption Diseased;
        public static CustomNumberOption DiseasedKillMultiplier;

        public static CustomHeaderOption Bait;
        public static CustomNumberOption BaitMinDelay;
        public static CustomNumberOption BaitMaxDelay;

        public static CustomHeaderOption Lovers;
        public static CustomToggleOption BothLoversDie;
        public static CustomNumberOption LovingImpPercent;
        public static CustomToggleOption NeutralLovers;

        public static Func<object, string> PercentFormat { get; } = value => $"{value:0}%";
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}s";
        private static Func<object, string> MultiplierFormat { get; } = value => $"{value:0.0#}x";


        public static void GenerateAll()
        {
            var num = 0;

            Patches.ExportButton = new Export(num++);
            Patches.ImportButton = new Import(num++);


            CrewInvestigativeRoles = new CustomHeaderOption(num++, "Crewmate Investigative Roles");
            DetectiveOn = new CustomNumberOption(true, num++, "<color=#4D4DFFFF>Detective</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            HaunterOn = new CustomNumberOption(true, num++, "<color=#D3D3D3FF>Haunter</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            InvestigatorOn = new CustomNumberOption(true, num++, "<color=#00B3B3FF>Investigator</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MysticOn = new CustomNumberOption(true, num++, "<color=#4D99E6FF>Mystic</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SeerOn = new CustomNumberOption(true, num++, "<color=#FFCC80FF>Seer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SnitchOn = new CustomNumberOption(true, num++, "<color=#D4AF37FF>Snitch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SpyOn = new CustomNumberOption(true, num++, "<color=#CCA3CCFF>Spy</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrackerOn = new CustomNumberOption(true, num++, "<color=#009900FF>Tracker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrapperOn = new CustomNumberOption(true, num++, "<color=#A7D1B3FF>Trapper</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewKillingRoles = new CustomHeaderOption(num++, "Crewmate Killing Roles");
            SheriffOn = new CustomNumberOption(true, num++, "<color=#FFFF00FF>Sheriff</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VeteranOn = new CustomNumberOption(true, num++, "<color=#998040FF>Veteran</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VigilanteOn = new CustomNumberOption(true, num++, "<color=#FFFF99FF>Vigilante</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewProtectiveRoles = new CustomHeaderOption(num++, "Crewmate Protective Roles");
            AltruistOn = new CustomNumberOption(true, num++, "<color=#660000FF>Altruist</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MedicOn = new CustomNumberOption(true, num++, "<color=#006600FF>Medic</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewSupportRoles = new CustomHeaderOption(num++, "Crewmate Support Roles");
            EngineerOn = new CustomNumberOption(true, num++, "<color=#FFA60AFF>Engineer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MayorOn = new CustomNumberOption(true, num++, "<color=#704FA8FF>Mayor</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MediumOn = new CustomNumberOption(true, num++, "<color=#A680FFFF>Medium</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwapperOn = new CustomNumberOption(true, num++, "<color=#66E666FF>Swapper</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TimeLordOn = new CustomNumberOption(true, num++, "<color=#0000FFFF>Time Lord</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TransporterOn = new CustomNumberOption(true, num++, "<color=#00EEFFFF>Transporter</color>", 0f, 0f, 100f, 10f,
                PercentFormat);


            NeutralBenignRoles = new CustomHeaderOption(num++, "Neutral Benign Roles");
            AmnesiacOn = new CustomNumberOption(true, num++, "<color=#80B2FFFF>Amnesiac</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GuardianAngelOn = new CustomNumberOption(true, num++, "<color=#B3FFFFFF>Guardian Angel</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SurvivorOn = new CustomNumberOption(true, num++, "<color=#FFE64DFF>Survivor</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralEvilRoles = new CustomHeaderOption(num++, "Neutral Evil Roles");
            ExecutionerOn = new CustomNumberOption(true, num++, "<color=#8C4005FF>Executioner</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JesterOn = new CustomNumberOption(true, num++, "<color=#FFBFCCFF>Jester</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PhantomOn = new CustomNumberOption(true, num++, "<color=#662962FF>Phantom</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralKillingRoles = new CustomHeaderOption(num++, "Neutral Killing Roles");
            ArsonistOn = new CustomNumberOption(true, num++, "<color=#FF4D00FF>Arsonist</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PlaguebearerOn = new CustomNumberOption(true, num++, "<color=#E6FFB3FF>Plaguebearer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GlitchOn = new CustomNumberOption(true, num++, "<color=#00FF00FF>The Glitch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            WerewolfOn = new CustomNumberOption(true, num++, "<color=#A86629FF>Werewolf</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorConcealingRoles = new CustomHeaderOption(num++, "Impostor Concealing Roles");
            GrenadierOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>Grenadier</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MorphlingOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>Morphling</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwooperOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>Swooper</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorKillingRoles = new CustomHeaderOption(num++, "Impostor Killing Roles");
            PoisonerOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>Poisoner</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TraitorOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>Traitor</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UnderdogOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>Underdog</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorSupportRoles = new CustomHeaderOption(num++, "Impostor Support Roles");
            BlackmailerOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>Blackmailer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JanitorOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>Janitor</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MinerOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>Miner</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UndertakerOn = new CustomNumberOption(true, num++, "<color=#FF0000FF>Undertaker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewmateModifiers = new CustomHeaderOption(num++, "Crewmate Modifiers");
            BaitOn = new CustomNumberOption(true, num++, "<color=#00B3B3FF>Bait</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DiseasedOn = new CustomNumberOption(true, num++, "<color=#808080FF>Diseased</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TorchOn = new CustomNumberOption(true, num++, "<color=#FFFF99FF>Torch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GlobalModifiers = new CustomHeaderOption(num++, "Global Modifiers");
            BlindOn = new CustomNumberOption(true, num++, "<color=#AAAAAAFF>Blind</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            ButtonBarryOn = new CustomNumberOption(true, num++, "<color=#E600FFFF>Button Barry</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            FlashOn = new CustomNumberOption(true, num++, "<color=#FF8080FF>Flash</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GiantOn = new CustomNumberOption(true, num++, "<color=#FFB34DFF>Giant</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            LoversOn = new CustomNumberOption(true, num++, "<color=#FF66CCFF>Lovers</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SleuthOn = new CustomNumberOption(true, num++, "<color=#803333FF>Sleuth</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TiebreakerOn = new CustomNumberOption(true, num++, "<color=#99E699FF>Tiebreaker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CustomGameSettings =
                new CustomHeaderOption(num++, "Custom Game Settings");
            ColourblindComms = new CustomToggleOption(num++, "Camouflaged Comms", false);
            ImpostorSeeRoles = new CustomToggleOption(num++, "Impostors Can See The Roles Of Their Team", false);
            DeadSeeRoles =
                new CustomToggleOption(num++, "Dead Can See Everyone's Roles/Votes", false);
            VanillaGame = new CustomNumberOption(num++, "Probability Of A Completely Vanilla Game", 0f, 0f, 100f, 5f,
                PercentFormat);
            InitialCooldowns =
                new CustomNumberOption(num++, "Game Start Cooldowns", 10, 10, 30, 2.5f, CooldownFormat);
            ParallelMedScans = new CustomToggleOption(num++, "Parallel Medbay Scans", false);
            SkipButtonDisable = new CustomStringOption(num++, "Disable Meeting Skip Button", new[] { "No", "Emergency", "Always" });
            DisableLevels = new CustomToggleOption(num++, "Disable Level Icons", false);
            WhiteNameplates = new CustomToggleOption(num++, "Disable Player Nameplates", false);

            RoleCountSettings =
                new CustomHeaderOption(num++, "Role Count Settings");
            MinNeutralNonKillingRoles =
                new CustomNumberOption(num++, "Min Neutral Non-Killing Roles", 1f, 0f, 5f, 1f);
            MaxNeutralNonKillingRoles =
                new CustomNumberOption(num++, "Max Neutral Non-Killing Roles", 1f, 0f, 5f, 1f);
            MinNeutralKillingRoles =
                new CustomNumberOption(num++, "Min Neutral Killing Roles", 1f, 0f, 4f, 1f);
            MaxNeutralKillingRoles =
                new CustomNumberOption(num++, "Max Neutral Killing Roles", 1f, 0f, 4f, 1f);

            TaskTrackingSettings =
                new CustomHeaderOption(num++, "Task Tracking Settings");
            SeeTasksDuringRound = new CustomToggleOption(num++, "See Tasks During Round", false);
            SeeTasksDuringMeeting = new CustomToggleOption(num++, "See Tasks During Meetings", false);
            SeeTasksWhenDead = new CustomToggleOption(num++, "See Tasks When Dead", true);

            Assassin = new CustomHeaderOption(num++, "<color=#FF0000FF>Assassin Ability</color>");
            NumberOfAssassins = new CustomNumberOption(num++, "Number Of Assassins", 1, 0, 3, 1);
            AmneTurnAssassin = new CustomToggleOption(num++, "Amnesiac Turned Impostor Gets Ability", false);
            TraitorCanAssassin = new CustomToggleOption(num++, "Traitor Gets Ability", false);
            AssassinKills = new CustomNumberOption(num++, "Number Of Assassin Kills", 1, 1, 15, 1);
            AssassinMultiKill = new CustomToggleOption(num++, "Assassin Can Kill More Than Once Per Meeting", false);
            AssassinCrewmateGuess = new CustomToggleOption(num++, "Assassin Can Guess \"Crewmate\"", false);
            AssassinSnitchViaCrewmate = new CustomToggleOption(num++, "Assassinate Snitch Via \"Crewmate\" Guess", false);
            AssassinGuessNeutralBenign = new CustomToggleOption(num++, "Assassin Can Guess Neutral Benign Roles", false);
            AssassinGuessNeutralEvil = new CustomToggleOption(num++, "Assassin Can Guess Neutral Evil Roles", false);
            AssassinGuessNeutralKilling = new CustomToggleOption(num++, "Assassin Can Guess Neutral Killing Roles", false);
            AssassinGuessModifiers = new CustomToggleOption(num++, "Assassin Can Guess Crewmate Modifiers", false);
            AssassinGuessLovers = new CustomToggleOption(num++, "Assassin Can Guess Lovers", false);
            AssassinateAfterVoting = new CustomToggleOption(num++, "Assassin Can Guess After Voting", false);

            Detective =
                new CustomHeaderOption(num++, "<color=#4D4DFFFF>Detective</color>");
            InitialExamineCooldown =
                new CustomNumberOption(num++, "Initial Examine Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ExamineCooldown =
                new CustomNumberOption(num++, "Examine Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            RecentKill =
                new CustomNumberOption(num++, "How Long Players Stay Bloody For", 25f, 10f, 60f, 2.5f, CooldownFormat);
            DetectiveReportOn = new CustomToggleOption(num++, "Show Detective Reports", true);
            DetectiveRoleDuration =
                new CustomNumberOption(num++, "Time Where Detective Will Have Role", 15, 0, 60, 2.5f,
                    CooldownFormat);
            DetectiveFactionDuration =
                new CustomNumberOption(num++, "Time Where Detective Will Have Faction", 30, 0, 120, 2.5f,
                    CooldownFormat);

            Haunter =
                new CustomHeaderOption(num++, "<color=#d3d3d3FF>Haunter</color>");
            HaunterTasksRemainingClicked =
                 new CustomNumberOption(num++, "Tasks Remaining When Haunter Can Be Clicked", 5, 1, 10, 1);
            HaunterTasksRemainingAlert =
                 new CustomNumberOption(num++, "Tasks Remaining When Alert Is Sent", 1, 1, 5, 1);
            HaunterRevealsNeutrals = new CustomToggleOption(num++, "Haunter Reveals Neutral Roles", false);
            HaunterCanBeClickedBy = new CustomStringOption(num++, "Who Can Click Haunter", new[] { "All", "Non-Crew", "Imps Only" });

            Investigator =
                new CustomHeaderOption(num++, "<color=#00B3B3FF>Investigator</color>");
            FootprintSize = new CustomNumberOption(num++, "Footprint Size", 4f, 1f, 10f, 1f);
            FootprintInterval =
                new CustomNumberOption(num++, "Footprint Interval", 0.1f, 0.05f, 1f, 0.05f, CooldownFormat);
            FootprintDuration = new CustomNumberOption(num++, "Footprint Duration", 10f, 1f, 10f, 0.5f, CooldownFormat);
            AnonymousFootPrint = new CustomToggleOption(num++, "Anonymous Footprint", false);
            VentFootprintVisible = new CustomToggleOption(num++, "Footprint Vent Visible", false);

            Mystic =
                new CustomHeaderOption(num++, "<color=#4D99E6FF>Mystic</color>");
            MysticArrowDuration =
                new CustomNumberOption(num++, "Dead Body Arrow Duration", 0.1f, 0f, 1f, 0.05f, CooldownFormat);

            Seer =
                new CustomHeaderOption(num++, "<color=#FFCC80FF>Seer</color>");
            SeerCooldown =
                new CustomNumberOption(num++, "Seer Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            CrewKillingRed =
                new CustomToggleOption(num++, "Crewmate Killing Roles Show Evil", false);
            NeutBenignRed =
                new CustomToggleOption(num++, "Neutral Benign Roles Show Evil", false);
            NeutEvilRed =
                new CustomToggleOption(num++, "Neutral Evil Roles Show Evil", false);
            NeutKillingRed =
                new CustomToggleOption(num++, "Neutral Killing Roles Show Evil", false);
            TraitorColourSwap =
                new CustomToggleOption(num++, "Traitor Does Not Swap Colours", false);

            Snitch = new CustomHeaderOption(num++, "<color=#D4AF37FF>Snitch</color>");
            SnitchOnLaunch =
                new CustomToggleOption(num++, "Snitch Knows Who They Are On Game Start", false);
            SnitchSeesNeutrals = new CustomToggleOption(num++, "Snitch Sees Neutral Roles", false);
            SnitchTasksRemaining =
                 new CustomNumberOption(num++, "Tasks Remaining When Revealed", 1, 1, 5, 1);
            SnitchSeesImpInMeeting = new CustomToggleOption(num++, "Snitch Sees Impostors In Meetings", true);

            Tracker =
                new CustomHeaderOption(num++, "<color=#009900FF>Tracker</color>");
            UpdateInterval =
                new CustomNumberOption(num++, "Arrow Update Interval", 5f, 0.5f, 15f, 0.5f, CooldownFormat);
            TrackCooldown =
                new CustomNumberOption(num++, "Track Cooldown", 25f, 10f, 40f, 2.5f, CooldownFormat);
            ResetOnNewRound = new CustomToggleOption(num++, "Tracker Arrows Reset After Each Round", false);
            MaxTracks = new CustomNumberOption(num++, "Maximum Number Of Tracks Per Round", 5, 1, 15, 1);

            Trapper =
                new CustomHeaderOption(num++, "<color=#A7D1B3FF>Trapper</color>");
            MinAmountOfTimeInTrap =
                new CustomNumberOption(num++, "Min Amount Of Time In Trap To Register", 1f, 0f, 15f, 0.5f, CooldownFormat);
            TrapCooldown =
                new CustomNumberOption(num++, "Trap Cooldown", 25f, 10f, 40f, 2.5f, CooldownFormat);
            TrapsRemoveOnNewRound =
                new CustomToggleOption(num++, "Traps Removed After Each Round", true);
            MaxTraps =
                new CustomNumberOption(num++, "Maximum Number Of Traps Per Game", 5, 1, 15, 1);
            TrapSize =
                new CustomNumberOption(num++, "Trap Size", 1f, 0.5f, 5f, 0.5f, MultiplierFormat);
            MinAmountOfPlayersInTrap =
                new CustomNumberOption(num++, "Minimum Number Of Roles Required To Trigger Trap", 3, 1, 5, 1);

            Sheriff =
                new CustomHeaderOption(num++, "<color=#FFFF00FF>Sheriff</color>");
            SheriffKillOther =
                new CustomToggleOption(num++, "Sheriff Miskill Kills Crewmate", false);
            SheriffKillsJester =
                new CustomToggleOption(num++, "Sheriff Kills Jester", false);
            SheriffKillsGlitch =
                new CustomToggleOption(num++, "Sheriff Kills The Glitch", false);
            SheriffKillsExecutioner =
                new CustomToggleOption(num++, "Sheriff Kills Executioner", false);
            SheriffKillsArsonist =
                new CustomToggleOption(num++, "Sheriff Kills Arsonist", false);
            SheriffKillsWerewolf =
                new CustomToggleOption(num++, "Sheriff Kills Werewolf", false);
            SheriffKillsPlaguebearer =
                new CustomToggleOption(num++, "Sheriff Kills Plaguebearer", false);
            SheriffKillCd =
                new CustomNumberOption(num++, "Sheriff Kill Cooldown", 25f, 10f, 40f, 2.5f, CooldownFormat);
            SheriffBodyReport = new CustomToggleOption(num++, "Sheriff Can Report Who They've Killed");

            Veteran =
                new CustomHeaderOption(num++, "<color=#998040FF>Veteran</color>");
            KilledOnAlert =
                new CustomToggleOption(num++, "Can Be Killed On Alert", false);
            AlertCooldown =
                new CustomNumberOption(num++, "Alert Cooldown", 25, 10, 60, 2.5f, CooldownFormat);
            AlertDuration =
                new CustomNumberOption(num++, "Alert Duration", 10, 5, 15, 1f, CooldownFormat);
            MaxAlerts = new CustomNumberOption(num++, "Maximum Number Of Alerts", 5, 1, 15, 1);

            Vigilante = new CustomHeaderOption(num++, "<color=#FFFF99FF>Vigilante</color>");
            VigilanteKills = new CustomNumberOption(num++, "Number Of Vigilante Kills", 1, 1, 15, 1);
            VigilanteMultiKill = new CustomToggleOption(num++, "Vigilante Can Kill More Than Once Per Meeting", false);
            VigilanteGuessNeutralBenign = new CustomToggleOption(num++, "Vigilante Can Guess Neutral Benign Roles", false);
            VigilanteGuessNeutralEvil = new CustomToggleOption(num++, "Vigilante Can Guess Neutral Evil Roles", false);
            VigilanteGuessNeutralKilling = new CustomToggleOption(num++, "Vigilante Can Guess Neutral Killing Roles", false);
            VigilanteGuessLovers = new CustomToggleOption(num++, "Vigilante Can Guess Lovers", false);
            VigilanteAfterVoting = new CustomToggleOption(num++, "Vigilante Can Guess After Voting", false);

            Altruist = new CustomHeaderOption(num++, "<color=#660000FF>Altruist</color>");
            ReviveDuration =
                new CustomNumberOption(num++, "Altruist Revive Duration", 10, 1, 30, 1f, CooldownFormat);
            AltruistTargetBody =
                new CustomToggleOption(num++, "Target's Body Disappears On Beginning Of Revive", false);

            Medic =
                new CustomHeaderOption(num++, "<color=#006600FF>Medic</color>");
            ShowShielded =
                new CustomStringOption(num++, "Show Shielded Player",
                    new[] { "Self", "Medic", "Self+Medic", "Everyone" });
            WhoGetsNotification =
                new CustomStringOption(num++, "Who Gets Murder Attempt Indicator",
                    new[] { "Medic", "Shielded", "Everyone", "Nobody" });
            ShieldBreaks = new CustomToggleOption(num++, "Shield Breaks On Murder Attempt", false);
            MedicReportSwitch = new CustomToggleOption(num++, "Show Medic Reports");
            MedicReportNameDuration =
                new CustomNumberOption(num++, "Time Where Medic Will Have Name", 0, 0, 60, 2.5f,
                    CooldownFormat);
            MedicReportColorDuration =
                new CustomNumberOption(num++, "Time Where Medic Will Have Color Type", 15, 0, 120, 2.5f,
                    CooldownFormat);

            Engineer =
                new CustomHeaderOption(num++, "<color=#FFA60AFF>Engineer</color>");
            EngineerPer =
                new CustomStringOption(num++, "Engineer Fix Per", new[] { "Round", "Game" });

            Mayor =
                new CustomHeaderOption(num++, "<color=#704FA8FF>Mayor</color>");
            MayorVoteBank =
                new CustomNumberOption(num++, "Initial Mayor Vote Bank", 1, 1, 5, 1);
            MayorAnonymous =
                new CustomToggleOption(num++, "Mayor Votes Show Anonymous", false);

            Medium =
                new CustomHeaderOption(num++, "<color=#A680FFFF>Medium</color>");
            MediateCooldown =
                new CustomNumberOption(num++, "Mediate Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            ShowMediatePlayer =
                new CustomToggleOption(num++, "Reveal Appearance Of Mediate Target", true);
            ShowMediumToDead =
                new CustomToggleOption(num++, "Reveal The Medium To The Mediate Target", true);
            DeadRevealed =
                new CustomStringOption(num++, "Who Is Revealed With Mediate", new[] { "Oldest Dead", "Newest Dead", "All Dead" });

            Swapper =
                new CustomHeaderOption(num++, "<color=#66E666FF>Swapper</color>");
            SwapperButton =
                new CustomToggleOption(num++, "Swapper Can Button", true);

            TimeLord =
                new CustomHeaderOption(num++, "<color=#0000FFFF>Time Lord</color>");
            RewindRevive = new CustomToggleOption(num++, "Revive During Rewind", false);
            RewindDuration = new CustomNumberOption(num++, "Rewind Duration", 2f, 2f, 5f, 0.5f, CooldownFormat);
            RewindCooldown = new CustomNumberOption(num++, "Rewind Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RewindMaxUses =
                 new CustomNumberOption(num++, "Maximum Number Of Rewinds", 5, 1, 15, 1);
            TimeLordVitals =
                new CustomToggleOption(num++, "Time Lord Can Use Vitals", false);

            Transporter =
                new CustomHeaderOption(num++, "<color=#00EEFFFF>Transporter</color>");
            TransportCooldown =
                new CustomNumberOption(num++, "Transport Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TransportMaxUses =
                new CustomNumberOption(num++, "Maximum Number Of Transports", 5, 1, 15, 1);
            TransporterVitals =
                new CustomToggleOption(num++, "Transporter Can Use Vitals", false);

            Amnesiac = new CustomHeaderOption(num++, "<color=#80B2FFFF>Amnesiac</color>");
            RememberArrows =
                new CustomToggleOption(num++, "Amnesiac Gets Arrows Pointing To Dead Bodies", false);
            RememberArrowDelay =
                new CustomNumberOption(num++, "Time After Death Arrow Appears", 5f, 0f, 15f, 1f, CooldownFormat);

            GuardianAngel =
                new CustomHeaderOption(num++, "<color=#B3FFFFFF>Guardian Angel</color>");
            ProtectCd =
                new CustomNumberOption(num++, "Protect Cooldown", 25, 10, 60, 2.5f, CooldownFormat);
            ProtectDuration =
                new CustomNumberOption(num++, "Protect Duration", 10, 5, 15, 1f, CooldownFormat);
            ProtectKCReset =
                new CustomNumberOption(num++, "Kill Cooldown Reset When Protected", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxProtects =
                new CustomNumberOption(num++, "Maximum Number Of Protects", 5, 1, 15, 1);
            ShowProtect =
                new CustomStringOption(num++, "Show Protected Player",
                    new[] { "Self", "Guardian Angel", "Self+GA", "Everyone" });
            GaOnTargetDeath = new CustomStringOption(num++, "GA Becomes On Target Dead",
                new[] { "Crew", "Amnesiac", "Survivor", "Jester" });
            GATargetKnows =
                new CustomToggleOption(num++, "Target Knows GA Exists", false);
            GAKnowsTargetRole =
                new CustomToggleOption(num++, "GA Knows Targets Role", false);

            Survivor =
                new CustomHeaderOption(num++, "<color=#FFE64DFF>Survivor</color>");
            VestCd =
                new CustomNumberOption(num++, "Vest Cooldown", 25, 10, 60, 2.5f, CooldownFormat);
            VestDuration =
                new CustomNumberOption(num++, "Vest Duration", 10, 5, 15, 1f, CooldownFormat);
            VestKCReset =
                new CustomNumberOption(num++, "Kill Cooldown Reset On Attack", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxVests =
                new CustomNumberOption(num++, "Maximum Number Of Vests", 5, 1, 15, 1);

            Executioner =
                new CustomHeaderOption(num++, "<color=#8C4005FF>Executioner</color>");
            OnTargetDead = new CustomStringOption(num++, "Executioner Becomes On Target Dead",
                new[] { "Crew", "Amnesiac", "Survivor", "Jester" });
            ExecutionerButton =
                new CustomToggleOption(num++, "Executioner Can Button", true);

            Jester =
                new CustomHeaderOption(num++, "<color=#FFBFCCFF>Jester</color>");
            JesterButton =
                new CustomToggleOption(num++, "Jester Can Button", true);
            JesterVent =
                new CustomToggleOption(num++, "Jester Can Hide In Vents", false);

            Phantom =
                new CustomHeaderOption(num++, "<color=#662962FF>Phantom</color>");
            PhantomTasksRemaining =
                 new CustomNumberOption(num++, "Tasks Remaining When Phantom Can Be Clicked", 5, 1, 10, 1);

            Arsonist = new CustomHeaderOption(num++, "<color=#FF4D00FF>Arsonist</color>");
            DouseCooldown =
                new CustomNumberOption(num++, "Douse Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxDoused =
                new CustomNumberOption(num++, "Maximum Alive Players Doused", 5, 1, 15, 1);

            Plaguebearer = new CustomHeaderOption(num++, "<color=#E6FFB3FF>Plaguebearer</color>");
            InfectCooldown =
                new CustomNumberOption(num++, "Infect Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestKillCooldown =
                new CustomNumberOption(num++, "Pestilence Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestVent =
                new CustomToggleOption(num++, "Pestilence Can Vent", false);

            TheGlitch =
                new CustomHeaderOption(num++, "<color=#00FF00FF>The Glitch</color>");
            MimicCooldownOption = new CustomNumberOption(num++, "Mimic Cooldown", 25f, 10f, 120f, 2.5f, CooldownFormat);
            MimicDurationOption = new CustomNumberOption(num++, "Mimic Duration", 10f, 1f, 30f, 1f, CooldownFormat);
            HackCooldownOption = new CustomNumberOption(num++, "Hack Cooldown", 25f, 10f, 120f, 2.5f, CooldownFormat);
            HackDurationOption = new CustomNumberOption(num++, "Hack Duration", 10f, 1f, 30f, 1f, CooldownFormat);
            GlitchKillCooldownOption =
                new CustomNumberOption(num++, "Glitch Kill Cooldown", 25f, 10f, 120f, 2.5f, CooldownFormat);
            GlitchHackDistanceOption =
                new CustomStringOption(num++, "Glitch Hack Distance", new[] { "Short", "Normal", "Long" });
            GlitchVent =
                new CustomToggleOption(num++, "Glitch Can Vent", false);

            Werewolf = new CustomHeaderOption(num++, "<color=#A86629FF>Werewolf</color>");
            RampageCooldown =
                new CustomNumberOption(num++, "Rampage Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageDuration =
                new CustomNumberOption(num++, "Rampage Duration", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageKillCooldown =
                new CustomNumberOption(num++, "Rampage Kill Cooldown", 10f, 0.5f, 15f, 0.5f, CooldownFormat);
            WerewolfVent =
                new CustomToggleOption(num++, "Werewolf Can Vent When Rampaged", false);

            Grenadier =
                new CustomHeaderOption(num++, "<color=#FF0000FF>Grenadier</color>");
            GrenadeCooldown =
                new CustomNumberOption(num++, "Flash Grenade Cooldown", 25, 10, 40, 2.5f, CooldownFormat);
            GrenadeDuration =
                new CustomNumberOption(num++, "Flash Grenade Duration", 10, 5, 15, 1f, CooldownFormat);
            FlashRadius =
                new CustomNumberOption(num++, "Flash Radius", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            GrenadierIndicators =
                new CustomToggleOption(num++, "Indicate Flashed Crewmates", false);
            GrenadierVent =
                new CustomToggleOption(num++, "Grenadier Can Vent", false);

            Morphling =
                new CustomHeaderOption(num++, "<color=#FF0000FF>Morphling</color>");
            MorphlingCooldown =
                new CustomNumberOption(num++, "Morphling Cooldown", 25, 10, 40, 2.5f, CooldownFormat);
            MorphlingDuration =
                new CustomNumberOption(num++, "Morphling Duration", 10, 5, 15, 1f, CooldownFormat);
            MorphlingVent =
                new CustomToggleOption(num++, "Morphling Can Vent", false);

            Swooper = new CustomHeaderOption(num++, "<color=#FF0000FF>Swooper</color>");

            SwoopCooldown =
                new CustomNumberOption(num++, "Swoop Cooldown", 25, 10, 40, 2.5f, CooldownFormat);
            SwoopDuration =
                new CustomNumberOption(num++, "Swoop Duration", 10, 5, 15, 1f, CooldownFormat);
            SwooperVent =
                new CustomToggleOption(num++, "Swooper Can Vent", false);

            Poisoner =
                new CustomHeaderOption(num++, "<color=#FF0000FF>Poisoner</color>");
            PoisonCooldown =
                new CustomNumberOption(num++, "Poison Cooldown", 25, 10, 40, 2.5f, CooldownFormat);
            PoisonDuration =
                new CustomNumberOption(num++, "Poison Kill Delay", 5, 1, 15, 1f, CooldownFormat);
            PoisonerVent =
                new CustomToggleOption(num++, "Poisoner Can Vent", false);

            Traitor = new CustomHeaderOption(num++, "<color=#FF0000FF>Traitor</color>");
            LatestSpawn = new CustomNumberOption(num++, "Minimum People Alive When Traitor Can Spawn", 5, 3, 15, 1);
            NeutralKillingStopsTraitor =
                new CustomToggleOption(num++, "Traitor Won't Spawn If Any Neutral Killing Is Alive", false);

            Underdog = new CustomHeaderOption(num++, "<color=#FF0000FF>Underdog</color>");
            UnderdogKillBonus = new CustomNumberOption(num++, "Kill Cooldown Bonus", 5, 2.5f, 30, 2.5f, CooldownFormat);
            UnderdogIncreasedKC = new CustomToggleOption(num++, "Increased Kill Cooldown When 2+ Imps", true);

            Blackmailer = new CustomHeaderOption(num++, "<color=#FF0000FF>Blackmailer</color>");
            BlackmailCooldown =
                new CustomNumberOption(num++, "Initial Blackmail Cooldown", 10, 1, 15, 1f, CooldownFormat);

            Miner = new CustomHeaderOption(num++, "<color=#FF0000FF>Miner</color>");
            MineCooldown =
                new CustomNumberOption(num++, "Mine Cooldown", 25, 10, 40, 2.5f, CooldownFormat);

            Undertaker = new CustomHeaderOption(num++, "<color=#FF0000FF>Undertaker</color>");
            DragCooldown = new CustomNumberOption(num++, "Drag Cooldown", 25, 10, 40, 2.5f, CooldownFormat);
            UndertakerVent =
                new CustomToggleOption(num++, "Undertaker Can Vent", false);
            UndertakerVentWithBody =
                new CustomToggleOption(num++, "Undertaker Can Vent While Dragging", false);

            Bait = new CustomHeaderOption(num++, "<color=#00B3B3FF>Bait</color>");
            BaitMinDelay = new CustomNumberOption(num++, "Minimum Delay for the Bait Report", 0f, 0f, 15f, 0.5f, CooldownFormat);
            BaitMaxDelay = new CustomNumberOption(num++, "Maximum Delay for the Bait Report", 1f, 0f, 15f, 0.5f, CooldownFormat);

            Diseased = new CustomHeaderOption(num++, "<color=#808080FF>Diseased</color>");
            DiseasedKillMultiplier = new CustomNumberOption(num++, "Diseased Kill Multiplier", 3f, 1.5f, 5f, 0.5f, MultiplierFormat);

            Flash = new CustomHeaderOption(num++, "<color=#FF8080FF>Flash</color>");
            FlashSpeed = new CustomNumberOption(num++, "Flash Speed", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);

            Giant = new CustomHeaderOption(num++, "<color=#FFB34DFF>Giant</color>");
            GiantSlow = new CustomNumberOption(num++, "Giant Speed", 0.75f, 0.5f, 1f, 0.05f, MultiplierFormat);

            Lovers =
                new CustomHeaderOption(num++, "<color=#FF66CCFF>Lovers</color>");
            BothLoversDie = new CustomToggleOption(num++, "Both Lovers Die");
            LovingImpPercent = new CustomNumberOption(num++, "Loving Impostor Probability", 20f, 0f, 100f, 10f,
                PercentFormat);
            NeutralLovers = new CustomToggleOption(num++, "Neutral Roles Can Be Lovers");
        }
    }
}