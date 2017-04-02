function RegisterInputFormatting() {

    // format proper noun
    $('input.valid-name, input.proper-noun').on('keypress blur', function (event) {
        if (GetSelectedText() == '') {
            ProperNoun($(this));
        }
    });

    // format email address to lowercase
    $('input.email, input.lowercase').on('keypress blur', function (event) {
        if (GetSelectedText() == '') {
            ToLowercase($(this));
        }
    });

    // format phone numbers
    $('input.phone').on('keypress', function (event) {
        if (GetSelectedText() == '') {
            var isNumber = NumbersOnly(event);
            if (isNumber) {
                PhoneFormat($(this), event);
            } else {
                return false;
            }
        }
    });

}

function NumbersOnly(event) {
    try {
        if (window.event) {
            var charCode = window.event.keyCode;
        }
        else if (event) {
            var charCode = event.which;
        }
        else {
            return true;
        }
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            return false;
        }
        return true;
    }
    catch (ex) {
        alert(ex.Description);
    }
}

function ProperNoun($object) {
    if ($object.val() != '') {
        var value = $object.val();
        $object.val(value.replace(/\w\S*/g, function (txt) {
            return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();
        }));
    }
}

function ToLowercase($object) {
    if ($object.val() != '') {
        var value = $object.val();
        $object.val(value.toLowerCase());
    }
}

function PhoneFormat($object, event) {
    var key = event.which || event.keyCode || event.charCode;
    if (key !== 8) {
        if ($object.val() != '') {
            var thisVal = $object.val();
            if (thisVal.length == 3) {
                $object.val(thisVal + '-');
            }
            if (thisVal.length == 7) {
                $object.val(thisVal + '-');
            }
        }
    }
}


//Determine if the value is selected
function GetSelectedText() {
    var selectedText = '';
    if (window.getSelection) {
        selectedText = window.getSelection();
    } else if (document.getSelection) {
        selectedText = document.getSelection();
    } else if (document.selection) {
        selectedText = document.selection.createRange().text;
    }
    return selectedText;
}