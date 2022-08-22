import { Component } from "react";




class Products extends Component{

    render(){
        return(<div>
            <h1> Total Products :  {this.props.totalProductsForSale} </h1>
            <button onClick={this.props.greetings}>Greet</button>
        </div>)
    }


}

export default Products;