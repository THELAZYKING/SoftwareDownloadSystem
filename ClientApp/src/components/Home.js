import React, { Component } from 'react';
import 'semantic-ui-css/semantic.min.css';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
        <div>

            <h3 className="ui center aligned header" style={{ margin: "10px" }}>Create a new Software Request </h3>

            <form className="ui mini form">
                <div className="inline field">
                    <div className="ui input"><input type="text" placeholder="Employee Code" /></div>
                </div>
            
            <div className="ui green segment" >
                     
                    <div className="twelve wide field">
                        <label>Software Name</label>
                        <div className="ui input"><input type="text" placeholder="Software Name" /></div>
                    </div>
                    <div className="four wide field">
                        <label>Version</label>
                        <div className="ui input"><input type="text" placeholder="Version" /></div>
                    </div>

                    <div class="field">
                        <label>Software Tags</label>
                        <input placeholder="Software Tags" />
                    </div>

                    

                    <div className="twelve wide field">
                        <label>Website Link</label>
                        <div className="ui input"><input type="text" placeholder="Website Link" /></div>
                    </div>
                               

                </div>
            </form>
         </div>
    );
  }
}
