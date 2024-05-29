using Microsoft.AspNetCore.Components;

namespace VSSThreeSyncfusionBlazor.Client.Pages.Accordion
{
    public class Acdatabindingbase : ComponentBase
    {
        protected List<AccordionData> AccordionItems = new List<AccordionData>()
        {
            new AccordionData()
            {
                EmployeeId = 1,
                EmployeeName = "Herma Chepkoech",
                Designation = "Product Manager"

            },

            new AccordionData()
            {
                EmployeeId = 2,
                EmployeeName = "John Callahan",
                Designation = "Team Lead"
            },

            new AccordionData()
            {
                EmployeeId = 3,
                EmployeeName = "Goat Maguire",
                Designation = "Developer"
            },

            new AccordionData()
            {
                EmployeeId = 4,
                EmployeeName = "Honest Pure",
                Designation = "Product Manager"
            }
        };

        protected class AccordionData
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; } = string.Empty;
            public string Designation { get; set; } = string.Empty;
        }
    }
}
