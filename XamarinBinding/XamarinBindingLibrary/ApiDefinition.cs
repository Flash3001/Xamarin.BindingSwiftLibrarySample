using Foundation;

namespace XamarinBindingLibrary
{
	// @interface MyClass : NSObject
	[BaseType(typeof(NSObject), Name = "_TtC11SwiftSample7MyClass")]
	interface MyClass
	{
		// -(NSString * _Nonnull)getValue;
		[Export("getValue")]
		string Value { get; }
	}
}
