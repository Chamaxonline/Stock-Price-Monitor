import React from "react";
import { getAllSource } from "../../services/SourceService";

export default class SourceDropDown extends React.Component {
  constructor() {
    super();
    this.state = {
      collection: [],
      value: "",
    };
  }

  componentDidMount() {
    getAllSource()
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
        
        { <select
          className="form-control"
          name="{props.username}"
          onChange={this.onChange}
        >
          <option defaultValue>Select Source</option>
          {this.state.collection.map((item, index) => (
            <option key={item.id} value={item.id}>
              {item.sourceName}
            </option>
          ))}
        </select> }
      </div>
    );
  }
}
