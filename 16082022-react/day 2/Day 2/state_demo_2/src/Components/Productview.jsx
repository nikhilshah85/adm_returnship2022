import { Component } from "react";

class ProductView extends Component
{
    render(){
        return(<div>
            {/* <h1> Total Products : {this.props.totalProducts() }</h1> */}
                <table>
                    { this.props.pList.map( p => <tr>
                        <td> { p.pId }</td>
                        <td> { p.pName }</td>
                        <td> { p.pCategory }</td>
                        <td> { p.pPrice }</td>
                    </tr>) }
                </table>
        </div>)
    }
}

export default ProductView;