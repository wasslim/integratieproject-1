﻿using System.ComponentModel.DataAnnotations;

namespace PIP.Domain.Flow.Inquiry;

public class ClosedQuestion : Question
{
    [Required (ErrorMessage = "Opties zijn verplicht.")]
    public ICollection<Option> Options { get; set; } = new List<Option>();
}