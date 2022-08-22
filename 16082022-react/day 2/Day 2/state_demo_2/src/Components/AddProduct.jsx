import { Component } from "react";


class AddProduct extends Component
{
    render(){
        return(<div>
            <button onClick={this.props.addNewProduct()}></button>
        </div>)
    }
}