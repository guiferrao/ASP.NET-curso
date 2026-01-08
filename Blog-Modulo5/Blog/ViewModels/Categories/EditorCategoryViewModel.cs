using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Categories
{
    public class EditorCategoryViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatorio")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "este campo deve ter entre 3 e 40 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O slug é obrigatorio")]
        public string Slug { get; set; }
    }
}