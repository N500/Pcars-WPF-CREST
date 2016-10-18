Imports Newtonsoft.Json
Imports Pcars_WPF.Example.SampleResponse1JsonTypes

Namespace Example.SampleResponse1JsonTypes

    Public Class Buildinfo

        <JsonProperty("mVersion")>
        Public Property MVersion() As Integer
            Get
                Return m_MVersion
            End Get
            Set
                m_MVersion = Value
            End Set
        End Property
        Private m_MVersion As Integer

        <JsonProperty("mBuildVersionNumber")>
        Public Property MBuildVersionNumber() As Integer
            Get
                Return m_MBuildVersionNumber
            End Get
            Set
                m_MBuildVersionNumber = Value
            End Set
        End Property
        Private m_MBuildVersionNumber As Integer
    End Class

    Friend Class GameStates

        <JsonProperty("mGameState")>
        Public Property MGameState() As Integer
            Get
                Return m_MGameState
            End Get
            Set
                m_MGameState = Value
            End Set
        End Property
        Private m_MGameState As Integer

        <JsonProperty("mSessionState")>
        Public Property MSessionState() As Integer
            Get
                Return m_MSessionState
            End Get
            Set
                m_MSessionState = Value
            End Set
        End Property
        Private m_MSessionState As Integer

        <JsonProperty("mRaceState")>
        Public Property MRaceState() As Integer
            Get
                Return m_MRaceState
            End Get
            Set
                m_MRaceState = Value
            End Set
        End Property
        Private m_MRaceState As Integer
    End Class

    Friend Class MParticipantInfo

        <JsonProperty("mIsActive")>
        Public Property MIsActive() As Boolean
            Get
                Return m_MIsActive
            End Get
            Set
                m_MIsActive = Value
            End Set
        End Property
        Private m_MIsActive As Boolean

        <JsonProperty("mName")>
        Public Property MName() As String
            Get
                Return m_MName
            End Get
            Set
                m_MName = Value
            End Set
        End Property
        Private m_MName As String

        <JsonProperty("mWorldPosition")>
        Public Property MWorldPosition() As Double()
            Get
                Return m_MWorldPosition
            End Get
            Set
                m_MWorldPosition = Value
            End Set
        End Property
        Private m_MWorldPosition As Double()

        <JsonProperty("mCurrentLapDistance")>
        Public Property MCurrentLapDistance() As Double
            Get
                Return m_MCurrentLapDistance
            End Get
            Set
                m_MCurrentLapDistance = Value
            End Set
        End Property
        Private m_MCurrentLapDistance As Double

        <JsonProperty("mRacePosition")>
        Public Property MRacePosition() As Integer
            Get
                Return m_MRacePosition
            End Get
            Set
                m_MRacePosition = Value
            End Set
        End Property
        Private m_MRacePosition As Integer

        <JsonProperty("mLapsCompleted")>
        Public Property MLapsCompleted() As Integer
            Get
                Return m_MLapsCompleted
            End Get
            Set
                m_MLapsCompleted = Value
            End Set
        End Property
        Private m_MLapsCompleted As Integer

        <JsonProperty("mCurrentLap")>
        Public Property MCurrentLap() As Integer
            Get
                Return m_MCurrentLap
            End Get
            Set
                m_MCurrentLap = Value
            End Set
        End Property
        Private m_MCurrentLap As Integer

        <JsonProperty("mCurrentSector")>
        Public Property MCurrentSector() As Integer
            Get
                Return m_MCurrentSector
            End Get
            Set
                m_MCurrentSector = Value
            End Set
        End Property
        Private m_MCurrentSector As Integer
    End Class

    Friend Class Participants

        <JsonProperty("mViewedParticipantIndex")>
        Public Property MViewedParticipantIndex() As Integer
            Get
                Return m_MViewedParticipantIndex
            End Get
            Set
                m_MViewedParticipantIndex = Value
            End Set
        End Property
        Private m_MViewedParticipantIndex As Integer

        <JsonProperty("mNumParticipants")>
        Public Property MNumParticipants() As Integer
            Get
                Return m_MNumParticipants
            End Get
            Set
                m_MNumParticipants = Value
            End Set
        End Property
        Private m_MNumParticipants As Integer

        <JsonProperty("mParticipantInfo")>
        Public Property MParticipantInfo() As MParticipantInfo()
            Get
                Return m_MParticipantInfo
            End Get
            Set
                m_MParticipantInfo = Value
            End Set
        End Property
        Private m_MParticipantInfo As MParticipantInfo()
    End Class

    Friend Class UnfilteredInput

        <JsonProperty("mUnfilteredThrottle")>
        Public Property MUnfilteredThrottle() As Single
            Get
                Return m_MUnfilteredThrottle
            End Get
            Set
                m_MUnfilteredThrottle = Value
            End Set
        End Property
        Private m_MUnfilteredThrottle As Single

        <JsonProperty("mUnfilteredBrake")>
        Public Property MUnfilteredBrake() As Single
            Get
                Return m_MUnfilteredBrake
            End Get
            Set
                m_MUnfilteredBrake = Value
            End Set
        End Property
        Private m_MUnfilteredBrake As Single

        <JsonProperty("mUnfilteredSteering")>
        Public Property MUnfilteredSteering() As Single
            Get
                Return m_MUnfilteredSteering
            End Get
            Set
                m_MUnfilteredSteering = Value
            End Set
        End Property
        Private m_MUnfilteredSteering As Single

        <JsonProperty("mUnfilteredClutch")>
        Public Property MUnfilteredClutch() As Single
            Get
                Return m_MUnfilteredClutch
            End Get
            Set
                m_MUnfilteredClutch = Value
            End Set
        End Property
        Private m_MUnfilteredClutch As Single
    End Class

    Friend Class VehicleInformation

        <JsonProperty("mCarName")>
        Public Property MCarName() As String
            Get
                Return m_MCarName
            End Get
            Set
                m_MCarName = Value
            End Set
        End Property
        Private m_MCarName As String

        <JsonProperty("mCarClassName")>
        Public Property MCarClassName() As String
            Get
                Return m_MCarClassName
            End Get
            Set
                m_MCarClassName = Value
            End Set
        End Property
        Private m_MCarClassName As String
    End Class

    Friend Class EventInformation

        <JsonProperty("mLapsInEvent")>
        Public Property MLapsInEvent() As Integer
            Get
                Return m_MLapsInEvent
            End Get
            Set
                m_MLapsInEvent = Value
            End Set
        End Property
        Private m_MLapsInEvent As Integer

        <JsonProperty("mTrackLocation")>
        Public Property MTrackLocation() As String
            Get
                Return m_MTrackLocation
            End Get
            Set
                m_MTrackLocation = Value
            End Set
        End Property
        Private m_MTrackLocation As String

        <JsonProperty("mTrackVariation")>
        Public Property MTrackVariation() As String
            Get
                Return m_MTrackVariation
            End Get
            Set
                m_MTrackVariation = Value
            End Set
        End Property
        Private m_MTrackVariation As String

        <JsonProperty("mTrackLength")>
        Public Property MTrackLength() As Double
            Get
                Return m_MTrackLength
            End Get
            Set
                m_MTrackLength = Value
            End Set
        End Property
        Private m_MTrackLength As Double
    End Class

    Friend Class Timings

        <JsonProperty("mLapInvalidated")>
        Public Property MLapInvalidated() As Boolean
            Get
                Return m_MLapInvalidated
            End Get
            Set
                m_MLapInvalidated = Value
            End Set
        End Property
        Private m_MLapInvalidated As Boolean

        <JsonProperty("mBestLapTime")>
        Public Property MBestLapTime() As Integer
            Get
                Return m_MBestLapTime
            End Get
            Set
                m_MBestLapTime = Value
            End Set
        End Property
        Private m_MBestLapTime As Integer

        <JsonProperty("mLastLapTime")>
        Public Property MLastLapTime() As Integer
            Get
                Return m_MLastLapTime
            End Get
            Set
                m_MLastLapTime = Value
            End Set
        End Property
        Private m_MLastLapTime As Integer

        <JsonProperty("mCurrentTime")>
        Public Property MCurrentTime() As Double
            Get
                Return m_MCurrentTime
            End Get
            Set
                m_MCurrentTime = Value
            End Set
        End Property
        Private m_MCurrentTime As Double

        <JsonProperty("mSplitTimeAhead")>
        Public Property MSplitTimeAhead() As Double
            Get
                Return m_MSplitTimeAhead
            End Get
            Set
                m_MSplitTimeAhead = Value
            End Set
        End Property
        Private m_MSplitTimeAhead As Double

        <JsonProperty("mSplitTimeBehind")>
        Public Property MSplitTimeBehind() As Double
            Get
                Return m_MSplitTimeBehind
            End Get
            Set
                m_MSplitTimeBehind = Value
            End Set
        End Property
        Private m_MSplitTimeBehind As Double

        <JsonProperty("mSplitTime")>
        Public Property MSplitTime() As Integer
            Get
                Return m_MSplitTime
            End Get
            Set
                m_MSplitTime = Value
            End Set
        End Property
        Private m_MSplitTime As Integer

        <JsonProperty("mEventTimeRemaining")>
        Public Property MEventTimeRemaining() As Integer
            Get
                Return m_MEventTimeRemaining
            End Get
            Set
                m_MEventTimeRemaining = Value
            End Set
        End Property
        Private m_MEventTimeRemaining As Integer

        <JsonProperty("mPersonalFastestLapTime")>
        Public Property MPersonalFastestLapTime() As Integer
            Get
                Return m_MPersonalFastestLapTime
            End Get
            Set
                m_MPersonalFastestLapTime = Value
            End Set
        End Property
        Private m_MPersonalFastestLapTime As Integer

        <JsonProperty("mWorldFastestLapTime")>
        Public Property MWorldFastestLapTime() As Double
            Get
                Return m_MWorldFastestLapTime
            End Get
            Set
                m_MWorldFastestLapTime = Value
            End Set
        End Property
        Private m_MWorldFastestLapTime As Double

        <JsonProperty("mCurrentSector1Time")>
        Public Property MCurrentSector1Time() As Integer
            Get
                Return m_MCurrentSector1Time
            End Get
            Set
                m_MCurrentSector1Time = Value
            End Set
        End Property
        Private m_MCurrentSector1Time As Integer

        <JsonProperty("mCurrentSector2Time")>
        Public Property MCurrentSector2Time() As Integer
            Get
                Return m_MCurrentSector2Time
            End Get
            Set
                m_MCurrentSector2Time = Value
            End Set
        End Property
        Private m_MCurrentSector2Time As Integer

        <JsonProperty("mCurrentSector3Time")>
        Public Property MCurrentSector3Time() As Integer
            Get
                Return m_MCurrentSector3Time
            End Get
            Set
                m_MCurrentSector3Time = Value
            End Set
        End Property
        Private m_MCurrentSector3Time As Integer

        <JsonProperty("mFastestSector1Time")>
        Public Property MFastestSector1Time() As Integer
            Get
                Return m_MFastestSector1Time
            End Get
            Set
                m_MFastestSector1Time = Value
            End Set
        End Property
        Private m_MFastestSector1Time As Integer

        <JsonProperty("mFastestSector2Time")>
        Public Property MFastestSector2Time() As Integer
            Get
                Return m_MFastestSector2Time
            End Get
            Set
                m_MFastestSector2Time = Value
            End Set
        End Property
        Private m_MFastestSector2Time As Integer

        <JsonProperty("mFastestSector3Time")>
        Public Property MFastestSector3Time() As Integer
            Get
                Return m_MFastestSector3Time
            End Get
            Set
                m_MFastestSector3Time = Value
            End Set
        End Property
        Private m_MFastestSector3Time As Integer

        <JsonProperty("mPersonalFastestSector1Time")>
        Public Property MPersonalFastestSector1Time() As Integer
            Get
                Return m_MPersonalFastestSector1Time
            End Get
            Set
                m_MPersonalFastestSector1Time = Value
            End Set
        End Property
        Private m_MPersonalFastestSector1Time As Integer

        <JsonProperty("mPersonalFastestSector2Time")>
        Public Property MPersonalFastestSector2Time() As Integer
            Get
                Return m_MPersonalFastestSector2Time
            End Get
            Set
                m_MPersonalFastestSector2Time = Value
            End Set
        End Property
        Private m_MPersonalFastestSector2Time As Integer

        <JsonProperty("mPersonalFastestSector3Time")>
        Public Property MPersonalFastestSector3Time() As Integer
            Get
                Return m_MPersonalFastestSector3Time
            End Get
            Set
                m_MPersonalFastestSector3Time = Value
            End Set
        End Property
        Private m_MPersonalFastestSector3Time As Integer

        <JsonProperty("mWorldFastestSector1Time")>
        Public Property MWorldFastestSector1Time() As Double
            Get
                Return m_MWorldFastestSector1Time
            End Get
            Set
                m_MWorldFastestSector1Time = Value
            End Set
        End Property
        Private m_MWorldFastestSector1Time As Double

        <JsonProperty("mWorldFastestSector2Time")>
        Public Property MWorldFastestSector2Time() As Double
            Get
                Return m_MWorldFastestSector2Time
            End Get
            Set
                m_MWorldFastestSector2Time = Value
            End Set
        End Property
        Private m_MWorldFastestSector2Time As Double

        <JsonProperty("mWorldFastestSector3Time")>
        Public Property MWorldFastestSector3Time() As Double
            Get
                Return m_MWorldFastestSector3Time
            End Get
            Set
                m_MWorldFastestSector3Time = Value
            End Set
        End Property
        Private m_MWorldFastestSector3Time As Double
    End Class

    Friend Class Flags

        <JsonProperty("mHighestFlagColour")>
        Public Property MHighestFlagColour() As Integer
            Get
                Return m_MHighestFlagColour
            End Get
            Set
                m_MHighestFlagColour = Value
            End Set
        End Property
        Private m_MHighestFlagColour As Integer

        <JsonProperty("mHighestFlagReason")>
        Public Property MHighestFlagReason() As Integer
            Get
                Return m_MHighestFlagReason
            End Get
            Set
                m_MHighestFlagReason = Value
            End Set
        End Property
        Private m_MHighestFlagReason As Integer
    End Class

    Friend Class PitInfo

        <JsonProperty("mPitMode")>
        Public Property MPitMode() As Integer
            Get
                Return m_MPitMode
            End Get
            Set
                m_MPitMode = Value
            End Set
        End Property
        Private m_MPitMode As Integer

        <JsonProperty("mPitSchedule")>
        Public Property MPitSchedule() As Integer
            Get
                Return m_MPitSchedule
            End Get
            Set
                m_MPitSchedule = Value
            End Set
        End Property
        Private m_MPitSchedule As Integer
    End Class

    Friend Class CarState

        <JsonProperty("mCarFlags")>
        Public Property MCarFlags() As Integer
            Get
                Return m_MCarFlags
            End Get
            Set
                m_MCarFlags = Value
            End Set
        End Property
        Private m_MCarFlags As Integer

        <JsonProperty("mOilTempCelsius")>
        Public Property MOilTempCelsius() As Double
            Get
                Return m_MOilTempCelsius
            End Get
            Set
                m_MOilTempCelsius = Value
            End Set
        End Property
        Private m_MOilTempCelsius As Double

        <JsonProperty("mWaterTempCelsius")>
        Public Property MWaterTempCelsius() As Double
            Get
                Return m_MWaterTempCelsius
            End Get
            Set
                m_MWaterTempCelsius = Value
            End Set
        End Property
        Private m_MWaterTempCelsius As Double

        <JsonProperty("mWaterPressureKPa")>
        Public Property MWaterPressureKPa() As Double
            Get
                Return m_MWaterPressureKPa
            End Get
            Set
                m_MWaterPressureKPa = Value
            End Set
        End Property
        Private m_MWaterPressureKPa As Double

        <JsonProperty("mFuelPressureKPa")>
        Public Property MFuelPressureKPa() As Double
            Get
                Return m_MFuelPressureKPa
            End Get
            Set
                m_MFuelPressureKPa = Value
            End Set
        End Property
        Private m_MFuelPressureKPa As Double

        <JsonProperty("mFuelLevel")>
        Public Property MFuelLevel() As Double
            Get
                Return m_MFuelLevel
            End Get
            Set
                m_MFuelLevel = Value
            End Set
        End Property
        Private m_MFuelLevel As Double

        <JsonProperty("mFuelCapacity")>
        Public Property MFuelCapacity() As Integer
            Get
                Return m_MFuelCapacity
            End Get
            Set
                m_MFuelCapacity = Value
            End Set
        End Property
        Private m_MFuelCapacity As Integer

        <JsonProperty("mSpeed")>
        Public Property MSpeed() As Double
            Get
                Return m_MSpeed
            End Get
            Set
                m_MSpeed = Value
            End Set
        End Property
        Private m_MSpeed As Double

        <JsonProperty("mRpm")>
        Public Property MRpm() As Double
            Get
                Return m_MRpm
            End Get
            Set
                m_MRpm = CInt(Value)
            End Set
        End Property
        Private m_MRpm As Integer

        <JsonProperty("mMaxRPM")>
        Public Property MMaxRPM() As Integer
            Get
                Return m_MMaxRPM
            End Get
            Set
                m_MMaxRPM = Value
            End Set
        End Property
        Private m_MMaxRPM As Integer

        <JsonProperty("mBrake")>
        Public Property MBrake() As Single
            Get
                Return m_MBrake
            End Get
            Set
                m_MBrake = Value
            End Set
        End Property
        Private m_MBrake As Single

        <JsonProperty("mThrottle")>
        Public Property MThrottle() As Single
            Get
                Return m_MThrottle
            End Get
            Set
                m_MThrottle = Value
            End Set
        End Property
        Private m_MThrottle As Single

        <JsonProperty("mClutch")>
        Public Property MClutch() As Single
            Get
                Return m_MClutch
            End Get
            Set
                m_MClutch = Value
            End Set
        End Property
        Private m_MClutch As Single

        <JsonProperty("mSteering")>
        Public Property MSteering() As Double
            Get
                Return m_MSteering
            End Get
            Set
                m_MSteering = Value
            End Set
        End Property
        Private m_MSteering As Double

        <JsonProperty("mGear")>
        Public Property MGear() As Integer
            Get
                Return m_MGear
            End Get
            Set
                m_MGear = Value
            End Set
        End Property
        Private m_MGear As Integer

        <JsonProperty("mNumGears")>
        Public Property MNumGears() As Integer
            Get
                Return m_MNumGears
            End Get
            Set
                m_MNumGears = Value
            End Set
        End Property
        Private m_MNumGears As Integer

        <JsonProperty("mOdometerKM")>
        Public Property MOdometerKM() As Double
            Get
                Return m_MOdometerKM
            End Get
            Set
                m_MOdometerKM = Value
            End Set
        End Property
        Private m_MOdometerKM As Double

        <JsonProperty("mAntiLockActive")>
        Public Property MAntiLockActive() As Boolean
            Get
                Return m_MAntiLockActive
            End Get
            Set
                m_MAntiLockActive = Value
            End Set
        End Property
        Private m_MAntiLockActive As Boolean

        <JsonProperty("mLastOpponentCollisionIndex")>
        Public Property MLastOpponentCollisionIndex() As Integer
            Get
                Return m_MLastOpponentCollisionIndex
            End Get
            Set
                m_MLastOpponentCollisionIndex = Value
            End Set
        End Property
        Private m_MLastOpponentCollisionIndex As Integer

        <JsonProperty("mLastOpponentCollisionMagnitude")>
        Public Property MLastOpponentCollisionMagnitude() As Integer
            Get
                Return m_MLastOpponentCollisionMagnitude
            End Get
            Set
                m_MLastOpponentCollisionMagnitude = Value
            End Set
        End Property
        Private m_MLastOpponentCollisionMagnitude As Integer

        <JsonProperty("mBoostActive")>
        Public Property MBoostActive() As Boolean
            Get
                Return m_MBoostActive
            End Get
            Set
                m_MBoostActive = Value
            End Set
        End Property
        Private m_MBoostActive As Boolean

        <JsonProperty("mBoostAmount")>
        Public Property MBoostAmount() As Integer
            Get
                Return m_MBoostAmount
            End Get
            Set
                m_MBoostAmount = Value
            End Set
        End Property
        Private m_MBoostAmount As Integer
    End Class

    Friend Class MotionAndDeviceRelated

        <JsonProperty("mOrientation")>
        Public Property MOrientation() As Double()
            Get
                Return m_MOrientation
            End Get
            Set
                m_MOrientation = Value
            End Set
        End Property
        Private m_MOrientation As Double()

        <JsonProperty("mLocalVelocity")>
        Public Property MLocalVelocity() As Double()
            Get
                Return m_MLocalVelocity
            End Get
            Set
                m_MLocalVelocity = Value
            End Set
        End Property
        Private m_MLocalVelocity As Double()

        <JsonProperty("mWorldVelocity")>
        Public Property MWorldVelocity() As Double()
            Get
                Return m_MWorldVelocity
            End Get
            Set
                m_MWorldVelocity = Value
            End Set
        End Property
        Private m_MWorldVelocity As Double()

        <JsonProperty("mAngularVelocity")>
        Public Property MAngularVelocity() As Double()
            Get
                Return m_MAngularVelocity
            End Get
            Set
                m_MAngularVelocity = Value
            End Set
        End Property
        Private m_MAngularVelocity As Double()

        <JsonProperty("mLocalAcceleration")>
        Public Property MLocalAcceleration() As Double()
            Get
                Return m_MLocalAcceleration
            End Get
            Set
                m_MLocalAcceleration = Value
            End Set
        End Property
        Private m_MLocalAcceleration As Double()

        <JsonProperty("mWorldAcceleration")>
        Public Property MWorldAcceleration() As Double()
            Get
                Return m_MWorldAcceleration
            End Get
            Set
                m_MWorldAcceleration = Value
            End Set
        End Property
        Private m_MWorldAcceleration As Double()

        <JsonProperty("mExtentsCentre")>
        Public Property MExtentsCentre() As Double()
            Get
                Return m_MExtentsCentre
            End Get
            Set
                m_MExtentsCentre = Value
            End Set
        End Property
        Private m_MExtentsCentre As Double()
    End Class

    Friend Class WheelsAndTyres

        <JsonProperty("mTyreFlags")>
        Public Property MTyreFlags() As Integer()
            Get
                Return m_MTyreFlags
            End Get
            Set
                m_MTyreFlags = Value
            End Set
        End Property
        Private m_MTyreFlags As Integer()

        <JsonProperty("mTerrain")>
        Public Property MTerrain() As Integer()
            Get
                Return m_MTerrain
            End Get
            Set
                m_MTerrain = Value
            End Set
        End Property
        Private m_MTerrain As Integer()

        <JsonProperty("mTyreY")>
        Public Property MTyreY() As Double()
            Get
                Return m_MTyreY
            End Get
            Set
                m_MTyreY = Value
            End Set
        End Property
        Private m_MTyreY As Double()

        <JsonProperty("mTyreRPS")>
        Public Property MTyreRPS() As Double()
            Get
                Return m_MTyreRPS
            End Get
            Set
                m_MTyreRPS = Value
            End Set
        End Property
        Private m_MTyreRPS As Double()

        <JsonProperty("mTyreSlipSpeed")>
        Public Property MTyreSlipSpeed() As Double()
            Get
                Return m_MTyreSlipSpeed
            End Get
            Set
                m_MTyreSlipSpeed = Value
            End Set
        End Property
        Private m_MTyreSlipSpeed As Double()

        <JsonProperty("mTyreTemp")>
        Public Property MTyreTemp() As Double()
            Get
                Return m_MTyreTemp
            End Get
            Set
                m_MTyreTemp = Value
            End Set
        End Property
        Private m_MTyreTemp As Double()

        <JsonProperty("mTyreGrip")>
        Public Property MTyreGrip() As Double()
            Get
                Return m_MTyreGrip
            End Get
            Set
                m_MTyreGrip = Value
            End Set
        End Property
        Private m_MTyreGrip As Double()

        <JsonProperty("mTyreHeightAboveGround")>
        Public Property MTyreHeightAboveGround() As Double()
            Get
                Return m_MTyreHeightAboveGround
            End Get
            Set
                m_MTyreHeightAboveGround = Value
            End Set
        End Property
        Private m_MTyreHeightAboveGround As Double()

        <JsonProperty("mTyreLateralStiffness")>
        Public Property MTyreLateralStiffness() As Integer()
            Get
                Return m_MTyreLateralStiffness
            End Get
            Set
                m_MTyreLateralStiffness = Value
            End Set
        End Property
        Private m_MTyreLateralStiffness As Integer()

        <JsonProperty("mTyreWear")>
        Public Property MTyreWear() As Double()
            Get
                Return m_MTyreWear
            End Get
            Set
                m_MTyreWear = Value
            End Set
        End Property
        Private m_MTyreWear As Double()

        <JsonProperty("mBrakeDamage")>
        Public Property MBrakeDamage() As Integer()
            Get
                Return m_MBrakeDamage
            End Get
            Set
                m_MBrakeDamage = Value
            End Set
        End Property
        Private m_MBrakeDamage As Integer()

        <JsonProperty("mSuspensionDamage")>
        Public Property MSuspensionDamage() As Integer()
            Get
                Return m_MSuspensionDamage
            End Get
            Set
                m_MSuspensionDamage = Value
            End Set
        End Property
        Private m_MSuspensionDamage As Integer()

        <JsonProperty("mBrakeTempCelsius")>
        Public Property MBrakeTempCelsius() As Double()
            Get
                Return m_MBrakeTempCelsius
            End Get
            Set
                m_MBrakeTempCelsius = Value
            End Set
        End Property
        Private m_MBrakeTempCelsius As Double()

        <JsonProperty("mTyreTreadTemp")>
        Public Property MTyreTreadTemp() As Double()
            Get
                Return m_MTyreTreadTemp
            End Get
            Set
                m_MTyreTreadTemp = Value
            End Set
        End Property
        Private m_MTyreTreadTemp As Double()

        <JsonProperty("mTyreLayerTemp")>
        Public Property MTyreLayerTemp() As Double()
            Get
                Return m_MTyreLayerTemp
            End Get
            Set
                m_MTyreLayerTemp = Value
            End Set
        End Property
        Private m_MTyreLayerTemp As Double()

        <JsonProperty("mTyreCarcassTemp")>
        Public Property MTyreCarcassTemp() As Double()
            Get
                Return m_MTyreCarcassTemp
            End Get
            Set
                m_MTyreCarcassTemp = Value
            End Set
        End Property
        Private m_MTyreCarcassTemp As Double()

        <JsonProperty("mTyreRimTemp")>
        Public Property MTyreRimTemp() As Double()
            Get
                Return m_MTyreRimTemp
            End Get
            Set
                m_MTyreRimTemp = Value
            End Set
        End Property
        Private m_MTyreRimTemp As Double()

        <JsonProperty("mTyreInternalAirTemp")>
        Public Property MTyreInternalAirTemp() As Double()
            Get
                Return m_MTyreInternalAirTemp
            End Get
            Set
                m_MTyreInternalAirTemp = Value
            End Set
        End Property
        Private m_MTyreInternalAirTemp As Double()
    End Class

    Friend Class CarDamage

        <JsonProperty("mCrashState")>
        Public Property MCrashState() As Integer
            Get
                Return m_MCrashState
            End Get
            Set
                m_MCrashState = Value
            End Set
        End Property
        Private m_MCrashState As Integer

        <JsonProperty("mAeroDamage")>
        Public Property MAeroDamage() As Integer
            Get
                Return m_MAeroDamage
            End Get
            Set
                m_MAeroDamage = Value
            End Set
        End Property
        Private m_MAeroDamage As Integer

        <JsonProperty("mEngineDamage")>
        Public Property MEngineDamage() As Double
            Get
                Return m_MEngineDamage
            End Get
            Set
                m_MEngineDamage = Value
            End Set
        End Property
        Private m_MEngineDamage As Double
    End Class

    Friend Class Weather

        <JsonProperty("mAmbientTemperature")>
        Public Property MAmbientTemperature() As Double
            Get
                Return m_MAmbientTemperature
            End Get
            Set
                m_MAmbientTemperature = Value
            End Set
        End Property
        Private m_MAmbientTemperature As Double

        <JsonProperty("mTrackTemperature")>
        Public Property MTrackTemperature() As Double
            Get
                Return m_MTrackTemperature
            End Get
            Set
                m_MTrackTemperature = Value
            End Set
        End Property
        Private m_MTrackTemperature As Double

        <JsonProperty("mRainDensity")>
        Public Property MRainDensity() As Integer
            Get
                Return m_MRainDensity
            End Get
            Set
                m_MRainDensity = Value
            End Set
        End Property
        Private m_MRainDensity As Integer

        <JsonProperty("mWindSpeed")>
        Public Property MWindSpeed() As Double
            Get
                Return m_MWindSpeed
            End Get
            Set
                m_MWindSpeed = Value
            End Set
        End Property
        Private m_MWindSpeed As Double

        <JsonProperty("mWindDirectionX")>
        Public Property MWindDirectionX() As Double
            Get
                Return m_MWindDirectionX
            End Get
            Set
                m_MWindDirectionX = Value
            End Set
        End Property
        Private m_MWindDirectionX As Double

        <JsonProperty("mWindDirectionY")>
        Public Property MWindDirectionY() As Double
            Get
                Return m_MWindDirectionY
            End Get
            Set
                m_MWindDirectionY = Value
            End Set
        End Property
        Private m_MWindDirectionY As Double

        <JsonProperty("mCloudBrightness")>
        Public Property MCloudBrightness() As Double
            Get
                Return m_MCloudBrightness
            End Get
            Set
                m_MCloudBrightness = Value
            End Set
        End Property
        Private m_MCloudBrightness As Double
    End Class

End Namespace

Namespace Example

    Friend Class SampleResponse1

        <JsonProperty("buildinfo")>
        Public Property Buildinfo() As Buildinfo
            Get
                Return m_Buildinfo
            End Get
            Set
                m_Buildinfo = Value
            End Set
        End Property
        Private m_Buildinfo As Buildinfo

        <JsonProperty("gameStates")>
        Public Property GameStates() As GameStates
            Get
                Return m_GameStates
            End Get
            Set
                m_GameStates = Value
            End Set
        End Property
        Private m_GameStates As GameStates

        <JsonProperty("participants")>
        Public Property Participants() As Participants
            Get
                Return m_Participants
            End Get
            Set
                m_Participants = Value
            End Set
        End Property
        Private m_Participants As Participants

        <JsonProperty("unfilteredInput")>
        Public Property UnfilteredInput() As UnfilteredInput
            Get
                Return m_UnfilteredInput
            End Get
            Set
                m_UnfilteredInput = Value
            End Set
        End Property
        Private m_UnfilteredInput As UnfilteredInput

        <JsonProperty("vehicleInformation")>
        Public Property VehicleInformation() As VehicleInformation
            Get
                Return m_VehicleInformation
            End Get
            Set
                m_VehicleInformation = Value
            End Set
        End Property
        Private m_VehicleInformation As VehicleInformation

        <JsonProperty("eventInformation")>
        Public Property EventInformation() As EventInformation
            Get
                Return m_EventInformation
            End Get
            Set
                m_EventInformation = Value
            End Set
        End Property
        Private m_EventInformation As EventInformation

        <JsonProperty("timings")>
        Public Property Timings() As Timings
            Get
                Return m_Timings
            End Get
            Set
                m_Timings = Value
            End Set
        End Property
        Private m_Timings As Timings

        <JsonProperty("flags")>
        Public Property Flags() As Flags
            Get
                Return m_Flags
            End Get
            Set
                m_Flags = Value
            End Set
        End Property
        Private m_Flags As Flags

        <JsonProperty("pitInfo")>
        Public Property PitInfo() As PitInfo
            Get
                Return m_PitInfo
            End Get
            Set
                m_PitInfo = Value
            End Set
        End Property
        Private m_PitInfo As PitInfo

        <JsonProperty("carState")>
        Public Property CarState() As CarState
            Get
                Return m_CarState
            End Get
            Set
                m_CarState = Value
            End Set
        End Property
        Private m_CarState As CarState

        <JsonProperty("motionAndDeviceRelated")>
        Public Property MotionAndDeviceRelated() As MotionAndDeviceRelated
            Get
                Return m_MotionAndDeviceRelated
            End Get
            Set
                m_MotionAndDeviceRelated = Value
            End Set
        End Property
        Private m_MotionAndDeviceRelated As MotionAndDeviceRelated

        <JsonProperty("wheelsAndTyres")>
        Public Property WheelsAndTyres() As WheelsAndTyres
            Get
                Return m_WheelsAndTyres
            End Get
            Set
                m_WheelsAndTyres = Value
            End Set
        End Property
        Private m_WheelsAndTyres As WheelsAndTyres

        <JsonProperty("carDamage")>
        Public Property CarDamage() As CarDamage
            Get
                Return m_CarDamage
            End Get
            Set
                m_CarDamage = Value
            End Set
        End Property
        Private m_CarDamage As CarDamage

        <JsonProperty("weather")>
        Public Property Weather() As Weather
            Get
                Return m_Weather
            End Get
            Set
                m_Weather = Value
            End Set
        End Property
        Private m_Weather As Weather
    End Class

End Namespace
