using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Esri.ArcGISRuntime.Geometry;
using JetBrains.Annotations;

namespace Esri.ArcGISRuntime.Layers
{
    public interface Layer
    {
#if __ANDROID__
        Com.Esri.Android.Map.Layer Native { get; }
        void SetLayer(Com.Esri.Android.Map.Layer native);
#else
        Layer Native { get; }
        void SetLayer(Layer native);
#endif

        /// <summary>
        /// Gets the default spatial reference.
        /// </summary>
        /// <value>
        /// The default spatial reference.
        /// </value>
        SpatialReference DefaultSpatialReference { get; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary> 
        /// <value>
        /// The display name.
        /// </value>
        string DisplayName { get; set; }

        /// <summary>
        /// Gets the full extent of the layer in it's default spatial reference.
        /// </summary>
        Envelope FullExtent { get; }

        string ID { get; set; }
        Exception InitializationException { get; }

        /// <summary>
        /// Gets or sets the layer visibility.
        /// </summary>
        /// <value>
        /// The visibility
        /// </value>
        bool IsVisible { get; set; }

        /// <summary>
        /// Gets or sets the maximum scale to display this layer at.
        ///             A small number allows the map to display the layer when zooming further in.
        /// </summary>
        /// 
        /// <value>
        /// The maximum scale.
        /// 
        /// </value>
        /// <seealso cref="P:Esri.ArcGISRuntime.Layers.Layer.MinScale"/><seealso cref="P:Esri.ArcGISRuntime.Controls.MapView.MinScale"/><seealso cref="P:Esri.ArcGISRuntime.Controls.MapView.MaxScale"/><exception cref="T:System.ArgumentOutOfRangeException">MaxScale</exception>
        /// <remarks>
        /// 
        /// <para>
        /// A scale is usually referred to as 1:X, where X is the scale specified here.
        ///             This value is the relative scale to the real world, where on inch on the screen is
        ///             X inches in the real world. Note that this is only an approximation and is dependent
        ///             on the map's projection that can add some distortion, as well as the system's
        ///             reported DPI setting which doesn't necessarily match the actual DPI of the screen.
        /// 
        /// </para>
        /// 
        /// <para>
        /// The default value of this property is <see cref="F:System.Double.NaN"/>
        ///             which makes the layer unbounded by any scale.
        /// </para>
        /// 
        /// </remarks>
        double MaxScale { get; set; }

        /// <summary>
        /// Gets or sets the minimum scale to render this layer at.
        ///             A large number allows the map to display the layer when zooming further out.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The minimum scale.
        /// 
        /// </value>
        /// <seealso cref="P:Esri.ArcGISRuntime.Layers.Layer.MaxScale"/><seealso cref="P:Esri.ArcGISRuntime.Controls.MapView.MinScale"/><seealso cref="P:Esri.ArcGISRuntime.Controls.MapView.MaxScale"/><exception cref="T:System.ArgumentOutOfRangeException">MinScale</exception>
        /// <remarks>
        /// 
        /// <para>
        /// A scale is usually referred to as 1:X, where X is the scale specified here.
        ///             This value is the relative scale to the real world, where on inch on the screen is
        ///             X inches in the real world. Note that this is only an approximation and is dependent
        ///             on the map's projection that can add some distortion, as well as the system's
        ///             reported DPI setting which doesn't necessarily match the actual DPI of the screen.
        /// 
        /// </para>
        /// 
        /// <para>
        /// The default value of this property is <see cref="F:System.Double.NaN"/>
        ///             which makes the layer unbounded by any scale.
        /// </para>
        /// 
        /// </remarks>
        double MinScale { get; set; }

        double Opacity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this layer should show
        ///             in a legend
        /// 
        /// </summary>
        bool ShowLegend { get; set; }

        LayerStatus Status { get; set; }

        /// <summary>
        /// Occurs when a property value changes.
        /// 
        /// </summary>
        event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Loads the metadata for this layer based on the current configuration.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Completion Task
        /// </returns>
        /// 
        /// <remarks>
        /// 
        /// <example>
        /// 
        /// <para>
        /// Demonstrates implementing logic which is dependent on the layer collection being initialized.
        /// 
        /// </para>
        /// 
        /// <para>
        /// <img border="0" alt="Code example using the Layer.InitializeAsync Event." src="../media/LayersInitialized.png"/>
        /// </para>
        /// 
        /// <code language="XAML" removeRegionMarkers="true" source="C:\applications\DotNet\Common\SDK\LibRef\WinStore\Samples\LayersInitialized\CSharp\MainPage.xaml"/>
        /// 
        /// <code language="CSHARP" removeRegionMarkers="true" source="C:\applications\DotNet\Common\SDK\LibRef\WinStore\Samples\LayersInitialized\CSharp\MainPage.xaml.cs"/>
        /// 
        /// <code language="VBNET" removeRegionMarkers="true" source="C:\applications\DotNet\Common\SDK\LibRef\WinStore\Samples\LayersInitialized\VBNet\MainPage.xaml.vb"/>
        /// 
        /// </example>
        /// 
        /// </remarks>
        Task InitializeAsync();
    }

    /// <summary>
    /// This is the base class for all geographic data that can be added to the
    ///             <see cref="T:Esri.ArcGISRuntime.Controls.MapView">MapView</see> Control.
    /// 
    /// </summary>
    /// 
    /// <remarks>
    /// 
    /// <para>
    /// A Layer is a representation of geographic data portrayed using symbols and text labels. Multiple
    ///             Layers can be ‘stacked’ on top of each other to enhance the information displayed for making
    ///             meaningful decisions. Layers are displayed visually in the Map Control. Layers are drawn bottom
    ///             to top so the first one in the <see cref="T:Esri.ArcGISRuntime.Layers.LayerCollection">LayerCollection</see>
    ///             is drawn first (on the bottom) and each subsequent layer is drawn on top of it, in the order listed.
    /// </para>
    /// 
    /// <para>
    /// The first Layer with a valid <see cref="T:Esri.ArcGISRuntime.Geometry.SpatialReference">SpatialReference</see>
    ///             defines the <see cref="P:Esri.ArcGISRuntime.Controls.MapView.SpatialReference">Map.SpatialReference</see>.
    /// 
    /// </para>
    /// 
    /// </remarks>
    public abstract class NativeLayer : INotifyPropertyChanged, Layer
    {
#if __ANDROID__
        public Com.Esri.Android.Map.Layer Native { get; private set; }

        public NativeLayer(Com.Esri.Android.Map.Layer native)
        {
            Native = native;
        }

        public void SetLayer(Com.Esri.Android.Map.Layer native)
        {
            Native = native;
        }
#else
        public Layer Native { get; private set; }

        public NativeLayer(Layer native)
        {
            Native = native;
        }

        public void SetLayer(Layer native)
        {
            Native = native;
        }

#endif

        /// <summary>
        /// Gets the default spatial reference.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The default spatial reference.
        /// 
        /// </value>
        public SpatialReference DefaultSpatialReference { get; protected set; }

        /// <summary>
        /// Gets or sets the display name.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The display name.
        /// 
        /// </value>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets the full extent of the layer in it's default spatial reference.
        /// 
        /// </summary>
        public Envelope FullExtent { get; protected set; }

        /// <summary>
        /// Gets or sets an ID associated with this layer.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets the initialization exception.
        /// </summary>
        public Exception InitializationException { get; protected set; }

        /// <summary>
        /// Gets or sets the layer visibility.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The visibility.
        /// 
        /// </value>
        public bool IsVisible
        {
            get;
            set;
        }

        public NativeLayer()
        {

        }

        protected NativeLayer(bool initLayer)
        {
            throw new NotImplementedException();
        }

        protected NativeLayer(long handle)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// Gets or sets the maximum scale to display this layer at.
        ///             A small number allows the map to display the layer when zooming further in.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The maximum scale.
        /// 
        /// </value>
        /// <seealso cref="P:Esri.ArcGISRuntime.Layers.Layer.MinScale"/><seealso cref="P:Esri.ArcGISRuntime.Controls.MapView.MinScale"/><seealso cref="P:Esri.ArcGISRuntime.Controls.MapView.MaxScale"/><exception cref="T:System.ArgumentOutOfRangeException">MaxScale</exception>
        /// <remarks>
        /// 
        /// <para>
        /// A scale is usually referred to as 1:X, where X is the scale specified here.
        ///             This value is the relative scale to the real world, where on inch on the screen is
        ///             X inches in the real world. Note that this is only an approximation and is dependent
        ///             on the map's projection that can add some distortion, as well as the system's
        ///             reported DPI setting which doesn't necessarily match the actual DPI of the screen.
        /// 
        /// </para>
        /// 
        /// <para>
        /// The default value of this property is <see cref="F:System.Double.NaN"/>
        ///             which makes the layer unbounded by any scale.
        /// </para>
        /// 
        /// </remarks>
        public double MaxScale { get; set; }

        /// <summary>
        /// Gets or sets the minimum scale to render this layer at.
        ///             A large number allows the map to display the layer when zooming further out.
        /// 
        /// </summary>
        /// 
        /// <value>
        /// The minimum scale.
        /// 
        /// </value>
        /// <seealso cref="P:Esri.ArcGISRuntime.Layers.Layer.MaxScale"/><seealso cref="P:Esri.ArcGISRuntime.Controls.MapView.MinScale"/><seealso cref="P:Esri.ArcGISRuntime.Controls.MapView.MaxScale"/><exception cref="T:System.ArgumentOutOfRangeException">MinScale</exception>
        /// <remarks>
        /// 
        /// <para>
        /// A scale is usually referred to as 1:X, where X is the scale specified here.
        ///             This value is the relative scale to the real world, where on inch on the screen is
        ///             X inches in the real world. Note that this is only an approximation and is dependent
        ///             on the map's projection that can add some distortion, as well as the system's
        ///             reported DPI setting which doesn't necessarily match the actual DPI of the screen.
        /// 
        /// </para>
        /// 
        /// <para>
        /// The default value of this property is <see cref="F:System.Double.NaN"/>
        ///             which makes the layer unbounded by any scale.
        /// </para>
        /// 
        /// </remarks>
        public double MinScale { get; set; }

        /// <summary>
        /// Gets or sets the opacity.
        /// </summary>
        public double Opacity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this layer should show
        ///             in a legend
        /// 
        /// </summary>
        public bool ShowLegend { get; set; }

        /// <summary>
        /// The Layer's Status, indicating whether it is being/has been initialized,
        ///     or initialization failed.
        /// </summary>
        public LayerStatus Status { get; set; }

        /// <summary>
        /// Occurs when a property value changes.
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Loads the metadata for this layer based on the current configuration.
        /// 
        /// </summary>
        /// 
        /// <returns>
        /// Completion Task
        /// </returns>
        /// 
        /// <remarks>
        /// 
        /// <example>
        /// 
        /// <para>
        /// Demonstrates implementing logic which is dependent on the layer collection being initialized.
        /// 
        /// </para>
        /// 
        /// <para>
        /// <img border="0" alt="Code example using the Layer.InitializeAsync Event." src="../media/LayersInitialized.png"/>
        /// </para>
        /// 
        /// <code language="XAML" removeRegionMarkers="true" source="C:\applications\DotNet\Common\SDK\LibRef\WinStore\Samples\LayersInitialized\CSharp\MainPage.xaml"/>
        /// 
        /// <code language="CSHARP" removeRegionMarkers="true" source="C:\applications\DotNet\Common\SDK\LibRef\WinStore\Samples\LayersInitialized\CSharp\MainPage.xaml.cs"/>
        /// 
        /// <code language="VBNET" removeRegionMarkers="true" source="C:\applications\DotNet\Common\SDK\LibRef\WinStore\Samples\LayersInitialized\VBNet\MainPage.xaml.vb"/>
        /// 
        /// </example>
        /// 
        /// </remarks>
        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// status must be failed - if not throw
        /// </summary>
        /// <param name="err"></param>
        protected void SetLayerInitializationFailed(Exception err)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Status cannot be failed or it will throw. To set Status to LayerStatus.Failed,
        //     call SetLayerInitializationFailed.
        /// </summary>
        /// <param name="status"></param>
        protected void SetLayerStatus(LayerStatus status)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Override this method to initialize any properties and settings prior to using the map.
        /// 
        /// </summary>
        /// 
        /// <returns/>
        internal abstract Task<LayerInitializationInfo> OnInitializeRequestedAsync();


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
