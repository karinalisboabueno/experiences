﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstaBurger.Migrations
{
    public partial class popularCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Normal','Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
                "VALUES('Natural','Lanche feito com ingredientes integrais e naturais')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
