const moneyDisplay = document.getElementById("moneyDisplay");
let money = parseInt(moneyDisplay.innerHTML.split('$').pop());

const symbolDisplay = document.getElementById("symbolDisplay")
symbolDisplay.style.width = `${width * 80}px`;
symbolDisplay.style.height = `${height * 80}px`;

const slots = [];

for (let i = 0; i < (width * height); i++) {
    const slot = document.createElement("img");
    slot.classList.add("slot");
    slot.id = `slot${i}`;
    slot.style.backgroundColor = 'rgba(0, 0, 0, 0)';
    slots.push(slot);
    symbolDisplay.append(slot);
}

const rowCheckboxes = [];

for (let i = 0; i < height; i++) {
    const buyRow = document.createElement("input");
    buyRow.setAttribute("type", "checkbox");
    buyRow.classList.add("buyRow");
    buyRow.id = `buyRow${i}`;
    buyRow.style.top = `${(i - height) * 80}px`;
    buyRow.style.left = `${(i + 1) * -80}px`
    buyRow.isContentEditable = true;
    rowCheckboxes.push(buyRow);
    symbolDisplay.append(buyRow);
}

function generateSymbols() {
    const selectedRows = [];

    for (let i = 0; i < rowCheckboxes.length; i++) {
        if (rowCheckboxes[i].checked) {
            selectedRows.push(i);
        }
    }

    money -= (selectedRows.length * cost);
    moneyDisplay.innerHTML = `$${money}`;

    if (selectedRows.length > 0) {
        $.ajax({
            type: "POST",
            url: $('#UrlGenerateSlotSymbols').val(),
            data: { machineId: machineId, selectedRows: JSON.stringify(selectedRows)},
            dataType: "json",
            success: function (response) {
                const obj = JSON.parse(`${response}`);

                document.getElementById("generateBtn").disabled = true;

                document.getElementById("resultDisplay").innerHTML = "";
                slots.forEach(el => {
                    el.src = `/images/SlotMachine/slotmachinespin.gif`
                    el.style.backgroundColor = 'rgba(0, 0, 0, 0)';
                });

                setTimeout(revealSlots, 500, obj.result);

                setTimeout(function () {
                    //const objDisplay = document.createElement("p");
                    //objDisplay.innerHTML = `object: ${response}<br/>win object: ${obj.wins}`;
                    //document.getElementById("resultDisplay").append(objDisplay);

                    obj.wins.forEach((element) => {
                        const winMsg = document.createElement("p");
                        winMsg.innerHTML = `${element.Message} $${element.Payout}`;
                        document.getElementById("resultDisplay").append(winMsg);

                        slots.slice(element.Index * width, (element.Index + 1) * width).forEach((slot) => {
                            slot.style.backgroundColor = 'rgba(255, 236, 0, 0.5)';
                        });
                    });

                    document.getElementById("generateBtn").disabled = false;

                    money += obj.pay
                    moneyDisplay.innerHTML = `$${money}`;
                }, 500 + (width - 1) * 750)
            },
            error: function (req, status, error) {
                console.log(msg);
            }
        });
    }
    //error message
};

function revealSlots(finalSlots) {
    for (let i = 0; i < width; i++) {
        setTimeout(function (x, sl) {
            for (let j = 0; j < height; j++) {
                let curSlot = x + (width * j);
                slots[curSlot].style.top = "5px";
                slots[curSlot].src = `/images/SlotMachine/${name}/${sl[curSlot]}.png`;
                setTimeout(function (s) { slots[s].style.top = "0px"; }, 100, curSlot);
            }
        }, i * 750, i, finalSlots);
    }
}

const generateBtn = document.getElementById("generateBtn");
generateBtn.addEventListener('click', generateSymbols);