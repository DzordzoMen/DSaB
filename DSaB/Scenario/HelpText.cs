using System.Collections.Generic;

namespace DSaB.Scenario {
  public class HelpText {
    public List<HelpTextData> Tour { get; set; }
  }

  public class HelpTextData {
    public string Text { get; set; }
    public string Item { get; set; } = null;
    public string Enemy { get; set; } = null;
  }
}
