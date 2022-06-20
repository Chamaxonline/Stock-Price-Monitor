import React from "react";
import { getAllTicker } from "../../services/TickerService";

export default class TickerDropDown extends React.Component {
  constructor() {
    super();
    this.state = {
      collection: [],
      value: "",
    };
  }

  componentDidMount() {
    getAllTicker()
      .then((res) => this.setState({ collection: res }));
  }
  onChange = (event) => {
    this.setState({ value: event.target.value });
    this.props.onChange(event.target.value);
  };

  render() {
    return (
      <div className="col-sm-2 mb-2">
        <strong></strong>
        <select
          className="form-control"
          name="{props.name}"
          onChange={this.onChange}
        >
          <option defaultValue>Select Ticker</option>
          {this.state.collection.map((item, index) => (
            <option key={item.id} value={item.id}>
              {item.name}
            </option>
          ))}
        </select>
      </div>
    );
  }
}
