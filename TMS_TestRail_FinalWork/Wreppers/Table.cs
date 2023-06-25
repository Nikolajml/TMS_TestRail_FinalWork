using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_TestRail_FinalWork.Wreppers
{
    public class Table
    {
        private UIElement _uiElement;
        private List<TableRow> _rowList = new List<TableRow>();
        private int _columnsCount;

        public Table(IWebDriver? driver, By @by)
        {
            _uiElement = new UIElement(driver, @by);

            _columnsCount = driver.FindElements(By.TagName("col")).Count;
            foreach (var row in _uiElement.FindElements(By.TagName("tr")))
            {
                _rowList.Add(new TableRow(driver, row));
            }
        }

        public int RowCount()
        {
            return _rowList.Count;
        }

        public void Click(int column, int row)
        {

        }
    }
}
