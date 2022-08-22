import { Component } from "react";



class Products extends Component
{
    productList  = [
        {pId:101, pName:'Pepsi',pCategory:'Cold-Drink',pPrice:50, pQty:10, pIsInStock:true},
        {pId:102, pName:'Coke',pCategory:'Cold-Drink',pPrice:50, pQty:10, pIsInStock:true},
        {pId:103, pName:'IPhone',pCategory:'Electronics',pPrice:50, pQty:10, pIsInStock:true},
        {pId:104, pName:'Fossil',pCategory:'Watch',pPrice:50, pQty:10, pIsInStock:true},
        {pId:105, pName:'IWatch',pCategory:'Watch',pPrice:50, pQty:10, pIsInStock:true},
        {pId:106, pName:'OGeneral',pCategory:'Electronics',pPrice:50, pQty:10, pIsInStock:true},
        {pId:107, pName:'Air Pods',pCategory:'Electronics',pPrice:50, pQty:10, pIsInStock:true},
        {pId:108, pName:'Latte',pCategory:'Hot-Drink',pPrice:50, pQty:10, pIsInStock:true},
    ]


    render(){
        return(<table>
             { this.productList.map(p =>  <tr>
                <td> {p.pId} </td>
                <td> {p.pName} </td>
                <td> {p.pCategory} </td>
                <td> {p.pPrice} </td>
                <td> {p.pQty} </td>
                <td> {p.pIsInStock} </td>
             </tr> )}
        </table>)
    }


}

export default Products;








