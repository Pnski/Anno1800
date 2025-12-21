namespace T9SDKAuto
{
	public class MyGlobalVars
	{
		public MyGlobalVars()
		{
		}
		
		#region Properties
		#endregion
		#region Fields
		public static readonly string Hash = "F0-BA-99-76-EC-10-B4-7F-95-78-E7-C0-12-39-9E-22-72-6B-4F-9B-F8-49-E7-5A-C6-AB-73-DE-CF-BD-65-EC-40-28-20-0F-31-7A-21-B2-E8-AA-77-65-12-A5-15-AA-65-6C-EE-B0-E7-44-B9-93-25-27-9F-DE-BB-09-EB-34";
		#endregion
	}
	
	public enum AchievementCategory
	{
		@NOSELECTION = -1,
		@Economy = 0,
		@Military = 1,
		@Items = 2,
		@Culture = 3,
		@Online = 4,
		@General = 5,
		@Hidden = 6,
		@ProAchievements = 7,
		@DLC06 = 8,
		@DM = 9,
		@DLC01 = 10,
		@DLC02 = 11,
		@DLC03 = 12,
		@Progression = 13,
		@ThirdParty = 14,
		@Exploration = 15,
		@Campaign = 16,
		@Construction = 17,
		@Population = 18,
		@Trade = 19,
		@DLC04 = 20,
		@DLC05 = 21,
		@DLC07 = 22,
		@DLC08 = 23,
		@DLC09 = 24
	}
	
	public enum AchievementDifficulty
	{
		@NOSELECTION = -1,
		@Beginner = 0,
		@Common = 1,
		@Expert = 2
	}
	
	public enum AchievementRewardCategory
	{
		@NOSELECTION = -1,
		@OrnamentalBuildings = 0,
		@Portraits = 1,
		@Colors = 2,
		@CompanyLogos = 3
	}
	
	public enum AmbientZone
	{
		@NOSELECTION = -1,
		@North = 0,
		@South = 1
	}
	
	public enum AttackableType
	{
		@NOSELECTION = -1,
		@TradeShip = 0,
		@WarShip = 1,
		@Kontor = 2,
		@DefenseBuilding = 3,
		@MilitaryTakeoverTarget = 4,
		@OngoingWarTarget = 5
	}
	
	public enum AttackCondition
	{
		@NOSELECTION = -1,
		@IsStronger = 0,
		@IsWeaker = 1,
		@IsFarther = 2,
		@IsNearer = 3,
		@LowHitpoints = 4,
		@IsNotMoving = 5,
		@LowMilitaryTakeoverMorale = 6,
		@IsSmallerHarbour = 7,
		@IsLargerHarbour = 8
	}
	
	public enum AttractivenessLevel
	{
		@NOSELECTION = -1,
		@Hideous = 0,
		@Revolting = 1,
		@Foul = 2,
		@Funereal = 3,
		@Dreary = 4,
		@Ordinary = 5,
		@Fair = 6,
		@Quaint = 7,
		@Curious = 8,
		@Pleasant = 9,
		@Appealing = 10,
		@Picturesque = 11,
		@Attractive = 12,
		@Beguiling = 13,
		@Enticing = 14,
		@Delightful = 15,
		@Beautiful = 16,
		@Glamorous = 17,
		@Impeccable = 18,
		@Grand = 19,
		@Superior = 20,
		@Exquisite = 21
	}
	
	public enum BuildingTerrainType
	{
		@NOSELECTION = -1,
		@Terrain = 0,
		@Water_Including_Coast = 1,
		@Coast = 2,
		@Water_Excluding_Coast = 3
	}
	
	public enum BuildingType
	{
		@NOSELECTION = -1,
		@Other = 0,
		@Residence = 1,
		@Factory = 2,
		@Mine = 3,
		@Logistic = 4,
		@Public = 5,
		@BuildingModule = 6,
		@Warehouse = 7
	}
	
	public enum ChatCommand
	{
		@NOSELECTION = -1,
		@Help = 0,
		@Whisper = 1,
		@Team = 2,
		@Coop = 3,
		@Mute = 4,
		@Unmute = 5
	}
	
	public enum ChatMessage
	{
		@NOSELECTION = -1,
		@All = 0,
		@Team = 1,
		@Coop = 2,
		@Whisper = 3,
		@System = 4,
		@Transcribed = 5
	}
	
	public enum CitySize
	{
		@NOSELECTION = -1,
		@Settlement = 0,
		@Village = 1,
		@PortTown = 2,
		@City = 3,
		@Capital = 4,
		@Metropolis = 5,
		@ColonyTown = 6,
		@Colony = 7
	}
	
	public enum ComparisonOperator
	{
		@NOSELECTION = -1,
		@AtLeast = 0,
		@AtMost = 1,
		@Equals = 2,
		@LessThan = 3,
		@MoreThan = 4
	}
	
	public enum CriticalErrorType
	{
		@NOSELECTION = -1,
		@UplayApiDisconnected = 0,
		@UplayAccountShared = 1,
		@UplayOwnershipRevoked = 2,
		@SavegameFolderPermissionsDenied = 3
	}
	
	public enum DamageTarget
	{
		@NOSELECTION = -1,
		@Building = 0,
		@SailShip = 1,
		@SteamShip = 2
	}
	
	public enum DamageType
	{
		@NOSELECTION = -1,
		@Normal = 0,
		@Torpedo = 1,
		@Cannon = 2,
		@BigBertha = 3
	}
	
	public enum DynamicVariationType
	{
		@NOSELECTION = -1,
		@TestData = 0,
		@SequenceAsset = 1
	}
	
	public enum EconomyIncomeCategory
	{
		@NOSELECTION = -1,
		@AdministrationBuildings = 0,
		@BoughtShares = 1,
		@CharterShips = 2,
		@CityInstitutionBuildings = 3,
		@CultureBuildings = 4,
		@HarbourBuildings = 5,
		@InfrastructureBuildings = 6,
		@LostShares = 7,
		@Newspaper = 8,
		@ProductionBuildings = 9,
		@PublicServiceBuildings = 10,
		@RoyalTaxes = 11,
		@Residences = 12,
		@TradeShips = 13,
		@Visitors = 14,
		@WarShips = 15
	}
	
	public enum FeedbackSequenceType
	{
		@NOSELECTION = -1,
		@Default = 0,
		@Work = 1,
		@LowProductivity = 2,
		@Cheer = 3,
		@Boosted = 4,
		@Riot = 5,
		@RiotSpecial01 = 6,
		@RiotSpecial02 = 7,
		@RiotSpecial03 = 8
	}
	
	public enum FestivalType
	{
		@NOSELECTION = -1,
		@BeerFestival = 0,
		@HarvestFestival = 1,
		@ArtsFestival = 2,
		@Commemoration = 3,
		@Carnival = 4,
		@AnarchyFest = 5,
		@SpiritualFestivalAfrica = 6,
		@HarvestFestivalAfrica = 7,
		@TradeFestivalAfrica = 8,
		@QueenParade = 9
	}
	
	public enum FloorType
	{
		@NOSELECTION = -1,
		@BigFloor = 0,
		@MediumFloor = 1,
		@TinyFloor = 2
	}
	
	public enum GameCameraControl
	{
		@NOSELECTION = -1,
		@Free = 0,
		@Anno = 1
	}
	
	public enum GameObjectState
	{
		@NOSELECTION = -1,
		@GameLogic = 0,
		@Blueprint = 1,
		@Visible = 2
	}
	
	public enum HappinessCategory
	{
		@NOSELECTION = -1,
		@WorkingConditions = 0,
		@Pollution = 1,
		@Needs = 2,
		@War = 3,
		@Newspaper = 4,
		@Hotspots = 5,
		@Attractiveness = 6
	}
	
	public enum HappinessProductCategory
	{
		@NOSELECTION = -1,
		@Needs = 0,
		@Hotspots = 1
	}
	
	public enum HappinessState
	{
		@NOSELECTION = -1,
		@Angry = 0,
		@Unhappy = 1,
		@Neutral = 2,
		@Happy = 3,
		@Euphoric = 4
	}
	
	public enum IncidentCommunication
	{
		@NOSELECTION = -1,
		@FireDefault = 0,
		@FireIndustry = 1,
		@FireBombardment = 2,
		@FireExplosion = 3,
		@FireShipped = 4,
		@FireFromMob = 5,
		@FireCheat = 6,
		@RiotDefault = 7,
		@RiotIndustry = 8,
		@RiotCheat = 9,
		@IllnessDefault = 10,
		@IllnessIndustry = 11,
		@IllnessCheat = 12,
		@IllnessShipped = 13,
		@ExplosionDefault = 14,
		@ExplosionIndustry = 15,
		@ExplosionFromMob = 16,
		@ExplosionCheat = 17,
		@ExplosionFromDamage = 18,
		@AnarchyFire = 19,
		@AnarchyRiot = 20,
		@AnarchyExplosion = 21,
		@IllnessArcticDefault = 22,
		@IllnessArcticCheat = 23
	}
	
	public enum IncidentGraphicEffect
	{
		@NOSELECTION = -1,
		@Vertical = 0,
		@Horizontal = 1,
		@General = 2
	}
	
	public enum IncidentInfectionChanceSources
	{
		@NOSELECTION = -1,
		@Base = 0,
		@Damage = 1,
		@Density = 2,
		@HappinessResidence = 3,
		@Satisfaction = 4,
		@WorkingConditionFactory = 5,
		@Productivity = 6,
		@Proximity = 7,
		@HappinessFactory = 8,
		@Newspaper = 9,
		@Upgrades = 10,
		@InfluencerPositive = 11,
		@InfluencerNegative = 12,
		@WorkingConditionResidence = 13,
		@Heat = 14
	}
	
	public enum IncidentInfluenceDecreaseType
	{
		@NOSELECTION = -1,
		@NoDecrease = 0,
		@LinearDecrease = 1,
		@QuadraticDecrease = 2
	}
	
	public enum IncidentType
	{
		@NOSELECTION = -1,
		@Fire = 0,
		@Riot = 1,
		@Illness = 2,
		@Explosion = 3,
		@ArcticIllness = 4
	}
	
	public enum InfluenceCategory
	{
		@NOSELECTION = -1,
		@Propaganda = 0,
		@Trade = 1,
		@Military = 2,
		@Optimisation = 3,
		@Culture = 4,
		@Expansion = 5
	}
	
	public enum InfluenceSource
	{
		@NOSELECTION = -1,
		@Base = 0,
		@CompanyLevel = 1,
		@Investors = 2,
		@Engineers = 3,
		@Culture = 4,
		@Undefined = 5
	}
	
	public enum InfluenceUsage
	{
		@NOSELECTION = -1,
		@None = 0,
		@GuildHouse = 1,
		@Townhall = 2,
		@HarborOffice = 3,
		@WarShip = 4,
		@DefenseBuilding = 5,
		@TradeShip = 6,
		@Propaganda = 7,
		@ZooModule = 8,
		@MuseumModule = 9,
		@Kontor = 10,
		@WorkforceTransfer = 11,
		@CharterRoutes = 12,
		@Shares = 13,
		@BotanicModule = 14,
		@AirShip = 15
	}
	
	public enum KontorFilter
	{
		@NOSELECTION = -1,
		@None = 0,
		@Session = 1
	}
	
	public enum KontorType
	{
		@NOSELECTION = -1,
		@Main = 0,
		@Imperial = 1,
		@Cliff = 2
	}
	
	public enum LockScope
	{
		@NOSELECTION = -1,
		@Account = 0,
		@MetaGame = 1,
		@Participant = 2
	}
	
	public enum MeshDecalMode
	{
		@NOSELECTION = -1,
		@Disabled = 0,
		@CorporationLogoFromPlayer = 1
	}
	
	public enum MeshPlacement
	{
		@NOSELECTION = -1,
		@Default = 0,
		@OnTerrain = 1,
		@OnTerrainPhysics = 2,
		@OnTerrainSlope = 3,
		@OnWater = 4,
		@OnWaterSlope = 5
	}
	
	public enum ModuleType
	{
		@NOSELECTION = -1,
		@Main = 0,
		@Pavilion = 1,
		@Connector = 2,
		@Palace = 3,
		@AdditionalModule = 4,
		@DocklandModuleStorage = 5,
		@DocklandModuleItem = 6,
		@DocklandModulePier = 7,
		@DocklandModuleExport = 8,
		@DocklandModuleRepair = 9,
		@DocklandModuleSpeed = 10
	}
	
	public enum MonumentConstructionState
	{
		@NOSELECTION = -1,
		@Interrupted = 0,
		@OutOfWorkforce = 1,
		@WaitingForResources = 2,
		@Processing = 3,
		@WaitingForOrders = 4,
		@Completed = 5
	}
	
	public enum MonumentConstructionUpdate
	{
		@NOSELECTION = -1,
		@MonumentPhaseStarted = 0,
		@MonumentPhaseFinished = 1,
		@MonumentFinished = 2
	}
	
	public enum NonCriticalErrorType
	{
		@NOSELECTION = -1,
		@CorporationIdentifierInvalid = 0,
		@CorporationNotFound = 1,
		@CorporationBankrupt = 2
	}
	
	public enum ObjectSpawnerContextType
	{
		@NOSELECTION = -1,
		@Random = 0,
		@ClientKontor = 1,
		@ClientObject = 2,
		@PlayerKontor = 3,
		@Object = 4,
		@Area = 5,
		@ForceContextPosition = 6
	}
	
	public enum PopulationLevel
	{
		@NOSELECTION = -1,
		@Level1 = 0,
		@Level2 = 1,
		@Level3 = 2,
		@Level4 = 3,
		@Level5 = 4,
		@LevelScholar = 5,
		@LevelTourist = 6
	}
	
	public enum ProgressLevel
	{
		@NOSELECTION = -1,
		@EarlyGame = 0,
		@EarlyMidGame = 1,
		@MidGame = 2,
		@LateMidGame = 3,
		@LateGame = 4,
		@EndGame = 5
	}
	
	public enum ProjectileType
	{
		@NOSELECTION = -1,
		@HomingStraight = 0,
		@HomingArc = 1,
		@HomingMissle = 2,
		@Arc = 3
	}
	
	public enum QualityLevelClipping
	{
		@NOSELECTION = -1,
		@Low = 0,
		@Medium = 1,
		@High = 2,
		@VeryHigh = 3,
		@UltraHigh = 4
	}
	
	public enum RangeOperator
	{
		@NOSELECTION = -1,
		@None = 0,
		@Any = 1,
		@All = 2
	}
	
	public enum Region
	{
		@NOSELECTION = -1,
		@Meta = 0,
		@Moderate = 1,
		@Colony01 = 2,
		@Arctic = 3,
		@Africa = 4
	}
	
	public enum RenderCondition
	{
		@NOSELECTION = -1,
		@ColorTransform = 0,
		@PhysicsTransform = 1,
		@DestructionTransform = 2,
		@Selected = 3,
		@Unselected = 4,
		@Common01 = 5,
		@Common02 = 6,
		@Common03 = 7,
		@Common04 = 8,
		@Common05 = 9,
		@Common06 = 10,
		@Common07 = 11,
		@Common08 = 12,
		@Common09 = 13,
		@Common10 = 14,
		@Common11 = 15,
		@SkyDay = 16,
		@EffectShield = 17,
		@EffectRepair = 18,
		@EffectStun = 19,
		@EffectBurn = 20,
		@ShowWarningLights = 21,
		@Riot = 22,
		@RiotSpecial01 = 23,
		@NoInhabitants = 24,
		@Ruin = 25,
		@Irrigated = 26,
		@GroundDecalDefault = 27,
		@GroundDecalVariation = 28
	}
	
	public enum Rotation90
	{
		@NOSELECTION = -1,
		@_0 = 0,
		@_90 = 1,
		@_180 = 2,
		@_270 = 3
	}
	
	public enum ScanDirection
	{
		@NOSELECTION = -1,
		@Clockwise = 0,
		@CounterClockwise = 1,
		@Random = 2
	}
	
	public enum SelectionColor
	{
		@NOSELECTION = -1,
		@DefaultSelectionColor = 0,
		@ParticipantColor = 1,
		@PropertySelectionColor = 2,
		@NoColor = 3
	}
	
	public enum SequenceType
	{
		@NOSELECTION = -1,
		@default = 0,
		@idle01 = 1,
		@idle02 = 2,
		@idle03 = 3,
		@idle04 = 4,
		@idle05 = 5,
		@death01 = 6,
		@talk01 = 7,
		@talk02 = 8,
		@greet01 = 9,
		@bow01 = 10,
		@cheer01 = 11,
		@cheer02 = 12,
		@cheer03 = 13,
		@lookat01 = 14,
		@lookat02 = 15,
		@protest01 = 16,
		@protest02 = 17,
		@protest03 = 18,
		@protest04 = 19,
		@protest05 = 20,
		@protest06 = 21,
		@laydown01 = 22,
		@laydown02 = 23,
		@laydown03 = 24,
		@fishing01 = 25,
		@fishing02 = 26,
		@fishing03 = 27,
		@dance01 = 28,
		@dance02 = 29,
		@dance03 = 30,
		@dance04 = 31,
		@fight01 = 32,
		@fight02 = 33,
		@fight03 = 34,
		@fight04 = 35,
		@fight05 = 36,
		@walk01 = 37,
		@walk02 = 38,
		@walk03 = 39,
		@walk04 = 40,
		@walk05 = 41,
		@walk06 = 42,
		@walk07 = 43,
		@drunkenwalk01 = 44,
		@drunkenwalk02 = 45,
		@run01 = 46,
		@panicrun01 = 47,
		@panicrun02 = 48,
		@riotspecial01 = 49,
		@riotspecial02 = 50,
		@riotspecial03 = 51,
		@donate01 = 52,
		@buy01 = 53,
		@buy02 = 54,
		@work01 = 55,
		@work02 = 56,
		@work03 = 57,
		@work04 = 58,
		@work05 = 59,
		@work06 = 60,
		@work07 = 61,
		@work08 = 62,
		@work09 = 63,
		@work10 = 64,
		@work11 = 65,
		@work12 = 66,
		@work13 = 67,
		@work14 = 68,
		@work15 = 69,
		@work16 = 70,
		@work17 = 71,
		@work18 = 72,
		@work19 = 73,
		@stand01 = 74,
		@build01 = 75,
		@extFire01 = 76,
		@extFire02 = 77,
		@extFire03 = 78,
		@pray01 = 79,
		@protestwalk01 = 80,
		@protestwalk02 = 81,
		@protestwalk03 = 82,
		@takeoff01 = 83,
		@land01 = 84,
		@portrait_neutral_idle = 85,
		@portrait_neutral_talk = 86,
		@portrait_friendly_idle = 87,
		@portrait_friendly_talk = 88,
		@portrait_angry_idle = 89,
		@portrait_angry_talk = 90,
		@portrait_neutral_talk_idle = 91,
		@portrait_friendly_talk_idle = 92,
		@portrait_angry_talk_idle = 93,
		@work_staged01 = 94,
		@work_staged02 = 95,
		@work_staged03 = 96,
		@boosted = 97,
		@sitdown01 = 98,
		@sitdown02 = 99,
		@sitdown03 = 100,
		@explode01 = 101,
		@explode02 = 102,
		@explode03 = 103,
		@explode04 = 104,
		@idleLoaded01 = 105,
		@walkingLoaded01 = 106,
		@hitwood = 107,
		@hitbrick = 108,
		@hitsteel = 109,
		@hitconcrete = 110,
		@misswater = 111,
		@missland = 112
	}
	
	public enum SessionDirection
	{
		@NOSELECTION = -1,
		@NorthEast = 0,
		@SouthEast = 1,
		@SouthWest = 2,
		@NorthWest = 3
	}
	
	public enum SessionObjectFilter
	{
		@NOSELECTION = -1,
		@Easy = 0,
		@Medium = 1,
		@Hard = 2
	}
	
	public enum ShipFilter
	{
		@NOSELECTION = -1,
		@None = 0,
		@Available = 1,
		@Idle = 2,
		@Session = 3
	}
	
	public enum SimpleEventType
	{
		@NOSELECTION = -1,
		@CriticalError = 0,
		@NonCriticalError = 1,
		@OnetimeCallback = 2,
		@ComponentReload = 3,
		@SystemLoaded = 4,
		@ProfileLoaded = 5,
		@DataUnload = 6,
		@DataReload = 7,
		@SessionLoad = 8,
		@SessionLoaded = 9,
		@MetaGameLoaded = 10,
		@SessionUnloaded = 11,
		@MetaGameUnloaded = 12,
		@SessionEnter = 13,
		@SessionLeave = 14,
		@AccountAssetCreated = 15,
		@AccountAssetRemoved = 16,
		@AccountAssetWatcherDone = 17,
		@CorporationAssetCreated = 18,
		@CorporationAssetRemoved = 19,
		@CorporationAssetWatcherDone = 20,
		@CorporationLevelUp = 21,
		@QuestStarted = 22,
		@QuestResolved = 23,
		@QuestSuccessfullyResolved = 24,
		@QuestStateChanged = 25,
		@QuestObjectCollected = 26,
		@QuestTargetReached = 27,
		@QuestConfirmationAccepted = 28,
		@ObjectSelected = 29,
		@ObjectBuilt = 30,
		@ObjectDestroyed = 31,
		@ObjectGUIDChanged = 32,
		@GUIDUnlocked = 33,
		@GUIAction = 34,
		@ShowSubtitle = 35,
		@CameraSequenceEnd = 36,
		@CameraSequenceMetaStart = 37,
		@CameraSequenceMetaPause = 38,
		@CameraSequenceMetaEnd = 39,
		@ChangeSelection = 40,
		@InteractionStarted = 41,
		@InteractionCompleted = 42,
		@ObjectAttached = 43,
		@ObjectDropped = 44,
		@UbiservicesNewsReceived = 45,
		@ParticipantMessage = 46,
		@MetaParticipantCreated = 47,
		@SessionParticipantCreated = 48,
		@ResolverUnitAvailable = 49,
		@IncidentSpreaded = 50,
		@NotificationTriggered = 51,
		@NotificationRemoved = 52,
		@ModuleAdded = 53,
		@ModuleRemoved = 54,
		@EnterUIState = 55,
		@LeaveUIState = 56,
		@CloseUIState = 57,
		@DragOperationInProgress = 58,
		@ItemEquipmentChanged = 59,
		@NewspaperEditNotificationClicked = 60,
		@NewspaperAddArticle = 61,
		@NewspaperMinIntervalEnded = 62,
		@NewspaperIntervalEnded = 63,
		@NewspaperIntervalStarted = 64,
		@NewspaperPublished = 65,
		@MPSessionEvent = 66,
		@MPPeerEvent = 67,
		@MPDeSyncDetected = 68,
		@IslandSettled = 69,
		@IslandUnsettled = 70,
		@GameObjectSold = 71,
		@ExpeditionStatusChanged = 72,
		@DiplomaticRelationChanged = 73,
		@RuinStateEntered = 74,
		@IniFileChanged = 75,
		@IncidentStarted = 76,
		@IncidentEscalated = 77,
		@IncidentResolved = 78,
		@IncidentSpecialActionTriggered = 79,
		@TutorialSystemStateChanged = 80,
		@GameEnded = 81,
		@IncidentHealingUnitSent = 82,
		@TradeRouteCreated = 83,
		@MonumentEventActive = 84,
		@MonumentEventEnded = 85,
		@OnlineStateChanged = 86,
		@MonumentConstructionUpdate = 87,
		@TransferChanged = 88,
		@MPTransmissionEvent = 89,
		@MovieFinished = 90,
		@UplayActionUnlocked = 91,
		@UplayRewardUnlocked = 92,
		@NotificationSideArchiveAdded = 93,
		@NotificationSideArchiveRemoved = 94,
		@NotificationOnScreenAdded = 95,
		@ScreenshotTaken = 96,
		@NotificationOnScreenRemoved = 97,
		@FightChanged = 98,
		@ItemActionCompleted = 99,
		@ShortcutChanged = 100,
		@GraphicAdapterChanged = 101,
		@WorldMapClick = 102,
		@AssetFileChanged = 103,
		@PirateResettled = 104,
		@ShareTraded = 105,
		@HostileTakeoverCompleted = 106,
		@IslandWarStarted = 107,
		@IslandWarEnded = 108,
		@IslandWarMoraleChanged = 109,
		@CameraControlSwitched = 110,
		@RuinStateEnded = 111,
		@BlueprintStateChanged = 112,
		@WindowSizeChanged = 113,
		@IncidentInfected = 114,
		@MetaParticipantRemoved = 115,
		@SessionParticipantRemoved = 116,
		@TradeRouteAdded = 117,
		@UbiservicesRewardsReceived = 118,
		@UbiservicesActionsReceived = 119,
		@GUIDLocked = 120,
		@UbiservicesBadgesReceived = 121,
		@IslandDiscovered = 122,
		@OptionsSaved = 123,
		@BuildingDecorationAdded = 124,
		@BuildingDecorationRemoved = 125,
		@DivingBellUsed = 126,
		@DiscoveryEvent = 127,
		@MPTransmissionSenderEvent = 128,
		@ModuleAdditionalAdded = 129,
		@ModuleAdditionalRemoved = 130,
		@MonumentEventPreparationStarted = 131,
		@MonumentEventRewardCollected = 132,
		@FutureIrrigationChanged = 133,
		@ResearchCenterCraftingFinished = 134,
		@ResearchCenterCraftingStarted = 135
	}
	
	public enum SlotType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Random = 1,
		@Coast = 2,
		@WorkAreaMountain = 3,
		@River = 4,
		@AreaConnector = 5,
		@DistributionCenter = 6,
		@Coal = 7,
		@Iron = 8,
		@Clay = 9,
		@Tin = 10,
		@Copper = 11,
		@Cement = 12,
		@Unused = 13,
		@GoldOre = 14,
		@WorkAreaCave = 15,
		@Oil = 16,
		@Gas = 17
	}
	
	public enum SpawnArea
	{
		@NOSELECTION = -1,
		@ConstructionArea = 0,
		@Water = 1,
		@Water_01 = 2,
		@Water_02 = 3,
		@Underwater_01 = 4,
		@Underwater_02 = 5,
		@Land_01 = 6,
		@Land_02 = 7,
		@Land_03 = 8,
		@Land_04 = 9,
		@Mountain_01 = 10,
		@Mountain_02 = 11,
		@Campaign_01 = 12,
		@Campaign_02 = 13,
		@Campaign_03 = 14,
		@Campaign_04 = 15,
		@Campaign_05 = 16
	}
	
	public enum StreetUpgrading
	{
		@NOSELECTION = -1,
		@Default = 0,
		@BadStreet = 1,
		@GoodStreet = 2,
		@Rail = 3,
		@Railcrossing = 4,
		@IrrigationPipe = 5,
		@IrrigationPipeStreetCrossing = 6,
		@Harbour = 7,
		@Visual = 8,
		@QuayStreet = 9
	}
	
	public enum SubRegion
	{
		@NOSELECTION = -1,
		@PrimaryRegion = 0,
		@SecondaryRegion = 1
	}
	
	public enum TrackingProgressionEventType
	{
		@NOSELECTION = -1,
		@QUEST_MILESTONES = 0,
		@CORPORATION_LEVEL = 1,
		@POPULATION_LEVEL = 2
	}
	
	public enum TradeRouteError
	{
		@NOSELECTION = -1,
		@NotEnoughSlots = 0,
		@NotEnoughStations = 1,
		@IslandUnderSiege = 2,
		@NoValidPier = 3,
		@NoTradeRights = 4,
		@ConfiguredGoodNotTraded = 5,
		@LoadedGoodNeverUnloaded = 6,
		@UnloadedGoodNeverLoaded = 7,
		@GoodsDontMatch = 8,
		@StorageFull = 9,
		@StorageEmpty = 10,
		@NoGoods = 11,
		@NoShips = 12,
		@AllShipsPaused = 13,
		@LongWaitingTime = 14,
		@MismatchingGood = 15
	}
	
	public enum TradeRouteTransportationType
	{
		@NOSELECTION = -1,
		@Normal = 0,
		@Charter = 1,
		@Oil = 2
	}
	
	public enum TradeRouteWarningType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Notification = 1,
		@Warning = 2
	}
	
	public enum TraderShipProductionQueue
	{
		@NOSELECTION = -1,
		@War = 0,
		@Trade = 1,
		@Sell = 2
	}
	
	public enum TradeType
	{
		@NOSELECTION = -1,
		@ActiveTrade = 0,
		@PassiveTrade = 1
	}
	
	public enum UplayProductPromotionType
	{
		@NOSELECTION = -1,
		@SeasonPassDLC = 0,
		@Season2PassDLC = 1,
		@DigitalMission = 2,
		@OrnamentalPack = 3,
		@Season3PassDLC = 4
	}
	
	public enum UplayProductType
	{
		@NOSELECTION = -1,
		@LanguagePack = 0,
		@FreeUpdate = 1,
		@DLC = 2,
		@PreOrderBonus = 3,
		@CompanyLogos = 4,
		@SeasonPass = 5,
		@TwitchDrop = 6,
		@OrnamentalPack = 7
	}
	
	public enum VariableModifyOperator
	{
		@NOSELECTION = -1,
		@Set = 0,
		@Add = 1,
		@Multiply = 2,
		@Divide = 3
	}
	
	public enum Variables
	{
		@NOSELECTION = -1,
		@Mercier_ARQTriggerChance = 0,
		@Mercier_ARQDelayTimer = 1,
		@Mercier_ARQQuestTypeChance = 2,
		@Mercier_PropagandaQuestChance = 3,
		@Mercier_DeserterDelayTimer = 4,
		@AnarchyFestivalWeight = 5,
		@Mercier_DeserterReactionNotiChance = 6
	}
	
	public enum VariableValueType
	{
		@NOSELECTION = -1,
		@Value = 0,
		@Range = 1
	}
	
	public enum VegetationType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Tree = 1
	}
	
	public enum VersionType
	{
		@NOSELECTION = -1,
		@main = 0,
		@dm = 1,
		@dlc01 = 2,
		@dlc02 = 3,
		@dlc03 = 4,
		@dlc04 = 5,
		@dlc05 = 6,
		@dlc06 = 7,
		@dlc07 = 8,
		@dlc08 = 9,
		@dlc09 = 10,
		@cdlc01 = 11,
		@cdlc02 = 12,
		@cdlc03 = 13,
		@dlc10 = 14,
		@dlc11 = 15,
		@dlc12 = 16,
		@test = 17
	}
	
	public enum WeatherEffectType
	{
		@NOSELECTION = -1,
		@Snow = 0,
		@Rain = 1,
		@SnowRain = 2
	}
	
	public enum WeatherPreset
	{
		@NOSELECTION = -1,
		@Default = 0,
		@Storm = 1,
		@Apocalyptic = 2,
		@ChristmasModerate_ForceAllowSnow = 3,
		@FirstPersonNonsense_Rain = 4,
		@FirstPersonNonsense_Snow = 5
	}
	
	public enum WinLoseState
	{
		@NOSELECTION = -1,
		@Win = 0,
		@Lose = 1,
		@Defeat = 2
	}
	
	public enum EditingStatus
	{
		@NOSELECTION = -1,
		@New = 0,
		@Edit = 1,
		@GameWriting = 2,
		@Localization = 3,
		@Exported = 4,
		@ToBeDeleted = 5
	}
	
	public enum EditLanguage
	{
		@NOSELECTION = -1,
		@English = 0
	}
	
	public enum Language
	{
		@NOSELECTION = -1,
		@English = 0,
		@French = 1,
		@Polish = 2,
		@Russian = 3,
		@Spanish = 4,
		@German = 5,
		@Chinese = 6,
		@Taiwanese = 7,
		@Japanese = 8,
		@Korean = 9,
		@Italian = 10
	}
	
	public enum ValueOperation
	{
		@NOSELECTION = -1,
		@Reset = 0,
		@ClearVector = 1,
		@AddVectorItem = 2,
		@RemoveVectorItem = 3,
		@OpenFile = 4,
		@MoveUp = 5,
		@MoveDown = 6
	}
	
	public enum ActionID
	{
		@NOSELECTION = -1,
		@NOACTION = 0,
		@WALK = 1,
		@SELECT = 2,
		@DELETE = 3,
		@CHANNEL = 4,
		@PIPETTE = 5,
		@MOVE = 6,
		@COLLECT = 7,
		@ATTACK = 8,
		@COLLECT_ON_CLICK = 9,
		@DROP = 10,
		@FOLLOW = 11,
		@NUKE = 12,
		@REPAIR = 13,
		@SUPPORT = 14,
		@SHIELD = 15,
		@UPGRADE = 16,
		@INTERACT = 17,
		@STUN = 18,
		@PUSH = 19,
		@DRAG = 20,
		@SELECT_OR_MOVE = 21,
		@ITEM = 22,
		@SET_RALLY_POINT = 23,
		@START_PATROL = 24,
		@ADD_PATROL = 25,
		@BUFF_OTHER = 26,
		@HEAL_INCIDENT = 27,
		@KAMIKAZE = 28,
		@CANNOT_COLLECT = 29,
		@PLACE_MINE = 30,
		@SONARPING = 31,
		@COOP_PING = 32,
		@DOWNGRADE = 33
	}
	
	public enum Matchflag
	{
		@NOSELECTION = -1,
		@AndNextMatch = 0,
		@OrNextMatch = 1,
		@AndNotNextMatch = 2,
		@OrNotNextMatch = 3,
		@OwnedByPlayer = 4,
		@CheckProperty = 5,
		@CheckNotProperty = 6,
		@CheckGUID = 7,
		@CheckNotGUID = 8,
		@CheckObjectType = 9,
		@NotSelf = 10,
		@SingleSelection = 11,
		@Never = 12,
		@Destructable = 13,
		@Movable = 14,
		@Buildable = 15,
		@Upgradable = 16,
		@OwnedByEnemy = 17,
		@CollectableOnSelection = 18,
		@IsCollectable = 19,
		@IsDroppableCollectable = 20,
		@IsDroppableDraggable = 21,
		@IsCollectableBySelection = 22,
		@NotSelfIgnoreMultiselection = 23,
		@IsInteractable = 24,
		@IsDraggedBySelection = 25,
		@IsDraggableBySelection = 26,
		@Damaged = 27,
		@NotActionBlocked = 28,
		@Guardable = 29,
		@Attackable = 30,
		@IsInfectedByFire = 31,
		@IsInfectedByIllness = 32,
		@IsInfectedByRiot = 33,
		@IsCoastalBuilding = 34,
		@OwnedByPirate = 35,
		@IsOnPlayerArea = 36,
		@Downgradable = 37
	}
	
	public enum MatchType
	{
		@NOSELECTION = -1,
		@SelectionMatch1 = 0,
		@SelectionMatch2 = 1,
		@SelectionMatch3 = 2,
		@TargetMatch1 = 3,
		@TargetMatch2 = 4,
		@TargetMatch3 = 5,
		@DisableMatch1 = 6,
		@DisableMatch2 = 7,
		@DisableMatch3 = 8
	}
	
	public enum PositionCheck
	{
		@NOSELECTION = -1,
		@Never = 0,
		@Always = 1,
		@Land = 2,
		@Water = 3,
		@ClaimableArea = 4,
		@DeletableStreet = 5,
		@CloneableStreet = 6
	}
	
	public enum AttractivityType
	{
		@NOSELECTION = -1,
		@Culture = 0,
		@Monument = 1,
		@Ornament = 2,
		@Factory = 3,
		@Incident = 4,
		@War = 5,
		@Ruins = 6,
		@Nature = 7,
		@Military = 8,
		@MonumentEvent = 9,
		@NatureBonus = 10,
		@DisasterTourism = 11,
		@FestivalIncident = 12,
		@Landscaping = 13,
		@Cyclideon = 14,
		@Cheat = 15,
		@Palace = 16,
		@ParkBonus = 17,
		@Dockland = 18,
		@Ornament_XMasDeco = 19,
		@Ornament_AmusementPark = 20,
		@Ornament_CityLights = 21
	}
	
	public enum BuildModeGridCategory
	{
		@NOSELECTION = -1,
		@FreeAreaProductivity = 0,
		@Default = 1,
		@Module_Radius = 2,
		@Module_IrrigationNeeder = 3,
		@ModuleOwner_Radius = 4,
		@ModuleOwner_IrrigationNeeder = 5,
		@Canal = 6,
		@SelectedBuilding = 7
	}
	
	public enum BuildModeGridTileCategory
	{
		@NOSELECTION = -1,
		@Blocked_Invisible = 0,
		@Default = 1,
		@Irrigated_Land = 2,
		@Irrigated_Land_Prediction = 3,
		@Irrigated_Land_Future = 4,
		@Irrigated_Pipe = 5,
		@Irrigated_Pipe_Prediction = 6,
		@Irrigated_Pipe_Future = 7,
		@IrrigationMissing = 8,
		@FreeAreaUsed = 9,
		@FreeAreaUsed_Irrigated = 10,
		@FreeAreaUsed_IrrigationMissing = 11
	}
	
	public enum ButtonState
	{
		@NOSELECTION = -1,
		@Normal = 0,
		@Disabled = 1,
		@Hidden = 2
	}
	
	public enum CategoryButtonIcon
	{
		@NOSELECTION = -1,
		@None = 0,
		@Background = 1,
		@Timer = 2
	}
	
	public enum ConstructionMenuCategoryMode
	{
		@NOSELECTION = -1,
		@Tier = 0,
		@BuildingCategory = 1
	}
	
	public enum ConstructionMode
	{
		@NOSELECTION = -1,
		@Default = 0,
		@Street = 1,
		@Move = 2,
		@Railway = 3,
		@ConstructionItem = 4,
		@Tree = 5
	}
	
	public enum CorporationScoreRewardType
	{
		@NOSELECTION = -1,
		@Material0 = 0,
		@Material1 = 1,
		@Material2 = 2,
		@Material3 = 3,
		@Material4 = 4,
		@TransportationVehicle0 = 5,
		@FleetVehicle = 6,
		@Title = 7,
		@RouteLimit = 8,
		@StorageCap = 9,
		@TransportationVehicle1 = 10
	}
	
	public enum DestructionType
	{
		@NOSELECTION = -1,
		@StreetsAndBridges = 0,
		@Production = 1,
		@Residents = 2,
		@Public = 3,
		@Logistic = 4,
		@Other = 5,
		@Palace = 6
	}
	
	public enum DragType
	{
		@NOSELECTION = -1,
		@ConstructionMenuButton = 0,
		@ItemSocket = 1,
		@CargoProductStack = 2,
		@CargoItemStack = 3,
		@StorageProductStack = 4,
		@StorageItemStack = 5,
		@ActiveTradeBuy = 6,
		@ActiveTradeSell = 7
	}
	
	public enum EconomyStatsCategory
	{
		@NOSELECTION = -1,
		@Production = 0,
		@Warehouse = 1,
		@Income = 2,
		@Population = 3,
		@Item = 4
	}
	
	public enum EnbesaTextPopupContext
	{
		@NOSELECTION = -1,
		@None = 0,
		@Chronicles1 = 1,
		@Chronicles2 = 2,
		@Chronicles3 = 3,
		@Chronicles4 = 4
	}
	
	public enum FixDaytimeValues
	{
		@NOSELECTION = -1,
		@Value1 = 0,
		@Value2 = 1,
		@Value3 = 2,
		@Value4 = 3
	}
	
	public enum GenericPopup
	{
		@NOSELECTION = -1,
		@Quit = 0,
		@DestroyItem = 1,
		@NotImplemented = 2,
		@DiscardExpedition = 3,
		@ForceTakeoverIsland = 4,
		@CancelMonumentEvent = 5,
		@DestroyConfirmation = 6,
		@ShipDestroyConfirmation = 7,
		@IslandDestroyConfirmation = 8,
		@DeleteSavegame = 9,
		@CampaignReadLetter = 10,
		@SendToSessionSingle = 11,
		@SendToSessionMulti = 12,
		@OverrideShortcut = 13,
		@AutoSave = 14,
		@UnloadCorporation = 15,
		@ResetExpeditionPreparation = 16,
		@MultiplayerGenericError = 17,
		@TutorialHappiness = 18,
		@RemoveTradeRoute = 19,
		@UplayInviteFailed = 20,
		@UplayError = 21,
		@UplayConnectionError = 22,
		@PlayerLeft = 23,
		@ConnectToLobby = 24,
		@InviteReceived = 25,
		@GameVersionMismatch = 26,
		@NATError = 27,
		@Kicked = 28,
		@FileNotFound = 29,
		@FileLoadedSuccessfully = 30,
		@RestartRequired = 31,
		@ConfirmOptions = 32,
		@SettingsSaved = 33,
		@ResetCustomDifficulty = 34,
		@PlayerDisconnected = 35,
		@ConnectionLost = 36,
		@LeaveLobbyToTitle = 37,
		@LeaveLobbyToLastScene = 38,
		@LoadGameAndLeaveMatch = 39,
		@FailedToLoadSavegame = 40,
		@DLCBreadcrumbsNote = 41,
		@UpgradeSavegame = 42,
		@HostLeftLobby = 43,
		@UpgradeSavegameMP = 44,
		@ContinentalIslandDestroyConfirmation = 45,
		@LobbyFull = 46,
		@LobbyFull_Mercier = 47,
		@GameAlreadyStarted = 48,
		@InviteTimedOut = 49,
		@MPSingleGameStart = 50,
		@IslandDestroyCampaignWarning = 51,
		@SessionStorytellingSpear = 52,
		@MoveConfirmation = 53,
		@DontMissStoryQuest = 54,
		@NewShortcuts = 55,
		@UnificationPrompt = 56,
		@FatalError = 57,
		@ConfirmIslandDestroyArctic = 58,
		@ForceAlternativeGrassColor = 59
	}
	
	public enum GUIColors
	{
		@NOSELECTION = -1,
		@OrangeHighlight = 0,
		@Red = 1,
		@Green = 2,
		@GreenLight1 = 3,
		@GreenLight2 = 4,
		@GreyBase = 5,
		@GreyLight1 = 6,
		@GreyLight2 = 7,
		@GreyLight3 = 8,
		@GreyLight4 = 9,
		@GreyLight5 = 10,
		@GreyDark1 = 11,
		@GreyDark2 = 12,
		@GreyDark3 = 13,
		@TorquoiseComplementaryOverlay = 14,
		@TorquoiseComplementaryLight1 = 15,
		@TorquoiseComplementaryLight3 = 16,
		@TorquoiseComplementaryLight4 = 17,
		@TorquoiseComplementaryLight5 = 18,
		@TorquoiseComplementaryLight6 = 19,
		@TorquoiseComplementaryDark1 = 20,
		@TorquoiseComplementaryDark2 = 21,
		@RedDark1 = 22,
		@MagentaTint = 23,
		@OrangeHighlightLight1 = 24,
		@OrangeHighlightDark1 = 25,
		@OrangeHighlightDark2 = 26,
		@TorquoiseGreen = 27,
		@Violet = 28,
		@Yellow = 29,
		@BlueLight = 30,
		@White = 31,
		@None = 32,
		@TorquoiseIbarra = 33,
		@BlueLeiSheng = 34,
		@CorporationColorPlayer = 35,
		@CorporationColorIbarra = 36,
		@CorporationColorCassian = 37,
		@CorporationColorUsoyev = 38,
		@CorporationColorLeiSheng = 39,
		@CorporationColorSaayman = 40
	}
	
	public enum GUIState
	{
		@NOSELECTION = -1,
		@Video = 0,
		@Title = 1,
		@ProfileSelection = 2,
		@CharacterNotification = 3,
		@ExpeditionEvent = 4,
		@ExpeditionOverview = 5,
		@Diplomacy = 6,
		@SessionTradeRouteOverview = 7,
		@Newspaper = 8,
		@OnlineMarket = 9,
		@WorldMap = 10,
		@CameraSequence = 11,
		@PostcardView = 12,
		@ResidentView = 13,
		@RotatingCameraView = 14,
		@ActiveTrade = 15,
		@TextPopup = 16,
		@VisitorHarbor = 17,
		@Minimap = 18,
		@ObjectmenuResidence = 19,
		@ObjectmenuProduction = 20,
		@Attractiveness = 21,
		@ObjectmenuMonumentEvent = 22,
		@CampaignNewspaper = 23,
		@QuestBook = 24,
		@QuestTracker = 25,
		@ObjectmenuMausoleum = 26,
		@NewspaperSpecialEdition = 27,
		@ObjectmenuForeign = 28,
		@IslandBar = 29,
		@ObjectMenuKontor = 30,
		@ObjectmenuMonument = 31,
		@TreasureMap = 32,
		@ChatNotifications = 33,
		@ObjectMenuPalace = 34,
		@ObjectMenuDepartment = 35,
		@ObjectMenuPump = 36,
		@Research = 37,
		@ObjectMenuDockland = 38,
		@Docklands = 39,
		@Achievements = 40,
		@Monument = 41,
		@RecipeBuilding = 42
	}
	
	public enum GUIType
	{
		@NOSELECTION = -1,
		@Generic = 0,
		@Residence = 1,
		@Production = 2,
		@Monument = 3,
		@CityInstitution = 4,
		@PublicService = 5,
		@Culture = 6,
		@Module = 7,
		@Warehouse = 8,
		@VisitorHarbor = 9,
		@Quest = 10,
		@Vehicle = 11,
		@SlotGhost = 12,
		@Guildhouse = 13,
		@Kontor = 14,
		@Shipyard = 15,
		@Market = 16,
		@Specialist = 17,
		@Ornamental = 18,
		@Military = 19,
		@CoalOilHarbour = 20,
		@Blueprint = 21,
		@WorkforceConnector = 22,
		@CampaignMausoleum = 23,
		@MonumentEvent = 24,
		@TraderOldNate = 25,
		@AirshipHangar = 26,
		@Palace = 27,
		@Department = 28,
		@Pump = 29,
		@RiverSlot = 30,
		@ResearchCentre = 31,
		@Pier = 32,
		@Dockland = 33,
		@BusStop = 34
	}
	
	public enum HighscoreType
	{
		@NOSELECTION = -1,
		@GlobalCostsScore = 0,
		@GlobalProductionScore = 1,
		@GlobalStorageScore = 2,
		@TradeShipScore = 3,
		@MilitaryShipScore = 4,
		@AirshipScore = 5,
		@CompletedSetsScore = 6,
		@SocketedItemsScore = 7,
		@DiscoveredItemsScore = 8,
		@TotalAttractivenessScore = 9,
		@MostAttractiveIsland = 10
	}
	
	public enum HighscoreUISubCategory
	{
		@NOSELECTION = -1,
		@GlobalCostsCategory = 0,
		@GlobalProductionCategory = 1,
		@GlobalStorageCategory = 2,
		@FleetCategory = 3,
		@ItemCategory = 4,
		@AttractivenessCategory = 5
	}
	
	public enum KeyEventType
	{
		@NOSELECTION = -1,
		@OnUp = 0,
		@OnDown = 1
	}
	
	public enum MinimapFilters
	{
		@NOSELECTION = -1,
		@ImperialKontor = 0,
		@Kontor = 1,
		@Quest = 2,
		@Lodes = 3,
		@Ships = 4,
		@Mine = 5,
		@Treasure = 6,
		@WindDirection = 7,
		@Transparency = 8
	}
	
	public enum MouseCursorMode
	{
		@NOSELECTION = -1,
		@Gamepad = 0,
		@CameraSequence = 1,
		@CameraMode = 2,
		@GUISpecial = 3,
		@GUI = 4,
		@CameraControl = 5,
		@Game = 6
	}
	
	public enum NumberPresentation
	{
		@NOSELECTION = -1,
		@NoConversion = 0,
		@PerMinute = 1,
		@TonsPerMinute = 2
	}
	
	public enum ParticipantColors
	{
		@NOSELECTION = -1,
		@Color1 = 0,
		@Color2 = 1,
		@Color3 = 2,
		@Color4 = 3,
		@Color5 = 4,
		@Color6 = 5,
		@Color7 = 6,
		@Color8 = 7,
		@Color9 = 8,
		@Color10 = 9,
		@Color11 = 10,
		@Color12 = 11
	}
	
	public enum PassiveTradeType
	{
		@NOSELECTION = -1,
		@None = 0,
		@BuySell = 1,
		@SellOnly = 2,
		@BuyOnly = 3
	}
	
	public enum PortraitMenuType
	{
		@NOSELECTION = -1,
		@VideoLeft = 0,
		@VideoRight = 1,
		@Residence = 2,
		@CharacterNotification = 3,
		@DiplomacyLeft = 4,
		@DiplomacyRight = 5,
		@ExpeditionEvent = 6,
		@ExpeditionOverview = 7,
		@QuestBook = 8,
		@NewsPaper = 9,
		@CampaignNewsPaper = 10,
		@VisitorHarbor = 11,
		@Attractiveness = 12,
		@Kontor = 13,
		@CreateGame = 14,
		@MilitaryResultLeft = 15,
		@MilitaryResultRight = 16,
		@MonumentEvent = 17,
		@Lobby = 18,
		@QuickLobby = 19,
		@CommuterHarbour = 20,
		@Production = 21,
		@Trader = 22,
		@ProfileSelection = 23,
		@ProfileCreation = 24,
		@RewardChest = 25,
		@Mausoleum = 26,
		@ActiveTrade = 27,
		@Foreign = 28,
		@NewspaperSpecialEdition = 29,
		@IslandBar = 30,
		@Monument = 31,
		@Decision = 32,
		@ResearchCentre = 33,
		@Dockland = 34
	}
	
	public enum PortraitMood
	{
		@NOSELECTION = -1,
		@Angry = 0,
		@Normal = 1,
		@Happy = 2
	}
	
	public enum QuestBookCategory
	{
		@NOSELECTION = -1,
		@Main = 0,
		@LandOfLions = 1,
		@ThePassage = 2,
		@SunkenTreasure = 3,
		@Optional = 4
	}
	
	public enum QuestTrackerCategory
	{
		@NOSELECTION = -1,
		@Main = 0,
		@LandOfLions = 1,
		@ThePassage = 2,
		@SunkenTreasures = 3,
		@Optional = 4
	}
	
	public enum RecipeListType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Diner = 1,
		@Cafe = 2,
		@Bar = 3,
		@Factory = 4,
		@Forrest = 5,
		@AssemblyLine = 6,
		@LuxuryDiner = 7
	}
	
	public enum RightClickButtons
	{
		@NOSELECTION = -1,
		@Street = 0,
		@Residence = 1,
		@Building0 = 2,
		@Building1 = 3,
		@Move = 4,
		@Demolish = 5,
		@EyeDrop = 6,
		@Upgrade = 7,
		@Construct = 8
	}
	
	public enum ShipListCategories
	{
		@NOSELECTION = -1,
		@All = 0,
		@Idle = 1,
		@TradeRoute = 2,
		@Patrolling = 3,
		@Escorting = 4,
		@Transit = 5
	}
	
	public enum ShiplistConditions
	{
		@NOSELECTION = -1,
		@Moving = 0,
		@NotMoving = 1,
		@Escorting = 2,
		@InCombat = 3,
		@Expedition = 4,
		@Patrolling = 5,
		@Leaving = 6,
		@TradeRoute = 7
	}
	
	public enum ShortcutContext
	{
		@NOSELECTION = -1,
		@None = 0,
		@Menu = 1,
		@Session = 2,
		@WorldMap = 3,
		@VideoCameraSequence = 4,
		@TextInput = 5,
		@PostcardView = 6,
		@Pause = 7,
		@Pausemenu = 8,
		@Popup = 9,
		@Chat = 10
	}
	
	public enum SideNotificationArchiveButton
	{
		@NOSELECTION = -1,
		@Quest = 0,
		@Newspaper = 1,
		@Expedition = 2,
		@Event = 3,
		@General = 4,
		@Warning = 5
	}
	
	public enum StaticHelpType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Default = 1,
		@DocklandsExportContract = 2,
		@DocklandsExportContractPyramid = 3,
		@DocklandsExportContractQuality = 4,
		@DocklandsExportContractFullfillment = 5,
		@DocklandsExportModuleUnlock = 6,
		@TouristSeasonTourists = 7,
		@TouristSeasonHotels1 = 8,
		@TouristSeasonHotels2 = 9,
		@TouristSeasonBusses1 = 10,
		@TouristSeasonBusses2 = 11,
		@TouristSeasonVenues = 12,
		@TouristSeasonOrchards = 13,
		@TouristSeasonChemical = 14,
		@TouristSeasonRecipeBook = 15,
		@TouristSeasonIronTower = 16
	}
	
	public enum StatisticBuildingState
	{
		@NOSELECTION = -1,
		@Ruin = 0,
		@Pause = 1,
		@Incident = 2
	}
	
	public enum StatisticGraphTexture
	{
		@NOSELECTION = -1,
		@Line = 0,
		@Dots = 1,
		@RectBigger = 2,
		@RectLarge = 3,
		@RectSmall = 4
	}
	
	public enum StreetOverlayGradientType
	{
		@NOSELECTION = -1,
		@Blueprint = 0,
		@Regular = 1,
		@Selection = 2
	}
	
	public enum TextAlignment
	{
		@NOSELECTION = -1,
		@Left = 0,
		@Center = 1,
		@Right = 2
	}
	
	public enum TextBookCoverColor
	{
		@NOSELECTION = -1,
		@Black = 0,
		@LightBrown = 1,
		@DarkBrown = 2,
		@LightBlue = 3,
		@DarkBlue = 4,
		@Pink = 5,
		@Red = 6,
		@Maroon = 7,
		@Green = 8,
		@Turquoise = 9,
		@Yellow = 10,
		@Orange = 11,
		@Grey = 12
	}
	
	public enum TextBookPageType
	{
		@NOSELECTION = -1,
		@PageType1 = 0,
		@PageType2 = 1,
		@PageType3 = 2
	}
	
	public enum TextPopupLayout
	{
		@NOSELECTION = -1,
		@Letter = 0,
		@DiaryPage1 = 1,
		@DiaryPage2 = 2,
		@DiaryPage3 = 3,
		@LetterThreat = 4,
		@LetterQuest = 5,
		@NadaskyJournal1 = 6,
		@NadaskyJournal2 = 7,
		@NadaskyJournal3 = 8,
		@RichardsonLog = 9,
		@VascoContract = 10,
		@JohnsNotes1 = 11,
		@JohnsNotes2 = 12,
		@JohnsNotes3 = 13,
		@JohnsNotes4 = 14,
		@JohnsNotes5 = 15,
		@JohnsNotes6 = 16,
		@WidlifeWolfSketch = 17,
		@WidlifeMooseSketch = 18,
		@WidlifeBearSketch = 19,
		@JohnsLogbook = 20,
		@ResearchCenterAccepted = 21,
		@ResearchCenterRejected1 = 22,
		@ResearchCenterRejected2 = 23,
		@MilitaryLogs = 24,
		@EnbesanHistory1 = 25,
		@EnbesanHistory2 = 26,
		@EnbesanHistory3 = 27,
		@EnbesanHistory4 = 28,
		@EnbesanHistory5 = 29,
		@EnbesanHistory6 = 30,
		@EnbesanHistory7 = 31,
		@EnbesanHistory8 = 32,
		@EnbesanHistory9 = 33,
		@KiryasJournal1 = 34,
		@KiryasJournal2 = 35,
		@KiryasJournal3 = 36,
		@BeekeeperList = 37,
		@CartographyArch = 38,
		@CartographyGraveyard = 39,
		@CartographyPrideRock = 40,
		@CartographyWaterfall = 41,
		@TextBook = 42,
		@QueensLetter = 43,
		@RomanceLetter = 44
	}
	
	public enum TradeRouteOverviewAction
	{
		@NOSELECTION = -1,
		@RenameGroup = 0,
		@CreateGroup = 1,
		@DeleteGroup = 2,
		@DeleteTradeRoute = 3,
		@RemoveFromGroup = 4,
		@MoveToGroup = 5,
		@NoGroup = 6
	}
	
	public enum TreasureMapQuality
	{
		@NOSELECTION = -1,
		@Low = 0,
		@Medium = 1,
		@High = 2
	}
	
	public enum TreasureMapRegionHint
	{
		@NOSELECTION = -1,
		@OldWorld = 0,
		@NewWorld = 1,
		@ForgottenWorld = 2,
		@Arctic = 3,
		@Africa = 4
	}
	
	public enum TutorialCondition
	{
		@NOSELECTION = -1,
		@Click = 0,
		@Hover = 1,
		@Selected = 2,
		@HintClosed = 3,
		@AutoCompleteTimer = 4,
		@Visibility = 5
	}
	
	public enum TutorialUiCategory
	{
		@NOSELECTION = -1,
		@ConstructionMenu = 0,
		@IslandBar = 1,
		@SessionScene = 2,
		@OMProduction = 3,
		@ResourceBar = 4,
		@NotificationArchive = 5,
		@OMResidence = 6,
		@OMShip = 7,
		@Kontor = 8,
		@Workforce = 9,
		@Zoo = 10,
		@CityInstitution = 11,
		@Warehouse = 12,
		@ProductionChain = 13,
		@RightClickMenu = 14,
		@Worldmap = 15,
		@OMMarketplace = 16,
		@OMPalace = 17,
		@PalaceOverview = 18,
		@OMDepartment = 19,
		@ResearchCentre = 20,
		@Expedition = 21,
		@OMGuildHouse = 22,
		@OMDocklands = 23,
		@Docklands = 24,
		@SettleIsland = 25,
		@RecipeBuilding = 26
	}
	
	public enum TutorialUiHintAnchor
	{
		@NOSELECTION = -1,
		@Top = 0,
		@Left = 1,
		@Right = 2,
		@Bottom = 3,
		@TopRight = 4,
		@BottomRight = 5,
		@BottomLeft = 6,
		@TopLeft = 7
	}
	
	public enum TutorialUiHintColorType
	{
		@NOSELECTION = -1,
		@Info = 0,
		@Quest = 1,
		@Anarchist = 2
	}
	
	public enum TutorialUiHintEndCondition
	{
		@NOSELECTION = -1,
		@None = 0,
		@Selection = 1,
		@Time = 2
	}
	
	public enum TutorialUiHintType
	{
		@NOSELECTION = -1,
		@None = 0,
		@UIElement = 1,
		@Object = 2
	}
	
	public enum UICirclePointerType
	{
		@NOSELECTION = -1,
		@None = 0,
		@North = 1,
		@NorthEast = 2,
		@East = 3,
		@SouthEast = 4,
		@South = 5,
		@SouthWest = 6,
		@West = 7,
		@NorthWest = 8
	}
	
	public enum AmbientMood
	{
		@NOSELECTION = -1,
		@None = 0,
		@AgricultureBuildingsEurope = 1,
		@AgricultureBuildingsSouthAmerica = 2,
		@CoastSand = 3,
		@CoastStone = 4,
		@FieldCorn = 5,
		@FieldRum = 6,
		@ForestEurope = 7,
		@ForestAmerica = 8,
		@IndustryHeavy = 9,
		@Meadow = 10,
		@Mining = 11,
		@MountainTop = 12,
		@SeaFar = 13,
		@SeaClose = 14,
		@ResidenceTier1 = 15,
		@ResidenceTier2 = 16,
		@ResidenceTier3 = 17,
		@ResidenceTier4 = 18,
		@ResidenceTier5 = 19,
		@MountainSide = 20,
		@WoodFarm = 21,
		@PotatoField = 22,
		@CoastStoneSteep = 23,
		@CoastStoneFlat = 24,
		@CoastStoneMountainSide = 25,
		@CoastIce = 26,
		@LakeShore = 27,
		@Tundra = 28,
		@Floe = 29,
		@MeadowIrrigated = 30,
		@ResidenceTierScholars = 31
	}
	
	public enum AudioMarkerType
	{
		@NOSELECTION = -1,
		@Start = 0,
		@Stop = 1,
		@End = 2
	}
	
	public enum CommandBarkType
	{
		@NOSELECTION = -1,
		@Selection = 0,
		@SelectionDamaged = 1,
		@AttackCommand = 2,
		@MoveCommand = 3,
		@EscortCommand = 4,
		@PatrolCommand = 5
	}
	
	public enum EnvironmentType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Ocean = 1,
		@Coast_Sand = 2,
		@Coast_Cliff = 3,
		@Meadow = 4,
		@Forest = 5,
		@Mountain = 6,
		@Building_Residence = 7,
		@Building_Industry = 8,
		@Field = 9,
		@Harbor = 10,
		@Mountain_Side = 11,
		@Fog = 12,
		@ResidenceT1 = 13,
		@ResidenceT2 = 14,
		@ResidenceT3 = 15,
		@ResidenceT4 = 16,
		@ResidenceT5 = 17,
		@Lake = 18,
		@Tundra = 19,
		@MeadowIrrigated = 20,
		@ResidenceScholars = 21
	}
	
	public enum GameAudioState
	{
		@NOSELECTION = -1,
		@InGame = 0,
		@InMeta = 1,
		@InCredits = 2,
		@InBink = 3,
		@InBinkNoMusic = 4,
		@InCamSequence = 5,
		@InTitleScreen = 6,
		@PreGame = 7,
		@InNewspaper = 8,
		@InExpedition = 9,
		@InLoading = 10,
		@InQuestbook = 11,
		@PreTitle = 12,
		@InExhibition = 13,
		@InExhibitionPreparation = 14,
		@InExhibitionReward = 15,
		@InExhibitionEventArchitectural = 16,
		@InExhibitionEventScience = 17,
		@InExhibitionEventArcheology = 18,
		@InExhibitionNoElectricity = 19,
		@InPauseMenu = 20
	}
	
	public enum GlobalSoundGameObjects
	{
		@NOSELECTION = -1,
		@GUISound = 0,
		@ConsoleDebug = 1,
		@BuildModeStreet = 2,
		@Music = 3,
		@CameraSequences = 4,
		@Voice2D = 5,
		@Environment = 6,
		@AmbientMood = 7,
		@Murmur1 = 8,
		@Murmur2 = 9,
		@Murmur3 = 10,
		@Murmur4 = 11,
		@MultiAction = 12,
		@RallyPoint = 13
	}
	
	public enum MaterialType
	{
		@NOSELECTION = -1,
		@NONE = 0,
		@Coal = 1,
		@Wood = 2,
		@Soil = 3,
		@Water = 4,
		@Stone = 5,
		@Metal = 6,
		@Grain = 7,
		@MetalChamber = 8,
		@Stack = 9,
		@Street_Dirt = 10,
		@Street_Brick = 11,
		@Bridge_Dirt = 12,
		@Bridge_Brick = 13,
		@Snow = 14,
		@Street_Snow = 15
	}
	
	public enum MilitaryHitType
	{
		@NOSELECTION = -1,
		@HitWood = 0,
		@HitBrick = 1,
		@HitSteel = 2,
		@HitConcrete = 3,
		@MissWater = 4,
		@MissLand = 5
	}
	
	public enum MurmurType
	{
		@NOSELECTION = -1,
		@None = 0,
		@IncidentRiot = 1,
		@IncidentFire = 2,
		@IncidentIllness = 3,
		@ResidenceSatisfied = 4,
		@ResidenceUnsatisfied = 5,
		@ZooHighAttractiveness = 6,
		@ZooMedAttractiveness = 7,
		@ZooLowAttractiveness = 8,
		@MuseumHighAttractiveness = 9,
		@MuseumMedAttractiveness = 10,
		@MuseumLowAttractiveness = 11,
		@FarmerContent = 12,
		@FarmerHappy = 13,
		@FarmerUnhappy = 14,
		@WorkerContent = 15,
		@WorkerHappy = 16,
		@WorkerUnhappy = 17,
		@ArtisanContent = 18,
		@ArtisanHappy = 19,
		@ArtisanUnhappy = 20,
		@EngineerContent = 21,
		@EngineerHappy = 22,
		@EngineerUnhappy = 23,
		@InvestorContent = 24,
		@InvestorHappy = 25,
		@InvestorUnhappy = 26,
		@JornaleroContent = 27,
		@JornaleroHappy = 28,
		@JornaleroUnhappy = 29,
		@OberaContent = 30,
		@OberaHappy = 31,
		@OberaUnhappy = 32,
		@Market = 33,
		@Monument = 34,
		@MonumentSlow = 35,
		@MonumentFast = 36,
		@Factory = 37,
		@Mine = 38,
		@Farm = 39,
		@Warehouse = 40,
		@Harbor = 41,
		@TouristsLowAttractiveness = 42,
		@TouristsMedAttractiveness = 43,
		@TouristsHighAttractiveness = 44,
		@PoliceSuppression = 45,
		@Festival = 46,
		@MonumentConstruction = 47,
		@MonumentEvent = 48,
		@ThirdPartyEdvard = 49,
		@ThirdPartyEdvardBurning = 50,
		@ThirdPartyIzabell = 51,
		@ThirdPartyPirateAnne = 52,
		@ThirdPartyPirateJean = 53,
		@ThirdPartyBlake = 54,
		@ThirdPartyJailor = 55,
		@WarAction = 56,
		@WarDeclared = 57,
		@WarSurrenderLikely = 58,
		@WarSurrenderUnlikely = 59,
		@DM_SecondPartyMercier = 60,
		@Arctic_BasicTundra = 61,
		@Arctic_BasicGlacier = 62,
		@Arctic_Mine = 63,
		@Arctic_Factory = 64,
		@Arctic_Farm = 65,
		@Arctic_AirshipHangar = 66,
		@Arctic_IncidentFire = 67,
		@Arctic_IncidentIllness = 68,
		@Arctic_AirshipHangarConstruction = 69,
		@Palace = 70,
		@Africa_ShepherdHappy = 71,
		@Africa_ShepherdUnhappy = 72,
		@Africa_ElderHappy = 73,
		@Africa_ElderUnhappy = 74,
		@Africa_Farms = 75,
		@Africa_Factories = 76,
		@Africa_Harbour = 77,
		@Africa_Monastery = 78,
		@Africa_ThirdPartyKetema = 79,
		@Africa_ThirdPartyAngereb = 80,
		@Africa_ThirdPartyKidusi = 81,
		@Africa_ThirdPartyWaha = 82,
		@ScholarHappy = 83,
		@ScholarUnhappy = 84,
		@ResearchCenter = 85,
		@Cosmetic_AmusementPark = 86,
		@Cosmetic_CityLife = 87,
		@Tourist_Bar = 88,
		@Tourist_Cafe = 89,
		@Tourist_ChemicalPlantOldWorld = 90,
		@Tourist_OrchardNewWorld = 91,
		@Tourist_Restaurant = 92,
		@Tourist_Tower = 93,
		@Tourist_TowerRestaurant = 94
	}
	
	public enum SoundEmitterTypes
	{
		@NOSELECTION = -1,
		@Active = 0,
		@BuildFailed = 1,
		@BuildMoveStart = 2,
		@BuildSuccessful = 3,
		@BuildUpgrade = 4,
		@BuildUpgradeFailed = 5,
		@Collected = 6,
		@Destroy = 7,
		@MovementStart = 8,
		@ProjectileLaunch = 9,
		@ProjectileImpact = 10,
		@ProjectileVolley = 11,
		@WeaponActivation = 12,
		@WeaponDeactivation = 13,
		@Selection = 14,
		@Spawn = 15,
		@Production_UI = 16,
		@BuildMoveSuccess = 17,
		@BuildMoveEnd = 18,
		@InfectFire = 19,
		@InfectIllness = 20,
		@InfectRiot = 21,
		@EnterRuin = 22,
		@LeaveRuin = 23,
		@InfectExplosion = 24,
		@StreetCancelWaypoint = 25,
		@StreetBuildWaypoint = 26
	}
	
	public enum SoundEventType
	{
		@NOSELECTION = -1,
		@Default = 0,
		@SmallFeedbackSound = 1,
		@MiddleFeedbackSound = 2,
		@LargeFeedbackSound = 3,
		@SmallBuildingSound = 4,
		@MiddleBuildingSound = 5,
		@LargeBuildingSound = 6,
		@SmallHerd = 7,
		@MiddleHerd = 8,
		@LargeHerd = 9,
		@CL_rfx_close = 10,
		@CL_rfx_mid = 11,
		@CL_rfx_far = 12
	}
	
	public enum SpeechAudioMood
	{
		@NOSELECTION = -1,
		@Positve = 0,
		@Neutral = 1,
		@Negative = 2
	}
	
	public enum SpeechAudioType
	{
		@NOSELECTION = -1,
		@Campaign = 0,
		@PaMSy = 1,
		@Murmur = 2,
		@Movie = 3
	}
	
	public enum VideoPortraitType
	{
		@NOSELECTION = -1,
		@Left = 0,
		@Right = 1
	}
	
	public enum VideoTimeType
	{
		@NOSELECTION = -1,
		@Queue = 0,
		@Pause = 1,
		@TimeCode = 2
	}
	
	public enum AudioSessionType
	{
		@NOSELECTION = -1,
		@Default = 0,
		@SunkenTreasure = 1
	}
	
	public enum IncidentMusicType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Fire = 1,
		@Riot = 2,
		@Illness = 3,
		@Anarchy = 4
	}
	
	public enum MusicEnding
	{
		@NOSELECTION = -1,
		@Win = 0,
		@Loose = 1,
		@Neutral = 2
	}
	
	public enum MusicType
	{
		@NOSELECTION = -1,
		@Standard = 0,
		@Incident = 1,
		@Military = 2,
		@ThirdParty = 3,
		@GameWon = 4,
		@GameLost = 5,
		@CampaignPrologue = 6,
		@CampaignEnd = 7
	}
	
	public enum CounterScope
	{
		@NOSELECTION = -1,
		@Area = 0,
		@Session = 1,
		@Region = 2,
		@Global = 3,
		@Account = 4
	}
	
	public enum CounterValueType
	{
		@NOSELECTION = -1,
		@Current = 0,
		@Min = 1,
		@Max = 2
	}
	
	public enum PlayerCounter
	{
		@NOSELECTION = -1,
		@ObjectBuilt = 0,
		@TradeProductBought = 1,
		@TradeProductSold = 2,
		@PopulationByLevel = 3,
		@PopulationByGroup = 4,
		@PopulationTotal = 5,
		@GoodsInStock = 6,
		@ObjectDestroyed = 7,
		@ObjectLost = 8,
		@StreetConnection = 9,
		@NoStreetConnection = 10,
		@AchievementPoints = 11,
		@CorporationLevel = 12,
		@BuildingsMoved = 13,
		@IslandSettled = 14,
		@BuildingsDemolished = 15,
		@MaxAchievementPoints = 16,
		@MaxCityStatus = 17,
		@QuestCalled = 18,
		@QuestEnded = 19,
		@QuestSolved = 20,
		@QuestAbortedManually = 21,
		@BankruptCounter = 22,
		@PopulationHappinessByLevel = 23,
		@PopulationHappinessByGroup = 24,
		@PopulationHappinessTotal = 25,
		@PopulationSatisfactionByGood = 26,
		@InfectedObjects = 27,
		@IncidentChance = 28,
		@WorkingConditions = 29,
		@MoneyBalance = 30,
		@ExpeditionSolved = 31,
		@ExpeditionFailed = 32,
		@ExpeditionReturnedEarly = 33,
		@CollectablesCollected = 34,
		@PassiveTradeBalance = 35,
		@CampaignRuinRemoved = 36,
		@ShipsSoldToParticipant = 37,
		@ParticipantDefeated = 38,
		@NewspaperArticlePublished = 39,
		@QuestPoolQuestsSolved = 40,
		@ReputationWithParticipant = 41,
		@DivingBellUsed = 42,
		@ItemSetsActive = 43,
		@Attractiveness = 44,
		@IncidentActive = 45,
		@CanalTilesFilled = 46,
		@ObjectWatered = 47,
		@MajorDiscoveryCrafted = 48,
		@ItemsCrafted = 49,
		@ObjectWateredInclFutureIrrigation = 50,
		@CanalTilesNotConnected = 51,
		@ItemsDonated = 52,
		@MilitaryStrength = 53,
		@QuestFailed = 54,
		@ActiveTradeContracts = 55,
		@ExportedGoodAmount = 56,
		@ImportedGoodAmount = 57
	}
	
	public enum AISquadCommands
	{
		@NOSELECTION = -1,
		@Attack = 0,
		@Defend = 1,
		@Patrol = 2,
		@Escort = 3,
		@RepairInCombat = 4,
		@RepairIdle = 5,
		@DefendAlly = 6
	}
	
	public enum AutoCreateParticipantMode
	{
		@NOSELECTION = -1,
		@DynamicallyCreatedOnDemand = 0,
		@AutoCreate_Meta = 1,
		@AutoCreate_MetaAndAllSessions = 2
	}
	
	public enum CeaseFireLength
	{
		@NOSELECTION = -1,
		@Default = 0
	}
	
	public enum DiplomacyActionMessageEvent
	{
		@NOSELECTION = -1,
		@OfferAction = 0,
		@ThreatAction = 1,
		@AcceptOfferAction = 2,
		@DeclineOfferAction = 3,
		@ThreatAcceptAction = 4,
		@ThreatIgnoreAction = 5,
		@EndNegotiation = 6
	}
	
	public enum DiplomacyActionMessageInitiator
	{
		@NOSELECTION = -1,
		@LastActorInitiator = 0,
		@FirstActorInitiator = 1
	}
	
	public enum DiplomacyAISpecialTrigger
	{
		@NOSELECTION = -1,
		@BuildingDestroyedByEnemy = 0,
		@ShipDestroyedByEnemy = 1,
		@GenericTimer = 2,
		@NeedPlayersIsland = 3,
		@TraderouteEndangeredByEnemy = 4
	}
	
	public enum DiplomacyAITrigger
	{
		@NOSELECTION = -1,
		@ReputationIncreased = 0,
		@ReputationDecreased = 1
	}
	
	public enum DiplomacyButtonVisibility
	{
		@NOSELECTION = -1,
		@Alliance = 0,
		@Trade = 1,
		@Peace = 2,
		@War = 3
	}
	
	public enum DiplomacyGiftSize
	{
		@NOSELECTION = -1,
		@receiveSmall = 0,
		@receiveOrdinary = 1,
		@receiveGenerous = 2,
		@giveSmall = 3,
		@giveOrdinary = 4,
		@giveGenerous = 5,
		@receivePayment = 6,
		@givePayment = 7,
		@counterProposal = 8
	}
	
	public enum DiplomacyHiddenFuture
	{
		@NOSELECTION = -1,
		@PositiveChange = 0,
		@NegativeChange = 1
	}
	
	public enum DiplomacyRating
	{
		@NOSELECTION = -1,
		@SuccessLvl0 = 0,
		@SuccessLvl1 = 1,
		@SuccessLvl2 = 2,
		@SuccessLvl3 = 3,
		@SuccessLvl4 = 4,
		@SuccessLvl5 = 5,
		@SuccessLvl6 = 6,
		@SuccessLvl7 = 7,
		@SuccessLvl8 = 8,
		@SuccessLvl9 = 9,
		@SuccessLvl10 = 10,
		@SuccessLvl11 = 11
	}
	
	public enum DiplomacyState
	{
		@NOSELECTION = -1,
		@War = 0,
		@Peace = 1,
		@TradeRights = 2,
		@Alliance = 3,
		@CeaseFire = 4,
		@NonAttack = 5
	}
	
	public enum DiplomaticAction
	{
		@NOSELECTION = -1,
		@DeclareWar = 0,
		@ThreatWar = 1,
		@RequestPeace = 2,
		@GiftMoneyOneTimeSmall = 3,
		@GiftMoneyOneTimeOrdinary = 4,
		@GiftMoneyOneTimeGenerous = 5,
		@CancelTraderights = 6,
		@RequestTraderights = 7,
		@PaymentIncreaseReputation = 8,
		@PaymentDecreaseReputation = 9,
		@Flatter = 10,
		@DemandQuest = 11,
		@CancelAlliance = 12,
		@RequestAlliance = 13,
		@Insult = 14,
		@RequestCeaseFire = 15,
		@ThreatCancelTrade = 16,
		@ThreatCancelAlliance = 17,
		@RequestNonAttack = 18
	}
	
	public enum DiplomaticActionDebuffs
	{
		@NOSELECTION = -1,
		@Disabled = 0,
		@ThreatWar = 1,
		@Peace = 2,
		@Trade = 3,
		@Alliance = 4,
		@CeaseFire = 5,
		@NonAttack = 6
	}
	
	public enum DiplomaticRepeatableAction
	{
		@NOSELECTION = -1,
		@Flatter = 0,
		@Insult = 1,
		@Gift = 2
	}
	
	public enum MetaParticipantCreateMode
	{
		@NOSELECTION = -1,
		@Dynamically_GameSetupOrMapload = 0,
		@AutoCreate_Always = 1,
		@AutoCreate_OnlyCampaign = 2
	}
	
	public enum MilitaryBlindedFlags
	{
		@NOSELECTION = -1,
		@IgnoreBuildings = 0,
		@IgnoreShips = 1,
		@IgnoreNonAttackers = 2
	}
	
	public enum MilitaryFlyoutType
	{
		@NOSELECTION = -1,
		@OwnHeal = 0,
		@OwnDamage = 1,
		@EnemyDamage = 2
	}
	
	public enum MilitaryState
	{
		@NOSELECTION = -1,
		@Peace = 0,
		@War = 1
	}
	
	public enum MilitaryStrengthLevel
	{
		@NOSELECTION = -1,
		@Inferior = 0,
		@Equal = 1,
		@Superior = 2
	}
	
	public enum NonAttackLength
	{
		@NOSELECTION = -1,
		@Default = 0
	}
	
	public enum ParticipantID
	{
		@NOSELECTION = -1,
		@Human0 = 0,
		@Human1 = 1,
		@Human2 = 2,
		@Human3 = 3,
		@Human4 = 4,
		@Human5 = 5,
		@Human6 = 6,
		@Human7 = 7,
		@Neutral = 8,
		@General_Enemy = 9,
		@Test_Doedel = 10,
		@Advisor_01_Hannah = 11,
		@Advisor_01_Hannah_BlackDress = 12,
		@Advisor_02_Aahrant = 13,
		@Third_enemy_01_Grant = 14,
		@Third_party_01_Queen = 15,
		@Third_party_02_Blake = 16,
		@Third_party_03_Pirate_Harlow = 17,
		@Third_party_04_Pirate_LaFortune = 18,
		@Third_party_05_Sarmento = 19,
		@Third_party_05b_Sarmento_Prosperity_Campaign = 20,
		@Third_party_05c_Sarmento_Attackable_Campaign = 21,
		@Third_party_06_Nate = 22,
		@Third_party_07_Jailor_Bleakworth = 23,
		@Third_party_08_Kahina = 24,
		@Second_ai_01_Jorgensen = 25,
		@Second_ai_02_Qing = 26,
		@Second_ai_03_Wibblesock = 27,
		@Second_ai_04_Smith = 28,
		@Second_ai_05_OMara = 29,
		@Second_ai_06_Gasparov = 30,
		@Second_ai_07_von_Malching = 31,
		@Second_ai_08_Gravez = 32,
		@Second_ai_09_Silva = 33,
		@Second_ai_10_Hunt = 34,
		@Resident_tier01 = 35,
		@Resident_tier02 = 36,
		@Resident_tier03 = 37,
		@Resident_tier04 = 38,
		@Resident_tier05 = 39,
		@Captain = 40,
		@Visitor = 41,
		@Editor = 42,
		@Event_character_01_Arctic = 43,
		@Campaign_character_01_demolition_expert = 44,
		@Campaign_character_02_pyrophorian_red = 45,
		@Campaign_character_02_pyrophorian_red_blinded = 46,
		@Campaign_character_03_pyrophorian_silver = 47,
		@Campaign_character_04_pyrophorian_gold = 48,
		@Campaign_character_07_magistrate = 49,
		@Campaign_character_08_cousin_female = 50,
		@Campaign_character_09_cousin_male = 51,
		@Campaign_character_10_SA_ticketseller = 52,
		@SA_Resident_tier01 = 53,
		@SA_Resident_tier02 = 54,
		@SA_Resident_tier01_atWork = 55,
		@SA_Resident_tier02_atWork = 56,
		@Resident_tier01_atWork = 57,
		@Resident_tier02_atWork = 58,
		@Resident_tier03_atWork = 59,
		@Resident_tier04_atWork = 60,
		@Resident_tier05_atWork = 61,
		@Workforce_Commuter_Captain = 62,
		@Campaign_character_04b_pyrophorian_gold_nonattackable = 63,
		@Second_ai_11_Mercier = 64,
		@Third_party_09_Vasco_Silva = 65,
		@Mercier_DeserterWorker = 66,
		@Arctic_Resident_tier01 = 67,
		@Arctic_Resident_tier02 = 68,
		@Arctic_Resident_tier01_atWork = 69,
		@Arctic_Resident_tier02_atWork = 70,
		@Arctic_LadyFaithful = 71,
		@Arctic_Inuit = 72,
		@Arctic_SirJohn = 73,
		@Third_party_02b_Blake_AttacksPirate = 74,
		@Africa_Resident_tier01 = 75,
		@Africa_Resident_tier02 = 76,
		@Africa_Kyria = 77,
		@Third_party_06b_Nate_Arctic = 78,
		@Africa_Resident_tier03 = 79,
		@Africa_Ketema = 80,
		@Africa_Biniam = 81,
		@Africa_Blake = 82,
		@Africa_Kidusi = 83,
		@Africa_Angereb = 84,
		@Africa_Waha = 85,
		@Africa_Goat = 86,
		@Africa_Zebra = 87,
		@Africa_Hyena = 88,
		@Africa_Hippopotamus = 89,
		@Africa_Cheetah = 90,
		@Africa_Lion = 91,
		@Africa_Nomads = 92,
		@Africa_KetemaFake = 93,
		@Africa_Building = 94,
		@Void_Trader = 95,
		@Resident_Tourist = 96,
		@Resident_Tourist_atWork = 97
	}
	
	public enum ProfileType
	{
		@NOSELECTION = -1,
		@Human = 0,
		@SecondParty = 1,
		@ThirdParty = 2,
		@VirtualParticipant_NeverOwnsGameObjects = 3
	}
	
	public enum SessionParticipantCreateMode
	{
		@NOSELECTION = -1,
		@Dynamically_MaploadOrSessionEnter = 0,
		@AutoCreate_Always = 1,
		@AutoCreate_OnlyCampaign = 2,
		@AutoCreate_WhenInGameSetup = 3
	}
	
	public enum ThirdPartyIslandPlacement
	{
		@NOSELECTION = -1,
		@NoIsland = 0,
		@Optional = 1,
		@OptionalUnique = 2,
		@InFirstSession = 3,
		@InFirstSessionUnique = 4,
		@InEverySession = 5
	}
	
	public enum ParticipantMessageCategory
	{
		@NOSELECTION = -1,
		@Other = 0,
		@Test = 1,
		@Diplomacy = 2,
		@Quest = 3,
		@Click = 4
	}
	
	public enum ParticipantMessageEffect
	{
		@NOSELECTION = -1,
		@None = 0,
		@AddReputation = 1
	}
	
	public enum ParticipantMessageFilter
	{
		@NOSELECTION = -1,
		@Expedition = 0,
		@Newspaper = 1,
		@Diplomacy = 2
	}
	
	public enum ParticipantMessageReputation
	{
		@NOSELECTION = -1,
		@DontCare = 0,
		@ReputationToInitiator = 1,
		@ReputationToTarget = 2,
		@CompareInitiatorWithRequired = 3,
		@CompareTargetWithRequired = 4
	}
	
	public enum ParticipantMessageRole
	{
		@NOSELECTION = -1,
		@Target = 0,
		@Initiator = 1,
		@ObserverToInitiator = 2,
		@ObserverToTarget = 3,
		@ObserverToSelf = 4,
		@InitiatorToSelf = 5,
		@TargetToSelf = 6
	}
	
	public enum ParticipantMessageTrigger
	{
		@NOSELECTION = -1,
		@None = 0,
		@ShipReachesHarbour = 1,
		@ClickKontor = 2,
		@ClickWorldFair = 3,
		@ClickOwnKontor = 4,
		@ClickResidence = 5,
		@ClickOwnResidence = 6,
		@ClickProductionBuildingWithInfolayer = 7,
		@ClickNPCBuilding = 8,
		@ClickNPCShip = 9,
		@QuestInvitation = 10,
		@QuestStarted = 11,
		@QuestSuccessful = 12,
		@QuestFailed = 13,
		@QuestAborted = 14,
		@QuestAbortedAutomatically = 15,
		@QuestEscortShipSelected = 16,
		@QuestReminder = 17,
		@QuestResolveConfirmation = 18,
		@QuestInvitationSmugglerQuest = 19,
		@QuestSmugglerTradingStationReached = 20,
		@QuestStartInvitationGiveItem = 21,
		@QuestStartFollowShip = 22,
		@QuestGiverIdleMessage = 23,
		@ShipTradeConfirmation = 24,
		@ActiveTradeConfirmation = 25,
		@PassiveTradeConfirmation = 26,
		@OpenActiveTradeMenu = 27,
		@GenericNegativeFeedback = 28,
		@SettlePermissionRequest = 29,
		@SettlePermissionAccepted = 30,
		@SettlePermissionDeclined = 31,
		@SettlementRightsClaimIsland = 32,
		@SettlementRightsSeizeIsland = 33,
		@DiplomacyOffer = 34,
		@DiplomacyOfferThreat = 35,
		@DiplomacyOfferAccept = 36,
		@DiplomacyOfferRejected = 37,
		@DiplomacyOfferRejectedTooOften = 38,
		@DiplomacyOfferThreatAccepted = 39,
		@DiplomacyOfferThreatRejected = 40,
		@DiplomacyDeclareWar = 41,
		@DiplomacyOfferPeace = 42,
		@DiplomacyOfferPeaceAccepted = 43,
		@DiplomacyOfferCeasefire = 44,
		@DiplomacyOfferCeasefireAccepted = 45,
		@DiplomacyOfferTraderights = 46,
		@DiplomacyOfferTraderightsAccepted = 47,
		@DiplomacyCancelTraderights = 48,
		@DiplomacyOfferProtection = 49,
		@DiplomacyOfferProtectionAccepted = 50,
		@DiplomacyCancelProtection = 51,
		@DiplomacyOfferAlliance = 52,
		@DiplomacyOfferAllianceAccepted = 53,
		@DiplomacyCancelAlliance = 54,
		@DiplomacyOfferOpenborders = 55,
		@DiplomacyCancelOpenborders = 56,
		@DiplomacyOfferGift = 57,
		@DiplomacyOfferGiftAccepted = 58,
		@DiplomacyOfferGiftRejected = 59,
		@DiplomacyRequestLoan = 60,
		@DiplomacySendSupportFleet = 61,
		@DiplomacyAskForQuestAccepted = 62,
		@DiplomacyAskForQuestRejected = 63,
		@DiplomacyGrantsLoan = 64,
		@DiplomacyRequestSupportFleet = 65,
		@DiplomacyRequestSupportFleetAccepted = 66,
		@DiplomacyRequestSupportFleetRejected = 67,
		@DiplomacyAcceptFlatter = 68,
		@DiplomacyDeclineFlatter = 69,
		@DiplomacyAcceptInsult = 70,
		@DiplomacyDeclineInsult = 71,
		@DiplomacyMemoryCorrectionPositive = 72,
		@DiplomacyMemoryCorrectionNegative = 73,
		@DiplomacyCounterProposal = 74,
		@DiplomacyAllianceNeedsHelp = 75,
		@DiplomacyAllianceNeedsDecision = 76,
		@DiplomacyProtectionNeedsHelp = 77,
		@DiplomacyProtectionNeedsDecision = 78,
		@DiplomacyOfferNonAggressionPact = 79,
		@DiplomacyOfferNonAggressionPactAccepted = 80,
		@DiplomacyPiratesResettled = 81,
		@DiplomacyPiratesDefeated = 82,
		@DiplomacyCeaseFireEnded = 83,
		@DiplomacyNonAgressionPactEnded = 84,
		@DiplomacyIdleMessage = 85,
		@NewspaperCreated = 86,
		@NewspaperPublishedWithPropaganda = 87,
		@NewspaperPublishedWithPropagandaGood = 88,
		@NewspaperPublishedWithPropagandaBad = 89,
		@NewspaperPublishedWithoutPropagandaGood = 90,
		@NewspaperPublishedWithoutPropagandaBad = 91,
		@NewspaperAutoPublished = 92,
		@NewspaperUsePropagandaArticle = 93,
		@BailoutTriggered = 94,
		@ParticipantDiscovered = 95,
		@ExpeditionSpawn = 96,
		@ExpeditionOpenLog = 97,
		@ExpeditionIdle = 98,
		@ExpeditionAssignShip = 99,
		@ExpeditionSetsOut = 100,
		@ExpeditionEventStart = 101,
		@ExpeditionCallForEvent = 102,
		@ExpeditionReward = 103,
		@ExpeditionContinue = 104,
		@ExpeditionReturns = 105,
		@ExpeditionReturnsWithRewards = 106,
		@ExpeditionDiscover = 107,
		@ExpeditionFailed = 108,
		@ExpeditionPreparationFailed = 109,
		@BuyIslandShare = 110,
		@SellIslandShare = 111,
		@TakeOverIslandPossible = 112,
		@TakeOverIsland = 113,
		@MenuFirstWelcomeMessage = 114,
		@MenuWelcomeMessage = 115,
		@MenuIdleMessage = 116,
		@MenuVisitorDecline = 117,
		@MenuVisitorIncrease = 118,
		@MenuStableTourism = 119,
		@MenuSpecialVisit = 120,
		@MenuRoadMissing = 121,
		@MenuAttractivenessLevel = 122,
		@DateNotificationEarthDay = 123,
		@DateNotificationStPatricksDay = 124,
		@DateNotificationNewYearsEve = 125,
		@DateNotificationNewYearsDay = 126,
		@DateNotificationHalloween = 127,
		@DateNotificationChristmas = 128,
		@DateNotificationEaster = 129,
		@FlagshipReplacementOffered = 130,
		@NewSession_HumanAfterAI = 131,
		@NewSession_AIAfterHuman = 132,
		@IncidentStart = 133,
		@IncidentEnd = 134,
		@IncidentEndWithoutResolver = 135,
		@IncidentSendSpecialForces = 136,
		@IncidentEscalate = 137,
		@MilitaryShipDestroyed = 138,
		@MilitaryBuildingDestroyed = 139,
		@MilitaryParticipantDefeated = 140,
		@MilitaryTakeoverSucceeded = 141,
		@MilitaryTakeoverFailed = 142,
		@MilitaryStrength = 143,
		@ExpansionHigherThanNPC = 144,
		@ExpansionLowerThanNPC = 145,
		@ExpansionEqualNPC = 146,
		@ExpansionExpanded = 147,
		@ProgressLevelHigherThanNPC = 148,
		@ProgressLevelLowerThanNPC = 149,
		@ProgressLevelEqualNPC = 150,
		@ProgressLevelLevelUp = 151,
		@NoQuestAvailable = 152,
		@BuildingBuilt = 153,
		@MonumentFinished = 154,
		@CulturalBuildingAttractivenessHigherThan = 155,
		@IslandPollutionHigherThan = 156,
		@FirstTimeEventHappened = 157,
		@PauseProductionBuilding = 158,
		@ResumeProductionBuilding = 159,
		@MonumentExhibitionStarts = 160,
		@MonumentShutdown = 161,
		@MonumentRewardReady = 162,
		@MonumentMenuTrigger = 163,
		@WorkingConditionsHigh = 164,
		@WorkingConditionsLow = 165,
		@DivingBellShipReplacementOffered = 166,
		@GreatEasternReplacementOffered = 167,
		@ResearchCenterRecipeUnlock = 168,
		@ResearchCenterStartCrafting = 169,
		@ResearchCenterFinishCrafting = 170,
		@ResearchCenterDonateItem = 171,
		@ResearchCenterCollectReminder = 172,
		@ResearchCenterMissingElectricity = 173,
		@DocklandsExportGoodUpgraded = 174,
		@DocklandsModulesBuilt = 175,
		@DocklandsModulesConnected = 176,
		@ClickHotel = 177,
		@ClickOwnHotel = 178,
		@ClickRestaurant = 179,
		@ClickOwnRestaurant = 180,
		@RecipeApplied = 181
	}
	
	public enum FeedbackBalancingOverwrite
	{
		@NOSELECTION = -1,
		@Default_NoOverwrite = 0,
		@Mercier = 1
	}
	
	public enum FeedbackBehaviour
	{
		@NOSELECTION = -1,
		@ResidencePerson = 0,
		@ResidenceVehicle = 1,
		@Police = 2,
		@Speaker = 3,
		@Train = 4,
		@HarborWorker = 5,
		@SimpleTourist = 6,
		@FarmWorker = 7,
		@FarmWorkerMotorized = 8,
		@FishingBoat = 9,
		@NightCrowd = 10,
		@Hunter = 11,
		@Prey = 12,
		@INTERNAL_DangerAvoid = 13,
		@INTERNAL_Listener = 14,
		@INTERNAL_Walk = 15,
		@INTERNAL_ForceField = 16,
		@INTERNAL_Interact = 17,
		@INTERNAL_TransportationStreet = 18,
		@INTERNAL_TransportationTrain = 19,
		@INTERNAL_CultureVisitor = 20,
		@INTERNAL_Idle = 21,
		@INTERNAL_MineLorry = 22,
		@INTERNAL_IncidentResolver = 23,
		@INTERNAL_Test = 24,
		@INTERNAL_DummyInteraction = 25,
		@INTERNAL_GroupMember = 26,
		@INTERNAL_ParadeTrain = 27,
		@INTERNAL_Woodcutter = 28,
		@INTERNAL_HarbourWater = 29,
		@INTERNAL_Bus = 30,
		@INTERNAL_BusStop = 31
	}
	
	public enum FeedbackBuildingGroupRole
	{
		@NOSELECTION = -1,
		@Residence1 = 0,
		@Residence2 = 1,
		@Residence3 = 2,
		@Residence4 = 3,
		@Residence5 = 4,
		@TrainDestination = 5,
		@Other = 6,
		@Cultural = 7,
		@Production1 = 8,
		@Production2 = 9,
		@Production3 = 10,
		@Production4 = 11,
		@ProvidesForAllResidenceTiers = 12,
		@Palace = 13,
		@ResidenceScholar = 14,
		@ResidenceTourist = 15
	}
	
	public enum FeedbackClassFlag
	{
		@NOSELECTION = -1,
		@InhabitsTier1Building = 0,
		@InhabitsTier2Building = 1,
		@InhabitsTier3Building = 2,
		@InhabitsTier4Building = 3,
		@InhabitsTier5Building = 4,
		@FightsRiot = 5,
		@FightsPolice = 6,
		@IsChild = 7,
		@Tourist = 8,
		@HarbourWorker = 9,
		@IsAnimal = 10,
		@JoinsNightCrowd = 11,
		@Palace = 12,
		@InhabitsTierScholarBuilding = 13,
		@InhabitsTierTouristBuilding = 14
	}
	
	public enum FeedbackDangerReationType
	{
		@NOSELECTION = -1,
		@RUN_AWAY = 0,
		@WALK_AWAY = 1,
		@IGNORE = 2
	}
	
	public enum FeedbackReaction
	{
		@NOSELECTION = -1,
		@Listen = 0,
		@Greet = 1,
		@Talk = 2,
		@Protest = 3,
		@Cheer = 4,
		@MobJoining = 5,
		@DangerAvoiding = 6,
		@DummyTalk = 7,
		@DummyTrade = 8,
		@DummyVanish = 9,
		@DummyLayDown = 10,
		@DummyFish = 11,
		@DummyPray = 12,
		@DummyCelebrate = 13,
		@DummyReact = 14,
		@DummySit = 15,
		@DummyWorkHammerWall = 16,
		@DummyWorkHammerFloor = 17,
		@DummyWorkShovel = 18,
		@DummyWorkThink = 19,
		@DummyWorkHands = 20,
		@DummyIdle_Vehicle = 21,
		@DummyDrink_Vehicle = 22
	}
	
	public enum FeedbackResidentCamInteraction
	{
		@NOSELECTION = -1,
		@MountAsMotorized = 0,
		@MountAsCoach = 1,
		@MountAsAnimal = 2,
		@MountAsBoat = 3,
		@Bus = 4,
		@None = 5
	}
	
	public enum FeedbackResolverSpawning
	{
		@NOSELECTION = -1,
		@DOORS = 0,
		@FEEDBACK_SPACE = 1,
		@DEMAGOGUE = 2
	}
	
	public enum FeedbackSequenceCategory
	{
		@NOSELECTION = -1,
		@Celebrate = 0,
		@Pray = 1,
		@IdleWithInteraction = 2,
		@Idle = 3
	}
	
	public enum FeedbackSpecialLayer
	{
		@NOSELECTION = -1,
		@Fishery = 0,
		@FarmFields_Person = 1,
		@FarmFields_Vehicle = 2,
		@Lumberjack = 3,
		@Hunter = 4
	}
	
	public enum FeedbackTrailerStyle
	{
		@NOSELECTION = -1,
		@Oil = 0,
		@ParadeDrums = 1,
		@ParadeTrumpets = 2,
		@ParadeBeerWagon = 3,
		@ParadeDancer = 4,
		@AnarchyParadeWalker = 5,
		@AnarchyParadeDrums = 6,
		@AnarchyParadeTrumpets = 7,
		@AnarchyParadeWagon = 8,
		@ParadeQueen = 9,
		@MountedSingleGuard = 10,
		@MountedGuards = 11,
		@WalkingGuards = 12
	}
	
	public enum FeedbackTransporterType
	{
		@NOSELECTION = -1,
		@FactoryTransporter = 0,
		@WarehouseTransporter = 1,
		@ResidenceTransporter = 2,
		@TrainTransporter = 3,
		@ElectricWarehouseTransporter = 4,
		@ElectricFactoryTransporter = 5,
		@FuelTransporter = 6
	}
	
	public enum FeedbackUnitCategories
	{
		@NOSELECTION = -1,
		@AllUnits = 0,
		@OnlyAdults = 1,
		@OnlyChildren = 2
	}
	
	public enum FeedbackUnitSpeedSource
	{
		@NOSELECTION = -1,
		@TakeFromCFG = 0,
		@TakeFromAsset = 1,
		@Managed = 2
	}
	
	public enum FeedbackUnitType
	{
		@NOSELECTION = -1,
		@Person = 0,
		@Vehicle = 1,
		@Train = 2,
		@MineLorry = 3,
		@Ship = 4,
		@ParadeTrain = 5,
		@ShipBig = 6,
		@Bus = 7
	}
	
	public enum Moods
	{
		@NOSELECTION = -1,
		@Bad = 0,
		@Neutral = 1,
		@Good = 2
	}
	
	public enum FeedbackSizeCategory
	{
		@NOSELECTION = -1,
		@Person = 0,
		@Vehicle = 1,
		@HugeVehicle = 2
	}
	
	public enum DynamicAutoSpawning
	{
		@NOSELECTION = -1,
		@None = 0,
		@Coast = 1,
		@City = 2
	}
	
	public enum FishWaterLayer
	{
		@NOSELECTION = -1,
		@Coast = 0,
		@DeepWater = 1
	}
	
	public enum HerdBlockingMode
	{
		@NOSELECTION = -1,
		@Passable = 0,
		@PassableWhenSparse = 1,
		@NeverPassable = 2
	}
	
	public enum DummyFallbackPriority
	{
		@NOSELECTION = -1,
		@DUMMY_ONLY = 0,
		@FALLBACK_ONLY = 1,
		@DUMMY_AND_FALLBACK = 2,
		@DUMMY_OR_FALLBACK = 3
	}
	
	public enum ActionScope
	{
		@NOSELECTION = -1,
		@Self = 0,
		@SelfRadius = 1,
		@Target = 2,
		@TargetRadius = 3
	}
	
	public enum ExternalBuffTarget
	{
		@NOSELECTION = -1,
		@Ally = 0,
		@Enemy = 1,
		@Self = 2
	}
	
	public enum ItemAllocation
	{
		@NOSELECTION = -1,
		@None = 0,
		@RadiusBuilding = 1,
		@GuildHouse = 2,
		@TownHall = 3,
		@HarborOffice = 4,
		@Headquarter = 5,
		@Culture = 6,
		@Zoo = 7,
		@BotanicGarden = 8,
		@Museum = 9,
		@Ship = 10,
		@SailShip = 11,
		@SteamShip = 12,
		@Expedition = 13,
		@Warship = 14,
		@Tradeship = 15,
		@DivingVessel = 16,
		@Pavilion = 17,
		@AirShip = 18,
		@Lodge = 19,
		@BuildPermit = 20,
		@Dockland = 21
	}
	
	public enum ItemSource
	{
		@NOSELECTION = -1,
		@Quest = 0,
		@Expedition = 1,
		@Trader = 2,
		@Visitors = 3,
		@Monument = 4,
		@ItemCrafting = 5,
		@MilitaryDrops = 6,
		@DivingBell = 7,
		@ArcticCrate = 8,
		@ResearchCrafting = 9
	}
	
	public enum ItemSourceDropType
	{
		@NOSELECTION = -1,
		@ShipDrop = 0,
		@MainIslandTakeover = 1,
		@SecondaryIslandTakeover = 2
	}
	
	public enum ItemType
	{
		@NOSELECTION = -1,
		@Normal = 0,
		@Animal = 1,
		@Specialist = 2,
		@None = 3
	}
	
	public enum NotSockableReason
	{
		@NOSELECTION = -1,
		@WrongAllocation = 0,
		@Duplicate = 1,
		@Exclusive = 2,
		@NoSpaceLeft = 3
	}
	
	public enum Rarity
	{
		@NOSELECTION = -1,
		@Narrative = 0,
		@Common = 1,
		@Uncommon = 2,
		@Rare = 3,
		@Epic = 4,
		@Legendary = 5,
		@Godlike = 6,
		@Quest = 7
	}
	
	public enum ReapplyVersion
	{
		@NOSELECTION = -1,
		@DebugAlways = 0,
		@LandOfLions = 1,
		@CDLC3 = 2,
		@TouristSeason = 3
	}
	
	public enum Scope
	{
		@NOSELECTION = -1,
		@Local = 0,
		@ModuleOwner = 1,
		@Radius = 2,
		@Unused_FormerRadiusWithStreetConnection = 3,
		@Area = 4,
		@Session = 5,
		@StreetDistance = 6
	}
	
	public enum ScopeDistanceSource
	{
		@NOSELECTION = -1,
		@Static = 0,
		@PublicServiceDistance = 1
	}
	
	public enum SocketExclusiveGroup
	{
		@NOSELECTION = -1,
		@None = 0,
		@Specialist = 1,
		@Gear = 2,
		@Sail = 3,
		@Motor = 4,
		@Captain = 5,
		@Priest = 6,
		@Navigator = 7,
		@Doctor = 8,
		@Craftsman = 9,
		@Hunter = 10,
		@Police = 11,
		@Diplomat = 12,
		@AutoAttackProjectile = 13,
		@FactoryAct = 14,
		@CleanAirAct = 15,
		@AdministrationAct = 16,
		@EntertainmentAct = 17,
		@ResearchAct = 18,
		@EducationAct = 19,
		@Ordinance = 20,
		@EconomyAct = 21,
		@PublicHealthAct = 22,
		@FirePreventionAct = 23,
		@PublicGatheringAct = 24,
		@ChildRightsAct = 25,
		@HumanRightsAct = 26,
		@AlcoholAct = 27,
		@AlcoholTaxesAct = 28,
		@SecularizationAct = 29,
		@TaxesManagementAct = 30,
		@WorkingConditionsAct = 31,
		@CharityEdict = 32,
		@AmnestyEdict = 33,
		@TourismAdCampaign = 34,
		@NatalityRegulationEdict = 35,
		@WomenRightsAct = 36,
		@Flag = 37,
		@TradingTaxBill = 38,
		@Telescopes = 39,
		@Newspaper = 40,
		@Propaganda = 41,
		@EconomicDoctrine = 42,
		@AnarchyEssay = 43,
		@Sonar = 44,
		@Diver = 45,
		@DivingBell = 46,
		@Cables = 47,
		@Canons = 48
	}
	
	public enum SocketScopeRadiusOverlapCategory
	{
		@NOSELECTION = -1,
		@None = 0,
		@Guildhouse = 1,
		@Townhall = 2,
		@HarborOffice = 3
	}
	
	public enum SonarTarget
	{
		@NOSELECTION = -1,
		@RandomTreasure = 0,
		@QuestTreasure = 1,
		@SeaMine = 2
	}
	
	public enum TreasureTypes
	{
		@NOSELECTION = -1,
		@RandomTreasure = 0,
		@QuestTreasure = 1
	}
	
	public enum ExpeditionAttributes
	{
		@NOSELECTION = -1,
		@None = 0,
		@Diplomacy = 1,
		@Melee = 2,
		@Might = 3,
		@Navigation = 4,
		@Medicine = 5,
		@Faith = 6,
		@Crafting = 7,
		@Hunting = 8,
		@PerkAnthropologist = 9,
		@PerkHypnotist = 10,
		@PerkFormerPirate = 11,
		@PerkDiver = 12,
		@PerkMilitaryShip = 13,
		@PerkTradeShip = 14,
		@PerkZoologist = 15,
		@PerkJackOfAllTraits = 16,
		@PerkEntertainer = 17,
		@PerkArcheologist = 18,
		@PerkPolyglot = 19,
		@PerkSailingShip = 20,
		@PerkSteamShip = 21,
		@PerkMale = 22,
		@PerkFemale = 23
	}
	
	public enum ExpeditionCategory
	{
		@NOSELECTION = -1,
		@Zoological = 0,
		@PirateHunt = 1,
		@RescueMission = 2,
		@Archeological = 3,
		@Botanical = 4,
		@Discovery = 5
	}
	
	public enum ExpeditionDecisionOutcome
	{
		@NOSELECTION = -1,
		@None = 0,
		@LoseSpecialist = 1,
		@LoseItem = 2,
		@LoseGoods = 3,
		@LoseSpecialistWithAttribute = 4,
		@LoseItemWithAttribute = 5,
		@LoseGoodsWithAttribute = 6,
		@LoseSpecialistPreferAttribute = 7,
		@LoseItemPreferAttribute = 8,
		@LoseGoodsPreferAttribute = 9,
		@LoseSpecialistSpecific = 10,
		@LoseItemSpecific = 11,
		@LoseGoodsSpecific = 12
	}
	
	public enum ExpeditionDifficulty
	{
		@NOSELECTION = -1,
		@Easy = 0,
		@Average = 1,
		@Hard = 2
	}
	
	public enum ExpeditionMorale
	{
		@NOSELECTION = -1,
		@AddHigh = 0,
		@AddMedium = 1,
		@AddFew = 2,
		@None = 3,
		@RemoveContinue = 4,
		@RemoveFew = 5,
		@RemoveMedium = 6,
		@RemoveHigh = 7,
		@RemoveVeryHigh = 8
	}
	
	public enum ExpeditionRegion
	{
		@NOSELECTION = -1,
		@None = 0,
		@Arctic = 1,
		@NorthernEurope = 2,
		@NorthAmerica = 3,
		@SouthAmerica = 4,
		@NorthAfrica = 5,
		@Africa = 6,
		@SouthernEurope = 7,
		@SouthernSouthAmerica = 8,
		@NorthernNorthAmerica = 9,
		@CentralEurope = 10
	}
	
	public enum ExpeditionState
	{
		@NOSELECTION = -1,
		@Preparation = 0,
		@Starting = 1,
		@Running = 2,
		@Event = 3,
		@EventFinished = 4,
		@Returning = 5,
		@TargetSession = 6,
		@Ended = 7
	}
	
	public enum ExpeditionThreshold
	{
		@NOSELECTION = -1,
		@UseValue = 0,
		@LossHighThreshold = 1,
		@LossMediumThreshold = 2,
		@LossFewThreshold = 3,
		@NeutralThreshold = 4,
		@RewardFewThreshold = 5,
		@RewardMediumThreshold = 6,
		@RewardHighThreshold = 7
	}
	
	public enum FirstPersonRewardType
	{
		@NOSELECTION = -1,
		@RunningFast = 0,
		@Weather_Rain = 1,
		@Weather_Snow = 2,
		@Particles_Konfetti = 3,
		@Particles_Water = 4,
		@Particles_Firework = 5
	}
	
	public enum FirstPersonTaskType
	{
		@NOSELECTION = -1,
		@VisitBuilding = 0,
		@CollectObjects = 1
	}
	
	public enum QuestAbortReason
	{
		@NOSELECTION = -1,
		@PreActivationTimerRanOut = 0,
		@PreconditionCheckFailed = 1,
		@TutorialDisabled = 2,
		@ParticipantRemoved = 3,
		@IslandUnsettled = 4,
		@DiplomaticRelationChanged = 5,
		@QuestInitFailed = 6,
		@PlayerAborted = 7,
		@ActionQuestpoolEnablement = 8,
		@SpecialReason = 9
	}
	
	public enum QuestActivationTime
	{
		@NOSELECTION = -1,
		@QuestStart = 0,
		@ManualActivation = 1,
		@Never = 2,
		@ConfirmationDialog = 3
	}
	
	public enum QuestCampaignChapter
	{
		@NOSELECTION = -1,
		@Chapter0 = 0,
		@Chapter1 = 1,
		@Chapter2 = 2,
		@Chapter3 = 3,
		@Chapter4 = 4,
		@Chapter5 = 5,
		@Chapter6 = 6
	}
	
	public enum QuestCategory
	{
		@NOSELECTION = -1,
		@MainQuest = 0,
		@RandomQuest = 1,
		@ExplorationQuest = 2,
		@TutorialQuest = 3,
		@MetaQuest = 4,
		@HappyEventQuest = 5,
		@AnarchistQuest = 6,
		@SunkenTreasureQuest = 7,
		@ThePassageQuest = 8,
		@LandOfLionsQuest = 9
	}
	
	public enum QuestDestroyTargetShipBehaviour
	{
		@NOSELECTION = -1,
		@StandStill = 0,
		@Patrol = 1,
		@LeaveMap = 2
	}
	
	public enum QuestDifficulty
	{
		@NOSELECTION = -1,
		@Easy = 0,
		@Medium = 1,
		@Hard = 2
	}
	
	public enum QuestEscortMoveTarget
	{
		@NOSELECTION = -1,
		@Random = 0,
		@MapBorder = 1,
		@ClientKontor = 2,
		@PlayerKontor = 3,
		@TargetObject = 4,
		@PrebuiltObject = 5
	}
	
	public enum QuestJumpToButtonVisibility
	{
		@NOSELECTION = -1,
		@Show = 0,
		@ShowOnlyFakePings = 1,
		@Hide = 2
	}
	
	public enum QuestNotificationDefaultInteraction
	{
		@NOSELECTION = -1,
		@DontCare = 0,
		@Accept = 1,
		@Decline = 2
	}
	
	public enum QuestObjectDespawn
	{
		@NOSELECTION = -1,
		@LeaveMap = 0,
		@Despawn = 1,
		@StayOnMap = 2
	}
	
	public enum QuestPicturePuzzleMobSequence
	{
		@NOSELECTION = -1,
		@Protest = 0,
		@Walk = 1,
		@Run = 2
	}
	
	public enum QuestPicturePuzzleObjectBehaviour
	{
		@NOSELECTION = -1,
		@Static = 0,
		@Mob = 1
	}
	
	public enum QuestSpawnTiming
	{
		@NOSELECTION = -1,
		@OnQuestActivated = 0,
		@OnQuestTriggered = 1
	}
	
	public enum QuestStarterObjectChoice
	{
		@NOSELECTION = -1,
		@None = 0,
		@Specific = 1,
		@QuestGiver = 2
	}
	
	public enum QuestState
	{
		@NOSELECTION = -1,
		@Triggered = 0,
		@Active = 1,
		@Reachable = 2,
		@Reached = 3,
		@Failed = 4,
		@AbortedAutomatically = 5,
		@AbortedManually = 6
	}
	
	public enum QuestTrackerVisibility
	{
		@NOSELECTION = -1,
		@Global = 0,
		@Session = 1,
		@Never = 2
	}
	
	public enum ActionMoveSearchType
	{
		@NOSELECTION = -1,
		@MidPoint = 0,
		@Closest = 1
	}
	
	public enum ActionNewspaperType
	{
		@NOSELECTION = -1,
		@Default = 0,
		@SpecialEdition = 1
	}
	
	public enum ActionType
	{
		@NOSELECTION = -1,
		@RegisterTrigger = 0,
		@ResetTrigger = 1,
		@SpawnObjects = 2,
		@StartQuest = 3,
		@EndQuest = 4,
		@EnableQuest = 5,
		@UnlockAsset = 6,
		@WinGame = 7,
		@LoseGame = 8,
		@ForceTradeOffer = 9,
		@UnForceTradeOffer = 10,
		@TimerAddTime = 11,
		@TimerPause = 12,
		@ExecuteScript = 13,
		@SetObjectVisibility = 14,
		@PlayMovie = 15,
		@PlaySound = 16,
		@ChangeParticipant = 17,
		@Bankrupt = 18,
		@PlayCameraSequence = 19,
		@DeleteObjects = 20,
		@LockAsset = 21,
		@TriggerVoicePlayback = 22,
		@StartObjectSequence = 23,
		@AddGoodsToItemContainer = 24,
		@QueueNewspaperArticle = 25,
		@ForceNewspaper = 26,
		@ActionLink = 27,
		@AddResource = 28,
		@SetObjectVariation = 29,
		@MoveObject = 30,
		@SetIslandReservation = 31,
		@SetObjectGUID = 32,
		@SetObjectPosition = 33,
		@TriggerTextPopup = 34,
		@StartIncident = 35,
		@DelayedActions = 36,
		@TriggerPopup = 37,
		@Notification = 38,
		@AddReputation = 39,
		@ExecuteDiplomaticAction = 40,
		@EnterSession = 41,
		@MenuVisibility = 42,
		@DiscoverIsland = 43,
		@TriggerMinimapPing = 44,
		@LoadSession = 45,
		@UnloadSession = 46,
		@HostileTakeover = 47,
		@SetObjectHitpoints = 48,
		@StopIncident = 49,
		@ChangeIncident = 50,
		@ReplaceItem = 51,
		@SetCamera = 52,
		@BindItemToQuest = 53,
		@ShowTutorialHighlight = 54,
		@SetIslandName = 55,
		@DeleteItem = 56,
		@DeleteStreets = 57,
		@BuildObject = 58,
		@ChangeSoundState = 59,
		@SpeechBubble = 60,
		@EnableTicks = 61,
		@ModifyVariable = 62,
		@ExecuteActionByChance = 63,
		@SetQuestPoolEnablement = 64,
		@StartTreasureMapQuest = 65,
		@DiscoverParticipant = 66,
		@UnlockIrrigationTypeForIsland = 67,
		@Buff = 68,
		@ApplyMemorization = 69,
		@FinishMemorization = 70,
		@MoveRiverLevel = 71,
		@SetAudioState = 72,
		@SetObjectVisualDamage = 73,
		@TriggerTextBook = 74,
		@ForceDiplomaticRelation = 75,
		@StopObjectMovement = 76,
		@StartFestival = 77,
		@ChangeSkin = 78
	}
	
	public enum ConditionResult
	{
		@NOSELECTION = -1,
		@Success = 0,
		@Failed = 1
	}
	
	public enum ConditionType
	{
		@NOSELECTION = -1,
		@AlwaysTrue = 0,
		@PlayerCounter = 1,
		@Event = 2,
		@MoveVehicle = 3,
		@ActiveSession = 4,
		@ActiveRegion = 5,
		@Timer = 6,
		@QuestState = 7,
		@ObjectSelected = 8,
		@QuestDelivery = 9,
		@StaticResult = 10,
		@AreaClaimed = 11,
		@CorporationDifficulty = 12,
		@StarterObject = 13,
		@SessionLoading = 14,
		@AlwaysFalse = 15,
		@HappyEvent = 16,
		@Unlocked = 17,
		@QuestEscort = 18,
		@QuestSubQuest = 19,
		@QuestSelectObject = 20,
		@GoodsInRange = 21,
		@ShipsInRange = 22,
		@QuestItemUsed = 23,
		@ItemUsed = 24,
		@ItemActionCompleted = 25,
		@QuestPickup = 26,
		@Threshold = 27,
		@QuestDestroy = 28,
		@QuestModuleBuildingEfficiency = 29,
		@ModuleBuildingEfficiency = 30,
		@QuestPoolQuestRunning = 31,
		@QuestStatusQuo = 32,
		@QuestSmuggler = 33,
		@QuestPicturePuzzle = 34,
		@UnlockList = 35,
		@QuestSustain = 36,
		@ObjectPosition = 37,
		@IsCampaign = 38,
		@ShipyardState = 39,
		@QuestResolveConfirmation = 40,
		@QuestPhotography = 41,
		@PhotographObject = 42,
		@QuestExpedition = 43,
		@QuestUseItemInArea = 44,
		@DiplomaticState = 45,
		@Reputation = 46,
		@InStorage = 47,
		@QuestFollowShip = 48,
		@QuestHitMovingTarget = 49,
		@FakeDescription = 50,
		@QuestFakeObjective = 51,
		@HappinessMood = 52,
		@ObjHPCheck = 53,
		@FactoryProductivity = 54,
		@QuestTutorial = 55,
		@EvaluateTextSource = 56,
		@TutorialInteraction = 57,
		@ModuleCount = 58,
		@ShipsOwnedInSession = 59,
		@IsTutorial = 60,
		@IsDiscovered = 61,
		@QuestSellObjectToParticipant = 62,
		@BuildingsInBlueprintmode = 63,
		@TextPopupPagesViewed = 64,
		@BurningObject = 65,
		@MonumentEventsActive = 66,
		@ExpeditionFinished = 67,
		@NewspaperPublished = 68,
		@FirstTimeEventHappened = 69,
		@DiplomaticStateChanged = 70,
		@TradeRouteCount = 71,
		@MetagameLoaded = 72,
		@QuestBringVehicleToObject = 73,
		@GameEnded = 74,
		@Attractiveness = 75,
		@MutualAreaInSubconditions = 76,
		@QuestDivingBell = 77,
		@ReminderMessage = 78,
		@IsParticipantInGame = 79,
		@NewspaperPossible = 80,
		@IsMultiplayer = 81,
		@IsDLCActive = 82,
		@InPalaceRange = 83,
		@PalaceUnlocks = 84,
		@PalaceItemEquipBonusActive = 85,
		@IsIndustrialized = 86,
		@IsBuffed = 87,
		@QuestDecision = 88,
		@Decision = 89,
		@Productivity = 90,
		@OverlapsAABB = 91,
		@DecisionOption = 92,
		@ResearchPointLimitReached = 93,
		@IrrigationCapacityExceeded = 94,
		@RecipeResearchCompleted = 95,
		@QuestRecipeResearchCompleted = 96,
		@IsCraftingInProgress = 97,
		@TextPopupClosed = 98,
		@IsDocklandsExportPyramidFull = 99,
		@ExportGoodsLeveled = 100,
		@QuestFactoryProductivity = 101,
		@IslandsWithFertility = 102,
		@QuestIslandsWithFertility = 103,
		@Festival = 104,
		@BusActivationNeedSaturation = 105,
		@QuestBusActivationNeedSaturation = 106,
		@SelectionHappinessDebuffActive = 107,
		@GUIEvent = 108
	}
	
	public enum GoodsInRangeType
	{
		@NOSELECTION = -1,
		@TargetObject = 0,
		@Area = 1,
		@Meta = 2
	}
	
	public enum GUIEventType
	{
		@NOSELECTION = -1,
		@Enter = 0,
		@Leave = 1
	}
	
	public enum MonumentUpgradeState
	{
		@NOSELECTION = -1,
		@NotPossible = 0,
		@Possible = 1,
		@Started = 2,
		@Finished = 3,
		@Finalizable = 4,
		@Done = 5
	}
	
	public enum MutualAreaMask
	{
		@NOSELECTION = -1,
		@MostPopulatedArea = 0
	}
	
	public enum SelectionAllowRuins
	{
		@NOSELECTION = -1,
		@DontCare = 0,
		@True = 1,
		@False = 2
	}
	
	public enum SpawnBorderDistance
	{
		@NOSELECTION = -1,
		@Near = 0,
		@Mid = 1,
		@Far = 2
	}
	
	public enum SpawnIslandDistance
	{
		@NOSELECTION = -1,
		@Near = 0,
		@Mid = 1,
		@Far = 2
	}
	
	public enum SubConditionCompletionOrder
	{
		@NOSELECTION = -1,
		@Parallel = 0,
		@Linear = 1,
		@MutuallyExclusive = 2
	}
	
	public enum TradingStationsDestinationType
	{
		@NOSELECTION = -1,
		@ClientKontor = 0,
		@SpawnedShip = 1
	}
	
	public enum CorporationDifficulty
	{
		@NOSELECTION = -1,
		@Easy = 0,
		@Normal = 1,
		@Hard = 2,
		@Classic = 3,
		@EasyMultiplayer = 4,
		@NormalMultiplayer = 5,
		@HardMultiplayer = 6,
		@Anarchist = 7,
		@EasyQuickMP = 8,
		@NormalQuickMP = 9,
		@HardQuickMP = 10
	}
	
	public enum DCConstructionCostRefund
	{
		@NOSELECTION = -1,
		@Full = 0,
		@Half = 1,
		@None = 2,
		@PayCredits = 3
	}
	
	public enum DCDistributionWorkforce
	{
		@NOSELECTION = -1,
		@Plenty = 0,
		@Medium = 1,
		@Spare = 2
	}
	
	public enum DCHostileTakeover
	{
		@NOSELECTION = -1,
		@On = 0,
		@Off = 1
	}
	
	public enum DCInactiveCosts
	{
		@NOSELECTION = -1,
		@On = 0,
		@Off = 1
	}
	
	public enum DCIncidents
	{
		@NOSELECTION = -1,
		@Easy = 0,
		@Medium = 1,
		@Hard = 2
	}
	
	public enum DCInfluence
	{
		@NOSELECTION = -1,
		@Plenty = 0,
		@Medium = 1,
		@Sparse = 2,
		@Unspecified = 3
	}
	
	public enum DCLossCondition
	{
		@NOSELECTION = -1,
		@BailoutWithSlowLiquidation = 0,
		@BailoutWithFastLiquidation = 1,
		@Bankrupt = 2
	}
	
	public enum DCOptionalQuestFrequency
	{
		@NOSELECTION = -1,
		@Often = 0,
		@Normal = 1,
		@Rare = 2
	}
	
	public enum DCOptionalQuestRewards
	{
		@NOSELECTION = -1,
		@Plenty = 0,
		@Medium = 1,
		@Spare = 2,
		@PennyPinching = 3
	}
	
	public enum DCOptionalQuestTimeout
	{
		@NOSELECTION = -1,
		@NotLimited = 0,
		@Long = 1,
		@Medium = 2,
		@Short = 3
	}
	
	public enum DCRelocateBuildings
	{
		@NOSELECTION = -1,
		@On = 0,
		@PayCredits = 1,
		@Off = 2
	}
	
	public enum DCRevealedMap
	{
		@NOSELECTION = -1,
		@On = 0,
		@Off = 1
	}
	
	public enum DCRevenue
	{
		@NOSELECTION = -1,
		@Plenty = 0,
		@Medium = 1,
		@Spare = 2
	}
	
	public enum DCStartCredits
	{
		@NOSELECTION = -1,
		@Plenty = 0,
		@Medium = 1,
		@Spare = 2
	}
	
	public enum DCStartShips
	{
		@NOSELECTION = -1,
		@None = 0,
		@OneShip = 1,
		@TradeFleet = 2,
		@WarFleet = 3
	}
	
	public enum DCStartWithKontor
	{
		@NOSELECTION = -1,
		@Off = 0,
		@Standard = 1,
		@Full = 2
	}
	
	public enum DCThirdParty
	{
		@NOSELECTION = -1,
		@Off = 0,
		@Normal = 1,
		@Hard = 2
	}
	
	public enum DCTraderRefillRate
	{
		@NOSELECTION = -1,
		@Plenty = 0,
		@Medium = 1,
		@Sparse = 2
	}
	
	public enum DCVictoryConditionAllOrOne
	{
		@NOSELECTION = -1,
		@Off = 0,
		@One = 1,
		@All = 2
	}
	
	public enum DCVictoryConditionDiplomacy
	{
		@NOSELECTION = -1,
		@Off = 0,
		@On = 1
	}
	
	public enum DCVictoryConditionIncome
	{
		@NOSELECTION = -1,
		@None = 0,
		@Easy = 1,
		@Medium = 2,
		@Hard = 3
	}
	
	public enum DCVictoryConditionInvestors
	{
		@NOSELECTION = -1,
		@None = 0,
		@Easy = 1,
		@Medium = 2,
		@Hard = 3
	}
	
	public enum DCVictoryConditionMonuments
	{
		@NOSELECTION = -1,
		@None = 0,
		@Easy = 1,
		@Medium = 2,
		@Hard = 3
	}
	
	public enum DCVictoryConditionPopulation
	{
		@NOSELECTION = -1,
		@None = 0,
		@Easy = 1,
		@Medium = 2,
		@Hard = 3
	}
	
	public enum DCVictoryConditionWealth
	{
		@NOSELECTION = -1,
		@None = 0,
		@Easy = 1,
		@Medium = 2,
		@Hard = 3
	}
	
	public enum DifficultyButtonType
	{
		@NOSELECTION = -1,
		@Header = 0,
		@Empty = 1,
		@Choice = 2,
		@Toggle = 3,
		@MapCode = 4,
		@LoadSettings = 5
	}
	
	public enum DifficultyCategory
	{
		@NOSELECTION = -1,
		@ConstructionCostRefund = 0,
		@DistributionWorkforce = 1,
		@Fertility = 2,
		@HostileTakeover = 3,
		@InactiveCosts = 4,
		@Incidents = 5,
		@LossCondition = 6,
		@OptionalQuestFrequency = 7,
		@OptionalQuestRewards = 8,
		@OptionalQuestTimeout = 9,
		@ThirdParty = 10,
		@RawMaterial = 11,
		@RelocateBuildings = 12,
		@RevealedMap = 13,
		@Revenue = 14,
		@StartCredits = 15,
		@StartSession = 16,
		@StartSessionIslandDifficulty = 17,
		@StartSessionIslandSize = 18,
		@StartShips = 19,
		@StartWithKontor = 20,
		@TraderRefillRate = 21,
		@VictoryConditionMonuments = 22,
		@VictoryConditionInvestors = 23,
		@VictoryConditionPopulation = 24,
		@VictoryConditionWealth = 25,
		@VictoryConditionIncome = 26,
		@VictoryConditionAllOrOne = 27,
		@VictoryConditionDiplomacy = 28,
		@MapType = 29,
		@DifficultyPreset = 30,
		@Influence = 31
	}
	
	public enum DifficultyPageType
	{
		@NOSELECTION = -1,
		@SecondPartyPage = 0,
		@ThirdPartyPage = 1,
		@OptionPage = 2
	}
	
	public enum BuildingBlockType
	{
		@NOSELECTION = -1,
		@DontCare = 0,
		@Corner = 1,
		@Mid = 2,
		@TCrossing = 3,
		@Crossing = 4,
		@End = 5,
		@Single = 6
	}
	
	public enum CampaignBehaviour
	{
		@NOSELECTION = -1,
		@DestructRuin = 0
	}
	
	public enum DraggableType
	{
		@NOSELECTION = -1,
		@Ship = 0,
		@Drone = 1
	}
	
	public enum FarmType
	{
		@NOSELECTION = -1,
		@NoFarm = 0,
		@PlantFarm = 1,
		@AnimalFarm = 2
	}
	
	public enum MinistryDecreeTier
	{
		@NOSELECTION = -1,
		@Tier1Decree = 0,
		@Tier2Decree = 1,
		@Tier3Decree = 2,
		@Tier4Decree = 3,
		@Tier5Decree = 4
	}
	
	public enum ObjectPositionType
	{
		@NOSELECTION = -1,
		@Static = 0,
		@Dynamic = 1,
		@Unmanaged = 2
	}
	
	public enum ObjectType
	{
		@NOSELECTION = -1,
		@GameObject = 0,
		@FeedbackObject = 1,
		@NaturePreset = 2,
		@Nature = 3,
		@EditorObject = 4,
		@NotSerialized = 5,
		@Prop = 6
	}
	
	public enum PalaceMinistryType
	{
		@NOSELECTION = -1,
		@City = 0,
		@Culture = 1,
		@Productivity = 2,
		@Service = 3,
		@Harbor = 4
	}
	
	public enum ShootingTracking
	{
		@NOSELECTION = -1,
		@Side = 0,
		@Front = 1,
		@TurretFixed = 2
	}
	
	public enum SkinTrackingType
	{
		@NOSELECTION = -1,
		@ShipSkin = 0,
		@TrainSkin = 1,
		@BuildingSkin = 2,
		@OrnamentSkin = 3
	}
	
	public enum StreetNeighborAdaptGroup
	{
		@NOSELECTION = -1,
		@Street = 0,
		@StreetLowQuality = 1,
		@StreetHighQuality = 2,
		@Crossing_Rail_Street = 3,
		@Crossing_Rail_StreetLowQuality = 4,
		@Crossing_Rail_StreetHighQuality = 5,
		@Rail_And_RailUnderBuilding = 6,
		@Quay_And_QuaySpecial = 7,
		@Quay_And_QuayBase_And_HiddenFences = 8,
		@FenceBasePlate_And_HiddenFences = 9,
		@Bridge_StreetLowQuality = 10,
		@Bridge_Rail = 11,
		@Bridge_StreetHighQuality = 12,
		@Canal = 13,
		@QuayStreet = 14
	}
	
	public enum TrailerType
	{
		@NOSELECTION = -1,
		@Coach = 0,
		@TrainStatic = 1,
		@TrainDynamic = 2
	}
	
	public enum TreasureTypeVisibility
	{
		@NOSELECTION = -1,
		@Always = 0,
		@OnlyForDivingBellShip = 1
	}
	
	public enum UniqueScope
	{
		@NOSELECTION = -1,
		@None = 0,
		@Area = 1,
		@Session = 2,
		@Game = 3
	}
	
	public enum UniqueType
	{
		@NOSELECTION = -1,
		@None = 0,
		@VisitorHarbor = 1,
		@Monument01 = 2,
		@Headquarter = 3,
		@CoalHarbor = 4,
		@OilHarbor = 5,
		@WorkforceConnector = 6,
		@Palace = 7,
		@PalaceMinistry = 8,
		@ResearchCenter = 9,
		@Dockland = 10,
		@TourismMonument = 11
	}
	
	public enum CurveSegmentDensity
	{
		@NOSELECTION = -1,
		@Low = 0,
		@Medium = 1,
		@High = 2
	}
	
	public enum PathPlannerLayer
	{
		@NOSELECTION = -1,
		@Land = 0,
		@Street = 1,
		@Water = 2,
		@Air = 3,
		@Feedback = 4,
		@Railway = 5,
		@Animal = 6,
		@FeedbackWater = 7
	}
	
	public enum PathPlannerTopology
	{
		@NOSELECTION = -1,
		@QuadTree = 0,
		@Grid = 1,
		@SparseGrid = 2
	}
	
	public enum SpecialMovementType
	{
		@NOSELECTION = -1,
		@AirConstantHeight = 0,
		@AirVerticalLanding = 1
	}
	
	public enum UniqueShipType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Flagship = 1,
		@DivingBellShip = 2,
		@GreatEastern = 3
	}
	
	public enum ArmorType
	{
		@NOSELECTION = -1,
		@Default = 0,
		@Explosive = 1,
		@HeavyArmor = 2
	}
	
	public enum TakeOverEffect
	{
		@NOSELECTION = -1,
		@Never = 0,
		@OnDeath = 1,
		@OnHit = 2
	}
	
	public enum TakeOverTier
	{
		@NOSELECTION = -1,
		@Tier01 = 0,
		@Tier02 = 1,
		@Tier03 = 2,
		@Tier04 = 3
	}
	
	public enum TakeOverTransformation
	{
		@NOSELECTION = -1,
		@Destroy = 0,
		@RuinState = 1,
		@Copy = 2,
		@DontTouch = 3
	}
	
	public enum CollectableType
	{
		@NOSELECTION = -1,
		@WaterCollectable = 0,
		@LandCollectable = 1
	}
	
	public enum IslandDifficulty
	{
		@NOSELECTION = -1,
		@Normal = 0,
		@Hard = 1
	}
	
	public enum IslandForcedRotation
	{
		@NOSELECTION = -1,
		@DontCare = 0,
		@_0 = 1,
		@_90 = 2,
		@_180 = 3,
		@_270 = 4
	}
	
	public enum IslandGameType
	{
		@NOSELECTION = -1,
		@SandboxSingleplayer = 0,
		@SandboxMultilayer = 1,
		@CampaignMode = 2
	}
	
	public enum IslandSize
	{
		@NOSELECTION = -1,
		@Small = 0,
		@Medium = 1,
		@Large = 2
	}
	
	public enum IslandType
	{
		@NOSELECTION = -1,
		@Normal = 0,
		@Starter = 1,
		@Decoration = 2,
		@ThirdParty = 3,
		@PirateIsland = 4,
		@CliffIsland = 5
	}
	
	public enum MapTemplateSize
	{
		@NOSELECTION = -1,
		@Small = 0,
		@Medium = 1,
		@Large = 2
	}
	
	public enum MapTemplateType
	{
		@NOSELECTION = -1,
		@Random = 0,
		@Archipelago = 1,
		@Atoll = 2,
		@Arc = 3,
		@Corners = 4,
		@Snowflake = 5
	}
	
	public enum ResourceAmount
	{
		@NOSELECTION = -1,
		@Low = 0,
		@Medium = 1,
		@High = 2
	}
	
	public enum JiraFeedbackTopic
	{
		@NOSELECTION = -1,
		@Gameplay = 0,
		@AI = 1,
		@Audio = 2,
		@Graphics = 3,
		@Controls = 4,
		@Leveldesign = 5,
		@Multiplayer = 6,
		@UI = 7,
		@Other = 8
	}
	
	public enum JiraFeedbackType
	{
		@NOSELECTION = -1,
		@Feedback = 0,
		@Bug = 1,
		@Improvement = 2
	}
	
	public enum FreeAreaType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Lumberjack = 1,
		@Hunter = 2,
		@Hunter2 = 3,
		@Coconut = 4,
		@Camphor = 5,
		@Citrus = 6,
		@LeafTrees = 7,
		@FirTrees = 8
	}
	
	public enum IndustrializationType
	{
		@NOSELECTION = -1,
		@Powerplant = 0
	}
	
	public enum MotorizableType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Tractor = 1,
		@Silo = 2
	}
	
	public enum ResidentSatisfactionCalculation
	{
		@NOSELECTION = -1,
		@Linear = 0,
		@LoweredQuadratic = 1,
		@Quadratic = 2
	}
	
	public enum StorageLevel
	{
		@NOSELECTION = -1,
		@Meta = 0,
		@Area = 1,
		@Building = 2
	}
	
	public enum StorageType
	{
		@NOSELECTION = -1,
		@Kontor = 0,
		@Warehouse = 1,
		@Depot = 2
	}
	
	public enum EventSettingNotifications
	{
		@NOSELECTION = -1,
		@ExhibitionFinshed = 0,
		@SpecialistArrived = 1,
		@MajorDiscovery = 2
	}
	
	public enum EventSettingOptions
	{
		@NOSELECTION = -1,
		@CharacterNotificationAndArchive = 0,
		@SideNotificationAndArchive = 1
	}
	
	public enum NotificationCallbackType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Corporation = 1,
		@Construction = 2
	}
	
	public enum NotificationGroup
	{
		@NOSELECTION = -1,
		@None = 0,
		@IncidentFire = 1,
		@IncidentRiot = 2,
		@IncidentIllness = 3,
		@Visitors = 4,
		@PlayerClick = 5,
		@Festival = 6,
		@PaMSyGossip = 7
	}
	
	public enum NotificationType
	{
		@NOSELECTION = -1,
		@Character = 0,
		@Main = 1,
		@Side = 2,
		@OnScreenText = 3,
		@Campaign = 4,
		@Attractiveness = 5,
		@Palace = 6
	}
	
	public enum SideNotificationCategory
	{
		@NOSELECTION = -1,
		@General = 0,
		@Warning = 1,
		@Newspaper = 2,
		@Expedition = 3,
		@Military = 4,
		@Event = 5
	}
	
	public enum SideNotificationFilter
	{
		@NOSELECTION = -1,
		@None = 0,
		@System = 1,
		@Progress = 2,
		@Railway = 3,
		@Trade = 4,
		@TradeRouteWarning = 5,
		@TradeRouteError = 6,
		@Items = 7,
		@Incidents = 8,
		@VisitorsAndCulture = 9,
		@DiplomaticRelations = 10,
		@Military = 11,
		@HostileTakeover = 12,
		@Heating = 13
	}
	
	public enum ArticleEffect
	{
		@NOSELECTION = -1,
		@None = 0,
		@HappinessGlobal = 1,
		@HappinessPopulation = 2,
		@Income = 3,
		@NeedConsumption = 4,
		@FireChanceGlobal = 5,
		@RiotChanceGlobal = 6,
		@RiotChancePopulation = 7,
		@IllnessChanceGlobal = 8,
		@ExplosionChanceGlobal = 9,
		@NeighbourWatch = 10,
		@FireRate = 11,
		@NoSurrender = 12,
		@WarPreparation = 13,
		@Workforce = 14,
		@Productivity = 15,
		@Anarchy = 16
	}
	
	public enum ArticleEffectColor
	{
		@NOSELECTION = -1,
		@DeepRed = 0,
		@LightRed = 1,
		@Yellow = 2,
		@LightGreen = 3,
		@DeepGreen = 4
	}
	
	public enum ArticleEffectStrength
	{
		@NOSELECTION = -1,
		@Light = 0,
		@Medium = 1,
		@Strong = 2
	}
	
	public enum ArticleRating
	{
		@NOSELECTION = -1,
		@Good = 0,
		@Neutral = 1,
		@Bad = 2
	}
	
	public enum ArticleSize
	{
		@NOSELECTION = -1,
		@Small = 0,
		@Medium = 1,
		@Big = 2
	}
	
	public enum ArticleTriggerFilter
	{
		@NOSELECTION = -1,
		@Always = 0,
		@OncePerArea = 1,
		@Once = 2
	}
	
	public enum ArticleType
	{
		@NOSELECTION = -1,
		@Gameplay = 0,
		@Filler = 1,
		@Propaganda = 2
	}
	
	public enum NewsCategory
	{
		@NOSELECTION = -1,
		@None = 0,
		@Satisfaction = 1,
		@Economy = 2,
		@Special = 3,
		@Filler = 4,
		@Progress = 5,
		@Beautification = 6,
		@Monument = 7,
		@VictoryAndLose = 8,
		@HostileTakeover = 9,
		@Diplomacy = 10,
		@Military = 11,
		@Expeditions = 12,
		@Visitors = 13,
		@CityAttractiveness = 14,
		@Quests = 15
	}
	
	public enum NewsTrackerScope
	{
		@NOSELECTION = -1,
		@Area = 0,
		@Global = 1
	}
	
	public enum NewsTrackerType
	{
		@NOSELECTION = -1,
		@UnlockTracker = 0,
		@ObjectBuildNewsTracker = 1,
		@VisitorNewsTracker = 2,
		@OverallSatisfactionNewsTracker = 3,
		@NeedsSatisfactionNewsTracker = 4,
		@IncomeBalanceNewsTracker = 5,
		@IncidentNewsTracker = 6,
		@MonumentNewsTracker = 7,
		@IslandSettledNewsTracker = 8,
		@ShipBuiltNewsTracker = 9,
		@WorkforceNewsTracker = 10,
		@WorkforceSliderNewsTracker = 11,
		@DiplomacyNewsTracker = 12,
		@QuestNewsTracker = 13,
		@MilitaryNewsTracker = 14,
		@HostileTakeoverNewsTracker = 15,
		@CityAttractivenessNewsTracker = 16
	}
	
	public enum Channel
	{
		@NOSELECTION = -1,
		@All = 0,
		@Team = 1,
		@Coop = 2,
		@Whisper = 3
	}
	
	public enum GameType
	{
		@NOSELECTION = -1,
		@Sandbox = 0,
		@Campaign = 1
	}
	
	public enum HappyDayEvent
	{
		@NOSELECTION = -1,
		@ChristmanSeason = 0,
		@HolyNight = 1,
		@NewYears = 2,
		@Easter = 3,
		@StPatricksDay = 4,
		@EarthDay = 5,
		@Halloween = 6,
		@NewYearsEve = 7,
		@Christmas = 8,
		@SkyDay = 9
	}
	
	public enum MPCoopPeer
	{
		@NOSELECTION = -1,
		@Peer1 = 0,
		@Peer2 = 1,
		@Peer3 = 2,
		@Peer4 = 3
	}
	
	public enum MPSlot
	{
		@NOSELECTION = -1,
		@Slot1 = 0,
		@Slot2 = 1,
		@Slot3 = 2,
		@Slot4 = 3
	}
	
	public enum ParticipantType
	{
		@NOSELECTION = -1,
		@None = 0,
		@Human = 1,
		@AI = 2
	}
	
	public enum Peer
	{
		@NOSELECTION = -1,
		@Slot1 = 0,
		@Slot2 = 1,
		@Slot3 = 2,
		@Slot4 = 3,
		@Slot5 = 4,
		@Slot6 = 5,
		@Slot7 = 6,
		@Slot8 = 7,
		@Slot9 = 8,
		@Slot10 = 9,
		@Slot11 = 10,
		@Slot12 = 11,
		@Slot13 = 12,
		@Slot14 = 13,
		@Slot15 = 14,
		@Slot16 = 15
	}
	
	public enum PlayerPossessions
	{
		@NOSELECTION = -1,
		@PreorderShip = 0,
		@PreorderRailway = 1
	}
	
	public enum QuickMatchType
	{
		@NOSELECTION = -1,
		@QuickMatch1 = 0,
		@QuickMatch2 = 1,
		@QuickMatch3 = 2,
		@QuickMatchAny = 3
	}
	
	public enum Team
	{
		@NOSELECTION = -1,
		@Team1 = 0,
		@Team2 = 1,
		@Team3 = 2,
		@Team4 = 3
	}
	
	public enum AIAvenueOrnamentalRotation
	{
		@NOSELECTION = -1,
		@Random = 0,
		@_0_Or_180 = 1,
		@_90_Or_270 = 2,
		@_0 = 3,
		@_90 = 4,
		@_180 = 5,
		@_270 = 6
	}
	
	public enum AIBlockLayoutTypes
	{
		@NOSELECTION = -1,
		@City = 0,
		@Production = 1,
		@Culture = 2,
		@Misc = 3
	}
	
	public enum AIBudgets
	{
		@NOSELECTION = -1,
		@Construction = 0,
		@Military = 1,
		@ActiveTrade = 2,
		@Shares = 3
	}
	
	public enum AIBuildableTypes
	{
		@NOSELECTION = -1,
		@CoastPoints = 0,
		@FromGrid = 1
	}
	
	public enum AICityBlockTypes
	{
		@NOSELECTION = -1,
		@SingleRow = 0,
		@DoubleRow = 1,
		@DoubleRowAvenue = 2,
		@ShapeO = 3,
		@ShapeH = 4,
		@ShapeU = 5,
		@ShapeL = 6,
		@StreetsInCorners = 7,
		@SquarePublic = 8,
		@INTERNAL_PureOrnamental = 9,
		@INTERNAL_Fallback = 10
	}
	
	public enum AIFreeformInnerRatioType
	{
		@NOSELECTION = -1,
		@Blocked = 0,
		@Unused = 1
	}
	
	public enum AIOrnamentalArea
	{
		@NOSELECTION = -1,
		@Production = 0,
		@City = 1,
		@Cultural = 2,
		@RailroadHiding = 3
	}
	
	public enum AIPlacementScoreTypes
	{
		@NOSELECTION = -1,
		@CulturalCompound = 0,
		@CulturalModule = 1,
		@CityResidence = 2,
		@CityResidenceUpgrade = 3,
		@CityResidenceMove = 4,
		@CityPublic = 5,
		@CityTownhall = 6,
		@HarborCoastal = 7,
		@HarborCoastalElectricityNeeder = 8,
		@HarborDefenseCoastal = 9,
		@HarborWater = 10,
		@HarborDefenseWater = 11,
		@HarborOffice = 12,
		@HarborOil = 13,
		@ProductionFarmCompound = 14,
		@ProductionFarmModule = 15,
		@ProductionFarmFreeform = 16,
		@ProductionSimple = 17,
		@ProductionSimpleElectricityNeeder = 18,
		@ProductionGuildMaster = 19,
		@ProductionFreeAreaProductivity = 20,
		@ProductionSimpleWithinFreeAreaProductivityBlock = 21,
		@BlockProductionFreeformFarm = 22,
		@BlockProductionDefault = 23,
		@BlockProductionGuildmaster = 24,
		@BlockProductionPowerPlant = 25,
		@BlockProductionElectricityNeeder = 26,
		@BlockCityPowerPlant = 27,
		@BlockCityResidence = 28,
		@BlockCityPublic = 29,
		@BlockCityPublicNeedPipe = 30,
		@BlockCityTownhall = 31,
		@BlockCityMarketplace = 32,
		@BlockCityFirst = 33,
		@BlockCityScholars = 34,
		@BlockCultural = 35,
		@BlockWarehouse = 36,
		@BlockAirshipHangar = 37,
		@BlockResearchCenter = 38,
		@BlockHeatProvider = 39,
		@ProductionLure = 40
	}
	
	public enum AIRatingDistanceMetric
	{
		@NOSELECTION = -1,
		@Default_StaticAbsoluteValue = 0,
		@PowerPlantRangePercentage = 1
	}
	
	public enum AIRatingDistanceTargets
	{
		@NOSELECTION = -1,
		@CityCenter = 0,
		@Kontor = 1,
		@ReferencePos = 2,
		@Coast = 3,
		@StaticBlocker_Coarse = 4,
		@Warehouse = 5,
		@City = 6,
		@ProductionLure = 7,
		@HarborDefense = 8,
		@PowerPlant = 9,
		@RailwayBuilding = 10,
		@HeaterBuilding = 11,
		@UpgradeCenter = 12
	}
	
	public enum AIRatingStateCategories
	{
		@NOSELECTION = -1,
		@Streets = 0,
		@Railway = 1,
		@Pipe = 2,
		@Buildings = 3,
		@Preview = 4,
		@StaticBlockedLand = 5,
		@Quay = 6,
		@Shippath = 7,
		@Basin = 8,
		@UnusedWithinBlock = 9
	}
	
	public enum AIRatingSubRects
	{
		@NOSELECTION = -1,
		@Shippath = 0,
		@Basin = 1,
		@CompoundMain = 2,
		@CompoundModules = 3,
		@This = 4,
		@AdditionalStreet = 5
	}
	
	public enum AISessionRole
	{
		@NOSELECTION = -1,
		@Main = 0,
		@MainForRegion = 1,
		@Other = 2
	}
	
	public enum AISharePriorities
	{
		@NOSELECTION = -1,
		@Random = 0,
		@OwnShare = 1,
		@CurrentlyNeeded = 2,
		@LaterNeeded = 3
	}
	
	public enum AIShipPurpose
	{
		@NOSELECTION = -1,
		@TradeRoute = 0,
		@SettleMission = 1,
		@ActiveTrade = 2,
		@Military = 3,
		@Transit = 4,
		@New = 5,
		@Idle = 6,
		@Repair = 7,
		@GoodTransfer = 8
	}
	
	public enum DaytimePeriod
	{
		@NOSELECTION = -1,
		@Sunrise = 0,
		@Day = 1,
		@Sunset = 2,
		@Night = 3
	}
	
	public enum DaytimePresets
	{
		@NOSELECTION = -1,
		@Dawn = 0,
		@Day = 1,
		@Dusk = 2,
		@Night = 3
	}
	
	public enum DaytimeSetting
	{
		@NOSELECTION = -1,
		@Manual = 0,
		@Auto_Advance = 1
	}
	
	public enum FeedbackUnitNightBehavior
	{
		@NOSELECTION = -1,
		@Default = 0,
		@OnlyShowAtNight = 1,
		@OnlyShowAtDay = 2,
		@AlwaysShow = 3
	}
	
	public enum LocalFeedbackNightBehavior
	{
		@NOSELECTION = -1,
		@HideAll = 0,
		@HideRand = 1,
		@HideNone = 2
	}
	
	public enum FertilizerType
	{
		@NOSELECTION = -1,
		@Water = 0
	}
	
	public enum IrrigationLevel
	{
		@NOSELECTION = -1,
		@NoWater = 0,
		@LowWater = 1,
		@MediumWater = 2,
		@HighWater = 3,
		@FullWater = 4
	}
	
	public enum IrrigationTileType
	{
		@NOSELECTION = -1,
		@Default_None = 0,
		@Source_River = 1,
		@Source_Canal = 2,
		@Source_Lake_Small = 3,
		@Source_Lake_Medium = 4,
		@Source_Lake_Large = 5,
		@Source_LevelArt = 6,
		@Source_Condition1 = 7,
		@Source_Condition2 = 8,
		@Source_Condition3 = 9
	}
	
	public enum WaterSpreadRule
	{
		@NOSELECTION = -1,
		@MaxAbsDist = 0,
		@EulerDist = 1,
		@ManhattanDist = 2
	}
	
	public enum GodlikeCategory
	{
		@NOSELECTION = -1,
		@Nature = 0,
		@Concept = 1,
		@Production = 2
	}
	
	public enum GodlikeType
	{
		@NOSELECTION = -1,
		@MoveClay = 0,
		@MoveOil = 1,
		@ChangeMine = 2,
		@ChangeFertility = 3,
		@GreatEasternPermit = 4,
		@HighTechPierPermit = 5,
		@ProductionBuildingPermit = 6,
		@ResearchKit = 7,
		@ScholarPermit = 8
	}
	
	public enum ResearchFields
	{
		@NOSELECTION = -1,
		@Culture = 0,
		@Technology = 1,
		@Talent = 2
	}
	
	public enum ExportLevel
	{
		@NOSELECTION = -1,
		@Common = 0,
		@Uncommon = 1,
		@Rare = 2,
		@Epic = 3,
		@Legendary = 4
	}
	
}
