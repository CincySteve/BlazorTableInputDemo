
namespace BlazorTableInputDemo
    {
    public class TableCell
        {
        public string CSSClass { get; set; } = string.Empty;
        public int Index_Col { get; set; }
        public int Index_Row { get; set; }
        public string Value { get; set; } = string.Empty;

        public TableCell()
            {
            }
        }
    }
