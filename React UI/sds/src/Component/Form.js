import React from 'react';
import 'semantic-ui-css/semantic.min.css';
import "./Form.css";

class MyForm extends React.Component {
    constructor()
    {
        super();

        this.state = {
          EmpNumber : '',
          SoftName : '',
          Version : '',
          Email: '',
          SoftTags : '',
          WebLink : '',
          TLName: '',
          License: '',

        }
        this.handleSubmit = this.handleSubmit.bind(this);
        this.handleChange = this.handleChange.bind(this);
        this.handleTL = this.handleTL.bind(this);
        this.handleOptionChange = this.handleOptionChange.bind(this);
    }

addPostValue(data)
{
  
   data.append('Employee_Code' , this.state.EmpNumber);
    data.append('Software_Name' , this.state.SoftName);
    data.append('Software_Version' , this.state.Version);
    data.append('Employee_EmailID' , this.state.Email);
   data.append('Tags' , this.state.SoftTags);
    data.append('Website_Link' , this.state.WebLink);
    data.append('Team_Lead_ID' , this.state.TLName);
    data.append('Software_License', this.state.License);

   return data;
}

async handleSubmit(e){
  e.preventDefault();
  var data = new FormData();

var result = this.addPostValue(data);

    let response = await fetch('https://localhost:44364/api/SoftwareDownloads', {
 method : 'POST',
 body : result
});

console.log(response.message);
}

handleOptionChange(e) {
  this.setState({
    License: e.target.value
  });

}

 handleChange(e){

  this.setState({
    [e.target.name] : e.target.value
  });


}

handleTL(e){
  this.setState({
    TLName : e.target.value
  });
}

render(){
    return (
        <div>
        <h3 className="ui center aligned header" style={{ margin: "10px" }}>Create a new Software Request </h3>

        <div className="ui green segment" style={{ marginLeft : "20%" , marginRight : "20%", marginTop : "30px" , width  : "60%" , padding : "30px"}} >

        <form onSubmit={this.handleSubmit} className="ui mini form">
        
        <div className="eight wide field">
        <label htmlFor="EmpNumber">Employee No.</label>
        <input id="EmpNumber" name="EmpNumber" value={this.state.EmpNumber}  type="text" onChange={ (e) => this.handleChange(e)}/>
        </div>

        <div className="fields">
        <div className="twelve wide field">
        <label htmlFor="SoftName">Software Name</label>
        <input id="SoftName" name="SoftName" value={this.state.SoftName}  type="text" onChange={ (e) => this.handleChange(e)}/>
        </div>

        <div className="four wide field">
        <label htmlFor="Version">Version </label>
        <input id="Version" name="Version" value={this.state.Version} type="text" onChange={ (e) => this.handleChange(e)} />
        </div>
        </div>


        <div className="field"> 
        <label htmlFor="Email">Employee Email Id</label>
        <input id="Email" name="Email" type="Email" value={this.state.Email} onChange={ (e) => this.handleChange(e)} />
        </div>

        <div className="field">
        <label htmlFor="SoftTags">Software Tags</label>
        <input id="SoftTags" name="SoftTags" value={this.state.SoftTags} type="text" onChange={ (e) => this.handleChange(e)} />
        </div>

        <div className="field">
        <label htmlFor="WebLink"> Website Link</label>
        <input id="WebLink" name="WebLink" type="text" value={this.state.WebLink}  onChange={ (e) => this.handleChange(e)}/>
        </div>

        <div className="field">
      <label>Team Lead Name</label>
      <select value={this.state.value} onChange={this.handleTL}>
        <option value="1536">Anil Kumar Modest</option>
        <option value="1592">Yogesh Parashar</option>
        <option value="1397">Puneet Singhal</option>
        <option value="2437">Rahul Gupta</option>
      </select>
    </div>

        

        <div className="inline fields">
    <label>License</label>
    <div className="field">
      <div className="ui radio checkbox">
        <input type="radio"  value="Free" checked={this.state.License === 'Free'} onChange={this.handleOptionChange}/>
        <label>Free</label>
      </div>
    </div>
    <div className="field">
      <div className="ui radio checkbox">
        <input type="radio"  value="Paid" checked={this.state.License === 'Paid'} onChange={this.handleOptionChange} />
        <label>Paid</label>
      </div>
    </div>
    </div>
    <button>Submit Download Request</button>
      </form> 
</div>

<div className="ui red segment" style={{ marginLeft : "20%" , marginRight : "20%", marginTop : "30px" , width  : "60%" , padding : "30px"}} >

<h4 className="ui center aligned header" style={{ margin: "20px" }}> Team Lead Panel </h4>

<form className="ui mini form">

<div className="inline fields">
    <label>Approval Status</label>
    <div className="field">
      <div className="ui radio checkbox">
        <input type="radio"  value="Approved" />
        <label>Approved</label>
      </div>
    </div>
    <div className="field">
      <div className="ui radio checkbox">
        <input type="radio"  value="Rejected" />
        <label>Rejected</label>
      </div>
    </div>
    </div>

      <div className="field">
    <label>Remarks</label>
    <textarea placeholder="..." rows="3"></textarea>
  </div>

  <button onClick={this.handleSubmit}>Submit Approval</button>
        </form>

      </div>
      <div className="ui red segment" style={{ marginLeft : "20%" , marginRight : "20%", marginTop : "30px" , width  : "60%" , padding : "30px"}} >

<h4 className="ui center aligned header" style={{ margin: "20px" }}> NSD Panel</h4>

<form className="ui mini form">



      <div className="field">
    <label>Download Link </label>
    <textarea placeholder="..." rows="3"></textarea>
  </div>
  <div className="ui checkbox">
      <input type="checkbox" />
      <label>Couldn't find the Download Link</label>
    </div>
    <br/>
  <button>Submit Download Link</button>
        </form>

      </div>
      </div>
    );
}

}


export default MyForm;