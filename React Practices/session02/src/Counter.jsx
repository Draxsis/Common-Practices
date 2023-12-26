import React, { Component } from "react";

class Counter extends Component {
  constructor(props) {
    super(props);
    this.state = {
      count: 0,
    };
  }

  render() {
    return (
      <>
        <div
          style={{ border: "2px solid", margin: "10px 1px", padding: "10px" }}
        >
          <label>{this.props.label} </label>
          <label>{this.props.label2} </label>
          <hr />
          <button style={{ margin: "0px 16px" }} onClick={this.Minus}>
            -
          </button>
          <p1>Count: {this.state.count}</p1>
          <button style={{ margin: "0px 16px" }} onClick={this.Add}>
            +
          </button>
        </div>
      </>
    );
  }

  add = () => {
    this.setState({
      count: this.state.count < 10 ? this.state.count + 1 : this.state.count,
    });
  };

  minus = () => {
    this.setState({
      count: this.state.count > 0 ? this.state.count - 1 : this.state.count,
    });
  };
}

export default Counter;
