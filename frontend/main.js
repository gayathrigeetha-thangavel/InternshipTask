//var httpRequest = new XMLHttpRequest();

const connectionUri = 'mongodb://localhost:27017/api/user'

function addItem() {
    const addNameTextbox = document.getElementById('username');
    const addPasswordTextBox = document.getElementById('password');

    const userName = {
      isComplete: false,
      name: addNameTextbox.value.trim()
    };

    const password = {
        isComplete: false,
        name: addNamePassword.value.trim()
      };
      
    console.log("UN"+addNameTextbox);
    console.log("PASS"+addPasswordTextBox);
  

    fetch(connectionUri, {
      method: 'POST',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
      },
      body: JSON.stringify({addNameTextbox, addPasswordTextBox})
    })
      .then(response => response.json())
      .then(() => {
       // getItems();
        addNameTextbox.value = '';
        addPasswordTextBox.value = '';
      })
      .catch(error => console.error('Unable to add item.', error));
}