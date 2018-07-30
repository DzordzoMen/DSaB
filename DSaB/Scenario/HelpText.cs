using System.Collections.Generic;

namespace DSaB.Scenario {
  public class HelpText {
    public List<HelpTextData> tour{ get; set; }
  }

  public class HelpTextData {
    public string text { get; set; }
    public string item { get; set; } = null;
  }
}
