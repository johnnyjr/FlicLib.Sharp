using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"io/flic/lib",
					},
					new Converter<string, Type>[]{
						lookup_io_flic_lib_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_io_flic_lib_mappings;
		static Type lookup_io_flic_lib_package (string klass)
		{
			if (package_io_flic_lib_mappings == null) {
				package_io_flic_lib_mappings = new string[]{
					"io/flic/lib/IFlicLibCallbackInterface$Stub:IO.Flic.Lib.FlicLibCallbackInterfaceStub",
					"io/flic/lib/IFlicLibCallbackInterface$Stub$Proxy:IO.Flic.Lib.FlicLibCallbackInterfaceStub/Proxy",
					"io/flic/lib/IFlicLibInterface$Stub:IO.Flic.Lib.FlicLibInterfaceStub",
					"io/flic/lib/IFlicLibInterface$Stub$Proxy:IO.Flic.Lib.FlicLibInterfaceStub/Proxy",
				};
			}

			return Lookup (package_io_flic_lib_mappings, klass);
		}
	}
}
