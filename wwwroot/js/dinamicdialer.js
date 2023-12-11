function renderInputFields() {
    var dialerValue = parseInt(document.getElementById('dialer').value);
    var container = document.getElementById('dialerBox');
    container.innerHTML = ''
    for (var i = 0; i < dialerValue; i++) {
        var input = document.createElement('input');
        input.type = 'number';
        input.name = 'dynamicFields[' + i + ']';
        input.value = '0';
        input.min = '0';
        input.max = '1';


        container.appendChild(input);
    }

}