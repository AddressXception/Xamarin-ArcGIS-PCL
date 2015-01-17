using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esri.ArcGISRuntime.Layers
{
    /// <summary>
    /// A value indicating a Layer's status with respect to its initialization.
    /// </summary>
    public enum LayerStatus
    {
        /// <summary>
        /// InitializeAsync has not yet been called.
        /// </summary>
        NotInitialized = 0,

        /// <summary>
        /// Initialization is in progress.
        /// </summary>
        Initializing = 1,

        /// <summary>
        /// InitializeAsync completed, and the layer is initialized.
        /// </summary>
        Initialized = 2,

        /// <summary>
        /// InitializeAsync faulted; layer initialization failed. See Layer.InitializationException
        //     for details.
        /// </summary>
        Failed = 3,
    }
}
