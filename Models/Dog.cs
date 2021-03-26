using System.ComponentModel.DataAnnotations.Schema;

namespace ProjDotNetCoreApi.Models
{
    public class Dog
    {
        #region Propriedades
        
            public int Id { get; set; } 
            public string Name { get; set; }

            public virtual Breed Breed { get; set; }

        #endregion
    }
}