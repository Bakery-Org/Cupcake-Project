using Dapper;
using System.Data;
using Cupcake_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cupcake_Project.Repos
{
    public class IngredientRepo : IIngredientRepo
    {
        private readonly IDbConnection _connection;

        public IngredientRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _connection.Query<Ingredient>("SELECT * FROM Ingredients;");
        }

        public Ingredient GetIngredient(int id)
        {
            return _connection.QuerySingle<Ingredient>("SELECT * FROM Ingredients WHERE id = @id", new { id = id });
        }

        public void InsertIngredient(Ingredient ingredient)
        {
            _connection.Execute("INSERT INTO Ingredients ( id, Name, Description, Unit_of_Measurement, Quantity_In_stock) VALUES (@name, @description, @price, @quantity_in_stock);", 
                new { id = ingredient.ID, name = ingredient.Name, description = ingredient.Description, unit_of_measruemenr = ingredient.Unit_of_Measurement, quantity_in_stock = ingredient.Quantity_in_stock });
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            _connection.Execute("UPDATE Ingredients SET id = @id, name = @name, description = @description, unit_of_measurement = @unit_of_measurement, quantity_in_stock = @quantity_in_stock WHERE ProductID = @id",
                new { id = ingredient.ID, name = ingredient.Name, description = ingredient.Description, unit_of_measurement = ingredient.Unit_of_Measurement, quantity_in_stock = ingredient.Quantity_in_stock });
        }

        public void DeleteProduct(Product product)
        {
            _connection.Execute("DELETE FROM Ingredient WHERE ID = @id;", new { id = product.ID });
        }
    }
}

