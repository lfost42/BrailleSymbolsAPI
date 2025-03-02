﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Braille.Data.Models.BrailleSymbol;

namespace Braille.Data.Models.Dtos
{
    public class BrailleSymbolDto
    {
        public int Id { get; set; }

        [Required, StringLength(20, ErrorMessage = "The {0} must be atleast {2} and at most {1} characters.", MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public int AsciiCharacterId { get; set; }

        [ForeignKey("AsciiCharacterId")]
        public AsciiCharacter AsciiCharacter { get; set; }

    }
}
