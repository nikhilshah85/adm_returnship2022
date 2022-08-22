import { Component } from "react";



class Project extends Component
{
    render(){
        return(<div>

                <h2> Devloper :  {this.props.devaloper } </h2>
                <h2> Total Member : { this.props.totalMembers }</h2>

                <ul>
                    { this.props.team.map(t =>  <li> { t } </li> ) }
                </ul>

                <button onClick={this.props.greetings} > Greetings </button>
        </div>)
    }
}

export default Project; 