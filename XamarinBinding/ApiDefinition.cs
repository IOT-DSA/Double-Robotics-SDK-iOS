using Foundation;
using ObjCRuntime;

namespace DoubleRobotics
{
	// @protocol DRDoubleDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface DRDoubleDelegate
	{
		// @optional -(void)doubleDidConnect:(DRDouble *)theDouble;
		[Export("doubleDidConnect:")]
		void DoubleDidConnect(DRDouble theDouble);

		// @optional -(void)doubleDidDisconnect:(DRDouble *)theDouble;
		[Export("doubleDidDisconnect:")]
		void DoubleDidDisconnect(DRDouble theDouble);

		// @optional -(void)doubleStatusDidUpdate:(DRDouble *)theDouble;
		[Export("doubleStatusDidUpdate:")]
		void DoubleStatusDidUpdate(DRDouble theDouble);

		// @optional -(void)doubleDriveShouldUpdate:(DRDouble *)theDouble;
		[Export("doubleDriveShouldUpdate:")]
		void DoubleDriveShouldUpdate(DRDouble theDouble);

		// @optional -(void)doubleTravelDataDidUpdate:(DRDouble *)theDouble;
		[Export("doubleTravelDataDidUpdate:")]
		void DoubleTravelDataDidUpdate(DRDouble theDouble);
	}

	// @interface DRDouble : NSObject
	[BaseType(typeof(NSObject))]
	interface DRDouble
	{
		[Wrap("WeakDelegate")]
		DRDoubleDelegate Delegate { get; set; }

		// @property (assign, nonatomic) id<DRDoubleDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) float poleHeightPercent;
		[Export("poleHeightPercent")]
		float PoleHeightPercent { get; }

		// @property (readonly, nonatomic) int kickstandState;
		[Export("kickstandState")]
		int KickstandState { get; }

		// @property (readonly, nonatomic) float batteryPercent;
		[Export("batteryPercent")]
		float BatteryPercent { get; }

		// @property (readonly, nonatomic) BOOL batteryIsFullyCharged;
		[Export("batteryIsFullyCharged")]
		bool BatteryIsFullyCharged { get; }

		// @property (readonly, nonatomic) NSString * firmwareVersion;
		[Export("firmwareVersion")]
		string FirmwareVersion { get; }

		// @property (readonly, nonatomic) float leftEncoderDeltaInches;
		[Export("leftEncoderDeltaInches")]
		float LeftEncoderDeltaInches { get; }

		// @property (readonly, nonatomic) float rightEncoderDeltaInches;
		[Export("rightEncoderDeltaInches")]
		float RightEncoderDeltaInches { get; }

		// @property (readonly, nonatomic) float xDeltaInches;
		[Export("xDeltaInches")]
		float XDeltaInches { get; }

		// @property (readonly, nonatomic) float yDeltaInches;
		[Export("yDeltaInches")]
		float YDeltaInches { get; }

		// @property (readonly, nonatomic) float headingDeltaRadians;
		[Export("headingDeltaRadians")]
		float HeadingDeltaRadians { get; }

		// @property (readonly, nonatomic) NSString * serial;
		[Export("serial")]
		string Serial { get; }

		// +(DRDouble *)sharedDouble;
		[Static]
		[Export("sharedDouble")]
		DRDouble SharedDouble { get; }

		// -(void)drive:(DRDriveDirection)forwardBack turn:(float)leftRight;
		[Export("drive:turn:")]
		void Drive(DRDriveDirection forwardBack, float leftRight);

		// -(void)variableDrive:(float)forwardBack turn:(float)leftRight;
		[Export("variableDrive:turn:")]
		void VariableDrive(float forwardBack, float leftRight);

		// -(void)turnByDegrees:(float)theDegrees;
		[Export("turnByDegrees:")]
		void TurnByDegrees(float theDegrees);

		// -(void)poleUp;
		[Export("poleUp")]
		void PoleUp();

		// -(void)poleDown;
		[Export("poleDown")]
		void PoleDown();

		// -(void)poleStop;
		[Export("poleStop")]
		void PoleStop();

		// -(void)deployKickstands;
		[Export("deployKickstands")]
		void DeployKickstands();

		// -(void)retractKickstands;
		[Export("retractKickstands")]
		void RetractKickstands();

		// -(void)startTravelData;
		[Export("startTravelData")]
		void StartTravelData();

		// -(void)stopTravelData;
		[Export("stopTravelData")]
		void StopTravelData();

		// -(void)requestStatusUpdate;
		[Export("requestStatusUpdate")]
		void RequestStatusUpdate();
	}

}

