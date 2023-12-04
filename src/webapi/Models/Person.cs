﻿using System;
using System.Collections.Generic;

namespace webapi.Models;

public partial class Person
{
    public int Personid { get; set; }

    public string LastName { get; set; } = null!;

    public string? FirstName { get; set; }

    public int? Age { get; set; }
}
