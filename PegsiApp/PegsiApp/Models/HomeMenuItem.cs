using System;
using System.Collections.Generic;
using System.Text;

namespace PegsiApp.Models
{
    public enum MenuItemType
    {
        Participante,
        Browse,
        About,
        Salir
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
