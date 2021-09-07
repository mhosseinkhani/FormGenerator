using System;
using System.Collections.Generic;
using System.Linq;

namespace FormBuilder.Shared
{
    public static class FormControlsMaker
    {
        public class FormControl
        {
            public string Name { get; set; }
            public string Title { get; set; }
            public ControlType Type { get; set; }
            public byte Col { get; set; }
            public byte Row { get; set; }

        }
        public class StringToFormItems
        {
            public static FormControl[] GenerateControls(string[] input)
            {
                return input.ToList().Select(p => new FormControl
                {
                    Type = p.Split(":")[1].GetControlType(),
                    Name = p.Split(":")[0],
                    Title = p.Split(":")[0]
                }).ToArray();
            }
        }
        public static string[] MakeControls(FormControl[] inputs)
        {
            var result = new List<string>();
            inputs.ToList().ForEach(p =>
            {
                switch (p.Type)
                {
                    case ControlType.TextBox:
                        result.Add(ControlConst.TextBox.Replace(ControlConst.ControlNameString,p.Name)
                            .Replace(ControlConst.ControlTileString, p.Title)
                            .Replace(ControlConst.ControlColString, p.Col.ToString()));
                        break;
                    case ControlType.Select:
                        result.Add(ControlConst.Select.Replace(ControlConst.ControlNameString, p.Name)
                            .Replace(ControlConst.ControlTileString, p.Title)
                            .Replace(ControlConst.ControlColString, p.Col.ToString()));
                        break;
                    case ControlType.Number:
                        result.Add(ControlConst.TextBox.Replace(ControlConst.ControlNameString, p.Name)
                            .Replace(ControlConst.ControlTileString, p.Title)
                            .Replace(ControlConst.ControlColString, p.Col.ToString()));
                        break;
                    case ControlType.Date:
                        result.Add(ControlConst.Date.Replace(ControlConst.ControlNameString, p.Name)
                            .Replace(ControlConst.ControlTileString, p.Title)
                            .Replace(ControlConst.ControlColString, p.Col.ToString()));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            });
            return result.ToArray();
        }

       public static ControlType GetControlType(this string input)
        {
            return input.ToLower() switch
            {
                "string"  => ControlType.TextBox,
                "select" => ControlType.Select,
                "number" => ControlType.Number,
                "date" => ControlType.Date,
                _ => ControlType.TextBox
            };
        }
    }

    public enum ControlType
    {
        TextBox,
        Select,
        Number,
        Date
    }
    public static class ControlConst
    {
        public const string ControlTileString = "#controlTitle";
        public const string ControlNameString = "#contorlName";
        public const string ControlColString = "#controlCol";
        public const string TextBox = @"  
        <div class=""col-lg-#controlCol"">
            <label class=""form-label"">#controlTitle </label>
            <input type=""text"" class=""form-control form-control-lg form-control-solid"" name=""#contorlName""
              placeholder=""#controlTitle را وارد نمایید"" autocomplete=""off"" [class.is-invalid]=""isControlInvalid('#contorlName')""
              [class.is-valid]=""isControlValid('#contorlName')"" formControlName=""#contorlName"" />
            <div class=""invalid-feedback"" *ngIf=""controlHasError('required', '#contorlName')"">فیلد اجباری می باشد</div>
        </div>
";

        public const string Number = @"  
        <div class=""col-lg-#controlCol"">
            <label class=""form-label"">#controlTitle </label>
            <input type=""number"" class=""form-control form-control-lg form-control-solid"" name=""#contorlName""
              placeholder=""#controlTitle را وارد نمایید"" autocomplete=""off"" [class.is-invalid]=""isControlInvalid('#contorlName')""
              [class.is-valid]=""isControlValid('#contorlName')"" formControlName=""#contorlName"" />
            <div class=""invalid-feedback"" *ngIf=""controlHasError('required', '#contorlName')"">فیلد اجباری می باشد</div>
        </div>
";

        public const string Select = @"  
        <div class=""col-lg-#controlCol"">
            <label class=""form-label"">#controlTitle </label>
            <select class=""form-control form-control-lg form-control-solid"" name=""#contorlName"" formControlName=""#contorlName"">
              <option value=""{{item.id}}"" *ngFor=""let item of #contorlNameList"">{{item.title}}</option>
            </select>
            <div class=""invalid-feedback"" *ngIf=""controlHasError('required', '#contorlName')"">فیلد اجباری می باشد</div>
        </div>
";
        public const string Date = @"  
        <div class=""col-lg-#controlCol"">
            <label class=""form-label"">#controlTitle </label>
            <input id=""#contorlName"" class=""form-control"" type=""text"" (click)=""#contorlName.toggle()""
              formControlName=""#contorlName"" placeholder=""#controlTitle"" ngbDatepicker autocomplete=""off""
              ##contorlName=""ngbDatepicker"" [class.is-invalid]=""isControlInvalid('#contorlName')"">
              <div class=""invalid-feedback"" *ngIf=""controlHasError('required', '#contorlName')"">فیلد اجباری می باشد</div>
        </div>
";


    }
}
