﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SAEReports.Src {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SAEReports.Src.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Inventarios y servicios.
        /// </summary>
        internal static string lblInventariosInv {
            get {
                return ResourceManager.GetString("lblInventariosInv", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Movimientos al inventario.
        /// </summary>
        internal static string lblInventariosMov {
            get {
                return ResourceManager.GetString("lblInventariosMov", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Multialmacén.
        /// </summary>
        internal static string lblInventariosMul {
            get {
                return ResourceManager.GetString("lblInventariosMul", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Detallado.
        /// </summary>
        internal static string lblVentasDetallado {
            get {
                return ResourceManager.GetString("lblVentasDetallado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Resumen.
        /// </summary>
        internal static string lblVentasResumen {
            get {
                return ResourceManager.GetString("lblVentasResumen", resourceCulture);
            }
        }
    }
}
