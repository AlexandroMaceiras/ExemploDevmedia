using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ExemploDevmedia.Models
{
    public class Cliente
    {
        /*
         * [HiddenInput(DisplayValue = false)] -> Este atributo só é necessário usar se estiver usando @Html.EditorForModel() nos formulários.
         * @Html.EditorForModel() faz o formulário completo na tela sem precisar escrever NADA baseado no @model da view.
         */
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Idade é obrigatório")]
        public int Idade { get; set; }

        public override bool Equals(object obj)
        {
            return this.Id == ((Cliente)obj).Id;
        }

    }
}