using System;
using System.Collections.Generic;
using System.Linq;
using static FormBuilder.Shared.FormControlsMaker;

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
            public bool HavePlaceHolder { get; set; }
            public int Order { get; set; }

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
                result.Add(ControlConst.Get(p));
            });
            return result.ToArray();
        }

        public static ControlType GetControlType(this string input)
        {
            return input.ToLower() switch
            {
                "string" => ControlType.TextBox,
                "select" => ControlType.Select,
                "0" => ControlType.Number,
                "number" => ControlType.Number,
                "date" => ControlType.Date,
                "bool" => ControlType.CheckBox,
                "boolean" => ControlType.CheckBox,
                _ => ControlType.TextBox
            };
        }
    }

    public enum ControlType
    {
        TextBox,
        Select,
        Number,
        Date,
        CheckBox
    }
    public static class ControlConst
    {
        public const string ControlTileString = "#controlTitle";
        public const string ControlNameString = "#contorlName";
        public const string ControlColString = "#controlCol";
        public const string ControlPlaceHolderString = "placeholder=\"#controlTitle را وارد نمایید\"";
        private const string ControlPlaceHolderStringPrivate = "#placeholder";

        public static string Get(FormControl p)
        {
            string result = p.Type switch
            {
                ControlType.TextBox => TextBox,
                ControlType.Number => Number,
                ControlType.Date => Date,
                ControlType.Select => Select,
                ControlType.CheckBox => CheckBox,
                _ => string.Empty,
            };
            if (p.Type == ControlType.TextBox || p.Type == ControlType.Number)
                result = result.Replace(ControlPlaceHolderStringPrivate, p.HavePlaceHolder ? ControlPlaceHolderString : string.Empty);
            return result.Replace(ControlConst.ControlNameString, p.Name)
                        .Replace(ControlConst.ControlTileString, p.Title)
                        .Replace(ControlConst.ControlColString, p.Col.ToString());

        }

        private const string TextBox = @"  
        <div class=""col-lg-#controlCol"">
            <label class=""form-label"">#controlTitle </label>
            <input type=""text"" class=""form-control form-control-lg form-control-solid"" name=""#contorlName""
              #placeholder autocomplete=""off"" [class.is-invalid]=""isControlInvalid('#contorlName')""
              [class.is-valid]=""isControlValid('#contorlName')"" formControlName=""#contorlName"" />
            <div class=""invalid-feedback"" *ngIf=""controlHasError('required', '#contorlName')"">فیلد اجباری می باشد</div>
        </div>
";

        private const string Number = @"  
        <div class=""col-lg-#controlCol"">
            <label class=""form-label"">#controlTitle </label>
            <input type=""number"" class=""form-control form-control-lg form-control-solid"" name=""#contorlName""
              #placeholder autocomplete=""off"" [class.is-invalid]=""isControlInvalid('#contorlName')""
              [class.is-valid]=""isControlValid('#contorlName')"" formControlName=""#contorlName"" />
            <div class=""invalid-feedback"" *ngIf=""controlHasError('required', '#contorlName')"">فیلد اجباری می باشد</div>
        </div>
";

        private const string Select = @"  
        <div class=""col-lg-#controlCol"">
            <label class=""form-label"">#controlTitle </label>
            <select class=""form-control form-control-lg form-control-solid"" name=""#contorlName"" formControlName=""#contorlName"">
              <option value=""{{item.id}}"" *ngFor=""let item of #contorlNameList"">{{item.title}}</option>
            </select>
            <div class=""invalid-feedback"" *ngIf=""controlHasError('required', '#contorlName')"">فیلد اجباری می باشد</div>
        </div>
";
        private const string Date = @"  
        <div class=""col-lg-#controlCol"">
            <label class=""form-label"">#controlTitle </label>
            <input id=""#contorlName"" class=""form-control"" type=""text"" (click)=""#contorlName.toggle()""
              formControlName=""#contorlName"" placeholder=""#controlTitle"" ngbDatepicker autocomplete=""off""
              ##contorlName=""ngbDatepicker"" [class.is-invalid]=""isControlInvalid('#contorlName')"">
              <div class=""invalid-feedback"" *ngIf=""controlHasError('required', '#contorlName')"">فیلد اجباری می باشد</div>
        </div>
";

        public const string CheckBox = @"  
        <div class=""col-lg-#controlCol"">
            <mat-checkbox formControlName=""includedInSanctionedPersonsList"">#controlTitle
            </mat-checkbox>
              <div class=""invalid-feedback"" *ngIf=""controlHasError('required', '#contorlName')"">فیلد اجباری می باشد</div>
        </div>
";
    }
}
