﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions options) : base(options) {
        Database.EnsureCreated();
     }

    public DbSet<Todo> Todos => Set<Todo>();
}

public class Todo
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }
    public bool IsComplete { get; set; }
}
