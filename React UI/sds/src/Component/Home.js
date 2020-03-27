import React from 'react'
import 'semantic-ui-css/semantic.min.css';
import './HomePage.css'


class HomePage extends React.Component {
    constructor()
    {
        super();
        this.state = {
            searchBar : '',
            loading : true,
            GetData : [],
        }
    }

    componentDidMount() {
        this.GetRequest();
      }

      static renderDatasetsTable(GetData) {
        return (
             <div>
              {GetData.map(Dataset =>
                <div className="DataBox" key={Dataset.ID}>
                  <div className="DataTitle"> {Dataset.Software_Name}</div>
                  <div className="DataVersion">version : {Dataset.Software_Version}</div>
                  <div className="DataWeb">Website : {Dataset.Website_link}</div>    
                <button class="ui fluid button" style={{ backgroundColor : "#2185d0" , color : "white"}}>Get Download link</button>
                </div>
              )}
            </div>
        );
      }


    render()
    {
        let GetResponse = this.state.loading 
        ? <p><em>Loading...</em></p>
        : HomePage.renderDatasetsTable(this.state.GetData);
  
        return (
            <div>
                <h3 className="ui center aligned header" style={{ marginTop: "40px" }}>Search for the Software you need to install </h3>
            
                <div className="ui icon input" style={{ marginLeft : "20%" , marginRight : "20%", marginTop : "30px" , width  : "60%" , padding : "30px"}}>
  <input type="text" placeholder="Search Here For Software "  style={{ width : "90%" , borderRadius : "15px 0px 0px 15px"}}/>
  <button className="ui icon button" style={{ borderRadius : "0px 15px 15px 0px" , backgroundColor : "white" , border : "1px solid rgba(34,36,38,.15)"}}><i aria-hidden="true" className="search icon" style={{ color : "grey"}}></i></button>
</div>

<button className="ui button" style={{ marginLeft : "35%" , marginRight : "35%", marginTop : "30px" , width  : "30%" , padding : "10px"}}>Make a New Request</button>


{GetResponse}

<br/><br/>
            </div>
        );
    }

async GetRequest(){
    const response = await fetch('https://reqres.in/api/unknown');
    const data = await response.json();
   
    this.setState({ GetData : data, loading : false});
}
    

}

export default HomePage;