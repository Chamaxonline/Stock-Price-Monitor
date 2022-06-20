import "./App.css";
import React from "react";
import TickerDropDown from "./components/Ticker/TickerDropDown";
import SourceDropDown from "./components/Source/SourceDropDown";
import {
  getLastPrices,
  createRandomPrices,
} from "../src/services/PriceService";
import moment from "moment";

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      selectedSource: null,
      selectedTicker: null,
      isAvailable: false,
      priceCollection: [],
      isUpdated: false,
    };
  }

  sourceChage = (value) => {
    this.setState({
      selectedSource: value,
    });
    if (this.state.selectedTicker != null) {
      this.loadPriceList(value, this.state.selectedTicker);
    }
  };

  tickerChage = (value) => {
    this.setState({
      selectedTicker: value,
    });
    this.loadPriceList(this.state.selectedSource, value);
  };
  async loadPriceList(source, ticker) {
    getLastPrices(source, ticker).then((res) =>
      this.setState({ priceCollection: res })
    );
    this.setState({
      isAvailable: true,
    });
  }

  generatePrices = (value) => {
    createRandomPrices().then();
    alert("Success");
    this.setState({ isUpdated: true });
    this.loadPriceList(this.state.selectedSource, this.state.selectedTicker);
  };

  render() {
    return (
      <React.Fragment>
        <hr />
        <div className="container-fluid">
          <div className="row">
            <label className="col-md-1 mb-2">Source: </label>{" "}
            <SourceDropDown onChange={this.sourceChage} />
          </div>
          <div className="row">
            <label className="col-md-1 mb-2">Ticker: </label>{" "}
            <TickerDropDown onChange={this.tickerChage} />
          </div>
          <div className="col-md-3 mb-2">
            {this.state.isAvailable || this.state.isUpdated ? (
              <table className="table">
                <thead className="thead-light">
                  <tr>
                    <th scope="col">Time</th>
                    <th scope="col">Price</th>
                  </tr>
                </thead>
                <tbody>
                  {this.state.priceCollection.map((value, key) => {
                    return (
                      <tr key={key}>
                        <td>
                          {moment(value.time).format("YYYY-MM-DD hh:mm:ss")}
                        </td>
                        <td>
                          {value.priceTag.toLocaleString(undefined, {
                            maximumFractionDigits: 2,
                          })}
                        </td>
                      </tr>
                    );
                  })}
                </tbody>
              </table>
            ) : (
              <label>Select Source and Price to Load Price table</label>
            )}
          </div>

          <div className="col-md-3">
            {this.state.isAvailable ? (
              <>
                <p>If you want to add new Random Price List click the below</p>
                <button
                  className="btn btn-primary"
                  onClick={this.generatePrices}
                >
                  Add Random Prices
                </button>
              </>
            ) : (
              <div></div>
            )}
          </div>
        </div>
      </React.Fragment>
    );
  }
}
export default App;
