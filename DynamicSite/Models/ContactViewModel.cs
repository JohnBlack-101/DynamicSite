using System.ComponentModel.DataAnnotations; //Grants access to the annotations for validation

namespace DynamicSite.Models
{
    //If you receive an error when generating a View with this model
    //That requests a primary key, you can add the using statement above
    //and annotate the class with the [Keyless] decorator.
    public class ContactViewModel
    {
        //We can use Data Annotation to add validation to our model.
        //This is useful when we have required fileds or need certain kinds of info.

        [Required(ErrorMessage = "*Name is required")]//Makes the field required
        public string Name { get; set; }

        [Required(ErrorMessage = "*Email is required")]
        [DataType(DataType.EmailAddress)]//Certain formatting is expected (@ symbol, .com, etc.)
        public string Email { get; set; }

        [Required(ErrorMessage = "*Subject is required")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "*Message is required")]
        [DataType(DataType.MultilineText)] //Denotes this field is larger than a standard textbox (<input> => <textarea>)
        public string Message { get; set; }

        //MINI-LAB!
        //Create the CntavtViewModel in your PersonalSite MVC solution.
        //You can copy and paste the properties & data annotations here
        //into that solution. Don't forget the using statement for the annotations!
    }
}
