﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Model.Tablas
{
    [MetadataType(typeof(ProductMetadata))]
    public partial class Product : Ejemplo.Model.Product
    {
        [NotMapped]
        public double SizeInInches {
            get {
                double resultado = 0;
                bool pudoSerConvertido;
                switch (this.SizeUnitMeasureCode)
                { 
                case "CM":
                    pudoSerConvertido = double.TryParse(this.Size, out resultado);
                    if (pudoSerConvertido)
                        resultado /= 2.2;
                    break;
                case "IN":
                    pudoSerConvertido = double.TryParse(this.Size, out resultado);
                    if (pudoSerConvertido)
                        resultado /= 1.0;
                    break;
                }
                return (resultado); } }
    }

    public class ProductMetadata
    {

    }
}
