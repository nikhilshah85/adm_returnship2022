import logo from './logo.svg';
import './App.css';
import { Component } from 'react';
import ProductView from './Components/Productview';

//1
class App extends Component
{


//2
constructor(props)
{
  //3
  super(props);

  //4
  this.state = {
    products:[
      {pId:101, pName:'T-Shirt',pCategory:'Cloths',pPrice:1800},
      {pId:102, pName:'T-Shirt',pCategory:'Cloths',pPrice:1800},
      {pId:103, pName:'T-Shirt',pCategory:'Cloths',pPrice:1800},
      {pId:104, pName:'T-Shirt',pCategory:'Cloths',pPrice:1800},
      {pId:105, pName:'T-Shirt',pCategory:'Cloths',pPrice:1800},
      {pId:106, pName:'T-Shirt',pCategory:'Cloths',pPrice:1800}
    ],
    
  }

  //11. Since this funcion is makeing changes to the state variable, React does not allow that by default, 
  //we have to make react aware of that by using the bind function
  this.addNewProduct = this.addNewProduct.bind(this);
}


//6
addNewProduct()
{
//7
  var newP = {pId:107, pName:'T-Shirt',pCategory:'Cloths',pPrice:1800};

  
 //8 add a new local variable, and set it equal to the list from state 
  var newList = this.state.products;

  //9 add a new reord to the local variable
  newList.push(newP);

  //10 set the state variable to local variable
  this.setState({
    products:newList
  })
}

render(){
  return(<div>

    <button onClick={this.addNewProduct}>Add Product</button>


    <hr/>
    <ProductView 
             pList={this.state.products}> </ProductView>
    
  </div>)
}


}

export default App;
