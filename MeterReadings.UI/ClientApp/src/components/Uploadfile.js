import React, { Component } from 'react';

export class UploadFile extends Component {
    static displayName = UploadFile.name;

    constructor(props) {
        super(props);
       
    }

 
    render() {
   
        return (
            <div>
           
                <input
                    type="file"
                    ref={(input) => { this.filesInput = input }}
                    name="file"
                    icon='file text outline'
                    iconPosition='left'
                    label='Upload CSV'
                    labelPosition='right'
                    placeholder='UploadCSV...'
                    onChange={this.handleChange}
                />
                </div>
                
        );
    }
     handleChange = async (event) => {
        
        let csv = event.target.files[0];
        let formData = new FormData();
        formData.append('file', csv);
        let options = {
            method: 'POST',
            headers: { "Authorization":"Basic a012b1NqdkQ0bnNJTVdPYWdwMGg6TkFBYTM2OGFjNjEzYTk1N2EzZmEwYzE=" },
            body: formData
        }
        const response =  await fetch(`http://localhost:5000/api/MeterReadings/meter-reading-uploads`, options);
        const data = await response.json();
        console.log(`Here: ${data}`);
        
    }
}