## What Is This? ##
ESRI recently announced support is coming for [Xamarin](http://xamarin.com/).  This is a proof of concept demonstrating one way to access the ESRI ArcGIS Runtime from inside a PCL on Xamarin.

## How can I build this?  ##
You need an [ArcGISOnline](https://developers.arcgis.com/en/) account to get the Runtime SDK's.  They are not licensed for distribution and as such are excluded from this repo.  Try to build the solution and you will see the missing files.

## So How Does it Work ##
This method relies on using compiler directives and file linking inside a PCL to pass the native Runtime objects into a core library.

### What's in the Solution? ###
There is a core PCL that contains ESRI PCL models derived from the .NET SDK's public methods.

Then there is a platform library that sets up the views and concrete implementations.  It also has copies of some of the PCL models via file linking.  There are extension methods for converting between the PCL models and the Runtime models.

In the samples directory is an [MVVMCross](https://github.com/MvvmCross/MvvmCross) example.  Notice that Mvx.Android implements both the core PCL library and the Android platform library.  An extern alias is used to keep the namespaces straight.

## Why not just use a shared project? ##
Because I like Resharper and this way seems more friendly to refactoring.

## Wait, that sample project isn't very MVVM! ##
Correct, the purpose here is to demonstrate that the native platform view can be instantiated from within a portable class library, while maximizing code reuse.  Since the ArcGIS runtime and its views have similar concepts across all platforms, I find it helpful to keep common logic and behavior in the PCL so I only have to write it once.


## Who Helped? ##
Credit goes to [Shawn Castrianni](http://code.google.com/p/nettopologysuite) on the Xamarin Forms for the initial work on setting up the binding libraries.  Thanks also go to [MikesCandy](https://github.com/mikescandy/ArcgisXamarinBinding) for compiling the work into a solution that was easy to reference.

## What's left? ##
Everything.  This is just a proof of concept.  I mocked out some of the common ESRI interfaces (Geometry and Layers) but none of them do anything.  If you want to use these in the PCL, you will have to use compiler directives to pass each property between the native and general classes.  I.e.

```cs
public SpatialReference
{
#If __Android
get { return 
_Native.GetSpatialReference;}
#else
get { return
_Native.SpatialReference;}
#endif
}

```

## Licensing ##
Do whatever you want.  If you make any progress though, or find a better method of doing this, please let me know.

