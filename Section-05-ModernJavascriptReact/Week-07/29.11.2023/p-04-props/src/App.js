import './App.css';
import ProductList from './Components/ProductList/ProductList';
import TickTock from './Components/TickTock/TickTock';

function App() {
  const firstName = "Engin Niyazi";
  const lastName = "Ergül";
  const age = 48;
  let products = [
    { id: 1, name: "Iphone 14", desc: "Hoş bir telefon", price: 43000 },
    { id: 2, name: "Iphone 15", desc: "Hoş bir telefon", price: 53000 },
    { id: 3, name: "Iphone 16", desc: "Hoş bir telefon", price: 63000 },
    { id: 4, name: "Iphone 17", desc: "Hoş bir telefon", price: 73000 }
  ];
  return (
    <>
      <div>
        {/* <TickTock firstName={firstName} lastName={lastName} age={age} />
        <TickTock firstName={"Alex de"} lastName={"Souza"} age={47} /> */}
        <ProductList products={products} />
      </div>
    </>
  );
}

export default App;
