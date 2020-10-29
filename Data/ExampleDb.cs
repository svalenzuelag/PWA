﻿using Blazor.IndexedDB.Framework;
using Microsoft.JSInterop;
using System.ComponentModel.DataAnnotations;

namespace RecipeApp.Data
{
    public class ExampleDb : IndexedDb
    {
        public ExampleDb(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version) { }
        public IndexedSet<Person> People { get; set; }
    }

    public class Person
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
