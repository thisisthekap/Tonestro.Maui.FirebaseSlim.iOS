using Foundation;
using ObjCRuntime;

namespace Tonestro.Maui.FirebaseSlim.iOS;

[Static]
partial interface Constants
{
	// extern double MauiFirebaseVersionNumber;
	[Field ("MauiFirebaseVersionNumber", "__Internal")]
	double MauiFirebaseVersionNumber { get; }

	// extern const unsigned char[] MauiFirebaseVersionString;
	[Field ("MauiFirebaseVersionString", "__Internal")]
	NSString MauiFirebaseVersionString { get; }
}

// @interface AnalyticsManagerSlim : NSObject
[BaseType (typeof(NSObject))]
interface AnalyticsManagerSlim
{
	// @property (readonly, nonatomic, strong, class) AnalyticsManagerSlim * _Nonnull shared;
	[Static]
	[Export ("shared", ArgumentSemantic.Strong)]
	AnalyticsManagerSlim Shared { get; }

	// -(void)logEvent:(NSString * _Nonnull)name parameters:(NSDictionary<NSString *,id> * _Nonnull)parameters;
	[Export ("logEvent:parameters:")]
	void LogEvent (string name, NSDictionary<NSString, NSObject> parameters);

	// @property (readonly, copy, nonatomic) NSString * _Nonnull appInstanceId;
	[Export ("appInstanceId")]
	string AppInstanceId { get; }

	// -(void)setUserId:(NSString * _Nullable)userId;
	[Export ("setUserId:")]
	void SetUserId ([NullAllowed] string userId);

	// -(void)setUserProperty:(NSString * _Nullable)value forName:(NSString * _Nonnull)name;
	[Export ("setUserProperty:forName:")]
	void SetUserProperty ([NullAllowed] string value, string name);
}

// @interface FirebaseCoreSlim : NSObject
[BaseType (typeof(NSObject))]
interface FirebaseCoreSlim
{
	// @property (readonly, nonatomic, strong, class) FirebaseCoreSlim * _Nonnull shared;
	[Static]
	[Export ("shared", ArgumentSemantic.Strong)]
	FirebaseCoreSlim Shared { get; }

	// -(void)configure;
	[Export ("configure")]
	void Configure ();
}
