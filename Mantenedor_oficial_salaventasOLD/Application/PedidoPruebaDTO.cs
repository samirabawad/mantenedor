using Mantenedor_oficial_salaventasOLD.Enums;
using System.ComponentModel.DataAnnotations;

namespace Mantenedor_oficial_salaventasOLD.Application
{
    public class PedidoPruebaDTO
    {
        [Required(ErrorMessage = "El ID del pedido es obligatorio")]
        public int IdPedido { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [MaxLength(200)]
        public string Descripcion { get; set; }

        /// <summary>
        /// Estado actual del pedido
        /// </summary>
        [Required]
        public EstadoPedidoEnum Estado { get; set; }

        /// <summary>
        /// Nivel de prioridad del pedido
        /// </summary>
        public PrioridadEnum Prioridad { get; set; } = PrioridadEnum.Media;

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}