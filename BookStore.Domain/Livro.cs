using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Livro
    {
        public Livro()
        {
            this.Autores = new List<Autor>();

        }
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Requirido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Campo Inválido!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Nome Requirido")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Campo Inválido!")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Nome Requirido")]
        [DataType(DataType.Date)] //Informa apenas a data, sem a necessidade de formatação.
        public DateTime DataLancamento{ get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<Autor> Autores { get; set; }
    }
}