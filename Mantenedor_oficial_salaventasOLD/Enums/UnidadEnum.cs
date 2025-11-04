namespace Mantenedor_oficial_salaventasOLD.Enums
{
    using System.ComponentModel.DataAnnotations;

    namespace Mantenedor_oficial_salaventasOLD.Enums
    {
        /// <summary>
        /// Unidades disponibles en el sistema
        /// El valor numérico corresponde al código de unidad en la base de datos
        /// </summary>
        public enum UnidadEnum
        {
            [Display(Name = "Matriz")]
            MATRIZ = 0,

            [Display(Name = "Central")]
            CENTRAL = 1,

            [Display(Name = "Antofagasta")]
            ANTOFAGASTA = 2,

            [Display(Name = "Copiapó")]
            COPIAPO = 3,

            [Display(Name = "La Serena")]
            LA_SERENA = 4,

            [Display(Name = "Rancagua")]
            RANCAGUA = 6,

            [Display(Name = "Talca")]
            TALCA = 7,

            [Display(Name = "Concepción")]
            CONCEPCION = 8,

            [Display(Name = "Temuco")]
            TEMUCO = 9,

            [Display(Name = "Valdivia")]
            VALDIVIA = 10,

            [Display(Name = "Iquique")]
            IQUIQUE = 11,

            [Display(Name = "Punta Arenas")]
            PUNTA_ARENAS = 12,

            [Display(Name = "Prueba")]
            PRUEBA = 21,

            [Display(Name = "Los Andes")]
            LOS_ANDES = 51,

            [Display(Name = "Quillota")]
            QUILLOTA = 52,

            [Display(Name = "Viña del Mar")]
            VINA_DEL_MAR = 53,

            [Display(Name = "Valparaíso")]
            VALPARAISO = 54,

            [Display(Name = "Quilpué")]
            QUILPUE = 55,

            [Display(Name = "Puerto Montt")]
            PUERTO_MONTT = 101,

            [Display(Name = "Matucana")]
            MATUCANA = 132,

            [Display(Name = "San Diego")]
            SAN_DIEGO = 133,

            [Display(Name = "Puente Alto")]
            PUENTE_ALTO = 135,

            [Display(Name = "Chillán")]
            CHILLAN = 161,

            [Display(Name = "Arica")]
            ARICA = 250
        }
    }
}
